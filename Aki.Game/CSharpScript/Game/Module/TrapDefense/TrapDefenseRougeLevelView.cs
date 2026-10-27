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
	// Token: 0x02004ABA RID: 19130
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRougeLevelView : UiViewBase
	{
		// Token: 0x06031902 RID: 203010 RVA: 0x00B7E45F File Offset: 0x00B7C65F
		public TrapDefenseRougeLevelView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031903 RID: 203011 RVA: 0x00B7E478 File Offset: 0x00B7C678
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

		// Token: 0x06031904 RID: 203012 RVA: 0x00B7E64C File Offset: 0x00B7C84C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseRougeLevelView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseRougeLevelView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031905 RID: 203013 RVA: 0x00B7E68F File Offset: 0x00B7C88F
		protected override void OnStart()
		{
			TrapDefenseModel.Instance.RougeModeData.CheckModeOpenRedDotState();
			this.InitData();
		}

		// Token: 0x06031906 RID: 203014 RVA: 0x00B7E6A7 File Offset: 0x00B7C8A7
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06031907 RID: 203015 RVA: 0x00B7E6A9 File Offset: 0x00B7C8A9
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06031908 RID: 203016 RVA: 0x00B7E6AB File Offset: 0x00B7C8AB
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06031909 RID: 203017 RVA: 0x00B7E6B3 File Offset: 0x00B7C8B3
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603190A RID: 203018 RVA: 0x00B7E6B5 File Offset: 0x00B7C8B5
		protected override void OnBeforeHide()
		{
			this.ViewModel.Model.RougeModeData.SaveCacheReachOpenTimeLevels();
		}

		// Token: 0x0603190B RID: 203019 RVA: 0x00B7E6CC File Offset: 0x00B7C8CC
		public void OnClickBtnKeyboardSet()
		{
			this.ViewModel.Model.OpenViewKeySetting();
		}

		// Token: 0x0603190C RID: 203020 RVA: 0x00B7E6E0 File Offset: 0x00B7C8E0
		public void OnClickBtnSave()
		{
			int helpIdLevelSaveProgress = TrapDefenseConfig.Instance.GetHelpIdLevelSaveProgress();
			HelpController.Instance.OpenHelpById(helpIdLevelSaveProgress);
		}

		// Token: 0x0603190D RID: 203021 RVA: 0x00B7E704 File Offset: 0x00B7C904
		public void OnBtnHelp()
		{
			int helpIdRougeLevel = TrapDefenseConfig.Instance.GetHelpIdRougeLevel();
			HelpController.Instance.OpenHelpById(helpIdRougeLevel);
		}

		// Token: 0x0603190E RID: 203022 RVA: 0x00B7E727 File Offset: 0x00B7C927
		public void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603190F RID: 203023 RVA: 0x00B7E730 File Offset: 0x00B7C930
		public void InitData()
		{
			if (this.ViewModel.JumpLevelData != null)
			{
				this.PanelLevelTab.InitSelectLevel(this.ViewModel.JumpLevelData);
			}
		}

		// Token: 0x06031910 RID: 203024 RVA: 0x00B7E755 File Offset: 0x00B7C955
		public void UpdateData()
		{
			this.PanelLevelTab.UpdateModeData();
			this.UpdateSaveState();
		}

		// Token: 0x06031911 RID: 203025 RVA: 0x00B7E768 File Offset: 0x00B7C968
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

		// Token: 0x06031912 RID: 203026 RVA: 0x00B7E7EC File Offset: 0x00B7C9EC
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

		// Token: 0x0401A7BB RID: 108475
		public TrapDefenseRougeLevelViewModel ViewModel = TrapDefenseModel.Instance.ViewModelRougeLevel;

		// Token: 0x0401A7BC RID: 108476
		public PopupCaptionItem PopupCaption;

		// Token: 0x0401A7BD RID: 108477
		public TrapDefenseRougeLevelTabPanel PanelLevelTab;

		// Token: 0x0401A7BE RID: 108478
		public TrapDefenseLevelNamePanel PanelNameInfo;

		// Token: 0x0401A7BF RID: 108479
		public TrapDefenseLevelMapPanel PanelMapInfo;

		// Token: 0x0401A7C0 RID: 108480
		public TrapDefenseLevelTargetPanel PanelTargetInfo;

		// Token: 0x0200AC20 RID: 44064
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040344D8 RID: 214232
			public const int ItemCaption = 0;

			// Token: 0x040344D9 RID: 214233
			public const int BtnKeyboardSet = 1;

			// Token: 0x040344DA RID: 214234
			public const int ItemLevelTabPanel = 2;

			// Token: 0x040344DB RID: 214235
			public const int ItemLevelNamePanel = 3;

			// Token: 0x040344DC RID: 214236
			public const int ItemLevelMapPanel = 4;

			// Token: 0x040344DD RID: 214237
			public const int ItemLevelTargetPanel = 5;

			// Token: 0x040344DE RID: 214238
			public const int BtnSave = 6;

			// Token: 0x040344DF RID: 214239
			public const int SpriteSaveIcon = 7;

			// Token: 0x040344E0 RID: 214240
			public const int TextSaveTitle = 8;

			// Token: 0x040344E1 RID: 214241
			public const int TexLevel = 9;
		}
	}
}
