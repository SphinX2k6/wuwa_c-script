using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200476E RID: 18286
	public class TRollBlockLaunchMethodUnion
	{
		// Token: 0x17007F9F RID: 32671
		// (get) Token: 0x0601AED7 RID: 110295 RVA: 0x003D1A10 File Offset: 0x003CFC10
		// (set) Token: 0x0601AED8 RID: 110296 RVA: 0x003D1A18 File Offset: 0x003CFC18
		public TRollBlockLaunchMethod Type { get; set; }

		// Token: 0x17007FA0 RID: 32672
		// (get) Token: 0x0601AED9 RID: 110297 RVA: 0x003D1A21 File Offset: 0x003CFC21
		// (set) Token: 0x0601AEDA RID: 110298 RVA: 0x003D1A29 File Offset: 0x003CFC29
		public object Value { get; set; }

		// Token: 0x0601AEDB RID: 110299 RVA: 0x003D1A32 File Offset: 0x003CFC32
		public TRollBlockLaunchMethodUnion()
		{
			this.Type = TRollBlockLaunchMethod.NONE;
			this.Value = null;
		}

		// Token: 0x0601AEDC RID: 110300 RVA: 0x003D1A48 File Offset: 0x003CFC48
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AEDD RID: 110301 RVA: 0x003D1A5A File Offset: 0x003CFC5A
		public IRollBlockLaunchMethodInteractT AsIRollBlockLaunchMethodInteract()
		{
			return this.As<IRollBlockLaunchMethodInteractT>();
		}

		// Token: 0x0601AEDE RID: 110302 RVA: 0x003D1A62 File Offset: 0x003CFC62
		public static TRollBlockLaunchMethodUnion FromIRollBlockLaunchMethodInteract(IRollBlockLaunchMethodInteractT _irollblocklaunchmethodinteract)
		{
			return new TRollBlockLaunchMethodUnion
			{
				Type = TRollBlockLaunchMethod.IRollBlockLaunchMethodInteract,
				Value = _irollblocklaunchmethodinteract
			};
		}

		// Token: 0x0601AEDF RID: 110303 RVA: 0x003D1A77 File Offset: 0x003CFC77
		public IRollBlockLaunchMethodRangeT AsIRollBlockLaunchMethodRange()
		{
			return this.As<IRollBlockLaunchMethodRangeT>();
		}

		// Token: 0x0601AEE0 RID: 110304 RVA: 0x003D1A7F File Offset: 0x003CFC7F
		public static TRollBlockLaunchMethodUnion FromIRollBlockLaunchMethodRange(IRollBlockLaunchMethodRangeT _irollblocklaunchmethodrange)
		{
			return new TRollBlockLaunchMethodUnion
			{
				Type = TRollBlockLaunchMethod.IRollBlockLaunchMethodRange,
				Value = _irollblocklaunchmethodrange
			};
		}

		// Token: 0x0601AEE1 RID: 110305 RVA: 0x003D1A94 File Offset: 0x003CFC94
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
