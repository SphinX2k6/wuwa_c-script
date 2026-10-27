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
	// Token: 0x02004CFD RID: 19709
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomTabItem : GridProxyAbstract<IRoleLangCustomInfo>
	{
		// Token: 0x06032F40 RID: 208704 RVA: 0x00BE0B98 File Offset: 0x00BDED98
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

		// Token: 0x06032F41 RID: 208705 RVA: 0x00BE0D27 File Offset: 0x00BDEF27
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06032F42 RID: 208706 RVA: 0x00BE0D64 File Offset: 0x00BDEF64
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

		// Token: 0x06032F43 RID: 208707 RVA: 0x00BE0DFC File Offset: 0x00BDEFFC
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

		// Token: 0x06032F44 RID: 208708 RVA: 0x00BE0F25 File Offset: 0x00BDF125
		public bool OnTick()
		{
			return this.NeedTick && this.RefreshButton();
		}

		// Token: 0x06032F45 RID: 208709 RVA: 0x00BE0F38 File Offset: 0x00BDF138
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

		// Token: 0x06032F46 RID: 208710 RVA: 0x00BE0F92 File Offset: 0x00BDF192
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<IRoleLangCustomInfo> onClickedCallback = this.OnClickedCallback;
			if (onClickedCallback == null)
			{
				return;
			}
			onClickedCallback(this.ItemData);
		}

		// Token: 0x06032F47 RID: 208711 RVA: 0x00BE0FAC File Offset: 0x00BDF1AC
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

		// Token: 0x06032F48 RID: 208712 RVA: 0x00BE1020 File Offset: 0x00BDF220
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

		// Token: 0x0401B1A2 RID: 111010
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomInfo> OnClickedCallback;

		// Token: 0x0401B1A3 RID: 111011
		[Nullable(2)]
		public Func<bool> CheckScrollActiveCallback;

		// Token: 0x0401B1A4 RID: 111012
		public bool NeedTick;

		// Token: 0x0401B1A5 RID: 111013
		protected IRoleLangCustomInfo ItemData;

		// Token: 0x0200AE8E RID: 44686
		[NullableContext(0)]
		private enum EToggle
		{
			// Token: 0x04035014 RID: 217108
			ToggleItem,
			// Token: 0x04035015 RID: 217109
			TxtName,
			// Token: 0x04035016 RID: 217110
			PanelCheckState,
			// Token: 0x04035017 RID: 217111
			BtnDownloadProgress,
			// Token: 0x04035018 RID: 217112
			SpriteDownloadFill,
			// Token: 0x04035019 RID: 217113
			SpritePauseIcon,
			// Token: 0x0403501A RID: 217114
			SpritePlayIcon,
			// Token: 0x0403501B RID: 217115
			BtnDownload
		}
	}
}
