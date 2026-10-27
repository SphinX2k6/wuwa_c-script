using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Settlement
{
	// Token: 0x020062F7 RID: 25335
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballSettleResultView : UiViewBase, IPinballSettleResultViewContext
	{
		// Token: 0x0603FC08 RID: 261128 RVA: 0x00F6CA5C File Offset: 0x00F6AC5C
		[NullableContext(1)]
		public PinballSettleResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170092B2 RID: 37554
		// (get) Token: 0x0603FC09 RID: 261129 RVA: 0x00F6CA65 File Offset: 0x00F6AC65
		public new IPinballSettleResultViewParam OpenParam
		{
			get
			{
				return this.OpenParam as IPinballSettleResultViewParam;
			}
		}

		// Token: 0x0603FC0A RID: 261130 RVA: 0x00F6CA74 File Offset: 0x00F6AC74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 22;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnShop));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnRole));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FC0B RID: 261131 RVA: 0x00F6CDE0 File Offset: 0x00F6AFE0
		protected override void OnBeforeCreate()
		{
			switch (this.OpenParam.LevelType)
			{
			case EPinballLevelShowType.Normal:
				this.Strategy = new PinballSettleResultNormalStrategy();
				break;
			case EPinballLevelShowType.Cow:
				this.Strategy = new PinballSettleResultBonusStrategy();
				break;
			case EPinballLevelShowType.Tower:
				this.Strategy = new PinballSettleResultTowerStrategy();
				break;
			case EPinballLevelShowType.Daily:
				this.Strategy = new PinballSettleResultDailyStrategy();
				break;
			}
			this.Strategy.Context = this;
		}

		// Token: 0x0603FC0C RID: 261132 RVA: 0x00F6CE54 File Offset: 0x00F6B054
		protected override UniTask OnBeforeStartAsync()
		{
			PinballSettleResultView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballSettleResultView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC0D RID: 261133 RVA: 0x00F6CE98 File Offset: 0x00F6B098
		private UniTask InitButtons()
		{
			PinballSettleResultView.<InitButtons>d__17 <InitButtons>d__;
			<InitButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtons>d__.<>4__this = this;
			<InitButtons>d__.<>1__state = -1;
			<InitButtons>d__.<>t__builder.Start<PinballSettleResultView.<InitButtons>d__17>(ref <InitButtons>d__);
			return <InitButtons>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC0E RID: 261134 RVA: 0x00F6CEDC File Offset: 0x00F6B0DC
		private UniTask InitRewardView()
		{
			PinballSettleResultView.<InitRewardView>d__18 <InitRewardView>d__;
			<InitRewardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardView>d__.<>4__this = this;
			<InitRewardView>d__.<>1__state = -1;
			<InitRewardView>d__.<>t__builder.Start<PinballSettleResultView.<InitRewardView>d__18>(ref <InitRewardView>d__);
			return <InitRewardView>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC0F RID: 261135 RVA: 0x00F6CF20 File Offset: 0x00F6B120
		private UniTask InitProgressRewardView()
		{
			PinballSettleResultView.<InitProgressRewardView>d__19 <InitProgressRewardView>d__;
			<InitProgressRewardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitProgressRewardView>d__.<>4__this = this;
			<InitProgressRewardView>d__.<>1__state = -1;
			<InitProgressRewardView>d__.<>t__builder.Start<PinballSettleResultView.<InitProgressRewardView>d__19>(ref <InitProgressRewardView>d__);
			return <InitProgressRewardView>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC10 RID: 261136 RVA: 0x00F6CF64 File Offset: 0x00F6B164
		private UniTask InitDialogView()
		{
			PinballSettleResultView.<InitDialogView>d__20 <InitDialogView>d__;
			<InitDialogView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDialogView>d__.<>4__this = this;
			<InitDialogView>d__.<>1__state = -1;
			<InitDialogView>d__.<>t__builder.Start<PinballSettleResultView.<InitDialogView>d__20>(ref <InitDialogView>d__);
			return <InitDialogView>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC11 RID: 261137 RVA: 0x00F6CFA8 File Offset: 0x00F6B1A8
		private UniTask InitFailTipsView()
		{
			PinballSettleResultView.<InitFailTipsView>d__21 <InitFailTipsView>d__;
			<InitFailTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFailTipsView>d__.<>4__this = this;
			<InitFailTipsView>d__.<>1__state = -1;
			<InitFailTipsView>d__.<>t__builder.Start<PinballSettleResultView.<InitFailTipsView>d__21>(ref <InitFailTipsView>d__);
			return <InitFailTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC12 RID: 261138 RVA: 0x00F6CFEC File Offset: 0x00F6B1EC
		private UniTask InitUnlockTipsView()
		{
			PinballSettleResultView.<InitUnlockTipsView>d__22 <InitUnlockTipsView>d__;
			<InitUnlockTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitUnlockTipsView>d__.<>4__this = this;
			<InitUnlockTipsView>d__.<>1__state = -1;
			<InitUnlockTipsView>d__.<>t__builder.Start<PinballSettleResultView.<InitUnlockTipsView>d__22>(ref <InitUnlockTipsView>d__);
			return <InitUnlockTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC13 RID: 261139 RVA: 0x00F6D030 File Offset: 0x00F6B230
		protected override void OnStart()
		{
			this.UiViewSequence.StartSequenceName = (this.OpenParam.IsWin ? "Victory_In" : "Failure_In");
			this.UiViewSequence.ShowSequenceName = (this.OpenParam.IsWin ? "Victory_ShowView" : "Failure_ShowView");
			this.BindRedDot();
			this.InitStarLayout();
			this.RefreshViewState();
			AudioSystem.Instance.PostEvent("stop_dungeon_huodong_danzhu_battle");
			AudioSystem.Instance.PostEvent("stop_dungeon_huodong_danzhu_boss");
		}

		// Token: 0x0603FC14 RID: 261140 RVA: 0x00F6D0B7 File Offset: 0x00F6B2B7
		protected override void OnDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x0603FC15 RID: 261141 RVA: 0x00F6D0C0 File Offset: 0x00F6B2C0
		protected void RefreshTitle()
		{
			PinballSettleResultStrategyBase pinballSettleResultStrategyBase = this.Strategy as PinballSettleResultStrategyBase;
			if (pinballSettleResultStrategyBase != null && pinballSettleResultStrategyBase.HasCustomRefreshTitle)
			{
				this.Strategy.RefreshTitle();
				return;
			}
			if (this.OpenParam.IsWin)
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(19), "Pinball_BattleSettlement_Success", Array.Empty<object>());
			}
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(this.OpenParam.IsWin);
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!this.OpenParam.IsWin);
		}

		// Token: 0x0603FC16 RID: 261142 RVA: 0x00F6D158 File Offset: 0x00F6B358
		private void InitStarLayout()
		{
			this.StarLayout = new GenericLayout<PinballStarItemView, bool>(base.GetHorizontalLayout(6), () => new PinballStarItemView(), null, false, true);
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603FC17 RID: 261143 RVA: 0x00F6D1AB File Offset: 0x00F6B3AB
		protected void RefreshStarLayout()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshStarLayout();
		}

		// Token: 0x0603FC18 RID: 261144 RVA: 0x00F6D1C0 File Offset: 0x00F6B3C0
		protected void RefreshDamageLayout()
		{
			this.DamageLayout = new GenericLayout<DamageLayoutItemView, IDamageLayoutItemData>(base.GetVerticalLayout(8), () => new DamageLayoutItemView(), null, false, true);
			List<IDamageLayoutItemData> list = new List<IDamageLayoutItemData>();
			foreach (KeyValuePair<int, float> keyValuePair in this.OpenParam.Roles)
			{
				int num;
				float num2;
				keyValuePair.Deconstruct(out num, out num2);
				int roleId = num;
				float damage = num2;
				list.Add(new DamageLayoutItemData
				{
					RoleId = roleId,
					Damage = damage,
					IsWin = this.OpenParam.IsWin
				});
			}
			list.Sort((IDamageLayoutItemData a, IDamageLayoutItemData b) => b.Damage.CompareTo(a.Damage));
			this.DamageLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603FC19 RID: 261145 RVA: 0x00F6D2BC File Offset: 0x00F6B4BC
		protected UniTask RefreshRole()
		{
			PinballSettleResultView.<RefreshRole>d__29 <RefreshRole>d__;
			<RefreshRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRole>d__.<>4__this = this;
			<RefreshRole>d__.<>1__state = -1;
			<RefreshRole>d__.<>t__builder.Start<PinballSettleResultView.<RefreshRole>d__29>(ref <RefreshRole>d__);
			return <RefreshRole>d__.<>t__builder.Task;
		}

		// Token: 0x0603FC1A RID: 261146 RVA: 0x00F6D2FF File Offset: 0x00F6B4FF
		private void RefreshViewState()
		{
			this.RefreshTitle();
			this.RefreshStarLayout();
			this.RefreshDamageLayout();
			this.RefreshButtons();
			this.RefreshRewards();
			this.RefreshProgressRewards();
			this.RefreshFailTips();
			this.RefreshUnlockTips();
			this.RefreshDialog();
			this.RefreshFormationToggle();
		}

		// Token: 0x0603FC1B RID: 261147 RVA: 0x00F6D340 File Offset: 0x00F6B540
		private void RefreshFormationToggle()
		{
			if (this.OpenParam.IsWin)
			{
				UUIItem item = base.GetItem(4);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId);
				bool flag = pinballLevelConfigById != null && pinballLevelConfigById.Value.TrailRoleLength > 0;
				UUIItem item2 = base.GetItem(4);
				if (item2 != null)
				{
					item2.SetUIActive(!flag);
				}
				UUIExtendToggle extendToggle = base.GetExtendToggle(18);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x0603FC1C RID: 261148 RVA: 0x00F6D3D0 File Offset: 0x00F6B5D0
		protected void RefreshButtons()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy != null)
			{
				strategy.RefreshButtons();
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(this.ShouldShowFunctionBtn(EFunctionType.PinballShop));
				}
			}
			UUIButtonComponent button2 = base.GetButton(3);
			if (button2 == null)
			{
				return;
			}
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(this.ShouldShowFunctionBtn(EFunctionType.PinballRole));
		}

		// Token: 0x0603FC1D RID: 261149 RVA: 0x00F6D44C File Offset: 0x00F6B64C
		private bool ShouldShowFunctionBtn(EFunctionType functionType)
		{
			if (!FunctionModel.Instance.IsOpen(functionType))
			{
				return false;
			}
			FunctionCondition? functionCondition = FunctionConfig.Instance.GetFunctionCondition((int)functionType);
			if (functionCondition == null)
			{
				return false;
			}
			ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(functionCondition.Value.OpenConditionId);
			if (conditionGroupConfig == null || conditionGroupConfig.Value.GroupIdLength == 0 || conditionGroupConfig.Value.GroupIdLength > 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "检查弹射物语功能解锁条件组配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConditionGroupId", functionCondition.Value.OpenConditionId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int num = conditionGroupConfig.Value.GroupId(0);
			Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(num);
			if (conditionConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "弹射物语功能解锁条件配置不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("conditionId", num);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			string text;
			conditionConfig.Value.LimitParams().TryGetValue("SubInsId", out text);
			int num2 = (text != null) ? int.Parse(text) : 0;
			if (num2 <= 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PinballBattle;
				ELogAuthor author3 = ELogAuthor.CB;
				string message3 = "弹射物语功能解锁条件配置解锁关卡ID不存在";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("conditionId", num);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				return true;
			}
			return this.OpenParam.LevelId != num2 || !this.OpenParam.IsFirstPass;
		}

		// Token: 0x0603FC1E RID: 261150 RVA: 0x00F6D5E2 File Offset: 0x00F6B7E2
		protected void RefreshRewards()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshRewards();
		}

		// Token: 0x0603FC1F RID: 261151 RVA: 0x00F6D5F4 File Offset: 0x00F6B7F4
		protected void RefreshProgressRewards()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshProgressRewards();
		}

		// Token: 0x0603FC20 RID: 261152 RVA: 0x00F6D608 File Offset: 0x00F6B808
		protected void RefreshFailTips()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null || !strategy.GetIsNeedFailTipsView())
			{
				return;
			}
			PinballSettleResultStrategyBase pinballSettleResultStrategyBase = this.Strategy as PinballSettleResultStrategyBase;
			if (pinballSettleResultStrategyBase != null && pinballSettleResultStrategyBase.HasCustomRefreshFailTips)
			{
				this.Strategy.RefreshFailTips();
				return;
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId);
			if (pinballLevelConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游关卡配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", this.OpenParam.LevelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PinballSettleFailTipsView failTipsView = this.FailTipsView;
			if (failTipsView != null)
			{
				failTipsView.ShowTxt(pinballLevelConfigById.Value.FailTipsTxt);
			}
			PinballSettleFailTipsView failTipsView2 = this.FailTipsView;
			if (failTipsView2 == null)
			{
				return;
			}
			failTipsView2.SetUiActive(true);
		}

		// Token: 0x0603FC21 RID: 261153 RVA: 0x00F6D6DC File Offset: 0x00F6B8DC
		protected void RefreshDialog()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null || !strategy.GetIsNeedDialogView())
			{
				return;
			}
			PinballSettleResultStrategyBase pinballSettleResultStrategyBase = this.Strategy as PinballSettleResultStrategyBase;
			if (pinballSettleResultStrategyBase != null && pinballSettleResultStrategyBase.HasCustomRefreshDialog)
			{
				this.Strategy.RefreshDialog();
				return;
			}
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.OpenParam.MostValuablePlayerRoleId);
			if (pinballRoleConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleId", this.OpenParam.MostValuablePlayerRoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < pinballRoleConfigById.Value.FailBubbleTxtsLength; i++)
			{
				string text = pinballRoleConfigById.Value.FailBubbleTxts(i);
				if (text != null)
				{
					list.Add(text);
				}
			}
			string randomItem = MathUtils.Instance.GetRandomItem<string>(list);
			if (randomItem == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PinballBattle;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "星弹奇游角色配置失败气泡文本不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("RoleId", this.OpenParam.MostValuablePlayerRoleId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			PinballSettleDialogView dialogView = this.DialogView;
			if (dialogView != null)
			{
				dialogView.ShowTxt(randomItem);
			}
			PinballSettleDialogView dialogView2 = this.DialogView;
			if (dialogView2 == null)
			{
				return;
			}
			dialogView2.SetUiActive(true);
		}

		// Token: 0x0603FC22 RID: 261154 RVA: 0x00F6D82E File Offset: 0x00F6BA2E
		protected void RefreshUnlockTips()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshUnlockTips();
		}

		// Token: 0x0603FC23 RID: 261155 RVA: 0x00F6D840 File Offset: 0x00F6BA40
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPinballRoleFunction, base.GetItem(21), null, 0);
		}

		// Token: 0x0603FC24 RID: 261156 RVA: 0x00F6D86F File Offset: 0x00F6BA6F
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPinballRoleFunction, base.GetItem(21), 0);
		}

		// Token: 0x0603FC25 RID: 261157 RVA: 0x00F6D889 File Offset: 0x00F6BA89
		private void OnClickBtnShop()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballShopView, null, null);
		}

		// Token: 0x0603FC26 RID: 261158 RVA: 0x00F6D89C File Offset: 0x00F6BA9C
		private void OnClickBtnRole()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, null, null);
		}

		// Token: 0x0603FC27 RID: 261159 RVA: 0x00F6D8AF File Offset: 0x00F6BAAF
		public void BindRestartButton()
		{
			ButtonItem btnLeft = this.BtnLeft;
			if (btnLeft != null)
			{
				btnLeft.SetLocalTextNew("Pinball_BattleSettlement_Button01", Array.Empty<object>());
			}
			ButtonItem btnLeft2 = this.BtnLeft;
			if (btnLeft2 == null)
			{
				return;
			}
			btnLeft2.SetFunction(delegate(int _)
			{
				this.OnClickBtnRestart();
			});
		}

		// Token: 0x0603FC28 RID: 261160 RVA: 0x00F6D8E8 File Offset: 0x00F6BAE8
		public void BindNextButton()
		{
			ButtonItem btnRight = this.BtnRight;
			if (btnRight != null)
			{
				btnRight.SetLocalTextNew("Pinball_BattleSettlement_Button02", Array.Empty<object>());
			}
			ButtonItem btnRight2 = this.BtnRight;
			if (btnRight2 == null)
			{
				return;
			}
			btnRight2.SetFunction(delegate(int _)
			{
				this.OnClickBtnNext();
			});
		}

		// Token: 0x0603FC29 RID: 261161 RVA: 0x00F6D921 File Offset: 0x00F6BB21
		public void BindBackButton()
		{
			ButtonItem btnRight = this.BtnRight;
			if (btnRight != null)
			{
				btnRight.SetLocalTextNew("Pinball_BattleSettlement_Button03", Array.Empty<object>());
			}
			ButtonItem btnRight2 = this.BtnRight;
			if (btnRight2 == null)
			{
				return;
			}
			btnRight2.SetFunction(delegate(int _)
			{
				this.OnClickBtnBack();
			});
		}

		// Token: 0x0603FC2A RID: 261162 RVA: 0x00F6D95A File Offset: 0x00F6BB5A
		private void OnClickBtnRestart()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.OnClickBtnRestart(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603FC2B RID: 261163 RVA: 0x00F6D978 File Offset: 0x00F6BB78
		private void OnClickBtnNext()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.OnClickBtnNext(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603FC2C RID: 261164 RVA: 0x00F6D996 File Offset: 0x00F6BB96
		private void OnClickBtnBack()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.OnClickBtnBack(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603FC2D RID: 261165 RVA: 0x00F6D9B4 File Offset: 0x00F6BBB4
		[NullableContext(1)]
		public void ShowStarLayout(bool[] starInfo)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			GenericLayout<PinballStarItemView, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(starInfo, null, false);
		}

		// Token: 0x0603FC2E RID: 261166 RVA: 0x00F6D9DC File Offset: 0x00F6BBDC
		public bool GetNeedAdjustFormation()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(18);
			return extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0603FC2F RID: 261167 RVA: 0x00F6D9F4 File Offset: 0x00F6BBF4
		[NullableContext(1)]
		public void ShowRewards(List<TItem> rewardList)
		{
			PinballSettleRewardView rewardView = this.RewardView;
			if (rewardView != null)
			{
				rewardView.SetUiActive(true);
			}
			PinballSettleRewardView rewardView2 = this.RewardView;
			if (rewardView2 == null)
			{
				return;
			}
			rewardView2.ShowRewardList(rewardList);
		}

		// Token: 0x0603FC30 RID: 261168 RVA: 0x00F6DA19 File Offset: 0x00F6BC19
		public void ShowRewardsGot()
		{
			PinballSettleRewardView rewardView = this.RewardView;
			if (rewardView != null)
			{
				rewardView.SetUiActive(true);
			}
			PinballSettleRewardView rewardView2 = this.RewardView;
			if (rewardView2 == null)
			{
				return;
			}
			rewardView2.ShowRewardGot();
		}

		// Token: 0x0603FC31 RID: 261169 RVA: 0x00F6DA3D File Offset: 0x00F6BC3D
		[NullableContext(1)]
		public void ShowProgressRewardList(int score, int[] scoreLevel, int[] scoreLevelDropId)
		{
			PinballSettleProgressRewardView progressRewardView = this.ProgressRewardView;
			if (progressRewardView != null)
			{
				progressRewardView.SetUiActive(true);
			}
			PinballSettleProgressRewardView progressRewardView2 = this.ProgressRewardView;
			if (progressRewardView2 == null)
			{
				return;
			}
			progressRewardView2.ShowProgressRewardList(score, scoreLevel, scoreLevelDropId);
		}

		// Token: 0x0603FC32 RID: 261170 RVA: 0x00F6DA64 File Offset: 0x00F6BC64
		[NullableContext(1)]
		public void ShowSuccessTips(string successTitle)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(19), successTitle, Array.Empty<object>());
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603FC33 RID: 261171 RVA: 0x00F6DAB0 File Offset: 0x00F6BCB0
		[NullableContext(1)]
		public IPinballSettleResultViewParam GetOpenParam()
		{
			return this.OpenParam;
		}

		// Token: 0x0402148A RID: 136330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<PinballStarItemView, bool> StarLayout;

		// Token: 0x0402148B RID: 136331
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<DamageLayoutItemView, IDamageLayoutItemData> DamageLayout;

		// Token: 0x0402148C RID: 136332
		protected ButtonItem BtnLeft;

		// Token: 0x0402148D RID: 136333
		protected ButtonItem BtnRight;

		// Token: 0x0402148E RID: 136334
		protected PinballSettleDialogView DialogView;

		// Token: 0x0402148F RID: 136335
		protected PinballSettleRewardView RewardView;

		// Token: 0x04021490 RID: 136336
		protected PinballSettleProgressRewardView ProgressRewardView;

		// Token: 0x04021491 RID: 136337
		protected PinballSettleFailTipsView FailTipsView;

		// Token: 0x04021492 RID: 136338
		protected PinballSettleUnlockTipsView UnlockTipsView;

		// Token: 0x04021493 RID: 136339
		protected IPinballSettleResultStrategy Strategy;

		// Token: 0x0200C4E9 RID: 50409
		[NullableContext(0)]
		private enum EPinballSettleResultComponent
		{
			// Token: 0x0403B6C0 RID: 243392
			SpineRole,
			// Token: 0x0403B6C1 RID: 243393
			SpineRoleShadow,
			// Token: 0x0403B6C2 RID: 243394
			BtnShop,
			// Token: 0x0403B6C3 RID: 243395
			BtnRole,
			// Token: 0x0403B6C4 RID: 243396
			FormationToggleItem,
			// Token: 0x0403B6C5 RID: 243397
			PnlDialog,
			// Token: 0x0403B6C6 RID: 243398
			StarLayout,
			// Token: 0x0403B6C7 RID: 243399
			StarLayoutItem,
			// Token: 0x0403B6C8 RID: 243400
			DamageLayout,
			// Token: 0x0403B6C9 RID: 243401
			DamageLayoutItem,
			// Token: 0x0403B6CA RID: 243402
			PnlReward,
			// Token: 0x0403B6CB RID: 243403
			PnlProgressRward,
			// Token: 0x0403B6CC RID: 243404
			PnlTips,
			// Token: 0x0403B6CD RID: 243405
			PnlUnlockTips,
			// Token: 0x0403B6CE RID: 243406
			BtnLeft,
			// Token: 0x0403B6CF RID: 243407
			BtnRight,
			// Token: 0x0403B6D0 RID: 243408
			TitleSuccess,
			// Token: 0x0403B6D1 RID: 243409
			TitleFail,
			// Token: 0x0403B6D2 RID: 243410
			FormationToggle,
			// Token: 0x0403B6D3 RID: 243411
			TitleSuccessText,
			// Token: 0x0403B6D4 RID: 243412
			BtnShopRedDot,
			// Token: 0x0403B6D5 RID: 243413
			BtnRoleRedDot
		}
	}
}
