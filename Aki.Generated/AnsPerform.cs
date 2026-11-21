using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BDA RID: 3034
	public struct AnsPerform : IFlatbufferObject
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x001F61C9 File Offset: 0x001F43C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x001F61D6 File Offset: 0x001F43D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x001F61E0 File Offset: 0x001F43E0
		public static AnsPerform GetRootAsAnsPerform(ByteBuffer _bb)
		{
			return AnsPerform.GetRootAsAnsPerform(_bb, default(AnsPerform));
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x001F61FC File Offset: 0x001F43FC
		public static AnsPerform GetRootAsAnsPerform(ByteBuffer _bb, AnsPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x001F6219 File Offset: 0x001F4419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x001F6228 File Offset: 0x001F4428
		public AnsPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x001F6238 File Offset: 0x001F4438
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06004D71 RID: 19825 RVA: 0x001F6274 File Offset: 0x001F4474
		public string Condition
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

		// Token: 0x06004D72 RID: 19826 RVA: 0x001F62AB File Offset: 0x001F44AB
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x001F62BA File Offset: 0x001F44BA
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x001F62D4 File Offset: 0x001F44D4
		public string Action
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

		// Token: 0x06004D75 RID: 19829 RVA: 0x001F630B File Offset: 0x001F450B
		public Span<byte> GetActionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x001F631A File Offset: 0x001F451A
		public byte[] GetActionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050BB RID: 20667
		private Table __p;
	}
}
