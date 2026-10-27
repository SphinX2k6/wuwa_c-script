using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C16 RID: 3094
	public struct DungeonPackInfo : IFlatbufferObject
	{
		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600669E RID: 26270 RVA: 0x0021DE5A File Offset: 0x0021C05A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x0021DE67 File Offset: 0x0021C067
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066A0 RID: 26272 RVA: 0x0021DE70 File Offset: 0x0021C070
		public static DungeonPackInfo GetRootAsDungeonPackInfo(ByteBuffer _bb)
		{
			return DungeonPackInfo.GetRootAsDungeonPackInfo(_bb, default(DungeonPackInfo));
		}

		// Token: 0x060066A1 RID: 26273 RVA: 0x0021DE8C File Offset: 0x0021C08C
		public static DungeonPackInfo GetRootAsDungeonPackInfo(ByteBuffer _bb, DungeonPackInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066A2 RID: 26274 RVA: 0x0021DEA9 File Offset: 0x0021C0A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066A3 RID: 26275 RVA: 0x0021DEB8 File Offset: 0x0021C0B8
		public DungeonPackInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x0021DEC8 File Offset: 0x0021C0C8
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0021DF04 File Offset: 0x0021C104
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

		// Token: 0x060066A6 RID: 26278 RVA: 0x0021DF3B File Offset: 0x0021C13B
		public Span<byte> GetUmapBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x0021DF4A File Offset: 0x0021C14A
		public byte[] GetUmapArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x0021DF64 File Offset: 0x0021C164
		public int OwnerBlockIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x0021DFA4 File Offset: 0x0021C1A4
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

		// Token: 0x060066AA RID: 26282 RVA: 0x0021DFCF File Offset: 0x0021C1CF
		public Span<int> GetOwnerBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x0021DFDE File Offset: 0x0021C1DE
		public int[] GetOwnerBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060066AC RID: 26284 RVA: 0x0021DFF8 File Offset: 0x0021C1F8
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

		// Token: 0x060066AD RID: 26285 RVA: 0x0021E030 File Offset: 0x0021C230
		public Span<byte> GetBlockPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x0021E040 File Offset: 0x0021C240
		public byte[] GetBlockPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0021E058 File Offset: 0x0021C258
		public int ReachableBlockIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060066B0 RID: 26288 RVA: 0x0021E098 File Offset: 0x0021C298
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

		// Token: 0x060066B1 RID: 26289 RVA: 0x0021E0C4 File Offset: 0x0021C2C4
		public Span<int> GetReachableBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x0021E0D4 File Offset: 0x0021C2D4
		public int[] GetReachableBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x0021E0EC File Offset: 0x0021C2EC
		public string ReachableUmaps(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060066B4 RID: 26292 RVA: 0x0021E128 File Offset: 0x0021C328
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

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060066B5 RID: 26293 RVA: 0x0021E154 File Offset: 0x0021C354
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

		// Token: 0x060066B6 RID: 26294 RVA: 0x0021E18C File Offset: 0x0021C38C
		public Span<byte> GetBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x0021E19C File Offset: 0x0021C39C
		public byte[] GetBranchArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x0021E1B4 File Offset: 0x0021C3B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OwnerBlockIdsIter()或GetOwnerBlockIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OwnerBlockIds()
		{
			DungeonPackInfo dungeonPackInfo = this;
			return dungeonPackInfo.GetOwnerBlockIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x0021E1D8 File Offset: 0x0021C3D8
		[NullableContext(1)]
		public readonly IEnumerable<int> OwnerBlockIdsIter()
		{
			DungeonPackInfo.<OwnerBlockIdsIter>d__36 <OwnerBlockIdsIter>d__ = new DungeonPackInfo.<OwnerBlockIdsIter>d__36(-2);
			<OwnerBlockIdsIter>d__.<>3__<>4__this = this;
			return <OwnerBlockIdsIter>d__;
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x0021E1F0 File Offset: 0x0021C3F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReachableBlockIdsIter()或GetReachableBlockIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReachableBlockIds()
		{
			DungeonPackInfo dungeonPackInfo = this;
			return dungeonPackInfo.GetReachableBlockIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x0021E214 File Offset: 0x0021C414
		[NullableContext(1)]
		public readonly IEnumerable<int> ReachableBlockIdsIter()
		{
			DungeonPackInfo.<ReachableBlockIdsIter>d__38 <ReachableBlockIdsIter>d__ = new DungeonPackInfo.<ReachableBlockIdsIter>d__38(-2);
			<ReachableBlockIdsIter>d__.<>3__<>4__this = this;
			return <ReachableBlockIdsIter>d__;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x0021E229 File Offset: 0x0021C429
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReachableUmapsIter()或GetReachableUmapsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ReachableUmaps()
		{
			return this.ReachableUmapsIter().ToArray<string>();
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0021E236 File Offset: 0x0021C436
		[NullableContext(1)]
		public readonly IEnumerable<string> ReachableUmapsIter()
		{
			DungeonPackInfo.<ReachableUmapsIter>d__40 <ReachableUmapsIter>d__ = new DungeonPackInfo.<ReachableUmapsIter>d__40(-2);
			<ReachableUmapsIter>d__.<>3__<>4__this = this;
			return <ReachableUmapsIter>d__;
		}

		// Token: 0x04004C56 RID: 19542
		private Table __p;
	}
}
