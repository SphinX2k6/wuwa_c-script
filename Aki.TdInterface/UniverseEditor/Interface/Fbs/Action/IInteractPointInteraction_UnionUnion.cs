using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A6 RID: 27046
	public class IInteractPointInteraction_UnionUnion
	{
		// Token: 0x1700C8A3 RID: 51363
		// (get) Token: 0x0602F40D RID: 193549 RVA: 0x0066FC8D File Offset: 0x0066DE8D
		// (set) Token: 0x0602F40E RID: 193550 RVA: 0x0066FC95 File Offset: 0x0066DE95
		public IInteractPointInteraction_Union Type { get; set; }

		// Token: 0x1700C8A4 RID: 51364
		// (get) Token: 0x0602F40F RID: 193551 RVA: 0x0066FC9E File Offset: 0x0066DE9E
		// (set) Token: 0x0602F410 RID: 193552 RVA: 0x0066FCA6 File Offset: 0x0066DEA6
		public object Value { get; set; }

		// Token: 0x0602F411 RID: 193553 RVA: 0x0066FCAF File Offset: 0x0066DEAF
		public IInteractPointInteraction_UnionUnion()
		{
			this.Type = IInteractPointInteraction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F412 RID: 193554 RVA: 0x0066FCC5 File Offset: 0x0066DEC5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F413 RID: 193555 RVA: 0x0066FCD7 File Offset: 0x0066DED7
		public IInteractPointInteractionT AsIInteractPointInteraction()
		{
			return this.As<IInteractPointInteractionT>();
		}

		// Token: 0x0602F414 RID: 193556 RVA: 0x0066FCDF File Offset: 0x0066DEDF
		public static IInteractPointInteraction_UnionUnion FromIInteractPointInteraction(IInteractPointInteractionT _iinteractpointinteraction)
		{
			return new IInteractPointInteraction_UnionUnion
			{
				Type = IInteractPointInteraction_Union.IInteractPointInteraction,
				Value = _iinteractpointinteraction
			};
		}

		// Token: 0x0602F415 RID: 193557 RVA: 0x0066FCF4 File Offset: 0x0066DEF4
		public IDragInteractPointInteractionT AsIDragInteractPointInteraction()
		{
			return this.As<IDragInteractPointInteractionT>();
		}

		// Token: 0x0602F416 RID: 193558 RVA: 0x0066FCFC File Offset: 0x0066DEFC
		public static IInteractPointInteraction_UnionUnion FromIDragInteractPointInteraction(IDragInteractPointInteractionT _idraginteractpointinteraction)
		{
			return new IInteractPointInteraction_UnionUnion
			{
				Type = IInteractPointInteraction_Union.IDragInteractPointInteraction,
				Value = _idraginteractpointinteraction
			};
		}

		// Token: 0x0602F417 RID: 193559 RVA: 0x0066FD14 File Offset: 0x0066DF14
		public static int Pack(FlatBufferBuilder builder, IInteractPointInteraction_UnionUnion _o)
		{
			IInteractPointInteraction_Union type = _o.Type;
			if (type == IInteractPointInteraction_Union.IInteractPointInteraction)
			{
				return IInteractPointInteraction.Pack(builder, _o.AsIInteractPointInteraction()).Value;
			}
			if (type != IInteractPointInteraction_Union.IDragInteractPointInteraction)
			{
				return 0;
			}
			return IDragInteractPointInteraction.Pack(builder, _o.AsIDragInteractPointInteraction()).Value;
		}
	}
}
