using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.TowerDefenseEvent.Model;
using UnrealEngine;

// Token: 0x02002148 RID: 8520
[NullableContext(1)]
[Nullable(0)]
public class TowerDefenseEventRaycastResult
{
	// Token: 0x06014EBB RID: 85691 RVA: 0x00617A5C File Offset: 0x00615C5C
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

	// Token: 0x06014EBC RID: 85692 RVA: 0x00617C30 File Offset: 0x00615E30
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

	// Token: 0x06014EBD RID: 85693 RVA: 0x00617D18 File Offset: 0x00615F18
	[NullableContext(2)]
	private bool UpdateRaycastState(TsTowerDefenseEventActor target, bool canRecycle)
	{
		bool flag = this.UpdateBuildState(target);
		bool flag2 = this.UpdateRecycleState(canRecycle);
		return flag || flag2;
	}

	// Token: 0x06014EBE RID: 85694 RVA: 0x00617D38 File Offset: 0x00615F38
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

	// Token: 0x06014EBF RID: 85695 RVA: 0x00617E0C File Offset: 0x0061600C
	private bool UpdateRecycleState(bool canRecycle)
	{
		bool flag = canRecycle && this.RaycastTarget != null;
		bool result = this.IsCanRecycle != flag;
		this.IsCanRecycle = flag;
		return result;
	}

	// Token: 0x0400B23B RID: 45627
	private FKuroBuildingGridRaycastResult BuildingGridRaycastResult = new FKuroBuildingGridRaycastResult();

	// Token: 0x0400B23C RID: 45628
	public Vector Start = Vector.Create();

	// Token: 0x0400B23D RID: 45629
	public Vector End = Vector.Create();

	// Token: 0x0400B23E RID: 45630
	[Nullable(2)]
	public TsTowerDefenseEventActor Target;

	// Token: 0x0400B23F RID: 45631
	[Nullable(2)]
	public TsTowerDefenseEventActor RaycastTarget;

	// Token: 0x0400B240 RID: 45632
	[Nullable(2)]
	public AKuroBuildingGrid Grid;

	// Token: 0x0400B241 RID: 45633
	public Vector Location = Vector.Create();

	// Token: 0x0400B242 RID: 45634
	public Rotator Rotation = Rotator.Create();

	// Token: 0x0400B243 RID: 45635
	public Vector2D Coords = Vector2D.Create(0.0, 0.0);

	// Token: 0x0400B244 RID: 45636
	public float Degree;

	// Token: 0x0400B245 RID: 45637
	public Vector Normal = Vector.Create();

	// Token: 0x0400B246 RID: 45638
	public ETowerDefenseEventTrapPlacementType PlacementType = ETowerDefenseEventTrapPlacementType.Ground;

	// Token: 0x0400B247 RID: 45639
	public bool IsStateDirty;

	// Token: 0x0400B248 RID: 45640
	public bool IsInvalidPlacement;

	// Token: 0x0400B249 RID: 45641
	public bool IsCanPlace;

	// Token: 0x0400B24A RID: 45642
	public bool IsCanBuild;

	// Token: 0x0400B24B RID: 45643
	public bool IsPolluted;

	// Token: 0x0400B24C RID: 45644
	public int PollutedNum;

	// Token: 0x0400B24D RID: 45645
	public bool IsCanRecycle;
}
