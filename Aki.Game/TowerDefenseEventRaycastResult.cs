using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x02002BCD RID: 11213
[NullableContext(1)]
[Nullable(0)]
public class TowerDefenseEventRaycastResult
{
	// Token: 0x0601748A RID: 95370 RVA: 0x005EAEC4 File Offset: 0x005E90C4
	[NullableContext(2)]
	public bool Raycast(TsTowerDefenseEventActor target, ETowerDefenseEventTrapPlacementType placementType, float degree, bool canRecycle)
	{
		this.Start.DeepCopy(CameraModel.Instance.MainModel.CameraLocation);
		CameraModel.Instance.MainModel.CameraRotator.Vector(this.End);
		this.End.MultiplyEqual(10000.0);
		this.End.AdditionEqual(this.Start);
		this.PlacementType = placementType;
		this.BuildingGridRaycastResult.Target = new TWeakObjectPtr<UObject>(target);
		this.BuildingGridRaycastResult.DegreeAlongNormal = degree;
		this.BuildingGridRaycastResult.RaycastTarget = new TWeakObjectPtr<UObject>(null);
		UObject world = GlobalData.World;
		FVectorDouble fvectorDouble = this.Start.ToUeVector(false);
		FVectorDouble fvectorDouble2 = this.End.ToUeVector(false);
		bool flag = UKuroBuildingGridSubsystem.K2_RaycastGrid(world, fvectorDouble, fvectorDouble2, ref this.BuildingGridRaycastResult);
		if (flag)
		{
			this.Target = (this.BuildingGridRaycastResult.Target.Get() as TsTowerDefenseEventActor);
			this.RaycastTarget = (this.BuildingGridRaycastResult.RaycastTarget.Get() as TsTowerDefenseEventActor);
			this.Grid = this.BuildingGridRaycastResult.Grid;
			Vector location = this.Location;
			fvectorDouble = this.BuildingGridRaycastResult.Location;
			location.DeepCopy(fvectorDouble);
			Rotator rotation = this.Rotation;
			FRotator frotator = this.BuildingGridRaycastResult.Rotation.Rotator();
			rotation.DeepCopy(frotator);
			this.Coords.Set((double)this.BuildingGridRaycastResult.Coords.X, (double)this.BuildingGridRaycastResult.Coords.Y);
			this.Degree = this.BuildingGridRaycastResult.DegreeAlongNormal;
			Vector normal = this.Normal;
			FVector normal2 = this.BuildingGridRaycastResult.Normal;
			fvectorDouble = normal2;
			normal.DeepCopy(fvectorDouble);
			this.IsStateDirty = this.UpdateRaycastState(target, canRecycle);
			return flag;
		}
		this.Reset();
		return flag;
	}

	// Token: 0x0601748B RID: 95371 RVA: 0x005EB098 File Offset: 0x005E9298
	public void Reset()
	{
		this.BuildingGridRaycastResult.Target = new TWeakObjectPtr<UObject>(null);
		this.BuildingGridRaycastResult.RaycastTarget = new TWeakObjectPtr<UObject>(null);
		this.Target = null;
		this.RaycastTarget = null;
		this.Grid = null;
		this.Location.Set(0.0, 0.0, 0.0);
		this.Rotation.Set(0f, 0f, 0f);
		this.Coords.Set(0.0, 0.0);
		this.Degree = 0f;
		this.Normal.Set(0.0, 0.0, 0.0);
		this.IsStateDirty = this.UpdateRaycastState(this.Target, false);
	}

	// Token: 0x0601748C RID: 95372 RVA: 0x005EB180 File Offset: 0x005E9380
	[NullableContext(2)]
	private bool UpdateRaycastState(TsTowerDefenseEventActor target, bool canRecycle)
	{
		bool flag = this.UpdateBuildState(target);
		bool flag2 = this.UpdateRecycleState(canRecycle);
		return flag || flag2;
	}

	// Token: 0x0601748D RID: 95373 RVA: 0x005EB1A0 File Offset: 0x005E93A0
	[NullableContext(2)]
	private bool UpdateBuildState(TsTowerDefenseEventActor target)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		this.PollutedNum = 0;
		if (target != null && target == this.Target)
		{
			if (TowerDefenseEventUtility.ValidatePlacementWithGridNormal(this.PlacementType, this.Normal, 0.7f))
			{
				flag2 = true;
				OutPollutedNum outPollutedNum = new OutPollutedNum();
				ETowerDefenseEventBuildState etowerDefenseEventBuildState = target.UpdateBuildState(this.Grid, this.Coords, this.Degree, this.Location, this.Rotation, outPollutedNum);
				this.PollutedNum = outPollutedNum.PollutedNum;
				flag3 = ((etowerDefenseEventBuildState & ETowerDefenseEventBuildState.Valid) == ETowerDefenseEventBuildState.Valid);
				flag4 = ((etowerDefenseEventBuildState & ETowerDefenseEventBuildState.Polluted) == ETowerDefenseEventBuildState.Polluted);
			}
			else
			{
				flag = true;
			}
		}
		bool result = this.IsInvalidPlacement != flag || this.IsCanPlace != flag2 || this.IsCanBuild != flag3 || this.IsPolluted != flag4;
		this.IsInvalidPlacement = flag;
		this.IsCanPlace = flag2;
		this.IsCanBuild = flag3;
		this.IsPolluted = flag4;
		return result;
	}

	// Token: 0x0601748E RID: 95374 RVA: 0x005EB274 File Offset: 0x005E9474
	private bool UpdateRecycleState(bool canRecycle)
	{
		bool flag = canRecycle && this.RaycastTarget != null;
		bool result = this.IsCanRecycle != flag;
		this.IsCanRecycle = flag;
		return result;
	}

	// Token: 0x0400AE36 RID: 44598
	private FKuroBuildingGridRaycastResult BuildingGridRaycastResult = new FKuroBuildingGridRaycastResult();

	// Token: 0x0400AE37 RID: 44599
	public Vector Start = Vector.Create();

	// Token: 0x0400AE38 RID: 44600
	public Vector End = Vector.Create();

	// Token: 0x0400AE39 RID: 44601
	[Nullable(2)]
	public TsTowerDefenseEventActor Target;

	// Token: 0x0400AE3A RID: 44602
	[Nullable(2)]
	public TsTowerDefenseEventActor RaycastTarget;

	// Token: 0x0400AE3B RID: 44603
	[Nullable(2)]
	public AKuroBuildingGrid Grid;

	// Token: 0x0400AE3C RID: 44604
	public Vector Location = Vector.Create();

	// Token: 0x0400AE3D RID: 44605
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400AE3E RID: 44606
	public Vector2D Coords = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400AE3F RID: 44607
	public float Degree;

	// Token: 0x0400AE40 RID: 44608
	public Vector Normal = Vector.Create();

	// Token: 0x0400AE41 RID: 44609
	public ETowerDefenseEventTrapPlacementType PlacementType = ETowerDefenseEventTrapPlacementType.Ground;

	// Token: 0x0400AE42 RID: 44610
	public bool IsStateDirty;

	// Token: 0x0400AE43 RID: 44611
	public bool IsInvalidPlacement;

	// Token: 0x0400AE44 RID: 44612
	public bool IsCanPlace;

	// Token: 0x0400AE45 RID: 44613
	public bool IsCanBuild;

	// Token: 0x0400AE46 RID: 44614
	public bool IsPolluted;

	// Token: 0x0400AE47 RID: 44615
	public int PollutedNum;

	// Token: 0x0400AE48 RID: 44616
	public bool IsCanRecycle;
}
