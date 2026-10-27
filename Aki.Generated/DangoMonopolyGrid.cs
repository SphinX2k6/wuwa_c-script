using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD9 RID: 3033
	public struct DangoMonopolyGrid : IFlatbufferObject
	{
		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x0020F9C8 File Offset: 0x0020DBC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x0020F9D5 File Offset: 0x0020DBD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x0020F9DC File Offset: 0x0020DBDC
		public static DangoMonopolyGrid GetRootAsDangoMonopolyGrid(ByteBuffer _bb)
		{
			return DangoMonopolyGrid.GetRootAsDangoMonopolyGrid(_bb, default(DangoMonopolyGrid));
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x0020F9F8 File Offset: 0x0020DBF8
		public static DangoMonopolyGrid GetRootAsDangoMonopolyGrid(ByteBuffer _bb, DangoMonopolyGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x0020FA15 File Offset: 0x0020DC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x0020FA24 File Offset: 0x0020DC24
		public DangoMonopolyGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x0020FA34 File Offset: 0x0020DC34
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x0020FA70 File Offset: 0x0020DC70
		public int GridId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x0020FAAC File Offset: 0x0020DCAC
		public int GridGroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x0020FAE8 File Offset: 0x0020DCE8
		public int GridInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600607E RID: 24702 RVA: 0x0020FB28 File Offset: 0x0020DD28
		public int GridInfoLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x0020FB54 File Offset: 0x0020DD54
		public Span<int> GetGridInfoBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x0020FB64 File Offset: 0x0020DD64
		public int[] GetGridInfoArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x0020FB7C File Offset: 0x0020DD7C
		public int AddPropertyId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06006082 RID: 24706 RVA: 0x0020FBBC File Offset: 0x0020DDBC
		public int RemovePropertyId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x0020FBFC File Offset: 0x0020DDFC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GridInfoIter()或GetGridInfoBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GridInfo()
		{
			DangoMonopolyGrid dangoMonopolyGrid = this;
			return dangoMonopolyGrid.GetGridInfoArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x0020FC20 File Offset: 0x0020DE20
		[NullableContext(1)]
		public readonly IEnumerable<int> GridInfoIter()
		{
			DangoMonopolyGrid.<GridInfoIter>d__24 <GridInfoIter>d__ = new DangoMonopolyGrid.<GridInfoIter>d__24(-2);
			<GridInfoIter>d__.<>3__<>4__this = this;
			return <GridInfoIter>d__;
		}

		// Token: 0x04004C06 RID: 19462
		private Table __p;
	}
}
