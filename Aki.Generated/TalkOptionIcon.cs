using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001115 RID: 4373
	public struct TalkOptionIcon : IFlatbufferObject
	{
		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600DCCA RID: 56522 RVA: 0x00329568 File Offset: 0x00327768
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DCCB RID: 56523 RVA: 0x00329575 File Offset: 0x00327775
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DCCC RID: 56524 RVA: 0x0032957C File Offset: 0x0032777C
		public static TalkOptionIcon GetRootAsTalkOptionIcon(ByteBuffer _bb)
		{
			return TalkOptionIcon.GetRootAsTalkOptionIcon(_bb, default(TalkOptionIcon));
		}

		// Token: 0x0600DCCD RID: 56525 RVA: 0x00329598 File Offset: 0x00327798
		public static TalkOptionIcon GetRootAsTalkOptionIcon(ByteBuffer _bb, TalkOptionIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DCCE RID: 56526 RVA: 0x003295B5 File Offset: 0x003277B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DCCF RID: 56527 RVA: 0x003295C4 File Offset: 0x003277C4
		public TalkOptionIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x003295D4 File Offset: 0x003277D4
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

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600DCD1 RID: 56529 RVA: 0x00329610 File Offset: 0x00327810
		public string Type
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

		// Token: 0x0600DCD2 RID: 56530 RVA: 0x00329647 File Offset: 0x00327847
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DCD3 RID: 56531 RVA: 0x00329656 File Offset: 0x00327856
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600DCD4 RID: 56532 RVA: 0x00329670 File Offset: 0x00327870
		public string Icon
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

		// Token: 0x0600DCD5 RID: 56533 RVA: 0x003296A7 File Offset: 0x003278A7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DCD6 RID: 56534 RVA: 0x003296B6 File Offset: 0x003278B6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005252 RID: 21074
		private Table __p;
	}
}
