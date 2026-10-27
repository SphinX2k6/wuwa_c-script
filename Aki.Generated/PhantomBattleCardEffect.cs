using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC1 RID: 3777
	public struct PhantomBattleCardEffect : IFlatbufferObject
	{
		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x002ABDF8 File Offset: 0x002A9FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A547 RID: 42311 RVA: 0x002ABE05 File Offset: 0x002AA005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A548 RID: 42312 RVA: 0x002ABE0C File Offset: 0x002AA00C
		public static PhantomBattleCardEffect GetRootAsPhantomBattleCardEffect(ByteBuffer _bb)
		{
			return PhantomBattleCardEffect.GetRootAsPhantomBattleCardEffect(_bb, default(PhantomBattleCardEffect));
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x002ABE28 File Offset: 0x002AA028
		public static PhantomBattleCardEffect GetRootAsPhantomBattleCardEffect(ByteBuffer _bb, PhantomBattleCardEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x002ABE45 File Offset: 0x002AA045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x002ABE54 File Offset: 0x002AA054
		public PhantomBattleCardEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x002ABE64 File Offset: 0x002AA064
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

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600A54D RID: 42317 RVA: 0x002ABEA0 File Offset: 0x002AA0A0
		public string BaseColor
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

		// Token: 0x0600A54E RID: 42318 RVA: 0x002ABED7 File Offset: 0x002AA0D7
		public Span<byte> GetBaseColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x002ABEE6 File Offset: 0x002AA0E6
		public byte[] GetBaseColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x002ABF00 File Offset: 0x002AA100
		public string BackGroundColor
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

		// Token: 0x0600A551 RID: 42321 RVA: 0x002ABF37 File Offset: 0x002AA137
		public Span<byte> GetBackGroundColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x002ABF46 File Offset: 0x002AA146
		public byte[] GetBackGroundColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x0600A553 RID: 42323 RVA: 0x002ABF60 File Offset: 0x002AA160
		public string FieldIcon
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

		// Token: 0x0600A554 RID: 42324 RVA: 0x002ABF98 File Offset: 0x002AA198
		public Span<byte> GetFieldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x002ABFA8 File Offset: 0x002AA1A8
		public byte[] GetFieldIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600A556 RID: 42326 RVA: 0x002ABFC0 File Offset: 0x002AA1C0
		public string FieldRing
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

		// Token: 0x0600A557 RID: 42327 RVA: 0x002ABFF8 File Offset: 0x002AA1F8
		public Span<byte> GetFieldRingBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x002AC008 File Offset: 0x002AA208
		public byte[] GetFieldRingArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600A559 RID: 42329 RVA: 0x002AC020 File Offset: 0x002AA220
		public string FieldActivateIcon
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

		// Token: 0x0600A55A RID: 42330 RVA: 0x002AC058 File Offset: 0x002AA258
		public Span<byte> GetFieldActivateIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x002AC068 File Offset: 0x002AA268
		public byte[] GetFieldActivateIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x002AC080 File Offset: 0x002AA280
		public string FieldActivateRing
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

		// Token: 0x0600A55D RID: 42333 RVA: 0x002AC0B8 File Offset: 0x002AA2B8
		public Span<byte> GetFieldActivateRingBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x002AC0C8 File Offset: 0x002AA2C8
		public byte[] GetFieldActivateRingArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600A55F RID: 42335 RVA: 0x002AC0E0 File Offset: 0x002AA2E0
		public string FieldButtonColor
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

		// Token: 0x0600A560 RID: 42336 RVA: 0x002AC118 File Offset: 0x002AA318
		public Span<byte> GetFieldButtonColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A561 RID: 42337 RVA: 0x002AC128 File Offset: 0x002AA328
		public byte[] GetFieldButtonColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x002AC140 File Offset: 0x002AA340
		public string FieldNorColor
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

		// Token: 0x0600A563 RID: 42339 RVA: 0x002AC178 File Offset: 0x002AA378
		public Span<byte> GetFieldNorColorBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x002AC188 File Offset: 0x002AA388
		public byte[] GetFieldNorColorArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600A565 RID: 42341 RVA: 0x002AC1A0 File Offset: 0x002AA3A0
		public string FieldActivateColor
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

		// Token: 0x0600A566 RID: 42342 RVA: 0x002AC1D8 File Offset: 0x002AA3D8
		public Span<byte> GetFieldActivateColorBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x002AC1E8 File Offset: 0x002AA3E8
		public byte[] GetFieldActivateColorArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x002AC200 File Offset: 0x002AA400
		public string FieldLightColor
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

		// Token: 0x0600A569 RID: 42345 RVA: 0x002AC238 File Offset: 0x002AA438
		public Span<byte> GetFieldLightColorBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x002AC248 File Offset: 0x002AA448
		public byte[] GetFieldLightColorArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600A56B RID: 42347 RVA: 0x002AC260 File Offset: 0x002AA460
		public string FieldReleaseColor
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

		// Token: 0x0600A56C RID: 42348 RVA: 0x002AC298 File Offset: 0x002AA498
		public Span<byte> GetFieldReleaseColorBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x002AC2A8 File Offset: 0x002AA4A8
		public byte[] GetFieldReleaseColorArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x002AC2C0 File Offset: 0x002AA4C0
		public string FieldSkillTexRelease
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

		// Token: 0x0600A56F RID: 42351 RVA: 0x002AC2F8 File Offset: 0x002AA4F8
		public Span<byte> GetFieldSkillTexReleaseBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x002AC308 File Offset: 0x002AA508
		public byte[] GetFieldSkillTexReleaseArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600A571 RID: 42353 RVA: 0x002AC320 File Offset: 0x002AA520
		public string FieldSkillTexBg
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

		// Token: 0x0600A572 RID: 42354 RVA: 0x002AC358 File Offset: 0x002AA558
		public Span<byte> GetFieldSkillTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x002AC368 File Offset: 0x002AA568
		public byte[] GetFieldSkillTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600A574 RID: 42356 RVA: 0x002AC380 File Offset: 0x002AA580
		public string FieldSkillTexIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x002AC3B8 File Offset: 0x002AA5B8
		public Span<byte> GetFieldSkillTexIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x002AC3C8 File Offset: 0x002AA5C8
		public byte[] GetFieldSkillTexIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600A577 RID: 42359 RVA: 0x002AC3E0 File Offset: 0x002AA5E0
		public string FieldTexSmokeColor
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

		// Token: 0x0600A578 RID: 42360 RVA: 0x002AC418 File Offset: 0x002AA618
		public Span<byte> GetFieldTexSmokeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x002AC428 File Offset: 0x002AA628
		public byte[] GetFieldTexSmokeColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F7D RID: 20349
		private Table __p;
	}
}
