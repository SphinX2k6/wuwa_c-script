using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE9 RID: 3561
	public struct MapAudio : IFlatbufferObject
	{
		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600909F RID: 37023 RVA: 0x0027D5EC File Offset: 0x0027B7EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x0027D5F9 File Offset: 0x0027B7F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x0027D600 File Offset: 0x0027B800
		public static MapAudio GetRootAsMapAudio(ByteBuffer _bb)
		{
			return MapAudio.GetRootAsMapAudio(_bb, default(MapAudio));
		}

		// Token: 0x060090A2 RID: 37026 RVA: 0x0027D61C File Offset: 0x0027B81C
		public static MapAudio GetRootAsMapAudio(ByteBuffer _bb, MapAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x0027D639 File Offset: 0x0027B839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x0027D648 File Offset: 0x0027B848
		public MapAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060090A5 RID: 37029 RVA: 0x0027D658 File Offset: 0x0027B858
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

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x0027D694 File Offset: 0x0027B894
		public string Name
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

		// Token: 0x060090A7 RID: 37031 RVA: 0x0027D6CB File Offset: 0x0027B8CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0027D6DA File Offset: 0x0027B8DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x0027D6F4 File Offset: 0x0027B8F4
		public string Event
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

		// Token: 0x060090AA RID: 37034 RVA: 0x0027D72B File Offset: 0x0027B92B
		public Span<byte> GetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x0027D73A File Offset: 0x0027B93A
		public byte[] GetEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060090AC RID: 37036 RVA: 0x0027D754 File Offset: 0x0027B954
		public string EnterEvent
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

		// Token: 0x060090AD RID: 37037 RVA: 0x0027D78C File Offset: 0x0027B98C
		public Span<byte> GetEnterEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x0027D79C File Offset: 0x0027B99C
		public byte[] GetEnterEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0027D7B4 File Offset: 0x0027B9B4
		public string ExitEvent
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

		// Token: 0x060090B0 RID: 37040 RVA: 0x0027D7EC File Offset: 0x0027B9EC
		public Span<byte> GetExitEventBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x0027D7FC File Offset: 0x0027B9FC
		public byte[] GetExitEventArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x0027D814 File Offset: 0x0027BA14
		public string ResetEvent
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

		// Token: 0x060090B3 RID: 37043 RVA: 0x0027D84C File Offset: 0x0027BA4C
		public Span<byte> GetResetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x0027D85C File Offset: 0x0027BA5C
		public byte[] GetResetEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x060090B5 RID: 37045 RVA: 0x0027D874 File Offset: 0x0027BA74
		public string MusicResetEvent
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

		// Token: 0x060090B6 RID: 37046 RVA: 0x0027D8AC File Offset: 0x0027BAAC
		public Span<byte> GetMusicResetEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x0027D8BC File Offset: 0x0027BABC
		public byte[] GetMusicResetEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E85 RID: 20101
		private Table __p;
	}
}
