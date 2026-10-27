using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006430 RID: 25648
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightTalentTreeView : UiViewBase
	{
		// Token: 0x060407CB RID: 264139 RVA: 0x00F9B6A2 File Offset: 0x00F998A2
		[NullableContext(1)]
		public MotorFightTalentTreeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060407CC RID: 264140 RVA: 0x00F9B6B8 File Offset: 0x00F998B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060407CD RID: 264141 RVA: 0x00F9B850 File Offset: 0x00F99A50
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightTalentTreeView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightTalentTreeView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060407CE RID: 264142 RVA: 0x00F9B894 File Offset: 0x00F99A94
		private void RefreshDetailPanel()
		{
			this.SetSpriteByPath(this.TalentData.Icon, base.GetSprite(3), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), this.TalentData.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.TalentData.Desc, this.TalentData.DescParams);
			bool flag = this.ActivityData.GetTalentCoinNum() >= this.TalentData.Cost;
			UUIText text = base.GetText(6);
			text.SetText(this.TalentData.Cost.ToString(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			bool flag2 = this.ActivityData.IsPreNodeAllUnlock(this.TalentData) && this.TalentData.IsFinishPreCondition;
			ButtonItem confirmBtn = this.ConfirmBtn;
			if (confirmBtn != null)
			{
				confirmBtn.SetUiActive(flag2 && !this.TalentData.IsUnLock);
			}
			FunctionalPanelConditionLock lockPanel = this.LockPanel;
			if (lockPanel != null)
			{
				lockPanel.SetUiActive(!flag2 && !this.TalentData.IsUnLock);
			}
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(this.TalentData.IsUnLock);
			}
			string textId = this.TalentData.IsFinishPreCondition ? "MotorFightGame_TechTree_01" : LevelGeneralCommons.GetConditionGroupHintText(this.TalentData.ConditionId);
			FunctionalPanelConditionLock lockPanel2 = this.LockPanel;
			if (lockPanel2 == null)
			{
				return;
			}
			lockPanel2.SetTextByTextId(textId, Array.Empty<string>());
		}

		// Token: 0x060407CF RID: 264143 RVA: 0x00F9BA2C File Offset: 0x00F99C2C
		[NullableContext(1)]
		private void OnSelectTalentNode(MotorFightTalentNodeItem talentNode)
		{
			if (this.CurSelectNode != null)
			{
				this.CurSelectNode.SetToggleState(EToggleState.ETT_UnChecked);
			}
			this.CurSelectNode = talentNode;
			this.CurSelectNode.SetToggleState(EToggleState.ETT_Checked);
			this.TalentData = talentNode.Data;
			this.ActivityData.SelectedTalentNodeId = this.TalentData.Id;
			this.RefreshDetailPanel();
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x060407D0 RID: 264144 RVA: 0x00F9BA9D File Offset: 0x00F99C9D
		[NullableContext(1)]
		private MotorFightTalentGridPanel CreateTalentGridPanel()
		{
			return new MotorFightTalentGridPanel
			{
				OnSelectTalentNode = new Action<MotorFightTalentNodeItem>(this.OnSelectTalentNode)
			};
		}

		// Token: 0x060407D1 RID: 264145 RVA: 0x00F9BAB8 File Offset: 0x00F99CB8
		private void OnConfirmBtnClick(int _)
		{
			if (this.ActivityData.GetTalentCoinNum() < this.CurSelectNode.Data.Cost)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(this.ActivityData.TalentTreeItemId).Name, null);
				ScrollingTipsController.Instance.ShowTipsByTextId("ItemConsumption_Talent", new object[]
				{
					localTextNew
				});
				return;
			}
			MotorFightController.Instance.RequestUnlockTalentNode(this.CurSelectNode.Data.Id, delegate
			{
				this.RefreshDetailPanel();
				GenericScrollViewNew<MotorFightTalentGridPanel, List<MotorFightTalentData>> scrollView = this.ScrollView;
				if (scrollView != null)
				{
					scrollView.RefreshByData(this.TalentTreeList, null, false);
				}
				LevelUpSuccessEffectData levelUpSuccessEffectData = new LevelUpSuccessEffectData();
				levelUpSuccessEffectData.Title = "MotorFightGame_TechTreeUnlock_01";
				List<SingleText> list = new List<SingleText>();
				SingleText singleText = new SingleText();
				singleText.TextId = this.TalentData.Desc;
				singleText.Params = (from x in this.TalentData.DescParams
				select x.ToString()).ToArray<string>();
				list.Add(singleText);
				levelUpSuccessEffectData.TextList = list;
				LevelUpSuccessEffectData data = levelUpSuccessEffectData;
				RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
			});
		}

		// Token: 0x060407D2 RID: 264146 RVA: 0x00F9BB43 File Offset: 0x00F99D43
		private void OnCloseBtnClick()
		{
			this.ActivityData.SelectedTalentNodeId = 0;
			base.CloseMe(null);
		}

		// Token: 0x04021861 RID: 137313
		private MotorFightActivityData ActivityData;

		// Token: 0x04021862 RID: 137314
		private MotorFightTalentData TalentData;

		// Token: 0x04021863 RID: 137315
		[Nullable(1)]
		private List<List<MotorFightTalentData>> TalentTreeList = new List<List<MotorFightTalentData>>();

		// Token: 0x04021864 RID: 137316
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021865 RID: 137317
		private ButtonItem ConfirmBtn;

		// Token: 0x04021866 RID: 137318
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x04021867 RID: 137319
		public MotorFightTalentNodeItem CurSelectNode;

		// Token: 0x04021868 RID: 137320
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public GenericScrollViewNew<MotorFightTalentGridPanel, List<MotorFightTalentData>> ScrollView;

		// Token: 0x0200C670 RID: 50800
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BE96 RID: 245398
			public const int ItemCaption = 0;

			// Token: 0x0403BE97 RID: 245399
			public const int ScrollViewLayout = 1;

			// Token: 0x0403BE98 RID: 245400
			public const int ItemTalentNode = 2;

			// Token: 0x0403BE99 RID: 245401
			public const int SpriteIcon = 3;

			// Token: 0x0403BE9A RID: 245402
			public const int TextDesc = 4;

			// Token: 0x0403BE9B RID: 245403
			public const int ItemConfirmBtn = 5;

			// Token: 0x0403BE9C RID: 245404
			public const int TextCostNum = 6;

			// Token: 0x0403BE9D RID: 245405
			public const int TextureCostIcon = 7;

			// Token: 0x0403BE9E RID: 245406
			public const int ItemLockPanel = 8;

			// Token: 0x0403BE9F RID: 245407
			public const int ItemUnlockPanel = 9;

			// Token: 0x0403BEA0 RID: 245408
			public const int TextTalentName = 10;
		}
	}
}
