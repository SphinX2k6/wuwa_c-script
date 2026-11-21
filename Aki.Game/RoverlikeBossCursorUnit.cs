using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001416 RID: 5142
[NullableContext(1)]
[Nullable(0)]
public class RoverlikeBossCursorUnit : HudUnitBase
{
	// Token: 0x0600CC5F RID: 52319 RVA: 0x003CCD88 File Offset: 0x003CAF88
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

	// Token: 0x0600CC60 RID: 52320 RVA: 0x003CCE34 File Offset: 0x003CB034
	protected override void OnStart()
	{
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
		this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
		this.DirectionArrow = base.GetItem(0);
		this.DirectionArrowRed = base.GetItem(3);
	}

	// Token: 0x0600CC61 RID: 52321 RVA: 0x003CCEBE File Offset: 0x003CB0BE
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600CC62 RID: 52322 RVA: 0x003CCEC7 File Offset: 0x003CB0C7
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600CC63 RID: 52323 RVA: 0x003CCED0 File Offset: 0x003CB0D0
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

	// Token: 0x0600CC64 RID: 52324 RVA: 0x003CCF4B File Offset: 0x003CB14B
	public void Deactivate()
	{
		this.RemoveEntityEvents();
		this.EntityHandle = null;
		this.ActorComp = null;
		base.SetVisible(false, 0);
	}

	// Token: 0x0600CC65 RID: 52325 RVA: 0x003CCF6C File Offset: 0x003CB16C
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

	// Token: 0x0600CC66 RID: 52326 RVA: 0x003CCFBC File Offset: 0x003CB1BC
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

	// Token: 0x0600CC67 RID: 52327 RVA: 0x003CD16C File Offset: 0x003CB36C
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

	// Token: 0x0600CC68 RID: 52328 RVA: 0x003CD1DD File Offset: 0x003CB3DD
	protected void AddEntityEvents()
	{
		this.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"], new Action<int, bool>(this.OnTagRefresh));
	}

	// Token: 0x0600CC69 RID: 52329 RVA: 0x003CD200 File Offset: 0x003CB400
	protected void OnTagRefresh(int tagId, bool tagExist)
	{
		this.RefreshState(false);
	}

	// Token: 0x0600CC6A RID: 52330 RVA: 0x003CD20C File Offset: 0x003CB40C
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

	// Token: 0x0600CC6B RID: 52331 RVA: 0x003CD2D9 File Offset: 0x003CB4D9
	protected void RemoveEntityEvents()
	{
		this.ClearAllTagTask();
	}

	// Token: 0x0600CC6C RID: 52332 RVA: 0x003CD2E4 File Offset: 0x003CB4E4
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

	// Token: 0x0600CC6D RID: 52333 RVA: 0x003CD328 File Offset: 0x003CB528
	protected void ClearAllTagTask()
	{
		foreach (ITagTask tagTask in this.TagTaskList)
		{
			tagTask.EndTask();
		}
		this.TagTaskList.Clear();
	}

	// Token: 0x0400741F RID: 29727
	private const float MAX_A = 1176f;

	// Token: 0x04007420 RID: 29728
	private const float MARGIN_A = 1008f;

	// Token: 0x04007421 RID: 29729
	private const float MAX_B = 712.5f;

	// Token: 0x04007422 RID: 29730
	private const float MARGIN_B = 495f;

	// Token: 0x04007423 RID: 29731
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04007424 RID: 29732
	[Nullable(2)]
	protected UUIItem DirectionArrow;

	// Token: 0x04007425 RID: 29733
	[Nullable(2)]
	protected UUIItem DirectionArrowRed;

	// Token: 0x04007426 RID: 29734
	protected FVector2D ScreenPositionRef;

	// Token: 0x04007427 RID: 29735
	protected Vector2D ScreenPosition = Vector2D.Create();

	// Token: 0x04007428 RID: 29736
	protected Vector2D LastScreenPosition = Vector2D.Create();

	// Token: 0x04007429 RID: 29737
	protected readonly Vector2D PointTransport = new Vector2D(1.0, -1.0);

	// Token: 0x0400742A RID: 29738
	protected bool InRange;

	// Token: 0x0400742B RID: 29739
	protected Rotator TempRotator = Rotator.Create();

	// Token: 0x0400742C RID: 29740
	protected float LimitA;

	// Token: 0x0400742D RID: 29741
	protected float LimitB;

	// Token: 0x0400742E RID: 29742
	protected bool TickEnabled;

	// Token: 0x0400742F RID: 29743
	[Nullable(2)]
	protected EntityHandle EntityHandle;

	// Token: 0x04007430 RID: 29744
	[Nullable(2)]
	protected BaseActorComponent ActorComp;

	// Token: 0x04007431 RID: 29745
	[Nullable(2)]
	protected BaseTagComponent TagComp;

	// Token: 0x04007432 RID: 29746
	protected readonly List<ITagTask> TagTaskList = new List<ITagTask>();

	// Token: 0x04007433 RID: 29747
	protected RoverlikeBossCursorUnit.EState CurState;

	// Token: 0x020076D7 RID: 30423
	[NullableContext(0)]
	protected enum EState
	{
		// Token: 0x0402699C RID: 158108
		Normal,
		// Token: 0x0402699D RID: 158109
		Skill,
		// Token: 0x0402699E RID: 158110
		FallDown
	}

	// Token: 0x020076D8 RID: 30424
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402699F RID: 158111
		public const int DirectionArrow = 0;

		// Token: 0x040269A0 RID: 158112
		public const int BgLightItem = 1;

		// Token: 0x040269A1 RID: 158113
		public const int BgTex = 2;

		// Token: 0x040269A2 RID: 158114
		public const int DirectionArrowRed = 3;
	}
}
