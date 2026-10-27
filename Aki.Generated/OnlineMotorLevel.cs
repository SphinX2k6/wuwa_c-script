using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA3 RID: 3747
	public struct OnlineMotorLevel : IFlatbufferObject
	{
		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x0600A150 RID: 41296 RVA: 0x002A2864 File Offset: 0x002A0A64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x002A2871 File Offset: 0x002A0A71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x002A2878 File Offset: 0x002A0A78
		public static OnlineMotorLevel GetRootAsOnlineMotorLevel(ByteBuffer _bb)
		{
			return OnlineMotorLevel.GetRootAsOnlineMotorLevel(_bb, default(OnlineMotorLevel));
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x002A2894 File Offset: 0x002A0A94
		public static OnlineMotorLevel GetRootAsOnlineMotorLevel(ByteBuffer _bb, OnlineMotorLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x002A28B1 File Offset: 0x002A0AB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x002A28C0 File Offset: 0x002A0AC0
		public OnlineMotorLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600A156 RID: 41302 RVA: 0x002A28D0 File Offset: 0x002A0AD0
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

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x002A290C File Offset: 0x002A0B0C
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

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x002A2948 File Offset: 0x002A0B48
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

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600A159 RID: 41305 RVA: 0x002A2984 File Offset: 0x002A0B84
		public int PreLevel
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

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x002A29C4 File Offset: 0x002A0BC4
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A15B RID: 41307 RVA: 0x002A2A04 File Offset: 0x002A0C04
		public int LevelTaskIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x002A2A44 File Offset: 0x002A0C44
		public int LevelTaskIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x002A2A70 File Offset: 0x002A0C70
		public Span<int> GetLevelTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x002A2A80 File Offset: 0x002A0C80
		public int[] GetLevelTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600A15F RID: 41311 RVA: 0x002A2A98 File Offset: 0x002A0C98
		public string LevelTitleSprite
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

		// Token: 0x0600A160 RID: 41312 RVA: 0x002A2AD0 File Offset: 0x002A0CD0
		public Span<byte> GetLevelTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x002A2AE0 File Offset: 0x002A0CE0
		public byte[] GetLevelTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x002A2AF8 File Offset: 0x002A0CF8
		public string LevelRomanSprite
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

		// Token: 0x0600A163 RID: 41315 RVA: 0x002A2B30 File Offset: 0x002A0D30
		public Span<byte> GetLevelRomanSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x002A2B40 File Offset: 0x002A0D40
		public byte[] GetLevelRomanSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600A165 RID: 41317 RVA: 0x002A2B58 File Offset: 0x002A0D58
		public string LevelTitleTexture
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

		// Token: 0x0600A166 RID: 41318 RVA: 0x002A2B90 File Offset: 0x002A0D90
		public Span<byte> GetLevelTitleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x002A2BA0 File Offset: 0x002A0DA0
		public byte[] GetLevelTitleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600A168 RID: 41320 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		public string LevelTitleTextureSelect
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

		// Token: 0x0600A169 RID: 41321 RVA: 0x002A2BF0 File Offset: 0x002A0DF0
		public Span<byte> GetLevelTitleTextureSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x002A2C00 File Offset: 0x002A0E00
		public byte[] GetLevelTitleTextureSelectArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600A16B RID: 41323 RVA: 0x002A2C18 File Offset: 0x002A0E18
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

		// Token: 0x0600A16C RID: 41324 RVA: 0x002A2C50 File Offset: 0x002A0E50
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x002A2C60 File Offset: 0x002A0E60
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x002A2C78 File Offset: 0x002A0E78
		public string LevelTexture
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

		// Token: 0x0600A16F RID: 41327 RVA: 0x002A2CB0 File Offset: 0x002A0EB0
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x002A2CC0 File Offset: 0x002A0EC0
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600A171 RID: 41329 RVA: 0x002A2CD8 File Offset: 0x002A0ED8
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x002A2D18 File Offset: 0x002A0F18
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x002A2D5C File Offset: 0x002A0F5C
		public int CenterOffsetLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x002A2D88 File Offset: 0x002A0F88
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x002A2D98 File Offset: 0x002A0F98
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x002A2DB0 File Offset: 0x002A0FB0
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600A177 RID: 41335 RVA: 0x002A2DF4 File Offset: 0x002A0FF4
		public int UiOffsetLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x002A2E20 File Offset: 0x002A1020
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(32, 4);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x002A2E30 File Offset: 0x002A1030
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(32) ?? Array.Empty<float>();
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600A17A RID: 41338 RVA: 0x002A2E48 File Offset: 0x002A1048
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600A17B RID: 41339 RVA: 0x002A2E8C File Offset: 0x002A108C
		public int SplineId
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

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600A17C RID: 41340 RVA: 0x002A2ECC File Offset: 0x002A10CC
		public int SplineStartIndex
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

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600A17D RID: 41341 RVA: 0x002A2F0C File Offset: 0x002A110C
		public int SplineEndIndex
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600A17E RID: 41342 RVA: 0x002A2F4C File Offset: 0x002A114C
		public int RouteTextureRotation
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x002A2F8C File Offset: 0x002A118C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CenterOffsetIter()或GetCenterOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CenterOffset()
		{
			OnlineMotorLevel onlineMotorLevel = this;
			return onlineMotorLevel.GetCenterOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x002A2FB0 File Offset: 0x002A11B0
		[NullableContext(1)]
		public readonly IEnumerable<float> CenterOffsetIter()
		{
			OnlineMotorLevel.<CenterOffsetIter>d__70 <CenterOffsetIter>d__ = new OnlineMotorLevel.<CenterOffsetIter>d__70(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x002A2FC8 File Offset: 0x002A11C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelTaskIdsIter()或GetLevelTaskIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelTaskIds()
		{
			OnlineMotorLevel onlineMotorLevel = this;
			return onlineMotorLevel.GetLevelTaskIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x002A2FEC File Offset: 0x002A11EC
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelTaskIdsIter()
		{
			OnlineMotorLevel.<LevelTaskIdsIter>d__72 <LevelTaskIdsIter>d__ = new OnlineMotorLevel.<LevelTaskIdsIter>d__72(-2);
			<LevelTaskIdsIter>d__.<>3__<>4__this = this;
			return <LevelTaskIdsIter>d__;
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x002A3004 File Offset: 0x002A1204
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiOffsetIter()或GetUiOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] UiOffset()
		{
			OnlineMotorLevel onlineMotorLevel = this;
			return onlineMotorLevel.GetUiOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x002A3028 File Offset: 0x002A1228
		[NullableContext(1)]
		public readonly IEnumerable<float> UiOffsetIter()
		{
			OnlineMotorLevel.<UiOffsetIter>d__74 <UiOffsetIter>d__ = new OnlineMotorLevel.<UiOffsetIter>d__74(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x04004F57 RID: 20311
		private Table __p;
	}
}
