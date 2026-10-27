using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005019 RID: 20505
	public class IConnectorPathAdvanceVisual_UnionUnion
	{
		// Token: 0x170094A7 RID: 38055
		// (get) Token: 0x06020CF9 RID: 134393 RVA: 0x0048FBD5 File Offset: 0x0048DDD5
		// (set) Token: 0x06020CFA RID: 134394 RVA: 0x0048FBDD File Offset: 0x0048DDDD
		public IConnectorPathAdvanceVisual_Union Type { get; set; }

		// Token: 0x170094A8 RID: 38056
		// (get) Token: 0x06020CFB RID: 134395 RVA: 0x0048FBE6 File Offset: 0x0048DDE6
		// (set) Token: 0x06020CFC RID: 134396 RVA: 0x0048FBEE File Offset: 0x0048DDEE
		public object Value { get; set; }

		// Token: 0x06020CFD RID: 134397 RVA: 0x0048FBF7 File Offset: 0x0048DDF7
		public IConnectorPathAdvanceVisual_UnionUnion()
		{
			this.Type = IConnectorPathAdvanceVisual_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020CFE RID: 134398 RVA: 0x0048FC0D File Offset: 0x0048DE0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020CFF RID: 134399 RVA: 0x0048FC1F File Offset: 0x0048DE1F
		public IConnectorPathAdvanceVisualT AsIConnectorPathAdvanceVisual()
		{
			return this.As<IConnectorPathAdvanceVisualT>();
		}

		// Token: 0x06020D00 RID: 134400 RVA: 0x0048FC27 File Offset: 0x0048DE27
		public static IConnectorPathAdvanceVisual_UnionUnion FromIConnectorPathAdvanceVisual(IConnectorPathAdvanceVisualT _iconnectorpathadvancevisual)
		{
			return new IConnectorPathAdvanceVisual_UnionUnion
			{
				Type = IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVisual,
				Value = _iconnectorpathadvancevisual
			};
		}

		// Token: 0x06020D01 RID: 134401 RVA: 0x0048FC3C File Offset: 0x0048DE3C
		public IConnectorPathAdvanceVasePlantVisualT AsIConnectorPathAdvanceVasePlantVisual()
		{
			return this.As<IConnectorPathAdvanceVasePlantVisualT>();
		}

		// Token: 0x06020D02 RID: 134402 RVA: 0x0048FC44 File Offset: 0x0048DE44
		public static IConnectorPathAdvanceVisual_UnionUnion FromIConnectorPathAdvanceVasePlantVisual(IConnectorPathAdvanceVasePlantVisualT _iconnectorpathadvancevaseplantvisual)
		{
			return new IConnectorPathAdvanceVisual_UnionUnion
			{
				Type = IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVasePlantVisual,
				Value = _iconnectorpathadvancevaseplantvisual
			};
		}

		// Token: 0x06020D03 RID: 134403 RVA: 0x0048FC5C File Offset: 0x0048DE5C
		public static int Pack(FlatBufferBuilder builder, IConnectorPathAdvanceVisual_UnionUnion _o)
		{
			IConnectorPathAdvanceVisual_Union type = _o.Type;
			if (type == IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVisual)
			{
				return IConnectorPathAdvanceVisual.Pack(builder, _o.AsIConnectorPathAdvanceVisual()).Value;
			}
			if (type != IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVasePlantVisual)
			{
				return 0;
			}
			return IConnectorPathAdvanceVasePlantVisual.Pack(builder, _o.AsIConnectorPathAdvanceVasePlantVisual()).Value;
		}
	}
}
