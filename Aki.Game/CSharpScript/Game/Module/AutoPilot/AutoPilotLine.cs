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
	// Token: 0x02005E6D RID: 24173
	[NullableContext(1)]
	[Nullable(0)]
	public class AutoPilotLine
	{
		// Token: 0x17008E7A RID: 36474
		// (get) Token: 0x0603D77C RID: 251772 RVA: 0x00ED4CAF File Offset: 0x00ED2EAF
		// (set) Token: 0x0603D77D RID: 251773 RVA: 0x00ED4CB7 File Offset: 0x00ED2EB7
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

		// Token: 0x0603D77E RID: 251774 RVA: 0x00ED4CC0 File Offset: 0x00ED2EC0
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

		// Token: 0x0603D77F RID: 251775 RVA: 0x00ED4D84 File Offset: 0x00ED2F84
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
				vector2D = this.Map.AsT1.MapTileMgr.TotalTileSize;
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

		// Token: 0x0603D780 RID: 251776 RVA: 0x00ED4E24 File Offset: 0x00ED3024
		private UniTask InitComponentAsync()
		{
			AutoPilotLine.<InitComponentAsync>d__19 <InitComponentAsync>d__;
			<InitComponentAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitComponentAsync>d__.<>4__this = this;
			<InitComponentAsync>d__.<>1__state = -1;
			<InitComponentAsync>d__.<>t__builder.Start<AutoPilotLine.<InitComponentAsync>d__19>(ref <InitComponentAsync>d__);
			return <InitComponentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D781 RID: 251777 RVA: 0x00ED4E67 File Offset: 0x00ED3067
		public void CheckAutoPilotLineInfo()
		{
			this.CheckAutoPilotLineAsync().Forget();
		}

		// Token: 0x0603D782 RID: 251778 RVA: 0x00ED4E74 File Offset: 0x00ED3074
		private UniTask CheckAutoPilotLineAsync()
		{
			AutoPilotLine.<CheckAutoPilotLineAsync>d__21 <CheckAutoPilotLineAsync>d__;
			<CheckAutoPilotLineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckAutoPilotLineAsync>d__.<>4__this = this;
			<CheckAutoPilotLineAsync>d__.<>1__state = -1;
			<CheckAutoPilotLineAsync>d__.<>t__builder.Start<AutoPilotLine.<CheckAutoPilotLineAsync>d__21>(ref <CheckAutoPilotLineAsync>d__);
			return <CheckAutoPilotLineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D783 RID: 251779 RVA: 0x00ED4EB7 File Offset: 0x00ED30B7
		public void SetUiActive(bool active)
		{
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent == null)
			{
				return;
			}
			autoPilotLineComponent.SetUiActive(active);
		}

		// Token: 0x0603D784 RID: 251780 RVA: 0x00ED4ECC File Offset: 0x00ED30CC
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

		// Token: 0x0603D785 RID: 251781 RVA: 0x00ED4F1C File Offset: 0x00ED311C
		private void OnUpdateAutoPilotLine()
		{
			this.CheckAutoPilotLineInfo();
		}

		// Token: 0x0603D786 RID: 251782 RVA: 0x00ED4F24 File Offset: 0x00ED3124
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

		// Token: 0x0603D787 RID: 251783 RVA: 0x00ED4FF4 File Offset: 0x00ED31F4
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

		// Token: 0x0603D788 RID: 251784 RVA: 0x00ED5120 File Offset: 0x00ED3320
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

		// Token: 0x0603D789 RID: 251785 RVA: 0x00ED524C File Offset: 0x00ED344C
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

		// Token: 0x0603D78A RID: 251786 RVA: 0x00ED5404 File Offset: 0x00ED3604
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

		// Token: 0x0603D78B RID: 251787 RVA: 0x00ED55BC File Offset: 0x00ED37BC
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

		// Token: 0x0603D78C RID: 251788 RVA: 0x00ED5774 File Offset: 0x00ED3974
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

		// Token: 0x0603D78D RID: 251789 RVA: 0x00ED57E4 File Offset: 0x00ED39E4
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

		// Token: 0x0603D78E RID: 251790 RVA: 0x00ED58B8 File Offset: 0x00ED3AB8
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

		// Token: 0x0603D78F RID: 251791 RVA: 0x00ED5978 File Offset: 0x00ED3B78
		private void DrawCirclePathHighLightLine(AutoPilotCirclePathResult result)
		{
			AutoPilotLineComponent autoPilotLineComponent = this.AutoPilotLineComponent;
			if (autoPilotLineComponent == null)
			{
				return;
			}
			autoPilotLineComponent.LoadCirclePathHighLightLine(result.CircleId).Forget();
		}

		// Token: 0x0603D790 RID: 251792 RVA: 0x00ED5998 File Offset: 0x00ED3B98
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

		// Token: 0x0603D791 RID: 251793 RVA: 0x00ED5A07 File Offset: 0x00ED3C07
		public void OnMiniMapTick()
		{
			this.CheckAutoPilotLineInfo();
		}

		// Token: 0x0603D792 RID: 251794 RVA: 0x00ED5A10 File Offset: 0x00ED3C10
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

		// Token: 0x0603D793 RID: 251795 RVA: 0x00ED5A8C File Offset: 0x00ED3C8C
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

		// Token: 0x0603D794 RID: 251796 RVA: 0x00ED5B08 File Offset: 0x00ED3D08
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

		// Token: 0x0402013A RID: 131386
		[Nullable(2)]
		private AutoPilotLineComponent AutoPilotLineComponent;

		// Token: 0x0402013B RID: 131387
		[Nullable(2)]
		private UniTaskCompletionSource ComponentPromise;

		// Token: 0x0402013C RID: 131388
		private readonly Vector2D TmpVector2D = Vector2D.Create();

		// Token: 0x0402013D RID: 131389
		private readonly Vector2D StartPoint2D = Vector2D.Create();

		// Token: 0x0402013E RID: 131390
		private readonly Vector2D PlayerPoint2D = Vector2D.Create();

		// Token: 0x0402013F RID: 131391
		private readonly Vector2D TargetPoint2D = Vector2D.Create();

		// Token: 0x04020140 RID: 131392
		private readonly Vector2D EndPoint2D = Vector2D.Create();

		// Token: 0x04020141 RID: 131393
		private readonly Rotator PlayerToStartLineRotator = Rotator.Create();

		// Token: 0x04020142 RID: 131394
		private readonly Rotator EndToTargetLineRotator = Rotator.Create();

		// Token: 0x04020143 RID: 131395
		private readonly Rotator PlayerToTargetLineRotator = Rotator.Create();

		// Token: 0x04020144 RID: 131396
		private double ScaleDivideOne = 1.0;

		// Token: 0x04020145 RID: 131397
		private readonly global::Vector Scale3D = global::Vector.Create();

		// Token: 0x04020146 RID: 131398
		private readonly Stat StatsObject0 = Stat.Create("DrawFindPathHighLightLine", "", "");
	}
}
