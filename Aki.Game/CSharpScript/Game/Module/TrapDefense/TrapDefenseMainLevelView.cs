using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A60 RID: 14944
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainLevelView : UiViewBase
	{
		// Token: 0x0602667D RID: 157309 RVA: 0x00AC1F40 File Offset: 0x00AC0140
		public TrapDefenseMainLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602667E RID: 157310 RVA: 0x00AC1F5C File Offset: 0x00AC015C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBtnKeyboardSet));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnSave));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602667F RID: 157311 RVA: 0x00AC2130 File Offset: 0x00AC0330
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMainLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026680 RID: 157312 RVA: 0x00AC2173 File Offset: 0x00AC0373
		protected override void OnStart()
		{
			this.InitData();
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseMainLevelViewOpen, true);
		}

		// Token: 0x06026681 RID: 157313 RVA: 0x00AC218C File Offset: 0x00AC038C
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06026682 RID: 157314 RVA: 0x00AC218E File Offset: 0x00AC038E
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06026683 RID: 157315 RVA: 0x00AC2190 File Offset: 0x00AC0390
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06026684 RID: 157316 RVA: 0x00AC2198 File Offset: 0x00AC0398
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseMainLevelViewOpen, false);
		}

		// Token: 0x06026685 RID: 157317 RVA: 0x00AC21AB File Offset: 0x00AC03AB
		protected override void OnBeforeHide()
		{
			this.ViewModel.Model.LevelModeData.SaveCacheReachOpenTimeLevels();
		}

		// Token: 0x06026686 RID: 157318 RVA: 0x00AC21C2 File Offset: 0x00AC03C2
		public void OnClickBtnKeyboardSet()
		{
			this.ViewModel.Model.OpenViewKeySetting();
		}

		// Token: 0x06026687 RID: 157319 RVA: 0x00AC21D4 File Offset: 0x00AC03D4
		public void OnClickBtnSave()
		{
			int helpIdLevelSaveProgress = TrapDefenseConfig.Instance.GetHelpIdLevelSaveProgress();
			HelpController.Instance.OpenHelpById(helpIdLevelSaveProgress);
		}

		// Token: 0x06026688 RID: 157320 RVA: 0x00AC21F8 File Offset: 0x00AC03F8
		public void OnBtnHelp()
		{
			int helpIdMainLevel = TrapDefenseConfig.Instance.GetHelpIdMainLevel();
			HelpController.Instance.OpenHelpById(helpIdMainLevel);
		}

		// Token: 0x06026689 RID: 157321 RVA: 0x00AC221B File Offset: 0x00AC041B
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602668A RID: 157322 RVA: 0x00AC2224 File Offset: 0x00AC0424
		public void InitData()
		{
			if (this.ViewModel.JumpDifficulty != null)
			{
				ETrapDefenseDifficultyLevel? jumpDifficulty = this.ViewModel.JumpDifficulty;
				ETrapDefenseDifficultyLevel etrapDefenseDifficultyLevel = ETrapDefenseDifficultyLevel.None;
				if (!(jumpDifficulty.GetValueOrDefault() == etrapDefenseDifficultyLevel & jumpDifficulty != null))
				{
					this.PanelLevelTab.InitSelectDifficulty(this.ViewModel.JumpDifficulty.Value);
				}
			}
			if (this.ViewModel.JumpLevelData != null)
			{
				this.PanelLevelTab.InitSelectLevel(this.ViewModel.JumpLevelData);
			}
		}

		// Token: 0x0602668B RID: 157323 RVA: 0x00AC22A3 File Offset: 0x00AC04A3
		public void UpdateData()
		{
			this.PanelLevelTab.UpdateModeData();
			this.UpdateSaveState();
		}

		// Token: 0x0602668C RID: 157324 RVA: 0x00AC22B8 File Offset: 0x00AC04B8
		public void UpdateSaveState()
		{
			TrapDefenseLevelData curSelectLevel = this.PanelLevelTab.CurSelectLevel;
			bool flag = curSelectLevel != null && curSelectLevel.Config.IsCanSave;
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			if (flag)
			{
				ETrapDefenseTextKey etrapDefenseTextKey = curSelectLevel.IsLeaved ? ETrapDefenseTextKey.LevelExistSaveTitle : ETrapDefenseTextKey.LevelCanSaveTitle;
				UUIText text = base.GetText(8);
				if (text == null)
				{
					return;
				}
				text.ShowTextNew(etrapDefenseTextKey.ToString());
			}
		}

		// Token: 0x0602668D RID: 157325 RVA: 0x00AC233C File Offset: 0x00AC053C
		public void OnSelectLevelItem(TrapDefenseLevelData data)
		{
			this.UpdateSaveState();
			this.PanelNameInfo.UpdateData(data);
			this.PanelMapInfo.UpdateData(data);
			this.PanelTargetInfo.UpdateData(data);
			string levelImage = data.Config.LevelImage;
			base.SetTextureByPath(levelImage, base.GetTexture(9), null, null);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Switch", false, false);
			}
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.PlaySequencePurely("Switch", false, false);
		}

		// Token: 0x04015107 RID: 86279
		public TrapDefenseMainLevelViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMainLevel;

		// Token: 0x04015108 RID: 86280
		public PopupCaptionItem PopupCaption;

		// Token: 0x04015109 RID: 86281
		public TrapDefenseMainLevelTabPanel PanelLevelTab;

		// Token: 0x0401510A RID: 86282
		public TrapDefenseLevelNamePanel PanelNameInfo;

		// Token: 0x0401510B RID: 86283
		public TrapDefenseLevelMapPanel PanelMapInfo;

		// Token: 0x0401510C RID: 86284
		public TrapDefenseLevelTargetPanel PanelTargetInfo;

		// Token: 0x0200963E RID: 38462
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE7B RID: 192123
			public const int ItemCaption = 0;

			// Token: 0x0402EE7C RID: 192124
			public const int BtnKeyboardSet = 1;

			// Token: 0x0402EE7D RID: 192125
			public const int ItemLevelTabPanel = 2;

			// Token: 0x0402EE7E RID: 192126
			public const int ItemLevelNamePanel = 3;

			// Token: 0x0402EE7F RID: 192127
			public const int ItemLevelMapPanel = 4;

			// Token: 0x0402EE80 RID: 192128
			public const int ItemLevelTargetPanel = 5;

			// Token: 0x0402EE81 RID: 192129
			public const int BtnSave = 6;

			// Token: 0x0402EE82 RID: 192130
			public const int SpriteSaveIcon = 7;

			// Token: 0x0402EE83 RID: 192131
			public const int TextSaveTitle = 8;

			// Token: 0x0402EE84 RID: 192132
			public const int TexLevel = 9;
		}
	}
}
