using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED0 RID: 3792
	public struct MapBorder : IFlatbufferObject
	{
		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x0029BE0A File Offset: 0x0029A00A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096EA RID: 38634 RVA: 0x0029BE17 File Offset: 0x0029A017
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x0029BE20 File Offset: 0x0029A020
		public static MapBorder GetRootAsMapBorder(ByteBuffer _bb)
		{
			return MapBorder.GetRootAsMapBorder(_bb, default(MapBorder));
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x0029BE3C File Offset: 0x0029A03C
		public static MapBorder GetRootAsMapBorder(ByteBuffer _bb, MapBorder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x0029BE59 File Offset: 0x0029A059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x0029BE68 File Offset: 0x0029A068
		public MapBorder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x060096EF RID: 38639 RVA: 0x0029BE78 File Offset: 0x0029A078
		public int BorderId
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

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x060096F0 RID: 38640 RVA: 0x0029BEB4 File Offset: 0x0029A0B4
		public int MapId
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

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x060096F1 RID: 38641 RVA: 0x0029BEF0 File Offset: 0x0029A0F0
		public int InstanceDungeonId
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

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x060096F2 RID: 38642 RVA: 0x0029BF2C File Offset: 0x0029A12C
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x060096F3 RID: 38643 RVA: 0x0029BF6C File Offset: 0x0029A16C
		public int InstanceDungeonIdMapType
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

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x060096F4 RID: 38644 RVA: 0x0029BFAC File Offset: 0x0029A1AC
		public int ConditionId
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

		// Token: 0x060096F5 RID: 38645 RVA: 0x0029BFEC File Offset: 0x0029A1EC
		public string PrefabPaths(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x060096F6 RID: 38646 RVA: 0x0029C028 File Offset: 0x0029A228
		public int PrefabPathsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x0029C054 File Offset: 0x0029A254
		[NullableContext(1)]
		public string[] PrefabPaths()
		{
			return this.PrefabPathsIter().ToArray<string>();
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x0029C061 File Offset: 0x0029A261
		[NullableContext(1)]
		public IEnumerable<string> PrefabPathsIter()
		{
			MapBorder.<PrefabPathsIter>d__24 <PrefabPathsIter>d__ = new MapBorder.<PrefabPathsIter>d__24(-2);
			<PrefabPathsIter>d__.<>3__<>4__this = this;
			return <PrefabPathsIter>d__;
		}

		// Token: 0x0400546C RID: 21612
		private Table __p;
	}
}
