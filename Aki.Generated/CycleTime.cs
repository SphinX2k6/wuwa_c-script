using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B4 RID: 4532
	public struct CycleTime : IFlatbufferObject
	{
		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x003470E0 File Offset: 0x003452E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x003470ED File Offset: 0x003452ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x003470F4 File Offset: 0x003452F4
		public static CycleTime GetRootAsCycleTime(ByteBuffer _bb)
		{
			return CycleTime.GetRootAsCycleTime(_bb, default(CycleTime));
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x00347110 File Offset: 0x00345310
		public static CycleTime GetRootAsCycleTime(ByteBuffer _bb, CycleTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x0034712D File Offset: 0x0034532D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x0034713C File Offset: 0x0034533C
		public CycleTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x0034714C File Offset: 0x0034534C
		public int CycleType
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

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600E9E8 RID: 59880 RVA: 0x00347188 File Offset: 0x00345388
		public int CycleParam
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

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600E9E9 RID: 59881 RVA: 0x003471C4 File Offset: 0x003453C4
		public string TimeParam
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

		// Token: 0x0600E9EA RID: 59882 RVA: 0x003471FB File Offset: 0x003453FB
		public Span<byte> GetTimeParamBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E9EB RID: 59883 RVA: 0x0034720A File Offset: 0x0034540A
		public byte[] GetTimeParamArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005305 RID: 21253
		private Table __p;
	}
}
