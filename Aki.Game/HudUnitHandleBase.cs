using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013EF RID: 5103
[NullableContext(1)]
[Nullable(0)]
public abstract class HudUnitHandleBase
{
	// Token: 0x0600CA11 RID: 51729 RVA: 0x003C1BAD File Offset: 0x003BFDAD
	public void Initialize()
	{
		this.PlayerController = Global.CharacterController;
		this.PlayerCameraManager = Global.CharacterCameraManager;
		this.HudItem = UiLayer.Instance.GetBattleViewUnit(1);
		this.OnAddEvents();
		this.OnInitialize();
	}

	// Token: 0x0600CA12 RID: 51730 RVA: 0x003C1BE4 File Offset: 0x003BFDE4
	protected void InitCursorAxis()
	{
		float num = (float)ConfigCommonParamById.GetIntConfig("MonsterCursorWidthToScreenPercent").Value / 100f;
		float num2 = (float)ConfigCommonParamById.GetIntConfig("MonsterCursorHeightToScreenPercent").Value / 100f;
		this.MajorAxis = this.HudItem.GetWidth() * num;
		this.MinorAxis = this.HudItem.GetHeight() * num2;
	}

	// Token: 0x0600CA13 RID: 51731 RVA: 0x003C1C4B File Offset: 0x003BFE4B
	public void Destroy()
	{
		this.OnDestroyed();
		this.OnRemoveEvents();
		this.DestroyAllHudUnit();
		this.IsDestroyed = true;
		HudEntitySet hudEntitySet = this.HudEntitySet;
		if (hudEntitySet != null)
		{
			hudEntitySet.Clear();
		}
		this.HudEntitySet = null;
	}

