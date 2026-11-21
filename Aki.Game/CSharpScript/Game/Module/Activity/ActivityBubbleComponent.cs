using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE3 RID: 20195
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityBubbleComponent
	{
		// Token: 0x06032C22 RID: 207906 RVA: 0x00E417C7 File Offset: 0x00E3F9C7
		public ActivityBubbleComponent(UUIItem bubbleRootItem, UUISprite bubbleSprite, UUIText bubbleText, Action<string, UUISprite, bool> setSpriteDelegate)
		{
			this.BubbleRootItem = bubbleRootItem;
			this.BubbleSprite = bubbleSprite;
			this.BubbleText = bubbleText;
			this.SetSpriteDelegate = setSpriteDelegate;
		}

		// Token: 0x06032C23 RID: 207907 RVA: 0x00E417EC File Offset: 0x00E3F9EC
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

		// Token: 0x06032C24 RID: 207908 RVA: 0x00E418E1 File Offset: 0x00E3FAE1
		public void ShowBubble()
		{
			this.IsShowBubble = true;
			this.BubbleRootItem.SetUIActive(true);
		}

		// Token: 0x06032C25 RID: 207909 RVA: 0x00E418F6 File Offset: 0x00E3FAF6
		public void HideBubble()
		{
			this.IsShowBubble = false;
			this.BubbleRootItem.SetUIActive(false);
		}

		// Token: 0x06032C26 RID: 207910 RVA: 0x00E4190C File Offset: 0x00E3FB0C
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

		// Token: 0x06032C27 RID: 207911 RVA: 0x00E419A1 File Offset: 0x00E3FBA1
		public bool GetIsShowBubble()
		{
			return this.IsShowBubble;
		}

		// Token: 0x06032C28 RID: 207912 RVA: 0x00E419AC File Offset: 0x00E3FBAC
		private double GetRemainTime(long endTime)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return Math.Max((double)endTime - serverTime, 1.0);
		}

		// Token: 0x0401AF4E RID: 110414
		[Nullable(2)]
		private ActivityBaseData Data;

		// Token: 0x0401AF4F RID: 110415
		private bool IsShowBubble;

		// Token: 0x0401AF50 RID: 110416
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

		// Token: 0x0401AF51 RID: 110417
		private UUIItem BubbleRootItem;

		// Token: 0x0401AF52 RID: 110418
		private UUISprite BubbleSprite;

		// Token: 0x0401AF53 RID: 110419
		private UUIText BubbleText;

		// Token: 0x0401AF54 RID: 110420
		private Action<string, UUISprite, bool> SetSpriteDelegate;
	}
}
