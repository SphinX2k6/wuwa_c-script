using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D36 RID: 3382
	public struct ExploreRouletteType : IFlatbufferObject
	{
		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x002483E8 File Offset: 0x002465E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x002483F5 File Offset: 0x002465F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x002483FC File Offset: 0x002465FC
		public static ExploreRouletteType GetRootAsExploreRouletteType(ByteBuffer _bb)
		{
			return ExploreRouletteType.GetRootAsExploreRouletteType(_bb, default(ExploreRouletteType));
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00248418 File Offset: 0x00246618
		public static ExploreRouletteType GetRootAsExploreRouletteType(ByteBuffer _bb, ExploreRouletteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x00248435 File Offset: 0x00246635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00248444 File Offset: 0x00246644
		public ExploreRouletteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x00248454 File Offset: 0x00246654
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

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060071D6 RID: 29142 RVA: 0x00248490 File Offset: 0x00246690
		public int SortId
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

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x002484CC File Offset: 0x002466CC
		public bool ShowInPad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x0024850C File Offset: 0x0024670C
		public int UnlockFuncId
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

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x0024854C File Offset: 0x0024674C
		public string TabName
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

		// Token: 0x060071DA RID: 29146 RVA: 0x00248584 File Offset: 0x00246784
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00248594 File Offset: 0x00246794
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x002485AC File Offset: 0x002467AC
		public string TabIcon
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

		// Token: 0x060071DD RID: 29149 RVA: 0x002485E4 File Offset: 0x002467E4
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x002485F4 File Offset: 0x002467F4
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400527D RID: 21117
		private Table __p;
	}
}
