using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E8 RID: 4328
	public struct RogueResEventBg : IFlatbufferObject
	{
		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600C867 RID: 51303 RVA: 0x00307F2D File Offset: 0x0030612D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x00307F3A File Offset: 0x0030613A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x00307F44 File Offset: 0x00306144
		public static RogueResEventBg GetRootAsRogueResEventBg(ByteBuffer _bb)
		{
			return RogueResEventBg.GetRootAsRogueResEventBg(_bb, default(RogueResEventBg));
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x00307F60 File Offset: 0x00306160
		public static RogueResEventBg GetRootAsRogueResEventBg(ByteBuffer _bb, RogueResEventBg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x00307F7D File Offset: 0x0030617D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x00307F8C File Offset: 0x0030618C
		public RogueResEventBg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600C86D RID: 51309 RVA: 0x00307F9C File Offset: 0x0030619C
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

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x0600C86E RID: 51310 RVA: 0x00307FD8 File Offset: 0x003061D8
		public string BgName
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

		// Token: 0x0600C86F RID: 51311 RVA: 0x0030800F File Offset: 0x0030620F
		public Span<byte> GetBgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x0030801E File Offset: 0x0030621E
		public byte[] GetBgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B4 RID: 12468
		// (get) Token: 0x0600C871 RID: 51313 RVA: 0x00308038 File Offset: 0x00306238
		public string BgPath
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

		// Token: 0x0600C872 RID: 51314 RVA: 0x0030806F File Offset: 0x0030626F
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x0030807E File Offset: 0x0030627E
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600C874 RID: 51316 RVA: 0x00308098 File Offset: 0x00306298
		public string BgFemalePath
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

		// Token: 0x0600C875 RID: 51317 RVA: 0x003080D0 File Offset: 0x003062D0
		public Span<byte> GetBgFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x003080E0 File Offset: 0x003062E0
		public byte[] GetBgFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600C877 RID: 51319 RVA: 0x003080F8 File Offset: 0x003062F8
		public string HandBookBgPath
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

		// Token: 0x0600C878 RID: 51320 RVA: 0x00308130 File Offset: 0x00306330
		public Span<byte> GetHandBookBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x00308140 File Offset: 0x00306340
		public byte[] GetHandBookBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600C87A RID: 51322 RVA: 0x00308158 File Offset: 0x00306358
		public string HandBookBgFemalePath
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

		// Token: 0x0600C87B RID: 51323 RVA: 0x00308190 File Offset: 0x00306390
		public Span<byte> GetHandBookBgFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x003081A0 File Offset: 0x003063A0
		public byte[] GetHandBookBgFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600C87D RID: 51325 RVA: 0x003081B8 File Offset: 0x003063B8
		public string BgSpineAtlasPath
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

		// Token: 0x0600C87E RID: 51326 RVA: 0x003081F0 File Offset: 0x003063F0
		public Span<byte> GetBgSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x00308200 File Offset: 0x00306400
		public byte[] GetBgSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600C880 RID: 51328 RVA: 0x00308218 File Offset: 0x00306418
		public string BgSpineSkeletonPath
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

		// Token: 0x0600C881 RID: 51329 RVA: 0x00308250 File Offset: 0x00306450
		public Span<byte> GetBgSpineSkeletonPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x00308260 File Offset: 0x00306460
		public byte[] GetBgSpineSkeletonPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600C883 RID: 51331 RVA: 0x00308278 File Offset: 0x00306478
		public string BgSpineAtlasFemalePath
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

		// Token: 0x0600C884 RID: 51332 RVA: 0x003082B0 File Offset: 0x003064B0
		public Span<byte> GetBgSpineAtlasFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x003082C0 File Offset: 0x003064C0
		public byte[] GetBgSpineAtlasFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600C886 RID: 51334 RVA: 0x003082D8 File Offset: 0x003064D8
		public string BgSpineSkeletonFemalePath
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

		// Token: 0x0600C887 RID: 51335 RVA: 0x00308310 File Offset: 0x00306510
		public Span<byte> GetBgSpineSkeletonFemalePathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00308320 File Offset: 0x00306520
		public byte[] GetBgSpineSkeletonFemalePathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x040056D0 RID: 22224
		private Table __p;
	}
}
