using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA5 RID: 3493
	public struct FloroRanchWeeklyEvent : IFlatbufferObject
	{
		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x0025E697 File Offset: 0x0025C897
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x0025E6A4 File Offset: 0x0025C8A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x0025E6AC File Offset: 0x0025C8AC
		public static FloroRanchWeeklyEvent GetRootAsFloroRanchWeeklyEvent(ByteBuffer _bb)
		{
			return FloroRanchWeeklyEvent.GetRootAsFloroRanchWeeklyEvent(_bb, default(FloroRanchWeeklyEvent));
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x0025E6C8 File Offset: 0x0025C8C8
		public static FloroRanchWeeklyEvent GetRootAsFloroRanchWeeklyEvent(ByteBuffer _bb, FloroRanchWeeklyEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x0025E6E5 File Offset: 0x0025C8E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0025E6F4 File Offset: 0x0025C8F4
		public FloroRanchWeeklyEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x06007B51 RID: 31569 RVA: 0x0025E704 File Offset: 0x0025C904
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

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x06007B52 RID: 31570 RVA: 0x0025E740 File Offset: 0x0025C940
		public string Title
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

		// Token: 0x06007B53 RID: 31571 RVA: 0x0025E777 File Offset: 0x0025C977
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0025E786 File Offset: 0x0025C986
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x0025E7A0 File Offset: 0x0025C9A0
		public string Desc
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

		// Token: 0x06007B56 RID: 31574 RVA: 0x0025E7D7 File Offset: 0x0025C9D7
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x0025E7E6 File Offset: 0x0025C9E6
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005315 RID: 21269
		private Table __p;
	}
}
