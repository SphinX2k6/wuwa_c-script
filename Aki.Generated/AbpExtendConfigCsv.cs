using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7D RID: 2941
	public struct AbpExtendConfigCsv : IFlatbufferObject
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600450A RID: 17674 RVA: 0x001E3949 File Offset: 0x001E1B49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x001E3956 File Offset: 0x001E1B56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x001E3960 File Offset: 0x001E1B60
		public static AbpExtendConfigCsv GetRootAsAbpExtendConfigCsv(ByteBuffer _bb)
		{
			return AbpExtendConfigCsv.GetRootAsAbpExtendConfigCsv(_bb, default(AbpExtendConfigCsv));
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x001E397C File Offset: 0x001E1B7C
		public static AbpExtendConfigCsv GetRootAsAbpExtendConfigCsv(ByteBuffer _bb, AbpExtendConfigCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x001E3999 File Offset: 0x001E1B99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x001E39A8 File Offset: 0x001E1BA8
		public AbpExtendConfigCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x001E39B8 File Offset: 0x001E1BB8
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

		// Token: 0x06004511 RID: 17681 RVA: 0x001E39EF File Offset: 0x001E1BEF
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x001E39FE File Offset: 0x001E1BFE
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x001E3A18 File Offset: 0x001E1C18
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
		// (get) Token: 0x06004514 RID: 17684 RVA: 0x001E3A54 File Offset: 0x001E1C54
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

		// Token: 0x0400504B RID: 20555
		private Table __p;
	}
}
