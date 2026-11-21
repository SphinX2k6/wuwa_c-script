using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F55 RID: 32597
	public class TMoveOperationUnion
	{
		// Token: 0x1700F2B1 RID: 62129
		// (get) Token: 0x0603AC53 RID: 240723 RVA: 0x007E6ADE File Offset: 0x007E4CDE
		// (set) Token: 0x0603AC54 RID: 240724 RVA: 0x007E6AE6 File Offset: 0x007E4CE6
		public TMoveOperation Type { get; set; }

		// Token: 0x1700F2B2 RID: 62130
		// (get) Token: 0x0603AC55 RID: 240725 RVA: 0x007E6AEF File Offset: 0x007E4CEF
		// (set) Token: 0x0603AC56 RID: 240726 RVA: 0x007E6AF7 File Offset: 0x007E4CF7
		public object Value { get; set; }

		// Token: 0x0603AC57 RID: 240727 RVA: 0x007E6B00 File Offset: 0x007E4D00
		public TMoveOperationUnion()
		{
			this.Type = TMoveOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC58 RID: 240728 RVA: 0x007E6B16 File Offset: 0x007E4D16
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC59 RID: 240729 RVA: 0x007E6B28 File Offset: 0x007E4D28
		public IDisableMoveOperationT AsIDisableMoveOperation()
		{
			return this.As<IDisableMoveOperationT>();
		}

		// Token: 0x0603AC5A RID: 240730 RVA: 0x007E6B30 File Offset: 0x007E4D30
		public static TMoveOperationUnion FromIDisableMoveOperation(IDisableMoveOperationT _idisablemoveoperation)
		{
			return new TMoveOperationUnion
			{
				Type = TMoveOperation.IDisableMoveOperation,
				Value = _idisablemoveoperation
			};
		}

		// Token: 0x0603AC5B RID: 240731 RVA: 0x007E6B45 File Offset: 0x007E4D45
		public IEnableMoveOperationT AsIEnableMoveOperation()
		{
			return this.As<IEnableMoveOperationT>();
		}

		// Token: 0x0603AC5C RID: 240732 RVA: 0x007E6B4D File Offset: 0x007E4D4D
		public static TMoveOperationUnion FromIEnableMoveOperation(IEnableMoveOperationT _ienablemoveoperation)
		{
			return new TMoveOperationUnion
			{
				Type = TMoveOperation.IEnableMoveOperation,
				Value = _ienablemoveoperation
			};
		}

		// Token: 0x0603AC5D RID: 240733 RVA: 0x007E6B64 File Offset: 0x007E4D64
		public static int Pack(FlatBufferBuilder builder, TMoveOperationUnion _o)
		{
			TMoveOperation type = _o.Type;
			if (type == TMoveOperation.IDisableMoveOperation)
			{
				return IDisableMoveOperation.Pack(builder, _o.AsIDisableMoveOperation()).Value;
			}
			if (type != TMoveOperation.IEnableMoveOperation)
			{
				return 0;
			}
			return IEnableMoveOperation.Pack(builder, _o.AsIEnableMoveOperation()).Value;
		}
	}
}
