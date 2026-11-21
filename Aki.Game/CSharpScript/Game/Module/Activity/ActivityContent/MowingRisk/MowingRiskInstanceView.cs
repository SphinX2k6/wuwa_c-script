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
	// Token: 0x02005363 RID: 21347
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceView : IInstanceDungeonEntranceAbility
	{
		// Token: 0x1700676D RID: 26477
		// (get) Token: 0x060351DF RID: 217567 RVA: 0x00ED5A9E File Offset: 0x00ED3C9E
		public override string ResourceId
		{
			get
			{
				return MowingRiskModel.Instance.InstanceSubViewResourceId;
			}
		}

		// Token: 0x060351E0 RID: 217568 RVA: 0x00ED5AAC File Offset: 0x00ED3CAC
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

		// Token: 0x060351E1 RID: 217569 RVA: 0x00ED5C60 File Offset: 0x00ED3E60
		protected override UniTask OnBeforeStartAsync()
		{
			MowingRiskInstanceView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351E2 RID: 217570 RVA: 0x00ED5CA3 File Offset: 0x00ED3EA3
		protected override void OnBeforeDestroy()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskBuffAll, base.GetItem(5), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotMowingRiskReward, base.GetItem(7), 0);
		}

		// Token: 0x060351E3 RID: 217571 RVA: 0x00ED5CD3 File Offset: 0x00ED3ED3
		protected override void OnStart()
		{
			this.InitVerticalPanels();
			EventSystem.Instance.Emit(EEventName.MowingRiskOnRefreshRewardRedDot);
		}

		// Token: 0x060351E4 RID: 217572 RVA: 0x00ED5CEC File Offset: 0x00ED3EEC
		public override UniTask RefreshExternalAsync()
		{
			MowingRiskInstanceView.<RefreshExternalAsync>d__8 <RefreshExternalAsync>d__;
			<RefreshExternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshExternalAsync>d__.<>4__this = this;
			<RefreshExternalAsync>d__.<>1__state = -1;
			<RefreshExternalAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<RefreshExternalAsync>d__8>(ref <RefreshExternalAsync>d__);
			return <RefreshExternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351E5 RID: 217573 RVA: 0x00ED5D30 File Offset: 0x00ED3F30
		public override void RefreshOnTick()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			IMowingRiskInstanceDetailLockItemData data = instance.BuildInstanceDetailLockDataByInstanceId(instance.CurrentInstanceId);
			this.Detail.RefreshLockItemExternalByData(data);
		}

		// Token: 0x060351E6 RID: 217574 RVA: 0x00ED5D5A File Offset: 0x00ED3F5A
		private void OnLeftClick()
		{
			UiManager.Instance.OpenView(EUiViewName.MowingBuffView, EMowingBuffViewUsage.BeforeBattle, null);
		}

		// Token: 0x060351E7 RID: 217575 RVA: 0x00ED5D72 File Offset: 0x00ED3F72
		private void OnRightClick()
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, MowingRiskModel.Instance.BuildActivityRewardViewData(), null);
		}

		// Token: 0x060351E8 RID: 217576 RVA: 0x00ED5D90 File Offset: 0x00ED3F90
		private UniTask CreateDetailAsync()
		{
			MowingRiskInstanceView.<CreateDetailAsync>d__12 <CreateDetailAsync>d__;
			<CreateDetailAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDetailAsync>d__.<>4__this = this;
			<CreateDetailAsync>d__.<>1__state = -1;
			<CreateDetailAsync>d__.<>t__builder.Start<MowingRiskInstanceView.<CreateDetailAsync>d__12>(ref <CreateDetailAsync>d__);
			return <CreateDetailAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351E9 RID: 217577 RVA: 0x00ED5DD3 File Offset: 0x00ED3FD3
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

		// Token: 0x0401C096 RID: 114838
		private MowingRiskInstanceDetailView Detail;

		// Token: 0x0200AFE7 RID: 45031
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040365DD RID: 222685
			public const int DetailItem = 0;

			// Token: 0x040365DE RID: 222686
			public const int DropDownItem = 1;

			// Token: 0x040365DF RID: 222687
			public const int RecommendLevelItem = 2;

			// Token: 0x040365E0 RID: 222688
			public const int RecommendLevelText = 3;

			// Token: 0x040365E1 RID: 222689
			public const int LeftButton = 4;

			// Token: 0x040365E2 RID: 222690
			public const int LeftRedDotItem = 5;

			// Token: 0x040365E3 RID: 222691
			public const int RightButton = 6;

			// Token: 0x040365E4 RID: 222692
			public const int RightRedDotItem = 7;

			// Token: 0x040365E5 RID: 222693
			public const int ProgressText = 8;
		}
	}
}
