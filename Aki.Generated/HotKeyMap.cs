using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D55 RID: 3413
	public struct HotKeyMap : IFlatbufferObject
	{
		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x0025C249 File Offset: 0x0025A449
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x0025C256 File Offset: 0x0025A456
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x0025C260 File Offset: 0x0025A460
		public static HotKeyMap GetRootAsHotKeyMap(ByteBuffer _bb)
		{
			return HotKeyMap.GetRootAsHotKeyMap(_bb, default(HotKeyMap));
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x0025C27C File Offset: 0x0025A47C
		public static HotKeyMap GetRootAsHotKeyMap(ByteBuffer _bb, HotKeyMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0025C299 File Offset: 0x0025A499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x0025C2A8 File Offset: 0x0025A4A8
		public HotKeyMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600821C RID: 33308 RVA: 0x0025C2B8 File Offset: 0x0025A4B8
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

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600821D RID: 33309 RVA: 0x0025C2F4 File Offset: 0x0025A4F4
		public string ActionName
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

		// Token: 0x0600821E RID: 33310 RVA: 0x0025C32B File Offset: 0x0025A52B
		public Span<byte> GetActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x0025C33A File Offset: 0x0025A53A
		public byte[] GetActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06008220 RID: 33312 RVA: 0x0025C354 File Offset: 0x0025A554
		public string AxisName
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

		// Token: 0x06008221 RID: 33313 RVA: 0x0025C38B File Offset: 0x0025A58B
		public Span<byte> GetAxisNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x0025C39A File Offset: 0x0025A59A
		public byte[] GetAxisNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06008223 RID: 33315 RVA: 0x0025C3B4 File Offset: 0x0025A5B4
		public int AxisDirection
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

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06008224 RID: 33316 RVA: 0x0025C3F4 File Offset: 0x0025A5F4
		public string TextId
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

		// Token: 0x06008225 RID: 33317 RVA: 0x0025C42C File Offset: 0x0025A62C
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x0025C43C File Offset: 0x0025A63C
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06008227 RID: 33319 RVA: 0x0025C454 File Offset: 0x0025A654
		public string Type
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

		// Token: 0x06008228 RID: 33320 RVA: 0x0025C48C File Offset: 0x0025A68C
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x0025C49C File Offset: 0x0025A69C
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x0025C4B4 File Offset: 0x0025A6B4
		public int LongPressTime
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

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x0600822B RID: 33323 RVA: 0x0025C4F4 File Offset: 0x0025A6F4
		public int ReleaseFailureTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600822C RID: 33324 RVA: 0x0025C534 File Offset: 0x0025A734
		public string BindButtonTag
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

		// Token: 0x0600822D RID: 33325 RVA: 0x0025C56C File Offset: 0x0025A76C
		public Span<byte> GetBindButtonTagBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x0025C57C File Offset: 0x0025A77C
		public byte[] GetBindButtonTagArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600822F RID: 33327 RVA: 0x0025C594 File Offset: 0x0025A794
		public int ApplicableType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x0025C5D4 File Offset: 0x0025A7D4
		public bool IsOccupancyFightInput
		{
			get
			{
				int num = this.__p.__offset(24);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06008231 RID: 33329 RVA: 0x0025C614 File Offset: 0x0025A814
		public bool HideInShowMouse
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004DD4 RID: 19924
		private Table __p;
	}
}
