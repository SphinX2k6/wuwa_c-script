using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113B RID: 4411
	public struct RoleLevelConsume : IFlatbufferObject
	{
		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600CFDC RID: 53212 RVA: 0x00318979 File Offset: 0x00316B79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x00318986 File Offset: 0x00316B86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFDE RID: 53214 RVA: 0x00318990 File Offset: 0x00316B90
		public static RoleLevelConsume GetRootAsRoleLevelConsume(ByteBuffer _bb)
		{
			return RoleLevelConsume.GetRootAsRoleLevelConsume(_bb, default(RoleLevelConsume));
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x003189AC File Offset: 0x00316BAC
		public static RoleLevelConsume GetRootAsRoleLevelConsume(ByteBuffer _bb, RoleLevelConsume obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x003189C9 File Offset: 0x00316BC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFE1 RID: 53217 RVA: 0x003189D8 File Offset: 0x00316BD8
		public RoleLevelConsume __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x003189E8 File Offset: 0x00316BE8
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

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600CFE3 RID: 53219 RVA: 0x00318A24 File Offset: 0x00316C24
		public int ConsumeGroupId
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

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00318A60 File Offset: 0x00316C60
		public int Level
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

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600CFE5 RID: 53221 RVA: 0x00318A9C File Offset: 0x00316C9C
		public int ExpCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400573C RID: 22332
		private Table __p;
	}
}
