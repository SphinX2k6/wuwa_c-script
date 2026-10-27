using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200700E RID: 28686
	public class ISetJigsawFoundationType_UnionUnion
	{
		// Token: 0x1700D509 RID: 54537
		// (get) Token: 0x06032BD3 RID: 207827 RVA: 0x006D88B5 File Offset: 0x006D6AB5
		// (set) Token: 0x06032BD4 RID: 207828 RVA: 0x006D88BD File Offset: 0x006D6ABD
		public ISetJigsawFoundationType_Union Type { get; set; }

		// Token: 0x1700D50A RID: 54538
		// (get) Token: 0x06032BD5 RID: 207829 RVA: 0x006D88C6 File Offset: 0x006D6AC6
		// (set) Token: 0x06032BD6 RID: 207830 RVA: 0x006D88CE File Offset: 0x006D6ACE
		public object Value { get; set; }

		// Token: 0x06032BD7 RID: 207831 RVA: 0x006D88D7 File Offset: 0x006D6AD7
		public ISetJigsawFoundationType_UnionUnion()
		{
			this.Type = ISetJigsawFoundationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032BD8 RID: 207832 RVA: 0x006D88ED File Offset: 0x006D6AED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032BD9 RID: 207833 RVA: 0x006D88FF File Offset: 0x006D6AFF
		public ISetJigsawFoundationTypeT AsISetJigsawFoundationType()
		{
			return this.As<ISetJigsawFoundationTypeT>();
		}

		// Token: 0x06032BDA RID: 207834 RVA: 0x006D8907 File Offset: 0x006D6B07
		public static ISetJigsawFoundationType_UnionUnion FromISetJigsawFoundationType(ISetJigsawFoundationTypeT _isetjigsawfoundationtype)
		{
			return new ISetJigsawFoundationType_UnionUnion
			{
				Type = ISetJigsawFoundationType_Union.ISetJigsawFoundationType,
				Value = _isetjigsawfoundationtype
			};
		}

		// Token: 0x06032BDB RID: 207835 RVA: 0x006D891C File Offset: 0x006D6B1C
		public ISetPieceStateT AsISetPieceState()
		{
			return this.As<ISetPieceStateT>();
		}

		// Token: 0x06032BDC RID: 207836 RVA: 0x006D8924 File Offset: 0x006D6B24
		public static ISetJigsawFoundationType_UnionUnion FromISetPieceState(ISetPieceStateT _isetpiecestate)
		{
			return new ISetJigsawFoundationType_UnionUnion
			{
				Type = ISetJigsawFoundationType_Union.ISetPieceState,
				Value = _isetpiecestate
			};
		}

		// Token: 0x06032BDD RID: 207837 RVA: 0x006D893C File Offset: 0x006D6B3C
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
