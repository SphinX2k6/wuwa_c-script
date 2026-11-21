using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EEE RID: 20206
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityEntrancePointData
	{
		// Token: 0x06032CA3 RID: 208035 RVA: 0x00E42FC4 File Offset: 0x00E411C4
		public int GetCurrentPoint()
		{
			return this.CurrentPoint;
		}

		// Token: 0x06032CA4 RID: 208036 RVA: 0x00E42FCC File Offset: 0x00E411CC
		public ERedDotName? GetRedDotName()
		{
			return this.RedDotName;
		}

		// Token: 0x06032CA5 RID: 208037 RVA: 0x00E42FD4 File Offset: 0x00E411D4
		public int GetRedDotId()
		{
			return this.RedDotId;
		}

		// Token: 0x06032CA6 RID: 208038 RVA: 0x00E42FDC File Offset: 0x00E411DC
		public Action GetPointRewardBtnClickCallBack()
		{
			return this.PointRewardBtnClickCallBack;
		}

		// Token: 0x06032CA7 RID: 208039 RVA: 0x00E42FE4 File Offset: 0x00E411E4
		public int GetLimitPoint()
		{
			return this.LimitPoint;
		}

		// Token: 0x06032CA8 RID: 208040 RVA: 0x00E42FEC File Offset: 0x00E411EC
		public IActivityRewardViewData GetRewardData()
		{
			return this.RewardData;
		}

		// Token: 0x06032CA9 RID: 208041 RVA: 0x00E42FF4 File Offset: 0x00E411F4
		[NullableContext(1)]
		public string GetScoreDesc()
		{
			if (this.GetScoreDescCallBack == null)
			{
				return string.Empty;
			}
			return this.GetScoreDescCallBack();
		}

		// Token: 0x06032CAA RID: 208042 RVA: 0x00E4300F File Offset: 0x00E4120F
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

		// Token: 0x0401AF6F RID: 110447
		private int CurrentPoint;

		// Token: 0x0401AF70 RID: 110448
		private int LimitPoint;

		// Token: 0x0401AF71 RID: 110449
		private ERedDotName? RedDotName;

		// Token: 0x0401AF72 RID: 110450
		private int RedDotId;

		// Token: 0x0401AF73 RID: 110451
		private IActivityRewardViewData RewardData;

		// Token: 0x0401AF74 RID: 110452
		private Action PointRewardBtnClickCallBack;

		// Token: 0x0401AF75 RID: 110453
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<string> GetScoreDescCallBack;
	}
}
