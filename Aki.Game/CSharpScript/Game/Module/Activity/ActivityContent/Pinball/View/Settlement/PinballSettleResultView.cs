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
	// Token: 0x02005275 RID: 21109
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballSettleResultView : UiViewBase, IPinballSettleResultViewContext
	{
		// Token: 0x060348C9 RID: 215241 RVA: 0x00EB39B8 File Offset: 0x00EB1BB8
		[NullableContext(1)]
		public PinballSettleResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x060348CA RID: 215242 RVA: 0x00EB39C1 File Offset: 0x00EB1BC1
		public new IPinballSettleResultViewParam OpenParam
		{
			get
			{
				return this.OpenParam as IPinballSettleResultViewParam;
			}
		}

		// Token: 0x060348CB RID: 215243 RVA: 0x00EB39D0 File Offset: 0x00EB1BD0
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

		// Token: 0x060348CC RID: 215244 RVA: 0x00EB3D3C File Offset: 0x00EB1F3C
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

		// Token: 0x060348CD RID: 215245 RVA: 0x00EB3DB0 File Offset: 0x00EB1FB0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballSettleResultView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballSettleResultView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060348CE RID: 215246 RVA: 0x00EB3DF4 File Offset: 0x00EB1FF4
		private UniTask InitButtons()
		{
			PinballSettleResultView.<InitButtons>d__17 <InitButtons>d__;
			<InitButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtons>d__.<>4__this = this;
			<InitButtons>d__.<>1__state = -1;
			<InitButtons>d__.<>t__builder.Start<PinballSettleResultView.<InitButtons>d__17>(ref <InitButtons>d__);
			return <InitButtons>d__.<>t__builder.Task;
		}

		// Token: 0x060348CF RID: 215247 RVA: 0x00EB3E38 File Offset: 0x00EB2038
		private UniTask InitRewardView()
		{
			PinballSettleResultView.<InitRewardView>d__18 <InitRewardView>d__;
			<InitRewardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardView>d__.<>4__this = this;
			<InitRewardView>d__.<>1__state = -1;
			<InitRewardView>d__.<>t__builder.Start<PinballSettleResultView.<InitRewardView>d__18>(ref <InitRewardView>d__);
			return <InitRewardView>d__.<>t__builder.Task;
		}

		// Token: 0x060348D0 RID: 215248 RVA: 0x00EB3E7C File Offset: 0x00EB207C
		private UniTask InitProgressRewardView()
		{
			PinballSettleResultView.<InitProgressRewardView>d__19 <InitProgressRewardView>d__;
			<InitProgressRewardView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitProgressRewardView>d__.<>4__this = this;
			<InitProgressRewardView>d__.<>1__state = -1;
			<InitProgressRewardView>d__.<>t__builder.Start<PinballSettleResultView.<InitProgressRewardView>d__19>(ref <InitProgressRewardView>d__);
			return <InitProgressRewardView>d__.<>t__builder.Task;
		}

		// Token: 0x060348D1 RID: 215249 RVA: 0x00EB3EC0 File Offset: 0x00EB20C0
		private UniTask InitDialogView()
		{
			PinballSettleResultView.<InitDialogView>d__20 <InitDialogView>d__;
			<InitDialogView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDialogView>d__.<>4__this = this;
			<InitDialogView>d__.<>1__state = -1;
			<InitDialogView>d__.<>t__builder.Start<PinballSettleResultView.<InitDialogView>d__20>(ref <InitDialogView>d__);
			return <InitDialogView>d__.<>t__builder.Task;
		}

		// Token: 0x060348D2 RID: 215250 RVA: 0x00EB3F04 File Offset: 0x00EB2104
		private UniTask InitFailTipsView()
		{
			PinballSettleResultView.<InitFailTipsView>d__21 <InitFailTipsView>d__;
			<InitFailTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFailTipsView>d__.<>4__this = this;
			<InitFailTipsView>d__.<>1__state = -1;
			<InitFailTipsView>d__.<>t__builder.Start<PinballSettleResultView.<InitFailTipsView>d__21>(ref <InitFailTipsView>d__);
			return <InitFailTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x060348D3 RID: 215251 RVA: 0x00EB3F48 File Offset: 0x00EB2148
		private UniTask InitUnlockTipsView()
		{
			PinballSettleResultView.<InitUnlockTipsView>d__22 <InitUnlockTipsView>d__;
			<InitUnlockTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitUnlockTipsView>d__.<>4__this = this;
			<InitUnlockTipsView>d__.<>1__state = -1;
			<InitUnlockTipsView>d__.<>t__builder.Start<PinballSettleResultView.<InitUnlockTipsView>d__22>(ref <InitUnlockTipsView>d__);
			return <InitUnlockTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x060348D4 RID: 215252 RVA: 0x00EB3F8C File Offset: 0x00EB218C
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

		// Token: 0x060348D5 RID: 215253 RVA: 0x00EB4013 File Offset: 0x00EB2213
		protected override void OnDestroy()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060348D6 RID: 215254 RVA: 0x00EB401C File Offset: 0x00EB221C
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

		// Token: 0x060348D7 RID: 215255 RVA: 0x00EB40B4 File Offset: 0x00EB22B4
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

		// Token: 0x060348D8 RID: 215256 RVA: 0x00EB4107 File Offset: 0x00EB2307
		protected void RefreshStarLayout()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshStarLayout();
		}

		// Token: 0x060348D9 RID: 215257 RVA: 0x00EB411C File Offset: 0x00EB231C
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

		// Token: 0x060348DA RID: 215258 RVA: 0x00EB4218 File Offset: 0x00EB2418
		protected UniTask RefreshRole()
		{
			PinballSettleResultView.<RefreshRole>d__29 <RefreshRole>d__;
			<RefreshRole>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRole>d__.<>4__this = this;
			<RefreshRole>d__.<>1__state = -1;
			<RefreshRole>d__.<>t__builder.Start<PinballSettleResultView.<RefreshRole>d__29>(ref <RefreshRole>d__);
			return <RefreshRole>d__.<>t__builder.Task;
		}

		// Token: 0x060348DB RID: 215259 RVA: 0x00EB425B File Offset: 0x00EB245B
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

		// Token: 0x060348DC RID: 215260 RVA: 0x00EB429C File Offset: 0x00EB249C
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

		// Token: 0x060348DD RID: 215261 RVA: 0x00EB432C File Offset: 0x00EB252C
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

		// Token: 0x060348DE RID: 215262 RVA: 0x00EB43A8 File Offset: 0x00EB25A8
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

		// Token: 0x060348DF RID: 215263 RVA: 0x00EB453E File Offset: 0x00EB273E
		protected void RefreshRewards()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshRewards();
		}

		// Token: 0x060348E0 RID: 215264 RVA: 0x00EB4550 File Offset: 0x00EB2750
		protected void RefreshProgressRewards()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshProgressRewards();
		}

		// Token: 0x060348E1 RID: 215265 RVA: 0x00EB4564 File Offset: 0x00EB2764
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

		// Token: 0x060348E2 RID: 215266 RVA: 0x00EB4638 File Offset: 0x00EB2838
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

		// Token: 0x060348E3 RID: 215267 RVA: 0x00EB478A File Offset: 0x00EB298A
		protected void RefreshUnlockTips()
		{
			IPinballSettleResultStrategy strategy = this.Strategy;
			if (strategy == null)
			{
				return;
			}
			strategy.RefreshUnlockTips();
		}

		// Token: 0x060348E4 RID: 215268 RVA: 0x00EB479C File Offset: 0x00EB299C
		private void BindRedDot()
		{
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPinballRoleFunction, base.GetItem(21), null, 0);
		}

		// Token: 0x060348E5 RID: 215269 RVA: 0x00EB47CB File Offset: 0x00EB29CB
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPinballRoleFunction, base.GetItem(21), 0);
		}

		// Token: 0x060348E6 RID: 215270 RVA: 0x00EB47E5 File Offset: 0x00EB29E5
		private void OnClickBtnShop()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballShopView, null, null);
		}

		// Token: 0x060348E7 RID: 215271 RVA: 0x00EB47F8 File Offset: 0x00EB29F8
		private void OnClickBtnRole()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballRoleView, null, null);
		}

		// Token: 0x060348E8 RID: 215272 RVA: 0x00EB480B File Offset: 0x00EB2A0B
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

		// Token: 0x060348E9 RID: 215273 RVA: 0x00EB4844 File Offset: 0x00EB2A44
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

		// Token: 0x060348EA RID: 215274 RVA: 0x00EB487D File Offset: 0x00EB2A7D
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

		// Token: 0x060348EB RID: 215275 RVA: 0x00EB48B6 File Offset: 0x00EB2AB6
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

		// Token: 0x060348EC RID: 215276 RVA: 0x00EB48D4 File Offset: 0x00EB2AD4
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

		// Token: 0x060348ED RID: 215277 RVA: 0x00EB48F2 File Offset: 0x00EB2AF2
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

		// Token: 0x060348EE RID: 215278 RVA: 0x00EB4910 File Offset: 0x00EB2B10
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

		// Token: 0x060348EF RID: 215279 RVA: 0x00EB4938 File Offset: 0x00EB2B38
		public bool GetNeedAdjustFormation()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(18);
			return extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x060348F0 RID: 215280 RVA: 0x00EB4950 File Offset: 0x00EB2B50
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

		// Token: 0x060348F1 RID: 215281 RVA: 0x00EB4975 File Offset: 0x00EB2B75
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

		// Token: 0x060348F2 RID: 215282 RVA: 0x00EB4999 File Offset: 0x00EB2B99
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

		// Token: 0x060348F3 RID: 215283 RVA: 0x00EB49C0 File Offset: 0x00EB2BC0
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

		// Token: 0x060348F4 RID: 215284 RVA: 0x00EB4A0C File Offset: 0x00EB2C0C
		[NullableContext(1)]
		public IPinballSettleResultViewParam GetOpenParam()
		{
			return this.OpenParam;
		}

		// Token: 0x0401BDB9 RID: 114105
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<PinballStarItemView, bool> StarLayout;

		// Token: 0x0401BDBA RID: 114106
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<DamageLayoutItemView, IDamageLayoutItemData> DamageLayout;

		// Token: 0x0401BDBB RID: 114107
		protected ButtonItem BtnLeft;

		// Token: 0x0401BDBC RID: 114108
		protected ButtonItem BtnRight;

		// Token: 0x0401BDBD RID: 114109
		protected PinballSettleDialogView DialogView;

		// Token: 0x0401BDBE RID: 114110
		protected PinballSettleRewardView RewardView;

		// Token: 0x0401BDBF RID: 114111
		protected PinballSettleProgressRewardView ProgressRewardView;

		// Token: 0x0401BDC0 RID: 114112
		protected PinballSettleFailTipsView FailTipsView;

		// Token: 0x0401BDC1 RID: 114113
		protected PinballSettleUnlockTipsView UnlockTipsView;

		// Token: 0x0401BDC2 RID: 114114
		protected IPinballSettleResultStrategy Strategy;

		// Token: 0x0200AED0 RID: 44752
		[NullableContext(0)]
		private enum EPinballSettleResultComponent
		{
			// Token: 0x04036022 RID: 221218
			SpineRole,
			// Token: 0x04036023 RID: 221219
			SpineRoleShadow,
			// Token: 0x04036024 RID: 221220
			BtnShop,
			// Token: 0x04036025 RID: 221221
			BtnRole,
			// Token: 0x04036026 RID: 221222
			FormationToggleItem,
			// Token: 0x04036027 RID: 221223
			PnlDialog,
			// Token: 0x04036028 RID: 221224
			StarLayout,
			// Token: 0x04036029 RID: 221225
			StarLayoutItem,
			// Token: 0x0403602A RID: 221226
			DamageLayout,
			// Token: 0x0403602B RID: 221227
			DamageLayoutItem,
			// Token: 0x0403602C RID: 221228
			PnlReward,
			// Token: 0x0403602D RID: 221229
			PnlProgressRward,
			// Token: 0x0403602E RID: 221230
			PnlTips,
			// Token: 0x0403602F RID: 221231
			PnlUnlockTips,
			// Token: 0x04036030 RID: 221232
			BtnLeft,
			// Token: 0x04036031 RID: 221233
			BtnRight,
			// Token: 0x04036032 RID: 221234
			TitleSuccess,
			// Token: 0x04036033 RID: 221235
			TitleFail,
			// Token: 0x04036034 RID: 221236
			FormationToggle,
			// Token: 0x04036035 RID: 221237
			TitleSuccessText,
			// Token: 0x04036036 RID: 221238
			BtnShopRedDot,
			// Token: 0x04036037 RID: 221239
			BtnRoleRedDot
		}
	}
}
