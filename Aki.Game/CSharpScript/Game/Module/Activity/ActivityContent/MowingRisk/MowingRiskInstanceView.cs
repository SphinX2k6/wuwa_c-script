using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063E5 RID: 25573
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceView : IInstanceDungeonEntranceAbility
	{
		// Token: 0x1700940B RID: 37899
		// (get) Token: 0x0604051E RID: 263454 RVA: 0x00F8EB06 File Offset: 0x00F8CD06
		public override string ResourceId
		{
			get
			{
				return MowingRiskModel.Instance.InstanceSubViewResourceId;
			}
		}

		// Token: 0x0604051F RID: 263455 RVA: 0x00F8EB14 File Offset: 0x00F8CD14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnLeftClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnRightClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040520 RID: 263456 RVA: 0x00F8ECC8 File Offset: 0x00F8CEC8
		protected override UniTask OnBeforeStartAsync()
		{
			MowingRiskInstanceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040521 RID: 263457 RVA: 0x00F8ED0B File Offset: 0x00F8CF0B
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskBuffAll, base.GetItem(5), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskReward, base.GetItem(7), 0);
		}

		// Token: 0x06040522 RID: 263458 RVA: 0x00F8ED3B File Offset: 0x00F8CF3B
		protected override void OnStart()
		{
			this.InitVerticalPanels();
			EventSystem.Instance.Emit(EEventName.MowingRiskOnRefreshRewardRedDot);
		}

		// Token: 0x06040523 RID: 263459 RVA: 0x00F8ED54 File Offset: 0x00F8CF54
		public override UniTask RefreshExternalAsync()
		{
			MowingRiskInstanceView.<RefreshExternalAsync>d__8 <RefreshExternalAsync>d__;
			<RefreshExternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshExternalAsync>d__.<>4__this = this;
			<RefreshExternalAsync>d__.<>1__state = -1;
			<RefreshExternalAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<RefreshExternalAsync>d__8>(ref <RefreshExternalAsync>d__);
			return <RefreshExternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040524 RID: 263460 RVA: 0x00F8ED98 File Offset: 0x00F8CF98
		public override void RefreshOnTick()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			IMowingRiskInstanceDetailLockItemData data = instance.BuildInstanceDetailLockDataByInstanceId(instance.CurrentInstanceId);
			this.Detail.RefreshLockItemExternalByData(data);
		}

		// Token: 0x06040525 RID: 263461 RVA: 0x00F8EDC2 File Offset: 0x00F8CFC2
		private void OnLeftClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MowingBuffView, EMowingBuffViewUsage.BeforeBattle, null);
		}

		// Token: 0x06040526 RID: 263462 RVA: 0x00F8EDDA File Offset: 0x00F8CFDA
		private void OnRightClick()
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, MowingRiskModel.Instance.BuildActivityRewardViewData(), null);
		}

		// Token: 0x06040527 RID: 263463 RVA: 0x00F8EDF8 File Offset: 0x00F8CFF8
		private UniTask CreateDetailAsync()
		{
			MowingRiskInstanceView.<CreateDetailAsync>d__12 <CreateDetailAsync>d__;
			<CreateDetailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailAsync>d__.<>4__this = this;
			<CreateDetailAsync>d__.<>1__state = -1;
			<CreateDetailAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<CreateDetailAsync>d__12>(ref <CreateDetailAsync>d__);
			return <CreateDetailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040528 RID: 263464 RVA: 0x00F8EE3B File Offset: 0x00F8D03B
		private void InitVerticalPanels()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}

		// Token: 0x04021767 RID: 137063
		private MowingRiskInstanceDetailView Detail;

		// Token: 0x0200C600 RID: 50688
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BC7E RID: 244862
			public const int DetailItem = 0;

			// Token: 0x0403BC7F RID: 244863
			public const int DropDownItem = 1;

			// Token: 0x0403BC80 RID: 244864
			public const int RecommendLevelItem = 2;

			// Token: 0x0403BC81 RID: 244865
			public const int RecommendLevelText = 3;

			// Token: 0x0403BC82 RID: 244866
			public const int LeftButton = 4;

			// Token: 0x0403BC83 RID: 244867
			public const int LeftRedDotItem = 5;

			// Token: 0x0403BC84 RID: 244868
			public const int RightButton = 6;

			// Token: 0x0403BC85 RID: 244869
			public const int RightRedDotItem = 7;

			// Token: 0x0403BC86 RID: 244870
			public const int ProgressText = 8;
		}
	}
}
