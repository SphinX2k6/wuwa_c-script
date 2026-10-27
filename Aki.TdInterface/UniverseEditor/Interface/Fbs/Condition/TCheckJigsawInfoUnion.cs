using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D37 RID: 19767
	public class TCheckJigsawInfoUnion
	{
		// Token: 0x17008F3F RID: 36671
		// (get) Token: 0x0601F5F6 RID: 128502 RVA: 0x0045F786 File Offset: 0x0045D986
		// (set) Token: 0x0601F5F7 RID: 128503 RVA: 0x0045F78E File Offset: 0x0045D98E
		public TCheckJigsawInfo Type { get; set; }

		// Token: 0x17008F40 RID: 36672
		// (get) Token: 0x0601F5F8 RID: 128504 RVA: 0x0045F797 File Offset: 0x0045D997
		// (set) Token: 0x0601F5F9 RID: 128505 RVA: 0x0045F79F File Offset: 0x0045D99F
		public object Value { get; set; }

		// Token: 0x0601F5FA RID: 128506 RVA: 0x0045F7A8 File Offset: 0x0045D9A8
		public TCheckJigsawInfoUnion()
		{
			this.Type = TCheckJigsawInfo.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5FB RID: 128507 RVA: 0x0045F7BE File Offset: 0x0045D9BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5FC RID: 128508 RVA: 0x0045F7D0 File Offset: 0x0045D9D0
		public ICheckJigsawItemMoveT AsICheckJigsawItemMove()
		{
			return this.As<ICheckJigsawItemMoveT>();
		}

		// Token: 0x0601F5FD RID: 128509 RVA: 0x0045F7D8 File Offset: 0x0045D9D8
		public static TCheckJigsawInfoUnion FromICheckJigsawItemMove(ICheckJigsawItemMoveT _icheckjigsawitemmove)
		{
			return new TCheckJigsawInfoUnion
			{
				Type = TCheckJigsawInfo.ICheckJigsawItemMove,
				Value = _icheckjigsawitemmove
			};
		}

		// Token: 0x0601F5FE RID: 128510 RVA: 0x0045F7ED File Offset: 0x0045D9ED
		public ICheckJigsawItemPlaceIndexT AsICheckJigsawItemPlaceIndex()
		{
			return this.As<ICheckJigsawItemPlaceIndexT>();
		}

		// Token: 0x0601F5FF RID: 128511 RVA: 0x0045F7F5 File Offset: 0x0045D9F5
		public static TCheckJigsawInfoUnion FromICheckJigsawItemPlaceIndex(ICheckJigsawItemPlaceIndexT _icheckjigsawitemplaceindex)
		{
			return new TCheckJigsawInfoUnion
			{
				Type = TCheckJigsawInfo.ICheckJigsawItemPlaceIndex,
				Value = _icheckjigsawitemplaceindex
			};
		}

		// Token: 0x0601F600 RID: 128512 RVA: 0x0045F80C File Offset: 0x0045DA0C
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
