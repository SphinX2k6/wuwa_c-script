using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005317 RID: 21271
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorParkourMapItem : UiPanelBase
	{
		// Token: 0x06034ECE RID: 216782 RVA: 0x00ECD291 File Offset: 0x00ECB491
		public MultiMotorParkourMapItem(MultiMotorLevelData levelData)
		{
			this.LevelData = levelData;
		}

		// Token: 0x06034ECF RID: 216783 RVA: 0x00ECD2C4 File Offset: 0x00ECB4C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUI2DLineRaw));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUI2DLineRaw));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034ED0 RID: 216784 RVA: 0x00ECD3F4 File Offset: 0x00ECB5F4
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorParkourMapItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorParkourMapItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034ED1 RID: 216785 RVA: 0x00ECD437 File Offset: 0x00ECB637
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshOnlineTeamList));
		}

		// Token: 0x06034ED2 RID: 216786 RVA: 0x00ECD458 File Offset: 0x00ECB658
		private void OnRefreshOnlineTeamList()
		{
			List<OnlineTeamData> teamList = OnlineModel.Instance.GetTeamList();
			int num = 0;
			for (int i = 0; i < MultiMotorParkourMapItem.NumberToComponent.Length; i++)
			{
				int num2 = i + 1;
				if (num2 != this.SelfPlayerNumber)
				{
					int playerId = 0;
					foreach (OnlineTeamData onlineTeamData in teamList)
					{
						if (onlineTeamData.PlayerNumber == num2)
						{
							playerId = onlineTeamData.PlayerId;
							break;
						}
					}
					if (num < this.PlayerMarkItemOthers.Count)
					{
						this.PlayerMarkItemOthers[num].PlayerId = playerId;
					}
					num++;
				}
			}
		}

		// Token: 0x06034ED3 RID: 216787 RVA: 0x00ECD510 File Offset: 0x00ECB710
		public void DrawMapPathLine()
		{
			MotorParkourMapModel.Instance.InitSplinePoints(this.LevelData.Config.Value.SplineId, (float)((int)this.LevelData.Config.Value.MapScale), this.CenterOffset, this.LevelData.Config.Value.SplineStartIndex, this.LevelData.Config.Value.SplineEndIndex);
			TArray<FVector2D> splinePoints = MotorParkourMapModel.Instance.SplinePoints;
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(1);
			if (uiLineRaw != null)
			{
				uiLineRaw.SetPoints(splinePoints, false);
			}
			this.MaxPointsCount = splinePoints.Num();
		}

		// Token: 0x06034ED4 RID: 216788 RVA: 0x00ECD5C8 File Offset: 0x00ECB7C8
		public void UpdatePlayerPosition()
		{
			MotorParkourPlayerMarkItem playerMarkItem = this.PlayerMarkItem;
			if (playerMarkItem != null)
			{
				playerMarkItem.UpdatePosition((float)((int)this.LevelData.Config.Value.MapScale), this.CenterOffset);
			}
			foreach (MotorParkourPlayerMarkItem motorParkourPlayerMarkItem in this.PlayerMarkItemOthers)
			{
				motorParkourPlayerMarkItem.UpdateOthersPosition(this.LevelData.Config.Value.MapScale, this.CenterOffset);
			}
			TArray<FVector2D> pathTakenSplinePoints = MotorParkourMapModel.Instance.GetPathTakenSplinePoints();
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(2);
			if (uiLineRaw != null)
			{
				uiLineRaw.SetPoints(pathTakenSplinePoints, false);
			}
			if (this.CurrentPointsCount != pathTakenSplinePoints.Num())
			{
				this.CurrentPointsCount = pathTakenSplinePoints.Num();
				MultiMotorController.Instance.MotorOnlineProgressReportPush(this.LevelData.Config.Value.InstId, (float)this.CurrentPointsCount / (float)this.MaxPointsCount * 10000f);
			}
		}

		// Token: 0x0401BFC9 RID: 114633
		private static readonly int[] NumberToComponent = new int[]
		{
			7,
			5,
			6
		};

		// Token: 0x0401BFCA RID: 114634
		[Nullable(2)]
		private MotorParkourPlayerMarkItem PlayerMarkItem;

		// Token: 0x0401BFCB RID: 114635
		private readonly List<MotorParkourPlayerMarkItem> PlayerMarkItemOthers = new List<MotorParkourPlayerMarkItem>();

		// Token: 0x0401BFCC RID: 114636
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x0401BFCD RID: 114637
		private readonly Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0401BFCE RID: 114638
		private int MaxPointsCount;

		// Token: 0x0401BFCF RID: 114639
		private int CurrentPointsCount;

		// Token: 0x0401BFD0 RID: 114640
		private int SelfPlayerNumber;

		// Token: 0x0401BFD1 RID: 114641
		public MultiMotorLevelData LevelData;

		// Token: 0x0200AF97 RID: 44951
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036457 RID: 222295
			public const int ItemMarkPanel = 0;

			// Token: 0x04036458 RID: 222296
			public const int LineRawMapPath = 1;

			// Token: 0x04036459 RID: 222297
			public const int LineRawPathTaken = 2;

			// Token: 0x0403645A RID: 222298
			public const int ItemEndPoint = 3;

			// Token: 0x0403645B RID: 222299
			public const int ItemPlayer = 4;

			// Token: 0x0403645C RID: 222300
			public const int ItemPlayer2P = 5;

			// Token: 0x0403645D RID: 222301
			public const int ItemPlayer3P = 6;

			// Token: 0x0403645E RID: 222302
			public const int ItemPlayer1P = 7;
		}
	}
}
