using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C68 RID: 3176
	public struct FightInfoDtType : IFlatbufferObject
	{
		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x0022D3D5 File Offset: 0x0022B5D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x0022D3E2 File Offset: 0x0022B5E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x0022D3EC File Offset: 0x0022B5EC
		public static FightInfoDtType GetRootAsFightInfoDtType(ByteBuffer _bb)
		{
			return FightInfoDtType.GetRootAsFightInfoDtType(_bb, default(FightInfoDtType));
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x0022D408 File Offset: 0x0022B608
		public static FightInfoDtType GetRootAsFightInfoDtType(ByteBuffer _bb, FightInfoDtType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x0022D425 File Offset: 0x0022B625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x0022D434 File Offset: 0x0022B634
		public FightInfoDtType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x0022D444 File Offset: 0x0022B644
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

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06006DBA RID: 28090 RVA: 0x0022D480 File Offset: 0x0022B680
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

		// Token: 0x06006DBB RID: 28091 RVA: 0x0022D4B7 File Offset: 0x0022B6B7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x0022D4C6 File Offset: 0x0022B6C6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CB3 RID: 19635
		private Table __p;
	}
}
