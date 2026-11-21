using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004726 RID: 18214
	public class TDarkTideBossEventUnion
	{
		// Token: 0x17007F6F RID: 32623
		// (get) Token: 0x0601AD2D RID: 109869 RVA: 0x003CF00C File Offset: 0x003CD20C
		// (set) Token: 0x0601AD2E RID: 109870 RVA: 0x003CF014 File Offset: 0x003CD214
		public TDarkTideBossEvent Type { get; set; }

		// Token: 0x17007F70 RID: 32624
		// (get) Token: 0x0601AD2F RID: 109871 RVA: 0x003CF01D File Offset: 0x003CD21D
		// (set) Token: 0x0601AD30 RID: 109872 RVA: 0x003CF025 File Offset: 0x003CD225
		public object Value { get; set; }

		// Token: 0x0601AD31 RID: 109873 RVA: 0x003CF02E File Offset: 0x003CD22E
		public TDarkTideBossEventUnion()
		{
			this.Type = TDarkTideBossEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD32 RID: 109874 RVA: 0x003CF044 File Offset: 0x003CD244
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD33 RID: 109875 RVA: 0x003CF056 File Offset: 0x003CD256
		public IDarkTideChonglouTrialBossEventT AsIDarkTideChonglouTrialBossEvent()
		{
			return this.As<IDarkTideChonglouTrialBossEventT>();
		}

		// Token: 0x0601AD34 RID: 109876 RVA: 0x003CF05E File Offset: 0x003CD25E
		public static TDarkTideBossEventUnion FromIDarkTideChonglouTrialBossEvent(IDarkTideChonglouTrialBossEventT _idarktidechongloutrialbossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideChonglouTrialBossEvent,
				Value = _idarktidechongloutrialbossevent
			};
		}

		// Token: 0x0601AD35 RID: 109877 RVA: 0x003CF073 File Offset: 0x003CD273
		public IDarkTideHaiweixiaArenaBossEventT AsIDarkTideHaiweixiaArenaBossEvent()
		{
			return this.As<IDarkTideHaiweixiaArenaBossEventT>();
		}

		// Token: 0x0601AD36 RID: 109878 RVA: 0x003CF07B File Offset: 0x003CD27B
		public static TDarkTideBossEventUnion FromIDarkTideHaiweixiaArenaBossEvent(IDarkTideHaiweixiaArenaBossEventT _idarktidehaiweixiaarenabossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideHaiweixiaArenaBossEvent,
				Value = _idarktidehaiweixiaarenabossevent
			};
		}

		// Token: 0x0601AD37 RID: 109879 RVA: 0x003CF090 File Offset: 0x003CD290
		public IDarkTideHecatePollutionBossEventT AsIDarkTideHecatePollutionBossEvent()
		{
			return this.As<IDarkTideHecatePollutionBossEventT>();
		}

		// Token: 0x0601AD38 RID: 109880 RVA: 0x003CF098 File Offset: 0x003CD298
		public static TDarkTideBossEventUnion FromIDarkTideHecatePollutionBossEvent(IDarkTideHecatePollutionBossEventT _idarktidehecatepollutionbossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideHecatePollutionBossEvent,
				Value = _idarktidehecatepollutionbossevent
			};
		}

		// Token: 0x0601AD39 RID: 109881 RVA: 0x003CF0AD File Offset: 0x003CD2AD
		public IDarkTideMechaAssemblyBossEventT AsIDarkTideMechaAssemblyBossEvent()
		{
			return this.As<IDarkTideMechaAssemblyBossEventT>();
		}

		// Token: 0x0601AD3A RID: 109882 RVA: 0x003CF0B5 File Offset: 0x003CD2B5
		public static TDarkTideBossEventUnion FromIDarkTideMechaAssemblyBossEvent(IDarkTideMechaAssemblyBossEventT _idarktidemechaassemblybossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideMechaAssemblyBossEvent,
				Value = _idarktidemechaassemblybossevent
			};
		}

		// Token: 0x0601AD3B RID: 109883 RVA: 0x003CF0CA File Offset: 0x003CD2CA
		public IDarkTideWyvernPositionBossEventT AsIDarkTideWyvernPositionBossEvent()
		{
			return this.As<IDarkTideWyvernPositionBossEventT>();
		}

		// Token: 0x0601AD3C RID: 109884 RVA: 0x003CF0D2 File Offset: 0x003CD2D2
		public static TDarkTideBossEventUnion FromIDarkTideWyvernPositionBossEvent(IDarkTideWyvernPositionBossEventT _idarktidewyvernpositionbossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideWyvernPositionBossEvent,
				Value = _idarktidewyvernpositionbossevent
			};
		}

		// Token: 0x0601AD3D RID: 109885 RVA: 0x003CF0E7 File Offset: 0x003CD2E7
		public IDarkTideXinjilemuChaseBossEventT AsIDarkTideXinjilemuChaseBossEvent()
		{
			return this.As<IDarkTideXinjilemuChaseBossEventT>();
		}

		// Token: 0x0601AD3E RID: 109886 RVA: 0x003CF0EF File Offset: 0x003CD2EF
		public static TDarkTideBossEventUnion FromIDarkTideXinjilemuChaseBossEvent(IDarkTideXinjilemuChaseBossEventT _idarktidexinjilemuchasebossevent)
		{
			return new TDarkTideBossEventUnion
			{
				Type = TDarkTideBossEvent.IDarkTideXinjilemuChaseBossEvent,
				Value = _idarktidexinjilemuchasebossevent
			};
		}

		// Token: 0x0601AD3F RID: 109887 RVA: 0x003CF104 File Offset: 0x003CD304
		public static int Pack(FlatBufferBuilder builder, TDarkTideBossEventUnion _o)
		{
			switch (_o.Type)
			{
			case TDarkTideBossEvent.IDarkTideChonglouTrialBossEvent:
				return IDarkTideChonglouTrialBossEvent.Pack(builder, _o.AsIDarkTideChonglouTrialBossEvent()).Value;
			case TDarkTideBossEvent.IDarkTideHaiweixiaArenaBossEvent:
				return IDarkTideHaiweixiaArenaBossEvent.Pack(builder, _o.AsIDarkTideHaiweixiaArenaBossEvent()).Value;
			case TDarkTideBossEvent.IDarkTideHecatePollutionBossEvent:
				return IDarkTideHecatePollutionBossEvent.Pack(builder, _o.AsIDarkTideHecatePollutionBossEvent()).Value;
			case TDarkTideBossEvent.IDarkTideMechaAssemblyBossEvent:
				return IDarkTideMechaAssemblyBossEvent.Pack(builder, _o.AsIDarkTideMechaAssemblyBossEvent()).Value;
			case TDarkTideBossEvent.IDarkTideWyvernPositionBossEvent:
				return IDarkTideWyvernPositionBossEvent.Pack(builder, _o.AsIDarkTideWyvernPositionBossEvent()).Value;
			case TDarkTideBossEvent.IDarkTideXinjilemuChaseBossEvent:
				return IDarkTideXinjilemuChaseBossEvent.Pack(builder, _o.AsIDarkTideXinjilemuChaseBossEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
