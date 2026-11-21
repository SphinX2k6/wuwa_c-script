using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110E RID: 4366
	public struct RogueTower : IFlatbufferObject
	{
		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x0030EEDD File Offset: 0x0030D0DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x0030EEEA File Offset: 0x0030D0EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBA8 RID: 52136 RVA: 0x0030EEF4 File Offset: 0x0030D0F4
		public static RogueTower GetRootAsRogueTower(ByteBuffer _bb)
		{
			return RogueTower.GetRootAsRogueTower(_bb, default(RogueTower));
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x0030EF10 File Offset: 0x0030D110
		public static RogueTower GetRootAsRogueTower(ByteBuffer _bb, RogueTower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x0030EF2D File Offset: 0x0030D12D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x0030EF3C File Offset: 0x0030D13C
		public RogueTower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x0030EF4C File Offset: 0x0030D14C
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

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x0030EF88 File Offset: 0x0030D188
		public int InstId
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

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x0030EFC4 File Offset: 0x0030D1C4
		public int SortId
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

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x0030F000 File Offset: 0x0030D200
		public int MaxLevel
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

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x0030F040 File Offset: 0x0030D240
		public int Buffs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600CBB1 RID: 52145 RVA: 0x0030F080 File Offset: 0x0030D280
		public int BuffsLength
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

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x0030F0AC File Offset: 0x0030D2AC
		public Span<int> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x0030F0BC File Offset: 0x0030D2BC
		public int[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170031C3 RID: 12739
		// (get) Token: 0x0600CBB4 RID: 52148 RVA: 0x0030F0D4 File Offset: 0x0030D2D4
		public string Name
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

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x0030F10C File Offset: 0x0030D30C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CBB6 RID: 52150 RVA: 0x0030F11C File Offset: 0x0030D31C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600CBB7 RID: 52151 RVA: 0x0030F134 File Offset: 0x0030D334
		public string Stand
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

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x0030F16C File Offset: 0x0030D36C
		public Span<byte> GetStandBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x0030F17C File Offset: 0x0030D37C
		public byte[] GetStandArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600CBBA RID: 52154 RVA: 0x0030F194 File Offset: 0x0030D394
		public string PreviewIcon
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

		// Token: 0x0600CBBB RID: 52155 RVA: 0x0030F1CC File Offset: 0x0030D3CC
		public Span<byte> GetPreviewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x0030F1DC File Offset: 0x0030D3DC
		public byte[] GetPreviewIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x0030F1F4 File Offset: 0x0030D3F4
		[NullableContext(1)]
		public int[] Buffs()
		{
			return this.GetBuffsArray();
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x0030F1FC File Offset: 0x0030D3FC
		[NullableContext(1)]
		public IEnumerable<int> BuffsIter()
		{
			RogueTower.<BuffsIter>d__34 <BuffsIter>d__ = new RogueTower.<BuffsIter>d__34(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04005701 RID: 22273
		private Table __p;
	}
}
