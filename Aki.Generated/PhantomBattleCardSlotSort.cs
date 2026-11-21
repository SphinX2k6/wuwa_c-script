using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAD RID: 4013
	public struct PhantomBattleCardSlotSort : IFlatbufferObject
	{
		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x002CADDE File Offset: 0x002C8FDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x002CADEB File Offset: 0x002C8FEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x002CADF4 File Offset: 0x002C8FF4
		public static PhantomBattleCardSlotSort GetRootAsPhantomBattleCardSlotSort(ByteBuffer _bb)
		{
			return PhantomBattleCardSlotSort.GetRootAsPhantomBattleCardSlotSort(_bb, default(PhantomBattleCardSlotSort));
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x002CAE10 File Offset: 0x002C9010
		public static PhantomBattleCardSlotSort GetRootAsPhantomBattleCardSlotSort(ByteBuffer _bb, PhantomBattleCardSlotSort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x002CAE2D File Offset: 0x002C902D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x002CAE3C File Offset: 0x002C903C
		public PhantomBattleCardSlotSort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x002CAE4C File Offset: 0x002C904C
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

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x0600AC55 RID: 44117 RVA: 0x002CAE88 File Offset: 0x002C9088
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

		// Token: 0x0600AC56 RID: 44118 RVA: 0x002CAEBF File Offset: 0x002C90BF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x002CAECE File Offset: 0x002C90CE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005569 RID: 21865
		private Table __p;
	}
}
