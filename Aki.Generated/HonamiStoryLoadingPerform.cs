using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E22 RID: 3618
	public struct HonamiStoryLoadingPerform : IFlatbufferObject
	{
		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06008657 RID: 34391 RVA: 0x00276985 File Offset: 0x00274B85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008658 RID: 34392 RVA: 0x00276992 File Offset: 0x00274B92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008659 RID: 34393 RVA: 0x0027699C File Offset: 0x00274B9C
		public static HonamiStoryLoadingPerform GetRootAsHonamiStoryLoadingPerform(ByteBuffer _bb)
		{
			return HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(_bb, default(HonamiStoryLoadingPerform));
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x002769B8 File Offset: 0x00274BB8
		public static HonamiStoryLoadingPerform GetRootAsHonamiStoryLoadingPerform(ByteBuffer _bb, HonamiStoryLoadingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x002769D5 File Offset: 0x00274BD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x002769E4 File Offset: 0x00274BE4
		public HonamiStoryLoadingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x002769F4 File Offset: 0x00274BF4
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

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x0600865E RID: 34398 RVA: 0x00276A30 File Offset: 0x00274C30
		public int Timing
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

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600865F RID: 34399 RVA: 0x00276A6C File Offset: 0x00274C6C
		public int MainBTId
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

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06008660 RID: 34400 RVA: 0x00276AA8 File Offset: 0x00274CA8
		public int PerformType
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

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06008661 RID: 34401 RVA: 0x00276AE8 File Offset: 0x00274CE8
		public string Title
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

		// Token: 0x06008662 RID: 34402 RVA: 0x00276B20 File Offset: 0x00274D20
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x00276B30 File Offset: 0x00274D30
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x00276B48 File Offset: 0x00274D48
		public string Tips
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

		// Token: 0x06008665 RID: 34405 RVA: 0x00276B80 File Offset: 0x00274D80
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008666 RID: 34406 RVA: 0x00276B90 File Offset: 0x00274D90
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x00276BA8 File Offset: 0x00274DA8
		public string StartAudioEvent
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

		// Token: 0x06008668 RID: 34408 RVA: 0x00276BE0 File Offset: 0x00274DE0
		public Span<byte> GetStartAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x00276BF0 File Offset: 0x00274DF0
		public byte[] GetStartAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00276C08 File Offset: 0x00274E08
		public string EndAudioEvent
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

		// Token: 0x0600866B RID: 34411 RVA: 0x00276C40 File Offset: 0x00274E40
		public Span<byte> GetEndAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00276C50 File Offset: 0x00274E50
		public byte[] GetEndAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400539D RID: 21405
		private Table __p;
	}
}
