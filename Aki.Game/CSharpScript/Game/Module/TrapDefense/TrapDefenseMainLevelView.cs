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
	// Token: 0x02004AB8 RID: 19128
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseMainLevelView : UiViewBase
	{
		// Token: 0x060318ED RID: 202989 RVA: 0x00B7DF8C File Offset: 0x00B7C18C
		public TrapDefenseMainLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060318EE RID: 202990 RVA: 0x00B7DFA8 File Offset: 0x00B7C1A8
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

		// Token: 0x060318EF RID: 202991 RVA: 0x00B7E17C File Offset: 0x00B7C37C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMainLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMainLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318F0 RID: 202992 RVA: 0x00B7E1BF File Offset: 0x00B7C3BF
		protected override void OnStart()
		{
			this.InitData();
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseMainLevelViewOpen, true);
		}

		// Token: 0x060318F1 RID: 202993 RVA: 0x00B7E1D8 File Offset: 0x00B7C3D8
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x060318F2 RID: 202994 RVA: 0x00B7E1DA File Offset: 0x00B7C3DA
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x060318F3 RID: 202995 RVA: 0x00B7E1DC File Offset: 0x00B7C3DC
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x060318F4 RID: 202996 RVA: 0x00B7E1E4 File Offset: 0x00B7C3E4
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit<bool>(EEventName.TrapDefenseMainLevelViewOpen, false);
		}

		// Token: 0x060318F5 RID: 202997 RVA: 0x00B7E1F7 File Offset: 0x00B7C3F7
		protected override void OnBeforeHide()
		{
			this.ViewModel.Model.LevelModeData.SaveCacheReachOpenTimeLevels();
		}

		// Token: 0x060318F6 RID: 202998 RVA: 0x00B7E20E File Offset: 0x00B7C40E
		public void OnClickBtnKeyboardSet()
		{
			this.ViewModel.Model.OpenViewKeySetting();
		}

		// Token: 0x060318F7 RID: 202999 RVA: 0x00B7E220 File Offset: 0x00B7C420
		public void OnClickBtnSave()
		{
			int helpIdLevelSaveProgress = TrapDefenseConfig.Instance.GetHelpIdLevelSaveProgress();
			HelpController.Instance.OpenHelpById(helpIdLevelSaveProgress);
		}

		// Token: 0x060318F8 RID: 203000 RVA: 0x00B7E244 File Offset: 0x00B7C444
		public void OnBtnHelp()
		{
			int helpIdMainLevel = TrapDefenseConfig.Instance.GetHelpIdMainLevel();
			HelpController.Instance.OpenHelpById(helpIdMainLevel);
		}

		// Token: 0x060318F9 RID: 203001 RVA: 0x00B7E267 File Offset: 0x00B7C467
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060318FA RID: 203002 RVA: 0x00B7E270 File Offset: 0x00B7C470
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

		// Token: 0x060318FB RID: 203003 RVA: 0x00B7E2EF File Offset: 0x00B7C4EF
		public void UpdateData()
		{
			this.PanelLevelTab.UpdateModeData();
			this.UpdateSaveState();
		}

		// Token: 0x060318FC RID: 203004 RVA: 0x00B7E304 File Offset: 0x00B7C504
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

		// Token: 0x060318FD RID: 203005 RVA: 0x00B7E388 File Offset: 0x00B7C588
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

		// Token: 0x0401A7B5 RID: 108469
		public TrapDefenseMainLevelViewModel ViewModel = TrapDefenseModel.Instance.ViewModelMainLevel;

		// Token: 0x0401A7B6 RID: 108470
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401A7B7 RID: 108471
		public TrapDefenseMainLevelTabPanel PanelLevelTab;

		// Token: 0x0401A7B8 RID: 108472
		public TrapDefenseLevelNamePanel PanelNameInfo;

		// Token: 0x0401A7B9 RID: 108473
		public TrapDefenseLevelMapPanel PanelMapInfo;

		// Token: 0x0401A7BA RID: 108474
		public TrapDefenseLevelTargetPanel PanelTargetInfo;

		// Token: 0x0200AC1E RID: 44062
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344CA RID: 214218
			public const int ItemCaption = 0;

			// Token: 0x040344CB RID: 214219
			public const int BtnKeyboardSet = 1;

			// Token: 0x040344CC RID: 214220
			public const int ItemLevelTabPanel = 2;

			// Token: 0x040344CD RID: 214221
			public const int ItemLevelNamePanel = 3;

			// Token: 0x040344CE RID: 214222
			public const int ItemLevelMapPanel = 4;

			// Token: 0x040344CF RID: 214223
			public const int ItemLevelTargetPanel = 5;

			// Token: 0x040344D0 RID: 214224
			public const int BtnSave = 6;

			// Token: 0x040344D1 RID: 214225
			public const int SpriteSaveIcon = 7;

			// Token: 0x040344D2 RID: 214226
			public const int TextSaveTitle = 8;

			// Token: 0x040344D3 RID: 214227
			public const int TexLevel = 9;
		}
	}
}
