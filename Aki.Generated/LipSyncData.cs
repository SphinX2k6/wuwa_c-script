using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD2 RID: 3538
	public struct LipSyncData : IFlatbufferObject
	{
		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x002798FD File Offset: 0x00277AFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x0027990A File Offset: 0x00277B0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x00279914 File Offset: 0x00277B14
		public static LipSyncData GetRootAsLipSyncData(ByteBuffer _bb)
		{
			return LipSyncData.GetRootAsLipSyncData(_bb, default(LipSyncData));
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x00279930 File Offset: 0x00277B30
		public static LipSyncData GetRootAsLipSyncData(ByteBuffer _bb, LipSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x0027994D File Offset: 0x00277B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0027995C File Offset: 0x00277B5C
		public LipSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06008EEA RID: 36586 RVA: 0x0027996C File Offset: 0x00277B6C
		public int DataID
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x002799A8 File Offset: 0x00277BA8
		public string FunctionName
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

		// Token: 0x06008EEC RID: 36588 RVA: 0x002799DF File Offset: 0x00277BDF
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x002799EE File Offset: 0x00277BEE
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E6C RID: 20076
		private Table __p;
	}
}
