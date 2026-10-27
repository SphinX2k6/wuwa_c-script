using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA8 RID: 2728
	public struct AbpExtendConfigCsv : IFlatbufferObject
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600400C RID: 16396 RVA: 0x001C45B5 File Offset: 0x001C27B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x001C45C2 File Offset: 0x001C27C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x001C45CC File Offset: 0x001C27CC
		public static AbpExtendConfigCsv GetRootAsAbpExtendConfigCsv(ByteBuffer _bb)
		{
			return AbpExtendConfigCsv.GetRootAsAbpExtendConfigCsv(_bb, default(AbpExtendConfigCsv));
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x001C45E8 File Offset: 0x001C27E8
		public static AbpExtendConfigCsv GetRootAsAbpExtendConfigCsv(ByteBuffer _bb, AbpExtendConfigCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x001C4605 File Offset: 0x001C2805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x001C4614 File Offset: 0x001C2814
		public AbpExtendConfigCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x001C4624 File Offset: 0x001C2824
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

		// Token: 0x06004013 RID: 16403 RVA: 0x001C465B File Offset: 0x001C285B
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x001C466A File Offset: 0x001C286A
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06004015 RID: 16405 RVA: 0x001C4684 File Offset: 0x001C2884
		public int WalkSpeed
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x001C46C0 File Offset: 0x001C28C0
		public int RunSpeed
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

		// Token: 0x04004A78 RID: 19064
		private Table __p;
	}
}
