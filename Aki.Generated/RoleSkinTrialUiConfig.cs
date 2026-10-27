using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001060 RID: 4192
	public struct RoleSkinTrialUiConfig : IFlatbufferObject
	{
		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600CB44 RID: 52036 RVA: 0x00300855 File Offset: 0x002FEA55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x00300862 File Offset: 0x002FEA62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x0030086C File Offset: 0x002FEA6C
		public static RoleSkinTrialUiConfig GetRootAsRoleSkinTrialUiConfig(ByteBuffer _bb)
		{
			return RoleSkinTrialUiConfig.GetRootAsRoleSkinTrialUiConfig(_bb, default(RoleSkinTrialUiConfig));
		}

		// Token: 0x0600CB47 RID: 52039 RVA: 0x00300888 File Offset: 0x002FEA88
		public static RoleSkinTrialUiConfig GetRootAsRoleSkinTrialUiConfig(ByteBuffer _bb, RoleSkinTrialUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x003008A5 File Offset: 0x002FEAA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB49 RID: 52041 RVA: 0x003008B4 File Offset: 0x002FEAB4
		public RoleSkinTrialUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600CB4A RID: 52042 RVA: 0x003008C4 File Offset: 0x002FEAC4
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

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600CB4B RID: 52043 RVA: 0x00300900 File Offset: 0x002FEB00
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

		// Token: 0x0600CB4C RID: 52044 RVA: 0x00300937 File Offset: 0x002FEB37
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x00300946 File Offset: 0x002FEB46
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600CB4E RID: 52046 RVA: 0x00300960 File Offset: 0x002FEB60
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

		// Token: 0x0600CB4F RID: 52047 RVA: 0x00300997 File Offset: 0x002FEB97
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CB50 RID: 52048 RVA: 0x003009A6 File Offset: 0x002FEBA6
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600CB51 RID: 52049 RVA: 0x003009C0 File Offset: 0x002FEBC0
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

		// Token: 0x0600CB52 RID: 52050 RVA: 0x003009F8 File Offset: 0x002FEBF8
		public Span<byte> GetColor3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x00300A08 File Offset: 0x002FEC08
		public byte[] GetColor3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600CB54 RID: 52052 RVA: 0x00300A20 File Offset: 0x002FEC20
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

		// Token: 0x0600CB55 RID: 52053 RVA: 0x00300A58 File Offset: 0x002FEC58
		public Span<byte> GetColor4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x00300A68 File Offset: 0x002FEC68
		public byte[] GetColor4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x00300A80 File Offset: 0x002FEC80
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

		// Token: 0x0600CB58 RID: 52056 RVA: 0x00300AB8 File Offset: 0x002FECB8
		public Span<byte> GetColor5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CB59 RID: 52057 RVA: 0x00300AC8 File Offset: 0x002FECC8
		public byte[] GetColor5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005164 RID: 20836
		private Table __p;
	}
}
