using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004788 RID: 18312
	public class IEffectConfigBase_UnionUnion
	{
		// Token: 0x17008355 RID: 33621
		// (get) Token: 0x0601C323 RID: 115491 RVA: 0x003FE261 File Offset: 0x003FC461
		// (set) Token: 0x0601C324 RID: 115492 RVA: 0x003FE269 File Offset: 0x003FC469
		public IEffectConfigBase_Union Type { get; set; }

		// Token: 0x17008356 RID: 33622
		// (get) Token: 0x0601C325 RID: 115493 RVA: 0x003FE272 File Offset: 0x003FC472
		// (set) Token: 0x0601C326 RID: 115494 RVA: 0x003FE27A File Offset: 0x003FC47A
		public object Value { get; set; }

		// Token: 0x0601C327 RID: 115495 RVA: 0x003FE283 File Offset: 0x003FC483
		public IEffectConfigBase_UnionUnion()
		{
			this.Type = IEffectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C328 RID: 115496 RVA: 0x003FE299 File Offset: 0x003FC499
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C329 RID: 115497 RVA: 0x003FE2AB File Offset: 0x003FC4AB
		public IEffectConfigBaseT AsIEffectConfigBase()
		{
			return this.As<IEffectConfigBaseT>();
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x003FE2B3 File Offset: 0x003FC4B3
		public static IEffectConfigBase_UnionUnion FromIEffectConfigBase(IEffectConfigBaseT _ieffectconfigbase)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigBase,
				Value = _ieffectconfigbase
			};
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x003FE2C8 File Offset: 0x003FC4C8
		public IEffectConfigMonsterDeathT AsIEffectConfigMonsterDeath()
		{
			return this.As<IEffectConfigMonsterDeathT>();
		}

		// Token: 0x0601C32C RID: 115500 RVA: 0x003FE2D0 File Offset: 0x003FC4D0
		public static IEffectConfigBase_UnionUnion FromIEffectConfigMonsterDeath(IEffectConfigMonsterDeathT _ieffectconfigmonsterdeath)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigMonsterDeath,
				Value = _ieffectconfigmonsterdeath
			};
		}

		// Token: 0x0601C32D RID: 115501 RVA: 0x003FE2E5 File Offset: 0x003FC4E5
		public IEffectConfigMonsterDeathGroupT AsIEffectConfigMonsterDeathGroup()
		{
			return this.As<IEffectConfigMonsterDeathGroupT>();
		}

		// Token: 0x0601C32E RID: 115502 RVA: 0x003FE2ED File Offset: 0x003FC4ED
		public static IEffectConfigBase_UnionUnion FromIEffectConfigMonsterDeathGroup(IEffectConfigMonsterDeathGroupT _ieffectconfigmonsterdeathgroup)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigMonsterDeathGroup,
				Value = _ieffectconfigmonsterdeathgroup
			};
		}

		// Token: 0x0601C32F RID: 115503 RVA: 0x003FE304 File Offset: 0x003FC504
		public static int Pack(FlatBufferBuilder builder, IEffectConfigBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEffectConfigBase_Union.IEffectConfigBase:
				return IEffectConfigBase.Pack(builder, _o.AsIEffectConfigBase()).Value;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeath:
				return IEffectConfigMonsterDeath.Pack(builder, _o.AsIEffectConfigMonsterDeath()).Value;
			case IEffectConfigBase_Union.IEffectConfigMonsterDeathGroup:
				return IEffectConfigMonsterDeathGroup.Pack(builder, _o.AsIEffectConfigMonsterDeathGroup()).Value;
			default:
				return 0;
			}
		}
	}
}
