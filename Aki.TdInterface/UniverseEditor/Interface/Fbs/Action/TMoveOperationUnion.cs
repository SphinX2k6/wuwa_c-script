using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772C RID: 30508
	public class TMoveOperationUnion
	{
		// Token: 0x1700E661 RID: 58977
		// (get) Token: 0x06037718 RID: 227096 RVA: 0x00781B4E File Offset: 0x0077FD4E
		// (set) Token: 0x06037719 RID: 227097 RVA: 0x00781B56 File Offset: 0x0077FD56
		public TMoveOperation Type { get; set; }

		// Token: 0x1700E662 RID: 58978
		// (get) Token: 0x0603771A RID: 227098 RVA: 0x00781B5F File Offset: 0x0077FD5F
		// (set) Token: 0x0603771B RID: 227099 RVA: 0x00781B67 File Offset: 0x0077FD67
		public object Value { get; set; }

		// Token: 0x0603771C RID: 227100 RVA: 0x00781B70 File Offset: 0x0077FD70
		public TMoveOperationUnion()
		{
			this.Type = TMoveOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603771D RID: 227101 RVA: 0x00781B86 File Offset: 0x0077FD86
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603771E RID: 227102 RVA: 0x00781B98 File Offset: 0x0077FD98
		public IDisableMoveOperationT AsIDisableMoveOperation()
		{
			return this.As<IDisableMoveOperationT>();
		}

		// Token: 0x0603771F RID: 227103 RVA: 0x00781BA0 File Offset: 0x0077FDA0
		public static TMoveOperationUnion FromIDisableMoveOperation(IDisableMoveOperationT _idisablemoveoperation)
		{
			return new TMoveOperationUnion
			{
				Type = TMoveOperation.IDisableMoveOperation,
				Value = _idisablemoveoperation
			};
		}

		// Token: 0x06037720 RID: 227104 RVA: 0x00781BB5 File Offset: 0x0077FDB5
		public IEnableMoveOperationT AsIEnableMoveOperation()
		{
			return this.As<IEnableMoveOperationT>();
		}

		// Token: 0x06037721 RID: 227105 RVA: 0x00781BBD File Offset: 0x0077FDBD
		public static TMoveOperationUnion FromIEnableMoveOperation(IEnableMoveOperationT _ienablemoveoperation)
		{
			return new TMoveOperationUnion
			{
				Type = TMoveOperation.IEnableMoveOperation,
				Value = _ienablemoveoperation
			};
		}

		// Token: 0x06037722 RID: 227106 RVA: 0x00781BD4 File Offset: 0x0077FDD4
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
