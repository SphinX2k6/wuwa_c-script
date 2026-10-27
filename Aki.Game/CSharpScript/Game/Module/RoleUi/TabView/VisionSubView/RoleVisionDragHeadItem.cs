using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF2 RID: 19698
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionDragHeadItem : RoleVisionCommonItem
	{
		// Token: 0x06032E33 RID: 208435 RVA: 0x00BDBFB8 File Offset: 0x00BDA1B8
		[NullableContext(1)]
		public RoleVisionDragHeadItem(UUIItem uiItem, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData, bool needRedDot = false, bool needShowOccupyDetail = false, ERoleViewSource source = ERoleViewSource.Normal) : base(uiItem, index, roleData, needRedDot, needShowOccupyDetail, source)
		{
		}

		// Token: 0x06032E34 RID: 208436 RVA: 0x00BDBFDB File Offset: 0x00BDA1DB
		protected override UUIItem GetPlusItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06032E35 RID: 208437 RVA: 0x00BDBFE4 File Offset: 0x00BDA1E4
		protected override UUITexture GetVisionTextureComponent()
		{
			return base.GetTexture(2);
		}

		// Token: 0x06032E36 RID: 208438 RVA: 0x00BDBFED File Offset: 0x00BDA1ED
		protected override UUISprite GetVisionQualitySprite()
		{
			return base.GetSprite(3);
		}

		// Token: 0x06032E37 RID: 208439 RVA: 0x00BDBFF6 File Offset: 0x00BDA1F6
		protected override UUIText GetVisionCostText()
		{
			return base.GetText(5);
		}

		// Token: 0x06032E38 RID: 208440 RVA: 0x00BDBFFF File Offset: 0x00BDA1FF
		protected override UUIItem GetVisionCostItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x06032E39 RID: 208441 RVA: 0x00BDC008 File Offset: 0x00BDA208
		public override UUIDraggableComponent GetDragComponent()
		{
			return base.GetDraggable(1);
		}

		// Token: 0x06032E3A RID: 208442 RVA: 0x00BDC011 File Offset: 0x00BDA211
		protected override UUIExtendToggle GetSelectToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06032E3B RID: 208443 RVA: 0x00BDC01C File Offset: 0x00BDA21C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, base.OnClickVision)
			};
		}

		// Token: 0x06032E3C RID: 208444 RVA: 0x00BDC1E8 File Offset: 0x00BDA3E8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionDragHeadItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionDragHeadItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032E3D RID: 208445 RVA: 0x00BDC22B File Offset: 0x00BDA42B
		public override void SetAniLightState(bool state)
		{
			base.GetItem(11).SetUIActive(state);
		}

		// Token: 0x06032E3E RID: 208446 RVA: 0x00BDC23B File Offset: 0x00BDA43B
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(8).SetUIActive(false);
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06032E3F RID: 208447 RVA: 0x00BDC278 File Offset: 0x00BDA478
		[NullableContext(1)]
		protected void OnSetClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06032E40 RID: 208448 RVA: 0x00BDC281 File Offset: 0x00BDA481
		protected override void OnDragBegin()
		{
			this.VisionFetterSuitItem.GetRootItem().SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshAddItemItem(true);
		}

		// Token: 0x06032E41 RID: 208449 RVA: 0x00BDC2BC File Offset: 0x00BDA4BC
		protected override void OnDragEnd()
		{
			this.CheckAnimationStateAndDataSetElementActiveState();
			this.RefreshAddItemItem(this.CurrentData == null);
		}

		// Token: 0x06032E42 RID: 208450 RVA: 0x00BDC2D4 File Offset: 0x00BDA4D4
		protected override void OnUpdateItem(PhantomDataBase data)
		{
			if (data != null)
			{
				base.GetText(5).SetText(data.GetCost().ToString(), true);
				PhantomFetterGroup fetterGroupConfig = data.GetFetterGroupConfig();
				this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(fetterGroupConfig));
			}
			this.CheckAnimationStateAndDataSetElementActiveState();
			this.RefreshCircleBgSprite(data);
			this.RefreshCircleBlackBg(data);
			this.UnBindRedDot();
			this.BindRedDot(data);
			this.RefreshAddItemItem(data == null);
			this.RefreshLevelText(data);
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshWarning(data);
		}

		// Token: 0x06032E43 RID: 208451 RVA: 0x00BDC364 File Offset: 0x00BDA564
		private void RefreshLevelText(PhantomDataBase data)
		{
			if (data == null || !this.NeedLevelShowState)
			{
				return;
			}
			int phantomLevel = data.GetPhantomLevel();
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(15);
			if (text == null)
			{
				return;
			}
			text.SetText("+" + phantomLevel.ToString(), true);
		}

		// Token: 0x06032E44 RID: 208452 RVA: 0x00BDC3BC File Offset: 0x00BDA5BC
		private void RefreshAddItemItem(bool state)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(state);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(state);
		}

		// Token: 0x06032E45 RID: 208453 RVA: 0x00BDC3E5 File Offset: 0x00BDA5E5
		private void RefreshCircleBlackBg(PhantomDataBase data)
		{
			base.GetItem(9).SetUIActive(data != null);
		}

		// Token: 0x06032E46 RID: 208454 RVA: 0x00BDC3F8 File Offset: 0x00BDA5F8
		private void CheckAnimationStateAndDataSetElementActiveState()
		{
			if (!this.AnimationState && this.CurrentData != null)
			{
				base.GetItem(4).SetUIActive(true);
				this.VisionFetterSuitItem.GetRootItem().SetUIActive(true);
				if (this.NeedLevelShowState)
				{
					UUIItem item = base.GetItem(14);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(true);
					return;
				}
			}
			else
			{
				this.VisionFetterSuitItem.GetRootItem().SetUIActive(false);
				base.GetItem(4).SetUIActive(false);
				UUIItem item2 = base.GetItem(14);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
			}
		}

		// Token: 0x06032E47 RID: 208455 RVA: 0x00BDC480 File Offset: 0x00BDA680
		protected override void OnScrollToScrollViewEvent()
		{
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.RefreshAddItemItem(false);
		}

		// Token: 0x06032E48 RID: 208456 RVA: 0x00BDC49D File Offset: 0x00BDA69D
		protected override void OnRemoveFromScrollViewEvent()
		{
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshAddItemItem(true);
		}

		// Token: 0x06032E49 RID: 208457 RVA: 0x00BDC4BA File Offset: 0x00BDA6BA
		protected override void OnChangeAnimationState()
		{
			this.CheckAnimationStateAndDataSetElementActiveState();
		}

		// Token: 0x06032E4A RID: 208458 RVA: 0x00BDC4C2 File Offset: 0x00BDA6C2
		protected override void OnItemOverlay()
		{
			base.PlaySequence("HighLight");
		}

		// Token: 0x06032E4B RID: 208459 RVA: 0x00BDC4CF File Offset: 0x00BDA6CF
		protected override void OnItemUnOverlay()
		{
			base.PlaySequence("Normal");
		}

		// Token: 0x06032E4C RID: 208460 RVA: 0x00BDC4DC File Offset: 0x00BDA6DC
		[NullableContext(1)]
		protected override void OnPlaySequence(string sequence)
		{
			if (this.CurrentSequence != sequence)
			{
				this.CurrentSequence = sequence;
				this.LevelSequencePlayer.PlaySequencePurely(sequence, false, false, null, null, false);
			}
		}

		// Token: 0x06032E4D RID: 208461 RVA: 0x00BDC518 File Offset: 0x00BDA718
		private void BindRedDot(PhantomDataBase data)
		{
			if (this.RoleData == null)
			{
				UUIItem item = base.GetItem(8);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else if (this.RoleData.IsTrialRole())
			{
				UUIItem item2 = base.GetItem(8);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				if (!this.RedDotBindState && this.NeedRedDot && data == null)
				{
					this.RedDotBindState = true;
					RedDotController.Instance.BindRedDot(ERedDotName.VisionGridRedDot, base.GetItem(8), null, this.RoleData.GetRoleId());
					this.RedDotType = 0;
					this.CurrentRoleData = this.RoleData;
					return;
				}
				if (!this.RedDotBindState && this.NeedRedDot && data != null)
				{
					this.RedDotBindState = true;
					int incrId = data.GetIncrId();
					RedDotController.Instance.BindRedDot(ERedDotName.VisionIdentifyTab, base.GetItem(8), null, incrId);
					this.RedDotType = 1;
					this.CurrentRedDotBindData = data;
				}
				return;
			}
		}

		// Token: 0x06032E4E RID: 208462 RVA: 0x00BDC5F4 File Offset: 0x00BDA7F4
		private void UnBindRedDot()
		{
			if (this.RedDotBindState)
			{
				this.RedDotBindState = false;
				if (this.RedDotType == 0)
				{
					RedDotController.Instance.UnBindGivenUi(ERedDotName.VisionGridRedDot, base.GetItem(8), this.CurrentRoleData.GetRoleId());
					return;
				}
				RedDotController instance = RedDotController.Instance;
				ERedDotName name = ERedDotName.VisionIdentifyTab;
				UUIItem item = base.GetItem(8);
				PhantomDataBase currentRedDotBindData = this.CurrentRedDotBindData;
				instance.UnBindGivenUi(name, item, (currentRedDotBindData != null) ? currentRedDotBindData.GetIncrId() : 0);
			}
		}

		// Token: 0x06032E4F RID: 208463 RVA: 0x00BDC65C File Offset: 0x00BDA85C
		private void RefreshCircleBgSprite(PhantomDataBase data)
		{
			if (data != null)
			{
				int quality = data.GetQuality();
				string phantomQualityBgSprite = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality);
				this.SetSpriteByPath(phantomQualityBgSprite, base.GetSprite(3), false, null, null);
				return;
			}
			string phantomQualityBgSprite2 = PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(0);
			this.SetSpriteByPath(phantomQualityBgSprite2, base.GetSprite(3), false, null, null);
		}

		// Token: 0x06032E50 RID: 208464 RVA: 0x00BDC6C0 File Offset: 0x00BDA8C0
		private void RefreshWarning(PhantomDataBase data)
		{
			RoleDataBase roleData = this.RoleData;
			int? num = (roleData != null) ? new int?(roleData.GetRoleId()) : null;
			if (data != null && num != null && this.Source == ERoleViewSource.WheelTower)
			{
				int incrId = data.GetIncrId();
				EnergyInfo selectedEnergyInfo = WheelTowerModel.Instance.SelectedEnergyInfo;
				bool flag = !selectedEnergyInfo.GetPhantomCanUse(incrId, num.Value);
				if (flag)
				{
					int phantomOccupyRoleId = selectedEnergyInfo.GetPhantomOccupyRoleId(incrId, num.Value);
					Aki.Config.RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(phantomOccupyRoleId);
					CommonWarningItem warningItem = this.WarningItem;
					if (warningItem != null)
					{
						warningItem.SetWarningIcon(roleConfig.Value.Card);
					}
					CommonWarningItem warningItem2 = this.WarningItem;
					if (warningItem2 != null)
					{
						warningItem2.SetLocalTextNew("WheelTower_Occupy_Tip", Array.Empty<object>());
					}
				}
				CommonWarningItem warningItem3 = this.WarningItem;
				if (warningItem3 != null)
				{
					warningItem3.SetUiActive(flag && this.NeedShowOccupyDetail);
				}
				UUIItem item = base.GetItem(17);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(flag && !this.NeedShowOccupyDetail);
				return;
			}
			else
			{
				CommonWarningItem warningItem4 = this.WarningItem;
				if (warningItem4 != null)
				{
					warningItem4.SetUiActive(false);
				}
				UUIItem item2 = base.GetItem(17);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x06032E51 RID: 208465 RVA: 0x00BDC7F4 File Offset: 0x00BDA9F4
		protected override void OnResetPosition()
		{
			UUIDraggableComponent dragComponent = this.GetDragComponent();
			if (dragComponent != null)
			{
				dragComponent.RootUIComp.Get().SetAsLastHierarchy();
			}
			if (this.CurrentSequence == "HighLight")
			{
				base.PlaySequence("Normal");
				this.LevelSequencePlayer.StopCurrentSequence(false, true);
			}
			else
			{
				this.CurrentSequence = "Normal";
			}
			this.AnimationState = false;
			this.CheckAnimationStateAndDataSetElementActiveState();
		}

		// Token: 0x06032E52 RID: 208466 RVA: 0x00BDC863 File Offset: 0x00BDAA63
		protected override void OnBeforeClearComponent()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06032E53 RID: 208467 RVA: 0x00BDC86B File Offset: 0x00BDAA6B
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x06032E54 RID: 208468 RVA: 0x00BDC86E File Offset: 0x00BDAA6E
		public void SetLevelItemShowState(bool state)
		{
			this.NeedLevelShowState = state;
		}

		// Token: 0x0401B10F RID: 110863
		protected Action<int> ClickFunction;

		// Token: 0x0401B110 RID: 110864
		private VisionFetterSuitItem VisionFetterSuitItem;

		// Token: 0x0401B111 RID: 110865
		private CommonWarningItem WarningItem;

		// Token: 0x0401B112 RID: 110866
		private bool RedDotBindState;

		// Token: 0x0401B113 RID: 110867
		private int RedDotType;

		// Token: 0x0401B114 RID: 110868
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B115 RID: 110869
		[Nullable(1)]
		private string CurrentSequence = "";

		// Token: 0x0401B116 RID: 110870
		private PhantomDataBase CurrentRedDotBindData;

		// Token: 0x0401B117 RID: 110871
		private RoleDataBase CurrentRoleData;

		// Token: 0x0401B118 RID: 110872
		private bool NeedLevelShowState = true;

		// Token: 0x0200AE7E RID: 44670
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034FAF RID: 217007
			ToggleItem,
			// Token: 0x04034FB0 RID: 217008
			CircleItem,
			// Token: 0x04034FB1 RID: 217009
			CircleItemTexture,
			// Token: 0x04034FB2 RID: 217010
			QualitySprite,
			// Token: 0x04034FB3 RID: 217011
			CostItem,
			// Token: 0x04034FB4 RID: 217012
			CostNumText,
			// Token: 0x04034FB5 RID: 217013
			PlusItem,
			// Token: 0x04034FB6 RID: 217014
			SuitElementItem,
			// Token: 0x04034FB7 RID: 217015
			RedItem,
			// Token: 0x04034FB8 RID: 217016
			CircleTextureBlackBg,
			// Token: 0x04034FB9 RID: 217017
			AddIconItem,
			// Token: 0x04034FBA RID: 217018
			AniLight,
			// Token: 0x04034FBB RID: 217019
			RemoveItem,
			// Token: 0x04034FBC RID: 217020
			AddIconItem2,
			// Token: 0x04034FBD RID: 217021
			LevelItem,
			// Token: 0x04034FBE RID: 217022
			LevelText,
			// Token: 0x04034FBF RID: 217023
			ItemOccupyPanel,
			// Token: 0x04034FC0 RID: 217024
			ItemWarningIcon
		}
	}
}
