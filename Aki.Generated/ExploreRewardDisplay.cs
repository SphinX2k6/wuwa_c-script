using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D33 RID: 3379
	public struct ExploreRewardDisplay : IFlatbufferObject
	{
		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600718F RID: 29071 RVA: 0x00247B8D File Offset: 0x00245D8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00247B9A File Offset: 0x00245D9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00247BA4 File Offset: 0x00245DA4
		public static ExploreRewardDisplay GetRootAsExploreRewardDisplay(ByteBuffer _bb)
		{
			return ExploreRewardDisplay.GetRootAsExploreRewardDisplay(_bb, default(ExploreRewardDisplay));
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00247BC0 File Offset: 0x00245DC0
		public static ExploreRewardDisplay GetRootAsExploreRewardDisplay(ByteBuffer _bb, ExploreRewardDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00247BDD File Offset: 0x00245DDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00247BEC File Offset: 0x00245DEC
		public ExploreRewardDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x00247BFC File Offset: 0x00245DFC
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

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06007196 RID: 29078 RVA: 0x00247C38 File Offset: 0x00245E38
		public string Title
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

		// Token: 0x06007197 RID: 29079 RVA: 0x00247C6F File Offset: 0x00245E6F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x00247C7E File Offset: 0x00245E7E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x00247C98 File Offset: 0x00245E98
		public string TitleHexColor
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

		// Token: 0x0600719A RID: 29082 RVA: 0x00247CCF File Offset: 0x00245ECF
		public Span<byte> GetTitleHexColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x00247CDE File Offset: 0x00245EDE
		public byte[] GetTitleHexColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x00247CF8 File Offset: 0x00245EF8
		public string TitleIconPath
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

		// Token: 0x0600719D RID: 29085 RVA: 0x00247D30 File Offset: 0x00245F30
		public Span<byte> GetTitleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x00247D40 File Offset: 0x00245F40
		public byte[] GetTitleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x00247D58 File Offset: 0x00245F58
		public string TitleIconHexColor
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

		// Token: 0x060071A0 RID: 29088 RVA: 0x00247D90 File Offset: 0x00245F90
		public Span<byte> GetTitleIconHexColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00247DA0 File Offset: 0x00245FA0
		public byte[] GetTitleIconHexColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x00247DB8 File Offset: 0x00245FB8
		public bool IsRecordVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x00247DF8 File Offset: 0x00245FF8
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x00247E38 File Offset: 0x00246038
		public bool IsExploreProgressVisible
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x00247E78 File Offset: 0x00246078
		public string ExploreBarTipsTextId
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

		// Token: 0x060071A6 RID: 29094 RVA: 0x00247EB0 File Offset: 0x002460B0
		public Span<byte> GetExploreBarTipsTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x00247EC0 File Offset: 0x002460C0
		public byte[] GetExploreBarTipsTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060071A8 RID: 29096 RVA: 0x00247ED8 File Offset: 0x002460D8
		public bool IsDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x00247F18 File Offset: 0x00246118
		public string Description
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

		// Token: 0x060071AA RID: 29098 RVA: 0x00247F50 File Offset: 0x00246150
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x00247F60 File Offset: 0x00246160
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x00247F78 File Offset: 0x00246178
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x00247FB8 File Offset: 0x002461B8
		public string AudioId
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

		// Token: 0x060071AE RID: 29102 RVA: 0x00247FF0 File Offset: 0x002461F0
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x00248000 File Offset: 0x00246200
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0400527A RID: 21114
		private Table __p;
	}
}
