using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F3 RID: 25587
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourMapItem : UiPanelBase
	{
		// Token: 0x060405B3 RID: 263603 RVA: 0x00F9102D File Offset: 0x00F8F22D
		public MotorParkourMapItem(MotorParkourLevelData levelData)
		{
			this.LevelData = levelData;
		}

		// Token: 0x060405B4 RID: 263604 RVA: 0x00F91054 File Offset: 0x00F8F254
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUI2DLineRaw));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUI2DLineRaw));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405B5 RID: 263605 RVA: 0x00F91120 File Offset: 0x00F8F320
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourMapItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourMapItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060405B6 RID: 263606 RVA: 0x00F91164 File Offset: 0x00F8F364
		public void DrawMapPathLine()
		{
			MotorParkourMapModel.Instance.InitSplinePoints(this.LevelData.SplineId, this.LevelData.MapScale, this.CenterOffset, this.LevelData.SplineStartIndex, this.LevelData.SplineEndIndex);
			TArray<FVector2D> splinePoints = MotorParkourMapModel.Instance.SplinePoints;
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(1);
			if (uiLineRaw == null)
			{
				return;
			}
			uiLineRaw.SetPoints(splinePoints, false);
		}

		// Token: 0x060405B7 RID: 263607 RVA: 0x00F911CC File Offset: 0x00F8F3CC
		public void UpdatePlayerPosition()
		{
			MotorParkourPlayerMarkItem playerMarkItem = this.PlayerMarkItem;
			if (playerMarkItem != null)
			{
				playerMarkItem.UpdatePosition(this.LevelData.MapScale, this.CenterOffset);
			}
			TArray<FVector2D> pathTakenSplinePoints = MotorParkourMapModel.Instance.GetPathTakenSplinePoints();
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(2);
			if (uiLineRaw == null)
			{
				return;
			}
			uiLineRaw.SetPoints(pathTakenSplinePoints, false);
		}

		// Token: 0x0402179B RID: 137115
		[Nullable(2)]
		private MotorParkourPlayerMarkItem PlayerMarkItem;

		// Token: 0x0402179C RID: 137116
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x0402179D RID: 137117
		private readonly Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0402179E RID: 137118
		public MotorParkourLevelData LevelData;

		// Token: 0x0200C60E RID: 50702
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCB9 RID: 244921
			public const int ItemMarkPanel = 0;

			// Token: 0x0403BCBA RID: 244922
			public const int LineRawMapPath = 1;

			// Token: 0x0403BCBB RID: 244923
			public const int LineRawPathTaken = 2;

			// Token: 0x0403BCBC RID: 244924
			public const int ItemEndPoint = 3;

			// Token: 0x0403BCBD RID: 244925
			public const int ItemPlayer = 4;
		}
	}
}
