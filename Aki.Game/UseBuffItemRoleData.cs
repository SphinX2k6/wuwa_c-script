using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000BD1 RID: 3025
[NullableContext(1)]
[Nullable(0)]
public class UseBuffItemRoleData
{
	// Token: 0x06007E67 RID: 32359 RVA: 0x0026F328 File Offset: 0x0026D528
	public UseBuffItemRoleData(string roleName, int position, int roleConfigId, int roleLevel, float currentAttribute, float maxAttribute, int useItemConfigId, Entity entity)
	{
		this.RoleName = roleName;
		this.Position = position;
		this.RoleConfigId = roleConfigId;
		this.RoleLevel = roleLevel;
		this.CurrentAttribute = currentAttribute;
		this.MaxAttribute = maxAttribute;
		this.UseItemConfigId = useItemConfigId;
		this.Entity = entity;
	}

	// Token: 0x06007E68 RID: 32360 RVA: 0x0026F378 File Offset: 0x0026D578
	public void SetCurrentAttribute(float currentAttribute)
	{
		this.CurrentAttribute = currentAttribute;
	}

	// Token: 0x06007E69 RID: 32361 RVA: 0x0026F381 File Offset: 0x0026D581
	public void SetUseItemCount(int useItemCount)
	{
		this.UseItemCountInternal = useItemCount;
	}

	// Token: 0x06007E6A RID: 32362 RVA: 0x0026F38A File Offset: 0x0026D58A
	public void AddUseItemCount()
	{
		if (InventoryModel.Instance.GetItemCountByConfigId(this.UseItemConfigId, 0) <= this.UseItemCountInternal)
		{
			return;
		}
		this.UseItemCountInternal++;
	}

	// Token: 0x06007E6B RID: 32363 RVA: 0x0026F3B4 File Offset: 0x0026D5B4
	public void ReduceUseItemCount()
	{
		if (this.UseItemCountInternal <= 1)
		{
			return;
		}
		this.UseItemCountInternal--;
	}

	// Token: 0x17000E2A RID: 3626
	// (get) Token: 0x06007E6C RID: 32364 RVA: 0x0026F3CE File Offset: 0x0026D5CE
	public int UseItemCount
	{
		get
		{
			return this.UseItemCountInternal;
		}
	}

	// Token: 0x06007E6D RID: 32365 RVA: 0x0026F3D8 File Offset: 0x0026D5D8
	public int GetUseItemMaxCount()
	{
		InventoryModel instance = InventoryModel.Instance;
		int itemCountByConfigId = instance.GetItemCountByConfigId(this.UseItemConfigId, 0);
		int useCountLimit = instance.GetItemDataBaseByConfigId(this.UseItemConfigId)[0].GetUseCountLimit();
		if (useCountLimit > 0)
		{
			return Math.Min(itemCountByConfigId, useCountLimit);
		}
		return itemCountByConfigId;
	}

	// Token: 0x06007E6E RID: 32366 RVA: 0x0026F41C File Offset: 0x0026D61C
	public bool IsMaxItemCount()
	{
		return this.UseItemCountInternal >= this.GetUseItemMaxCount();
	}

	// Token: 0x06007E6F RID: 32367 RVA: 0x0026F42F File Offset: 0x0026D62F
	public bool IsMinItemCount()
	{
		return this.UseItemCountInternal <= 1;
	}

	// Token: 0x06007E70 RID: 32368 RVA: 0x0026F43D File Offset: 0x0026D63D
	public float GetPreviewAttribute()
	{
		return Math.Min(this.GetAddAttribute() + this.CurrentAttribute, this.MaxAttribute);
	}

	// Token: 0x06007E71 RID: 32369 RVA: 0x0026F458 File Offset: 0x0026D658
	public float GetPreviewAttributeNoLimit()
	{
		return this.GetAddAttribute() + this.CurrentAttribute;
	}

	// Token: 0x06007E72 RID: 32370 RVA: 0x0026F468 File Offset: 0x0026D668
	public float GetAddAttribute()
	{
		return (float)Math.Floor((this.GetBuffItemCureHealth(this.UseItemConfigId, this.Entity) * (double)this.UseItemCountInternal).Value);
	}

