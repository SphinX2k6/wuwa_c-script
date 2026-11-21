using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001016 RID: 4118
	public struct PinballMonsterRiskType : IFlatbufferObject
	{
		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600B59C RID: 46492 RVA: 0x002DFB0D File Offset: 0x002DDD0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x002DFB1A File Offset: 0x002DDD1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x002DFB24 File Offset: 0x002DDD24
		public static PinballMonsterRiskType GetRootAsPinballMonsterRiskType(ByteBuffer _bb)
		{
			return PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(_bb, default(PinballMonsterRiskType));
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x002DFB40 File Offset: 0x002DDD40
		public static PinballMonsterRiskType GetRootAsPinballMonsterRiskType(ByteBuffer _bb, PinballMonsterRiskType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5A0 RID: 46496 RVA: 0x002DFB5D File Offset: 0x002DDD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x002DFB6C File Offset: 0x002DDD6C
		public PinballMonsterRiskType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600B5A2 RID: 46498 RVA: 0x002DFB7C File Offset: 0x002DDD7C
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

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x0600B5A3 RID: 46499 RVA: 0x002DFBB8 File Offset: 0x002DDDB8
		public string Name
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

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x002DFBEF File Offset: 0x002DDDEF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x002DFBFE File Offset: 0x002DDDFE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x0600B5A6 RID: 46502 RVA: 0x002DFC18 File Offset: 0x002DDE18
		public string Icon1
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

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x002DFC4F File Offset: 0x002DDE4F
		public Span<byte> GetIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x002DFC5E File Offset: 0x002DDE5E
		public byte[] GetIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x0600B5A9 RID: 46505 RVA: 0x002DFC78 File Offset: 0x002DDE78
		public string Icon2
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

		// Token: 0x0600B5AA RID: 46506 RVA: 0x002DFCB0 File Offset: 0x002DDEB0
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x002DFCC0 File Offset: 0x002DDEC0
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600B5AC RID: 46508 RVA: 0x002DFCD8 File Offset: 0x002DDED8
		public string TitleColor
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

		// Token: 0x0600B5AD RID: 46509 RVA: 0x002DFD10 File Offset: 0x002DDF10
		public Span<byte> GetTitleColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x002DFD20 File Offset: 0x002DDF20
		public byte[] GetTitleColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600B5AF RID: 46511 RVA: 0x002DFD38 File Offset: 0x002DDF38
		public string TitleOutlineColor
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

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x002DFD70 File Offset: 0x002DDF70
		public Span<byte> GetTitleOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x002DFD80 File Offset: 0x002DDF80
		public byte[] GetTitleOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040055E0 RID: 21984
		private Table __p;
	}
}
