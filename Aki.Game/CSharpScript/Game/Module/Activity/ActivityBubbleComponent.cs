using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EFC RID: 24316
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityBubbleComponent
	{
		// Token: 0x0603DC87 RID: 253063 RVA: 0x00EEFB03 File Offset: 0x00EEDD03
		public ActivityBubbleComponent(UUIItem bubbleRootItem, UUISprite bubbleSprite, UUIText bubbleText, Action<string, UUISprite, bool> setSpriteDelegate)
		{
			this.BubbleRootItem = bubbleRootItem;
			this.BubbleSprite = bubbleSprite;
			this.BubbleText = bubbleText;
			this.SetSpriteDelegate = setSpriteDelegate;
		}

		// Token: 0x0603DC88 RID: 253064 RVA: 0x00EEFB28 File Offset: 0x00EEDD28
		public bool RefreshBubble(ActivityBaseData data)
		{
			this.Data = data;
			ActivityModel instance = ActivityModel.Instance;
			if (data.RedPointShowState)
			{
				this.HideBubble();
				return false;
			}
			data.UpdateImportantBubble();
			if (!data.IsShowImportantBubble || data.BubbleType == EActivityBubbleType.None)
			{
				this.HideBubble();
				return false;
			}
			if (data.BubbleType != EActivityBubbleType.Important && instance.CheckBubbleHasClicked(data.Id, data.BubbleType))
			{
				this.HideBubble();
				return false;
			}
			string resourceId;
			if (!ActivityBubbleComponent.BubbleTypeToResourcePathMap.TryGetValue(data.BubbleType, out resourceId))
			{
				this.HideBubble();
				return false;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				this.HideBubble();
				return false;
			}
			this.ShowBubble();
			this.SetSpriteDelegate(resourcePath, this.BubbleSprite, false);
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat7(this.GetRemainTime(data.BubbleEndShowTime)).CountDownText;
			if (!string.IsNullOrEmpty(countDownText))
			{
				this.BubbleText.SetText(countDownText, true);
			}
			return true;
		}

		// Token: 0x0603DC89 RID: 253065 RVA: 0x00EEFC1D File Offset: 0x00EEDE1D
		public void ShowBubble()
		{
			this.IsShowBubble = true;
			this.BubbleRootItem.SetUIActive(true);
		}

		// Token: 0x0603DC8A RID: 253066 RVA: 0x00EEFC32 File Offset: 0x00EEDE32
		public void HideBubble()
		{
			this.IsShowBubble = false;
			this.BubbleRootItem.SetUIActive(false);
		}

		// Token: 0x0603DC8B RID: 253067 RVA: 0x00EEFC48 File Offset: 0x00EEDE48
		public bool CheckToUpdateBubbleClickState()
		{
			if (this.IsShowBubble)
			{
				ActivityBaseData data = this.Data;
				if (data == null || data.BubbleType > EActivityBubbleType.None)
				{
					bool flag = ActivityModel.Instance.CheckBubbleHasClicked(this.Data.Id, this.Data.BubbleType);
					ActivityModel.Instance.SetBubbleHasClicked(this.Data.Id, this.Data.BubbleType);
					bool flag2 = ActivityModel.Instance.CheckBubbleHasClicked(this.Data.Id, this.Data.BubbleType);
					return flag != flag2;
				}
			}
			return false;
		}

		// Token: 0x0603DC8C RID: 253068 RVA: 0x00EEFCDD File Offset: 0x00EEDEDD
		public bool GetIsShowBubble()
		{
			return this.IsShowBubble;
		}

		// Token: 0x0603DC8D RID: 253069 RVA: 0x00EEFCE8 File Offset: 0x00EEDEE8
		private double GetRemainTime(long endTime)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return Math.Max((double)endTime - serverTime, 1.0);
		}

		// Token: 0x0402047C RID: 132220
		[Nullable(2)]
		private ActivityBaseData Data;

		// Token: 0x0402047D RID: 132221
		private bool IsShowBubble;

		// Token: 0x0402047E RID: 132222
		private static readonly IReadOnlyDictionary<EActivityBubbleType, string> BubbleTypeToResourcePathMap = new Dictionary<EActivityBubbleType, string>
		{
			{
				EActivityBubbleType.Normal,
				"WhiteTimeIcon"
			},
			{
				EActivityBubbleType.Remind,
				"YellowTimeIcon"
			},
			{
				EActivityBubbleType.Important,
				"RedTimeIcon"
			}
		};

		// Token: 0x0402047F RID: 132223
		private UUIItem BubbleRootItem;

		// Token: 0x04020480 RID: 132224
		private UUISprite BubbleSprite;

		// Token: 0x04020481 RID: 132225
		private UUIText BubbleText;

		// Token: 0x04020482 RID: 132226
		private Action<string, UUISprite, bool> SetSpriteDelegate;
	}
}
