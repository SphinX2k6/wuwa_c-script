using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F2D RID: 7981
[NullableContext(1)]
[Nullable(0)]
public abstract class HudUnitHandleBase
{
	// Token: 0x0600F5F2 RID: 62962 RVA: 0x003B60C1 File Offset: 0x003B42C1
	public void Initialize()
	{
		this.PlayerController = Global.CharacterController;
		this.PlayerCameraManager = Global.CharacterCameraManager;
		this.HudItem = UiLayer.Instance.GetBattleViewUnit(1);
		this.OnAddEvents();
		this.OnInitialize();
	}

	// Token: 0x0600F5F3 RID: 62963 RVA: 0x003B60F8 File Offset: 0x003B42F8
	protected void InitCursorAxis()
	{
		float num = (float)ConfigCommonParamById.GetIntConfig("MonsterCursorWidthToScreenPercent").Value / 100f;
		float num2 = (float)ConfigCommonParamById.GetIntConfig("MonsterCursorHeightToScreenPercent").Value / 100f;
		this.MajorAxis = this.HudItem.GetWidth() * num;
		this.MinorAxis = this.HudItem.GetHeight() * num2;
	}

	// Token: 0x0600F5F4 RID: 62964 RVA: 0x003B615F File Offset: 0x003B435F
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

