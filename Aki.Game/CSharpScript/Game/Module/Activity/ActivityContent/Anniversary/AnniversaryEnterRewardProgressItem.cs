using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006925 RID: 26917
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryEnterRewardProgressItem : GridProxyAbstract<AnniversarySubActivityDataBase>
	{
		// Token: 0x060431C0 RID: 274880 RVA: 0x0105AF70 File Offset: 0x01059170
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x060431C1 RID: 274881 RVA: 0x0105AFAC File Offset: 0x010591AC
		[NullableContext(1)]
		public override void Refresh(AnniversarySubActivityDataBase data, bool isSelected, int gridIndex)
		{
			ValueTuple<int, int> currentProgress = data.GetCurrentProgress();
			int item = currentProgress.Item1;
			int item2 = currentProgress.Item2;
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(item);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			Activity? activityConfig = ActivityConfig.Instance.GetActivityConfig(data.GetActivityId());
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew((activityConfig != null) ? activityConfig.Value.Title : "");
		}

		// Token: 0x0200CACB RID: 51915
		private class EComponents
		{
			// Token: 0x0403D49E RID: 251038
			public const int TxtTitle = 0;

			// Token: 0x0403D49F RID: 251039
			public const int TxtValue = 1;
		}
	}
}
