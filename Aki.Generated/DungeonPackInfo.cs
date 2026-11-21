using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF9 RID: 3321
	public struct DungeonPackInfo : IFlatbufferObject
	{
		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06006C91 RID: 27793 RVA: 0x0023D32E File Offset: 0x0023B52E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x0023D33B File Offset: 0x0023B53B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x0023D344 File Offset: 0x0023B544
		public static DungeonPackInfo GetRootAsDungeonPackInfo(ByteBuffer _bb)
		{
			return DungeonPackInfo.GetRootAsDungeonPackInfo(_bb, default(DungeonPackInfo));
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x0023D360 File Offset: 0x0023B560
		public static DungeonPackInfo GetRootAsDungeonPackInfo(ByteBuffer _bb, DungeonPackInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x0023D37D File Offset: 0x0023B57D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x0023D38C File Offset: 0x0023B58C
		public DungeonPackInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x0023D39C File Offset: 0x0023B59C
		public int DungeonId
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

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06006C98 RID: 27800 RVA: 0x0023D3D8 File Offset: 0x0023B5D8
		public string Umap
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x0023D40F File Offset: 0x0023B60F
		public Span<byte> GetUmapBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x0023D41E File Offset: 0x0023B61E
		public byte[] GetUmapArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x0023D438 File Offset: 0x0023B638
		public int OwnerBlockIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06006C9C RID: 27804 RVA: 0x0023D478 File Offset: 0x0023B678
		public int OwnerBlockIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x0023D4A3 File Offset: 0x0023B6A3
		public Span<int> GetOwnerBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x0023D4B2 File Offset: 0x0023B6B2
		public int[] GetOwnerBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x0023D4CC File Offset: 0x0023B6CC
		public string BlockPakName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x0023D504 File Offset: 0x0023B704
		public Span<byte> GetBlockPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x0023D514 File Offset: 0x0023B714
		public byte[] GetBlockPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x0023D52C File Offset: 0x0023B72C
		public int ReachableBlockIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x0023D56C File Offset: 0x0023B76C
		public int ReachableBlockIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x0023D598 File Offset: 0x0023B798
		public Span<int> GetReachableBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x0023D5A8 File Offset: 0x0023B7A8
		public int[] GetReachableBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x0023D5C0 File Offset: 0x0023B7C0
		public string ReachableUmaps(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x0023D5FC File Offset: 0x0023B7FC
		public int ReachableUmapsLength
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

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06006CA8 RID: 27816 RVA: 0x0023D628 File Offset: 0x0023B828
		public string Branch
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x0023D660 File Offset: 0x0023B860
		public Span<byte> GetBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x0023D670 File Offset: 0x0023B870
		public byte[] GetBranchArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006CAB RID: 27819 RVA: 0x0023D688 File Offset: 0x0023B888
		[NullableContext(1)]
		public int[] OwnerBlockIds()
		{
			return this.GetOwnerBlockIdsArray();
		}

		// Token: 0x06006CAC RID: 27820 RVA: 0x0023D690 File Offset: 0x0023B890
		[NullableContext(1)]
		public IEnumerable<int> OwnerBlockIdsIter()
		{
			DungeonPackInfo.<OwnerBlockIdsIter>d__36 <OwnerBlockIdsIter>d__ = new DungeonPackInfo.<OwnerBlockIdsIter>d__36(-2);
			<OwnerBlockIdsIter>d__.<>3__<>4__this = this;
			return <OwnerBlockIdsIter>d__;
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x0023D6A5 File Offset: 0x0023B8A5
		[NullableContext(1)]
		public int[] ReachableBlockIds()
		{
			return this.GetReachableBlockIdsArray();
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x0023D6AD File Offset: 0x0023B8AD
		[NullableContext(1)]
		public IEnumerable<int> ReachableBlockIdsIter()
		{
			DungeonPackInfo.<ReachableBlockIdsIter>d__38 <ReachableBlockIdsIter>d__ = new DungeonPackInfo.<ReachableBlockIdsIter>d__38(-2);
			<ReachableBlockIdsIter>d__.<>3__<>4__this = this;
			return <ReachableBlockIdsIter>d__;
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x0023D6C2 File Offset: 0x0023B8C2
		[NullableContext(1)]
		public string[] ReachableUmaps()
		{
			return this.ReachableUmapsIter().ToArray<string>();
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x0023D6CF File Offset: 0x0023B8CF
		[NullableContext(1)]
		public IEnumerable<string> ReachableUmapsIter()
		{
			DungeonPackInfo.<ReachableUmapsIter>d__40 <ReachableUmapsIter>d__ = new DungeonPackInfo.<ReachableUmapsIter>d__40(-2);
			<ReachableUmapsIter>d__.<>3__<>4__this = this;
			return <ReachableUmapsIter>d__;
		}

		// Token: 0x04005239 RID: 21049
		private Table __p;
	}
}
