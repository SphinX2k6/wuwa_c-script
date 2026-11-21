using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x02001415 RID: 5141
public class RoleSideEnergyUnit : HudUnitBase
{
	// Token: 0x0600CC55 RID: 52309 RVA: 0x003CC9FC File Offset: 0x003CABFC
	[NullableContext(1)]
	public void InitInfo(GameplayCue cueConfig, BattleUiRoleData roleData)
	{
		this.CueConfig = new GameplayCue?(cueConfig);
		this.RoleData = roleData;
		this.AttrId = (EAttributeType)cueConfig.AttrId;
		this.MaxAttrId = CharacterAttributeTypes.attributeIdsWithMax.GetValueOrDefault(this.AttrId, EAttributeType.None);
		this.AddEvents();
		this.RefreshBarPercent();
	}

	// Token: 0x0600CC56 RID: 52310 RVA: 0x003CCA4C File Offset: 0x003CAC4C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CC57 RID: 52311 RVA: 0x003CCA94 File Offset: 0x003CAC94
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
		this.CueConfig = null;
		this.RoleData = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600CC58 RID: 52312 RVA: 0x003CCAB8 File Offset: 0x003CACB8
	protected virtual void AddEvents()
	{
		if (this.AttrId != EAttributeType.None)
		{
			BattleUiRoleData roleData = this.RoleData;
			if (((roleData != null) ? roleData.AttributeComponent : null) != null)
			{
				this.RoleData.AttributeComponent.AddListener(this.AttrId, new Action<EAttributeType, float, float>(this.OnAttrChanged), null);
				this.RoleData.AttributeComponent.AddListener(this.MaxAttrId, new Action<EAttributeType, float, float>(this.OnAttrChanged), null);
				return;
			}
		}
	}

	// Token: 0x0600CC59 RID: 52313 RVA: 0x003CCB28 File Offset: 0x003CAD28
	protected virtual void RemoveEvents()
	{
		if (this.AttrId != EAttributeType.None)
		{
			BattleUiRoleData roleData = this.RoleData;
			if (((roleData != null) ? roleData.AttributeComponent : null) != null)
			{
				this.RoleData.AttributeComponent.RemoveListener(this.AttrId, new Action<EAttributeType, float, float>(this.OnAttrChanged));
				this.RoleData.AttributeComponent.RemoveListener(this.MaxAttrId, new Action<EAttributeType, float, float>(this.OnAttrChanged));
				return;
			}
		}
	}

	// Token: 0x0600CC5A RID: 52314 RVA: 0x003CCB98 File Offset: 0x003CAD98
	protected void OnAttrChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshBarPercent();
	}

	// Token: 0x0600CC5B RID: 52315 RVA: 0x003CCBA0 File Offset: 0x003CADA0
	protected virtual void RefreshBarPercent()
	{
		if (this.AttrId != EAttributeType.None)
		{
			BattleUiRoleData roleData = this.RoleData;
			if (((roleData != null) ? roleData.AttributeComponent : null) != null)
			{
				float currentValue = this.RoleData.AttributeComponent.GetCurrentValue(this.AttrId);
				float currentValue2 = this.RoleData.AttributeComponent.GetCurrentValue(this.MaxAttrId);
				float fillAmount = (currentValue2 == 0f) ? 0f : (currentValue / currentValue2);
				base.GetSprite(0).SetFillAmount(fillAmount);
				return;
			}
		}
	}

	// Token: 0x0600CC5C RID: 52316 RVA: 0x003CCC18 File Offset: 0x003CAE18
	[NullableContext(1)]
	public void RefreshTargetPosition(float delta, Vector2D screenPos)
	{
		float num = (float)screenPos.X;
		float num2 = (float)screenPos.Y;
		if (Math.Abs(num - this.OffsetX) > 500f || Math.Abs(num2 - this.OffsetY) > 500f)
		{
			this.OffsetX = num;
			this.OffsetY = num2;
			base.SetAnchorOffset(this.OffsetX, this.OffsetY);
			return;
		}
		this.SpeedX = this.GetSpeed(delta, num, this.OffsetX, this.SpeedX);
		this.SpeedY = this.GetSpeed(delta, num2, this.OffsetY, this.SpeedY);
		float num3 = this.SpeedX * delta;
		float num4 = this.SpeedY * delta;
		if (num3 < 0.5f && num3 > -0.5f && num4 < 0.5f && num4 > -0.5f)
		{
			return;
		}
		this.OffsetX += num3;
		this.OffsetY += num4;
		base.SetAnchorOffset(this.OffsetX + -150f, this.OffsetY);
	}

	// Token: 0x0600CC5D RID: 52317 RVA: 0x003CCD1C File Offset: 0x003CAF1C
	private float GetSpeed(float delta, float target, float cur, float lastSpeed)
	{
		float num = target - cur;
		bool flag = false;
		if (num < 0f)
		{
			num = -num;
			flag = true;
		}
		if (num < 1f)
		{
			return 0f;
		}
		float num2;
		if (delta >= 200f)
		{
			num2 = num / delta;
		}
		else
		{
			num2 = num / 200f;
		}
		if (flag)
		{
			num2 = -num2;
		}
		return MathUtils.Instance.Lerp(lastSpeed, num2, 0.5f);
	}

	// Token: 0x04007413 RID: 29715
	private const float MAX_DELTA_TIME = 200f;

	// Token: 0x04007414 RID: 29716
	private const float MIN_DELTA_OFFSET = 0.5f;

	// Token: 0x04007415 RID: 29717
	private const float MAX_POS_OFFSET = 500f;

	// Token: 0x04007416 RID: 29718
	private const float OFFSET_X = -150f;

	// Token: 0x04007417 RID: 29719
	protected GameplayCue? CueConfig;

	// Token: 0x04007418 RID: 29720
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x04007419 RID: 29721
	protected EAttributeType AttrId;

	// Token: 0x0400741A RID: 29722
	protected EAttributeType MaxAttrId;

	// Token: 0x0400741B RID: 29723
	protected float OffsetX;

	// Token: 0x0400741C RID: 29724
	protected float OffsetY;

	// Token: 0x0400741D RID: 29725
	protected float SpeedX;

	// Token: 0x0400741E RID: 29726
	protected float SpeedY;

	// Token: 0x020076D6 RID: 30422
	private enum EChildType
	{
		// Token: 0x0402699A RID: 158106
		BarSprite
	}
}
