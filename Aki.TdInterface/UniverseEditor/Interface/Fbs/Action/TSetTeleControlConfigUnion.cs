using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC2 RID: 32706
	public class TSetTeleControlConfigUnion
	{
		// Token: 0x1700F2F9 RID: 62201
		// (get) Token: 0x0603AE65 RID: 241253 RVA: 0x007E9BDC File Offset: 0x007E7DDC
		// (set) Token: 0x0603AE66 RID: 241254 RVA: 0x007E9BE4 File Offset: 0x007E7DE4
		public TSetTeleControlConfig Type { get; set; }

		// Token: 0x1700F2FA RID: 62202
		// (get) Token: 0x0603AE67 RID: 241255 RVA: 0x007E9BED File Offset: 0x007E7DED
		// (set) Token: 0x0603AE68 RID: 241256 RVA: 0x007E9BF5 File Offset: 0x007E7DF5
		public object Value { get; set; }

		// Token: 0x0603AE69 RID: 241257 RVA: 0x007E9BFE File Offset: 0x007E7DFE
		public TSetTeleControlConfigUnion()
		{
			this.Type = TSetTeleControlConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE6A RID: 241258 RVA: 0x007E9C14 File Offset: 0x007E7E14
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE6B RID: 241259 RVA: 0x007E9C26 File Offset: 0x007E7E26
		public IOpenGravityT AsIOpenGravity()
		{
			return this.As<IOpenGravityT>();
		}

		// Token: 0x0603AE6C RID: 241260 RVA: 0x007E9C2E File Offset: 0x007E7E2E
		public static TSetTeleControlConfigUnion FromIOpenGravity(IOpenGravityT _iopengravity)
		{
			return new TSetTeleControlConfigUnion
			{
				Type = TSetTeleControlConfig.IOpenGravity,
				Value = _iopengravity
			};
		}

		// Token: 0x0603AE6D RID: 241261 RVA: 0x007E9C43 File Offset: 0x007E7E43
		public ISetResetPositionT AsISetResetPosition()
		{
			return this.As<ISetResetPositionT>();
		}

		// Token: 0x0603AE6E RID: 241262 RVA: 0x007E9C4B File Offset: 0x007E7E4B
		public static TSetTeleControlConfigUnion FromISetResetPosition(ISetResetPositionT _isetresetposition)
		{
			return new TSetTeleControlConfigUnion
			{
				Type = TSetTeleControlConfig.ISetResetPosition,
				Value = _isetresetposition
			};
		}

		// Token: 0x0603AE6F RID: 241263 RVA: 0x007E9C60 File Offset: 0x007E7E60
		public static int Pack(FlatBufferBuilder builder, TSetTeleControlConfigUnion _o)
		{
			TSetTeleControlConfig type = _o.Type;
			if (type == TSetTeleControlConfig.IOpenGravity)
			{
				return IOpenGravity.Pack(builder, _o.AsIOpenGravity()).Value;
			}
			if (type != TSetTeleControlConfig.ISetResetPosition)
			{
				return 0;
			}
			return ISetResetPosition.Pack(builder, _o.AsISetResetPosition()).Value;
		}
	}
}
