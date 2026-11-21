using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062A1 RID: 25249
	public class TNpcStandbyShowOptionUnion
	{
		// Token: 0x1700BB82 RID: 48002
		// (get) Token: 0x0602AF07 RID: 175879 RVA: 0x005DBD50 File Offset: 0x005D9F50
		// (set) Token: 0x0602AF08 RID: 175880 RVA: 0x005DBD58 File Offset: 0x005D9F58
		public TNpcStandbyShowOption Type { get; set; }

		// Token: 0x1700BB83 RID: 48003
		// (get) Token: 0x0602AF09 RID: 175881 RVA: 0x005DBD61 File Offset: 0x005D9F61
		// (set) Token: 0x0602AF0A RID: 175882 RVA: 0x005DBD69 File Offset: 0x005D9F69
		public object Value { get; set; }

		// Token: 0x0602AF0B RID: 175883 RVA: 0x005DBD72 File Offset: 0x005D9F72
		public TNpcStandbyShowOptionUnion()
		{
			this.Type = TNpcStandbyShowOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF0C RID: 175884 RVA: 0x005DBD88 File Offset: 0x005D9F88
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF0D RID: 175885 RVA: 0x005DBD9A File Offset: 0x005D9F9A
		public INpcStandbyShowFinitelyT AsINpcStandbyShowFinitely()
		{
			return this.As<INpcStandbyShowFinitelyT>();
		}

		// Token: 0x0602AF0E RID: 175886 RVA: 0x005DBDA2 File Offset: 0x005D9FA2
		public static TNpcStandbyShowOptionUnion FromINpcStandbyShowFinitely(INpcStandbyShowFinitelyT _inpcstandbyshowfinitely)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbyShowFinitely,
				Value = _inpcstandbyshowfinitely
			};
		}

		// Token: 0x0602AF0F RID: 175887 RVA: 0x005DBDB7 File Offset: 0x005D9FB7
		public INpcStandbyShowLooplyT AsINpcStandbyShowLooply()
		{
			return this.As<INpcStandbyShowLooplyT>();
		}

		// Token: 0x0602AF10 RID: 175888 RVA: 0x005DBDBF File Offset: 0x005D9FBF
		public static TNpcStandbyShowOptionUnion FromINpcStandbyShowLooply(INpcStandbyShowLooplyT _inpcstandbyshowlooply)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbyShowLooply,
				Value = _inpcstandbyshowlooply
			};
		}

		// Token: 0x0602AF11 RID: 175889 RVA: 0x005DBDD4 File Offset: 0x005D9FD4
		public INpcStandbySitT AsINpcStandbySit()
		{
			return this.As<INpcStandbySitT>();
		}

		// Token: 0x0602AF12 RID: 175890 RVA: 0x005DBDDC File Offset: 0x005D9FDC
		public static TNpcStandbyShowOptionUnion FromINpcStandbySit(INpcStandbySitT _inpcstandbysit)
		{
			return new TNpcStandbyShowOptionUnion
			{
				Type = TNpcStandbyShowOption.INpcStandbySit,
				Value = _inpcstandbysit
			};
		}

		// Token: 0x0602AF13 RID: 175891 RVA: 0x005DBDF4 File Offset: 0x005D9FF4
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
