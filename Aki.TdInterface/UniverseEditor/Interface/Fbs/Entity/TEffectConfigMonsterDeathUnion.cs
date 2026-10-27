using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047FA RID: 18426
	public class TEffectConfigMonsterDeathUnion
	{
		// Token: 0x17008468 RID: 33896
		// (get) Token: 0x0601C7FF RID: 116735 RVA: 0x004080D4 File Offset: 0x004062D4
		// (set) Token: 0x0601C800 RID: 116736 RVA: 0x004080DC File Offset: 0x004062DC
		public TEffectConfigMonsterDeath Type { get; set; }

		// Token: 0x17008469 RID: 33897
		// (get) Token: 0x0601C801 RID: 116737 RVA: 0x004080E5 File Offset: 0x004062E5
		// (set) Token: 0x0601C802 RID: 116738 RVA: 0x004080ED File Offset: 0x004062ED
		public object Value { get; set; }

		// Token: 0x0601C803 RID: 116739 RVA: 0x004080F6 File Offset: 0x004062F6
		public TEffectConfigMonsterDeathUnion()
		{
			this.Type = TEffectConfigMonsterDeath.NONE;
			this.Value = null;
		}

		// Token: 0x0601C804 RID: 116740 RVA: 0x0040810C File Offset: 0x0040630C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C805 RID: 116741 RVA: 0x0040811E File Offset: 0x0040631E
		public IEffectConfigMonsterDeathT AsIEffectConfigMonsterDeath()
		{
			return this.As<IEffectConfigMonsterDeathT>();
		}

		// Token: 0x0601C806 RID: 116742 RVA: 0x00408126 File Offset: 0x00406326
		public static TEffectConfigMonsterDeathUnion FromIEffectConfigMonsterDeath(IEffectConfigMonsterDeathT _ieffectconfigmonsterdeath)
		{
			return new TEffectConfigMonsterDeathUnion
			{
				Type = TEffectConfigMonsterDeath.IEffectConfigMonsterDeath,
				Value = _ieffectconfigmonsterdeath
			};
		}

		// Token: 0x0601C807 RID: 116743 RVA: 0x0040813B File Offset: 0x0040633B
		public IEffectConfigMonsterDeathGroupT AsIEffectConfigMonsterDeathGroup()
		{
			return this.As<IEffectConfigMonsterDeathGroupT>();
		}

		// Token: 0x0601C808 RID: 116744 RVA: 0x00408143 File Offset: 0x00406343
		public static TEffectConfigMonsterDeathUnion FromIEffectConfigMonsterDeathGroup(IEffectConfigMonsterDeathGroupT _ieffectconfigmonsterdeathgroup)
		{
			return new TEffectConfigMonsterDeathUnion
			{
				Type = TEffectConfigMonsterDeath.IEffectConfigMonsterDeathGroup,
				Value = _ieffectconfigmonsterdeathgroup
			};
		}

		// Token: 0x0601C809 RID: 116745 RVA: 0x00408158 File Offset: 0x00406358
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
