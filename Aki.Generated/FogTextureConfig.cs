using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC8 RID: 3272
	public struct FogTextureConfig : IFlatbufferObject
	{
		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060075F6 RID: 30198 RVA: 0x00241119 File Offset: 0x0023F319
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00241126 File Offset: 0x0023F326
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00241130 File Offset: 0x0023F330
		public static FogTextureConfig GetRootAsFogTextureConfig(ByteBuffer _bb)
		{
			return FogTextureConfig.GetRootAsFogTextureConfig(_bb, default(FogTextureConfig));
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x0024114C File Offset: 0x0023F34C
		public static FogTextureConfig GetRootAsFogTextureConfig(ByteBuffer _bb, FogTextureConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00241169 File Offset: 0x0023F369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00241178 File Offset: 0x0023F378
		public FogTextureConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060075FC RID: 30204 RVA: 0x00241188 File Offset: 0x0023F388
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x002411BF File Offset: 0x0023F3BF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x002411CE File Offset: 0x0023F3CE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060075FF RID: 30207 RVA: 0x002411E8 File Offset: 0x0023F3E8
		public string Block
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

		// Token: 0x06007600 RID: 30208 RVA: 0x0024121F File Offset: 0x0023F41F
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x0024122E File Offset: 0x0023F42E
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x00241248 File Offset: 0x0023F448
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06007603 RID: 30211 RVA: 0x00241284 File Offset: 0x0023F484
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

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x002412C4 File Offset: 0x0023F4C4
		public string MapTilePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x002412FC File Offset: 0x0023F4FC
		public Span<byte> GetMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x0024130C File Offset: 0x0023F50C
		public byte[] GetMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x06007607 RID: 30215 RVA: 0x00241324 File Offset: 0x0023F524
		public string MiniMapTilePath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x0024135C File Offset: 0x0023F55C
		public Span<byte> GetMiniMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x0024136C File Offset: 0x0023F56C
		public byte[] GetMiniMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600760A RID: 30218 RVA: 0x00241384 File Offset: 0x0023F584
		public string HdMapTilePath
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

		// Token: 0x0600760B RID: 30219 RVA: 0x002413BC File Offset: 0x0023F5BC
		public Span<byte> GetHdMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x002413CC File Offset: 0x0023F5CC
		public byte[] GetHdMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600760D RID: 30221 RVA: 0x002413E4 File Offset: 0x0023F5E4
		public string FogTilePath
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

		// Token: 0x0600760E RID: 30222 RVA: 0x0024141C File Offset: 0x0023F61C
		public Span<byte> GetFogTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x0024142C File Offset: 0x0023F62C
		public byte[] GetFogTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06007610 RID: 30224 RVA: 0x00241444 File Offset: 0x0023F644
		public string MiniFogTilePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x0024147C File Offset: 0x0023F67C
		public Span<byte> GetMiniFogTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x0024148C File Offset: 0x0023F68C
		public byte[] GetMiniFogTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x06007613 RID: 30227 RVA: 0x002414A4 File Offset: 0x0023F6A4
		public int SubMapGroupId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x002414E4 File Offset: 0x0023F6E4
		public int TileLoadFilterByArea(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x06007615 RID: 30229 RVA: 0x00241524 File Offset: 0x0023F724
		public int TileLoadFilterByAreaLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00241550 File Offset: 0x0023F750
		public Span<int> GetTileLoadFilterByAreaBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00241560 File Offset: 0x0023F760
		public int[] GetTileLoadFilterByAreaArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00241578 File Offset: 0x0023F778
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TileLoadFilterByAreaIter()或GetTileLoadFilterByAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TileLoadFilterByArea()
		{
			FogTextureConfig fogTextureConfig = this;
			return fogTextureConfig.GetTileLoadFilterByAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x0024159C File Offset: 0x0023F79C
		[NullableContext(1)]
		public readonly IEnumerable<int> TileLoadFilterByAreaIter()
		{
			FogTextureConfig.<TileLoadFilterByAreaIter>d__48 <TileLoadFilterByAreaIter>d__ = new FogTextureConfig.<TileLoadFilterByAreaIter>d__48(-2);
			<TileLoadFilterByAreaIter>d__.<>3__<>4__this = this;
			return <TileLoadFilterByAreaIter>d__;
		}

		// Token: 0x04004D38 RID: 19768
		private Table __p;
	}
}
