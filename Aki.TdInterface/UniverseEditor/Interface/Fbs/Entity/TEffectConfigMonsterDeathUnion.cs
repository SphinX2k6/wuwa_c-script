using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C62 RID: 19554
	public class TEffectConfigMonsterDeathUnion
	{
		// Token: 0x17008AB3 RID: 35507
		// (get) Token: 0x0601DFFC RID: 122876 RVA: 0x00434A24 File Offset: 0x00432C24
		// (set) Token: 0x0601DFFD RID: 122877 RVA: 0x00434A2C File Offset: 0x00432C2C
		public TEffectConfigMonsterDeath Type { get; set; }

		// Token: 0x17008AB4 RID: 35508
		// (get) Token: 0x0601DFFE RID: 122878 RVA: 0x00434A35 File Offset: 0x00432C35
		// (set) Token: 0x0601DFFF RID: 122879 RVA: 0x00434A3D File Offset: 0x00432C3D
		public object Value { get; set; }

		// Token: 0x0601E000 RID: 122880 RVA: 0x00434A46 File Offset: 0x00432C46
		public TEffectConfigMonsterDeathUnion()
		{
			this.Type = TEffectConfigMonsterDeath.NONE;
			this.Value = null;
		}

		// Token: 0x0601E001 RID: 122881 RVA: 0x00434A5C File Offset: 0x00432C5C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E002 RID: 122882 RVA: 0x00434A6E File Offset: 0x00432C6E
		public IEffectConfigMonsterDeathT AsIEffectConfigMonsterDeath()
		{
			return this.As<IEffectConfigMonsterDeathT>();
		}

		// Token: 0x0601E003 RID: 122883 RVA: 0x00434A76 File Offset: 0x00432C76
		public static TEffectConfigMonsterDeathUnion FromIEffectConfigMonsterDeath(IEffectConfigMonsterDeathT _ieffectconfigmonsterdeath)
		{
			return new TEffectConfigMonsterDeathUnion
			{
				Type = TEffectConfigMonsterDeath.IEffectConfigMonsterDeath,
				Value = _ieffectconfigmonsterdeath
			};
		}

		// Token: 0x0601E004 RID: 122884 RVA: 0x00434A8B File Offset: 0x00432C8B
		public IEffectConfigMonsterDeathGroupT AsIEffectConfigMonsterDeathGroup()
		{
			return this.As<IEffectConfigMonsterDeathGroupT>();
		}

		// Token: 0x0601E005 RID: 122885 RVA: 0x00434A93 File Offset: 0x00432C93
		public static TEffectConfigMonsterDeathUnion FromIEffectConfigMonsterDeathGroup(IEffectConfigMonsterDeathGroupT _ieffectconfigmonsterdeathgroup)
		{
			return new TEffectConfigMonsterDeathUnion
			{
				Type = TEffectConfigMonsterDeath.IEffectConfigMonsterDeathGroup,
				Value = _ieffectconfigmonsterdeathgroup
			};
		}

		// Token: 0x0601E006 RID: 122886 RVA: 0x00434AA8 File Offset: 0x00432CA8
		public static int Pack(FlatBufferBuilder builder, TEffectConfigMonsterDeathUnion _o)
		{
			TEffectConfigMonsterDeath type = _o.Type;
			if (type == TEffectConfigMonsterDeath.IEffectConfigMonsterDeath)
			{
				return IEffectConfigMonsterDeath.Pack(builder, _o.AsIEffectConfigMonsterDeath()).Value;
			}
			if (type != TEffectConfigMonsterDeath.IEffectConfigMonsterDeathGroup)
			{
				return 0;
			}
			return IEffectConfigMonsterDeathGroup.Pack(builder, _o.AsIEffectConfigMonsterDeathGroup()).Value;
		}
	}
}
