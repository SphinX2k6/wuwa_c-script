using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FC RID: 4604
	public struct SolarSchoolRole : IFlatbufferObject
	{
		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600E327 RID: 58151 RVA: 0x00344D5A File Offset: 0x00342F5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E328 RID: 58152 RVA: 0x00344D67 File Offset: 0x00342F67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E329 RID: 58153 RVA: 0x00344D70 File Offset: 0x00342F70
		public static SolarSchoolRole GetRootAsSolarSchoolRole(ByteBuffer _bb)
		{
			return SolarSchoolRole.GetRootAsSolarSchoolRole(_bb, default(SolarSchoolRole));
		}

		// Token: 0x0600E32A RID: 58154 RVA: 0x00344D8C File Offset: 0x00342F8C
		public static SolarSchoolRole GetRootAsSolarSchoolRole(ByteBuffer _bb, SolarSchoolRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E32B RID: 58155 RVA: 0x00344DA9 File Offset: 0x00342FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E32C RID: 58156 RVA: 0x00344DB8 File Offset: 0x00342FB8
		public SolarSchoolRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600E32D RID: 58157 RVA: 0x00344DC8 File Offset: 0x00342FC8
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

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x00344E04 File Offset: 0x00343004
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

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600E32F RID: 58159 RVA: 0x00344E40 File Offset: 0x00343040
		public int Classify
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

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600E330 RID: 58160 RVA: 0x00344E7C File Offset: 0x0034307C
		public int ConditionId
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

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600E331 RID: 58161 RVA: 0x00344EBC File Offset: 0x003430BC
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600E332 RID: 58162 RVA: 0x00344EFC File Offset: 0x003430FC
		public int MaxFavorLevel
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

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600E333 RID: 58163 RVA: 0x00344F3C File Offset: 0x0034313C
		public string Name
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

		// Token: 0x0600E334 RID: 58164 RVA: 0x00344F74 File Offset: 0x00343174
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E335 RID: 58165 RVA: 0x00344F84 File Offset: 0x00343184
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600E336 RID: 58166 RVA: 0x00344F9C File Offset: 0x0034319C
		public int SpeakerId
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

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00344FDC File Offset: 0x003431DC
		public string Spine
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

		// Token: 0x0600E338 RID: 58168 RVA: 0x00345014 File Offset: 0x00343214
		public Span<byte> GetSpineBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00345024 File Offset: 0x00343224
		public byte[] GetSpineArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600E33A RID: 58170 RVA: 0x0034503C File Offset: 0x0034323C
		public string GrayIcon
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

		// Token: 0x0600E33B RID: 58171 RVA: 0x00345074 File Offset: 0x00343274
		public Span<byte> GetGrayIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E33C RID: 58172 RVA: 0x00345084 File Offset: 0x00343284
		public byte[] GetGrayIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600E33D RID: 58173 RVA: 0x0034509C File Offset: 0x0034329C
		public string PopupIcon
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

		// Token: 0x0600E33E RID: 58174 RVA: 0x003450D4 File Offset: 0x003432D4
		public Span<byte> GetPopupIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E33F RID: 58175 RVA: 0x003450E4 File Offset: 0x003432E4
		public byte[] GetPopupIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600E340 RID: 58176 RVA: 0x003450FC File Offset: 0x003432FC
		public string HeadIcon
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

		// Token: 0x0600E341 RID: 58177 RVA: 0x00345134 File Offset: 0x00343334
		public Span<byte> GetHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E342 RID: 58178 RVA: 0x00345144 File Offset: 0x00343344
		public byte[] GetHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600E343 RID: 58179 RVA: 0x0034515C File Offset: 0x0034335C
		public string FrameHeadIcon
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

		// Token: 0x0600E344 RID: 58180 RVA: 0x00345194 File Offset: 0x00343394
		public Span<byte> GetFrameHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E345 RID: 58181 RVA: 0x003451A4 File Offset: 0x003433A4
		public byte[] GetFrameHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600E346 RID: 58182 RVA: 0x003451BC File Offset: 0x003433BC
		public string MapHeadIcon
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

		// Token: 0x0600E347 RID: 58183 RVA: 0x003451F4 File Offset: 0x003433F4
		public Span<byte> GetMapHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x00345204 File Offset: 0x00343404
		public byte[] GetMapHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600E349 RID: 58185 RVA: 0x0034521C File Offset: 0x0034341C
		public int InfluenceId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600E34A RID: 58186 RVA: 0x0034525C File Offset: 0x0034345C
		public string IntroductionName
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

		// Token: 0x0600E34B RID: 58187 RVA: 0x00345294 File Offset: 0x00343494
		public Span<byte> GetIntroductionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x003452A4 File Offset: 0x003434A4
		public byte[] GetIntroductionNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600E34D RID: 58189 RVA: 0x003452BC File Offset: 0x003434BC
		public string IntroductionInfluenceName
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x003452F4 File Offset: 0x003434F4
		public Span<byte> GetIntroductionInfluenceNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x00345304 File Offset: 0x00343504
		public byte[] GetIntroductionInfluenceNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600E350 RID: 58192 RVA: 0x0034531C File Offset: 0x0034351C
		public string Introduction
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E351 RID: 58193 RVA: 0x00345354 File Offset: 0x00343554
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x00345364 File Offset: 0x00343564
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600E353 RID: 58195 RVA: 0x0034537C File Offset: 0x0034357C
		public string IntroductionColor
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x003453B4 File Offset: 0x003435B4
		public Span<byte> GetIntroductionColorBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x003453C4 File Offset: 0x003435C4
		public byte[] GetIntroductionColorArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0400583A RID: 22586
		private Table __p;
	}
}
