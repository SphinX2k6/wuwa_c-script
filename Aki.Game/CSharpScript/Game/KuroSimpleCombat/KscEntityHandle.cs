using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat
{
	// Token: 0x02006FB8 RID: 28600
	[NullableContext(2)]
	[Nullable(0)]
	public class KscEntityHandle
	{
		// Token: 0x06045806 RID: 284678 RVA: 0x0113DEF5 File Offset: 0x0113C0F5
		public KscEntityHandle(AKSC_Entity kscEntity, long creatureDataId = 0L)
		{
			this.KscEntity = kscEntity;
			this.CreatureDataId = creatureDataId;
		}

		// Token: 0x17009B7C RID: 39804
		// (get) Token: 0x06045807 RID: 284679 RVA: 0x0113DF16 File Offset: 0x0113C116
		public bool Valid
		{
			get
			{
				AKSC_Entity kscEntity = this.KscEntity;
				return kscEntity != null && kscEntity.IsValid();
			}
		}

		// Token: 0x06045808 RID: 284680 RVA: 0x0113DF29 File Offset: 0x0113C129
		[NullableContext(1)]
		public void SetKscEntity(AKSC_Entity kscEntity)
		{
			this.KscEntity = kscEntity;
		}

		// Token: 0x06045809 RID: 284681 RVA: 0x0113DF32 File Offset: 0x0113C132
		public void SetCreatureDataId(int creatureDataId)
		{
			this.CreatureDataId = (long)creatureDataId;
		}

		// Token: 0x0604580A RID: 284682 RVA: 0x0113DF3C File Offset: 0x0113C13C
		public void SetAttr(EKSC_AttrType attrType, int attrValue)
		{
			this.ServerAttributeMap[attrType] = attrValue;
		}

		// Token: 0x0604580B RID: 284683 RVA: 0x0113DF4C File Offset: 0x0113C14C
		public unsafe void ApplyAttrDelta(Dictionary<int, int> newAttributes)
		{
			if (this.KscEntity == null || newAttributes == null || newAttributes.Count == 0)
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair in newAttributes)
			{
				EKSC_AttrType eksc_AttrType = (EKSC_AttrType)keyValuePair.Key;
				int value = keyValuePair.Value;
				if (eksc_AttrType != EKSC_AttrType.Life)
				{
					int num2;
					int num = this.ServerAttributeMap.TryGetValue(eksc_AttrType, out num2) ? num2 : 0;
					if (num != value)
					{
						this.ServerAttributeMap[eksc_AttrType] = value;
						int num3 = value - num;
						this.KscEntity.AddAttr(eksc_AttrType, num3);
						if (eksc_AttrType == EKSC_AttrType.LifeMax)
						{
							UKSC_SkillComp skillComp = this.KscEntity.GetSkillComp();
							TMap<EKSC_AttrType, int> tmap;
							if (skillComp == null)
							{
								tmap = null;
							}
							else
							{
								UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
								tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
							}
							TMap<EKSC_AttrType, int> tmap2 = tmap;
							if (tmap2 != null)
							{
								int valueOrDefault = tmap2.GetValueOrDefault(EKSC_AttrType.LifeMax, 0);
								int valueOrDefault2 = tmap2.GetValueOrDefault(EKSC_AttrType.Life, 0);
								int value2 = (num3 > 0) ? Math.Min(valueOrDefault, valueOrDefault2 + num3) : Math.Min(valueOrDefault, valueOrDefault2);
								this.KscEntity.SetAttr(EKSC_AttrType.Life, value2);
							}
							else
							{
								KscLog.EModule flag = KscLog.EModule.Attr;
								ELogAuthor author = ELogAuthor.HCW;
								UObject kscWorld = KscEnv.Instance.KscWorld;
								string log = "最大生命值没有下发";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", this.KscEntity.EntityId_);
								ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
								string item = "EntityFaction";
								UKSC_DA_Entity daEntity_ = this.KscEntity.DaEntity_;
								ptr = new ValueTuple<string, object>(item, (daEntity_ != null) ? daEntity_.Default_Faction : EKSC_Faction.Faction0);
								KscLog.Error(flag, author, kscWorld, log, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
						}
					}
				}
			}
		}

		// Token: 0x0604580C RID: 284684 RVA: 0x0113E110 File Offset: 0x0113C310
		private bool ShouldSync()
		{
			if (this.CreatureDataId == 0L)
			{
				return false;
			}
			CreatureModel instance = CreatureModel.Instance;
			EntityHandle entityHandle = (instance != null) ? instance.GetEntity(this.CreatureDataId) : null;
			if (entityHandle == null || entityHandle.Entity == null || !this.Valid)
			{
				return false;
			}
			BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
			AActor aactor = (component != null) ? component.Owner : null;
			FTransformDouble? ftransformDouble = (aactor != null) ? new FTransformDouble?(aactor.D_GetTransform()) : null;
			return ftransformDouble != null;
		}

		// Token: 0x0604580D RID: 284685 RVA: 0x0113E194 File Offset: 0x0113C394
		public void SyncEntityLocation()
		{
			if (!this.ShouldSync())
			{
				return;
			}
			FTransformDouble ftransformDouble = CreatureModel.Instance.GetEntity(this.CreatureDataId).Entity.GetComponent<BaseActorComponent>().Owner.D_GetTransform();
			this.KscEntity.SetTransformByWorld(ftransformDouble);
		}

		// Token: 0x04024441 RID: 148545
		public AKSC_Entity KscEntity;

		// Token: 0x04024442 RID: 148546
		public long CreatureDataId;

		// Token: 0x04024443 RID: 148547
		[Nullable(1)]
		private readonly Dictionary<EKSC_AttrType, int> ServerAttributeMap = new Dictionary<EKSC_AttrType, int>();
	}
}
