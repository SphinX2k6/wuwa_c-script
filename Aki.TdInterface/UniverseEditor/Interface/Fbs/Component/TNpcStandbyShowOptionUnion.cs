using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C79 RID: 23673
	public class TNpcStandbyShowOptionUnion
	{
		// Token: 0x1700B22E RID: 45614
		// (get) Token: 0x060288E5 RID: 166117 RVA: 0x0059390E File Offset: 0x00591B0E
		// (set) Token: 0x060288E6 RID: 166118 RVA: 0x00593916 File Offset: 0x00591B16
		public TNpcStandbyShowOption Type { get; set; }

		// Token: 0x1700B22F RID: 45615
		// (get) Token: 0x060288E7 RID: 166119 RVA: 0x0059391F File Offset: 0x00591B1F
		// (set) Token: 0x060288E8 RID: 166120 RVA: 0x00593927 File Offset: 0x00591B27
		public object Value { get; set; }

		// Token: 0x060288E9 RID: 166121 RVA: 0x00593930 File Offset: 0x00591B30
		public TNpcStandbyShowOptionUnion()
		{
			this.Type = TNpcStandbyShowOption.NONE;
			this.Value = null;
		}

		// Token: 0x060288EA RID: 166122 RVA: 0x00593946 File Offset: 0x00591B46
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060288EB RID: 166123 RVA: 0x00593958 File Offset: 0x00591B58
		public INpcStandbyShowFinitelyT AsINpcStandbyShowFinitely()
		{
			return this.As<INpcStandbyShowFinitelyT>();
		}

		// Token: 0x060288EC RID: 166124 RVA: 0x00593960 File Offset: 0x00591B60
		public static TNpcStandbyShowOptionUnion FromINpcStandbyShowFinitely(INpcStandbyShowFinitelyT _inpcstandbyshowfinitely)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbyShowFinitely,
				Value = _inpcstandbyshowfinitely
			};
		}

		// Token: 0x060288ED RID: 166125 RVA: 0x00593975 File Offset: 0x00591B75
		public INpcStandbyShowLooplyT AsINpcStandbyShowLooply()
		{
			return this.As<INpcStandbyShowLooplyT>();
		}

		// Token: 0x060288EE RID: 166126 RVA: 0x0059397D File Offset: 0x00591B7D
		public static TNpcStandbyShowOptionUnion FromINpcStandbyShowLooply(INpcStandbyShowLooplyT _inpcstandbyshowlooply)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbyShowLooply,
				Value = _inpcstandbyshowlooply
			};
		}

		// Token: 0x060288EF RID: 166127 RVA: 0x00593992 File Offset: 0x00591B92
		public INpcStandbySitT AsINpcStandbySit()
		{
			return this.As<INpcStandbySitT>();
		}

		// Token: 0x060288F0 RID: 166128 RVA: 0x0059399A File Offset: 0x00591B9A
		public static TNpcStandbyShowOptionUnion FromINpcStandbySit(INpcStandbySitT _inpcstandbysit)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbySit,
				Value = _inpcstandbysit
			};
		}

		// Token: 0x060288F1 RID: 166129 RVA: 0x005939B0 File Offset: 0x00591BB0
		public static int Pack(FlatBufferBuilder builder, TNpcStandbyShowOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TNpcStandbyShowOption.INpcStandbyShowFinitely:
				return INpcStandbyShowFinitely.Pack(builder, _o.AsINpcStandbyShowFinitely()).Value;
			case TNpcStandbyShowOption.INpcStandbyShowLooply:
				return INpcStandbyShowLooply.Pack(builder, _o.AsINpcStandbyShowLooply()).Value;
			case TNpcStandbyShowOption.INpcStandbySit:
				return INpcStandbySit.Pack(builder, _o.AsINpcStandbySit()).Value;
			default:
				return 0;
			}
		}
	}
}
