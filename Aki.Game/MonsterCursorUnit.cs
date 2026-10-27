using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001F51 RID: 8017
public class MonsterCursorUnit : HudUnitBase
{
	// Token: 0x0600F825 RID: 63525 RVA: 0x003C07D8 File Offset: 0x003BE9D8
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

	// Token: 0x0600F826 RID: 63526 RVA: 0x003C08C5 File Offset: 0x003BEAC5
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

	// Token: 0x0600F827 RID: 63527 RVA: 0x003C08E9 File Offset: 0x003BEAE9
	public void Deactivate()
	{
		if (this.HudEntity == null)
		{
			return;
		}
		this.HudEntity.ClearAllTagCountChangedCallback();
		this.HudEntity = null;
	}

	// Token: 0x0600F828 RID: 63528 RVA: 0x003C0908 File Offset: 0x003BEB08
	protected virtual void AddEntityEvents()
	{
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.部分动作"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
		this.HudEntity.ListenForTagAddOrRemove(GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪中"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagRefresh));
	}

	// Token: 0x0600F829 RID: 63529 RVA: 0x003C0987 File Offset: 0x003BEB87
	private void OnTagRefresh(int tagId, bool tagExist)
	{
		this.RefreshState();
	}

	// Token: 0x0600F82A RID: 63530 RVA: 0x003C0990 File Offset: 0x003BEB90
	public int? GetEntityId()
	{
		HudEntityData hudEntity = this.HudEntity;
		if (hudEntity == null)
		{
			return null;
		}
		return new int?(hudEntity.GetId());
	}

	// Token: 0x0600F82B RID: 63531 RVA: 0x003C09BB File Offset: 0x003BEBBB
	public bool IsValid()
	{
		return this.HudEntity != null;
	}

	// Token: 0x0600F82C RID: 63532 RVA: 0x003C09C6 File Offset: 0x003BEBC6
	[NullableContext(2)]
	public HudEntityData GetHudEntityData()
	{
		return this.HudEntity;
	}

	// Token: 0x0600F82D RID: 63533 RVA: 0x003C09D0 File Offset: 0x003BEBD0
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

	// Token: 0x0600F82E RID: 63534 RVA: 0x003C0A50 File Offset: 0x003BEC50
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

	// Token: 0x04007322 RID: 29474
	private const float RAD_2_DEG = 57.295776f;

	// Token: 0x04007323 RID: 29475
	private const int CURSOR_NUM = 3;

	// Token: 0x04007324 RID: 29476
	[Nullable(2)]
	private HudEntityData HudEntity;

	// Token: 0x04007325 RID: 29477
	private MonsterCursorUnit.EState CurState;

	// Token: 0x04007326 RID: 29478
	private float CurScale = 1f;

	// Token: 0x0200854F RID: 34127
	private enum EState
	{
		// Token: 0x0402B66B RID: 177771
		Normal,
		// Token: 0x0402B66C RID: 177772
		Skill,
		// Token: 0x0402B66D RID: 177773
		FallDown
	}

	// Token: 0x02008550 RID: 34128
	private enum EChildType
	{
		// Token: 0x0402B66F RID: 177775
		CommonCursorItem,
		// Token: 0x0402B670 RID: 177776
		FoundCursorItem,
		// Token: 0x0402B671 RID: 177777
		FallDownCursorItem,
		// Token: 0x0402B672 RID: 177778
		CommonNiagara,
		// Token: 0x0402B673 RID: 177779
		FoundNiagara,
		// Token: 0x0402B674 RID: 177780
		FallDownNiagara
	}
}
