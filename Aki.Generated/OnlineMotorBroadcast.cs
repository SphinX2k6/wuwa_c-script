using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F86 RID: 3974
	public struct OnlineMotorBroadcast : IFlatbufferObject
	{
		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x0600A749 RID: 42825 RVA: 0x002BF808 File Offset: 0x002BDA08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x002BF815 File Offset: 0x002BDA15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x002BF81C File Offset: 0x002BDA1C
		public static OnlineMotorBroadcast GetRootAsOnlineMotorBroadcast(ByteBuffer _bb)
		{
			return OnlineMotorBroadcast.GetRootAsOnlineMotorBroadcast(_bb, default(OnlineMotorBroadcast));
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x002BF838 File Offset: 0x002BDA38
		public static OnlineMotorBroadcast GetRootAsOnlineMotorBroadcast(ByteBuffer _bb, OnlineMotorBroadcast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x002BF855 File Offset: 0x002BDA55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x002BF864 File Offset: 0x002BDA64
		public OnlineMotorBroadcast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x002BF874 File Offset: 0x002BDA74
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

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x002BF8B0 File Offset: 0x002BDAB0
		public int BroadcastGroup
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

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x002BF8EC File Offset: 0x002BDAEC
		public string Speaker
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

		// Token: 0x0600A752 RID: 42834 RVA: 0x002BF923 File Offset: 0x002BDB23
		public Span<byte> GetSpeakerBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A753 RID: 42835 RVA: 0x002BF932 File Offset: 0x002BDB32
		public byte[] GetSpeakerArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x0600A754 RID: 42836 RVA: 0x002BF94C File Offset: 0x002BDB4C
		public string Content
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

		// Token: 0x0600A755 RID: 42837 RVA: 0x002BF984 File Offset: 0x002BDB84
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x002BF994 File Offset: 0x002BDB94
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0400553A RID: 21818
		private Table __p;
	}
}
