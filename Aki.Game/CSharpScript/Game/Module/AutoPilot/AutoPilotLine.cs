using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Transport;
using CSharpScript.Game.Module.WorldMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E52 RID: 20050
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotLine
	{
		// Token: 0x1700624C RID: 25164
		// (get) Token: 0x0603270C RID: 206604 RVA: 0x00E2621F File Offset: 0x00E2441F
		// (set) Token: 0x0603270D RID: 206605 RVA: 0x00E26227 File Offset: 0x00E24427
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public OneOf<BaseMap, MiniMap> Map { [return: Nullable(new byte[]
		{
			0,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			0,
			1,
			1
		})] private set; }

		// Token: 0x0603270E RID: 206606 RVA: 0x00E26230 File Offset: 0x00E24430
		public AutoPilotLine([Nullable(new byte[]
		{
			0,
			1,
			1
		})] OneOf<BaseMap, MiniMap> map)
		{
			this.Map = map;
			EventSystem.Instance.Add(EEventName.OnUpdateAutoPilotLine, new Action(this.OnUpdateAutoPilotLine));
		}

		// Token: 0x0603270F RID: 206607 RVA: 0x00E262F4 File Offset: 0x00E244F4
		private void SetComponentWidthAndHeight()
		{
			Vector2D vector2D;
			if (!this.Map.IsT1)
			{
				MapTileMgr mapTileMgr = this.Map.AsT2.MapTileMgr;
				vector2D = ((mapTileMgr != null) ? mapTileMgr.TotalTileSize : null);
			}
			else
			{
				MapTileMgr mapTileMgr2 = this.Map.AsT1.MapTileMgr;
				vector2D = ((mapTileMgr2 != null) ? mapTileMgr2.TotalTileSize : null);
			}
			Vector2D vector2D2 = vector2D;
			if (vector2D2 == null)
			{
				return;
			}
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent != null)
			{
				UUIItem rootItem = autoPilotLineComponent.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetWidth((float)vector2D2.X);
				}
			}
			AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
			if (autoPilotLineComponent2 == null)
			{
				return;
			}
			UUIItem rootItem2 = autoPilotLineComponent2.GetRootItem();
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetHeight((float)vector2D2.Y);
		}

		// Token: 0x06032710 RID: 206608 RVA: 0x00E2639C File Offset: 0x00E2459C
		private UniTask InitComponentAsync()
		{
			AutoPilotLine.<InitComponentAsync>d__19 <InitComponentAsync>d__;
			<InitComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitComponentAsync>d__.<>4__this = this;
			<InitComponentAsync>d__.<>1__state = -1;
			<InitComponentAsync>d__.<>t__builder.Start<AutoPilotLine.<InitComponentAsync>d__19>(ref <InitComponentAsync>d__);
			return <InitComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032711 RID: 206609 RVA: 0x00E263DF File Offset: 0x00E245DF
		public void CheckAutoPilotLineInfo()
		{
			this.CheckAutoPilotLineAsync().Forget();
		}

		// Token: 0x06032712 RID: 206610 RVA: 0x00E263EC File Offset: 0x00E245EC
		private UniTask CheckAutoPilotLineAsync()
		{
			AutoPilotLine.<CheckAutoPilotLineAsync>d__21 <CheckAutoPilotLineAsync>d__;
			<CheckAutoPilotLineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckAutoPilotLineAsync>d__.<>4__this = this;
			<CheckAutoPilotLineAsync>d__.<>1__state = -1;
			<CheckAutoPilotLineAsync>d__.<>t__builder.Start<AutoPilotLine.<CheckAutoPilotLineAsync>d__21>(ref <CheckAutoPilotLineAsync>d__);
			return <CheckAutoPilotLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032713 RID: 206611 RVA: 0x00E2642F File Offset: 0x00E2462F
		public void SetUiActive(bool active)
		{
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent == null)
			{
				return;
			}
			autoPilotLineComponent.SetUiActive(active);
		}

		// Token: 0x06032714 RID: 206612 RVA: 0x00E26444 File Offset: 0x00E24644
		public void Destroy()
		{
			if (this.AutoPilotLineComponent != null)
			{
				this.AutoPilotLineComponent.SkipDestroyActor = false;
				this.AutoPilotLineComponent.Destroy(null);
				this.AutoPilotLineComponent = null;
			}
			EventSystem.Instance.Remove(EEventName.OnUpdateAutoPilotLine, new Action(this.OnUpdateAutoPilotLine));
		}

		// Token: 0x06032715 RID: 206613 RVA: 0x00E26494 File Offset: 0x00E24694
		private void OnUpdateAutoPilotLine()
		{
			this.CheckAutoPilotLineInfo();
		}

		// Token: 0x06032716 RID: 206614 RVA: 0x00E2649C File Offset: 0x00E2469C
		public void RefreshFindPathLine()
		{
			AutoPilotFindPathResult findPathResult = AutoPilotModel.Instance.GetFindPathResult();
			int num = this.Map.IsT1 ? this.Map.AsT1.MapId : this.Map.AsT2.MapId;
			if (findPathResult != null && (findPathResult.MapId == num || findPathResult.MapId == 105))
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent != null)
				{
					UUIItem findPathRoot = autoPilotLineComponent.FindPathRoot;
					if (findPathRoot != null)
					{
						findPathRoot.SetUIActive(true);
					}
				}
				this.SetScale();
				this.DrawStartPoint(findPathResult);
				this.DrawEndPoint(findPathResult);
				this.DrawPlayerToStartLine(findPathResult);
				this.DrawEndToTargetLine(findPathResult);
				this.DrawPlayerToTargetLine(findPathResult);
				this.DrawFindPathHighLightLine(findPathResult);
				return;
			}
			AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
			if (autoPilotLineComponent2 == null)
			{
				return;
			}
			UUIItem findPathRoot2 = autoPilotLineComponent2.FindPathRoot;
			if (findPathRoot2 == null)
			{
				return;
			}
			findPathRoot2.SetUIActive(false);
		}

		// Token: 0x06032717 RID: 206615 RVA: 0x00E2656C File Offset: 0x00E2476C
		private void DrawStartPoint(AutoPilotFindPathResult result)
		{
			float mapScale = WorldMapModel.Instance.MapScale;
			float mapScaleMin = WorldMapModel.Instance.MapScaleMin;
			EMapType emapType = this.Map.IsT1 ? this.Map.AsT1.MapType : this.Map.AsT2.MapType;
			bool flag = mapScale <= mapScaleMin && emapType == EMapType.WorldMap;
			if (!result.GetIsShowStartPoint() || flag)
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUIItem startPoint = autoPilotLineComponent.StartPoint;
				if (startPoint == null)
				{
					return;
				}
				startPoint.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUIItem startPoint2 = autoPilotLineComponent2.StartPoint;
					if (startPoint2 != null)
					{
						startPoint2.SetUIActive(true);
					}
				}
				this.TmpVector2D.Set(result.StartPoint.X, result.StartPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.StartPoint2D);
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 != null)
				{
					UUIItem startPoint3 = autoPilotLineComponent3.StartPoint;
					if (startPoint3 != null)
					{
						startPoint3.SetAnchorOffset(this.StartPoint2D.ToUeVector2D(false));
					}
				}
				AutoPilotLineComponent autoPilotLineComponent4 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent4 == null)
				{
					return;
				}
				UUIItem startPoint4 = autoPilotLineComponent4.StartPoint;
				if (startPoint4 == null)
				{
					return;
				}
				startPoint4.SetUIItemScale(this.Scale3D.ToUeVectorOld());
				return;
			}
		}

		// Token: 0x06032718 RID: 206616 RVA: 0x00E26698 File Offset: 0x00E24898
		private void DrawEndPoint(AutoPilotFindPathResult result)
		{
			float mapScale = WorldMapModel.Instance.MapScale;
			float mapScaleMin = WorldMapModel.Instance.MapScaleMin;
			EMapType emapType = this.Map.IsT1 ? this.Map.AsT1.MapType : this.Map.AsT2.MapType;
			bool flag = mapScale <= mapScaleMin && emapType == EMapType.WorldMap;
			if (!result.GetIsShowEndPoint() || flag)
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUIItem endPoint = autoPilotLineComponent.EndPoint;
				if (endPoint == null)
				{
					return;
				}
				endPoint.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUIItem endPoint2 = autoPilotLineComponent2.EndPoint;
					if (endPoint2 != null)
					{
						endPoint2.SetUIActive(true);
					}
				}
				this.TmpVector2D.Set(result.EndPoint.X, result.EndPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.EndPoint2D);
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 != null)
				{
					UUIItem endPoint3 = autoPilotLineComponent3.EndPoint;
					if (endPoint3 != null)
					{
						endPoint3.SetAnchorOffset(this.EndPoint2D.ToUeVector2D(false));
					}
				}
				AutoPilotLineComponent autoPilotLineComponent4 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent4 == null)
				{
					return;
				}
				UUIItem endPoint4 = autoPilotLineComponent4.EndPoint;
				if (endPoint4 == null)
				{
					return;
				}
				endPoint4.SetUIItemScale(this.Scale3D.ToUeVectorOld());
				return;
			}
		}

		// Token: 0x06032719 RID: 206617 RVA: 0x00E267C4 File Offset: 0x00E249C4
		private void DrawPlayerToStartLine(AutoPilotFindPathResult result)
		{
			if (!result.GetIsShowPlayerToStartLine())
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUIItem playerToStartLine = autoPilotLineComponent.PlayerToStartLine;
				if (playerToStartLine == null)
				{
					return;
				}
				playerToStartLine.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUIItem playerToStartLine2 = autoPilotLineComponent2.PlayerToStartLine;
					if (playerToStartLine2 != null)
					{
						playerToStartLine2.SetUIActive(true);
					}
				}
				this.TmpVector2D.Set(result.PlayerPoint.X, result.PlayerPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.PlayerPoint2D);
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 != null)
				{
					UUIItem playerToStartLine3 = autoPilotLineComponent3.PlayerToStartLine;
					if (playerToStartLine3 != null)
					{
						playerToStartLine3.SetAnchorOffset(this.PlayerPoint2D.ToUeVector2D(false));
					}
				}
				this.TmpVector2D.Set(result.StartPoint.X, result.StartPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.StartPoint2D);
				double num = Vector2D.Distance(this.PlayerPoint2D, this.StartPoint2D);
				num *= this.ScaleDivideOne;
				AutoPilotLineComponent autoPilotLineComponent4 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent4 != null)
				{
					UUIItem playerToStartLine4 = autoPilotLineComponent4.PlayerToStartLine;
					if (playerToStartLine4 != null)
					{
						playerToStartLine4.SetHeight((float)num);
					}
				}
				AutoPilotLineComponent autoPilotLineComponent5 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent5 != null)
				{
					UUIItem playerToStartLine5 = autoPilotLineComponent5.PlayerToStartLine;
					if (playerToStartLine5 != null)
					{
						playerToStartLine5.SetUIItemScale(this.Scale3D.ToUeVectorOld());
					}
				}
				this.PlayerToStartLineRotator.Yaw = (float)(Math.Atan2(this.StartPoint2D.Y - this.PlayerPoint2D.Y, this.StartPoint2D.X - this.PlayerPoint2D.X) * 57.295780181884766 - 90.0);
				AutoPilotLineComponent autoPilotLineComponent6 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent6 == null)
				{
					return;
				}
				UUIItem playerToStartLine6 = autoPilotLineComponent6.PlayerToStartLine;
				if (playerToStartLine6 == null)
				{
					return;
				}
				FRotator frotator = this.PlayerToStartLineRotator.ToUeRotator();
				playerToStartLine6.SetUIRelativeRotation(frotator);
				return;
			}
		}

		// Token: 0x0603271A RID: 206618 RVA: 0x00E2697C File Offset: 0x00E24B7C
		private void DrawEndToTargetLine(AutoPilotFindPathResult result)
		{
			if (!result.GetIsShowEndToTargetLine())
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUIItem endToTargetLine = autoPilotLineComponent.EndToTargetLine;
				if (endToTargetLine == null)
				{
					return;
				}
				endToTargetLine.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUIItem endToTargetLine2 = autoPilotLineComponent2.EndToTargetLine;
					if (endToTargetLine2 != null)
					{
						endToTargetLine2.SetUIActive(true);
					}
				}
				this.TmpVector2D.Set(result.EndPoint.X, result.EndPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.EndPoint2D);
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 != null)
				{
					UUIItem endToTargetLine3 = autoPilotLineComponent3.EndToTargetLine;
					if (endToTargetLine3 != null)
					{
						endToTargetLine3.SetAnchorOffset(this.EndPoint2D.ToUeVector2D(false));
					}
				}
				this.TmpVector2D.Set(result.TargetPoint.X, result.TargetPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.TargetPoint2D);
				double num = Vector2D.Distance(this.EndPoint2D, this.TargetPoint2D);
				num *= this.ScaleDivideOne;
				AutoPilotLineComponent autoPilotLineComponent4 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent4 != null)
				{
					UUIItem endToTargetLine4 = autoPilotLineComponent4.EndToTargetLine;
					if (endToTargetLine4 != null)
					{
						endToTargetLine4.SetHeight((float)num);
					}
				}
				AutoPilotLineComponent autoPilotLineComponent5 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent5 != null)
				{
					UUIItem endToTargetLine5 = autoPilotLineComponent5.EndToTargetLine;
					if (endToTargetLine5 != null)
					{
						endToTargetLine5.SetUIItemScale(this.Scale3D.ToUeVectorOld());
					}
				}
				this.EndToTargetLineRotator.Yaw = (float)(Math.Atan2(this.TargetPoint2D.Y - this.EndPoint2D.Y, this.TargetPoint2D.X - this.EndPoint2D.X) * 57.295780181884766 - 90.0);
				AutoPilotLineComponent autoPilotLineComponent6 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent6 == null)
				{
					return;
				}
				UUIItem endToTargetLine6 = autoPilotLineComponent6.EndToTargetLine;
				if (endToTargetLine6 == null)
				{
					return;
				}
				FRotator frotator = this.EndToTargetLineRotator.ToUeRotator();
				endToTargetLine6.SetUIRelativeRotation(frotator);
				return;
			}
		}

		// Token: 0x0603271B RID: 206619 RVA: 0x00E26B34 File Offset: 0x00E24D34
		private void DrawPlayerToTargetLine(AutoPilotFindPathResult result)
		{
			if (!result.GetIsShowPlayerToTargetLine())
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUIItem playerToTargetLine = autoPilotLineComponent.PlayerToTargetLine;
				if (playerToTargetLine == null)
				{
					return;
				}
				playerToTargetLine.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUIItem playerToTargetLine2 = autoPilotLineComponent2.PlayerToTargetLine;
					if (playerToTargetLine2 != null)
					{
						playerToTargetLine2.SetUIActive(true);
					}
				}
				this.TmpVector2D.Set(result.PlayerPoint.X, result.PlayerPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.PlayerPoint2D);
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 != null)
				{
					UUIItem playerToTargetLine3 = autoPilotLineComponent3.PlayerToTargetLine;
					if (playerToTargetLine3 != null)
					{
						playerToTargetLine3.SetAnchorOffset(this.PlayerPoint2D.ToUeVector2D(false));
					}
				}
				this.TmpVector2D.Set(result.TargetPoint.X, result.TargetPoint.Y);
				MapUtil.WorldPosition2UiPosition2D(this.TmpVector2D, this.TargetPoint2D);
				double num = Vector2D.Distance(this.PlayerPoint2D, this.TargetPoint2D);
				num *= this.ScaleDivideOne;
				AutoPilotLineComponent autoPilotLineComponent4 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent4 != null)
				{
					UUIItem playerToTargetLine4 = autoPilotLineComponent4.PlayerToTargetLine;
					if (playerToTargetLine4 != null)
					{
						playerToTargetLine4.SetHeight((float)num);
					}
				}
				AutoPilotLineComponent autoPilotLineComponent5 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent5 != null)
				{
					UUIItem playerToTargetLine5 = autoPilotLineComponent5.PlayerToTargetLine;
					if (playerToTargetLine5 != null)
					{
						playerToTargetLine5.SetUIItemScale(this.Scale3D.ToUeVectorOld());
					}
				}
				this.PlayerToTargetLineRotator.Yaw = (float)(Math.Atan2(this.TargetPoint2D.Y - this.PlayerPoint2D.Y, this.TargetPoint2D.X - this.PlayerPoint2D.X) * 57.295780181884766 - 90.0);
				AutoPilotLineComponent autoPilotLineComponent6 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent6 == null)
				{
					return;
				}
				UUIItem playerToTargetLine6 = autoPilotLineComponent6.PlayerToTargetLine;
				if (playerToTargetLine6 == null)
				{
					return;
				}
				FRotator frotator = this.PlayerToTargetLineRotator.ToUeRotator();
				playerToTargetLine6.SetUIRelativeRotation(frotator);
				return;
			}
		}

		// Token: 0x0603271C RID: 206620 RVA: 0x00E26CEC File Offset: 0x00E24EEC
		private void DrawFindPathHighLightLine(AutoPilotFindPathResult result)
		{
			if (!result.GetIsShowHighLightLine())
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUI2DLineRaw findPathHighLightLine = autoPilotLineComponent.FindPathHighLightLine;
				if (findPathHighLightLine == null)
				{
					return;
				}
				findPathHighLightLine.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUI2DLineRaw findPathHighLightLine2 = autoPilotLineComponent2.FindPathHighLightLine;
					if (findPathHighLightLine2 != null)
					{
						findPathHighLightLine2.SetUIActive(true);
					}
				}
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 == null)
				{
					return;
				}
				UUI2DLineRaw findPathHighLightLine3 = autoPilotLineComponent3.FindPathHighLightLine;
				if (findPathHighLightLine3 == null)
				{
					return;
				}
				findPathHighLightLine3.SetPoints(result.SplinePoints, false);
				return;
			}
		}

		// Token: 0x0603271D RID: 206621 RVA: 0x00E26D5C File Offset: 0x00E24F5C
		public void SetScale()
		{
			bool flag = (this.Map.IsT1 ? this.Map.AsT1.MapType : this.Map.AsT2.MapType) == EMapType.MiniMap;
			float num = flag ? 1f : WorldMapModel.Instance.MapScale;
			double num2;
			if (flag)
			{
				UUIItem uuiitem = this.Map.IsT2 ? this.Map.AsT2.GetRootItem() : null;
				num2 = (double)((uuiitem != null) ? uuiitem.RelativeScale3D.X : 1f);
			}
			else
			{
				num2 = 1.0;
			}
			this.ScaleDivideOne = (double)num * num2;
			double num3 = 1.0 / this.ScaleDivideOne;
			this.Scale3D.Set(num3, num3, num3);
		}

		// Token: 0x0603271E RID: 206622 RVA: 0x00E26E30 File Offset: 0x00E25030
		private void RefreshCirclePathHighLightLine()
		{
			AutoPilotCirclePathResult circlePathResult = AutoPilotModel.Instance.GetCirclePathResult();
			int num = this.Map.IsT1 ? this.Map.AsT1.MapId : this.Map.AsT2.MapId;
			if (circlePathResult != null && (circlePathResult.MapId == num || circlePathResult.MapId == 105))
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent != null)
				{
					UUIItem circlePathRoot = autoPilotLineComponent.CirclePathRoot;
					if (circlePathRoot != null)
					{
						circlePathRoot.SetUIActive(true);
					}
				}
				this.DrawCirclePathHighLightLine(circlePathResult);
				this.DrawPathToCircleHighLightLine(circlePathResult);
				return;
			}
			AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
			if (autoPilotLineComponent2 != null)
			{
				UUIItem circlePathRoot2 = autoPilotLineComponent2.CirclePathRoot;
				if (circlePathRoot2 != null)
				{
					circlePathRoot2.SetUIActive(false);
				}
			}
			AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
			if (autoPilotLineComponent3 == null)
			{
				return;
			}
			autoPilotLineComponent3.ResetCircleId();
		}

		// Token: 0x0603271F RID: 206623 RVA: 0x00E26EF0 File Offset: 0x00E250F0
		private void DrawCirclePathHighLightLine(AutoPilotCirclePathResult result)
		{
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent == null)
			{
				return;
			}
			autoPilotLineComponent.LoadCirclePathHighLightLine(result.CircleId).Forget();
		}

		// Token: 0x06032720 RID: 206624 RVA: 0x00E26F10 File Offset: 0x00E25110
		private void DrawPathToCircleHighLightLine(AutoPilotCirclePathResult result)
		{
			if (result.GetIsInCircle())
			{
				AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
				if (autoPilotLineComponent == null)
				{
					return;
				}
				UUI2DLineRaw pathToCircleHighLightLine = autoPilotLineComponent.PathToCircleHighLightLine;
				if (pathToCircleHighLightLine == null)
				{
					return;
				}
				pathToCircleHighLightLine.SetUIActive(false);
				return;
			}
			else
			{
				AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent2 != null)
				{
					UUI2DLineRaw pathToCircleHighLightLine2 = autoPilotLineComponent2.PathToCircleHighLightLine;
					if (pathToCircleHighLightLine2 != null)
					{
						pathToCircleHighLightLine2.SetUIActive(true);
					}
				}
				AutoPilotLineComponent autoPilotLineComponent3 = this.AutoPilotLineComponent;
				if (autoPilotLineComponent3 == null)
				{
					return;
				}
				UUI2DLineRaw pathToCircleHighLightLine3 = autoPilotLineComponent3.PathToCircleHighLightLine;
				if (pathToCircleHighLightLine3 == null)
				{
					return;
				}
				pathToCircleHighLightLine3.SetPoints(result.PathToCircleSplinePoints, false);
				return;
			}
		}

		// Token: 0x06032721 RID: 206625 RVA: 0x00E26F7F File Offset: 0x00E2517F
		public void OnMiniMapTick()
		{
			this.CheckAutoPilotLineInfo();
		}

		// Token: 0x06032722 RID: 206626 RVA: 0x00E26F88 File Offset: 0x00E25188
		public void DrawDebugLine(int[] roadWayIds)
		{
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent != null)
			{
				autoPilotLineComponent.RecycleDebugLine();
			}
			foreach (int roadwayId in roadWayIds)
			{
				UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(roadwayId);
				if (roadWay != null && roadWay.RoadSpline != null)
				{
					TArray<FVector2D> tarray = new TArray<FVector2D>();
					AutoPilotUtil.GenerateSingleSplinePoints(roadWay.RoadSpline, tarray);
					AutoPilotLineComponent autoPilotLineComponent2 = this.AutoPilotLineComponent;
					if (autoPilotLineComponent2 != null)
					{
						autoPilotLineComponent2.CreateDebugRoadLine(tarray).Forget();
					}
				}
			}
		}

		// Token: 0x06032723 RID: 206627 RVA: 0x00E27004 File Offset: 0x00E25204
		public void DebugDrawCircle(int[] roadWayIds)
		{
			List<UKuroRoadway> list = new List<UKuroRoadway>();
			foreach (int roadwayId in roadWayIds)
			{
				UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(roadwayId);
				if (roadWay != null && roadWay.RoadSpline != null)
				{
					list.Add(roadWay);
				}
			}
			TArray<FVector2D> tarray = new TArray<FVector2D>();
			AutoPilotUtil.GenerateAllSplinePoints(list.ToArray(), tarray, null, null, null);
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent == null)
			{
				return;
			}
			autoPilotLineComponent.CreateDebugRoadLine(tarray).Forget();
		}

		// Token: 0x06032724 RID: 206628 RVA: 0x00E27080 File Offset: 0x00E25280
		private void RefreshDebugLine()
		{
			if ((this.Map.IsT1 ? this.Map.AsT1.MapType : this.Map.AsT2.MapType) != EMapType.WorldMap)
			{
				return;
			}
			if (AutoPilotModel.Instance.DebugCircleId != 0)
			{
				AutoPilotCircles? autoPilotCircles;
				int[] array = (ConfigAutoPilotCirclesById.GetConfig(AutoPilotModel.Instance.DebugCircleId, true) != null) ? autoPilotCircles.GetValueOrDefault().GetWaySplinesArray() : null;
				if (array == null || array.Length == 0)
				{
					return;
				}
				this.DebugDrawCircle(array);
				AutoPilotModel.Instance.DebugCircleId = 0;
				return;
			}
			else
			{
				List<int> debugRoadWayIds = AutoPilotModel.Instance.DebugRoadWayIds;
				if (debugRoadWayIds.Count == 0)
				{
					return;
				}
				this.DrawDebugLine(debugRoadWayIds.ToArray());
				AutoPilotModel.Instance.DebugRoadWayIds.Clear();
				return;
			}
		}

		// Token: 0x0401AC01 RID: 109569
		[Nullable(2)]
		private AutoPilotLineComponent AutoPilotLineComponent;

		// Token: 0x0401AC02 RID: 109570
		[Nullable(2)]
		private UniTaskCompletionSource ComponentPromise;

		// Token: 0x0401AC03 RID: 109571
		private readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x0401AC04 RID: 109572
		private readonly Vector2D StartPoint2D = Vector2D.Create();

		// Token: 0x0401AC05 RID: 109573
		private readonly Vector2D PlayerPoint2D = Vector2D.Create();

		// Token: 0x0401AC06 RID: 109574
		private readonly Vector2D TargetPoint2D = Vector2D.Create();

		// Token: 0x0401AC07 RID: 109575
		private readonly Vector2D EndPoint2D = Vector2D.Create();

		// Token: 0x0401AC08 RID: 109576
		private readonly Rotator PlayerToStartLineRotator = Rotator.Create();

		// Token: 0x0401AC09 RID: 109577
		private readonly Rotator EndToTargetLineRotator = Rotator.Create();

		// Token: 0x0401AC0A RID: 109578
		private readonly Rotator PlayerToTargetLineRotator = Rotator.Create();

		// Token: 0x0401AC0B RID: 109579
		private double ScaleDivideOne = 1.0;

		// Token: 0x0401AC0C RID: 109580
		private readonly global::Vector Scale3D = global::Vector.Create();

		// Token: 0x0401AC0D RID: 109581
		private readonly Stat StatsObject0 = Stat.Create("DrawFindPathHighLightLine", "", "");
	}
}
