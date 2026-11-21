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
	// Token: 0x02005360 RID: 21344
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskInstanceDetailView : UiPanelBase
	{
		// Token: 0x060351CE RID: 217550 RVA: 0x00ED55D4 File Offset: 0x00ED37D4
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

		// Token: 0x060351CF RID: 217551 RVA: 0x00ED57C8 File Offset: 0x00ED39C8
		protected override UniTask OnBeforeStartAsync()
		{
			MowingRiskInstanceDetailView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MowingRiskInstanceDetailView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060351D0 RID: 217552 RVA: 0x00ED580B File Offset: 0x00ED3A0B
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

		// Token: 0x060351D1 RID: 217553 RVA: 0x00ED5832 File Offset: 0x00ED3A32
		private void ClickHelper()
		{
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, InstanceDungeonEntranceModel.Instance.SelectInstanceId, null);
		}

		// Token: 0x060351D2 RID: 217554 RVA: 0x00ED5853 File Offset: 0x00ED3A53
		private MowingRiskInstanceDetailAttributeGridItem CreateAttributeItem()
		{
			return new MowingRiskInstanceDetailAttributeGridItem();
		}

		// Token: 0x060351D3 RID: 217555 RVA: 0x00ED585A File Offset: 0x00ED3A5A
		private void OnClickLeft(int _)
		{
		}

		// Token: 0x060351D4 RID: 217556 RVA: 0x00ED585C File Offset: 0x00ED3A5C
		private void OnClickRight(int _)
		{
			EventSystem.Instance.Emit(EEventName.OnClickEnterInstanceSingle);
		}

		// Token: 0x060351D5 RID: 217557 RVA: 0x00ED5870 File Offset: 0x00ED3A70
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

		// Token: 0x060351D6 RID: 217558 RVA: 0x00ED58C0 File Offset: 0x00ED3AC0
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

		// Token: 0x060351D7 RID: 217559 RVA: 0x00ED590B File Offset: 0x00ED3B0B
		public void RefreshLockItemExternalByData(IMowingRiskInstanceDetailLockItemData data)
		{
			this.RefreshLockItem(data);
		}

		// Token: 0x0401C092 RID: 114834
		private GenericLayout<MowingRiskInstanceDetailAttributeGridItem, IMowingRiskInstanceDetailAttributeItemData> AttributeLayout;

		// Token: 0x0401C093 RID: 114835
		private ButtonItem LeftButton;

		// Token: 0x0401C094 RID: 114836
		private ButtonItem RightButton;

		// Token: 0x0401C095 RID: 114837
		private MowingRiskInstanceDetailLockItem LockItem;

		// Token: 0x0200AFE2 RID: 45026
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x040365C2 RID: 222658
			public const int TitleText = 0;

			// Token: 0x040365C3 RID: 222659
			public const int RecommendElementItem = 1;

			// Token: 0x040365C4 RID: 222660
			public const int RecommendElementIconItem = 2;

			// Token: 0x040365C5 RID: 222661
			public const int ContentText = 3;

			// Token: 0x040365C6 RID: 222662
			public const int HelperButton = 4;

			// Token: 0x040365C7 RID: 222663
			public const int AttributeLayout = 5;

			// Token: 0x040365C8 RID: 222664
			public const int AttributeGridItem = 6;

			// Token: 0x040365C9 RID: 222665
			public const int LeftButtonItem = 7;

			// Token: 0x040365CA RID: 222666
			public const int RightButtonItem = 8;

			// Token: 0x040365CB RID: 222667
			public const int LockItem = 9;

			// Token: 0x040365CC RID: 222668
			public const int AddRootItem = 10;

			// Token: 0x040365CD RID: 222669
			public const int RecommendTitleText = 11;
		}
	}
}
