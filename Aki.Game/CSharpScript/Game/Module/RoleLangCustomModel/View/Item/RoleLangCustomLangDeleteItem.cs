using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.Update;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleLangCustomModel.View.Item
{
	// Token: 0x02004D7F RID: 19839
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomLangDeleteItem : GridProxyAbstract<IRoleLangCustomLangSelectInfo>
	{
		// Token: 0x0603349A RID: 210074 RVA: 0x00BF7AA0 File Offset: 0x00BF5CA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603349B RID: 210075 RVA: 0x00BF7D24 File Offset: 0x00BF5F24
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x0603349C RID: 210076 RVA: 0x00BF7D88 File Offset: 0x00BF5F88
		public override void Refresh(IRoleLangCustomLangSelectInfo data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			RoleVoiceLanguage? roleLangCustomConfigById = MenuBaseConfig.Instance.GetRoleLangCustomConfigById(data.LangIndex);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleLangCustomConfigById.Value.Text, Array.Empty<object>());
			FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(data.RoleId);
			if (favorRoleInfoConfig != null)
			{
				string item = "";
				if (data.LangIndex == 0)
				{
					item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameCn);
				}
				else if (data.LangIndex == 1)
				{
					item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameEn);
				}
				else if (data.LangIndex == 2)
				{
					item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameJp);
				}
				else if (data.LangIndex == 3)
				{
					item = PublicUtil.Instance.GetConfigTextByKey(favorRoleInfoConfig.Value.CVNameKo);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Role_VoiceDIY_CV", new <>z__ReadOnlySingleElementList<object>(item));
			}
			this.RefreshStateTag();
			base.GetExtendToggle(0).SetSelfInteractive(this.ToggleIsEnable());
			if (!this.ToggleIsEnable())
			{
				base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				return;
			}
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(data), false);
			}
		}

		// Token: 0x0603349D RID: 210077 RVA: 0x00BF7EF4 File Offset: 0x00BF60F4
		public void RefreshStateTag()
		{
			bool flag = RoleLangCustomModel.Instance.GetRoleLangType(this.ItemData.RoleId) == this.ItemData.LangIndex;
			bool flag2 = this.IsSameAsGlobalLang();
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			ELanguageDownloadStatus downloadStatus = RoleLangCustomModel.Instance.GetDownloadStatus(info);
			bool flag3 = downloadStatus == ELanguageDownloadStatus.None;
			bool flag4 = downloadStatus == ELanguageDownloadStatus.Half;
			bool flag5 = flag || flag3 || flag4 || flag2;
			base.GetItem(3).SetUIActive(flag5);
			if (flag5)
			{
				string key;
				if (flag)
				{
					key = "Label_VoiceDIY_Use";
				}
				else if (flag2)
				{
					key = "VoiceDIY_DefaultVoice";
				}
				else if (flag4)
				{
					key = "Label_VoiceDIY_Downloading";
				}
				else
				{
					key = "Label_VoiceDIY_Not_Downloaded";
				}
				base.GetText(5).ShowTextNew(key);
				base.GetSprite(14).SetUIActive(flag3 || flag2);
				bool flag6 = false;
				if (flag4)
				{
					flag6 = RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info);
				}
				base.GetSprite(15).SetUIActive(flag4 && flag6);
				base.GetSprite(16).SetUIActive(flag4 && !flag6);
				base.GetSprite(17).SetUIActive(flag);
				if (flag)
				{
					UUISprite sprite = base.GetSprite(4);
					if (sprite == null)
					{
						return;
					}
					sprite.SetColor(RoleLangCustomLangDeleteItem.IsCurrentUsingColor);
					return;
				}
				else if (flag3 || flag2)
				{
					UUISprite sprite2 = base.GetSprite(4);
					if (sprite2 == null)
					{
						return;
					}
					sprite2.SetColor(RoleLangCustomLangDeleteItem.NoResourceColor);
					return;
				}
				else if (flag4)
				{
					UUISprite sprite3 = base.GetSprite(4);
					if (sprite3 == null)
					{
						return;
					}
					sprite3.SetColor(RoleLangCustomLangDeleteItem.DownloadingColor);
				}
			}
		}

		// Token: 0x0603349E RID: 210078 RVA: 0x00BF807C File Offset: 0x00BF627C
		protected bool IsSameAsGlobalLang()
		{
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			return this.ItemData.LangIndex == languageTypeByAudioCode;
		}

		// Token: 0x0603349F RID: 210079 RVA: 0x00BF80AC File Offset: 0x00BF62AC
		protected bool ToggleIsEnable()
		{
			return UKuroLauncherLibrary.NeedHotPatch() && !this.IsSameAsGlobalLang() && RoleLangCustomModel.Instance.GetRoleLangType(this.ItemData.RoleId) != this.ItemData.LangIndex && RoleLangCustomModel.Instance.GetDownloadStatus(new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			}) == ELanguageDownloadStatus.Done;
		}

		// Token: 0x060334A0 RID: 210080 RVA: 0x00BF8127 File Offset: 0x00BF6327
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			if (!this.ToggleIsEnable())
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060334A1 RID: 210081 RVA: 0x00BF8149 File Offset: 0x00BF6349
		private bool ToggleCanChangeState()
		{
			return true;
		}

		// Token: 0x060334A2 RID: 210082 RVA: 0x00BF814C File Offset: 0x00BF634C
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<IRoleLangCustomLangSelectInfo, bool> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.ItemData, state == EToggleState.ETT_Checked);
		}

		// Token: 0x060334A3 RID: 210083 RVA: 0x00BF8168 File Offset: 0x00BF6368
		private void OnUndeterminedClicked()
		{
			bool flag = RoleLangCustomModel.Instance.GetRoleLangType(this.ItemData.RoleId) == this.ItemData.LangIndex;
			bool flag2 = this.IsSameAsGlobalLang();
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			bool flag3 = RoleLangCustomModel.Instance.GetDownloadStatus(info) == ELanguageDownloadStatus.None;
			string textId = string.Empty;
			if (flag)
			{
				textId = "VoiceDIY_Tips_CannotDelete_Inuse";
			}
			else if (flag2)
			{
				textId = "VoiceDIY_Tips_CannotDelete_DefaultVoice";
			}
			else if (flag3)
			{
				textId = "VoiceDIY_Tips_CannotDelete_NotDownloaded";
			}
			ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
		}

		// Token: 0x0401B37D RID: 111485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomLangSelectInfo, bool> OnToggleStateChangedCallback;

		// Token: 0x0401B37E RID: 111486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IRoleLangCustomLangSelectInfo, bool> OnToggleSelectedCheck;

		// Token: 0x0401B37F RID: 111487
		public IRoleLangCustomLangSelectInfo ItemData;

		// Token: 0x0401B380 RID: 111488
		[StaticVariableRuleIgnore]
		private static readonly FColor NoResourceColor = FColor.FromHex("#99a4ad");

		// Token: 0x0401B381 RID: 111489
		[StaticVariableRuleIgnore]
		private static readonly FColor DownloadingColor = FColor.FromHex("#dae4e5");

		// Token: 0x0401B382 RID: 111490
		[StaticVariableRuleIgnore]
		private static readonly FColor IsCurrentUsingColor = FColor.FromHex("#79e4b5");

		// Token: 0x0200AEF5 RID: 44789
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04035239 RID: 217657
			TogItem,
			// Token: 0x0403523A RID: 217658
			TxtLanguageName,
			// Token: 0x0403523B RID: 217659
			TxtCvName,
			// Token: 0x0403523C RID: 217660
			PanelStateTag,
			// Token: 0x0403523D RID: 217661
			SpriteBg,
			// Token: 0x0403523E RID: 217662
			TxtStateTitle,
			// Token: 0x0403523F RID: 217663
			BtnPlay,
			// Token: 0x04035240 RID: 217664
			SpritePlayIcon,
			// Token: 0x04035241 RID: 217665
			SpritePauseIcon,
			// Token: 0x04035242 RID: 217666
			BtnDownload,
			// Token: 0x04035243 RID: 217667
			BtnDownloadProgress,
			// Token: 0x04035244 RID: 217668
			SpriteDownloadFill,
			// Token: 0x04035245 RID: 217669
			SpriteStarDownloadIcon,
			// Token: 0x04035246 RID: 217670
			SpritePauseDownloadIcon,
			// Token: 0x04035247 RID: 217671
			TagSpriteNoLoad,
			// Token: 0x04035248 RID: 217672
			TagSpriteDownloading,
			// Token: 0x04035249 RID: 217673
			TagSpritePause,
			// Token: 0x0403524A RID: 217674
			TagSpriteUsing
		}
	}
}
