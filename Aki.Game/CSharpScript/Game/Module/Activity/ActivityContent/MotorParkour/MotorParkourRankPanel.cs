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
	// Token: 0x02005373 RID: 21363
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourRankPanel : UiPanelBase
	{
		// Token: 0x0603527C RID: 217724 RVA: 0x00ED839C File Offset: 0x00ED659C
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

		// Token: 0x0603527D RID: 217725 RVA: 0x00ED8428 File Offset: 0x00ED6628
		protected override void OnStart()
		{
			this.RankLayout = new GenericLayout<MotorParkourGameRankItem, MotorParkourRankData>(base.GetVerticalLayout(1), new Func<MotorParkourGameRankItem>(this.CreateRankItem), null, false, true);
			this.DuringTime = ConfigCommonParamById.GetIntConfig("MotorRacingRoundTime").GetValueOrDefault(3000);
		}

		// Token: 0x0603527E RID: 217726 RVA: 0x00ED8473 File Offset: 0x00ED6673
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

		// Token: 0x0603527F RID: 217727 RVA: 0x00ED848E File Offset: 0x00ED668E
		private MotorParkourGameRankItem CreateRankItem()
		{
			return new MotorParkourGameRankItem();
		}

		// Token: 0x0401C0CE RID: 114894
		private GenericLayout<MotorParkourGameRankItem, MotorParkourRankData> RankLayout;

		// Token: 0x0401C0CF RID: 114895
		private int DuringTime;

		// Token: 0x0200AFF8 RID: 45048
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036625 RID: 222757
			public const int TextTitle = 0;

			// Token: 0x04036626 RID: 222758
			public const int LayoutRank = 1;

			// Token: 0x04036627 RID: 222759
			public const int ItemRank = 2;
		}
	}
}
