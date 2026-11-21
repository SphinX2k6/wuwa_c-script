using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F3 RID: 4339
	public struct RogueResInstGrid : IFlatbufferObject
	{
		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600C996 RID: 51606 RVA: 0x0030A7BA File Offset: 0x003089BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C997 RID: 51607 RVA: 0x0030A7C7 File Offset: 0x003089C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x0030A7D0 File Offset: 0x003089D0
		public static RogueResInstGrid GetRootAsRogueResInstGrid(ByteBuffer _bb)
		{
			return RogueResInstGrid.GetRootAsRogueResInstGrid(_bb, default(RogueResInstGrid));
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x0030A7EC File Offset: 0x003089EC
		public static RogueResInstGrid GetRootAsRogueResInstGrid(ByteBuffer _bb, RogueResInstGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x0030A809 File Offset: 0x00308A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x0030A818 File Offset: 0x00308A18
		public RogueResInstGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600C99C RID: 51612 RVA: 0x0030A828 File Offset: 0x00308A28
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

		// Token: 0x0600C99D RID: 51613 RVA: 0x0030A864 File Offset: 0x00308A64
		public string SubLevelArray(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x0600C99E RID: 51614 RVA: 0x0030A8A0 File Offset: 0x00308AA0
		public int SubLevelArrayLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x0600C99F RID: 51615 RVA: 0x0030A8CC File Offset: 0x00308ACC
		public string Title
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

		// Token: 0x0600C9A0 RID: 51616 RVA: 0x0030A903 File Offset: 0x00308B03
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x0030A912 File Offset: 0x00308B12
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600C9A2 RID: 51618 RVA: 0x0030A92C File Offset: 0x00308B2C
		public int MapScaleMin
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600C9A3 RID: 51619 RVA: 0x0030A970 File Offset: 0x00308B70
		public int MapScaleMax
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600C9A4 RID: 51620 RVA: 0x0030A9B4 File Offset: 0x00308BB4
		public int MapInitScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x0030A9F8 File Offset: 0x00308BF8
		public int MapHeight
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 6000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600C9A6 RID: 51622 RVA: 0x0030AA3C File Offset: 0x00308C3C
		public int MapWidth
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 6000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600C9A7 RID: 51623 RVA: 0x0030AA80 File Offset: 0x00308C80
		public string MapBackground
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

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x0030AAB8 File Offset: 0x00308CB8
		public Span<byte> GetMapBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x0030AAC8 File Offset: 0x00308CC8
		public byte[] GetMapBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600C9AA RID: 51626 RVA: 0x0030AAE0 File Offset: 0x00308CE0
		public string MapMusicState
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

		// Token: 0x0600C9AB RID: 51627 RVA: 0x0030AB18 File Offset: 0x00308D18
		public Span<byte> GetMapMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x0030AB28 File Offset: 0x00308D28
		public byte[] GetMapMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600C9AD RID: 51629 RVA: 0x0030AB40 File Offset: 0x00308D40
		public string LoseTitle
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

		// Token: 0x0600C9AE RID: 51630 RVA: 0x0030AB78 File Offset: 0x00308D78
		public Span<byte> GetLoseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x0030AB88 File Offset: 0x00308D88
		public byte[] GetLoseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600C9B0 RID: 51632 RVA: 0x0030ABA0 File Offset: 0x00308DA0
		public string LoseDesc
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

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x0030ABD8 File Offset: 0x00308DD8
		public Span<byte> GetLoseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C9B2 RID: 51634 RVA: 0x0030ABE8 File Offset: 0x00308DE8
		public byte[] GetLoseDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x0030AC00 File Offset: 0x00308E00
		[NullableContext(1)]
		public string[] SubLevelArray()
		{
			return this.SubLevelArrayIter().ToArray<string>();
		}

		// Token: 0x0600C9B4 RID: 51636 RVA: 0x0030AC0D File Offset: 0x00308E0D
		[NullableContext(1)]
		public IEnumerable<string> SubLevelArrayIter()
		{
			RogueResInstGrid.<SubLevelArrayIter>d__44 <SubLevelArrayIter>d__ = new RogueResInstGrid.<SubLevelArrayIter>d__44(-2);
			<SubLevelArrayIter>d__.<>3__<>4__this = this;
			return <SubLevelArrayIter>d__;
		}

		// Token: 0x040056E0 RID: 22240
		private Table __p;
	}
}
