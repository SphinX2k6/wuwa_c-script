using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063E2 RID: 25570
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailView : UiPanelBase
	{
		// Token: 0x0604050D RID: 263437 RVA: 0x00F8E63C File Offset: 0x00F8C83C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ClickHelper));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604050E RID: 263438 RVA: 0x00F8E830 File Offset: 0x00F8CA30
		protected override UniTask OnBeforeStartAsync()
		{
			MowingRiskInstanceDetailView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingRiskInstanceDetailView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604050F RID: 263439 RVA: 0x00F8E873 File Offset: 0x00F8CA73
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06040510 RID: 263440 RVA: 0x00F8E89A File Offset: 0x00F8CA9A
		private void ClickHelper()
		{
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, InstanceDungeonEntranceModel.Instance.SelectInstanceId, null);
		}

		// Token: 0x06040511 RID: 263441 RVA: 0x00F8E8BB File Offset: 0x00F8CABB
		private MowingRiskInstanceDetailAttributeGridItem CreateAttributeItem()
		{
			return new MowingRiskInstanceDetailAttributeGridItem();
		}

		// Token: 0x06040512 RID: 263442 RVA: 0x00F8E8C2 File Offset: 0x00F8CAC2
		private void OnClickLeft(int _)
		{
		}

		// Token: 0x06040513 RID: 263443 RVA: 0x00F8E8C4 File Offset: 0x00F8CAC4
		private void OnClickRight(int _)
		{
			EventSystem.Instance.Emit(EEventName.OnClickEnterInstanceSingle);
		}

		// Token: 0x06040514 RID: 263444 RVA: 0x00F8E8D8 File Offset: 0x00F8CAD8
		private void RefreshLockItem(IMowingRiskInstanceDetailLockItemData data)
		{
			if (data != null)
			{
				this.RightButton.SetUiActive(false);
				this.LockItem.SetUiActive(true);
				this.LockItem.RefreshExternalByData(data);
				return;
			}
			this.RightButton.SetUiActive(true);
			this.LockItem.SetUiActive(false);
		}

		// Token: 0x06040515 RID: 263445 RVA: 0x00F8E928 File Offset: 0x00F8CB28
		public UniTask RefreshExternalByDataAsync(IMowingRiskInstanceDetailData data)
		{
			MowingRiskInstanceDetailView.<RefreshExternalByDataAsync>d__13 <RefreshExternalByDataAsync>d__;
			<RefreshExternalByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshExternalByDataAsync>d__.<>4__this = this;
			<RefreshExternalByDataAsync>d__.data = data;
			<RefreshExternalByDataAsync>d__.<>1__state = -1;
			<RefreshExternalByDataAsync>d__.<>t__builder.Start<MowingRiskInstanceDetailView.<RefreshExternalByDataAsync>d__13>(ref <RefreshExternalByDataAsync>d__);
			return <RefreshExternalByDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040516 RID: 263446 RVA: 0x00F8E973 File Offset: 0x00F8CB73
		public void RefreshLockItemExternalByData(IMowingRiskInstanceDetailLockItemData data)
		{
			this.RefreshLockItem(data);
		}

		// Token: 0x04021763 RID: 137059
		private GenericLayout<MowingRiskInstanceDetailAttributeGridItem, IMowingRiskInstanceDetailAttributeItemData> AttributeLayout;

		// Token: 0x04021764 RID: 137060
		private ButtonItem LeftButton;

		// Token: 0x04021765 RID: 137061
		private ButtonItem RightButton;

		// Token: 0x04021766 RID: 137062
		private MowingRiskInstanceDetailLockItem LockItem;

		// Token: 0x0200C5FB RID: 50683
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0403BC63 RID: 244835
			public const int TitleText = 0;

			// Token: 0x0403BC64 RID: 244836
			public const int RecommendElementItem = 1;

			// Token: 0x0403BC65 RID: 244837
			public const int RecommendElementIconItem = 2;

			// Token: 0x0403BC66 RID: 244838
			public const int ContentText = 3;

			// Token: 0x0403BC67 RID: 244839
			public const int HelperButton = 4;

			// Token: 0x0403BC68 RID: 244840
			public const int AttributeLayout = 5;

			// Token: 0x0403BC69 RID: 244841
			public const int AttributeGridItem = 6;

			// Token: 0x0403BC6A RID: 244842
			public const int LeftButtonItem = 7;

			// Token: 0x0403BC6B RID: 244843
			public const int RightButtonItem = 8;

			// Token: 0x0403BC6C RID: 244844
			public const int LockItem = 9;

			// Token: 0x0403BC6D RID: 244845
			public const int AddRootItem = 10;

			// Token: 0x0403BC6E RID: 244846
			public const int RecommendTitleText = 11;
		}
	}
}
