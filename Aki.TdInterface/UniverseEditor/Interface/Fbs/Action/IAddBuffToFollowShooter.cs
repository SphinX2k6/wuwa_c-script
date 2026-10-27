using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200611F RID: 24863
	public struct IAddBuffToFollowShooter : IFlatbufferObject
	{
		// Token: 0x1700B73B RID: 46907
		// (get) Token: 0x0602A7CF RID: 174031 RVA: 0x005DA086 File Offset: 0x005D8286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A7D0 RID: 174032 RVA: 0x005DA093 File Offset: 0x005D8293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A7D1 RID: 174033 RVA: 0x005DA09C File Offset: 0x005D829C
		public static IAddBuffToFollowShooter GetRootAsIAddBuffToFollowShooter(ByteBuffer _bb)
		{
			return IAddBuffToFollowShooter.GetRootAsIAddBuffToFollowShooter(_bb, default(IAddBuffToFollowShooter));
		}

		// Token: 0x0602A7D2 RID: 174034 RVA: 0x005DA0B8 File Offset: 0x005D82B8
		public static IAddBuffToFollowShooter GetRootAsIAddBuffToFollowShooter(ByteBuffer _bb, IAddBuffToFollowShooter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A7D3 RID: 174035 RVA: 0x005DA0D5 File Offset: 0x005D82D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A7D4 RID: 174036 RVA: 0x005DA0E4 File Offset: 0x005D82E4
		public IAddBuffToFollowShooter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A7D5 RID: 174037 RVA: 0x005DA0F4 File Offset: 0x005D82F4
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B73C RID: 46908
		// (get) Token: 0x0602A7D6 RID: 174038 RVA: 0x005DA134 File Offset: 0x005D8334
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A7D7 RID: 174039 RVA: 0x005DA15F File Offset: 0x005D835F
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602A7D8 RID: 174040 RVA: 0x005DA16E File Offset: 0x005D836E
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x1700B73D RID: 46909
		// (get) Token: 0x0602A7D9 RID: 174041 RVA: 0x005DA17C File Offset: 0x005D837C
		public int FollowShooterId
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

		// Token: 0x1700B73E RID: 46910
		// (get) Token: 0x0602A7DA RID: 174042 RVA: 0x005DA1B8 File Offset: 0x005D83B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A7DB RID: 174043 RVA: 0x005DA1F4 File Offset: 0x005D83F4
		public static Offset<IAddBuffToFollowShooter> CreateIAddBuffToFollowShooter(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset), int FollowShooterId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddBuffToFollowShooter.AddFollowShooterId(builder, FollowShooterId);
			IAddBuffToFollowShooter.AddBuffIds(builder, BuffIdsOffset);
			IAddBuffToFollowShooter.AddNullMask(builder, NullMask);
			return IAddBuffToFollowShooter.EndIAddBuffToFollowShooter(builder);
		}

		// Token: 0x0602A7DC RID: 174044 RVA: 0x005DA218 File Offset: 0x005D8418
		public static void StartIAddBuffToFollowShooter(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A7DD RID: 174045 RVA: 0x005DA221 File Offset: 0x005D8421
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602A7DE RID: 174046 RVA: 0x005DA234 File Offset: 0x005D8434
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A7DF RID: 174047 RVA: 0x005DA26B File Offset: 0x005D846B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7E0 RID: 174048 RVA: 0x005DA285 File Offset: 0x005D8485
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7E1 RID: 174049 RVA: 0x005DA2A3 File Offset: 0x005D84A3
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A7E2 RID: 174050 RVA: 0x005DA2BC File Offset: 0x005D84BC
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A7E3 RID: 174051 RVA: 0x005DA2C7 File Offset: 0x005D84C7
		public static void AddFollowShooterId(FlatBufferBuilder builder, int followShooterId)
		{
			builder.AddInt(1, followShooterId, 0);
		}

		// Token: 0x0602A7E4 RID: 174052 RVA: 0x005DA2D2 File Offset: 0x005D84D2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602A7E5 RID: 174053 RVA: 0x005DA2DD File Offset: 0x005D84DD
		public static Offset<IAddBuffToFollowShooter> EndIAddBuffToFollowShooter(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToFollowShooter>(builder.EndTable());
		}

		// Token: 0x0602A7E6 RID: 174054 RVA: 0x005DA2EC File Offset: 0x005D84EC
		public IAddBuffToFollowShooterT UnPack()
		{
			IAddBuffToFollowShooterT addBuffToFollowShooterT = new IAddBuffToFollowShooterT();
			this.UnPackTo(addBuffToFollowShooterT);
			return addBuffToFollowShooterT;
		}

		// Token: 0x0602A7E7 RID: 174055 RVA: 0x005DA308 File Offset: 0x005D8508
		public void UnPackTo(IAddBuffToFollowShooterT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
			_o.FollowShooterId = this.FollowShooterId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A7E8 RID: 174056 RVA: 0x005DA35C File Offset: 0x005D855C
		public static Offset<IAddBuffToFollowShooter> Pack(FlatBufferBuilder builder, IAddBuffToFollowShooterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToFollowShooter>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToFollowShooter.CreateBuffIdsVector(builder, data);
			}
			return IAddBuffToFollowShooter.CreateIAddBuffToFollowShooter(builder, buffIdsOffset, _o.FollowShooterId, _o.NullMask);
		}

		// Token: 0x040104F0 RID: 66800
		private Table __p;
	}
}
