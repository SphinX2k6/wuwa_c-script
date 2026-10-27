using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F2 RID: 4338
	public struct State : IFlatbufferObject
	{
		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600D963 RID: 55651 RVA: 0x0032151C File Offset: 0x0031F71C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x00321529 File Offset: 0x0031F729
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x00321530 File Offset: 0x0031F730
		public static State GetRootAsState(ByteBuffer _bb)
		{
			return State.GetRootAsState(_bb, default(State));
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x0032154C File Offset: 0x0031F74C
		public static State GetRootAsState(ByteBuffer _bb, State obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x00321569 File Offset: 0x0031F769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D968 RID: 55656 RVA: 0x00321578 File Offset: 0x0031F778
		public State __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600D969 RID: 55657 RVA: 0x00321588 File Offset: 0x0031F788
		public int StateId
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

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600D96A RID: 55658 RVA: 0x003215C4 File Offset: 0x0031F7C4
		public string StateName
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

		// Token: 0x0600D96B RID: 55659 RVA: 0x003215FB File Offset: 0x0031F7FB
		public Span<byte> GetStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x0032160A File Offset: 0x0031F80A
		public byte[] GetStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600D96D RID: 55661 RVA: 0x00321624 File Offset: 0x0031F824
		public string CountryId
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

		// Token: 0x0600D96E RID: 55662 RVA: 0x0032165B File Offset: 0x0031F85B
		public Span<byte> GetCountryIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x0032166A File Offset: 0x0031F86A
		public byte[] GetCountryIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600D970 RID: 55664 RVA: 0x00321684 File Offset: 0x0031F884
		public int SortIndex
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

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600D971 RID: 55665 RVA: 0x003216C4 File Offset: 0x0031F8C4
		public string WwiseStateName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x003216FC File Offset: 0x0031F8FC
		public Span<byte> GetWwiseStateNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x0032170C File Offset: 0x0031F90C
		public byte[] GetWwiseStateNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005226 RID: 21030
		private Table __p;
	}
}
