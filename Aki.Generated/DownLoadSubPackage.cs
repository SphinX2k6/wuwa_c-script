using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDB RID: 3291
	public struct DownLoadSubPackage : IFlatbufferObject
	{
		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x00234460 File Offset: 0x00232660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x0023446D File Offset: 0x0023266D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00234474 File Offset: 0x00232674
		public static DownLoadSubPackage GetRootAsDownLoadSubPackage(ByteBuffer _bb)
		{
			return DownLoadSubPackage.GetRootAsDownLoadSubPackage(_bb, default(DownLoadSubPackage));
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00234490 File Offset: 0x00232690
		public static DownLoadSubPackage GetRootAsDownLoadSubPackage(ByteBuffer _bb, DownLoadSubPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x002344AD File Offset: 0x002326AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x002344BC File Offset: 0x002326BC
		public DownLoadSubPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x002344CC File Offset: 0x002326CC
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

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x00234508 File Offset: 0x00232708
		public int Version
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

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x00234544 File Offset: 0x00232744
		public int SortId
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x00234580 File Offset: 0x00232780
		public int Type
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060068D5 RID: 26837 RVA: 0x002345C0 File Offset: 0x002327C0
		public int BelongBranch
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00234600 File Offset: 0x00232800
		public int Area(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060068D7 RID: 26839 RVA: 0x00234640 File Offset: 0x00232840
		public int AreaLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x0023466C File Offset: 0x0023286C
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x0023467C File Offset: 0x0023287C
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x00234694 File Offset: 0x00232894
		public bool BelongKey
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060068DB RID: 26843 RVA: 0x002346D4 File Offset: 0x002328D4
		public string Title
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x0023470C File Offset: 0x0023290C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x0023471C File Offset: 0x0023291C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x00234734 File Offset: 0x00232934
		[NullableContext(1)]
		public int[] Area()
		{
			return this.GetAreaArray();
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x0023473C File Offset: 0x0023293C
		[NullableContext(1)]
		public IEnumerable<int> AreaIter()
		{
			DownLoadSubPackage.<AreaIter>d__30 <AreaIter>d__ = new DownLoadSubPackage.<AreaIter>d__30(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x04005208 RID: 21000
		private Table __p;
	}
}
