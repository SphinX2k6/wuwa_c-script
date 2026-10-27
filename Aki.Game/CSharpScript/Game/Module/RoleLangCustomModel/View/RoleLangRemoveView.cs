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
	// Token: 0x02004D7D RID: 19837
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleLangRemoveView : UiViewBase
	{
		// Token: 0x06033485 RID: 210053 RVA: 0x00BF72CE File Offset: 0x00BF54CE
		public RoleLangRemoveView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033486 RID: 210054 RVA: 0x00BF72EC File Offset: 0x00BF54EC
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

		// Token: 0x06033487 RID: 210055 RVA: 0x00BF7480 File Offset: 0x00BF5680
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

		// Token: 0x06033488 RID: 210056 RVA: 0x00BF7550 File Offset: 0x00BF5750
		protected override void OnBeforeHide()
		{
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06033489 RID: 210057 RVA: 0x00BF7562 File Offset: 0x00BF5762
		protected override void OnBeforeDestroy()
		{
			this.StopCurrentAudioEvent();
		}

		// Token: 0x0603348A RID: 210058 RVA: 0x00BF756C File Offset: 0x00BF576C
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

		// Token: 0x0603348B RID: 210059 RVA: 0x00BF7628 File Offset: 0x00BF5828
		protected void RefreshButton()
		{
			base.GetButton(5).SetSelfInteractive(this.CurSelectedSet.Count > 0);
		}

		// Token: 0x0603348C RID: 210060 RVA: 0x00BF7644 File Offset: 0x00BF5844
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

		// Token: 0x0603348D RID: 210061 RVA: 0x00BF76DE File Offset: 0x00BF58DE
		private void OnClickedBtnBackB()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603348E RID: 210062 RVA: 0x00BF76E8 File Offset: 0x00BF58E8
		private void OnClickedBtnConfirmB()
		{
			if (this.CurSelectedSet.Count == 0)
			{
				return;
			}
			List<IRoleLangCustomLangPackageInfo> list = new List<IRoleLangCustomLangPackageInfo>();
			foreach (int langIndex in this.CurSelectedSet)
			{
				list.Add(new RoleLangCustomLangPackageInfo
				{
					RoleId = this.RoleId,
					LangIndex = langIndex
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

		// Token: 0x0603348F RID: 210063 RVA: 0x00BF77AC File Offset: 0x00BF59AC
		private RoleLangCustomLangDeleteItem CreateVoiceActingItem()
		{
			return new RoleLangCustomLangDeleteItem
			{
				OnToggleStateChangedCallback = new Action<IRoleLangCustomLangSelectInfo, bool>(this.OnVoiceItemToggleStateChanged),
				OnToggleSelectedCheck = new Func<IRoleLangCustomLangSelectInfo, bool>(this.CheckVoiceSelectedCallback)
			};
		}

		// Token: 0x06033490 RID: 210064 RVA: 0x00BF77D8 File Offset: 0x00BF59D8
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

		// Token: 0x06033491 RID: 210065 RVA: 0x00BF786C File Offset: 0x00BF5A6C
		private bool CheckVoiceSelectedCallback(IRoleLangCustomLangSelectInfo data)
		{
			return this.CurSelectedSet.Contains(data.LangIndex);
		}

		// Token: 0x0401B36F RID: 111471
		protected int RoleId;

		// Token: 0x0401B370 RID: 111472
		[Nullable(2)]
		protected Action CloseCallback;

		// Token: 0x0401B371 RID: 111473
		[Nullable(2)]
		protected Action ClickedDeleteCallback;

		// Token: 0x0401B372 RID: 111474
		protected GenericScrollViewNew<RoleLangCustomLangDeleteItem, IRoleLangCustomLangSelectInfo> VoiceScroll;

		// Token: 0x0401B373 RID: 111475
		protected HashSet<int> CurSelectedSet = new HashSet<int>();

		// Token: 0x0401B374 RID: 111476
		[Nullable(2)]
		protected IRoleLangCustomLangSelectInfo CurrentIsPlayingInfo;

		// Token: 0x0401B375 RID: 111477
		protected int? PlayAudioHandle;

		// Token: 0x0401B376 RID: 111478
		[Nullable(2)]
		protected string OldAudioCode;

		// Token: 0x0401B377 RID: 111479
		protected int? OldCodeRoleId;

		// Token: 0x0401B378 RID: 111480
		protected bool IsNormalEnd = true;

		// Token: 0x0200AEF2 RID: 44786
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04035229 RID: 217641
			BtnBackB,
			// Token: 0x0403522A RID: 217642
			TxtTitle,
			// Token: 0x0403522B RID: 217643
			VoiceActingItemScroll,
			// Token: 0x0403522C RID: 217644
			VoiceActingItem,
			// Token: 0x0403522D RID: 217645
			TxtDesc,
			// Token: 0x0403522E RID: 217646
			BtnConfirmB,
			// Token: 0x0403522F RID: 217647
			BtnCloseAll
		}
	}
}
