using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F5 RID: 25589
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRankPanel : UiPanelBase
	{
		// Token: 0x060405BB RID: 263611 RVA: 0x00F913B4 File Offset: 0x00F8F5B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405BC RID: 263612 RVA: 0x00F91440 File Offset: 0x00F8F640
		protected override void OnStart()
		{
			this.RankLayout = new GenericLayout<MotorParkourGameRankItem, MotorParkourRankData>(base.GetVerticalLayout(1), new Func<MotorParkourGameRankItem>(this.CreateRankItem), null, false, true);
			this.DuringTime = ConfigCommonParamById.GetIntConfig("MotorRacingRoundTime").GetValueOrDefault(3000);
		}

		// Token: 0x060405BD RID: 263613 RVA: 0x00F9148B File Offset: 0x00F8F68B
		public void RefreshRankList(List<MotorParkourRankData> rankDataList)
		{
			this.RankLayout.RefreshByData(rankDataList, delegate
			{
				this.SetActive(true);
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.SetActive(false);
				}, (float)this.DuringTime, null, null, true, 1f);
			}, true);
		}

		// Token: 0x060405BE RID: 263614 RVA: 0x00F914A6 File Offset: 0x00F8F6A6
		private MotorParkourGameRankItem CreateRankItem()
		{
			return new MotorParkourGameRankItem();
		}

		// Token: 0x0402179F RID: 137119
		private GenericLayout<MotorParkourGameRankItem, MotorParkourRankData> RankLayout;

		// Token: 0x040217A0 RID: 137120
		private int DuringTime;

		// Token: 0x0200C611 RID: 50705
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCC6 RID: 244934
			public const int TextTitle = 0;

			// Token: 0x0403BCC7 RID: 244935
			public const int LayoutRank = 1;

			// Token: 0x0403BCC8 RID: 244936
			public const int ItemRank = 2;
		}
	}
}
