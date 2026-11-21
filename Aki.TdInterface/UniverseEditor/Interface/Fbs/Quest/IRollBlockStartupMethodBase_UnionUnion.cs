using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004536 RID: 17718
	public class IRollBlockStartupMethodBase_UnionUnion
	{
		// Token: 0x17007B36 RID: 31542
		// (get) Token: 0x06019A5E RID: 105054 RVA: 0x003A70E9 File Offset: 0x003A52E9
		// (set) Token: 0x06019A5F RID: 105055 RVA: 0x003A70F1 File Offset: 0x003A52F1
		public IRollBlockStartupMethodBase_Union Type { get; set; }

		// Token: 0x17007B37 RID: 31543
		// (get) Token: 0x06019A60 RID: 105056 RVA: 0x003A70FA File Offset: 0x003A52FA
		// (set) Token: 0x06019A61 RID: 105057 RVA: 0x003A7102 File Offset: 0x003A5302
		public object Value { get; set; }

		// Token: 0x06019A62 RID: 105058 RVA: 0x003A710B File Offset: 0x003A530B
		public IRollBlockStartupMethodBase_UnionUnion()
		{
			this.Type = IRollBlockStartupMethodBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019A63 RID: 105059 RVA: 0x003A7121 File Offset: 0x003A5321
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019A64 RID: 105060 RVA: 0x003A7133 File Offset: 0x003A5333
		public IRollBlockStartupMethodBaseT AsIRollBlockStartupMethodBase()
		{
			return this.As<IRollBlockStartupMethodBaseT>();
		}

		// Token: 0x06019A65 RID: 105061 RVA: 0x003A713B File Offset: 0x003A533B
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockStartupMethodBase(IRollBlockStartupMethodBaseT _irollblockstartupmethodbase)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockStartupMethodBase,
				Value = _irollblockstartupmethodbase
			};
		}

		// Token: 0x06019A66 RID: 105062 RVA: 0x003A7150 File Offset: 0x003A5350
		public IRollBlockLaunchMethodInteractT AsIRollBlockLaunchMethodInteract()
		{
			return this.As<IRollBlockLaunchMethodInteractT>();
		}

		// Token: 0x06019A67 RID: 105063 RVA: 0x003A7158 File Offset: 0x003A5358
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockLaunchMethodInteract(IRollBlockLaunchMethodInteractT _irollblocklaunchmethodinteract)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodInteract,
				Value = _irollblocklaunchmethodinteract
			};
		}

		// Token: 0x06019A68 RID: 105064 RVA: 0x003A716D File Offset: 0x003A536D
		public IRollBlockLaunchMethodRangeT AsIRollBlockLaunchMethodRange()
		{
			return this.As<IRollBlockLaunchMethodRangeT>();
		}

		// Token: 0x06019A69 RID: 105065 RVA: 0x003A7175 File Offset: 0x003A5375
		public static IRollBlockStartupMethodBase_UnionUnion FromIRollBlockLaunchMethodRange(IRollBlockLaunchMethodRangeT _irollblocklaunchmethodrange)
		{
			return new IRollBlockStartupMethodBase_UnionUnion
			{
				Type = IRollBlockStartupMethodBase_Union.IRollBlockLaunchMethodRange,
				Value = _irollblocklaunchmethodrange
			};
		}

		// Token: 0x06019A6A RID: 105066 RVA: 0x003A718C File Offset: 0x003A538C
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
