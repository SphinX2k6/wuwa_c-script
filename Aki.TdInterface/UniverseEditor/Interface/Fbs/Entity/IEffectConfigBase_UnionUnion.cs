using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BF0 RID: 19440
	public class IEffectConfigBase_UnionUnion
	{
		// Token: 0x17008996 RID: 35222
		// (get) Token: 0x0601DAF8 RID: 121592 RVA: 0x0042A4FD File Offset: 0x004286FD
		// (set) Token: 0x0601DAF9 RID: 121593 RVA: 0x0042A505 File Offset: 0x00428705
		public IEffectConfigBase_Union Type { get; set; }

		// Token: 0x17008997 RID: 35223
		// (get) Token: 0x0601DAFA RID: 121594 RVA: 0x0042A50E File Offset: 0x0042870E
		// (set) Token: 0x0601DAFB RID: 121595 RVA: 0x0042A516 File Offset: 0x00428716
		public object Value { get; set; }

		// Token: 0x0601DAFC RID: 121596 RVA: 0x0042A51F File Offset: 0x0042871F
		public IEffectConfigBase_UnionUnion()
		{
			this.Type = IEffectConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601DAFD RID: 121597 RVA: 0x0042A535 File Offset: 0x00428735
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601DAFE RID: 121598 RVA: 0x0042A547 File Offset: 0x00428747
		public IEffectConfigBaseT AsIEffectConfigBase()
		{
			return this.As<IEffectConfigBaseT>();
		}

		// Token: 0x0601DAFF RID: 121599 RVA: 0x0042A54F File Offset: 0x0042874F
		public static IEffectConfigBase_UnionUnion FromIEffectConfigBase(IEffectConfigBaseT _ieffectconfigbase)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigBase,
				Value = _ieffectconfigbase
			};
		}

		// Token: 0x0601DB00 RID: 121600 RVA: 0x0042A564 File Offset: 0x00428764
		public IEffectConfigMonsterDeathT AsIEffectConfigMonsterDeath()
		{
			return this.As<IEffectConfigMonsterDeathT>();
		}

		// Token: 0x0601DB01 RID: 121601 RVA: 0x0042A56C File Offset: 0x0042876C
		public static IEffectConfigBase_UnionUnion FromIEffectConfigMonsterDeath(IEffectConfigMonsterDeathT _ieffectconfigmonsterdeath)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigMonsterDeath,
				Value = _ieffectconfigmonsterdeath
			};
		}

		// Token: 0x0601DB02 RID: 121602 RVA: 0x0042A581 File Offset: 0x00428781
		public IEffectConfigMonsterDeathGroupT AsIEffectConfigMonsterDeathGroup()
		{
			return this.As<IEffectConfigMonsterDeathGroupT>();
		}

		// Token: 0x0601DB03 RID: 121603 RVA: 0x0042A589 File Offset: 0x00428789
		public static IEffectConfigBase_UnionUnion FromIEffectConfigMonsterDeathGroup(IEffectConfigMonsterDeathGroupT _ieffectconfigmonsterdeathgroup)
		{
			return new IEffectConfigBase_UnionUnion
			{
				Type = IEffectConfigBase_Union.IEffectConfigMonsterDeathGroup,
				Value = _ieffectconfigmonsterdeathgroup
			};
		}

		// Token: 0x0601DB04 RID: 121604 RVA: 0x0042A5A0 File Offset: 0x004287A0
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
