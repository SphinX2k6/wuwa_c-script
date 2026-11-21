using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005875 RID: 22645
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryEnterRewardProgressItem : GridProxyAbstract<AnniversarySubActivityDataBase>
	{
		// Token: 0x06037D18 RID: 228632 RVA: 0x00F9C59C File Offset: 0x00F9A79C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06037D19 RID: 228633 RVA: 0x00F9C5D8 File Offset: 0x00F9A7D8
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

		// Token: 0x0200B493 RID: 46227
		private class EComponents
		{
			// Token: 0x04037D78 RID: 228728
			public const int TxtTitle = 0;

			// Token: 0x04037D79 RID: 228729
			public const int TxtValue = 1;
		}
	}
}
