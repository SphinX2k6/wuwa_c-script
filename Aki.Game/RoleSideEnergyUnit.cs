using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

// Token: 0x02001F53 RID: 8019
public class RoleSideEnergyUnit : HudUnitBase
{
	// Token: 0x0600F836 RID: 63542 RVA: 0x003C0F10 File Offset: 0x003BF110
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

	// Token: 0x0600F837 RID: 63543 RVA: 0x003C0F60 File Offset: 0x003BF160
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

	// Token: 0x0600F838 RID: 63544 RVA: 0x003C0FA8 File Offset: 0x003BF1A8
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
		this.CueConfig = null;
		this.RoleData = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600F839 RID: 63545 RVA: 0x003C0FCC File Offset: 0x003BF1CC
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

	// Token: 0x0600F83A RID: 63546 RVA: 0x003C103C File Offset: 0x003BF23C
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

	// Token: 0x0600F83B RID: 63547 RVA: 0x003C10AC File Offset: 0x003BF2AC
	protected void OnAttrChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		this.RefreshBarPercent();
	}

	// Token: 0x0600F83C RID: 63548 RVA: 0x003C10B4 File Offset: 0x003BF2B4
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

	// Token: 0x0600F83D RID: 63549 RVA: 0x003C112C File Offset: 0x003BF32C
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

	// Token: 0x0600F83E RID: 63550 RVA: 0x003C1230 File Offset: 0x003BF430
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

	// Token: 0x04007332 RID: 29490
	private const float MAX_DELTA_TIME = 200f;

	// Token: 0x04007333 RID: 29491
	private const float MIN_DELTA_OFFSET = 0.5f;

	// Token: 0x04007334 RID: 29492
	private const float MAX_POS_OFFSET = 500f;

	// Token: 0x04007335 RID: 29493
	private const float OFFSET_X = -150f;

	// Token: 0x04007336 RID: 29494
	protected GameplayCue? CueConfig;

	// Token: 0x04007337 RID: 29495
	[Nullable(2)]
	protected BattleUiRoleData RoleData;

	// Token: 0x04007338 RID: 29496
	protected EAttributeType AttrId;

	// Token: 0x04007339 RID: 29497
	protected EAttributeType MaxAttrId;

	// Token: 0x0400733A RID: 29498
	protected float OffsetX;

	// Token: 0x0400733B RID: 29499
	protected float OffsetY;

	// Token: 0x0400733C RID: 29500
	protected float SpeedX;

	// Token: 0x0400733D RID: 29501
	protected float SpeedY;

	// Token: 0x02008551 RID: 34129
	private enum EChildType
	{
		// Token: 0x0402B676 RID: 177782
		BarSprite
	}
}
