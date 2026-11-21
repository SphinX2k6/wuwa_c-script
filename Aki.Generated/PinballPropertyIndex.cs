using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001019 RID: 4121
	public struct PinballPropertyIndex : IFlatbufferObject
	{
		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600B5EB RID: 46571 RVA: 0x002E04B5 File Offset: 0x002DE6B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x002E04C2 File Offset: 0x002DE6C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x002E04CC File Offset: 0x002DE6CC
		public static PinballPropertyIndex GetRootAsPinballPropertyIndex(ByteBuffer _bb)
		{
			return PinballPropertyIndex.GetRootAsPinballPropertyIndex(_bb, default(PinballPropertyIndex));
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x002E04E8 File Offset: 0x002DE6E8
		public static PinballPropertyIndex GetRootAsPinballPropertyIndex(ByteBuffer _bb, PinballPropertyIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x002E0505 File Offset: 0x002DE705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x002E0514 File Offset: 0x002DE714
		public PinballPropertyIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600B5F1 RID: 46577 RVA: 0x002E0524 File Offset: 0x002DE724
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

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x002E0560 File Offset: 0x002DE760
		public string Key
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

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x002E0597 File Offset: 0x002DE797
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x002E05A6 File Offset: 0x002DE7A6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600B5F5 RID: 46581 RVA: 0x002E05C0 File Offset: 0x002DE7C0
		public string Name
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

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x002E05F7 File Offset: 0x002DE7F7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x002E0606 File Offset: 0x002DE806
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x0600B5F8 RID: 46584 RVA: 0x002E0620 File Offset: 0x002DE820
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0600B5F9 RID: 46585 RVA: 0x002E0660 File Offset: 0x002DE860
		public string Icon
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

		// Token: 0x0600B5FA RID: 46586 RVA: 0x002E0698 File Offset: 0x002DE898
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B5FB RID: 46587 RVA: 0x002E06A8 File Offset: 0x002DE8A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0600B5FC RID: 46588 RVA: 0x002E06C0 File Offset: 0x002DE8C0
		public string Desc
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

		// Token: 0x0600B5FD RID: 46589 RVA: 0x002E06F8 File Offset: 0x002DE8F8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x002E0708 File Offset: 0x002DE908
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600B5FF RID: 46591 RVA: 0x002E0720 File Offset: 0x002DE920
		public int KscAttrType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600B600 RID: 46592 RVA: 0x002E0760 File Offset: 0x002DE960
		public int ShowCoefficient
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055E3 RID: 21987
		private Table __p;
	}
}
