using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005666 RID: 22118
	public class INpcStandbyShowMode_UnionUnion
	{
		// Token: 0x1700A3E2 RID: 41954
		// (get) Token: 0x06024C95 RID: 150677 RVA: 0x00513637 File Offset: 0x00511837
		// (set) Token: 0x06024C96 RID: 150678 RVA: 0x0051363F File Offset: 0x0051183F
		public INpcStandbyShowMode_Union Type { get; set; }

		// Token: 0x1700A3E3 RID: 41955
		// (get) Token: 0x06024C97 RID: 150679 RVA: 0x00513648 File Offset: 0x00511848
		// (set) Token: 0x06024C98 RID: 150680 RVA: 0x00513650 File Offset: 0x00511850
		public object Value { get; set; }

		// Token: 0x06024C99 RID: 150681 RVA: 0x00513659 File Offset: 0x00511859
		public INpcStandbyShowMode_UnionUnion()
		{
			this.Type = INpcStandbyShowMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024C9A RID: 150682 RVA: 0x0051366F File Offset: 0x0051186F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024C9B RID: 150683 RVA: 0x00513681 File Offset: 0x00511881
		public INpcStandbyShowModeT AsINpcStandbyShowMode()
		{
			return this.As<INpcStandbyShowModeT>();
		}

		// Token: 0x06024C9C RID: 150684 RVA: 0x00513689 File Offset: 0x00511889
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowMode(INpcStandbyShowModeT _inpcstandbyshowmode)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowMode,
				Value = _inpcstandbyshowmode
			};
		}

		// Token: 0x06024C9D RID: 150685 RVA: 0x0051369E File Offset: 0x0051189E
		public INpcStandbyShowFinitelyT AsINpcStandbyShowFinitely()
		{
			return this.As<INpcStandbyShowFinitelyT>();
		}

		// Token: 0x06024C9E RID: 150686 RVA: 0x005136A6 File Offset: 0x005118A6
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowFinitely(INpcStandbyShowFinitelyT _inpcstandbyshowfinitely)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowFinitely,
				Value = _inpcstandbyshowfinitely
			};
		}

		// Token: 0x06024C9F RID: 150687 RVA: 0x005136BB File Offset: 0x005118BB
		public INpcStandbyShowLooplyT AsINpcStandbyShowLooply()
		{
			return this.As<INpcStandbyShowLooplyT>();
		}

		// Token: 0x06024CA0 RID: 150688 RVA: 0x005136C3 File Offset: 0x005118C3
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowLooply(INpcStandbyShowLooplyT _inpcstandbyshowlooply)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowLooply,
				Value = _inpcstandbyshowlooply
			};
		}

		// Token: 0x06024CA1 RID: 150689 RVA: 0x005136D8 File Offset: 0x005118D8
		public INpcStandbySitT AsINpcStandbySit()
		{
			return this.As<INpcStandbySitT>();
		}

		// Token: 0x06024CA2 RID: 150690 RVA: 0x005136E0 File Offset: 0x005118E0
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbySit(INpcStandbySitT _inpcstandbysit)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbySit,
				Value = _inpcstandbysit
			};
		}

		// Token: 0x06024CA3 RID: 150691 RVA: 0x005136F8 File Offset: 0x005118F8
		public static int Pack(FlatBufferBuilder builder, INpcStandbyShowMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcStandbyShowMode_Union.INpcStandbyShowMode:
				return INpcStandbyShowMode.Pack(builder, _o.AsINpcStandbyShowMode()).Value;
			case INpcStandbyShowMode_Union.INpcStandbyShowFinitely:
				return INpcStandbyShowFinitely.Pack(builder, _o.AsINpcStandbyShowFinitely()).Value;
			case INpcStandbyShowMode_Union.INpcStandbyShowLooply:
				return INpcStandbyShowLooply.Pack(builder, _o.AsINpcStandbyShowLooply()).Value;
			case INpcStandbyShowMode_Union.INpcStandbySit:
				return INpcStandbySit.Pack(builder, _o.AsINpcStandbySit()).Value;
			default:
				return 0;
			}
		}
	}
}
