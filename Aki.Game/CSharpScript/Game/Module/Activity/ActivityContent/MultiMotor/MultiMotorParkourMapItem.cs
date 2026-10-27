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
	// Token: 0x02006399 RID: 25497
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorParkourMapItem : UiPanelBase
	{
		// Token: 0x0604020D RID: 262669 RVA: 0x00F8631D File Offset: 0x00F8451D
		public MultiMotorParkourMapItem(MultiMotorLevelData levelData)
		{
			this.LevelData = levelData;
		}

		// Token: 0x0604020E RID: 262670 RVA: 0x00F86350 File Offset: 0x00F84550
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

		// Token: 0x0604020F RID: 262671 RVA: 0x00F86480 File Offset: 0x00F84680
		protected override UniTask OnBeforeStartAsync()
		{
			MultiMotorParkourMapItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiMotorParkourMapItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040210 RID: 262672 RVA: 0x00F864C3 File Offset: 0x00F846C3
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshOnlineTeamList, new Action(this.OnRefreshOnlineTeamList));
		}

		// Token: 0x06040211 RID: 262673 RVA: 0x00F864E4 File Offset: 0x00F846E4
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

		// Token: 0x06040212 RID: 262674 RVA: 0x00F8659C File Offset: 0x00F8479C
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

		// Token: 0x06040213 RID: 262675 RVA: 0x00F86654 File Offset: 0x00F84854
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

		// Token: 0x0402169A RID: 136858
		private static readonly int[] NumberToComponent = new int[]
		{
			7,
			5,
			6
		};

		// Token: 0x0402169B RID: 136859
		[Nullable(2)]
		private MotorParkourPlayerMarkItem PlayerMarkItem;

		// Token: 0x0402169C RID: 136860
		private readonly List<MotorParkourPlayerMarkItem> PlayerMarkItemOthers = new List<MotorParkourPlayerMarkItem>();

		// Token: 0x0402169D RID: 136861
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x0402169E RID: 136862
		private readonly Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0402169F RID: 136863
		private int MaxPointsCount;

		// Token: 0x040216A0 RID: 136864
		private int CurrentPointsCount;

		// Token: 0x040216A1 RID: 136865
		private int SelfPlayerNumber;

		// Token: 0x040216A2 RID: 136866
		public MultiMotorLevelData LevelData;

		// Token: 0x0200C5B0 RID: 50608
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BAF6 RID: 244470
			public const int ItemMarkPanel = 0;

			// Token: 0x0403BAF7 RID: 244471
			public const int LineRawMapPath = 1;

			// Token: 0x0403BAF8 RID: 244472
			public const int LineRawPathTaken = 2;

			// Token: 0x0403BAF9 RID: 244473
			public const int ItemEndPoint = 3;

			// Token: 0x0403BAFA RID: 244474
			public const int ItemPlayer = 4;

			// Token: 0x0403BAFB RID: 244475
			public const int ItemPlayer2P = 5;

			// Token: 0x0403BAFC RID: 244476
			public const int ItemPlayer3P = 6;

			// Token: 0x0403BAFD RID: 244477
			public const int ItemPlayer1P = 7;
		}
	}
}
