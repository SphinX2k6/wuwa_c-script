using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0C RID: 3340
	public struct ElementReactionMatrix : IFlatbufferObject
	{
		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x00240EC7 File Offset: 0x0023F0C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x00240ED4 File Offset: 0x0023F0D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00240EDC File Offset: 0x0023F0DC
		public static ElementReactionMatrix GetRootAsElementReactionMatrix(ByteBuffer _bb)
		{
			return ElementReactionMatrix.GetRootAsElementReactionMatrix(_bb, default(ElementReactionMatrix));
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x00240EF8 File Offset: 0x0023F0F8
		public static ElementReactionMatrix GetRootAsElementReactionMatrix(ByteBuffer _bb, ElementReactionMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x00240F15 File Offset: 0x0023F115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x00240F24 File Offset: 0x0023F124
		public ElementReactionMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x00240F34 File Offset: 0x0023F134
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x00240F70 File Offset: 0x0023F170
		public int ElementReactionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x00240FB0 File Offset: 0x0023F1B0
		public int ElementReactionListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006E64 RID: 28260 RVA: 0x00240FDB File Offset: 0x0023F1DB
		public Span<int> GetElementReactionListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006E65 RID: 28261 RVA: 0x00240FEA File Offset: 0x0023F1EA
		public int[] GetElementReactionListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x00241001 File Offset: 0x0023F201
		[NullableContext(1)]
		public int[] ElementReactionList()
		{
			return this.GetElementReactionListArray();
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x00241009 File Offset: 0x0023F209
		[NullableContext(1)]
		public IEnumerable<int> ElementReactionListIter()
		{
			ElementReactionMatrix.<ElementReactionListIter>d__16 <ElementReactionListIter>d__ = new ElementReactionMatrix.<ElementReactionListIter>d__16(-2);
			<ElementReactionListIter>d__.<>3__<>4__this = this;
			return <ElementReactionListIter>d__;
		}

		// Token: 0x0400524C RID: 21068
		private Table __p;
	}
}
