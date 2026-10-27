using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430F RID: 17167
	public class TRollBlockLaunchMethodUnion
	{
		// Token: 0x1700796C RID: 31084
		// (get) Token: 0x06019755 RID: 104277 RVA: 0x003A60E0 File Offset: 0x003A42E0
		// (set) Token: 0x06019756 RID: 104278 RVA: 0x003A60E8 File Offset: 0x003A42E8
		public TRollBlockLaunchMethod Type { get; set; }

		// Token: 0x1700796D RID: 31085
		// (get) Token: 0x06019757 RID: 104279 RVA: 0x003A60F1 File Offset: 0x003A42F1
		// (set) Token: 0x06019758 RID: 104280 RVA: 0x003A60F9 File Offset: 0x003A42F9
		public object Value { get; set; }

		// Token: 0x06019759 RID: 104281 RVA: 0x003A6102 File Offset: 0x003A4302
		public TRollBlockLaunchMethodUnion()
		{
			this.Type = TRollBlockLaunchMethod.NONE;
			this.Value = null;
		}

		// Token: 0x0601975A RID: 104282 RVA: 0x003A6118 File Offset: 0x003A4318
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601975B RID: 104283 RVA: 0x003A612A File Offset: 0x003A432A
		public IRollBlockLaunchMethodInteractT AsIRollBlockLaunchMethodInteract()
		{
			return this.As<IRollBlockLaunchMethodInteractT>();
		}

		// Token: 0x0601975C RID: 104284 RVA: 0x003A6132 File Offset: 0x003A4332
		public static TRollBlockLaunchMethodUnion FromIRollBlockLaunchMethodInteract(IRollBlockLaunchMethodInteractT _irollblocklaunchmethodinteract)
		{
			return new TRollBlockLaunchMethodUnion
			{
				Type = TRollBlockLaunchMethod.IRollBlockLaunchMethodInteract,
				Value = _irollblocklaunchmethodinteract
			};
		}

		// Token: 0x0601975D RID: 104285 RVA: 0x003A6147 File Offset: 0x003A4347
		public IRollBlockLaunchMethodRangeT AsIRollBlockLaunchMethodRange()
		{
			return this.As<IRollBlockLaunchMethodRangeT>();
		}

		// Token: 0x0601975E RID: 104286 RVA: 0x003A614F File Offset: 0x003A434F
		public static TRollBlockLaunchMethodUnion FromIRollBlockLaunchMethodRange(IRollBlockLaunchMethodRangeT _irollblocklaunchmethodrange)
		{
			return new TRollBlockLaunchMethodUnion
			{
				Type = TRollBlockLaunchMethod.IRollBlockLaunchMethodRange,
				Value = _irollblocklaunchmethodrange
			};
		}

		// Token: 0x0601975F RID: 104287 RVA: 0x003A6164 File Offset: 0x003A4364
		public static int Pack(FlatBufferBuilder builder, TRollBlockLaunchMethodUnion _o)
		{
			TRollBlockLaunchMethod type = _o.Type;
			if (type == TRollBlockLaunchMethod.IRollBlockLaunchMethodInteract)
			{
				return IRollBlockLaunchMethodInteract.Pack(builder, _o.AsIRollBlockLaunchMethodInteract()).Value;
			}
			if (type != TRollBlockLaunchMethod.IRollBlockLaunchMethodRange)
			{
				return 0;
			}
			return IRollBlockLaunchMethodRange.Pack(builder, _o.AsIRollBlockLaunchMethodRange()).Value;
		}
	}
}
