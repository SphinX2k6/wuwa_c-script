using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006675 RID: 26229
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleRecordItem : UiPanelBase
	{
		// Token: 0x06041BB8 RID: 269240 RVA: 0x00FF18D4 File Offset: 0x00FEFAD4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06041BB9 RID: 269241 RVA: 0x00FF192E File Offset: 0x00FEFB2E
		protected override void OnStart()
		{
		}

		// Token: 0x06041BBA RID: 269242 RVA: 0x00FF1930 File Offset: 0x00FEFB30
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

		// Token: 0x04022340 RID: 140096
		private const string RECORD_TEXT_ID = "Encircle_FewestSteps";

		// Token: 0x04022341 RID: 140097
		private const string CURRENT_TEXT_ID = "Encircle_CurrentSteps";
	}
}
