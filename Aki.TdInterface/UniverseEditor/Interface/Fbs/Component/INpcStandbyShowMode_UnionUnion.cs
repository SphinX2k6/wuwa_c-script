using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C07 RID: 23559
	public class INpcStandbyShowMode_UnionUnion
	{
		// Token: 0x1700AC71 RID: 44145
		// (get) Token: 0x06026ECE RID: 159438 RVA: 0x005541D3 File Offset: 0x005523D3
		// (set) Token: 0x06026ECF RID: 159439 RVA: 0x005541DB File Offset: 0x005523DB
		public INpcStandbyShowMode_Union Type { get; set; }

		// Token: 0x1700AC72 RID: 44146
		// (get) Token: 0x06026ED0 RID: 159440 RVA: 0x005541E4 File Offset: 0x005523E4
		// (set) Token: 0x06026ED1 RID: 159441 RVA: 0x005541EC File Offset: 0x005523EC
		public object Value { get; set; }

		// Token: 0x06026ED2 RID: 159442 RVA: 0x005541F5 File Offset: 0x005523F5
		public INpcStandbyShowMode_UnionUnion()
		{
			this.Type = INpcStandbyShowMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026ED3 RID: 159443 RVA: 0x0055420B File Offset: 0x0055240B
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026ED4 RID: 159444 RVA: 0x0055421D File Offset: 0x0055241D
		public INpcStandbyShowModeT AsINpcStandbyShowMode()
		{
			return this.As<INpcStandbyShowModeT>();
		}

		// Token: 0x06026ED5 RID: 159445 RVA: 0x00554225 File Offset: 0x00552425
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowMode(INpcStandbyShowModeT _inpcstandbyshowmode)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowMode,
				Value = _inpcstandbyshowmode
			};
		}

		// Token: 0x06026ED6 RID: 159446 RVA: 0x0055423A File Offset: 0x0055243A
		public INpcStandbyShowFinitelyT AsINpcStandbyShowFinitely()
		{
			return this.As<INpcStandbyShowFinitelyT>();
		}

		// Token: 0x06026ED7 RID: 159447 RVA: 0x00554242 File Offset: 0x00552442
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowFinitely(INpcStandbyShowFinitelyT _inpcstandbyshowfinitely)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowFinitely,
				Value = _inpcstandbyshowfinitely
			};
		}

		// Token: 0x06026ED8 RID: 159448 RVA: 0x00554257 File Offset: 0x00552457
		public INpcStandbyShowLooplyT AsINpcStandbyShowLooply()
		{
			return this.As<INpcStandbyShowLooplyT>();
		}

		// Token: 0x06026ED9 RID: 159449 RVA: 0x0055425F File Offset: 0x0055245F
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbyShowLooply(INpcStandbyShowLooplyT _inpcstandbyshowlooply)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbyShowLooply,
				Value = _inpcstandbyshowlooply
			};
		}

		// Token: 0x06026EDA RID: 159450 RVA: 0x00554274 File Offset: 0x00552474
		public INpcStandbySitT AsINpcStandbySit()
		{
			return this.As<INpcStandbySitT>();
		}

		// Token: 0x06026EDB RID: 159451 RVA: 0x0055427C File Offset: 0x0055247C
		public static INpcStandbyShowMode_UnionUnion FromINpcStandbySit(INpcStandbySitT _inpcstandbysit)
		{
			return new INpcStandbyShowMode_UnionUnion
			{
				Type = INpcStandbyShowMode_Union.INpcStandbySit,
				Value = _inpcstandbysit
			};
		}

		// Token: 0x06026EDC RID: 159452 RVA: 0x00554294 File Offset: 0x00552494
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
