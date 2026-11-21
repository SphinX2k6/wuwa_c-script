using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D7 RID: 30679
	public class ISetJigsawFoundationType_UnionUnion
	{
		// Token: 0x1700E0DD RID: 57565
		// (get) Token: 0x06035E39 RID: 220729 RVA: 0x007384F9 File Offset: 0x007366F9
		// (set) Token: 0x06035E3A RID: 220730 RVA: 0x00738501 File Offset: 0x00736701
		public ISetJigsawFoundationType_Union Type { get; set; }

		// Token: 0x1700E0DE RID: 57566
		// (get) Token: 0x06035E3B RID: 220731 RVA: 0x0073850A File Offset: 0x0073670A
		// (set) Token: 0x06035E3C RID: 220732 RVA: 0x00738512 File Offset: 0x00736712
		public object Value { get; set; }

		// Token: 0x06035E3D RID: 220733 RVA: 0x0073851B File Offset: 0x0073671B
		public ISetJigsawFoundationType_UnionUnion()
		{
			this.Type = ISetJigsawFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035E3E RID: 220734 RVA: 0x00738531 File Offset: 0x00736731
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035E3F RID: 220735 RVA: 0x00738543 File Offset: 0x00736743
		public ISetJigsawFoundationTypeT AsISetJigsawFoundationType()
		{
			return this.As<ISetJigsawFoundationTypeT>();
		}

		// Token: 0x06035E40 RID: 220736 RVA: 0x0073854B File Offset: 0x0073674B
		public static ISetJigsawFoundationType_UnionUnion FromISetJigsawFoundationType(ISetJigsawFoundationTypeT _isetjigsawfoundationtype)
		{
			return new ISetJigsawFoundationType_UnionUnion
			{
				Type = ISetJigsawFoundationType_Union.ISetJigsawFoundationType,
				Value = _isetjigsawfoundationtype
			};
		}

		// Token: 0x06035E41 RID: 220737 RVA: 0x00738560 File Offset: 0x00736760
		public ISetPieceStateT AsISetPieceState()
		{
			return this.As<ISetPieceStateT>();
		}

		// Token: 0x06035E42 RID: 220738 RVA: 0x00738568 File Offset: 0x00736768
		public static ISetJigsawFoundationType_UnionUnion FromISetPieceState(ISetPieceStateT _isetpiecestate)
		{
			return new ISetJigsawFoundationType_UnionUnion
			{
				Type = ISetJigsawFoundationType_Union.ISetPieceState,
				Value = _isetpiecestate
			};
		}

		// Token: 0x06035E43 RID: 220739 RVA: 0x00738580 File Offset: 0x00736780
		public static int Pack(FlatBufferBuilder builder, ISetJigsawFoundationType_UnionUnion _o)
		{
			ISetJigsawFoundationType_Union type = _o.Type;
			if (type == ISetJigsawFoundationType_Union.ISetJigsawFoundationType)
			{
				return ISetJigsawFoundationType.Pack(builder, _o.AsISetJigsawFoundationType()).Value;
			}
			if (type != ISetJigsawFoundationType_Union.ISetPieceState)
			{
				return 0;
			}
			return ISetPieceState.Pack(builder, _o.AsISetPieceState()).Value;
		}
	}
}
