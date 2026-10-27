using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C29 RID: 3113
	public struct ElementReactionMatrix : IFlatbufferObject
	{
		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06006859 RID: 26713 RVA: 0x0022195F File Offset: 0x0021FB5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x0022196C File Offset: 0x0021FB6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x00221974 File Offset: 0x0021FB74
		public static ElementReactionMatrix GetRootAsElementReactionMatrix(ByteBuffer _bb)
		{
			return ElementReactionMatrix.GetRootAsElementReactionMatrix(_bb, default(ElementReactionMatrix));
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00221990 File Offset: 0x0021FB90
		public static ElementReactionMatrix GetRootAsElementReactionMatrix(ByteBuffer _bb, ElementReactionMatrix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x002219AD File Offset: 0x0021FBAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x002219BC File Offset: 0x0021FBBC
		public ElementReactionMatrix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x0600685F RID: 26719 RVA: 0x002219CC File Offset: 0x0021FBCC
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

		// Token: 0x06006860 RID: 26720 RVA: 0x00221A08 File Offset: 0x0021FC08
		public int ElementReactionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x00221A48 File Offset: 0x0021FC48
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

		// Token: 0x06006862 RID: 26722 RVA: 0x00221A73 File Offset: 0x0021FC73
		public Span<int> GetElementReactionListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00221A82 File Offset: 0x0021FC82
		public int[] GetElementReactionListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x00221A9C File Offset: 0x0021FC9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ElementReactionListIter()或GetElementReactionListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ElementReactionList()
		{
			ElementReactionMatrix elementReactionMatrix = this;
			return elementReactionMatrix.GetElementReactionListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x00221AC0 File Offset: 0x0021FCC0
		[NullableContext(1)]
		public readonly IEnumerable<int> ElementReactionListIter()
		{
			ElementReactionMatrix.<ElementReactionListIter>d__16 <ElementReactionListIter>d__ = new ElementReactionMatrix.<ElementReactionListIter>d__16(-2);
			<ElementReactionListIter>d__.<>3__<>4__this = this;
			return <ElementReactionListIter>d__;
		}

		// Token: 0x04004C69 RID: 19561
		private Table __p;
	}
}
