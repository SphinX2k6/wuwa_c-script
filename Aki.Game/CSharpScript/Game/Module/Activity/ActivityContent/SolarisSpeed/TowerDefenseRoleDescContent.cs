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
	// Token: 0x020060D6 RID: 24790
	[NullableContext(1)]
	[Nullable(0)]
	internal class TowerDefenseRoleDescContent : UiPanelBase
	{
		// Token: 0x0603EAA6 RID: 256678 RVA: 0x00F2292C File Offset: 0x00F20B2C
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

		// Token: 0x0603EAA7 RID: 256679 RVA: 0x00F229B6 File Offset: 0x00F20BB6
		protected override void OnStart()
		{
			this.Scroll = new GenericScrollViewNew<TowerDefenseRoleDescItem, ITowerDefenseRoleDescData>(base.GetScrollViewWithScrollbar(1), new Func<TowerDefenseRoleDescItem>(this.InitScrollItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, null);
		}

		// Token: 0x0603EAA8 RID: 256680 RVA: 0x00F229E9 File Offset: 0x00F20BE9
		private TowerDefenseRoleDescItem InitScrollItem()
		{
			return new TowerDefenseRoleDescItem();
		}

		// Token: 0x0603EAA9 RID: 256681 RVA: 0x00F229F0 File Offset: 0x00F20BF0
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

		// Token: 0x0603EAAA RID: 256682 RVA: 0x00F22A34 File Offset: 0x00F20C34
		public void Refresh(ITowerDefenseRolePanelData data)
		{
			TowerDefenseSettle value = InstanceDungeonConfig.Instance.GetTowerDefenseSettleById(data.BestTitle).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Title, Array.Empty<object>());
			this.RefreshDescLayout(data.DescDataList.ToArray());
		}

		// Token: 0x04020C31 RID: 134193
		protected GenericScrollViewNew<TowerDefenseRoleDescItem, ITowerDefenseRoleDescData> Scroll;

		// Token: 0x0200C32A RID: 49962
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403AED7 RID: 241367
			public const int Title = 0;

			// Token: 0x0403AED8 RID: 241368
			public const int DescScroll = 1;

			// Token: 0x0403AED9 RID: 241369
			public const int DescItem = 2;
		}
	}
}
