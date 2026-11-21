using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001413 RID: 5139
public class MonsterCursorUnit : HudUnitBase
{
	// Token: 0x0600CC44 RID: 52292 RVA: 0x003CC2C4 File Offset: 0x003CA4C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CC45 RID: 52293 RVA: 0x003CC3B1 File Offset: 0x003CA5B1
	[NullableContext(1)]
	public void Activate(HudEntityData hudEntity)
	{
		this.HudEntity = hudEntity;
		this.AddEntityEvents();
		this.RefreshState();
		if (base.GetActive())
		{
			this.SetActive(false);
		}
	}

	// Token: 0x0600CC46 RID: 52294 RVA: 0x003CC3D5 File Offset: 0x003CA5D5
	public void Deactivate()
	{
		if (this.HudEntity == null)
		{
			return;
		}
		this.HudEntity.ClearAllTagCountChangedCallback();
		this.HudEntity = null;
	}

	// Token: 0x0600CC47 RID: 52295 RVA: 0x003CC3F4 File Offset: 0x003CA5F4
	protected virtual void AddEntityEvents()
	{
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.部分动作"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪中"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
	}

	// Token: 0x0600CC48 RID: 52296 RVA: 0x003CC473 File Offset: 0x003CA673
	private void OnTagRefresh(int tagId, bool tagExist)
	{
		this.RefreshState();
	}

	// Token: 0x0600CC49 RID: 52297 RVA: 0x003CC47C File Offset: 0x003CA67C
	public int? GetEntityId()
	{
		HudEntityData hudEntity = this.HudEntity;
		if (hudEntity == null)
		{
			return null;
		}
		return new int?(hudEntity.GetId());
	}

	// Token: 0x0600CC4A RID: 52298 RVA: 0x003CC4A7 File Offset: 0x003CA6A7
	public bool IsValid()
	{
		return this.HudEntity != null;
	}

	// Token: 0x0600CC4B RID: 52299 RVA: 0x003CC4B2 File Offset: 0x003CA6B2
	[NullableContext(2)]
	public HudEntityData GetHudEntityData()
	{
		return this.HudEntity;
	}

	// Token: 0x0600CC4C RID: 52300 RVA: 0x003CC4BC File Offset: 0x003CA6BC
	public void Refresh(float scale, FVector2D position)
	{
		if (scale != this.CurScale)
		{
			this.CurScale = scale;
			base.GetUiNiagara((int)(3 + this.CurState)).SetNiagaraVarFloat("Scale", scale);
		}
		float inYaw = MathF.Atan2(position.Y, position.X) * 57.295776f - 90f;
		UUIItem rootItem = this.RootItem;
		FRotator frotator = new FRotator(0f, inYaw, 0f);
		rootItem.SetUIRelativeRotation(frotator);
		this.RootItem.SetAnchorOffset(position);
	}

	// Token: 0x0600CC4D RID: 52301 RVA: 0x003CC53C File Offset: 0x003CA73C
	private void RefreshState()
	{
		int num;
		if (this.HudEntity.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪中"]))
		{
			num = 2;
		}
		else if (this.HudEntity.ContainsTagById(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中"]))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (this.CurState == (MonsterCursorUnit.EState)num)
		{
			return;
		}
		this.CurState = (MonsterCursorUnit.EState)num;
		for (int i = 0; i < 3; i++)
		{
			base.GetItem(i).SetUIActive(i == num);
		}
		base.GetUiNiagara(3 + num).SetNiagaraVarFloat("Scale", this.CurScale);
	}

	// Token: 0x04007403 RID: 29699
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04007404 RID: 29700
	private const int CURSOR_NUM = 3;

	// Token: 0x04007405 RID: 29701
	[Nullable(2)]
	private HudEntityData HudEntity;

	// Token: 0x04007406 RID: 29702
	private MonsterCursorUnit.EState CurState;

	// Token: 0x04007407 RID: 29703
	private float CurScale = 1f;

	// Token: 0x020076D4 RID: 30420
	private enum EState
	{
		// Token: 0x0402698F RID: 158095
		Normal,
		// Token: 0x04026990 RID: 158096
		Skill,
		// Token: 0x04026991 RID: 158097
		FallDown
	}

	// Token: 0x020076D5 RID: 30421
	private enum EChildType
	{
		// Token: 0x04026993 RID: 158099
		CommonCursorItem,
		// Token: 0x04026994 RID: 158100
		FoundCursorItem,
		// Token: 0x04026995 RID: 158101
		FallDownCursorItem,
		// Token: 0x04026996 RID: 158102
		CommonNiagara,
		// Token: 0x04026997 RID: 158103
		FoundNiagara,
		// Token: 0x04026998 RID: 158104
		FallDownNiagara
	}
}
