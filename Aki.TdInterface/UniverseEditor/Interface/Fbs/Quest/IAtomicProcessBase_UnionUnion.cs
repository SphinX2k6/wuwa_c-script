using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D1D RID: 15645
	public class IAtomicProcessBase_UnionUnion
	{
		// Token: 0x17006B51 RID: 27473
		// (get) Token: 0x06015967 RID: 88423 RVA: 0x0031E0E5 File Offset: 0x0031C2E5
		// (set) Token: 0x06015968 RID: 88424 RVA: 0x0031E0ED File Offset: 0x0031C2ED
		public IAtomicProcessBase_Union Type { get; set; }

		// Token: 0x17006B52 RID: 27474
		// (get) Token: 0x06015969 RID: 88425 RVA: 0x0031E0F6 File Offset: 0x0031C2F6
		// (set) Token: 0x0601596A RID: 88426 RVA: 0x0031E0FE File Offset: 0x0031C2FE
		public object Value { get; set; }

		// Token: 0x0601596B RID: 88427 RVA: 0x0031E107 File Offset: 0x0031C307
		public IAtomicProcessBase_UnionUnion()
		{
			this.Type = IAtomicProcessBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601596C RID: 88428 RVA: 0x0031E11D File Offset: 0x0031C31D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601596D RID: 88429 RVA: 0x0031E12F File Offset: 0x0031C32F
		public IAtomicProcessBaseT AsIAtomicProcessBase()
		{
			return this.As<IAtomicProcessBaseT>();
		}

		// Token: 0x0601596E RID: 88430 RVA: 0x0031E137 File Offset: 0x0031C337
		public static IAtomicProcessBase_UnionUnion FromIAtomicProcessBase(IAtomicProcessBaseT _iatomicprocessbase)
		{
			return new IAtomicProcessBase_UnionUnion
			{
				Type = IAtomicProcessBase_Union.IAtomicProcessBase,
				Value = _iatomicprocessbase
			};
		}

		// Token: 0x0601596F RID: 88431 RVA: 0x0031E14C File Offset: 0x0031C34C
		public IAtomicProcessStoveCoreFallT AsIAtomicProcessStoveCoreFall()
		{
			return this.As<IAtomicProcessStoveCoreFallT>();
		}

		// Token: 0x06015970 RID: 88432 RVA: 0x0031E154 File Offset: 0x0031C354
		public static IAtomicProcessBase_UnionUnion FromIAtomicProcessStoveCoreFall(IAtomicProcessStoveCoreFallT _iatomicprocessstovecorefall)
		{
			return new IAtomicProcessBase_UnionUnion
			{
				Type = IAtomicProcessBase_Union.IAtomicProcessStoveCoreFall,
				Value = _iatomicprocessstovecorefall
			};
		}

		// Token: 0x06015971 RID: 88433 RVA: 0x0031E16C File Offset: 0x0031C36C
		public static int Pack(FlatBufferBuilder builder, IAtomicProcessBase_UnionUnion _o)
		{
			IAtomicProcessBase_Union type = _o.Type;
			if (type == IAtomicProcessBase_Union.IAtomicProcessBase)
			{
				return IAtomicProcessBase.Pack(builder, _o.AsIAtomicProcessBase()).Value;
			}
			if (type != IAtomicProcessBase_Union.IAtomicProcessStoveCoreFall)
			{
				return 0;
			}
			return IAtomicProcessStoveCoreFall.Pack(builder, _o.AsIAtomicProcessStoveCoreFall()).Value;
		}
	}
}
