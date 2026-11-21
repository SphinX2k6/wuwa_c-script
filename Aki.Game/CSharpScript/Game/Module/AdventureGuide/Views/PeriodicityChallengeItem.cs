using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EC4 RID: 20164
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PeriodicityChallengeItem : GridProxyAbstract<IPeriodicityChallengeItem>
	{
		// Token: 0x06032B4A RID: 207690 RVA: 0x00E3BF00 File Offset: 0x00E3A100
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032B4B RID: 207691 RVA: 0x00E3BFAC File Offset: 0x00E3A1AC
		protected override UniTask OnBeforeStartAsync()
		{
			PeriodicityChallengeItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PeriodicityChallengeItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B4C RID: 207692 RVA: 0x00E3BFF0 File Offset: 0x00E3A1F0
		[NullableContext(1)]
		public override void Refresh(IPeriodicityChallengeItem data, bool isSelected, int gridIndex)
		{
			if (!data.Title)
			{
				this.PeriodicityChallengeTitleItem.SetUiActive(false);
			}
			else
			{
				this.PeriodicityChallengeTitleItem.SetUiActive(true);
				this.PeriodicityChallengeTitleItem.RefreshItem(data.Data);
			}
			if (data.TopTips != null)
			{
				this.TipsTopItem.SetUiActive(true);
				this.TipsTopItem.Refresh(data.TopTips);
			}
			else
			{
				this.TipsTopItem.SetUiActive(false);
			}
			PeriodicityChallengeDetectionItem periodicityChallengeDetectionItem = this.PeriodicityChallengeDetectionItem;
			if (periodicityChallengeDetectionItem != null)
			{
				periodicityChallengeDetectionItem.SetUiActive(true);
			}
			PeriodicityChallengeDetectionItem periodicityChallengeDetectionItem2 = this.PeriodicityChallengeDetectionItem;
			if (periodicityChallengeDetectionItem2 == null)
			{
				return;
			}
			periodicityChallengeDetectionItem2.RefreshItem(data.Data);
		}

		// Token: 0x0401AEB1 RID: 110257
		private PeriodicityChallengeTitleItem PeriodicityChallengeTitleItem;

		// Token: 0x0401AEB2 RID: 110258
		private PeriodicityChallengeDetectionItem PeriodicityChallengeDetectionItem;

		// Token: 0x0401AEB3 RID: 110259
		private PeriodicityChallengeItemTopTips TipsTopItem;
	}
}
