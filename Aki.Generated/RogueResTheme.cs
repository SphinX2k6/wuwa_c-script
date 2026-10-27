using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101A RID: 4122
	public struct RogueResTheme : IFlatbufferObject
	{
		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600C467 RID: 50279 RVA: 0x002F0BA1 File Offset: 0x002EEDA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x002F0BAE File Offset: 0x002EEDAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x002F0BB8 File Offset: 0x002EEDB8
		public static RogueResTheme GetRootAsRogueResTheme(ByteBuffer _bb)
		{
			return RogueResTheme.GetRootAsRogueResTheme(_bb, default(RogueResTheme));
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x002F0BD4 File Offset: 0x002EEDD4
		public static RogueResTheme GetRootAsRogueResTheme(ByteBuffer _bb, RogueResTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x002F0BF1 File Offset: 0x002EEDF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x002F0C00 File Offset: 0x002EEE00
		public RogueResTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600C46D RID: 50285 RVA: 0x002F0C10 File Offset: 0x002EEE10
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

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600C46E RID: 50286 RVA: 0x002F0C4C File Offset: 0x002EEE4C
		public int ActivityId
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

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600C46F RID: 50287 RVA: 0x002F0C88 File Offset: 0x002EEE88
		public int TimerId
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

		// Token: 0x0600C470 RID: 50288 RVA: 0x002F0CC4 File Offset: 0x002EEEC4
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600C471 RID: 50289 RVA: 0x002F0D04 File Offset: 0x002EEF04
		public int InstsLength
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

		// Token: 0x0600C472 RID: 50290 RVA: 0x002F0D30 File Offset: 0x002EEF30
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x002F0D40 File Offset: 0x002EEF40
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x002F0D58 File Offset: 0x002EEF58
		public DicIntInt? PreInsts(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600C475 RID: 50293 RVA: 0x002F0DBC File Offset: 0x002EEFBC
		public int PreInstsLength
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

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600C476 RID: 50294 RVA: 0x002F0DE8 File Offset: 0x002EEFE8
		public int SkillItem
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

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600C477 RID: 50295 RVA: 0x002F0E28 File Offset: 0x002EF028
		public int SkillMax
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

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600C478 RID: 50296 RVA: 0x002F0E68 File Offset: 0x002EF068
		public int PointItem
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

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600C479 RID: 50297 RVA: 0x002F0EA8 File Offset: 0x002EF0A8
		public int PointItemMax
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

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600C47A RID: 50298 RVA: 0x002F0EE8 File Offset: 0x002EF0E8
		public int ShopId
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

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600C47B RID: 50299 RVA: 0x002F0F28 File Offset: 0x002EF128
		public string Name
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x002F0F60 File Offset: 0x002EF160
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x002F0F70 File Offset: 0x002EF170
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600C47E RID: 50302 RVA: 0x002F0F88 File Offset: 0x002EF188
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600C47F RID: 50303 RVA: 0x002F0FC8 File Offset: 0x002EF1C8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C480 RID: 50304 RVA: 0x002F1000 File Offset: 0x002EF200
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600C481 RID: 50305 RVA: 0x002F1010 File Offset: 0x002EF210
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600C482 RID: 50306 RVA: 0x002F1028 File Offset: 0x002EF228
		public string ViewName
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x002F1060 File Offset: 0x002EF260
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C484 RID: 50308 RVA: 0x002F1070 File Offset: 0x002EF270
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600C485 RID: 50309 RVA: 0x002F1088 File Offset: 0x002EF288
		public string CoverF
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x002F10C0 File Offset: 0x002EF2C0
		public Span<byte> GetCoverFBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x002F10D0 File Offset: 0x002EF2D0
		public byte[] GetCoverFArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600C488 RID: 50312 RVA: 0x002F10E8 File Offset: 0x002EF2E8
		public string CoverM
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x002F1120 File Offset: 0x002EF320
		public Span<byte> GetCoverMBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x002F1130 File Offset: 0x002EF330
		public byte[] GetCoverMArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x002F1148 File Offset: 0x002EF348
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RogueResTheme rogueResTheme = this;
			return rogueResTheme.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x002F116C File Offset: 0x002EF36C
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RogueResTheme.<InstsIter>d__55 <InstsIter>d__ = new RogueResTheme.<InstsIter>d__55(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x002F1184 File Offset: 0x002EF384
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PreInstsFrozenDict()缓存字典，遍历请使用PreInstsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PreInsts()
		{
			return this.PreInstsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x002F11DA File Offset: 0x002EF3DA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PreInstsIter()
		{
			RogueResTheme.<PreInstsIter>d__57 <PreInstsIter>d__ = new RogueResTheme.<PreInstsIter>d__57(-2);
			<PreInstsIter>d__.<>3__<>4__this = this;
			return <PreInstsIter>d__;
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x002F11F0 File Offset: 0x002EF3F0
		public int? GetPreInsts(int key)
		{
			this.EnsurePreInstsCacheIfNeeded();
			int value;
			if (!this.PreInstsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C490 RID: 50320 RVA: 0x002F1224 File Offset: 0x002EF424
		private void EnsurePreInstsCacheIfNeeded()
		{
			if (this.PreInstsCache != null)
			{
				return;
			}
			this.PreInstsCache = this.PreInstsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x002F128A File Offset: 0x002EF48A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPreInstsFrozenDict(int key)
		{
			this.EnsurePreInstsCacheIfNeeded();
			return this.PreInstsCache;
		}

		// Token: 0x04005109 RID: 20745
		private Table __p;

		// Token: 0x0400510A RID: 20746
		[Nullable(2)]
		private FrozenDictionary<int, int> PreInstsCache;
	}
}
