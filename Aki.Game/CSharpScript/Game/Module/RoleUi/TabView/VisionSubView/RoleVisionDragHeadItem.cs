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
	// Token: 0x02003CA4 RID: 15524
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionDragHeadItem : RoleVisionCommonItem
	{
		// Token: 0x06027C0E RID: 162830 RVA: 0x00B218C0 File Offset: 0x00B1FAC0
		[NullableContext(1)]
		public RoleVisionDragHeadItem(UUIItem uiItem, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData, bool needRedDot = false, bool needShowOccupyDetail = false, ERoleViewSource source = ERoleViewSource.Normal) : base(uiItem, index, roleData, needRedDot, needShowOccupyDetail, source)
		{
		}

		// Token: 0x06027C0F RID: 162831 RVA: 0x00B218E3 File Offset: 0x00B1FAE3
		protected override UUIItem GetPlusItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06027C10 RID: 162832 RVA: 0x00B218EC File Offset: 0x00B1FAEC
		protected override UUITexture GetVisionTextureComponent()
		{
			return base.GetTexture(2);
		}

		// Token: 0x06027C11 RID: 162833 RVA: 0x00B218F5 File Offset: 0x00B1FAF5
		protected override UUISprite GetVisionQualitySprite()
		{
			return base.GetSprite(3);
		}

		// Token: 0x06027C12 RID: 162834 RVA: 0x00B218FE File Offset: 0x00B1FAFE
		protected override UUIText GetVisionCostText()
		{
			return base.GetText(5);
		}

		// Token: 0x06027C13 RID: 162835 RVA: 0x00B21907 File Offset: 0x00B1FB07
		protected override UUIItem GetVisionCostItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x06027C14 RID: 162836 RVA: 0x00B21910 File Offset: 0x00B1FB10
		public override UUIDraggableComponent GetDragComponent()
		{
			return base.GetDraggable(1);
		}

		// Token: 0x06027C15 RID: 162837 RVA: 0x00B21919 File Offset: 0x00B1FB19
		protected override UUIExtendToggle GetSelectToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06027C16 RID: 162838 RVA: 0x00B21924 File Offset: 0x00B1FB24
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

		// Token: 0x06027C17 RID: 162839 RVA: 0x00B21AF0 File Offset: 0x00B1FCF0
		protected override UniTask OnBeforeStartAsync()
		{
			RoleVisionDragHeadItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleVisionDragHeadItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027C18 RID: 162840 RVA: 0x00B21B33 File Offset: 0x00B1FD33
		public override void SetAniLightState(bool state)
		{
			base.GetItem(11).SetUIActive(state);
		}

		// Token: 0x06027C19 RID: 162841 RVA: 0x00B21B43 File Offset: 0x00B1FD43
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetItem(8).SetUIActive(false);
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06027C1A RID: 162842 RVA: 0x00B21B80 File Offset: 0x00B1FD80
		[NullableContext(1)]
		protected void OnSetClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06027C1B RID: 162843 RVA: 0x00B21B89 File Offset: 0x00B1FD89
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

		// Token: 0x06027C1C RID: 162844 RVA: 0x00B21BC4 File Offset: 0x00B1FDC4
		protected override void OnDragEnd()
		{
			this.CheckAnimationStateAndDataSetElementActiveState();
			this.RefreshAddItemItem(this.CurrentData == null);
		}

		// Token: 0x06027C1D RID: 162845 RVA: 0x00B21BDC File Offset: 0x00B1FDDC
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

		// Token: 0x06027C1E RID: 162846 RVA: 0x00B21C6C File Offset: 0x00B1FE6C
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

		// Token: 0x06027C1F RID: 162847 RVA: 0x00B21CC4 File Offset: 0x00B1FEC4
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

		// Token: 0x06027C20 RID: 162848 RVA: 0x00B21CED File Offset: 0x00B1FEED
		private void RefreshCircleBlackBg(PhantomDataBase data)
		{
			base.GetItem(9).SetUIActive(data != null);
		}

		// Token: 0x06027C21 RID: 162849 RVA: 0x00B21D00 File Offset: 0x00B1FF00
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

		// Token: 0x06027C22 RID: 162850 RVA: 0x00B21D88 File Offset: 0x00B1FF88
		protected override void OnScrollToScrollViewEvent()
		{
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.RefreshAddItemItem(false);
		}

		// Token: 0x06027C23 RID: 162851 RVA: 0x00B21DA5 File Offset: 0x00B1FFA5
		protected override void OnRemoveFromScrollViewEvent()
		{
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.RefreshAddItemItem(true);
		}

		// Token: 0x06027C24 RID: 162852 RVA: 0x00B21DC2 File Offset: 0x00B1FFC2
		protected override void OnChangeAnimationState()
		{
			this.CheckAnimationStateAndDataSetElementActiveState();
		}

		// Token: 0x06027C25 RID: 162853 RVA: 0x00B21DCA File Offset: 0x00B1FFCA
		protected override void OnItemOverlay()
		{
			base.PlaySequence("HighLight");
		}

		// Token: 0x06027C26 RID: 162854 RVA: 0x00B21DD7 File Offset: 0x00B1FFD7
		protected override void OnItemUnOverlay()
		{
			base.PlaySequence("Normal");
		}

		// Token: 0x06027C27 RID: 162855 RVA: 0x00B21DE4 File Offset: 0x00B1FFE4
		[NullableContext(1)]
		protected override void OnPlaySequence(string sequence)
		{
			if (this.CurrentSequence != sequence)
			{
				this.CurrentSequence = sequence;
				this.LevelSequencePlayer.PlaySequencePurely(sequence, false, false, null, null, false);
			}
		}

		// Token: 0x06027C28 RID: 162856 RVA: 0x00B21E20 File Offset: 0x00B20020
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

		// Token: 0x06027C29 RID: 162857 RVA: 0x00B21EFC File Offset: 0x00B200FC
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

		// Token: 0x06027C2A RID: 162858 RVA: 0x00B21F64 File Offset: 0x00B20164
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

		// Token: 0x06027C2B RID: 162859 RVA: 0x00B21FC8 File Offset: 0x00B201C8
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

		// Token: 0x06027C2C RID: 162860 RVA: 0x00B220FC File Offset: 0x00B202FC
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

		// Token: 0x06027C2D RID: 162861 RVA: 0x00B2216B File Offset: 0x00B2036B
		protected override void OnBeforeClearComponent()
		{
			this.UnBindRedDot();
		}

		// Token: 0x06027C2E RID: 162862 RVA: 0x00B22173 File Offset: 0x00B20373
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x06027C2F RID: 162863 RVA: 0x00B22176 File Offset: 0x00B20376
		public void SetLevelItemShowState(bool state)
		{
			this.NeedLevelShowState = state;
		}

		// Token: 0x04015A94 RID: 88724
		protected Action<int> ClickFunction;

		// Token: 0x04015A95 RID: 88725
		private VisionFetterSuitItem VisionFetterSuitItem;

		// Token: 0x04015A96 RID: 88726
		private CommonWarningItem WarningItem;

		// Token: 0x04015A97 RID: 88727
		private bool RedDotBindState;

		// Token: 0x04015A98 RID: 88728
		private int RedDotType;

		// Token: 0x04015A99 RID: 88729
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015A9A RID: 88730
		[Nullable(1)]
		private string CurrentSequence = "";

		// Token: 0x04015A9B RID: 88731
		private PhantomDataBase CurrentRedDotBindData;

		// Token: 0x04015A9C RID: 88732
		private RoleDataBase CurrentRoleData;

		// Token: 0x04015A9D RID: 88733
		private bool NeedLevelShowState = true;

		// Token: 0x0200989C RID: 39068
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F957 RID: 194903
			ToggleItem,
			// Token: 0x0402F958 RID: 194904
			CircleItem,
			// Token: 0x0402F959 RID: 194905
			CircleItemTexture,
			// Token: 0x0402F95A RID: 194906
			QualitySprite,
			// Token: 0x0402F95B RID: 194907
			CostItem,
			// Token: 0x0402F95C RID: 194908
			CostNumText,
			// Token: 0x0402F95D RID: 194909
			PlusItem,
			// Token: 0x0402F95E RID: 194910
			SuitElementItem,
			// Token: 0x0402F95F RID: 194911
			RedItem,
			// Token: 0x0402F960 RID: 194912
			CircleTextureBlackBg,
			// Token: 0x0402F961 RID: 194913
			AddIconItem,
			// Token: 0x0402F962 RID: 194914
			AniLight,
			// Token: 0x0402F963 RID: 194915
			RemoveItem,
			// Token: 0x0402F964 RID: 194916
			AddIconItem2,
			// Token: 0x0402F965 RID: 194917
			LevelItem,
			// Token: 0x0402F966 RID: 194918
			LevelText,
			// Token: 0x0402F967 RID: 194919
			ItemOccupyPanel,
			// Token: 0x0402F968 RID: 194920
			ItemWarningIcon
		}
	}
}
