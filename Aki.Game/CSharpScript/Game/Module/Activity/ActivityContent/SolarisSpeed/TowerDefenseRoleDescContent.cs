using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005054 RID: 20564
	[NullableContext(1)]
	[Nullable(0)]
	internal class TowerDefenseRoleDescContent : UiPanelBase
	{
		// Token: 0x0603376A RID: 210794 RVA: 0x00E696F4 File Offset: 0x00E678F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603376B RID: 210795 RVA: 0x00E6977E File Offset: 0x00E6797E
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<TowerDefenseRoleDescItem, ITowerDefenseRoleDescData>(base.GetScrollViewWithScrollbar(1), new Func<TowerDefenseRoleDescItem>(this.InitScrollItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603376C RID: 210796 RVA: 0x00E697B1 File Offset: 0x00E679B1
		private TowerDefenseRoleDescItem InitScrollItem()
		{
			return new TowerDefenseRoleDescItem();
		}

		// Token: 0x0603376D RID: 210797 RVA: 0x00E697B8 File Offset: 0x00E679B8
		private void RefreshDescLayout(ITowerDefenseRoleDescData[] data)
		{
			TowerDefenseRoleDescContent.<>c__DisplayClass5_0 CS$<>8__locals1 = new TowerDefenseRoleDescContent.<>c__DisplayClass5_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("TowerDefenseRoleDescContent.Refresh", delegate()
			{
				TowerDefenseRoleDescContent.<>c__DisplayClass5_0.<<RefreshDescLayout>b__0>d <<RefreshDescLayout>b__0>d;
				<<RefreshDescLayout>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshDescLayout>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshDescLayout>b__0>d.<>1__state = -1;
				<<RefreshDescLayout>b__0>d.<>t__builder.Start<TowerDefenseRoleDescContent.<>c__DisplayClass5_0.<<RefreshDescLayout>b__0>d>(ref <<RefreshDescLayout>b__0>d);
				return <<RefreshDescLayout>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0603376E RID: 210798 RVA: 0x00E697FC File Offset: 0x00E679FC
		public void Refresh(ITowerDefenseRolePanelData data)
		{
			TowerDefenseSettle value = InstanceDungeonConfig.Instance.GetTowerDefenseSettleById(data.BestTitle).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Title, Array.Empty<object>());
			this.RefreshDescLayout(data.DescDataList.ToArray());
		}

		// Token: 0x0401B55E RID: 111966
		protected GenericScrollViewNew<TowerDefenseRoleDescItem, ITowerDefenseRoleDescData> Scroll;

		// Token: 0x0200AD15 RID: 44309
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403583F RID: 219199
			public const int Title = 0;

			// Token: 0x04035840 RID: 219200
			public const int DescScroll = 1;

			// Token: 0x04035841 RID: 219201
			public const int DescItem = 2;
		}
	}
}
