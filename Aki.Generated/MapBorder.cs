using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEB RID: 3563
	public struct MapBorder : IFlatbufferObject
	{
		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x060090CD RID: 37069 RVA: 0x0027DB8A File Offset: 0x0027BD8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x0027DB97 File Offset: 0x0027BD97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x0027DBA0 File Offset: 0x0027BDA0
		public static MapBorder GetRootAsMapBorder(ByteBuffer _bb)
		{
			return MapBorder.GetRootAsMapBorder(_bb, default(MapBorder));
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x0027DBBC File Offset: 0x0027BDBC
		public static MapBorder GetRootAsMapBorder(ByteBuffer _bb, MapBorder obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x0027DBD9 File Offset: 0x0027BDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x0027DBE8 File Offset: 0x0027BDE8
		public MapBorder __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x060090D3 RID: 37075 RVA: 0x0027DBF8 File Offset: 0x0027BDF8
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x060090D4 RID: 37076 RVA: 0x0027DC34 File Offset: 0x0027BE34
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

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x060090D5 RID: 37077 RVA: 0x0027DC70 File Offset: 0x0027BE70
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

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x060090D6 RID: 37078 RVA: 0x0027DCAC File Offset: 0x0027BEAC
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

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x060090D7 RID: 37079 RVA: 0x0027DCEC File Offset: 0x0027BEEC
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

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x060090D8 RID: 37080 RVA: 0x0027DD2C File Offset: 0x0027BF2C
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

		// Token: 0x060090D9 RID: 37081 RVA: 0x0027DD6C File Offset: 0x0027BF6C
		public string PrefabPaths(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x060090DA RID: 37082 RVA: 0x0027DDA8 File Offset: 0x0027BFA8
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

		// Token: 0x060090DB RID: 37083 RVA: 0x0027DDD4 File Offset: 0x0027BFD4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PrefabPathsIter()或GetPrefabPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] PrefabPaths()
		{
			return this.PrefabPathsIter().ToArray<string>();
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x0027DDE1 File Offset: 0x0027BFE1
		[NullableContext(1)]
		public readonly IEnumerable<string> PrefabPathsIter()
		{
			MapBorder.<PrefabPathsIter>d__24 <PrefabPathsIter>d__ = new MapBorder.<PrefabPathsIter>d__24(-2);
			<PrefabPathsIter>d__.<>3__<>4__this = this;
			return <PrefabPathsIter>d__;
		}

		// Token: 0x04004E87 RID: 20103
		private Table __p;
	}
}