	// Token: 0x06007E73 RID: 32371 RVA: 0x0026F4C0 File Offset: 0x0026D6C0
	public int GetEntityId()
	{
		if (this.Entity == null)
		{
			return -1;
		}
		return this.Entity.Id;
	}

	// Token: 0x06007E74 RID: 32372 RVA: 0x0026F4D8 File Offset: 0x0026D6D8
	private double? GetBuffItemCureHealth(int itemConfigId, Entity entity)
	{
		Buff[] buffItemBuffConfig = BuffItemConfig.Instance.GetBuffItemBuffConfig(itemConfigId);
		if (buffItemBuffConfig == null)
		{
			return null;
		}
		double num = 0.0;
		foreach (Buff buffConfig in buffItemBuffConfig)
		{
			num += this.GetBuffCureHealth(buffConfig, entity);
		}
		return new double?(num);
	}

	// Token: 0x06007E75 RID: 32373 RVA: 0x0026F538 File Offset: 0x0026D738
	private unsafe double GetBuffCureHealth(Buff buffConfig, Entity entity)
	{
		double num = 0.0;
		BuffItemConfig instance = BuffItemConfig.Instance;
		string[] array = buffConfig.ExtraEffectParameters();
		int extraEffectID = buffConfig.ExtraEffectID;
		if (extraEffectID == 0)
		{
			foreach (long buffId in buffConfig.RoutineExpirationEffects())
			{
				num += this.GetBuffCureHealth(instance.GetBuffConfig(entity.Id, buffId).Value, entity);
			}
			return num;
		}
		if (extraEffectID == 4)
		{
			foreach (string text in array)
			{
				Damage? damageConfig = instance.GetDamageConfig(entity.Id, int.Parse(text));
				if (damageConfig == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.BuffItem;
					ELogAuthor author = ELogAuthor.YYZ;
					string message = "计算Buff道具治疗生命数值时，找不到结算表对应配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("结算表Id", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Buff配置", buffConfig);
					instance2.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					float attributeByRelatedProperty = this.GetAttributeByRelatedProperty(entity, damageConfig.Value.RelatedProperty);
					int num2 = damageConfig.Value.CureBaseValue()[0];
					int num3 = damageConfig.Value.RateLv()[0];
					int num4 = num3 / 10000;
					float num5 = (float)num2 + attributeByRelatedProperty * (float)num4;
					num += (double)num5;
				}
			}
			return num;
		}
		if (extraEffectID == 101)
		{
			if (array.Length < 2)
			{
				return num;
			}
			BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
			int num6 = int.Parse(array[0]) / 10000;
			float currentValue = component.GetCurrentValue(EAttributeType.LifeMax);
			num += (double)((float)num6 * currentValue + (float)int.Parse(array[1]));
		}
		return num;
	}

	// Token: 0x06007E76 RID: 32374 RVA: 0x0026F6F0 File Offset: 0x0026D8F0
	private float GetAttributeByRelatedProperty(Entity entity, int relatedProperty)
	{
		return entity.GetComponent<BaseAttributeComponent>().GetCurrentValue((EAttributeType)relatedProperty);
	}

	// Token: 0x04004E0E RID: 19982
	private const int TEN_THOUSANDTH_RATIO = 10000;

	// Token: 0x04004E0F RID: 19983
	public readonly string RoleName;

	// Token: 0x04004E10 RID: 19984
	public readonly int Position;

	// Token: 0x04004E11 RID: 19985
	public readonly int RoleConfigId;

	// Token: 0x04004E12 RID: 19986
	public float CurrentAttribute;

	// Token: 0x04004E13 RID: 19987
	public readonly float MaxAttribute;

	// Token: 0x04004E14 RID: 19988
	public readonly int UseItemConfigId;

	// Token: 0x04004E15 RID: 19989
	public readonly int RoleLevel;

	// Token: 0x04004E16 RID: 19990
	private int UseItemCountInternal;

	// Token: 0x04004E17 RID: 19991
	public readonly Entity Entity;
}
