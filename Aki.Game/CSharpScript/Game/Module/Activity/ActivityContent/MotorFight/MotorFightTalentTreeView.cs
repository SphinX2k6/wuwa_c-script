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
	// Token: 0x020053AE RID: 21422
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorFightTalentTreeView : UiViewBase
	{
		// Token: 0x0603548C RID: 218252 RVA: 0x00EE2642 File Offset: 0x00EE0842
		[NullableContext(1)]
		public MotorFightTalentTreeView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603548D RID: 218253 RVA: 0x00EE2658 File Offset: 0x00EE0858
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

		// Token: 0x0603548E RID: 218254 RVA: 0x00EE27F0 File Offset: 0x00EE09F0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightTalentTreeView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightTalentTreeView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603548F RID: 218255 RVA: 0x00EE2834 File Offset: 0x00EE0A34
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

		// Token: 0x06035490 RID: 218256 RVA: 0x00EE29CC File Offset: 0x00EE0BCC
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

		// Token: 0x06035491 RID: 218257 RVA: 0x00EE2A3D File Offset: 0x00EE0C3D
		[NullableContext(1)]
		private MotorFightTalentGridPanel CreateTalentGridPanel()
		{
			return new MotorFightTalentGridPanel
			{
				OnSelectTalentNode = new Action<MotorFightTalentNodeItem>(this.OnSelectTalentNode)
			};
		}

		// Token: 0x06035492 RID: 218258 RVA: 0x00EE2A58 File Offset: 0x00EE0C58
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
				LevelUpSuccessEffectData data = new LevelUpSuccessEffectData
				{
					Title = "MotorFightGame_TechTreeUnlock_01",
					TextList = new List<SingleText>
					{
						new SingleText
						{
							TextId = this.TalentData.Desc,
							Params = this.TalentData.DescParams.ToArray<string>()
						}
					}
				};
				RoleLevelUpSuccessController.Instance.OpenSuccessEffectView(data, null);
			});
		}

		// Token: 0x06035493 RID: 218259 RVA: 0x00EE2AE3 File Offset: 0x00EE0CE3
		private void OnCloseBtnClick()
		{
			this.ActivityData.SelectedTalentNodeId = 0;
			base.CloseMe(null);
		}

		// Token: 0x0401C190 RID: 115088
		private MotorFightActivityData ActivityData;

		// Token: 0x0401C191 RID: 115089
		private MotorFightTalentData TalentData;

		// Token: 0x0401C192 RID: 115090
		[Nullable(1)]
		private List<List<MotorFightTalentData>> TalentTreeList = new List<List<MotorFightTalentData>>();

		// Token: 0x0401C193 RID: 115091
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C194 RID: 115092
		private ButtonItem ConfirmBtn;

		// Token: 0x0401C195 RID: 115093
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0401C196 RID: 115094
		public MotorFightTalentNodeItem CurSelectNode;

		// Token: 0x0401C197 RID: 115095
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public GenericScrollViewNew<MotorFightTalentGridPanel, List<MotorFightTalentData>> ScrollView;

		// Token: 0x0200B057 RID: 45143
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040367F3 RID: 223219
			public const int ItemCaption = 0;

			// Token: 0x040367F4 RID: 223220
			public const int ScrollViewLayout = 1;

			// Token: 0x040367F5 RID: 223221
			public const int ItemTalentNode = 2;

			// Token: 0x040367F6 RID: 223222
			public const int SpriteIcon = 3;

			// Token: 0x040367F7 RID: 223223
			public const int TextDesc = 4;

			// Token: 0x040367F8 RID: 223224
			public const int ItemConfirmBtn = 5;

			// Token: 0x040367F9 RID: 223225
			public const int TextCostNum = 6;

			// Token: 0x040367FA RID: 223226
			public const int TextureCostIcon = 7;

			// Token: 0x040367FB RID: 223227
			public const int ItemLockPanel = 8;

			// Token: 0x040367FC RID: 223228
			public const int ItemUnlockPanel = 9;

			// Token: 0x040367FD RID: 223229
			public const int TextTalentName = 10;
		}
	}
}
