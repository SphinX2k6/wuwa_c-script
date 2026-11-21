using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001148 RID: 4424
	public struct RoleSkinTrialUiConfig : IFlatbufferObject
	{
		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600D19B RID: 53659 RVA: 0x0031CC4D File Offset: 0x0031AE4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x0031CC5A File Offset: 0x0031AE5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D19D RID: 53661 RVA: 0x0031CC64 File Offset: 0x0031AE64
		public static RoleSkinTrialUiConfig GetRootAsRoleSkinTrialUiConfig(ByteBuffer _bb)
		{
			return RoleSkinTrialUiConfig.GetRootAsRoleSkinTrialUiConfig(_bb, default(RoleSkinTrialUiConfig));
		}

		// Token: 0x0600D19E RID: 53662 RVA: 0x0031CC80 File Offset: 0x0031AE80
		public static RoleSkinTrialUiConfig GetRootAsRoleSkinTrialUiConfig(ByteBuffer _bb, RoleSkinTrialUiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D19F RID: 53663 RVA: 0x0031CC9D File Offset: 0x0031AE9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1A0 RID: 53664 RVA: 0x0031CCAC File Offset: 0x0031AEAC
		public RoleSkinTrialUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600D1A1 RID: 53665 RVA: 0x0031CCBC File Offset: 0x0031AEBC
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

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x0031CCF8 File Offset: 0x0031AEF8
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

		// Token: 0x0600D1A3 RID: 53667 RVA: 0x0031CD2F File Offset: 0x0031AF2F
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D1A4 RID: 53668 RVA: 0x0031CD3E File Offset: 0x0031AF3E
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600D1A5 RID: 53669 RVA: 0x0031CD58 File Offset: 0x0031AF58
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

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x0031CD8F File Offset: 0x0031AF8F
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x0031CD9E File Offset: 0x0031AF9E
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x0031CDB8 File Offset: 0x0031AFB8
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

		// Token: 0x0600D1A9 RID: 53673 RVA: 0x0031CDF0 File Offset: 0x0031AFF0
		public Span<byte> GetColor3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D1AA RID: 53674 RVA: 0x0031CE00 File Offset: 0x0031B000
		public byte[] GetColor3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600D1AB RID: 53675 RVA: 0x0031CE18 File Offset: 0x0031B018
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

		// Token: 0x0600D1AC RID: 53676 RVA: 0x0031CE50 File Offset: 0x0031B050
		public Span<byte> GetColor4Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D1AD RID: 53677 RVA: 0x0031CE60 File Offset: 0x0031B060
		public byte[] GetColor4Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600D1AE RID: 53678 RVA: 0x0031CE78 File Offset: 0x0031B078
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

		// Token: 0x0600D1AF RID: 53679 RVA: 0x0031CEB0 File Offset: 0x0031B0B0
		public Span<byte> GetColor5Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x0031CEC0 File Offset: 0x0031B0C0
		public byte[] GetColor5Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400574C RID: 22348
		private Table __p;
	}
}
