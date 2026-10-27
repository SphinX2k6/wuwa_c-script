using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FC0 RID: 16320
	public class IProgressBarLeftType_UnionUnion
	{
		// Token: 0x170071F6 RID: 29174
		// (get) Token: 0x0601755A RID: 95578 RVA: 0x0035D005 File Offset: 0x0035B205
		// (set) Token: 0x0601755B RID: 95579 RVA: 0x0035D00D File Offset: 0x0035B20D
		public IProgressBarLeftType_Union Type { get; set; }

		// Token: 0x170071F7 RID: 29175
		// (get) Token: 0x0601755C RID: 95580 RVA: 0x0035D016 File Offset: 0x0035B216
		// (set) Token: 0x0601755D RID: 95581 RVA: 0x0035D01E File Offset: 0x0035B21E
		public object Value { get; set; }

		// Token: 0x0601755E RID: 95582 RVA: 0x0035D027 File Offset: 0x0035B227
		public IProgressBarLeftType_UnionUnion()
		{
			this.Type = IProgressBarLeftType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601755F RID: 95583 RVA: 0x0035D03D File Offset: 0x0035B23D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017560 RID: 95584 RVA: 0x0035D04F File Offset: 0x0035B24F
		public IProgressBarLeftTypeT AsIProgressBarLeftType()
		{
			return this.As<IProgressBarLeftTypeT>();
		}

		// Token: 0x06017561 RID: 95585 RVA: 0x0035D057 File Offset: 0x0035B257
		public static IProgressBarLeftType_UnionUnion FromIProgressBarLeftType(IProgressBarLeftTypeT _iprogressbarlefttype)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IProgressBarLeftType,
				Value = _iprogressbarlefttype
			};
		}

		// Token: 0x06017562 RID: 95586 RVA: 0x0035D06C File Offset: 0x0035B26C
		public IUseCountT AsIUseCount()
		{
			return this.As<IUseCountT>();
		}

		// Token: 0x06017563 RID: 95587 RVA: 0x0035D074 File Offset: 0x0035B274
		public static IProgressBarLeftType_UnionUnion FromIUseCount(IUseCountT _iusecount)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IUseCount,
				Value = _iusecount
			};
		}

		// Token: 0x06017564 RID: 95588 RVA: 0x0035D089 File Offset: 0x0035B289
		public IUseVarT AsIUseVar()
		{
			return this.As<IUseVarT>();
		}

		// Token: 0x06017565 RID: 95589 RVA: 0x0035D091 File Offset: 0x0035B291
		public static IProgressBarLeftType_UnionUnion FromIUseVar(IUseVarT _iusevar)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IUseVar,
				Value = _iusevar
			};
		}

		// Token: 0x06017566 RID: 95590 RVA: 0x0035D0A8 File Offset: 0x0035B2A8
		public static int Pack(FlatBufferBuilder builder, IProgressBarLeftType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IProgressBarLeftType_Union.IProgressBarLeftType:
				return IProgressBarLeftType.Pack(builder, _o.AsIProgressBarLeftType()).Value;
			case IProgressBarLeftType_Union.IUseCount:
				return IUseCount.Pack(builder, _o.AsIUseCount()).Value;
			case IProgressBarLeftType_Union.IUseVar:
				return IUseVar.Pack(builder, _o.AsIUseVar()).Value;
			default:
				return 0;
			}
		}
	}
}
