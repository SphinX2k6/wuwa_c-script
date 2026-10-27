using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAA RID: 2730
	public struct AbpState : IFlatbufferObject
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x001C4964 File Offset: 0x001C2B64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001C4971 File Offset: 0x001C2B71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x001C4978 File Offset: 0x001C2B78
		public static AbpState GetRootAsAbpState(ByteBuffer _bb)
		{
			return AbpState.GetRootAsAbpState(_bb, default(AbpState));
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001C4994 File Offset: 0x001C2B94
		public static AbpState GetRootAsAbpState(ByteBuffer _bb, AbpState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x001C49B1 File Offset: 0x001C2BB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x001C49C0 File Offset: 0x001C2BC0
		public AbpState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x001C49D0 File Offset: 0x001C2BD0
		public string Abp
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001C4A07 File Offset: 0x001C2C07
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x001C4A16 File Offset: 0x001C2C16
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x001C4A30 File Offset: 0x001C2C30
		public string State1
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

		// Token: 0x06004035 RID: 16437 RVA: 0x001C4A67 File Offset: 0x001C2C67
		public Span<byte> GetState1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001C4A76 File Offset: 0x001C2C76
		public byte[] GetState1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x001C4A90 File Offset: 0x001C2C90
		public string State2
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

		// Token: 0x06004038 RID: 16440 RVA: 0x001C4AC7 File Offset: 0x001C2CC7
		public Span<byte> GetState2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x001C4AD6 File Offset: 0x001C2CD6
		public byte[] GetState2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A7A RID: 19066
		private Table __p;
	}
}
