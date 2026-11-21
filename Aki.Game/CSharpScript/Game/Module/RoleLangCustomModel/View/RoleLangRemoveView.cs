using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleLangCustomModel.View.Item;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View
{
	// Token: 0x02003D46 RID: 15686
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangRemoveView : UiViewBase
	{
		// Token: 0x060282F2 RID: 164594 RVA: 0x00B408A6 File Offset: 0x00B3EAA6
		public RoleLangRemoveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060282F3 RID: 164595 RVA: 0x00B408C4 File Offset: 0x00B3EAC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtnBackB));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedBtnConfirmB));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedBtnBackB));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060282F4 RID: 164596 RVA: 0x00B40A58 File Offset: 0x00B3EC58
		protected override void OnStart()
		{
			IRoleLangCustomDeleteInfo roleLangCustomDeleteInfo = this.OpenParam as IRoleLangCustomDeleteInfo;
			this.RoleId = roleLangCustomDeleteInfo.RoleId;
			this.CloseCallback = roleLangCustomDeleteInfo.CloseCallback;
			this.ClickedDeleteCallback = roleLangCustomDeleteInfo.RefreshCallback;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(this.RoleId);
			if (RoleModel.Instance.IsMainRole(this.RoleId))
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(FunctionModel.Instance.GetPlayerName() ?? "", true);
				}
			}
			else
			{
				UUIText text2 = base.GetText(1);
				if (text2 != null)
				{
					text2.ShowTextNew(roleConfig.Value.Name);
				}
			}
			this.VoiceScroll = new GenericScrollViewNew<RoleLangCustomLangDeleteItem, IRoleLangCustomLangSelectInfo>(base.GetScrollViewWithScrollbar(2), new Func<RoleLangCustomLangDeleteItem>(this.CreateVoiceActingItem), null, false, null);
			this.RefreshVoiceList();
		}

		// Token: 0x060282F5 RID: 164597 RVA: 0x00B40B28 File Offset: 0x00B3ED28
		protected override void OnBeforeHide()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x060282F6 RID: 164598 RVA: 0x00B40B3A File Offset: 0x00B3ED3A
		protected override void OnBeforeDestroy()
		{
			this.StopCurrentAudioEvent();
		}

		// Token: 0x060282F7 RID: 164599 RVA: 0x00B40B44 File Offset: 0x00B3ED44
		protected void RefreshVoiceList()
		{
			List<int> allLanguageTypeForAudio = LanguageUpdateManager.Instance.GetAllLanguageTypeForAudio();
			allLanguageTypeForAudio.Sort((int a, int b) => a - b);
			List<IRoleLangCustomLangSelectInfo> list = new List<IRoleLangCustomLangSelectInfo>();
			foreach (int langIndex in allLanguageTypeForAudio)
			{
				list.Add(new RoleLangCustomLangSelectInfo
				{
					RoleId = this.RoleId,
					LangIndex = langIndex
				});
			}
			this.StopCurrentAudioEvent();
			this.CurrentIsPlayingInfo = null;
			this.VoiceScroll.RefreshByData(list, null, false);
			this.RefreshButton();
		}

		// Token: 0x060282F8 RID: 164600 RVA: 0x00B40C00 File Offset: 0x00B3EE00
		protected void RefreshButton()
		{
			base.GetButton(5).SetSelfInteractive(this.CurSelectedSet.Count > 0);
		}

		// Token: 0x060282F9 RID: 164601 RVA: 0x00B40C1C File Offset: 0x00B3EE1C
		protected void StopCurrentAudioEvent()
		{
			if (!string.IsNullOrEmpty(this.OldAudioCode))
			{
				string roleLangStateGroup = RoleConfig.Instance.GetRoleLangStateGroup(this.OldCodeRoleId.Value);
				AudioSystem.Instance.SetState(roleLangStateGroup, this.OldAudioCode, false);
			}
			if (this.PlayAudioHandle != null && this.PlayAudioHandle.Value != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlayAudioHandle.Value, EAudioActionType.Stop, null);
			}
			this.PlayAudioHandle = null;
			this.OldAudioCode = null;
			this.OldCodeRoleId = null;
		}

		// Token: 0x060282FA RID: 164602 RVA: 0x00B40CB6 File Offset: 0x00B3EEB6
		private void OnClickedBtnBackB()
		{
			base.CloseMe(null);
		}

		// Token: 0x060282FB RID: 164603 RVA: 0x00B40CC0 File Offset: 0x00B3EEC0
		private void OnClickedBtnConfirmB()
		{
			if (this.CurSelectedSet.Count == 0)
			{
				return;
			}
			List<IRoleLangCustomLangPackageInfo> list = new List<IRoleLangCustomLangPackageInfo>();
			foreach (int num in this.CurSelectedSet)
			{
				if (RoleLangCustomModel.Instance.CheckPackageAudioDownloading(num))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_CannotDeleteTips", Array.Empty<object>());
					return;
				}
				list.Add(new RoleLangCustomLangPackageInfo
				{
					RoleId = this.RoleId,
					LangIndex = num
				});
			}
			RoleLangCustomModel.Instance.GetUpdateManager().DeletePackage(list);
			ScrollingTipsController.Instance.ShowTipsByTextId("Notice_VoiceDIY_Delete_Success", Array.Empty<object>());
			this.CurSelectedSet.Clear();
			this.RefreshVoiceList();
			Action clickedDeleteCallback = this.ClickedDeleteCallback;
			if (clickedDeleteCallback == null)
			{
				return;
			}
			clickedDeleteCallback();
		}

		// Token: 0x060282FC RID: 164604 RVA: 0x00B40DA8 File Offset: 0x00B3EFA8
		private RoleLangCustomLangDeleteItem CreateVoiceActingItem()
		{
			return new RoleLangCustomLangDeleteItem
			{
				OnToggleStateChangedCallback = new Action<IRoleLangCustomLangSelectInfo, bool>(this.OnVoiceItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<IRoleLangCustomLangSelectInfo, bool>(this.CheckVoiceSelectedCallback)
			};
		}

		// Token: 0x060282FD RID: 164605 RVA: 0x00B40DD4 File Offset: 0x00B3EFD4
		private void OnVoiceItemToggleStateChanged(IRoleLangCustomLangSelectInfo data, bool isSelected)
		{
			if (isSelected)
			{
				this.CurSelectedSet.Add(data.LangIndex);
			}
			else
			{
				this.CurSelectedSet.Remove(data.LangIndex);
			}
			foreach (RoleLangCustomLangDeleteItem roleLangCustomLangDeleteItem in this.VoiceScroll.GetScrollItemList())
			{
				roleLangCustomLangDeleteItem.SetSelected(this.CheckVoiceSelectedCallback(roleLangCustomLangDeleteItem.ItemData), false);
			}
			this.RefreshButton();
		}

		// Token: 0x060282FE RID: 164606 RVA: 0x00B40E68 File Offset: 0x00B3F068
		private bool CheckVoiceSelectedCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.CurSelectedSet.Contains(data.LangIndex);
		}

		// Token: 0x04015D42 RID: 89410
		protected int RoleId;

		// Token: 0x04015D43 RID: 89411
		[Nullable(2)]
		protected Action CloseCallback;

		// Token: 0x04015D44 RID: 89412
		[Nullable(2)]
		protected Action ClickedDeleteCallback;

		// Token: 0x04015D45 RID: 89413
		protected GenericScrollViewNew<RoleLangCustomLangDeleteItem, IRoleLangCustomLangSelectInfo> VoiceScroll;

		// Token: 0x04015D46 RID: 89414
		protected HashSet<int> CurSelectedSet = new HashSet<int>();

		// Token: 0x04015D47 RID: 89415
		[Nullable(2)]
		protected IRoleLangCustomLangSelectInfo CurrentIsPlayingInfo;

		// Token: 0x04015D48 RID: 89416
		protected int? PlayAudioHandle;

		// Token: 0x04015D49 RID: 89417
		[Nullable(2)]
		protected string OldAudioCode;

		// Token: 0x04015D4A RID: 89418
		protected int? OldCodeRoleId;

		// Token: 0x04015D4B RID: 89419
		protected bool IsNormalEnd = true;

		// Token: 0x02009926 RID: 39206
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402FC5D RID: 195677
			BtnBackB,
			// Token: 0x0402FC5E RID: 195678
			TxtTitle,
			// Token: 0x0402FC5F RID: 195679
			VoiceActingItemScroll,
			// Token: 0x0402FC60 RID: 195680
			VoiceActingItem,
			// Token: 0x0402FC61 RID: 195681
			TxtDesc,
			// Token: 0x0402FC62 RID: 195682
			BtnConfirmB,
			// Token: 0x0402FC63 RID: 195683
			BtnCloseAll
		}
	}
}
