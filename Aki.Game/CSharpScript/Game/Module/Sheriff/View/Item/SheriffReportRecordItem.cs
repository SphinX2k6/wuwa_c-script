using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Item
{
	// Token: 0x02003C27 RID: 15399
	public class SheriffReportRecordItem : UiTabViewBase
	{
		// Token: 0x06027736 RID: 161590 RVA: 0x00B10F74 File Offset: 0x00B0F174
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027737 RID: 161591 RVA: 0x00B11020 File Offset: 0x00B0F220
		protected override void OnBeforeShow()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06027738 RID: 161592 RVA: 0x00B1104C File Offset: 0x00B0F24C
		protected override void OnStart()
		{
			int criminalId = (int)this.ExtraParams;
			SheriffCriminalInfo criminalInfo = SheriffModel.Instance.GetCriminalInfo(criminalId);
			SheriffCriminal value = SheriffConfig.Instance.GetCriminalConfigById(criminalInfo.CriminalId).Value;
			SheriffIdentity value2 = SheriffConfig.Instance.GetIdentityConfigById(criminalInfo.Identity).Value;
			SheriffAnomalyInfo anomalyInfo = SheriffModel.Instance.GetAnomalyInfo(value.SheriffAnomalyId);
			SheriffEnding value3 = SheriffConfig.Instance.GetEndingConfigById(anomalyInfo.EndingId).Value;
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(value2.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Sheriff_EventProgress_18", new <>z__ReadOnlySingleElementList<object>(configTextByKey));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), value3.Context, Array.Empty<object>());
			base.SetTextureByPath(value3.Icon, base.GetTexture(0), null, null);
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)anomalyInfo.EndingTime);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Sheriff_EventProgress_20", new <>z__ReadOnlyArray<object>(new object[]
			{
				dataFromTimeStamp.Year,
				dataFromTimeStamp.Month,
				dataFromTimeStamp.Day
			}));
		}

		// Token: 0x02009849 RID: 38985
		private static class EDefine
		{
			// Token: 0x0402F80E RID: 194574
			public const int TexRecord = 0;

			// Token: 0x0402F80F RID: 194575
			public const int TxtTime = 1;

			// Token: 0x0402F810 RID: 194576
			public const int TxtName = 2;

			// Token: 0x0402F811 RID: 194577
			public const int TxtInfo = 3;
		}
	}
}
