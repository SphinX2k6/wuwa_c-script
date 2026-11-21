using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E8 RID: 16872
	public class IDarkTideBossEvent_UnionUnion
	{
		// Token: 0x170072F0 RID: 29424
		// (get) Token: 0x06017696 RID: 95894 RVA: 0x003589DC File Offset: 0x00356BDC
		// (set) Token: 0x06017697 RID: 95895 RVA: 0x003589E4 File Offset: 0x00356BE4
		public IDarkTideBossEvent_Union Type { get; set; }

		// Token: 0x170072F1 RID: 29425
		// (get) Token: 0x06017698 RID: 95896 RVA: 0x003589ED File Offset: 0x00356BED
		// (set) Token: 0x06017699 RID: 95897 RVA: 0x003589F5 File Offset: 0x00356BF5
		public object Value { get; set; }

		// Token: 0x0601769A RID: 95898 RVA: 0x003589FE File Offset: 0x00356BFE
		public IDarkTideBossEvent_UnionUnion()
		{
			this.Type = IDarkTideBossEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601769B RID: 95899 RVA: 0x00358A14 File Offset: 0x00356C14
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601769C RID: 95900 RVA: 0x00358A26 File Offset: 0x00356C26
		public IDarkTideBossEventT AsIDarkTideBossEvent()
		{
			return this.As<IDarkTideBossEventT>();
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x00358A2E File Offset: 0x00356C2E
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideBossEvent(IDarkTideBossEventT _idarktidebossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideBossEvent,
				Value = _idarktidebossevent
			};
		}

		// Token: 0x0601769E RID: 95902 RVA: 0x00358A43 File Offset: 0x00356C43
		public IDarkTideXinjilemuChaseBossEventT AsIDarkTideXinjilemuChaseBossEvent()
		{
			return this.As<IDarkTideXinjilemuChaseBossEventT>();
		}

		// Token: 0x0601769F RID: 95903 RVA: 0x00358A4B File Offset: 0x00356C4B
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideXinjilemuChaseBossEvent(IDarkTideXinjilemuChaseBossEventT _idarktidexinjilemuchasebossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideXinjilemuChaseBossEvent,
				Value = _idarktidexinjilemuchasebossevent
			};
		}

		// Token: 0x060176A0 RID: 95904 RVA: 0x00358A60 File Offset: 0x00356C60
		public IDarkTideHecatePollutionBossEventT AsIDarkTideHecatePollutionBossEvent()
		{
			return this.As<IDarkTideHecatePollutionBossEventT>();
		}

		// Token: 0x060176A1 RID: 95905 RVA: 0x00358A68 File Offset: 0x00356C68
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideHecatePollutionBossEvent(IDarkTideHecatePollutionBossEventT _idarktidehecatepollutionbossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideHecatePollutionBossEvent,
				Value = _idarktidehecatepollutionbossevent
			};
		}

		// Token: 0x060176A2 RID: 95906 RVA: 0x00358A7D File Offset: 0x00356C7D
		public IDarkTideHaiweixiaArenaBossEventT AsIDarkTideHaiweixiaArenaBossEvent()
		{
			return this.As<IDarkTideHaiweixiaArenaBossEventT>();
		}

		// Token: 0x060176A3 RID: 95907 RVA: 0x00358A85 File Offset: 0x00356C85
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideHaiweixiaArenaBossEvent(IDarkTideHaiweixiaArenaBossEventT _idarktidehaiweixiaarenabossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideHaiweixiaArenaBossEvent,
				Value = _idarktidehaiweixiaarenabossevent
			};
		}

		// Token: 0x060176A4 RID: 95908 RVA: 0x00358A9A File Offset: 0x00356C9A
		public IDarkTideWyvernPositionBossEventT AsIDarkTideWyvernPositionBossEvent()
		{
			return this.As<IDarkTideWyvernPositionBossEventT>();
		}

		// Token: 0x060176A5 RID: 95909 RVA: 0x00358AA2 File Offset: 0x00356CA2
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideWyvernPositionBossEvent(IDarkTideWyvernPositionBossEventT _idarktidewyvernpositionbossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideWyvernPositionBossEvent,
				Value = _idarktidewyvernpositionbossevent
			};
		}

		// Token: 0x060176A6 RID: 95910 RVA: 0x00358AB7 File Offset: 0x00356CB7
		public IDarkTideChonglouTrialBossEventT AsIDarkTideChonglouTrialBossEvent()
		{
			return this.As<IDarkTideChonglouTrialBossEventT>();
		}

		// Token: 0x060176A7 RID: 95911 RVA: 0x00358ABF File Offset: 0x00356CBF
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideChonglouTrialBossEvent(IDarkTideChonglouTrialBossEventT _idarktidechongloutrialbossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideChonglouTrialBossEvent,
				Value = _idarktidechongloutrialbossevent
			};
		}

		// Token: 0x060176A8 RID: 95912 RVA: 0x00358AD4 File Offset: 0x00356CD4
		public IDarkTideMechaAssemblyBossEventT AsIDarkTideMechaAssemblyBossEvent()
		{
			return this.As<IDarkTideMechaAssemblyBossEventT>();
		}

		// Token: 0x060176A9 RID: 95913 RVA: 0x00358ADC File Offset: 0x00356CDC
		public static IDarkTideBossEvent_UnionUnion FromIDarkTideMechaAssemblyBossEvent(IDarkTideMechaAssemblyBossEventT _idarktidemechaassemblybossevent)
		{
			return new IDarkTideBossEvent_UnionUnion
			{
				Type = IDarkTideBossEvent_Union.IDarkTideMechaAssemblyBossEvent,
				Value = _idarktidemechaassemblybossevent
			};
		}

		// Token: 0x060176AA RID: 95914 RVA: 0x00358AF4 File Offset: 0x00356CF4
		public static int Pack(FlatBufferBuilder builder, IDarkTideBossEvent_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDarkTideBossEvent_Union.IDarkTideBossEvent:
				return IDarkTideBossEvent.Pack(builder, _o.AsIDarkTideBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideXinjilemuChaseBossEvent:
				return IDarkTideXinjilemuChaseBossEvent.Pack(builder, _o.AsIDarkTideXinjilemuChaseBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideHecatePollutionBossEvent:
				return IDarkTideHecatePollutionBossEvent.Pack(builder, _o.AsIDarkTideHecatePollutionBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideHaiweixiaArenaBossEvent:
				return IDarkTideHaiweixiaArenaBossEvent.Pack(builder, _o.AsIDarkTideHaiweixiaArenaBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideWyvernPositionBossEvent:
				return IDarkTideWyvernPositionBossEvent.Pack(builder, _o.AsIDarkTideWyvernPositionBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideChonglouTrialBossEvent:
				return IDarkTideChonglouTrialBossEvent.Pack(builder, _o.AsIDarkTideChonglouTrialBossEvent()).Value;
			case IDarkTideBossEvent_Union.IDarkTideMechaAssemblyBossEvent:
				return IDarkTideMechaAssemblyBossEvent.Pack(builder, _o.AsIDarkTideMechaAssemblyBossEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
