using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001163 RID: 4451
	public struct RollBlock : IFlatbufferObject
	{
		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x00321441 File Offset: 0x0031F641
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D3AF RID: 54191 RVA: 0x0032144E File Offset: 0x0031F64E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D3B0 RID: 54192 RVA: 0x00321458 File Offset: 0x0031F658
		public static RollBlock GetRootAsRollBlock(ByteBuffer _bb)
		{
			return RollBlock.GetRootAsRollBlock(_bb, default(RollBlock));
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x00321474 File Offset: 0x0031F674
		public static RollBlock GetRootAsRollBlock(ByteBuffer _bb, RollBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x00321491 File Offset: 0x0031F691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D3B3 RID: 54195 RVA: 0x003214A0 File Offset: 0x0031F6A0
		public RollBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x003214B0 File Offset: 0x0031F6B0
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

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600D3B5 RID: 54197 RVA: 0x003214EC File Offset: 0x0031F6EC
		public string GroupName
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

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x00321523 File Offset: 0x0031F723
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x00321532 File Offset: 0x0031F732
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600D3B8 RID: 54200 RVA: 0x0032154C File Offset: 0x0031F74C
		public string Levels
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

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x00321583 File Offset: 0x0031F783
		public Span<byte> GetLevelsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x00321592 File Offset: 0x0031F792
		public byte[] GetLevelsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400576C RID: 22380
		private Table __p;
	}
}
