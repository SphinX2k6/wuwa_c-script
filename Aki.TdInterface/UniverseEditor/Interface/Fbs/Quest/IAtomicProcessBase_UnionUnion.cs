using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004134 RID: 16692
	public class IAtomicProcessBase_UnionUnion
	{
		// Token: 0x1700710B RID: 28939
		// (get) Token: 0x06016E9F RID: 93855 RVA: 0x0034535D File Offset: 0x0034355D
		// (set) Token: 0x06016EA0 RID: 93856 RVA: 0x00345365 File Offset: 0x00343565
		public IAtomicProcessBase_Union Type { get; set; }

		// Token: 0x1700710C RID: 28940
		// (get) Token: 0x06016EA1 RID: 93857 RVA: 0x0034536E File Offset: 0x0034356E
		// (set) Token: 0x06016EA2 RID: 93858 RVA: 0x00345376 File Offset: 0x00343576
		public object Value { get; set; }

		// Token: 0x06016EA3 RID: 93859 RVA: 0x0034537F File Offset: 0x0034357F
		public IAtomicProcessBase_UnionUnion()
		{
			this.Type = IAtomicProcessBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016EA4 RID: 93860 RVA: 0x00345395 File Offset: 0x00343595
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016EA5 RID: 93861 RVA: 0x003453A7 File Offset: 0x003435A7
		public IAtomicProcessBaseT AsIAtomicProcessBase()
		{
			return this.As<IAtomicProcessBaseT>();
		}

		// Token: 0x06016EA6 RID: 93862 RVA: 0x003453AF File Offset: 0x003435AF
		public static IAtomicProcessBase_UnionUnion FromIAtomicProcessBase(IAtomicProcessBaseT _iatomicprocessbase)
		{
			return new IAtomicProcessBase_UnionUnion
			{
				Type = IAtomicProcessBase_Union.IAtomicProcessBase,
				Value = _iatomicprocessbase
			};
		}

		// Token: 0x06016EA7 RID: 93863 RVA: 0x003453C4 File Offset: 0x003435C4
		public IAtomicProcessStoveCoreFallT AsIAtomicProcessStoveCoreFall()
		{
			return this.As<IAtomicProcessStoveCoreFallT>();
		}

		// Token: 0x06016EA8 RID: 93864 RVA: 0x003453CC File Offset: 0x003435CC
		public static IAtomicProcessBase_UnionUnion FromIAtomicProcessStoveCoreFall(IAtomicProcessStoveCoreFallT _iatomicprocessstovecorefall)
		{
			return new IAtomicProcessBase_UnionUnion
			{
				Type = IAtomicProcessBase_Union.IAtomicProcessStoveCoreFall,
				Value = _iatomicprocessstovecorefall
			};
		}

		// Token: 0x06016EA9 RID: 93865 RVA: 0x003453E4 File Offset: 0x003435E4
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
