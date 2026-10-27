using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F24 RID: 3876
	public struct PinballChapterConfig : IFlatbufferObject
	{
		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600AE3A RID: 44602 RVA: 0x002C025F File Offset: 0x002BE45F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x002C026C File Offset: 0x002BE46C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE3C RID: 44604 RVA: 0x002C0274 File Offset: 0x002BE474
		public static PinballChapterConfig GetRootAsPinballChapterConfig(ByteBuffer _bb)
		{
			return PinballChapterConfig.GetRootAsPinballChapterConfig(_bb, default(PinballChapterConfig));
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x002C0290 File Offset: 0x002BE490
		public static PinballChapterConfig GetRootAsPinballChapterConfig(ByteBuffer _bb, PinballChapterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x002C02AD File Offset: 0x002BE4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x002C02BC File Offset: 0x002BE4BC
		public PinballChapterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x002C02CC File Offset: 0x002BE4CC
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

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x002C0308 File Offset: 0x002BE508
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

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x0600AE42 RID: 44610 RVA: 0x002C0344 File Offset: 0x002BE544
		public int OpenDay
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

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600AE43 RID: 44611 RVA: 0x002C0380 File Offset: 0x002BE580
		public int PreChapterId
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

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x0600AE44 RID: 44612 RVA: 0x002C03C0 File Offset: 0x002BE5C0
		public string Name
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

		// Token: 0x0600AE45 RID: 44613 RVA: 0x002C03F8 File Offset: 0x002BE5F8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x002C0408 File Offset: 0x002BE608
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600AE47 RID: 44615 RVA: 0x002C0420 File Offset: 0x002BE620
		public string IconBg
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

		// Token: 0x0600AE48 RID: 44616 RVA: 0x002C0458 File Offset: 0x002BE658
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x002C0468 File Offset: 0x002BE668
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600AE4A RID: 44618 RVA: 0x002C0480 File Offset: 0x002BE680
		public string IconDecoration
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

		// Token: 0x0600AE4B RID: 44619 RVA: 0x002C04B8 File Offset: 0x002BE6B8
		public Span<byte> GetIconDecorationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x002C04C8 File Offset: 0x002BE6C8
		public byte[] GetIconDecorationArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600AE4D RID: 44621 RVA: 0x002C04E0 File Offset: 0x002BE6E0
		public string IconArtName
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

		// Token: 0x0600AE4E RID: 44622 RVA: 0x002C0518 File Offset: 0x002BE718
		public Span<byte> GetIconArtNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x002C0528 File Offset: 0x002BE728
		public byte[] GetIconArtNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600AE50 RID: 44624 RVA: 0x002C0540 File Offset: 0x002BE740
		public string PlanetBg
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

		// Token: 0x0600AE51 RID: 44625 RVA: 0x002C0578 File Offset: 0x002BE778
		public Span<byte> GetPlanetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x002C0588 File Offset: 0x002BE788
		public byte[] GetPlanetBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x002C05A0 File Offset: 0x002BE7A0
		public string PlanetMaskBg
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x002C05D8 File Offset: 0x002BE7D8
		public Span<byte> GetPlanetMaskBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x002C05E8 File Offset: 0x002BE7E8
		public byte[] GetPlanetMaskBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x002C0600 File Offset: 0x002BE800
		public int LevelList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x0600AE57 RID: 44631 RVA: 0x002C0640 File Offset: 0x002BE840
		public int LevelListLength
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

		// Token: 0x0600AE58 RID: 44632 RVA: 0x002C066C File Offset: 0x002BE86C
		public Span<int> GetLevelListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x002C067C File Offset: 0x002BE87C
		public int[] GetLevelListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x002C0694 File Offset: 0x002BE894
		public string OutlineColor
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x002C06CC File Offset: 0x002BE8CC
		public Span<byte> GetOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x002C06DC File Offset: 0x002BE8DC
		public byte[] GetOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x0600AE5D RID: 44637 RVA: 0x002C06F4 File Offset: 0x002BE8F4
		public string ExOutlineColor
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

		// Token: 0x0600AE5E RID: 44638 RVA: 0x002C072C File Offset: 0x002BE92C
		public Span<byte> GetExOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x002C073C File Offset: 0x002BE93C
		public byte[] GetExOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x002C0754 File Offset: 0x002BE954
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelListIter()或GetLevelListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelList()
		{
			PinballChapterConfig pinballChapterConfig = this;
			return pinballChapterConfig.GetLevelListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x002C0778 File Offset: 0x002BE978
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelListIter()
		{
			PinballChapterConfig.<LevelListIter>d__54 <LevelListIter>d__ = new PinballChapterConfig.<LevelListIter>d__54(-2);
			<LevelListIter>d__.<>3__<>4__this = this;
			return <LevelListIter>d__;
		}

		// Token: 0x04004FED RID: 20461
		private Table __p;
	}
}
