using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004401 RID: 17409
	public class IProgressBarLeftType_UnionUnion
	{
		// Token: 0x170077F4 RID: 30708
		// (get) Token: 0x06018BE9 RID: 101353 RVA: 0x00386C1D File Offset: 0x00384E1D
		// (set) Token: 0x06018BEA RID: 101354 RVA: 0x00386C25 File Offset: 0x00384E25
		public IProgressBarLeftType_Union Type { get; set; }

		// Token: 0x170077F5 RID: 30709
		// (get) Token: 0x06018BEB RID: 101355 RVA: 0x00386C2E File Offset: 0x00384E2E
		// (set) Token: 0x06018BEC RID: 101356 RVA: 0x00386C36 File Offset: 0x00384E36
		public object Value { get; set; }

		// Token: 0x06018BED RID: 101357 RVA: 0x00386C3F File Offset: 0x00384E3F
		public IProgressBarLeftType_UnionUnion()
		{
			this.Type = IProgressBarLeftType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018BEE RID: 101358 RVA: 0x00386C55 File Offset: 0x00384E55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018BEF RID: 101359 RVA: 0x00386C67 File Offset: 0x00384E67
		public IProgressBarLeftTypeT AsIProgressBarLeftType()
		{
			return this.As<IProgressBarLeftTypeT>();
		}

		// Token: 0x06018BF0 RID: 101360 RVA: 0x00386C6F File Offset: 0x00384E6F
		public static IProgressBarLeftType_UnionUnion FromIProgressBarLeftType(IProgressBarLeftTypeT _iprogressbarlefttype)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IProgressBarLeftType,
				Value = _iprogressbarlefttype
			};
		}

		// Token: 0x06018BF1 RID: 101361 RVA: 0x00386C84 File Offset: 0x00384E84
		public IUseCountT AsIUseCount()
		{
			return this.As<IUseCountT>();
		}

		// Token: 0x06018BF2 RID: 101362 RVA: 0x00386C8C File Offset: 0x00384E8C
		public static IProgressBarLeftType_UnionUnion FromIUseCount(IUseCountT _iusecount)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IUseCount,
				Value = _iusecount
			};
		}

		// Token: 0x06018BF3 RID: 101363 RVA: 0x00386CA1 File Offset: 0x00384EA1
		public IUseVarT AsIUseVar()
		{
			return this.As<IUseVarT>();
		}

		// Token: 0x06018BF4 RID: 101364 RVA: 0x00386CA9 File Offset: 0x00384EA9
		public static IProgressBarLeftType_UnionUnion FromIUseVar(IUseVarT _iusevar)
		{
			return new IProgressBarLeftType_UnionUnion
			{
				Type = IProgressBarLeftType_Union.IUseVar,
				Value = _iusevar
			};
		}

		// Token: 0x06018BF5 RID: 101365 RVA: 0x00386CC0 File Offset: 0x00384EC0
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
