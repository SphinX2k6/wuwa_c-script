using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC3 RID: 3267
	public struct DarkCoastDelivery : IFlatbufferObject
	{
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060066C8 RID: 26312 RVA: 0x002300B5 File Offset: 0x0022E2B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060066C9 RID: 26313 RVA: 0x002300C2 File Offset: 0x0022E2C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060066CA RID: 26314 RVA: 0x002300CC File Offset: 0x0022E2CC
		public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb)
		{
			return DarkCoastDelivery.GetRootAsDarkCoastDelivery(_bb, default(DarkCoastDelivery));
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x002300E8 File Offset: 0x0022E2E8
		public static DarkCoastDelivery GetRootAsDarkCoastDelivery(ByteBuffer _bb, DarkCoastDelivery obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00230105 File Offset: 0x0022E305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x00230114 File Offset: 0x0022E314
		public DarkCoastDelivery __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060066CE RID: 26318 RVA: 0x00230124 File Offset: 0x0022E324
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

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x00230160 File Offset: 0x0022E360
		public string Icon
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

		// Token: 0x060066D0 RID: 26320 RVA: 0x00230197 File Offset: 0x0022E397
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x002301A6 File Offset: 0x0022E3A6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060066D2 RID: 26322 RVA: 0x002301C0 File Offset: 0x0022E3C0
		public string LevelTexture
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

		// Token: 0x060066D3 RID: 26323 RVA: 0x002301F7 File Offset: 0x0022E3F7
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060066D4 RID: 26324 RVA: 0x00230206 File Offset: 0x0022E406
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060066D5 RID: 26325 RVA: 0x00230220 File Offset: 0x0022E420
		public string LevelIcon
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

		// Token: 0x060066D6 RID: 26326 RVA: 0x00230258 File Offset: 0x0022E458
		public Span<byte> GetLevelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060066D7 RID: 26327 RVA: 0x00230268 File Offset: 0x0022E468
		public byte[] GetLevelIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060066D8 RID: 26328 RVA: 0x00230280 File Offset: 0x0022E480
		public string LevelSelectIcon
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

		// Token: 0x060066D9 RID: 26329 RVA: 0x002302B8 File Offset: 0x0022E4B8
		public Span<byte> GetLevelSelectIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060066DA RID: 26330 RVA: 0x002302C8 File Offset: 0x0022E4C8
		public byte[] GetLevelSelectIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060066DB RID: 26331 RVA: 0x002302E0 File Offset: 0x0022E4E0
		public string TipIcon
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

		// Token: 0x060066DC RID: 26332 RVA: 0x00230318 File Offset: 0x0022E518
		public Span<byte> GetTipIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00230328 File Offset: 0x0022E528
		public byte[] GetTipIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060066DE RID: 26334 RVA: 0x00230340 File Offset: 0x0022E540
		public string TipLockIcon
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

		// Token: 0x060066DF RID: 26335 RVA: 0x00230378 File Offset: 0x0022E578
		public Span<byte> GetTipLockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060066E0 RID: 26336 RVA: 0x00230388 File Offset: 0x0022E588
		public byte[] GetTipLockIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060066E1 RID: 26337 RVA: 0x002303A0 File Offset: 0x0022E5A0
		public string TipName
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

		// Token: 0x060066E2 RID: 26338 RVA: 0x002303D8 File Offset: 0x0022E5D8
		public Span<byte> GetTipNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x002303E8 File Offset: 0x0022E5E8
		public byte[] GetTipNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060066E4 RID: 26340 RVA: 0x00230400 File Offset: 0x0022E600
		public string TipDesc
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

		// Token: 0x060066E5 RID: 26341 RVA: 0x00230438 File Offset: 0x0022E638
		public Span<byte> GetTipDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060066E6 RID: 26342 RVA: 0x00230448 File Offset: 0x0022E648
		public byte[] GetTipDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060066E7 RID: 26343 RVA: 0x00230460 File Offset: 0x0022E660
		public int RewardCount
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x002304A0 File Offset: 0x0022E6A0
		public string UnlockCondition
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

		// Token: 0x060066E9 RID: 26345 RVA: 0x002304D8 File Offset: 0x0022E6D8
		public Span<byte> GetUnlockConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x002304E8 File Offset: 0x0022E6E8
		public byte[] GetUnlockConditionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060066EB RID: 26347 RVA: 0x00230500 File Offset: 0x0022E700
		public string VisionTexture
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

		// Token: 0x060066EC RID: 26348 RVA: 0x00230538 File Offset: 0x0022E738
		public Span<byte> GetVisionTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00230548 File Offset: 0x0022E748
		public byte[] GetVisionTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x00230560 File Offset: 0x0022E760
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060066EF RID: 26351 RVA: 0x002305A0 File Offset: 0x0022E7A0
		public int LevelPlayId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051F0 RID: 20976
		private Table __p;
	}
}
