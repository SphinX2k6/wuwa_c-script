using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E75 RID: 3701
	public struct KSCBuff : IFlatbufferObject
	{
		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06008E4E RID: 36430 RVA: 0x002896DB File Offset: 0x002878DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x002896E8 File Offset: 0x002878E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x002896F0 File Offset: 0x002878F0
		public static KSCBuff GetRootAsKSCBuff(ByteBuffer _bb)
		{
			return KSCBuff.GetRootAsKSCBuff(_bb, default(KSCBuff));
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x0028970C File Offset: 0x0028790C
		public static KSCBuff GetRootAsKSCBuff(ByteBuffer _bb, KSCBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00289729 File Offset: 0x00287929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00289738 File Offset: 0x00287938
		public KSCBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x00289748 File Offset: 0x00287948
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

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06008E55 RID: 36437 RVA: 0x00289784 File Offset: 0x00287984
		public string AssetPath
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

		// Token: 0x06008E56 RID: 36438 RVA: 0x002897BB File Offset: 0x002879BB
		public Span<byte> GetAssetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x002897CA File Offset: 0x002879CA
		public byte[] GetAssetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005402 RID: 21506
		private Table __p;
	}
}
