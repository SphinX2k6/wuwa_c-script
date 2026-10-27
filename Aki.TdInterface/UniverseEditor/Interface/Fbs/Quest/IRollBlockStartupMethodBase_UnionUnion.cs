using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F5 RID: 16629
	public class IRollBlockStartupMethodBase_UnionUnion
	{
		// Token: 0x17007530 RID: 30000
		// (get) Token: 0x060183BD RID: 99261 RVA: 0x0037D199 File Offset: 0x0037B399
		// (set) Token: 0x060183BE RID: 99262 RVA: 0x0037D1A1 File Offset: 0x0037B3A1
		public IRollBlockStartupMethodBase_Union Type { get; set; }

		// Token: 0x17007531 RID: 30001
		// (get) Token: 0x060183BF RID: 99263 RVA: 0x0037D1AA File Offset: 0x0037B3AA
		// (set) Token: 0x060183C0 RID: 99264 RVA: 0x0037D1B2 File Offset: 0x0037B3B2
		public object Value { get; set; }

		// Token: 0x060183C1 RID: 99265 RVA: 0x0037D1BB File Offset: 0x0037B3BB
		public IRollBlockStartupMethodBase_UnionUnion()
		{
			this.Type = IRollBlockStartupMethodBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060183C2 RID: 99266 RVA: 0x0037D1D1 File Offset: 0x0037B3D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060183C3 RID: 99267 RVA: 0x0037D1E3 File Offset: 0x0037B3E3
		public IRollBlockStartupMethodBaseT AsIRollBlockStartupMethodBase()
		{
			return this.As<IRollBlockStartupMethodBaseT>();
		}

		// Token: 0x060183C4 RID: 99268 RVA: 0x0037D1EB File Offset: 0x0037B3EB
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockStartupMethodBase(IRollBlockStartupMethodBaseT _irollblockstartupmethodbase)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockStartupMethodBase,
				Value = _irollblockstartupmethodbase
			};
		}

		// Token: 0x060183C5 RID: 99269 RVA: 0x0037D200 File Offset: 0x0037B400
		public IRollBlockLaunchMethodInteractT AsIRollBlockLaunchMethodInteract()
		{
			return this.As<IRollBlockLaunchMethodInteractT>();
		}

		// Token: 0x060183C6 RID: 99270 RVA: 0x0037D208 File Offset: 0x0037B408
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockLaunchMethodInteract(IRollBlockLaunchMethodInteractT _irollblocklaunchmethodinteract)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodInteract,
				Value = _irollblocklaunchmethodinteract
			};
		}

		// Token: 0x060183C7 RID: 99271 RVA: 0x0037D21D File Offset: 0x0037B41D
		public IRollBlockLaunchMethodRangeT AsIRollBlockLaunchMethodRange()
		{
			return this.As<IRollBlockLaunchMethodRangeT>();
		}

		// Token: 0x060183C8 RID: 99272 RVA: 0x0037D225 File Offset: 0x0037B425
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockLaunchMethodRange(IRollBlockLaunchMethodRangeT _irollblocklaunchmethodrange)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodRange,
				Value = _irollblocklaunchmethodrange
			};
		}

		// Token: 0x060183C9 RID: 99273 RVA: 0x0037D23C File Offset: 0x0037B43C
		public static int Pack(FlatBufferBuilder builder, IRollBlockStartupMethodBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRollBlockStartupMethodBase_Union.IRollBlockStartupMethodBase:
				return IRollBlockStartupMethodBase.Pack(builder, _o.AsIRollBlockStartupMethodBase()).Value;
			case IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodInteract:
				return IRollBlockLaunchMethodInteract.Pack(builder, _o.AsIRollBlockLaunchMethodInteract()).Value;
			case IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodRange:
				return IRollBlockLaunchMethodRange.Pack(builder, _o.AsIRollBlockLaunchMethodRange()).Value;
			default:
				return 0;
			}
		}
	}
}
