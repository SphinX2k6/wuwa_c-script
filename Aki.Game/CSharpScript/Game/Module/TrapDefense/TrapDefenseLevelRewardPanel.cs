using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB1 RID: 19121
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelRewardPanel : UiPanelBase
	{
		// Token: 0x060318B7 RID: 202935 RVA: 0x00B7D328 File Offset: 0x00B7B528
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelRewardPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelRewardPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060318B8 RID: 202936 RVA: 0x00B7D373 File Offset: 0x00B7B573
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x060318B9 RID: 202937 RVA: 0x00B7D378 File Offset: 0x00B7B578
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060318BA RID: 202938 RVA: 0x00B7D404 File Offset: 0x00B7B604
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelRewardPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelRewardPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318BB RID: 202939 RVA: 0x00B7D447 File Offset: 0x00B7B647
		protected override void OnStart()
		{
		}

		// Token: 0x060318BC RID: 202940 RVA: 0x00B7D449 File Offset: 0x00B7B649
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060318BD RID: 202941 RVA: 0x00B7D44B File Offset: 0x00B7B64B
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060318BE RID: 202942 RVA: 0x00B7D450 File Offset: 0x00B7B650
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			List<ITrapDefenseLevelRewardItemData> rewardShowList = data.GetRewardShowList();
			this.LayoutReward.RefreshByData(rewardShowList, null, false);
			this.SetActive(rewardShowList.Count > 0);
		}

		// Token: 0x060318BF RID: 202943 RVA: 0x00B7D488 File Offset: 0x00B7B688
		public TrapDefenseLevelRewardItem CreateItemReward()
		{
			return new TrapDefenseLevelRewardItem();
		}

		// Token: 0x0401A7A2 RID: 108450
		public TrapDefenseLevelData LevelData;

		// Token: 0x0401A7A3 RID: 108451
		public GenericLayout<TrapDefenseLevelRewardItem, ITrapDefenseLevelRewardItemData> LayoutReward;

		// Token: 0x0200AC0F RID: 44047
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403448F RID: 214159
			public const int TextTitle = 0;

			// Token: 0x04034490 RID: 214160
			public const int LayoutReward = 1;

			// Token: 0x04034491 RID: 214161
			public const int ItemReward = 2;
		}
	}
}
