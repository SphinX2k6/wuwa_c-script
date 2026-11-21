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
	// Token: 0x02003D48 RID: 15688
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomLangDeleteItem : GridProxyAbstract<IRoleLangCustomLangSelectInfo>
	{
		// Token: 0x06028307 RID: 164615 RVA: 0x00B4109C File Offset: 0x00B3F29C
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

		// Token: 0x06028308 RID: 164616 RVA: 0x00B41320 File Offset: 0x00B3F520
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x06028309 RID: 164617 RVA: 0x00B41384 File Offset: 0x00B3F584
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

		// Token: 0x0602830A RID: 164618 RVA: 0x00B414F0 File Offset: 0x00B3F6F0
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

		// Token: 0x0602830B RID: 164619 RVA: 0x00B41678 File Offset: 0x00B3F878
		protected bool IsSameAsGlobalLang()
		{
			int languageTypeByAudioCode = LanguageSystem.Instance.GetLanguageTypeByAudioCode(LanguageSystem.Instance.PackageAudio);
			return this.ItemData.LangIndex == languageTypeByAudioCode;
		}

		// Token: 0x0602830C RID: 164620 RVA: 0x00B416A8 File Offset: 0x00B3F8A8
		protected bool ToggleIsEnable()
		{
			return UKuroLauncherLibrary.NeedHotPatch() && !this.IsSameAsGlobalLang() && RoleLangCustomModel.Instance.GetRoleLangType(this.ItemData.RoleId) != this.ItemData.LangIndex && RoleLangCustomModel.Instance.GetDownloadStatus(new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			}) == ELanguageDownloadStatus.Done;
		}

		// Token: 0x0602830D RID: 164621 RVA: 0x00B41723 File Offset: 0x00B3F923
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			if (!this.ToggleIsEnable())
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602830E RID: 164622 RVA: 0x00B41745 File Offset: 0x00B3F945
		private bool ToggleCanChangeState()
		{
			return true;
		}

		// Token: 0x0602830F RID: 164623 RVA: 0x00B41748 File Offset: 0x00B3F948
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<IRoleLangCustomLangSelectInfo, bool> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.ItemData, state == EToggleState.ETT_Checked);
		}

		// Token: 0x06028310 RID: 164624 RVA: 0x00B41764 File Offset: 0x00B3F964
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

		// Token: 0x04015D50 RID: 89424
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomLangSelectInfo, bool> OnToggleStateChangedCallback;

		// Token: 0x04015D51 RID: 89425
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IRoleLangCustomLangSelectInfo, bool> OnToggleSelectedCheck;

		// Token: 0x04015D52 RID: 89426
		public IRoleLangCustomLangSelectInfo ItemData;

		// Token: 0x04015D53 RID: 89427
		[StaticVariableRuleIgnore]
		private static readonly FColor NoResourceColor = FColor.FromHex("#99a4ad");

		// Token: 0x04015D54 RID: 89428
		[StaticVariableRuleIgnore]
		private static readonly FColor DownloadingColor = FColor.FromHex("#dae4e5");

		// Token: 0x04015D55 RID: 89429
		[StaticVariableRuleIgnore]
		private static readonly FColor IsCurrentUsingColor = FColor.FromHex("#79e4b5");

		// Token: 0x02009929 RID: 39209
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0402FC6D RID: 195693
			TogItem,
			// Token: 0x0402FC6E RID: 195694
			TxtLanguageName,
			// Token: 0x0402FC6F RID: 195695
			TxtCvName,
			// Token: 0x0402FC70 RID: 195696
			PanelStateTag,
			// Token: 0x0402FC71 RID: 195697
			SpriteBg,
			// Token: 0x0402FC72 RID: 195698
			TxtStateTitle,
			// Token: 0x0402FC73 RID: 195699
			BtnPlay,
			// Token: 0x0402FC74 RID: 195700
			SpritePlayIcon,
			// Token: 0x0402FC75 RID: 195701
			SpritePauseIcon,
			// Token: 0x0402FC76 RID: 195702
			BtnDownload,
			// Token: 0x0402FC77 RID: 195703
			BtnDownloadProgress,
			// Token: 0x0402FC78 RID: 195704
			SpriteDownloadFill,
			// Token: 0x0402FC79 RID: 195705
			SpriteStarDownloadIcon,
			// Token: 0x0402FC7A RID: 195706
			SpritePauseDownloadIcon,
			// Token: 0x0402FC7B RID: 195707
			TagSpriteNoLoad,
			// Token: 0x0402FC7C RID: 195708
			TagSpriteDownloading,
			// Token: 0x0402FC7D RID: 195709
			TagSpritePause,
			// Token: 0x0402FC7E RID: 195710
			TagSpriteUsing
		}
	}
}
