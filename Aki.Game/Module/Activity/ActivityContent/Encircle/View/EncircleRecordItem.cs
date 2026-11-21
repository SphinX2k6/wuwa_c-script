using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x02003025 RID: 12325
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleRecordItem : UiPanelBase
	{
		// Token: 0x0601D3E0 RID: 119776 RVA: 0x008ED9BC File Offset: 0x008EBBBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D3E1 RID: 119777 RVA: 0x008EDA46 File Offset: 0x008EBC46
		protected override void OnStart()
		{
		}

		// Token: 0x0601D3E2 RID: 119778 RVA: 0x008EDA48 File Offset: 0x008EBC48
		public void Refresh(IEncircleRewardInfo rewardInfo)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			string textStringId = "Encircle_CurrentSteps";
			if (rewardInfo.IsSuccess && rewardInfo.Score != null)
			{
				if (rewardInfo.RecordScore != null)
				{
					int? score = rewardInfo.Score;
					int? recordScore = rewardInfo.RecordScore;
					if (!(score.GetValueOrDefault() < recordScore.GetValueOrDefault() & (score != null & recordScore != null)))
					{
						goto IL_8A;
					}
				}
				UUIItem item2 = base.GetItem(0);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				textStringId = "Encircle_FewestSteps";
			}
			IL_8A:
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textStringId, new <>z__ReadOnlySingleElementList<object>(rewardInfo.Score));
		}

		// Token: 0x0400F64A RID: 63050
		private const string RECORD_TEXT_ID = "Encircle_FewestSteps";

		// Token: 0x0400F64B RID: 63051
		private const string CURRENT_TEXT_ID = "Encircle_CurrentSteps";
	}
}
