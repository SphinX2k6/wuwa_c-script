using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A62 RID: 14946
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeLevelView : UiViewBase
	{
		// Token: 0x06026692 RID: 157330 RVA: 0x00AC2413 File Offset: 0x00AC0613
		public TrapDefenseRougeLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026693 RID: 157331 RVA: 0x00AC242C File Offset: 0x00AC062C
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

		// Token: 0x06026694 RID: 157332 RVA: 0x00AC2600 File Offset: 0x00AC0800
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseRougeLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRougeLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026695 RID: 157333 RVA: 0x00AC2643 File Offset: 0x00AC0843
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.RougeModeData.CheckModeOpenRedDotState();
			this.InitData();
		}

		// Token: 0x06026696 RID: 157334 RVA: 0x00AC265B File Offset: 0x00AC085B
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06026697 RID: 157335 RVA: 0x00AC265D File Offset: 0x00AC085D
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06026698 RID: 157336 RVA: 0x00AC265F File Offset: 0x00AC085F
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06026699 RID: 157337 RVA: 0x00AC2667 File Offset: 0x00AC0867
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602669A RID: 157338 RVA: 0x00AC2669 File Offset: 0x00AC0869
		protected override void OnBeforeHide()
		{
			this.ViewModel.Model.RougeModeData.SaveCacheReachOpenTimeLevels();
		}

		// Token: 0x0602669B RID: 157339 RVA: 0x00AC2680 File Offset: 0x00AC0880
		public void OnClickBtnKeyboardSet()
		{
			this.ViewModel.Model.OpenViewKeySetting();
		}

		// Token: 0x0602669C RID: 157340 RVA: 0x00AC2694 File Offset: 0x00AC0894
		public void OnClickBtnSave()
		{
			int helpIdLevelSaveProgress = TrapDefenseConfig.Instance.GetHelpIdLevelSaveProgress();
			HelpController.Instance.OpenHelpById(helpIdLevelSaveProgress);
		}

		// Token: 0x0602669D RID: 157341 RVA: 0x00AC26B8 File Offset: 0x00AC08B8
		public void OnBtnHelp()
		{
			int helpIdRougeLevel = TrapDefenseConfig.Instance.GetHelpIdRougeLevel();
			HelpController.Instance.OpenHelpById(helpIdRougeLevel);
		}

		// Token: 0x0602669E RID: 157342 RVA: 0x00AC26DB File Offset: 0x00AC08DB
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602669F RID: 157343 RVA: 0x00AC26E4 File Offset: 0x00AC08E4
		public void InitData()
		{
			if (this.ViewModel.JumpLevelData != null)
			{
				this.PanelLevelTab.InitSelectLevel(this.ViewModel.JumpLevelData);
			}
		}

		// Token: 0x060266A0 RID: 157344 RVA: 0x00AC2709 File Offset: 0x00AC0909
		public void UpdateData()
		{
			this.PanelLevelTab.UpdateModeData();
			this.UpdateSaveState();
		}

		// Token: 0x060266A1 RID: 157345 RVA: 0x00AC271C File Offset: 0x00AC091C
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

		// Token: 0x060266A2 RID: 157346 RVA: 0x00AC27A0 File Offset: 0x00AC09A0
		public void OnSelectLevelItem(TrapDefenseLevelData data)
		{
			this.PanelNameInfo.UpdateData(data);
			this.PanelMapInfo.UpdateData(data);
			this.PanelTargetInfo.UpdateData(data);
			this.UpdateSaveState();
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

		// Token: 0x0401510D RID: 86285
		public TrapDefenseRougeLevelViewModel ViewModel = TrapDefenseModel.Instance.ViewModelRougeLevel;

		// Token: 0x0401510E RID: 86286
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401510F RID: 86287
		public TrapDefenseRougeLevelTabPanel PanelLevelTab;

		// Token: 0x04015110 RID: 86288
		public TrapDefenseLevelNamePanel PanelNameInfo;

		// Token: 0x04015111 RID: 86289
		public TrapDefenseLevelMapPanel PanelMapInfo;

		// Token: 0x04015112 RID: 86290
		public TrapDefenseLevelTargetPanel PanelTargetInfo;

		// Token: 0x02009640 RID: 38464
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE89 RID: 192137
			public const int ItemCaption = 0;

			// Token: 0x0402EE8A RID: 192138
			public const int BtnKeyboardSet = 1;

			// Token: 0x0402EE8B RID: 192139
			public const int ItemLevelTabPanel = 2;

			// Token: 0x0402EE8C RID: 192140
			public const int ItemLevelNamePanel = 3;

			// Token: 0x0402EE8D RID: 192141
			public const int ItemLevelMapPanel = 4;

			// Token: 0x0402EE8E RID: 192142
			public const int ItemLevelTargetPanel = 5;

			// Token: 0x0402EE8F RID: 192143
			public const int BtnSave = 6;

			// Token: 0x0402EE90 RID: 192144
			public const int SpriteSaveIcon = 7;

			// Token: 0x0402EE91 RID: 192145
			public const int TextSaveTitle = 8;

			// Token: 0x0402EE92 RID: 192146
			public const int TexLevel = 9;
		}
	}
}
