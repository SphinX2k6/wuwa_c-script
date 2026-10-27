using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA9 RID: 3753
	public struct OverlayMap : IFlatbufferObject
	{
		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600A259 RID: 41561 RVA: 0x002A4EC8 File Offset: 0x002A30C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x002A4ED5 File Offset: 0x002A30D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x002A4EDC File Offset: 0x002A30DC
		public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb)
		{
			return OverlayMap.GetRootAsOverlayMap(_bb, default(OverlayMap));
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x002A4EF8 File Offset: 0x002A30F8
		public static OverlayMap GetRootAsOverlayMap(ByteBuffer _bb, OverlayMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x002A4F15 File Offset: 0x002A3115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x002A4F24 File Offset: 0x002A3124
		public OverlayMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600A25F RID: 41567 RVA: 0x002A4F34 File Offset: 0x002A3134
		public int OverlayMapId
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

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600A260 RID: 41568 RVA: 0x002A4F70 File Offset: 0x002A3170
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

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600A261 RID: 41569 RVA: 0x002A4FAC File Offset: 0x002A31AC
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x002A4FE8 File Offset: 0x002A31E8
		public string MapAddress
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

		// Token: 0x0600A263 RID: 41571 RVA: 0x002A5020 File Offset: 0x002A3220
		public Span<byte> GetMapAddressBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x002A5030 File Offset: 0x002A3230
		public byte[] GetMapAddressArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x002A5048 File Offset: 0x002A3248
		public int MapPos(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x002A5088 File Offset: 0x002A3288
		public int MapPosLength
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

		// Token: 0x0600A267 RID: 41575 RVA: 0x002A50B4 File Offset: 0x002A32B4
		public Span<int> GetMapPosBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x002A50C4 File Offset: 0x002A32C4
		public int[] GetMapPosArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600A269 RID: 41577 RVA: 0x002A50DC File Offset: 0x002A32DC
		public int Rotation
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

		// Token: 0x0600A26A RID: 41578 RVA: 0x002A511C File Offset: 0x002A331C
		public int WidthHeight(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600A26B RID: 41579 RVA: 0x002A515C File Offset: 0x002A335C
		public int WidthHeightLength
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

		// Token: 0x0600A26C RID: 41580 RVA: 0x002A5188 File Offset: 0x002A3388
		public Span<int> GetWidthHeightBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x002A5198 File Offset: 0x002A3398
		public int[] GetWidthHeightArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x002A51B0 File Offset: 0x002A33B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MapPosIter()或GetMapPosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MapPos()
		{
			OverlayMap overlayMap = this;
			return overlayMap.GetMapPosArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x002A51D4 File Offset: 0x002A33D4
		[NullableContext(1)]
		public readonly IEnumerable<int> MapPosIter()
		{
			OverlayMap.<MapPosIter>d__31 <MapPosIter>d__ = new OverlayMap.<MapPosIter>d__31(-2);
			<MapPosIter>d__.<>3__<>4__this = this;
			return <MapPosIter>d__;
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x002A51EC File Offset: 0x002A33EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WidthHeightIter()或GetWidthHeightBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WidthHeight()
		{
			OverlayMap overlayMap = this;
			return overlayMap.GetWidthHeightArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x002A5210 File Offset: 0x002A3410
		[NullableContext(1)]
		public readonly IEnumerable<int> WidthHeightIter()
		{
			OverlayMap.<WidthHeightIter>d__33 <WidthHeightIter>d__ = new OverlayMap.<WidthHeightIter>d__33(-2);
			<WidthHeightIter>d__.<>3__<>4__this = this;
			return <WidthHeightIter>d__;
		}

		// Token: 0x04004F5E RID: 20318
		private Table __p;
	}
}
