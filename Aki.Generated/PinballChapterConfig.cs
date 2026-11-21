using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001009 RID: 4105
	public struct PinballChapterConfig : IFlatbufferObject
	{
		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600B45B RID: 46171 RVA: 0x002DCDDB File Offset: 0x002DAFDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x002DCDE8 File Offset: 0x002DAFE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x002DCDF0 File Offset: 0x002DAFF0
		public static PinballChapterConfig GetRootAsPinballChapterConfig(ByteBuffer _bb)
		{
			return PinballChapterConfig.GetRootAsPinballChapterConfig(_bb, default(PinballChapterConfig));
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x002DCE0C File Offset: 0x002DB00C
		public static PinballChapterConfig GetRootAsPinballChapterConfig(ByteBuffer _bb, PinballChapterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x002DCE29 File Offset: 0x002DB029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x002DCE38 File Offset: 0x002DB038
		public PinballChapterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600B461 RID: 46177 RVA: 0x002DCE48 File Offset: 0x002DB048
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

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x002DCE84 File Offset: 0x002DB084
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

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600B463 RID: 46179 RVA: 0x002DCEC0 File Offset: 0x002DB0C0
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

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x002DCEFC File Offset: 0x002DB0FC
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

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600B465 RID: 46181 RVA: 0x002DCF3C File Offset: 0x002DB13C
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

		// Token: 0x0600B466 RID: 46182 RVA: 0x002DCF74 File Offset: 0x002DB174
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x002DCF84 File Offset: 0x002DB184
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x002DCF9C File Offset: 0x002DB19C
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

		// Token: 0x0600B469 RID: 46185 RVA: 0x002DCFD4 File Offset: 0x002DB1D4
		public Span<byte> GetIconBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x002DCFE4 File Offset: 0x002DB1E4
		public byte[] GetIconBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600B46B RID: 46187 RVA: 0x002DCFFC File Offset: 0x002DB1FC
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

		// Token: 0x0600B46C RID: 46188 RVA: 0x002DD034 File Offset: 0x002DB234
		public Span<byte> GetIconDecorationBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x002DD044 File Offset: 0x002DB244
		public byte[] GetIconDecorationArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600B46E RID: 46190 RVA: 0x002DD05C File Offset: 0x002DB25C
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

		// Token: 0x0600B46F RID: 46191 RVA: 0x002DD094 File Offset: 0x002DB294
		public Span<byte> GetIconArtNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x002DD0A4 File Offset: 0x002DB2A4
		public byte[] GetIconArtNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600B471 RID: 46193 RVA: 0x002DD0BC File Offset: 0x002DB2BC
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

		// Token: 0x0600B472 RID: 46194 RVA: 0x002DD0F4 File Offset: 0x002DB2F4
		public Span<byte> GetPlanetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x002DD104 File Offset: 0x002DB304
		public byte[] GetPlanetBgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600B474 RID: 46196 RVA: 0x002DD11C File Offset: 0x002DB31C
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

		// Token: 0x0600B475 RID: 46197 RVA: 0x002DD154 File Offset: 0x002DB354
		public Span<byte> GetPlanetMaskBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x002DD164 File Offset: 0x002DB364
		public byte[] GetPlanetMaskBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x002DD17C File Offset: 0x002DB37C
		public int LevelList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600B478 RID: 46200 RVA: 0x002DD1BC File Offset: 0x002DB3BC
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

		// Token: 0x0600B479 RID: 46201 RVA: 0x002DD1E8 File Offset: 0x002DB3E8
		public Span<int> GetLevelListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x002DD1F8 File Offset: 0x002DB3F8
		public int[] GetLevelListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x0600B47B RID: 46203 RVA: 0x002DD210 File Offset: 0x002DB410
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

		// Token: 0x0600B47C RID: 46204 RVA: 0x002DD248 File Offset: 0x002DB448
		public Span<byte> GetOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x002DD258 File Offset: 0x002DB458
		public byte[] GetOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x0600B47E RID: 46206 RVA: 0x002DD270 File Offset: 0x002DB470
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

		// Token: 0x0600B47F RID: 46207 RVA: 0x002DD2A8 File Offset: 0x002DB4A8
		public Span<byte> GetExOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x002DD2B8 File Offset: 0x002DB4B8
		public byte[] GetExOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x002DD2D0 File Offset: 0x002DB4D0
		[NullableContext(1)]
		public int[] LevelList()
		{
			return this.GetLevelListArray();
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x002DD2D8 File Offset: 0x002DB4D8
		[NullableContext(1)]
		public IEnumerable<int> LevelListIter()
		{
			PinballChapterConfig.<LevelListIter>d__54 <LevelListIter>d__ = new PinballChapterConfig.<LevelListIter>d__54(-2);
			<LevelListIter>d__.<>3__<>4__this = this;
			return <LevelListIter>d__;
		}

		// Token: 0x040055D2 RID: 21970
		private Table __p;
	}
}
