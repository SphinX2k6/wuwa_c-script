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
	// Token: 0x02004D82 RID: 19842
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleLangCustomLangSelectItem : GridProxyAbstract<IRoleLangCustomLangSelectInfo>
	{
		// Token: 0x060334B8 RID: 210104 RVA: 0x00BF8884 File Offset: 0x00BF6A84
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
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedBtnPlay));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickedBtnDownload));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickedBtnDownloadProgress));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060334B9 RID: 210105 RVA: 0x00BF8B8C File Offset: 0x00BF6D8C
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.ToggleCanChangeState));
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060334BA RID: 210106 RVA: 0x00BF8BE4 File Offset: 0x00BF6DE4
		public override void Refresh(IRoleLangCustomLangSelectInfo data, bool isSelected, int gridIndex)
		{
			this.ItemData = data;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null && levelSequencePlayer.IsPlayingSequence("Finished"))
			{
				this.LevelSequencePlayer.StopSequenceByKey("Finished", false, true);
			}
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
			this.RefreshButtonState();
			if (this.AudioEventHandle != null)
			{
				AudioSystem.Instance.ExecuteAction(this.AudioEventHandle.Value, EAudioActionType.Stop, null);
				this.AudioEventHandle = null;
			}
			if (this.OnToggleSelectedCheck != null)
			{
				this.SetSelected(this.OnToggleSelectedCheck(this.ItemData), false);
			}
		}

		// Token: 0x060334BB RID: 210107 RVA: 0x00BF8D94 File Offset: 0x00BF6F94
		public bool OnTick(float delta)
		{
			if (!this.NeedTick)
			{
				return false;
			}
			this.RefreshButtonState();
			this.RefreshStateTag();
			if (!this.NeedTick)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.PlayOrReplaySequenceByName("Finished", false, null);
				}
			}
			return !this.NeedTick;
		}

		// Token: 0x060334BC RID: 210108 RVA: 0x00BF8DE8 File Offset: 0x00BF6FE8
		public void RefreshStateTag()
		{
			bool flag = RoleLangCustomModel.Instance.GetRoleLangType(this.ItemData.RoleId) == this.ItemData.LangIndex;
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			ELanguageDownloadStatus downloadStatus = RoleLangCustomModel.Instance.GetDownloadStatus(info);
			bool flag2 = downloadStatus == ELanguageDownloadStatus.None;
			bool flag3 = downloadStatus == ELanguageDownloadStatus.Half;
			bool flag4 = flag || flag2 || flag3;
			base.GetItem(3).SetUIActive(flag4);
			if (flag4)
			{
				string key;
				if (flag)
				{
					key = "Label_VoiceDIY_Use";
				}
				else if (flag3)
				{
					key = "Label_VoiceDIY_Downloading";
				}
				else
				{
					key = "Label_VoiceDIY_Not_Downloaded";
				}
				base.GetText(5).ShowTextNew(key);
				base.GetSprite(14).SetUIActive(flag2);
				bool flag5 = false;
				if (flag3)
				{
					flag5 = RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info);
				}
				base.GetSprite(15).SetUIActive(flag3 && flag5);
				base.GetSprite(16).SetUIActive(flag3 && !flag5);
				base.GetSprite(17).SetUIActive(flag);
				if (flag)
				{
					UUISprite sprite = base.GetSprite(4);
					if (sprite == null)
					{
						return;
					}
					sprite.SetColor(RoleLangCustomLangSelectItem.IsCurrentUsingColor);
					return;
				}
				else if (flag2)
				{
					UUISprite sprite2 = base.GetSprite(4);
					if (sprite2 == null)
					{
						return;
					}
					sprite2.SetColor(RoleLangCustomLangSelectItem.NoResourceColor);
					return;
				}
				else if (flag3)
				{
					UUISprite sprite3 = base.GetSprite(4);
					if (sprite3 == null)
					{
						return;
					}
					sprite3.SetColor(RoleLangCustomLangSelectItem.DownloadingColor);
				}
			}
		}

		// Token: 0x060334BD RID: 210109 RVA: 0x00BF8F50 File Offset: 0x00BF7150
		public void RefreshButtonState()
		{
			RoleLangCustomLangPackageInfo info = new RoleLangCustomLangPackageInfo
			{
				RoleId = this.ItemData.RoleId,
				LangIndex = this.ItemData.LangIndex
			};
			ELanguageDownloadStatus downloadStatus = RoleLangCustomModel.Instance.GetDownloadStatus(info);
			bool flag = downloadStatus == ELanguageDownloadStatus.Done;
			bool flag2 = downloadStatus == ELanguageDownloadStatus.None;
			bool flag3 = downloadStatus == ELanguageDownloadStatus.Half;
			base.GetButton(6).RootUIComp.Get().SetUIActive(flag);
			base.GetButton(9).RootUIComp.Get().SetUIActive(flag2);
			base.GetButton(10).RootUIComp.Get().SetUIActive(flag3);
			if (flag)
			{
				this.NeedTick = false;
				Func<IRoleLangCustomLangSelectInfo, bool> checkCurrentIsPlayingCallback = this.CheckCurrentIsPlayingCallback;
				bool flag4 = checkCurrentIsPlayingCallback != null && checkCurrentIsPlayingCallback(this.ItemData);
				base.GetSprite(7).SetUIActive(!flag4);
				base.GetSprite(8).SetUIActive(flag4);
				return;
			}
			if (!flag2 && flag3)
			{
				List<int> downloadProgress = RoleLangCustomModel.Instance.GetDownloadProgress(this.ItemData.RoleId, this.ItemData.LangIndex);
				int num = downloadProgress[0];
				int num2 = downloadProgress[1];
				float fillAmount = (num2 == 0) ? 1f : ((float)num / (float)num2);
				base.GetSprite(11).SetFillAmount(fillAmount);
				bool flag5 = !RoleLangCustomModel.Instance.GetUpdateManager().IsDownloading(info);
				base.GetSprite(12).SetUIActive(flag5);
				base.GetSprite(13).SetUIActive(!flag5);
			}
		}

		// Token: 0x060334BE RID: 210110 RVA: 0x00BF90CB File Offset: 0x00BF72CB
		public void SetSelected(bool isSelected, bool fireEvent = false)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060334BF RID: 210111 RVA: 0x00BF90E4 File Offset: 0x00BF72E4
		public void SetNeedTick(bool needTick)
		{
			this.NeedTick = needTick;
		}

		// Token: 0x060334C0 RID: 210112 RVA: 0x00BF90ED File Offset: 0x00BF72ED
		private bool ToggleCanChangeState()
		{
			return true;
		}

		// Token: 0x060334C1 RID: 210113 RVA: 0x00BF90F0 File Offset: 0x00BF72F0
		private void OnToggleStateChanged(EToggleState state)
		{
			Action<IRoleLangCustomLangSelectInfo> onToggleStateChangedCallback = this.OnToggleStateChangedCallback;
			if (onToggleStateChangedCallback == null)
			{
				return;
			}
			onToggleStateChangedCallback(this.ItemData);
		}

		// Token: 0x060334C2 RID: 210114 RVA: 0x00BF9108 File Offset: 0x00BF7308
		private void OnClickedBtnPlay()
		{
			this.SetSelected(true, true);
			Action<IRoleLangCustomLangSelectInfo> onPlayAudioCallback = this.OnPlayAudioCallback;
			if (onPlayAudioCallback != null)
			{
				onPlayAudioCallback(this.ItemData);
			}
			this.RefreshButtonState();
		}

		// Token: 0x060334C3 RID: 210115 RVA: 0x00BF9130 File Offset: 0x00BF7330
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
			if (!RoleLangCustomModel.Instance.CheckSpaceEnough(info))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VoiceDIY_Tips_OutOfMemory", Array.Empty<object>());
				return;
			}
			RoleLangCustomModel.Instance.StartDownloading(info);
			this.NeedTick = true;
		}

		// Token: 0x060334C4 RID: 210116 RVA: 0x00BF91C8 File Offset: 0x00BF73C8
		private void OnClickedBtnDownloadProgress()
		{
			this.NeedTick = true;
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

		// Token: 0x0401B38A RID: 111498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomLangSelectInfo> OnToggleStateChangedCallback;

		// Token: 0x0401B38B RID: 111499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IRoleLangCustomLangSelectInfo, bool> OnToggleSelectedCheck;

		// Token: 0x0401B38C RID: 111500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IRoleLangCustomLangSelectInfo, bool> CheckCurrentIsPlayingCallback;

		// Token: 0x0401B38D RID: 111501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IRoleLangCustomLangSelectInfo> OnPlayAudioCallback;

		// Token: 0x0401B38E RID: 111502
		public IRoleLangCustomLangSelectInfo ItemData;

		// Token: 0x0401B38F RID: 111503
		public bool NeedTick;

		// Token: 0x0401B390 RID: 111504
		protected int? AudioEventHandle;

		// Token: 0x0401B391 RID: 111505
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B392 RID: 111506
		[StaticVariableRuleIgnore]
		private static readonly FColor NoResourceColor = FColor.FromHex("#99a4ad");

		// Token: 0x0401B393 RID: 111507
		[StaticVariableRuleIgnore]
		private static readonly FColor DownloadingColor = FColor.FromHex("#dae4e5");

		// Token: 0x0401B394 RID: 111508
		[StaticVariableRuleIgnore]
		private static readonly FColor IsCurrentUsingColor = FColor.FromHex("#79e4b5");

		// Token: 0x0200AEFA RID: 44794
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04035262 RID: 217698
			TogItem,
			// Token: 0x04035263 RID: 217699
			TxtLanguageName,
			// Token: 0x04035264 RID: 217700
			TxtCvName,
			// Token: 0x04035265 RID: 217701
			PanelStateTag,
			// Token: 0x04035266 RID: 217702
			SpriteBg,
			// Token: 0x04035267 RID: 217703
			TxtStateTitle,
			// Token: 0x04035268 RID: 217704
			BtnPlay,
			// Token: 0x04035269 RID: 217705
			SpritePlayIcon,
			// Token: 0x0403526A RID: 217706
			SpritePauseIcon,
			// Token: 0x0403526B RID: 217707
			BtnDownload,
			// Token: 0x0403526C RID: 217708
			BtnDownloadProgress,
			// Token: 0x0403526D RID: 217709
			SpriteDownloadFill,
			// Token: 0x0403526E RID: 217710
			SpriteStarDownloadIcon,
			// Token: 0x0403526F RID: 217711
			SpritePauseDownloadIcon,
			// Token: 0x04035270 RID: 217712
			TagSpriteNoLoad,
			// Token: 0x04035271 RID: 217713
			TagSpriteDownloading,
			// Token: 0x04035272 RID: 217714
			TagSpritePause,
			// Token: 0x04035273 RID: 217715
			TagSpriteUsing
		}
	}
}
