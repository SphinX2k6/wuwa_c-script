using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCD RID: 3533
	public struct GamepadKey : IFlatbufferObject
	{
		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06007EEF RID: 32495 RVA: 0x002663D0 File Offset: 0x002645D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007EF0 RID: 32496 RVA: 0x002663DD File Offset: 0x002645DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x002663E4 File Offset: 0x002645E4
		public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb)
		{
			return GamepadKey.GetRootAsGamepadKey(_bb, default(GamepadKey));
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x00266400 File Offset: 0x00264600
		public static GamepadKey GetRootAsGamepadKey(ByteBuffer _bb, GamepadKey obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007EF3 RID: 32499 RVA: 0x0026641D File Offset: 0x0026461D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007EF4 RID: 32500 RVA: 0x0026642C File Offset: 0x0026462C
		public GamepadKey __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x06007EF5 RID: 32501 RVA: 0x0026643C File Offset: 0x0026463C
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

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x00266478 File Offset: 0x00264678
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

		// Token: 0x06007EF7 RID: 32503 RVA: 0x002664AF File Offset: 0x002646AF
		public Span<byte> GetKeyNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x002664BE File Offset: 0x002646BE
		public byte[] GetKeyNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06007EF9 RID: 32505 RVA: 0x002664D8 File Offset: 0x002646D8
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

		// Token: 0x06007EFA RID: 32506 RVA: 0x0026650F File Offset: 0x0026470F
		public Span<byte> GetKeyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0026651E File Offset: 0x0026471E
		public byte[] GetKeyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x06007EFC RID: 32508 RVA: 0x00266538 File Offset: 0x00264738
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

		// Token: 0x06007EFD RID: 32509 RVA: 0x00266570 File Offset: 0x00264770
		public Span<byte> GetKeyDisplayNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x00266580 File Offset: 0x00264780
		public byte[] GetKeyDisplayNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06007EFF RID: 32511 RVA: 0x00266598 File Offset: 0x00264798
		public string KeyIconPath
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

		// Token: 0x06007F00 RID: 32512 RVA: 0x002665D0 File Offset: 0x002647D0
		public Span<byte> GetKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x002665E0 File Offset: 0x002647E0
		public byte[] GetKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x002665F8 File Offset: 0x002647F8
		public string PsKeyIconPath
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

		// Token: 0x06007F03 RID: 32515 RVA: 0x00266630 File Offset: 0x00264830
		public Span<byte> GetPsKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x00266640 File Offset: 0x00264840
		public byte[] GetPsKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06007F05 RID: 32517 RVA: 0x00266658 File Offset: 0x00264858
		public string BackBoneKeyIconPath
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

		// Token: 0x06007F06 RID: 32518 RVA: 0x00266690 File Offset: 0x00264890
		public Span<byte> GetBackBoneKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x002666A0 File Offset: 0x002648A0
		public byte[] GetBackBoneKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06007F08 RID: 32520 RVA: 0x002666B8 File Offset: 0x002648B8
		public string NsKeyIconPath
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

		// Token: 0x06007F09 RID: 32521 RVA: 0x002666F0 File Offset: 0x002648F0
		public Span<byte> GetNsKeyIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x00266700 File Offset: 0x00264900
		public byte[] GetNsKeyIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400533E RID: 21310
		private Table __p;
	}
}