	// Token: 0x0600F5F5 RID: 62965 RVA: 0x003B6194 File Offset: 0x003B4394
	public void Tick(float delta)
	{
		this.OnTick(delta);
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.Tick(delta);
		}
	}

	// Token: 0x0600F5F6 RID: 62966 RVA: 0x003B61EC File Offset: 0x003B43EC
	public void AfterTick(float delta)
	{
		this.OnAfterTick(delta);
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.AfterTick(delta);
		}
	}

	// Token: 0x0600F5F7 RID: 62967 RVA: 0x003B6244 File Offset: 0x003B4444
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x0600F5F8 RID: 62968 RVA: 0x003B6246 File Offset: 0x003B4446
	protected virtual void OnDestroyed()
	{
	}

	// Token: 0x0600F5F9 RID: 62969 RVA: 0x003B6248 File Offset: 0x003B4448
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600F5FA RID: 62970 RVA: 0x003B624A File Offset: 0x003B444A
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x0600F5FB RID: 62971 RVA: 0x003B624C File Offset: 0x003B444C
	public virtual void OnShowHud()
	{
		this.IsHudVisible = true;
	}

	// Token: 0x0600F5FC RID: 62972 RVA: 0x003B6255 File Offset: 0x003B4455
	public void OnHideHud()
	{
		this.IsHudVisible = false;
	}

	// Token: 0x0600F5FD RID: 62973 RVA: 0x003B625E File Offset: 0x003B445E
	public virtual void OnInputControllerChanged(EInputControllerType last, EInputControllerType now)
	{
	}

	// Token: 0x0600F5FE RID: 62974
	protected abstract void OnAddEvents();

	// Token: 0x0600F5FF RID: 62975
	protected abstract void OnRemoveEvents();

	// Token: 0x0600F600 RID: 62976 RVA: 0x003B6260 File Offset: 0x003B4460
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

	// Token: 0x0600F601 RID: 62977 RVA: 0x003B62C4 File Offset: 0x003B44C4
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

	// Token: 0x0600F602 RID: 62978 RVA: 0x003B6332 File Offset: 0x003B4532
	protected void DestroyHudUnit(HudUnitBase hudUnit)
	{
		if (hudUnit == null)
		{
			return;
		}
		hudUnit.Destroy(null);
		this.HudUnitSet.Remove(hudUnit);
	}

	// Token: 0x0600F603 RID: 62979 RVA: 0x003B634C File Offset: 0x003B454C
	protected void DestroyAllHudUnit()
	{
		foreach (HudUnitBase hudUnitBase in this.HudUnitSet)
		{
			hudUnitBase.Destroy(null);
		}
		this.HudUnitSet.Clear();
	}

	// Token: 0x0600F604 RID: 62980 RVA: 0x003B63A8 File Offset: 0x003B45A8
	protected void NewHudEntitySet()
	{
		this.HudEntitySet = new HudEntitySet();
		this.HudEntitySet.Initialize();
	}

	// Token: 0x0600F605 RID: 62981 RVA: 0x003B63C0 File Offset: 0x003B45C0
	private float GetViewportSizeX()
	{
		int num = 0;
		this.PlayerController.GetViewportSize(ref this.ViewportSizeX, ref num);
		return (float)this.ViewportSizeX;
	}

	// Token: 0x0600F606 RID: 62982 RVA: 0x003B63E9 File Offset: 0x003B45E9
	private FVector2D GetUiRootItemSize()
	{
		return new FVector2D(this.HudItem.GetWidth(), this.HudItem.GetHeight());
	}

	// Token: 0x0600F607 RID: 62983 RVA: 0x003B6408 File Offset: 0x003B4608
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

	// Token: 0x0600F608 RID: 62984 RVA: 0x003B6464 File Offset: 0x003B4664
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

	// Token: 0x0600F609 RID: 62985 RVA: 0x003B64D7 File Offset: 0x003B46D7
	private global::Vector GetTargetToPlayerVector(global::Vector playerLocation, global::Vector targetLocation)
	{
		targetLocation.Subtraction(playerLocation, this.TargetToPlayerVector);
		return this.TargetToPlayerVector;
	}

	// Token: 0x0600F60A RID: 62986 RVA: 0x003B64F0 File Offset: 0x003B46F0
	private FVectorDouble GetCameraForwardVector()
	{
		return this.PlayerCameraManager.GetCameraRotation().VectorDouble();
	}

	// Token: 0x0600F60B RID: 62987 RVA: 0x003B6510 File Offset: 0x003B4710
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

	// Token: 0x0600F60C RID: 62988 RVA: 0x003B65AC File Offset: 0x003B47AC
	protected FVector2D? ProjectWorldToScreen(FVectorDouble worldLocation)
	{
		if (!UGameplayStatics.D_ProjectWorldToScreen(this.PlayerController, worldLocation, ref this.ScreenPositionRef, false))
		{
			return null;
		}
		return new FVector2D?(this.HudItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(this.ScreenPositionRef));
	}

	// Token: 0x0600F60D RID: 62989 RVA: 0x003B65F4 File Offset: 0x003B47F4
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

	// Token: 0x040071D0 RID: 29136
	private const float CenterY = 62.5f;

	// Token: 0x040071D1 RID: 29137
	private readonly HashSet<HudUnitBase> HudUnitSet = new HashSet<HudUnitBase>();

	// Token: 0x040071D2 RID: 29138
	[Nullable(2)]
	protected HudEntitySet HudEntitySet;

	// Token: 0x040071D3 RID: 29139
	[Nullable(2)]
	private APlayerController PlayerController;

	// Token: 0x040071D4 RID: 29140
	[Nullable(2)]
	private APlayerCameraManager PlayerCameraManager;

	// Token: 0x040071D5 RID: 29141
	private FVector2D ScreenPositionRef = new FVector2D();

	// Token: 0x040071D6 RID: 29142
	[Nullable(2)]
	private UUIItem HudItem;

	// Token: 0x040071D7 RID: 29143
	private readonly global::Vector TargetLocation = global::Vector.Create();

	// Token: 0x040071D8 RID: 29144
	private int ViewportSizeX;

	// Token: 0x040071D9 RID: 29145
	private readonly FVector2D PointTransport = new FVector2D(1f, -1f);

	// Token: 0x040071DA RID: 29146
	private float MajorAxis;

	// Token: 0x040071DB RID: 29147
	private float MinorAxis;

	// Token: 0x040071DC RID: 29148
	private readonly FVector2D Center = new FVector2D(0f, 62.5f);

	// Token: 0x040071DD RID: 29149
	private readonly global::Vector TargetToPlayerVector = global::Vector.Create();

	// Token: 0x040071DE RID: 29150
	private readonly global::Vector ProjectScreenLocation = global::Vector.Create();

	// Token: 0x040071DF RID: 29151
	protected bool IsHudVisible;

	// Token: 0x040071E0 RID: 29152
	protected bool IsDestroyed;
}
