using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005578 RID: 21880
	public class IConnectorPathAdvanceVisual_UnionUnion
	{
		// Token: 0x17009C88 RID: 40072
		// (get) Token: 0x06022C19 RID: 142361 RVA: 0x004C9625 File Offset: 0x004C7825
		// (set) Token: 0x06022C1A RID: 142362 RVA: 0x004C962D File Offset: 0x004C782D
		public IConnectorPathAdvanceVisual_Union Type { get; set; }

		// Token: 0x17009C89 RID: 40073
		// (get) Token: 0x06022C1B RID: 142363 RVA: 0x004C9636 File Offset: 0x004C7836
		// (set) Token: 0x06022C1C RID: 142364 RVA: 0x004C963E File Offset: 0x004C783E
		public object Value { get; set; }

		// Token: 0x06022C1D RID: 142365 RVA: 0x004C9647 File Offset: 0x004C7847
		public IConnectorPathAdvanceVisual_UnionUnion()
		{
			this.Type = IConnectorPathAdvanceVisual_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022C1E RID: 142366 RVA: 0x004C965D File Offset: 0x004C785D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022C1F RID: 142367 RVA: 0x004C966F File Offset: 0x004C786F
		public IConnectorPathAdvanceVisualT AsIConnectorPathAdvanceVisual()
		{
			return this.As<IConnectorPathAdvanceVisualT>();
		}

		// Token: 0x06022C20 RID: 142368 RVA: 0x004C9677 File Offset: 0x004C7877
		public static IConnectorPathAdvanceVisual_UnionUnion FromIConnectorPathAdvanceVisual(IConnectorPathAdvanceVisualT _iconnectorpathadvancevisual)
		{
			return new IConnectorPathAdvanceVisual_UnionUnion
			{
				Type = IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVisual,
				Value = _iconnectorpathadvancevisual
			};
		}

		// Token: 0x06022C21 RID: 142369 RVA: 0x004C968C File Offset: 0x004C788C
		public IConnectorPathAdvanceVasePlantVisualT AsIConnectorPathAdvanceVasePlantVisual()
		{
			return this.As<IConnectorPathAdvanceVasePlantVisualT>();
		}

		// Token: 0x06022C22 RID: 142370 RVA: 0x004C9694 File Offset: 0x004C7894
		public static IConnectorPathAdvanceVisual_UnionUnion FromIConnectorPathAdvanceVasePlantVisual(IConnectorPathAdvanceVasePlantVisualT _iconnectorpathadvancevaseplantvisual)
		{
			return new IConnectorPathAdvanceVisual_UnionUnion
			{
				Type = IConnectorPathAdvanceVisual_Union.IConnectorPathAdvanceVasePlantVisual,
				Value = _iconnectorpathadvancevaseplantvisual
			};
		}

		// Token: 0x06022C23 RID: 142371 RVA: 0x004C96AC File Offset: 0x004C78AC
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
