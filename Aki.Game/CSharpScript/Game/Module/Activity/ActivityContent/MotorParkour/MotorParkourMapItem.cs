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
	// Token: 0x02005371 RID: 21361
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorParkourMapItem : UiPanelBase
	{
		// Token: 0x06035274 RID: 217716 RVA: 0x00ED8015 File Offset: 0x00ED6215
		public MotorParkourMapItem(MotorParkourLevelData levelData)
		{
			this.LevelData = levelData;
		}

		// Token: 0x06035275 RID: 217717 RVA: 0x00ED803C File Offset: 0x00ED623C
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

		// Token: 0x06035276 RID: 217718 RVA: 0x00ED8108 File Offset: 0x00ED6308
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourMapItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourMapItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035277 RID: 217719 RVA: 0x00ED814C File Offset: 0x00ED634C
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

		// Token: 0x06035278 RID: 217720 RVA: 0x00ED81B4 File Offset: 0x00ED63B4
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

		// Token: 0x0401C0CA RID: 114890
		[Nullable(2)]
		private MotorParkourPlayerMarkItem PlayerMarkItem;

		// Token: 0x0401C0CB RID: 114891
		private readonly Vector2D UiOffset = Vector2D.Create();

		// Token: 0x0401C0CC RID: 114892
		private readonly Vector2D CenterOffset = Vector2D.Create();

		// Token: 0x0401C0CD RID: 114893
		public MotorParkourLevelData LevelData;

		// Token: 0x0200AFF5 RID: 45045
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036618 RID: 222744
			public const int ItemMarkPanel = 0;

			// Token: 0x04036619 RID: 222745
			public const int LineRawMapPath = 1;

			// Token: 0x0403661A RID: 222746
			public const int LineRawPathTaken = 2;

			// Token: 0x0403661B RID: 222747
			public const int ItemEndPoint = 3;

			// Token: 0x0403661C RID: 222748
			public const int ItemPlayer = 4;
		}
	}
}
