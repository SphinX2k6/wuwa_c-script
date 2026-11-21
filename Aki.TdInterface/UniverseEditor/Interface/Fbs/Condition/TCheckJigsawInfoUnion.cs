using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005233 RID: 21043
	public class TCheckJigsawInfoUnion
	{
		// Token: 0x17009678 RID: 38520
		// (get) Token: 0x0602123D RID: 135741 RVA: 0x00493716 File Offset: 0x00491916
		// (set) Token: 0x0602123E RID: 135742 RVA: 0x0049371E File Offset: 0x0049191E
		public TCheckJigsawInfo Type { get; set; }

		// Token: 0x17009679 RID: 38521
		// (get) Token: 0x0602123F RID: 135743 RVA: 0x00493727 File Offset: 0x00491927
		// (set) Token: 0x06021240 RID: 135744 RVA: 0x0049372F File Offset: 0x0049192F
		public object Value { get; set; }

		// Token: 0x06021241 RID: 135745 RVA: 0x00493738 File Offset: 0x00491938
		public TCheckJigsawInfoUnion()
		{
			this.Type = TCheckJigsawInfo.NONE;
			this.Value = null;
		}

		// Token: 0x06021242 RID: 135746 RVA: 0x0049374E File Offset: 0x0049194E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021243 RID: 135747 RVA: 0x00493760 File Offset: 0x00491960
		public ICheckJigsawItemMoveT AsICheckJigsawItemMove()
		{
			return this.As<ICheckJigsawItemMoveT>();
		}

		// Token: 0x06021244 RID: 135748 RVA: 0x00493768 File Offset: 0x00491968
		public static TCheckJigsawInfoUnion FromICheckJigsawItemMove(ICheckJigsawItemMoveT _icheckjigsawitemmove)
		{
			return new TCheckJigsawInfoUnion
			{
				Type = TCheckJigsawInfo.ICheckJigsawItemMove,
				Value = _icheckjigsawitemmove
			};
		}

		// Token: 0x06021245 RID: 135749 RVA: 0x0049377D File Offset: 0x0049197D
		public ICheckJigsawItemPlaceIndexT AsICheckJigsawItemPlaceIndex()
		{
			return this.As<ICheckJigsawItemPlaceIndexT>();
		}

		// Token: 0x06021246 RID: 135750 RVA: 0x00493785 File Offset: 0x00491985
		public static TCheckJigsawInfoUnion FromICheckJigsawItemPlaceIndex(ICheckJigsawItemPlaceIndexT _icheckjigsawitemplaceindex)
		{
			return new TCheckJigsawInfoUnion
			{
				Type = TCheckJigsawInfo.ICheckJigsawItemPlaceIndex,
				Value = _icheckjigsawitemplaceindex
			};
		}

		// Token: 0x06021247 RID: 135751 RVA: 0x0049379C File Offset: 0x0049199C
		public static int Pack(FlatBufferBuilder builder, TCheckJigsawInfoUnion _o)
		{
			TCheckJigsawInfo type = _o.Type;
			if (type == TCheckJigsawInfo.ICheckJigsawItemMove)
			{
				return ICheckJigsawItemMove.Pack(builder, _o.AsICheckJigsawItemMove()).Value;
			}
			if (type != TCheckJigsawInfo.ICheckJigsawItemPlaceIndex)
			{
				return 0;
			}
			return ICheckJigsawItemPlaceIndex.Pack(builder, _o.AsICheckJigsawItemPlaceIndex()).Value;
		}
	}
}
