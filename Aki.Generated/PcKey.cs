using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9B RID: 3995
	public struct PcKey : IFlatbufferObject
	{
		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x0600A991 RID: 43409 RVA: 0x002C4930 File Offset: 0x002C2B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x002C493D File Offset: 0x002C2B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x002C4944 File Offset: 0x002C2B44
		public static PcKey GetRootAsPcKey(ByteBuffer _bb)
		{
			return PcKey.GetRootAsPcKey(_bb, default(PcKey));
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x002C4960 File Offset: 0x002C2B60
		public static PcKey GetRootAsPcKey(ByteBuffer _bb, PcKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x002C497D File Offset: 0x002C2B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x002C498C File Offset: 0x002C2B8C
		public PcKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x002C499C File Offset: 0x002C2B9C
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

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x002C49D8 File Offset: 0x002C2BD8
		public string KeyName
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

		// Token: 0x0600A999 RID: 43417 RVA: 0x002C4A0F File Offset: 0x002C2C0F
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x002C4A1E File Offset: 0x002C2C1E
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x0600A99B RID: 43419 RVA: 0x002C4A38 File Offset: 0x002C2C38
		public string KeyDescription
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

		// Token: 0x0600A99C RID: 43420 RVA: 0x002C4A6F File Offset: 0x002C2C6F
		public Span<byte> GetKeyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x002C4A7E File Offset: 0x002C2C7E
		public byte[] GetKeyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x002C4A98 File Offset: 0x002C2C98
		public string KeyDisplayName
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

		// Token: 0x0600A99F RID: 43423 RVA: 0x002C4AD0 File Offset: 0x002C2CD0
		public Span<byte> GetKeyDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x002C4AE0 File Offset: 0x002C2CE0
		public byte[] GetKeyDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x0600A9A1 RID: 43425 RVA: 0x002C4AF8 File Offset: 0x002C2CF8
		public string FrenchKeyName
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

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x002C4B30 File Offset: 0x002C2D30
		public Span<byte> GetFrenchKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x002C4B40 File Offset: 0x002C2D40
		public byte[] GetFrenchKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x0600A9A4 RID: 43428 RVA: 0x002C4B58 File Offset: 0x002C2D58
		public string ThaiKeyName
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

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x002C4B90 File Offset: 0x002C2D90
		public Span<byte> GetThaiKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x002C4BA0 File Offset: 0x002C2DA0
		public byte[] GetThaiKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x0600A9A7 RID: 43431 RVA: 0x002C4BB8 File Offset: 0x002C2DB8
		public string KeyIconPath
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

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x002C4BF0 File Offset: 0x002C2DF0
		public Span<byte> GetKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x002C4C00 File Offset: 0x002C2E00
		public byte[] GetKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x0600A9AA RID: 43434 RVA: 0x002C4C18 File Offset: 0x002C2E18
		public string MacKeyIconPath
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

		// Token: 0x0600A9AB RID: 43435 RVA: 0x002C4C50 File Offset: 0x002C2E50
		public Span<byte> GetMacKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x002C4C60 File Offset: 0x002C2E60
		public byte[] GetMacKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x0600A9AD RID: 43437 RVA: 0x002C4C78 File Offset: 0x002C2E78
		public string FrenchKeyIconPath
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

		// Token: 0x0600A9AE RID: 43438 RVA: 0x002C4CB0 File Offset: 0x002C2EB0
		public Span<byte> GetFrenchKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x002C4CC0 File Offset: 0x002C2EC0
		public byte[] GetFrenchKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x0600A9B0 RID: 43440 RVA: 0x002C4CD8 File Offset: 0x002C2ED8
		public string ThaiKeyIconPath
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

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x002C4D10 File Offset: 0x002C2F10
		public Span<byte> GetThaiKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A9B2 RID: 43442 RVA: 0x002C4D20 File Offset: 0x002C2F20
		public byte[] GetThaiKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005551 RID: 21841
		private Table __p;
	}
}
