using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054D2 RID: 21714
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class LinkageRewardProgressPanel : UiPanelBase
	{
		// Token: 0x06035CC7 RID: 220359 RVA: 0x00F07624 File Offset: 0x00F05824
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035CC8 RID: 220360 RVA: 0x00F07734 File Offset: 0x00F05934
		public void Refresh(List<TimePointRewardData> dataList, int checkInDay)
		{
			int num = Math.Min(LinkageRewardProgressPanel.PointComponents.Length, LinkageRewardProgressPanel.DayTextComponents.Length);
			List<TimePointRewardData> list = NoLinq.WhereOrderByTakeToList<TimePointRewardData, long>(dataList, (TimePointRewardData stage) => stage.RewardTime > 0L, (TimePointRewardData stage) => stage.RewardTime, num);
			if (list.Count < num)
			{
				foreach (int name in LinkageRewardProgressPanel.PointComponents)
				{
					UUISprite sprite = base.GetSprite(name);
					if (sprite != null)
					{
						sprite.SetUIActive(false);
					}
				}
				foreach (int name2 in LinkageRewardProgressPanel.DayTextComponents)
				{
					UUIText text = base.GetText(name2);
					if (text != null)
					{
						text.SetUIActive(false);
					}
				}
				return;
			}
			List<int> list2 = new List<int>(list.Count);
			for (int j = 0; j < list.Count; j++)
			{
				list2.Add((int)list[j].RewardTime);
			}
			for (int k = 0; k < num; k++)
			{
				ETimePointRewardState rewardState = list[k].RewardState;
				int name3 = LinkageRewardProgressPanel.DayTextComponents[k];
				int component = LinkageRewardProgressPanel.PointComponents[k];
				UUIText text2 = base.GetText(name3);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				LinkageRewardDayTextUtil.ApplyLinkageRewardDayTextStyle(text2, rewardState);
				this.SetPointState(component, rewardState);
			}
			float fillAmount = LinkageRewardProgressPanel.CalculateProgressFill(list2, checkInDay);
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetFillAmount(fillAmount);
		}

		// Token: 0x06035CC9 RID: 220361 RVA: 0x00F078C4 File Offset: 0x00F05AC4
		private void SetPointState(int component, ETimePointRewardState state)
		{
			UUISprite sprite = base.GetSprite(component);
			if (sprite == null)
			{
				return;
			}
			string resourceId = "SP_CyberWelfarePoint2";
			if (state == ETimePointRewardState.UnlockAndClaimed)
			{
				resourceId = "SP_CyberWelfarePoint3";
			}
			else if (state == ETimePointRewardState.UnlockAndUnClaimed)
			{
				resourceId = "SP_CyberWelfarePoint1";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				return;
			}
			sprite.SetUIActive(false);
			this.SetSpriteByPath(resourcePath, sprite, false, null, delegate(bool _)
			{
				sprite.SetUIActive(true);
			});
		}

		// Token: 0x06035CCA RID: 220362 RVA: 0x00F07950 File Offset: 0x00F05B50
		private static float CalculateProgressFill(List<int> days, int checkInDay)
		{
			int[] array = new int[]
			{
				Math.Max(days[0], 0),
				Math.Max(days[1], 0),
				Math.Max(days[2], 0)
			};
			float[] array2 = new float[]
			{
				0.15f,
				0.57f,
				1f
			};
			int num = Math.Max(checkInDay, 0);
			int num2 = 0;
			float num3 = 0f;
			for (int i = 0; i < array.Length; i++)
			{
				int num4 = array[i];
				float num5 = array2[i];
				if (num < num4)
				{
					int num6 = Math.Max(num4 - num2, 1);
					float val = (float)(num - num2) / (float)num6;
					float num7 = Math.Max(0f, Math.Min(val, 1f));
					return num3 + (num5 - num3) * num7;
				}
				num2 = num4;
				num3 = num5;
			}
			return 1f;
		}

		// Token: 0x0401C779 RID: 116601
		private static readonly int[] PointComponents = new int[]
		{
			1,
			2,
			3
		};

		// Token: 0x0401C77A RID: 116602
		private static readonly int[] DayTextComponents = new int[]
		{
			4,
			5,
			6
		};

		// Token: 0x0200B127 RID: 45351
		[NullableContext(0)]
		private static class EProgressComponents
		{
			// Token: 0x04036C92 RID: 224402
			public const int SprProgress = 0;

			// Token: 0x04036C93 RID: 224403
			public const int SprPoint1 = 1;

			// Token: 0x04036C94 RID: 224404
			public const int SprPoint2 = 2;

			// Token: 0x04036C95 RID: 224405
			public const int SprPoint3 = 3;

			// Token: 0x04036C96 RID: 224406
			public const int TxtDay1 = 4;

			// Token: 0x04036C97 RID: 224407
			public const int TxtDay2 = 5;

			// Token: 0x04036C98 RID: 224408
			public const int TxtDay3 = 6;
		}
	}
}
