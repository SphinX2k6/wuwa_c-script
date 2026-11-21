using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C75 RID: 3189
	public struct CompositeRewardDisplay : IFlatbufferObject
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06005DB5 RID: 23989 RVA: 0x0021B791 File Offset: 0x00219991
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x0021B79E File Offset: 0x0021999E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x0021B7A8 File Offset: 0x002199A8
		public static CompositeRewardDisplay GetRootAsCompositeRewardDisplay(ByteBuffer _bb)
		{
			return CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(_bb, default(CompositeRewardDisplay));
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x0021B7C4 File Offset: 0x002199C4
		public static CompositeRewardDisplay GetRootAsCompositeRewardDisplay(ByteBuffer _bb, CompositeRewardDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x0021B7E1 File Offset: 0x002199E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x0021B7F0 File Offset: 0x002199F0
		public CompositeRewardDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x0021B800 File Offset: 0x00219A00
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06005DBC RID: 23996 RVA: 0x0021B83C File Offset: 0x00219A3C
		public bool IsDragonPool
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06005DBD RID: 23997 RVA: 0x0021B87C File Offset: 0x00219A7C
		public string Title
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

		// Token: 0x06005DBE RID: 23998 RVA: 0x0021B8B3 File Offset: 0x00219AB3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x0021B8C2 File Offset: 0x00219AC2
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x0021B8DC File Offset: 0x00219ADC
		public string ContinueText
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

		// Token: 0x06005DC1 RID: 24001 RVA: 0x0021B914 File Offset: 0x00219B14
		public Span<byte> GetContinueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x0021B924 File Offset: 0x00219B24
		public byte[] GetContinueTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06005DC3 RID: 24003 RVA: 0x0021B93C File Offset: 0x00219B3C
		public string TitleIconPath
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

		// Token: 0x06005DC4 RID: 24004 RVA: 0x0021B974 File Offset: 0x00219B74
		public Span<byte> GetTitleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x0021B984 File Offset: 0x00219B84
		public byte[] GetTitleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x0021B99C File Offset: 0x00219B9C
		public bool IsProgressVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06005DC7 RID: 24007 RVA: 0x0021B9DC File Offset: 0x00219BDC
		public string ProgressBarTitle
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

		// Token: 0x06005DC8 RID: 24008 RVA: 0x0021BA14 File Offset: 0x00219C14
		public Span<byte> GetProgressBarTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x0021BA24 File Offset: 0x00219C24
		public byte[] GetProgressBarTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x0021BA3C File Offset: 0x00219C3C
		public int ProgressBarAnimationTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06005DCB RID: 24011 RVA: 0x0021BA80 File Offset: 0x00219C80
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x0021BAC0 File Offset: 0x00219CC0
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06005DCD RID: 24013 RVA: 0x0021BB00 File Offset: 0x00219D00
		public string AudioId
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

		// Token: 0x06005DCE RID: 24014 RVA: 0x0021BB38 File Offset: 0x00219D38
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x0021BB48 File Offset: 0x00219D48
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005184 RID: 20868
		private Table __p;
	}
}
