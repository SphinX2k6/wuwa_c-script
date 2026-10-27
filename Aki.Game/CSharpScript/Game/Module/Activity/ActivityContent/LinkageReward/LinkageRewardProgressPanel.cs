using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x02006554 RID: 25940
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class LinkageRewardProgressPanel : UiPanelBase
	{
		// Token: 0x06041002 RID: 266242 RVA: 0x00FC0634 File Offset: 0x00FBE834
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

		// Token: 0x06041003 RID: 266243 RVA: 0x00FC0744 File Offset: 0x00FBE944
		public void Refresh(List<TimePointRewardData> dataList, int checkInDay)
		{
			int num = Math.Min(LinkageRewardProgressPanel.PointComponents.Length, LinkageRewardProgressPanel.DayTextComponents.Length);
			List<TimePointRewardData> list = (from x in dataList
			where x.RewardTime > 0L
			select x into a
			orderby a.RewardTime
			select a).Take(num).ToList<TimePointRewardData>();
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
			List<int> days = (from x in list
			select (int)x.RewardTime).ToList<int>();
			for (int j = 0; j < num; j++)
			{
				ETimePointRewardState rewardState = list[j].RewardState;
				int name3 = LinkageRewardProgressPanel.DayTextComponents[j];
				int component = LinkageRewardProgressPanel.PointComponents[j];
				UUIText text2 = base.GetText(name3);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				LinkageRewardDayTextUtil.ApplyLinkageRewardDayTextStyle(text2, rewardState);
				this.SetPointState(component, rewardState);
			}
			float fillAmount = LinkageRewardProgressPanel.CalculateProgressFill(days, checkInDay);
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

		// Token: 0x06041004 RID: 266244 RVA: 0x00FC08DC File Offset: 0x00FBEADC
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

		// Token: 0x06041005 RID: 266245 RVA: 0x00FC0968 File Offset: 0x00FBEB68
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

		// Token: 0x04021E48 RID: 138824
		private static readonly int[] PointComponents = new int[]
		{
			1,
			2,
			3
		};

		// Token: 0x04021E49 RID: 138825
		private static readonly int[] DayTextComponents = new int[]
		{
			4,
			5,
			6
		};

		// Token: 0x0200C742 RID: 51010
		[NullableContext(0)]
		private static class EProgressComponents
		{
			// Token: 0x0403C33F RID: 246591
			public const int SprProgress = 0;

			// Token: 0x0403C340 RID: 246592
			public const int SprPoint1 = 1;

			// Token: 0x0403C341 RID: 246593
			public const int SprPoint2 = 2;

			// Token: 0x0403C342 RID: 246594
			public const int SprPoint3 = 3;

			// Token: 0x0403C343 RID: 246595
			public const int TxtDay1 = 4;

			// Token: 0x0403C344 RID: 246596
			public const int TxtDay2 = 5;

			// Token: 0x0403C345 RID: 246597
			public const int TxtDay3 = 6;
		}
	}
}
