using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F07 RID: 24327
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEntrancePointData
	{
		// Token: 0x0603DD08 RID: 253192 RVA: 0x00EF12BC File Offset: 0x00EEF4BC
		public int GetCurrentPoint()
		{
			return this.CurrentPoint;
		}

		// Token: 0x0603DD09 RID: 253193 RVA: 0x00EF12C4 File Offset: 0x00EEF4C4
		public ERedDotName? GetRedDotName()
		{
			return this.RedDotName;
		}

		// Token: 0x0603DD0A RID: 253194 RVA: 0x00EF12CC File Offset: 0x00EEF4CC
		public int GetRedDotId()
		{
			return this.RedDotId;
		}

		// Token: 0x0603DD0B RID: 253195 RVA: 0x00EF12D4 File Offset: 0x00EEF4D4
		public Action GetPointRewardBtnClickCallBack()
		{
			return this.PointRewardBtnClickCallBack;
		}

		// Token: 0x0603DD0C RID: 253196 RVA: 0x00EF12DC File Offset: 0x00EEF4DC
		public int GetLimitPoint()
		{
			return this.LimitPoint;
		}

		// Token: 0x0603DD0D RID: 253197 RVA: 0x00EF12E4 File Offset: 0x00EEF4E4
		public IActivityRewardViewData GetRewardData()
		{
			return this.RewardData;
		}

		// Token: 0x0603DD0E RID: 253198 RVA: 0x00EF12EC File Offset: 0x00EEF4EC
		[NullableContext(1)]
		public string GetScoreDesc()
		{
			if (this.GetScoreDescCallBack == null)
			{
				return string.Empty;
			}
			return this.GetScoreDescCallBack();
		}

		// Token: 0x0603DD0F RID: 253199 RVA: 0x00EF1307 File Offset: 0x00EEF507
		[return: Nullable(1)]
		public static ActivityEntrancePointData Create(int currentPoint, int limitPoint, ERedDotName? redDotName, int redDotId, IActivityRewardViewData rewardData, [Nullable(new byte[]
		{
			2,
			1
		})] Func<string> getScoreDescCallBack, Action pointRewardBtnClickCallBack)
		{
			return new ActivityEntrancePointData
			{
				CurrentPoint = currentPoint,
				RedDotName = redDotName,
				RedDotId = redDotId,
				LimitPoint = limitPoint,
				RewardData = rewardData,
				GetScoreDescCallBack = getScoreDescCallBack,
				PointRewardBtnClickCallBack = pointRewardBtnClickCallBack
			};
		}

		// Token: 0x0402049D RID: 132253
		private int CurrentPoint;

		// Token: 0x0402049E RID: 132254
		private int LimitPoint;

		// Token: 0x0402049F RID: 132255
		private ERedDotName? RedDotName;

		// Token: 0x040204A0 RID: 132256
		private int RedDotId;

		// Token: 0x040204A1 RID: 132257
		private IActivityRewardViewData RewardData;

		// Token: 0x040204A2 RID: 132258
		private Action PointRewardBtnClickCallBack;

		// Token: 0x040204A3 RID: 132259
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<string> GetScoreDescCallBack;
	}
}
