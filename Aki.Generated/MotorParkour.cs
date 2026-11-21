using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F45 RID: 3909
	public struct MotorParkour : IFlatbufferObject
	{
		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x002B2C2D File Offset: 0x002B0E2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x002B2C3A File Offset: 0x002B0E3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x002B2C44 File Offset: 0x002B0E44
		public static MotorParkour GetRootAsMotorParkour(ByteBuffer _bb)
		{
			return MotorParkour.GetRootAsMotorParkour(_bb, default(MotorParkour));
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x002B2C60 File Offset: 0x002B0E60
		public static MotorParkour GetRootAsMotorParkour(ByteBuffer _bb, MotorParkour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x002B2C7D File Offset: 0x002B0E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x002B2C8C File Offset: 0x002B0E8C
		public MotorParkour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x002B2C9C File Offset: 0x002B0E9C
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

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600A146 RID: 41286 RVA: 0x002B2CD8 File Offset: 0x002B0ED8
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

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x002B2D14 File Offset: 0x002B0F14
		public int InstId
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

		// Token: 0x0600A148 RID: 41288 RVA: 0x002B2D50 File Offset: 0x002B0F50
		public int RewardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x002B2D90 File Offset: 0x002B0F90
		public int RewardIdsLength
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

		// Token: 0x0600A14A RID: 41290 RVA: 0x002B2DBC File Offset: 0x002B0FBC
		public Span<int> GetRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x002B2DCC File Offset: 0x002B0FCC
		public int[] GetRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600A14C RID: 41292 RVA: 0x002B2DE4 File Offset: 0x002B0FE4
		public string LevelName
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

		// Token: 0x0600A14D RID: 41293 RVA: 0x002B2E1C File Offset: 0x002B101C
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x002B2E2C File Offset: 0x002B102C
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x002B2E44 File Offset: 0x002B1044
		public string RouteName
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

		// Token: 0x0600A150 RID: 41296 RVA: 0x002B2E7C File Offset: 0x002B107C
		public Span<byte> GetRouteNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x002B2E8C File Offset: 0x002B108C
		public byte[] GetRouteNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600A152 RID: 41298 RVA: 0x002B2EA4 File Offset: 0x002B10A4
		public string SmallBgTexture
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

		// Token: 0x0600A153 RID: 41299 RVA: 0x002B2EDC File Offset: 0x002B10DC
		public Span<byte> GetSmallBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x002B2EEC File Offset: 0x002B10EC
		public byte[] GetSmallBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600A155 RID: 41301 RVA: 0x002B2F04 File Offset: 0x002B1104
		public string SelectedSmallBgTexture
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

		// Token: 0x0600A156 RID: 41302 RVA: 0x002B2F3C File Offset: 0x002B113C
		public Span<byte> GetSelectedSmallBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x002B2F4C File Offset: 0x002B114C
		public byte[] GetSelectedSmallBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x002B2F64 File Offset: 0x002B1164
		public string RaceTrackTexture
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

		// Token: 0x0600A159 RID: 41305 RVA: 0x002B2F9C File Offset: 0x002B119C
		public Span<byte> GetRaceTrackTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x002B2FAC File Offset: 0x002B11AC
		public byte[] GetRaceTrackTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600A15B RID: 41307 RVA: 0x002B2FC4 File Offset: 0x002B11C4
		public string RomanNum
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

		// Token: 0x0600A15C RID: 41308 RVA: 0x002B2FFC File Offset: 0x002B11FC
		public Span<byte> GetRomanNumBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x002B300C File Offset: 0x002B120C
		public byte[] GetRomanNumArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600A15E RID: 41310 RVA: 0x002B3024 File Offset: 0x002B1224
		public string MapTexture
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

		// Token: 0x0600A15F RID: 41311 RVA: 0x002B305C File Offset: 0x002B125C
		public Span<byte> GetMapTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x002B306C File Offset: 0x002B126C
		public byte[] GetMapTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x002B3084 File Offset: 0x002B1284
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x002B30C8 File Offset: 0x002B12C8
		public int CenterOffsetLength
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

		// Token: 0x0600A163 RID: 41315 RVA: 0x002B30F4 File Offset: 0x002B12F4
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x002B3104 File Offset: 0x002B1304
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x002B311C File Offset: 0x002B131C
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600A166 RID: 41318 RVA: 0x002B3160 File Offset: 0x002B1360
		public int UiOffsetLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x002B318C File Offset: 0x002B138C
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(28, 4);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x002B319C File Offset: 0x002B139C
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(28) ?? Array.Empty<float>();
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600A169 RID: 41321 RVA: 0x002B31B4 File Offset: 0x002B13B4
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600A16A RID: 41322 RVA: 0x002B31F8 File Offset: 0x002B13F8
		public int SplineId
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

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600A16B RID: 41323 RVA: 0x002B3238 File Offset: 0x002B1438
		public int SplineStartIndex
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600A16C RID: 41324 RVA: 0x002B3278 File Offset: 0x002B1478
		public int SplineEndIndex
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0600A16D RID: 41325 RVA: 0x002B32B8 File Offset: 0x002B14B8
		public int RouteTextureRotation
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x002B32F5 File Offset: 0x002B14F5
		[NullableContext(1)]
		public float[] CenterOffset()
		{
			return this.GetCenterOffsetArray();
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x002B32FD File Offset: 0x002B14FD
		[NullableContext(1)]
		public IEnumerable<float> CenterOffsetIter()
		{
			MotorParkour.<CenterOffsetIter>d__68 <CenterOffsetIter>d__ = new MotorParkour.<CenterOffsetIter>d__68(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x002B3312 File Offset: 0x002B1512
		[NullableContext(1)]
		public int[] RewardIds()
		{
			return this.GetRewardIdsArray();
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x002B331A File Offset: 0x002B151A
		[NullableContext(1)]
		public IEnumerable<int> RewardIdsIter()
		{
			MotorParkour.<RewardIdsIter>d__70 <RewardIdsIter>d__ = new MotorParkour.<RewardIdsIter>d__70(-2);
			<RewardIdsIter>d__.<>3__<>4__this = this;
			return <RewardIdsIter>d__;
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x002B332F File Offset: 0x002B152F
		[NullableContext(1)]
		public float[] UiOffset()
		{
			return this.GetUiOffsetArray();
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x002B3337 File Offset: 0x002B1537
		[NullableContext(1)]
		public IEnumerable<float> UiOffsetIter()
		{
			MotorParkour.<UiOffsetIter>d__72 <UiOffsetIter>d__ = new MotorParkour.<UiOffsetIter>d__72(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x040054F1 RID: 21745
		private Table __p;
	}
}
