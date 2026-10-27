using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001719 RID: 5913
[NullableContext(1)]
[Nullable(0)]
public class UseBuffItemRoleData
{
	// Token: 0x0600AA84 RID: 43652 RVA: 0x00264DD8 File Offset: 0x00262FD8
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

	// Token: 0x0600AA85 RID: 43653 RVA: 0x00264E28 File Offset: 0x00263028
	public void SetCurrentAttribute(float currentAttribute)
	{
		this.CurrentAttribute = currentAttribute;
	}

	// Token: 0x0600AA86 RID: 43654 RVA: 0x00264E31 File Offset: 0x00263031
	public void SetUseItemCount(int useItemCount)
	{
		this.UseItemCountInternal = useItemCount;
	}

	// Token: 0x0600AA87 RID: 43655 RVA: 0x00264E3A File Offset: 0x0026303A
	public void AddUseItemCount()
	{
		if (InventoryModel.Instance.GetItemCountByConfigId(this.UseItemConfigId, 0) <= this.UseItemCountInternal)
		{
			return;
		}
		this.UseItemCountInternal++;
	}

	// Token: 0x0600AA88 RID: 43656 RVA: 0x00264E64 File Offset: 0x00263064
	public void ReduceUseItemCount()
	{
		if (this.UseItemCountInternal <= 1)
		{
			return;
		}
		this.UseItemCountInternal--;
	}

	// Token: 0x17000E09 RID: 3593
	// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x00264E7E File Offset: 0x0026307E
	public int UseItemCount
	{
		get
		{
			return this.UseItemCountInternal;
		}
	}

	// Token: 0x0600AA8A RID: 43658 RVA: 0x00264E88 File Offset: 0x00263088
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

	// Token: 0x0600AA8B RID: 43659 RVA: 0x00264ECC File Offset: 0x002630CC
	public bool IsMaxItemCount()
	{
		return this.UseItemCountInternal >= this.GetUseItemMaxCount();
	}

	// Token: 0x0600AA8C RID: 43660 RVA: 0x00264EDF File Offset: 0x002630DF
	public bool IsMinItemCount()
	{
		return this.UseItemCountInternal <= 1;
	}

	// Token: 0x0600AA8D RID: 43661 RVA: 0x00264EED File Offset: 0x002630ED
	public float GetPreviewAttribute()
	{
		return Math.Min(this.GetAddAttribute() + this.CurrentAttribute, this.MaxAttribute);
	}

	// Token: 0x0600AA8E RID: 43662 RVA: 0x00264F08 File Offset: 0x00263108
	public float GetPreviewAttributeNoLimit()
	{
		return this.GetAddAttribute() + this.CurrentAttribute;
	}

	// Token: 0x0600AA8F RID: 43663 RVA: 0x00264F18 File Offset: 0x00263118
	public float GetAddAttribute()
	{
		return (float)Math.Floor((this.GetBuffItemCureHealth(this.UseItemConfigId, this.Entity) * (double)this.UseItemCountInternal).Value);
	}

	// Token: 0x0600AA90 RID: 43664 RVA: 0x00264F70 File Offset: 0x00263170
	public int GetEntityId()
	{
		if (this.Entity == null)
		{
			return -1;
		}
		return this.Entity.Id;
	}

	// Token: 0x0600AA91 RID: 43665 RVA: 0x00264F88 File Offset: 0x00263188
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

	// Token: 0x0600AA92 RID: 43666 RVA: 0x00264FE8 File Offset: 0x002631E8
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

	// Token: 0x0600AA93 RID: 43667 RVA: 0x002651A0 File Offset: 0x002633A0
	private float GetAttributeByRelatedProperty(Entity entity, int relatedProperty)
	{
		return entity.GetComponent<BaseAttributeComponent>().GetCurrentValue((EAttributeType)relatedProperty);
	}

	// Token: 0x04004D66 RID: 19814
	private const int TEN_THOUSANDTH_RATIO = 10000;

	// Token: 0x04004D67 RID: 19815
	public readonly string RoleName;

	// Token: 0x04004D68 RID: 19816
	public readonly int Position;

	// Token: 0x04004D69 RID: 19817
	public readonly int RoleConfigId;

	// Token: 0x04004D6A RID: 19818
	public float CurrentAttribute;

	// Token: 0x04004D6B RID: 19819
	public readonly float MaxAttribute;

	// Token: 0x04004D6C RID: 19820
	public readonly int UseItemConfigId;

	// Token: 0x04004D6D RID: 19821
	public readonly int RoleLevel;

	// Token: 0x04004D6E RID: 19822
	private int UseItemCountInternal;

	// Token: 0x04004D6F RID: 19823
	public readonly Entity Entity;
}
