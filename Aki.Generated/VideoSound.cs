using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001190 RID: 4496
	public struct VideoSound : IFlatbufferObject
	{
		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600E74C RID: 59212 RVA: 0x00341169 File Offset: 0x0033F369
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x00341176 File Offset: 0x0033F376
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x00341180 File Offset: 0x0033F380
		public static VideoSound GetRootAsVideoSound(ByteBuffer _bb)
		{
			return VideoSound.GetRootAsVideoSound(_bb, default(VideoSound));
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x0034119C File Offset: 0x0033F39C
		public static VideoSound GetRootAsVideoSound(ByteBuffer _bb, VideoSound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x003411B9 File Offset: 0x0033F3B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x003411C8 File Offset: 0x0033F3C8
		public VideoSound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600E752 RID: 59218 RVA: 0x003411D8 File Offset: 0x0033F3D8
		public int CaptionId
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

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600E753 RID: 59219 RVA: 0x00341214 File Offset: 0x0033F414
		public string CgName
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

		// Token: 0x0600E754 RID: 59220 RVA: 0x0034124B File Offset: 0x0033F44B
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x0034125A File Offset: 0x0033F45A
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600E756 RID: 59222 RVA: 0x00341274 File Offset: 0x0033F474
		public int GirlOrBoy
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600E757 RID: 59223 RVA: 0x003412B0 File Offset: 0x0033F4B0
		public string EventPath
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

		// Token: 0x0600E758 RID: 59224 RVA: 0x003412E8 File Offset: 0x0033F4E8
		public Span<byte> GetEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x003412F8 File Offset: 0x0033F4F8
		public byte[] GetEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600E75A RID: 59226 RVA: 0x00341310 File Offset: 0x0033F510
		public float StartMoment
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600E75B RID: 59227 RVA: 0x00341354 File Offset: 0x0033F554
		public float EndMoment
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052DA RID: 21210
		private Table __p;
	}
}
