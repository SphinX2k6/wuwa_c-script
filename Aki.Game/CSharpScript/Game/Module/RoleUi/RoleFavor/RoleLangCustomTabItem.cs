using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleFavor
{
	// Token: 0x02003CAF RID: 15535
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomTabItem : GridProxyAbstract<IRoleLangCustomInfo>
	{
		// Token: 0x06027D1B RID: 163099 RVA: 0x00B264A0 File Offset: 0x00B246A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickedBtnDownload));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedBtnDownloadProgress));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027D1C RID: 163100 RVA: 0x00B2662F File Offset: 0x00B2482F
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06027D1D RID: 163101 RVA: 0x00B2666C File Offset: 0x00B2486C
		public override void Refresh(IRoleLangCustomInfo data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(data.LangIndex);
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(roleLangCustomConfigById.Value.Text);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "VoiceDIY_Dubbing", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
			EToggleState state = (RoleLangCustomModel.Instance.GetRoleLangType(data.RoleId) == data.LangIndex) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(state, false, false, false);
			}
			this.RefreshButton();
		}

		// Token: 0x06027D1E RID: 163102 RVA: 0x00B26704 File Offset: 0x00B24904
		protected bool RefreshButton()
		{
			bool needTick = this.NeedTick;
			RoleLangCustomUpdateManager updateManager = RoleLangCustomModel.Instance.GetUpdateManager();
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			ELanguageDownloadStatus downloadStatus = RoleLangCustomModel.Instance.GetDownloadStatus(info);
			bool flag = downloadStatus == ELanguageDownloadStatus.Done;
			bool flag2 = downloadStatus == ELanguageDownloadStatus.Half;
			bool uiactive = downloadStatus == ELanguageDownloadStatus.None;
			base.GetItem(2).SetUIActive(flag);
			base.GetButton(3).RootUIComp.Get().SetUIActive(flag2);
			base.GetButton(7).RootUIComp.Get().SetUIActive(uiactive);
			if (flag2)
			{
				this.NeedTick = true;
				bool flag3 = updateManager.IsDownloading(info);
				List<int> downloadProgress = updateManager.GetDownloadProgress(info);
				int num = downloadProgress[0];
				int num2 = downloadProgress[1];
				float fillAmount = (num2 == 0) ? 1f : ((float)num / (float)num2);
				base.GetSprite(4).SetFillAmount(fillAmount);
				base.GetSprite(5).SetUIActive(flag3);
				base.GetSprite(6).SetUIActive(!flag3);
			}
			else if (flag)
			{
				this.NeedTick = false;
			}
			return needTick && !this.NeedTick;
		}

		// Token: 0x06027D1F RID: 163103 RVA: 0x00B2682D File Offset: 0x00B24A2D
		public bool OnTick()
		{
			return this.NeedTick && this.RefreshButton();
		}

		// Token: 0x06027D20 RID: 163104 RVA: 0x00B26840 File Offset: 0x00B24A40
		private bool ToggleCanChangeState()
		{
			if (this.CheckScrollActiveCallback != null && !this.CheckScrollActiveCallback())
			{
				return true;
			}
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			return RoleLangCustomModel.Instance.GetDownloadStatus(info) == ELanguageDownloadStatus.Done;
		}

		// Token: 0x06027D21 RID: 163105 RVA: 0x00B2689A File Offset: 0x00B24A9A
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<IRoleLangCustomInfo> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.ItemData);
		}

		// Token: 0x06027D22 RID: 163106 RVA: 0x00B268B4 File Offset: 0x00B24AB4
		private void OnClickedBtnDownload()
		{
			if (RoleLangCustomModel.Instance.CheckPackageAudioDownloading(this.ItemData.LangIndex))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_DownloadingEntireVoice", Array.Empty<object>());
				return;
			}
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			RoleLangCustomModel.Instance.StartDownloading(info);
			this.NeedTick = true;
		}

		// Token: 0x06027D23 RID: 163107 RVA: 0x00B26928 File Offset: 0x00B24B28
		private void OnClickedBtnDownloadProgress()
		{
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			if (RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info))
			{
				RoleLangCustomModel.Instance.PauseDownloading(info);
				return;
			}
			RoleLangCustomModel.Instance.StartDownloading(info);
		}

		// Token: 0x04015B27 RID: 88871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomInfo> OnClickedCallback;

		// Token: 0x04015B28 RID: 88872
		[Nullable(2)]
		public Func<bool> CheckScrollActiveCallback;

		// Token: 0x04015B29 RID: 88873
		public bool NeedTick;

		// Token: 0x04015B2A RID: 88874
		protected IRoleLangCustomInfo ItemData;

		// Token: 0x020098AC RID: 39084
		[NullableContext(0)]
		private enum EToggle
		{
			// Token: 0x0402F9BC RID: 195004
			ToggleItem,
			// Token: 0x0402F9BD RID: 195005
			TxtName,
			// Token: 0x0402F9BE RID: 195006
			PanelCheckState,
			// Token: 0x0402F9BF RID: 195007
			BtnDownloadProgress,
			// Token: 0x0402F9C0 RID: 195008
			SpriteDownloadFill,
			// Token: 0x0402F9C1 RID: 195009
			SpritePauseIcon,
			// Token: 0x0402F9C2 RID: 195010
			SpritePlayIcon,
			// Token: 0x0402F9C3 RID: 195011
			BtnDownload
		}
	}
}
