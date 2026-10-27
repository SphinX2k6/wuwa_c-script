using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E47 RID: 3655
	public struct MotorFightLevelType : IFlatbufferObject
	{
		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x0028F7DD File Offset: 0x0028D9DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x0028F7EA File Offset: 0x0028D9EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x0028F7F4 File Offset: 0x0028D9F4
		public static MotorFightLevelType GetRootAsMotorFightLevelType(ByteBuffer _bb)
		{
			return MotorFightLevelType.GetRootAsMotorFightLevelType(_bb, default(MotorFightLevelType));
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x0028F810 File Offset: 0x0028DA10
		public static MotorFightLevelType GetRootAsMotorFightLevelType(ByteBuffer _bb, MotorFightLevelType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x0028F82D File Offset: 0x0028DA2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x0028F83C File Offset: 0x0028DA3C
		public MotorFightLevelType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x0028F84C File Offset: 0x0028DA4C
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x060098AE RID: 39086 RVA: 0x0028F888 File Offset: 0x0028DA88
		public string Hold
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

		// Token: 0x060098AF RID: 39087 RVA: 0x0028F8BF File Offset: 0x0028DABF
		public Span<byte> GetHoldBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x0028F8CE File Offset: 0x0028DACE
		public byte[] GetHoldArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x0028F8E8 File Offset: 0x0028DAE8
		public string Mask
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

		// Token: 0x060098B2 RID: 39090 RVA: 0x0028F91F File Offset: 0x0028DB1F
		public Span<byte> GetMaskBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x0028F92E File Offset: 0x0028DB2E
		public byte[] GetMaskArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x060098B4 RID: 39092 RVA: 0x0028F948 File Offset: 0x0028DB48
		public string Light
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

		// Token: 0x060098B5 RID: 39093 RVA: 0x0028F980 File Offset: 0x0028DB80
		public Span<byte> GetLightBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x0028F990 File Offset: 0x0028DB90
		public byte[] GetLightArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x060098B7 RID: 39095 RVA: 0x0028F9A8 File Offset: 0x0028DBA8
		public string Bg
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

		// Token: 0x060098B8 RID: 39096 RVA: 0x0028F9E0 File Offset: 0x0028DBE0
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x0028F9F0 File Offset: 0x0028DBF0
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x060098BA RID: 39098 RVA: 0x0028FA08 File Offset: 0x0028DC08
		public string Title
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

		// Token: 0x060098BB RID: 39099 RVA: 0x0028FA40 File Offset: 0x0028DC40
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x0028FA50 File Offset: 0x0028DC50
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x0028FA68 File Offset: 0x0028DC68
		public string SelectLevelState
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

		// Token: 0x060098BE RID: 39102 RVA: 0x0028FAA0 File Offset: 0x0028DCA0
		public Span<byte> GetSelectLevelStateBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0028FAB0 File Offset: 0x0028DCB0
		public byte[] GetSelectLevelStateArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x060098C0 RID: 39104 RVA: 0x0028FAC8 File Offset: 0x0028DCC8
		public string SelectLevelStateBg
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

		// Token: 0x060098C1 RID: 39105 RVA: 0x0028FB00 File Offset: 0x0028DD00
		public Span<byte> GetSelectLevelStateBgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x0028FB10 File Offset: 0x0028DD10
		public byte[] GetSelectLevelStateBgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EEF RID: 20207
		private Table __p;
	}
}
