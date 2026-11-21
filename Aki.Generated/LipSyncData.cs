using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB7 RID: 3767
	public struct LipSyncData : IFlatbufferObject
	{
		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06009500 RID: 38144 RVA: 0x00297CD6 File Offset: 0x00295ED6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x00297CE3 File Offset: 0x00295EE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x00297CEC File Offset: 0x00295EEC
		public static LipSyncData GetRootAsLipSyncData(ByteBuffer _bb)
		{
			return LipSyncData.GetRootAsLipSyncData(_bb, default(LipSyncData));
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00297D08 File Offset: 0x00295F08
		public static LipSyncData GetRootAsLipSyncData(ByteBuffer _bb, LipSyncData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00297D25 File Offset: 0x00295F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x00297D34 File Offset: 0x00295F34
		public LipSyncData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06009506 RID: 38150 RVA: 0x00297D44 File Offset: 0x00295F44
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

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x00297D80 File Offset: 0x00295F80
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

		// Token: 0x06009508 RID: 38152 RVA: 0x00297DB7 File Offset: 0x00295FB7
		public Span<byte> GetFunctionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x00297DC6 File Offset: 0x00295FC6
		public byte[] GetFunctionNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005451 RID: 21585
		private Table __p;
	}
}