	// Token: 0x0600CA14 RID: 51732 RVA: 0x003C1C80 File Offset: 0x003BFE80
	public void Tick(float delta)
	{
		this.OnTick(delta);
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.Tick(delta);
		}
	}

	// Token: 0x0600CA15 RID: 51733 RVA: 0x003C1CD8 File Offset: 0x003BFED8
	public void AfterTick(float delta)
	{
		this.OnAfterTick(delta);
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.AfterTick(delta);
		}
	}

	// Token: 0x0600CA16 RID: 51734 RVA: 0x003C1D30 File Offset: 0x003BFF30
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x0600CA17 RID: 51735 RVA: 0x003C1D32 File Offset: 0x003BFF32
	protected virtual void OnDestroyed()
	{
	}

	// Token: 0x0600CA18 RID: 51736 RVA: 0x003C1D34 File Offset: 0x003BFF34
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600CA19 RID: 51737 RVA: 0x003C1D36 File Offset: 0x003BFF36
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x0600CA1A RID: 51738 RVA: 0x003C1D38 File Offset: 0x003BFF38
	public virtual void OnShowHud()
	{
		this.IsHudVisible = true;
	}

	// Token: 0x0600CA1B RID: 51739 RVA: 0x003C1D41 File Offset: 0x003BFF41
	public void OnHideHud()
	{
		this.IsHudVisible = false;
	}

	// Token: 0x0600CA1C RID: 51740 RVA: 0x003C1D4A File Offset: 0x003BFF4A
	public virtual void OnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
	}

	// Token: 0x0600CA1D RID: 51741
	protected abstract void OnAddEvents();

	// Token: 0x0600CA1E RID: 51742
	protected abstract void OnRemoveEvents();

	// Token: 0x0600CA1F RID: 51743 RVA: 0x003C1D4C File Offset: 0x003BFF4C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	protected UniTask<T> NewHudUnit<[Nullable(0)] T>(Type hudUnitClass, string resourceId, bool showAfterCreate = true, bool needSafeZone = false) where T : HudUnitBase
	{
		HudUnitHandleBase.<NewHudUnit>d__31<T> <NewHudUnit>d__;
		<NewHudUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<NewHudUnit>d__.<>4__this = this;
		<NewHudUnit>d__.hudUnitClass = hudUnitClass;
		<NewHudUnit>d__.resourceId = resourceId;
		<NewHudUnit>d__.showAfterCreate = showAfterCreate;
		<NewHudUnit>d__.needSafeZone = needSafeZone;
		<NewHudUnit>d__.<>1__state = -1;
		<NewHudUnit>d__.<>t__builder.Start<HudUnitHandleBase.<NewHudUnit>d__31<T>>(ref <NewHudUnit>d__);
		return <NewHudUnit>d__.<>t__builder.Task;
	}

	// Token: 0x0600CA20 RID: 51744 RVA: 0x003C1DB0 File Offset: 0x003BFFB0
	protected void NewHudUnitWithReturn<[Nullable(0)] T>(Type hudUnitClass, string resourceId, out T outHudUnit, bool showAfterCreate = true, [Nullable(new byte[]
	{
		2,
		1
	})] Action<T> onLoadedFinished = null, bool needSafeZone = false) where T : HudUnitBase
	{
		HudUnitBase hudUnitBase = Activator.CreateInstance(hudUnitClass) as HudUnitBase;
		T result = hudUnitBase as T;
		outHudUnit = result;
		hudUnitBase.Initialize(resourceId, showAfterCreate, needSafeZone).ContinueWith(delegate()
		{
			if (onLoadedFinished != null)
			{
				onLoadedFinished(result);
			}
		});
		this.HudUnitSet.Add(hudUnitBase);
	}

	// Token: 0x0600CA21 RID: 51745 RVA: 0x003C1E1E File Offset: 0x003C001E
	protected void DestroyHudUnit(HudUnitBase hudUnit)
	{
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.Destroy(null);
		this.HudUnitSet.Remove(hudUnit);
	}

	// Token: 0x0600CA22 RID: 51746 RVA: 0x003C1E38 File Offset: 0x003C0038
	protected void DestroyAllHudUnit()
	{
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.Destroy(null);
		}
		this.HudUnitSet.Clear();
	}

	// Token: 0x0600CA23 RID: 51747 RVA: 0x003C1E94 File Offset: 0x003C0094
	protected void NewHudEntitySet()
	{
		this.HudEntitySet = new HudEntitySet();
		this.HudEntitySet.Initialize();
	}

	// Token: 0x0600CA24 RID: 51748 RVA: 0x003C1EAC File Offset: 0x003C00AC
	private float GetViewportSizeX()
	{
		int num = 0;
		this.PlayerController.GetViewportSize(ref this.ViewportSizeX, ref num);
		return (float)this.ViewportSizeX;
	}

	// Token: 0x0600CA25 RID: 51749 RVA: 0x003C1ED5 File Offset: 0x003C00D5
	private FVector2D GetUiRootItemSize()
	{
		return new FVector2D(this.HudItem.GetWidth(), this.HudItem.GetHeight());
	}

	// Token: 0x0600CA26 RID: 51750 RVA: 0x003C1EF4 File Offset: 0x003C00F4
	private FVector2D ClampToEllipse(FVector2D vector, float majorAxis, float minorAxis, bool isInScreen)
	{
		float x = vector.X;
		float y = vector.Y;
		if (isInScreen && x * x / (majorAxis * majorAxis) + y * y / (minorAxis * minorAxis) <= 1f)
		{
			return vector;
		}
		float scale = majorAxis * minorAxis / (float)Math.Sqrt((double)(minorAxis * minorAxis * x * x + majorAxis * majorAxis * y * y));
		return vector * scale;
	}

	// Token: 0x0600CA27 RID: 51751 RVA: 0x003C1F50 File Offset: 0x003C0150
	protected FVector2D ScreenPositionToEllipsePosition(FVector2D screenPosition, bool isInScreen)
	{
		float viewportSizeX = this.GetViewportSizeX();
		FVector2D uiRootItemSize = this.GetUiRootItemSize();
		FVector2D vector = screenPosition * (uiRootItemSize.X / viewportSizeX);
		FVector2D fvector2D = uiRootItemSize * 0.5f;
		vector = vector - fvector2D;
		vector = vector * this.PointTransport;
		FVector2D fvector2D2 = this.ClampToEllipse(vector, this.MajorAxis, this.MinorAxis, isInScreen);
		return fvector2D2 + this.Center;
	}

	// Token: 0x0600CA28 RID: 51752 RVA: 0x003C1FC3 File Offset: 0x003C01C3
	private global::Vector GetTargetToPlayerVector(global::Vector playerLocation, global::Vector targetLocation)
	{
		targetLocation.Subtraction(playerLocation, this.TargetToPlayerVector);
		return this.TargetToPlayerVector;
	}

	// Token: 0x0600CA29 RID: 51753 RVA: 0x003C1FDC File Offset: 0x003C01DC
	private FVectorDouble GetCameraForwardVector()
	{
		return this.PlayerCameraManager.GetCameraRotation().VectorDouble();
	}

	// Token: 0x0600CA2A RID: 51754 RVA: 0x003C1FFC File Offset: 0x003C01FC
	protected global::Vector GetProjectionToFrontPosition(global::Vector playerLocation, FVectorDouble targetLocation)
	{
		this.TargetLocation.Set(targetLocation.X, targetLocation.Y, targetLocation.Z);
		global::Vector targetToPlayerVector = this.GetTargetToPlayerVector(playerLocation, this.TargetLocation);
		FVectorDouble cameraForwardVector = this.GetCameraForwardVector();
		FVectorDouble fvectorDouble = UKismetMathLibrary.D_ProjectVectorOnToVector(targetToPlayerVector.ToUeVector(false), cameraForwardVector);
		FVectorDouble fvectorDouble2 = fvectorDouble * 2.0;
		this.ProjectScreenLocation.Set(fvectorDouble2.X, fvectorDouble2.Y, fvectorDouble2.Z);
		targetToPlayerVector.SubtractionEqual(this.ProjectScreenLocation);
		playerLocation.Addition(targetToPlayerVector, this.TargetLocation);
		return this.TargetLocation;
	}

	// Token: 0x0600CA2B RID: 51755 RVA: 0x003C2098 File Offset: 0x003C0298
	protected FVector2D? ProjectWorldToScreen(FVectorDouble worldLocation)
	{
		if (!UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, worldLocation, ref this.ScreenPositionRef, false))
		{
			return null;
		}
		return new FVector2D?(this.HudItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(this.ScreenPositionRef));
	}

	// Token: 0x0600CA2C RID: 51756 RVA: 0x003C20E0 File Offset: 0x003C02E0
	[NullableContext(0)]
	protected ValueTuple<FVector2D, FVector2D?> GetInEllipsePosition([Nullable(1)] global::Vector playerLocation, FVectorDouble entityLocation)
	{
		bool flag = UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, entityLocation, ref this.ScreenPositionRef, false);
		FVector fvector = this.ScreenPositionRef;
		FVector2D screenPosition = new FVector2D(ref fvector);
		if (flag)
		{
			return new ValueTuple<FVector2D, FVector2D?>(this.ScreenPositionToEllipsePosition(screenPosition, true), new FVector2D?(this.ScreenPositionRef));
		}
		global::Vector projectionToFrontPosition = this.GetProjectionToFrontPosition(playerLocation, entityLocation);
		APlayerController playerController = this.PlayerController;
		FVectorDouble fvectorDouble = projectionToFrontPosition.ToUeVector(false);
		UGameplayStatics.D_ProjectWorldToScreen(playerController, fvectorDouble, ref this.ScreenPositionRef, false);
		return new ValueTuple<FVector2D, FVector2D?>(this.ScreenPositionToEllipsePosition(screenPosition, false), null);
	}

	// Token: 0x040072B1 RID: 29361
	private const float CenterY = 62.5f;

	// Token: 0x040072B2 RID: 29362
	private readonly HashSet<HudUnitBase> HudUnitSet = new HashSet<HudUnitBase>();

	// Token: 0x040072B3 RID: 29363
	[Nullable(2)]
	protected HudEntitySet HudEntitySet;

	// Token: 0x040072B4 RID: 29364
	[Nullable(2)]
	private APlayerController PlayerController;

	// Token: 0x040072B5 RID: 29365
	[Nullable(2)]
	private APlayerCameraManager PlayerCameraManager;

	// Token: 0x040072B6 RID: 29366
	private FVector2D ScreenPositionRef = new FVector2D();

	// Token: 0x040072B7 RID: 29367
	[Nullable(2)]
	private UUIItem HudItem;

	// Token: 0x040072B8 RID: 29368
	private readonly global::Vector TargetLocation = global::Vector.Create();

	// Token: 0x040072B9 RID: 29369
	private int ViewportSizeX;

	// Token: 0x040072BA RID: 29370
	private readonly FVector2D PointTransport = new FVector2D(1f, -1f);

	// Token: 0x040072BB RID: 29371
	private float MajorAxis;

	// Token: 0x040072BC RID: 29372
	private float MinorAxis;

	// Token: 0x040072BD RID: 29373
	private readonly FVector2D Center = new FVector2D(0f, 62.5f);

	// Token: 0x040072BE RID: 29374
	private readonly global::Vector TargetToPlayerVector = global::Vector.Create();

	// Token: 0x040072BF RID: 29375
	private readonly global::Vector ProjectScreenLocation = global::Vector.Create();

	// Token: 0x040072C0 RID: 29376
	protected bool IsHudVisible;

	// Token: 0x040072C1 RID: 29377
	protected bool IsDestroyed;
}
