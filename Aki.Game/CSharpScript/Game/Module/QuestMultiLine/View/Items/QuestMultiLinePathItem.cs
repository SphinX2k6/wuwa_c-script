using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View.Items
{
	// Token: 0x02004FBE RID: 20414
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLinePathItem : UiPanelBase
	{
		// Token: 0x060343FE RID: 214014 RVA: 0x00C449EE File Offset: 0x00C42BEE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUI2DLineRaw)),
				new ValueTuple<int, Type>(1, typeof(UUISprite))
			};
		}

		// Token: 0x060343FF RID: 214015 RVA: 0x00C44A27 File Offset: 0x00C42C27
		public void DrawPath(QuestMultiLineComponentData componentData)
		{
			this.DrawPathByPoints(componentData.AnimMovePoint);
		}

		// Token: 0x06034400 RID: 214016 RVA: 0x00C44A38 File Offset: 0x00C42C38
		public void DrawPathByPoints(IntVector2D[] points)
		{
			if (points == null || points.Length < 2)
			{
				return;
			}
			List<global::Vector> list = new List<global::Vector>(points.Length);
			foreach (IntVector2D intVector2D in points)
			{
				list.Add(global::Vector.Create((double)intVector2D.X, (double)intVector2D.Y, 0.0));
			}
			this.DrawPathByPoints(list);
		}

		// Token: 0x06034401 RID: 214017 RVA: 0x00C44A9C File Offset: 0x00C42C9C
		public void DrawPathByPoints(IReadOnlyList<global::Vector> points)
		{
			if (points == null || points.Count < 2)
			{
				return;
			}
			this.RootItem.SetUIActive(true);
			this.RootItem.SetAnchorOffset(new FVector2D(0f, 0f));
			CatmullRomCurve catmullRomCurve = new CatmullRomCurve(points);
			List<global::Vector> points2 = catmullRomCurve.GetPoints(100);
			this.FollowCurve = catmullRomCurve;
			this.FollowPresampled = points2;
			TArray<FVector2D> tarray = QuestMultiLineUtils.PointArrayToVectorArray(points2);
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(0);
			if (uiLineRaw != null)
			{
				uiLineRaw.SetEndType(EUI2DLineRenderer_EndType.None);
				uiLineRaw.SetPoints(tarray, false);
			}
			global::Vector derivative = catmullRomCurve.GetDerivative(1.0);
			UUISprite sprite = base.GetSprite(1);
			Rotator rotator = Rotator.Create();
			rotator.Yaw = (float)(Math.Atan2(derivative.Y, derivative.X) * 180.0 / 3.141592653589793);
			FRotator frotator = rotator.ToUeRotator();
			sprite.SetUIRelativeRotation(frotator);
			sprite.SetAnchorOffset(tarray.Get(tarray.Num() - 1));
		}

		// Token: 0x06034402 RID: 214018 RVA: 0x00C44B8E File Offset: 0x00C42D8E
		public void SetVisibleForAnim(bool visible)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(visible);
			}
			if (visible)
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 == null)
				{
					return;
				}
				rootItem2.SetAlpha(1f);
			}
		}

		// Token: 0x06034403 RID: 214019 RVA: 0x00C44BBC File Offset: 0x00C42DBC
		public void SetVisibleProgress(float t)
		{
			if (this.FollowCurve == null || this.FollowPresampled == null)
			{
				return;
			}
			UUI2DLineRaw uiLineRaw = base.GetUiLineRaw(0);
			if (uiLineRaw == null)
			{
				return;
			}
			if (t < 1f)
			{
				float num = Math.Max(0f, t);
				global::Vector point = this.FollowCurve.GetPoint((double)num);
				int num2 = Math.Min(this.FollowPresampled.Count, (int)Math.Ceiling((double)(num * 100f)));
				List<global::Vector> list = new List<global::Vector>
				{
					global::Vector.Create(point.X, point.Y, 0.0)
				};
				for (int i = num2; i < this.FollowPresampled.Count; i++)
				{
					list.Add(this.FollowPresampled[i]);
				}
				if (list.Count < 2)
				{
					global::Vector vector = this.FollowPresampled[this.FollowPresampled.Count - 1];
					list.Add(global::Vector.Create(vector.X, vector.Y, 0.0));
				}
				TArray<FVector2D> tarray = QuestMultiLineUtils.PointArrayToVectorArray(list);
				uiLineRaw.SetPoints(tarray, false);
				return;
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x06034404 RID: 214020 RVA: 0x00C44CE4 File Offset: 0x00C42EE4
		public void PlayDrawProgressively(QuestMultiLineComponentData componentData, float? speedUiPxPerSec = null, [Nullable(2)] Action onComplete = null)
		{
			this.StopDraw();
			IntVector2D[] animMovePoint = componentData.AnimMovePoint;
			if (animMovePoint == null || animMovePoint.Length < 2)
			{
				Action onComplete2 = onComplete;
				if (onComplete2 == null)
				{
					return;
				}
				onComplete2();
				return;
			}
			else
			{
				this.RootItem.SetUIActive(true);
				this.RootItem.SetAnchorOffset(new FVector2D(0f, 0f));
				UUI2DLineRaw lineRaw = base.GetUiLineRaw(0);
				if (lineRaw == null)
				{
					Action onComplete3 = onComplete;
					if (onComplete3 == null)
					{
						return;
					}
					onComplete3();
					return;
				}
				else
				{
					lineRaw.SetEndType(EUI2DLineRenderer_EndType.None);
					CatmullRomCurve curve = new CatmullRomCurve(animMovePoint);
					List<global::Vector> presampled = curve.GetPoints(100);
					this.FollowCurve = curve;
					this.FollowPresampled = presampled;
					UUISprite arrowSprite = base.GetSprite(1);
					float num = speedUiPxPerSec ?? ((float)componentData.PathSpeed);
					if (num <= 0f)
					{
						this.ApplyFullPath(lineRaw, arrowSprite, curve, presampled);
						Action onComplete4 = onComplete;
						if (onComplete4 == null)
						{
							return;
						}
						onComplete4();
						return;
					}
					else
					{
						ICatmullRomArcLengthLookup arcLengthLookup = CatmullRomCurve.CreateArcLengthLookup(curve, 100);
						double totalArcLength = arcLengthLookup.TotalLength;
						if (totalArcLength > 0.0)
						{
							this.ApplyProgress(lineRaw, arrowSprite, curve, presampled, 0f);
							float speedAlongCurvePxPerMs = num / 1000f;
							double traveledArcLength = 0.0;
							TimerHandle timerHandle = TimerSystem.Instance.Forever(delegate(float delta)
							{
								traveledArcLength = Math.Min(totalArcLength, traveledArcLength + (double)(speedAlongCurvePxPerMs * delta));
								double parameterByArcLength = CatmullRomCurve.GetParameterByArcLength(arcLengthLookup, traveledArcLength);
								this.ApplyProgress(lineRaw, arrowSprite, curve, presampled, (float)parameterByArcLength);
								if (traveledArcLength >= totalArcLength)
								{
									this.ApplyFullPath(lineRaw, arrowSprite, curve, presampled);
									TimerHandle drawTimerHandle = this.DrawTimerHandle;
									if (drawTimerHandle != null)
									{
										drawTimerHandle.Remove();
									}
									this.DrawTimerHandle = null;
									Action onComplete6 = onComplete;
									if (onComplete6 == null)
									{
										return;
									}
									onComplete6();
								}
							}, 20f, 1f, null, "QuestMultiLinePathItem.PlayDrawProgressively", true);
							if (timerHandle != null)
							{
								this.DrawTimerHandle = timerHandle;
							}
							return;
						}
						this.ApplyFullPath(lineRaw, arrowSprite, curve, presampled);
						Action onComplete5 = onComplete;
						if (onComplete5 == null)
						{
							return;
						}
						onComplete5();
						return;
					}
				}
			}
		}

		// Token: 0x06034405 RID: 214021 RVA: 0x00C44EF1 File Offset: 0x00C430F1
		public void StopDraw()
		{
			if (this.DrawTimerHandle != null)
			{
				this.DrawTimerHandle.Remove();
				this.DrawTimerHandle = null;
			}
		}

		// Token: 0x06034406 RID: 214022 RVA: 0x00C44F0E File Offset: 0x00C4310E
		protected override void OnBeforeDestroy()
		{
			this.StopDraw();
		}

		// Token: 0x06034407 RID: 214023 RVA: 0x00C44F18 File Offset: 0x00C43118
		private void ApplyProgress(UUI2DLineRaw lineRaw, UUISprite arrowSprite, CatmullRomCurve curve, IReadOnlyList<global::Vector> presampled, float t)
		{
			float num = Math.Min(1f, Math.Max(0f, t));
			int num2 = Math.Max(1, (int)Math.Floor((double)(num * 100f)));
			List<global::Vector> list = new List<global::Vector>();
			int num3 = 0;
			while (num3 < num2 && num3 < presampled.Count)
			{
				list.Add(presampled[num3]);
				num3++;
			}
			global::Vector point = curve.GetPoint((double)num);
			if (list.Count == 0)
			{
				list.Add(presampled[0]);
			}
			list.Add(global::Vector.Create(point.X, point.Y, 0.0));
			TArray<FVector2D> tarray = QuestMultiLineUtils.PointArrayToVectorArray(list);
			lineRaw.SetPoints(tarray, false);
			global::Vector derivative = curve.GetDerivative((double)num);
			Rotator rotator = Rotator.Create();
			rotator.Yaw = (float)(Math.Atan2(derivative.Y, derivative.X) * 180.0 / 3.141592653589793);
			FRotator frotator = rotator.ToUeRotator();
			arrowSprite.SetUIRelativeRotation(frotator);
			arrowSprite.SetAnchorOffset(new FVector2D((float)point.X, (float)point.Y));
		}

		// Token: 0x06034408 RID: 214024 RVA: 0x00C4503C File Offset: 0x00C4323C
		private void ApplyFullPath(UUI2DLineRaw lineRaw, UUISprite arrowSprite, CatmullRomCurve curve, IReadOnlyList<global::Vector> presampled)
		{
			TArray<FVector2D> tarray = QuestMultiLineUtils.PointArrayToVectorArray(presampled);
			lineRaw.SetPoints(tarray, false);
			global::Vector derivative = curve.GetDerivative(1.0);
			Rotator rotator = Rotator.Create();
			rotator.Yaw = (float)(Math.Atan2(derivative.Y, derivative.X) * 180.0 / 3.141592653589793);
			FRotator frotator = rotator.ToUeRotator();
			arrowSprite.SetUIRelativeRotation(frotator);
			arrowSprite.SetAnchorOffset(tarray.Get(tarray.Num() - 1));
		}

		// Token: 0x0401BC90 RID: 113808
		[Nullable(2)]
		private TimerHandle DrawTimerHandle;

		// Token: 0x0401BC91 RID: 113809
		[Nullable(2)]
		private CatmullRomCurve FollowCurve;

		// Token: 0x0401BC92 RID: 113810
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<global::Vector> FollowPresampled;
	}
}
