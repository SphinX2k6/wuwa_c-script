using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001066 RID: 4198
	public struct RoleTrialUiConfig : IFlatbufferObject
	{
		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600CBBB RID: 52155 RVA: 0x003017F9 File Offset: 0x002FF9F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBBC RID: 52156 RVA: 0x00301806 File Offset: 0x002FFA06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x00301810 File Offset: 0x002FFA10
		public static RoleTrialUiConfig GetRootAsRoleTrialUiConfig(ByteBuffer _bb)
		{
			return RoleTrialUiConfig.GetRootAsRoleTrialUiConfig(_bb, default(RoleTrialUiConfig));
		}

		// Token: 0x0600CBBE RID: 52158 RVA: 0x0030182C File Offset: 0x002FFA2C
		public static RoleTrialUiConfig GetRootAsRoleTrialUiConfig(ByteBuffer _bb, RoleTrialUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBBF RID: 52159 RVA: 0x00301849 File Offset: 0x002FFA49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x00301858 File Offset: 0x002FFA58
		public RoleTrialUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600CBC1 RID: 52161 RVA: 0x00301868 File Offset: 0x002FFA68
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

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x003018A4 File Offset: 0x002FFAA4
		public string Color1
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

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x003018DB File Offset: 0x002FFADB
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBC4 RID: 52164 RVA: 0x003018EA File Offset: 0x002FFAEA
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600CBC5 RID: 52165 RVA: 0x00301904 File Offset: 0x002FFB04
		public string Color2
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

		// Token: 0x0600CBC6 RID: 52166 RVA: 0x0030193B File Offset: 0x002FFB3B
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CBC7 RID: 52167 RVA: 0x0030194A File Offset: 0x002FFB4A
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600CBC8 RID: 52168 RVA: 0x00301964 File Offset: 0x002FFB64
		public string Color3
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

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x0030199C File Offset: 0x002FFB9C
		public Span<byte> GetColor3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x003019AC File Offset: 0x002FFBAC
		public byte[] GetColor3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600CBCB RID: 52171 RVA: 0x003019C4 File Offset: 0x002FFBC4
		public string Color4
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

		// Token: 0x0600CBCC RID: 52172 RVA: 0x003019FC File Offset: 0x002FFBFC
		public Span<byte> GetColor4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x00301A0C File Offset: 0x002FFC0C
		public byte[] GetColor4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600CBCE RID: 52174 RVA: 0x00301A24 File Offset: 0x002FFC24
		public string Color5
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

		// Token: 0x0600CBCF RID: 52175 RVA: 0x00301A5C File Offset: 0x002FFC5C
		public Span<byte> GetColor5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x00301A6C File Offset: 0x002FFC6C
		public byte[] GetColor5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400516B RID: 20843
		private Table __p;
	}
}
