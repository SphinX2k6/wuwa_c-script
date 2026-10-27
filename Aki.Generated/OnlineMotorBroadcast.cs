using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA1 RID: 3745
	public struct OnlineMotorBroadcast : IFlatbufferObject
	{
		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600A129 RID: 41257 RVA: 0x002A2320 File Offset: 0x002A0520
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x002A232D File Offset: 0x002A052D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x002A2334 File Offset: 0x002A0534
		public static OnlineMotorBroadcast GetRootAsOnlineMotorBroadcast(ByteBuffer _bb)
		{
			return OnlineMotorBroadcast.GetRootAsOnlineMotorBroadcast(_bb, default(OnlineMotorBroadcast));
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x002A2350 File Offset: 0x002A0550
		public static OnlineMotorBroadcast GetRootAsOnlineMotorBroadcast(ByteBuffer _bb, OnlineMotorBroadcast obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x002A236D File Offset: 0x002A056D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x002A237C File Offset: 0x002A057C
		public OnlineMotorBroadcast __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600A12F RID: 41263 RVA: 0x002A238C File Offset: 0x002A058C
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

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x002A23C8 File Offset: 0x002A05C8
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

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x0600A131 RID: 41265 RVA: 0x002A2404 File Offset: 0x002A0604
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

		// Token: 0x0600A132 RID: 41266 RVA: 0x002A243B File Offset: 0x002A063B
		public Span<byte> GetSpeakerBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x002A244A File Offset: 0x002A064A
		public byte[] GetSpeakerArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x002A2464 File Offset: 0x002A0664
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

		// Token: 0x0600A135 RID: 41269 RVA: 0x002A249C File Offset: 0x002A069C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x002A24AC File Offset: 0x002A06AC
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F55 RID: 20309
		private Table __p;
	}
}
