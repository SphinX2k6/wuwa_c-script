using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001172 RID: 4466
	public struct TravelPhantomQuest : IFlatbufferObject
	{
		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x0033B9CD File Offset: 0x00339BCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4F1 RID: 58609 RVA: 0x0033B9DA File Offset: 0x00339BDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x0033B9E4 File Offset: 0x00339BE4
		public static TravelPhantomQuest GetRootAsTravelPhantomQuest(ByteBuffer _bb)
		{
			return TravelPhantomQuest.GetRootAsTravelPhantomQuest(_bb, default(TravelPhantomQuest));
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x0033BA00 File Offset: 0x00339C00
		public static TravelPhantomQuest GetRootAsTravelPhantomQuest(ByteBuffer _bb, TravelPhantomQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x0033BA1D File Offset: 0x00339C1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x0033BA2C File Offset: 0x00339C2C
		public TravelPhantomQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600E4F6 RID: 58614 RVA: 0x0033BA3C File Offset: 0x00339C3C
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

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x0033BA78 File Offset: 0x00339C78
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

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x0033BAB4 File Offset: 0x00339CB4
		public int MapMarkId
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

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x0033BAF0 File Offset: 0x00339CF0
		public int Sort
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

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600E4FA RID: 58618 RVA: 0x0033BB30 File Offset: 0x00339D30
		public int AreaId
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

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x0033BB70 File Offset: 0x00339D70
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x0033BBB0 File Offset: 0x00339DB0
		public string Name
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

		// Token: 0x0600E4FD RID: 58621 RVA: 0x0033BBE8 File Offset: 0x00339DE8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x0033BBF8 File Offset: 0x00339DF8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x0033BC10 File Offset: 0x00339E10
		public string LockName
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

		// Token: 0x0600E500 RID: 58624 RVA: 0x0033BC48 File Offset: 0x00339E48
		public Span<byte> GetLockNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x0033BC58 File Offset: 0x00339E58
		public byte[] GetLockNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600E502 RID: 58626 RVA: 0x0033BC70 File Offset: 0x00339E70
		public int QuestReward
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600E503 RID: 58627 RVA: 0x0033BCB0 File Offset: 0x00339EB0
		public string Texture
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

		// Token: 0x0600E504 RID: 58628 RVA: 0x0033BCE8 File Offset: 0x00339EE8
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x0033BCF8 File Offset: 0x00339EF8
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600E506 RID: 58630 RVA: 0x0033BD10 File Offset: 0x00339F10
		public string UnlockTips
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

		// Token: 0x0600E507 RID: 58631 RVA: 0x0033BD48 File Offset: 0x00339F48
		public Span<byte> GetUnlockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E508 RID: 58632 RVA: 0x0033BD58 File Offset: 0x00339F58
		public byte[] GetUnlockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600E509 RID: 58633 RVA: 0x0033BD70 File Offset: 0x00339F70
		public string MapDesc
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

		// Token: 0x0600E50A RID: 58634 RVA: 0x0033BDA8 File Offset: 0x00339FA8
		public Span<byte> GetMapDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600E50B RID: 58635 RVA: 0x0033BDB8 File Offset: 0x00339FB8
		public byte[] GetMapDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B8 RID: 21176
		private Table __p;
	}
}
