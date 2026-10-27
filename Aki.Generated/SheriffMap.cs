using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A1 RID: 4257
	public struct SheriffMap : IFlatbufferObject
	{
		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600D103 RID: 53507 RVA: 0x0030D0A9 File Offset: 0x0030B2A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x0030D0B6 File Offset: 0x0030B2B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x0030D0C0 File Offset: 0x0030B2C0
		public static SheriffMap GetRootAsSheriffMap(ByteBuffer _bb)
		{
			return SheriffMap.GetRootAsSheriffMap(_bb, default(SheriffMap));
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x0030D0DC File Offset: 0x0030B2DC
		public static SheriffMap GetRootAsSheriffMap(ByteBuffer _bb, SheriffMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x0030D0F9 File Offset: 0x0030B2F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x0030D108 File Offset: 0x0030B308
		public SheriffMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600D109 RID: 53513 RVA: 0x0030D118 File Offset: 0x0030B318
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

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600D10A RID: 53514 RVA: 0x0030D154 File Offset: 0x0030B354
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

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600D10B RID: 53515 RVA: 0x0030D190 File Offset: 0x0030B390
		public string MapName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D10C RID: 53516 RVA: 0x0030D1C7 File Offset: 0x0030B3C7
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D10D RID: 53517 RVA: 0x0030D1D6 File Offset: 0x0030B3D6
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600D10E RID: 53518 RVA: 0x0030D1F0 File Offset: 0x0030B3F0
		public int BigMapDefaultScale
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

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600D10F RID: 53519 RVA: 0x0030D230 File Offset: 0x0030B430
		public int BigMapMinScale
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600D110 RID: 53520 RVA: 0x0030D270 File Offset: 0x0030B470
		public int BigMapMaxScale
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

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600D111 RID: 53521 RVA: 0x0030D2B0 File Offset: 0x0030B4B0
		public int QuestMapDefaultScale
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600D112 RID: 53522 RVA: 0x0030D2F0 File Offset: 0x0030B4F0
		public int QuestMapMinScale
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600D113 RID: 53523 RVA: 0x0030D330 File Offset: 0x0030B530
		public int QuestMapMaxScale
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x0030D370 File Offset: 0x0030B570
		public string TileRange(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600D115 RID: 53525 RVA: 0x0030D3AC File Offset: 0x0030B5AC
		public int TileRangeLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x0030D3D8 File Offset: 0x0030B5D8
		public int UnlockFogs(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600D117 RID: 53527 RVA: 0x0030D418 File Offset: 0x0030B618
		public int UnlockFogsLength
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

		// Token: 0x0600D118 RID: 53528 RVA: 0x0030D444 File Offset: 0x0030B644
		public Span<int> GetUnlockFogsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x0030D454 File Offset: 0x0030B654
		public int[] GetUnlockFogsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x0030D46C File Offset: 0x0030B66C
		public int ExtraMarkIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600D11B RID: 53531 RVA: 0x0030D4AC File Offset: 0x0030B6AC
		public int ExtraMarkIdsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D11C RID: 53532 RVA: 0x0030D4D8 File Offset: 0x0030B6D8
		public Span<int> GetExtraMarkIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x0030D4E8 File Offset: 0x0030B6E8
		public int[] GetExtraMarkIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600D11E RID: 53534 RVA: 0x0030D500 File Offset: 0x0030B700
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraMarkIdsIter()或GetExtraMarkIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraMarkIds()
		{
			SheriffMap sheriffMap = this;
			return sheriffMap.GetExtraMarkIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D11F RID: 53535 RVA: 0x0030D524 File Offset: 0x0030B724
		[NullableContext(1)]
		public readonly IEnumerable<int> ExtraMarkIdsIter()
		{
			SheriffMap.<ExtraMarkIdsIter>d__42 <ExtraMarkIdsIter>d__ = new SheriffMap.<ExtraMarkIdsIter>d__42(-2);
			<ExtraMarkIdsIter>d__.<>3__<>4__this = this;
			return <ExtraMarkIdsIter>d__;
		}

		// Token: 0x0600D120 RID: 53536 RVA: 0x0030D539 File Offset: 0x0030B739
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TileRangeIter()或GetTileRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TileRange()
		{
			return this.TileRangeIter().ToArray<string>();
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x0030D546 File Offset: 0x0030B746
		[NullableContext(1)]
		public readonly IEnumerable<string> TileRangeIter()
		{
			SheriffMap.<TileRangeIter>d__44 <TileRangeIter>d__ = new SheriffMap.<TileRangeIter>d__44(-2);
			<TileRangeIter>d__.<>3__<>4__this = this;
			return <TileRangeIter>d__;
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x0030D55C File Offset: 0x0030B75C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockFogsIter()或GetUnlockFogsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockFogs()
		{
			SheriffMap sheriffMap = this;
			return sheriffMap.GetUnlockFogsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x0030D580 File Offset: 0x0030B780
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockFogsIter()
		{
			SheriffMap.<UnlockFogsIter>d__46 <UnlockFogsIter>d__ = new SheriffMap.<UnlockFogsIter>d__46(-2);
			<UnlockFogsIter>d__.<>3__<>4__this = this;
			return <UnlockFogsIter>d__;
		}

		// Token: 0x040051AF RID: 20911
		private Table __p;
	}
}
