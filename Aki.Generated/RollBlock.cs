using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001068 RID: 4200
	public struct RollBlock : IFlatbufferObject
	{
		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600CBDB RID: 52187 RVA: 0x00301B89 File Offset: 0x002FFD89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x00301B96 File Offset: 0x002FFD96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x00301BA0 File Offset: 0x002FFDA0
		public static RollBlock GetRootAsRollBlock(ByteBuffer _bb)
		{
			return RollBlock.GetRootAsRollBlock(_bb, default(RollBlock));
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x00301BBC File Offset: 0x002FFDBC
		public static RollBlock GetRootAsRollBlock(ByteBuffer _bb, RollBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x00301BD9 File Offset: 0x002FFDD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x00301BE8 File Offset: 0x002FFDE8
		public RollBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600CBE1 RID: 52193 RVA: 0x00301BF8 File Offset: 0x002FFDF8
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

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600CBE2 RID: 52194 RVA: 0x00301C34 File Offset: 0x002FFE34
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

		// Token: 0x0600CBE3 RID: 52195 RVA: 0x00301C6B File Offset: 0x002FFE6B
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x00301C7A File Offset: 0x002FFE7A
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x00301C94 File Offset: 0x002FFE94
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

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x00301CCB File Offset: 0x002FFECB
		public Span<byte> GetLevelsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x00301CDA File Offset: 0x002FFEDA
		public byte[] GetLevelsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400516D RID: 20845
		private Table __p;
	}
}
