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
	// Token: 0x02003A59 RID: 14937
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelRewardPanel : UiPanelBase
	{
		// Token: 0x06026647 RID: 157255 RVA: 0x00AC12DC File Offset: 0x00ABF4DC
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

		// Token: 0x06026648 RID: 157256 RVA: 0x00AC1327 File Offset: 0x00ABF527
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x00AC132C File Offset: 0x00ABF52C
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

		// Token: 0x0602664A RID: 157258 RVA: 0x00AC13B8 File Offset: 0x00ABF5B8
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelRewardPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelRewardPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602664B RID: 157259 RVA: 0x00AC13FB File Offset: 0x00ABF5FB
		protected override void OnStart()
		{
		}

		// Token: 0x0602664C RID: 157260 RVA: 0x00AC13FD File Offset: 0x00ABF5FD
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602664D RID: 157261 RVA: 0x00AC13FF File Offset: 0x00ABF5FF
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602664E RID: 157262 RVA: 0x00AC1404 File Offset: 0x00ABF604
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			List<ITrapDefenseLevelRewardItemData> rewardShowList = data.GetRewardShowList();
			this.LayoutReward.RefreshByData(rewardShowList, null, false);
			this.SetActive(rewardShowList.Count > 0);
		}

		// Token: 0x0602664F RID: 157263 RVA: 0x00AC143C File Offset: 0x00ABF63C
		public TrapDefenseLevelRewardItem CreateItemReward()
		{
			return new TrapDefenseLevelRewardItem();
		}

		// Token: 0x040150F4 RID: 86260
		public TrapDefenseLevelData LevelData;

		// Token: 0x040150F5 RID: 86261
		public GenericLayout<TrapDefenseLevelRewardItem, ITrapDefenseLevelRewardItemData> LayoutReward;

		// Token: 0x0200962F RID: 38447
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE40 RID: 192064
			public const int TextTitle = 0;

			// Token: 0x0402EE41 RID: 192065
			public const int LayoutReward = 1;

			// Token: 0x0402EE42 RID: 192066
			public const int ItemReward = 2;
		}
	}
}
