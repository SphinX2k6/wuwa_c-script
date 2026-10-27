using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F54 RID: 8020
[NullableContext(1)]
[Nullable(0)]
public class RoverlikeBossCursorUnit : HudUnitBase
{
	// Token: 0x0600F840 RID: 63552 RVA: 0x003C129C File Offset: 0x003BF49C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F841 RID: 63553 RVA: 0x003C1348 File Offset: 0x003BF548
	protected override void OnStart()
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
		this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		this.DirectionArrow = base.GetItem(0);
		this.DirectionArrowRed = base.GetItem(3);
	}

	// Token: 0x0600F842 RID: 63554 RVA: 0x003C13D2 File Offset: 0x003BF5D2
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600F843 RID: 63555 RVA: 0x003C13DB File Offset: 0x003BF5DB
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600F844 RID: 63556 RVA: 0x003C13E4 File Offset: 0x003BF5E4
	public void Activate(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.Deactivate();
			return;
		}
		this.EntityHandle = entityHandle;
		WorldEntity entity = this.EntityHandle.Entity;
		this.ActorComp = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
		WorldEntity entity2 = this.EntityHandle.Entity;
		this.TagComp = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
		this.AddEntityEvents();
		this.RefreshState(false);
		base.SetVisible(true, 0);
	}

	// Token: 0x0600F845 RID: 63557 RVA: 0x003C145F File Offset: 0x003BF65F
	public void Deactivate()
	{
		this.RemoveEntityEvents();
		this.EntityHandle = null;
		this.ActorComp = null;
		base.SetVisible(false, 0);
	}

	// Token: 0x0600F846 RID: 63558 RVA: 0x003C1480 File Offset: 0x003BF680
	public override void Tick(float deltaTime)
	{
		if (!this.TickEnabled)
		{
			return;
		}
		if (this.ActorComp == null)
		{
			return;
		}
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.Deactivate();
			return;
		}
		this.UpdateTargetPosition(this.ActorComp.ActorLocation);
	}

	// Token: 0x0600F847 RID: 63559 RVA: 0x003C14D0 File Offset: 0x003BF6D0
	public void UpdateTargetPosition(FVectorDouble targetPosition)
	{
		TsCharacterController characterController = Global.CharacterController;
		bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, targetPosition, ref this.ScreenPositionRef, false);
		if (!flag)
		{
			FTransformDouble? cameraTransform = CameraModel.Instance.MainModel.CameraTransform;
			FVectorDouble fvectorDouble = cameraTransform.Value.InverseTransformPositionNoScale(targetPosition);
			fvectorDouble.X = -fvectorDouble.X;
			FVectorDouble fvectorDouble2 = cameraTransform.Value.TransformPositionNoScale(fvectorDouble);
			UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble2, ref this.ScreenPositionRef, false);
		}
		this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0))
		{
			this.LastScreenPosition.DeepCopy(this.ScreenPosition);
			BattleUiModel instance = BattleUiModel.Instance;
			this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
			this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
			this.RootItem.SetAnchorOffset(this.ScreenPosition.ToUeVector2D(false));
			if (!this.InRange)
			{
				this.TempRotator.Reset();
				this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875 - 90.0);
				FRotator frotator = this.TempRotator.ToUeRotator();
				this.DirectionArrow.SetUIRelativeRotation(frotator);
				this.DirectionArrowRed.SetUIRelativeRotation(frotator);
				base.SetUiActive(true);
				return;
			}
			base.SetUiActive(false);
		}
	}

	// Token: 0x0600F848 RID: 63560 RVA: 0x003C1680 File Offset: 0x003BF880
	protected bool ClampToEllipse(Vector2D vector, bool inFront)
	{
		double x = vector.X;
		double y = vector.Y;
		float limitA = this.LimitA;
		float limitB = this.LimitB;
		if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
		{
			return true;
		}
		double inB = (double)(limitA * limitB) / Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
		vector.MultiplyEqual(inB);
		return false;
	}

	// Token: 0x0600F849 RID: 63561 RVA: 0x003C16F1 File Offset: 0x003BF8F1
	protected void AddEntityEvents()
	{
		this.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"], new Action<int, bool>(this.OnTagRefresh));
	}

	// Token: 0x0600F84A RID: 63562 RVA: 0x003C1714 File Offset: 0x003BF914
	protected void OnTagRefresh(int tagId, bool tagExist)
	{
		this.RefreshState(false);
	}

	// Token: 0x0600F84B RID: 63563 RVA: 0x003C1720 File Offset: 0x003BF920
	protected void RefreshState(bool bForce = false)
	{
		BaseTagComponent tagComp = this.TagComp;
		int num;
		if (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (this.CurState == (RoverlikeBossCursorUnit.EState)num && !bForce)
		{
			return;
		}
		this.CurState = (RoverlikeBossCursorUnit.EState)num;
		UUITexture texture = base.GetTexture(2);
		FColor? fcolor;
		if (num == 1)
		{
			base.GetItem(1).SetUIActive(true);
			UUIItem uuiitem = texture;
			bool bUseChangeColor = true;
			fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			this.DirectionArrow.SetUIActive(false);
			this.DirectionArrowRed.SetUIActive(true);
			return;
		}
		base.GetItem(1).SetUIActive(false);
		UUIItem uuiitem2 = texture;
		bool bUseChangeColor2 = false;
		fcolor = new FColor?(texture.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		this.DirectionArrow.SetUIActive(true);
		this.DirectionArrowRed.SetUIActive(false);
	}

	// Token: 0x0600F84C RID: 63564 RVA: 0x003C17ED File Offset: 0x003BF9ED
	protected void RemoveEntityEvents()
	{
		this.ClearAllTagTask();
	}

	// Token: 0x0600F84D RID: 63565 RVA: 0x003C17F8 File Offset: 0x003BF9F8
	protected void ListenForTagAddOrRemoveChanged(int tagId, Action<int, bool> onTagChange)
	{
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp == null)
		{
			return;
		}
		ITagTask tagTask = tagComp.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(onTagChange.Invoke), null);
		if (tagTask != null)
		{
			this.TagTaskList.Add(tagTask);
		}
	}

	// Token: 0x0600F84E RID: 63566 RVA: 0x003C183C File Offset: 0x003BFA3C
	protected void ClearAllTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0400733E RID: 29502
	private const float MAX_A = 1176f;

	// Token: 0x0400733F RID: 29503
	private const float MARGIN_A = 1008f;

	// Token: 0x04007340 RID: 29504
	private const float MAX_B = 712.5f;

	// Token: 0x04007341 RID: 29505
	private const float MARGIN_B = 495f;

	// Token: 0x04007342 RID: 29506
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04007343 RID: 29507
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x04007344 RID: 29508
	[Nullable(2)]
	protected UUIItem DirectionArrowRed;

	// Token: 0x04007345 RID: 29509
	protected FVector2D ScreenPositionRef;

	// Token: 0x04007346 RID: 29510
	protected Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x04007347 RID: 29511
	protected Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x04007348 RID: 29512
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x04007349 RID: 29513
	protected bool InRange;

	// Token: 0x0400734A RID: 29514
	protected Rotator TempRotator = Rotator.Create();

	// Token: 0x0400734B RID: 29515
	protected float LimitA;

	// Token: 0x0400734C RID: 29516
	protected float LimitB;

	// Token: 0x0400734D RID: 29517
	protected bool TickEnabled;

	// Token: 0x0400734E RID: 29518
	[Nullable(2)]
	protected EntityHandle EntityHandle;

	// Token: 0x0400734F RID: 29519
	[Nullable(2)]
	protected BaseActorComponent ActorComp;

	// Token: 0x04007350 RID: 29520
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x04007351 RID: 29521
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007352 RID: 29522
	protected RoverlikeBossCursorUnit.EState CurState;

	// Token: 0x02008552 RID: 34130
	[NullableContext(0)]
	protected enum EState
	{
		// Token: 0x0402B678 RID: 177784
		Normal,
		// Token: 0x0402B679 RID: 177785
		Skill,
		// Token: 0x0402B67A RID: 177786
		FallDown
	}

	// Token: 0x02008553 RID: 34131
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402B67B RID: 177787
		public const int DirectionArrow = 0;

		// Token: 0x0402B67C RID: 177788
		public const int BgLightItem = 1;

		// Token: 0x0402B67D RID: 177789
		public const int BgTex = 2;

		// Token: 0x0402B67E RID: 177790
		public const int DirectionArrowRed = 3;
	}
}
