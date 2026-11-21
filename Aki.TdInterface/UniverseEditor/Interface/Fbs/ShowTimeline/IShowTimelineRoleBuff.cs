using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD0 RID: 16336
	public struct IShowTimelineRoleBuff : IFlatbufferObject
	{
		// Token: 0x17006EA3 RID: 28323
		// (get) Token: 0x06016535 RID: 91445 RVA: 0x00332C89 File Offset: 0x00330E89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016536 RID: 91446 RVA: 0x00332C96 File Offset: 0x00330E96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016537 RID: 91447 RVA: 0x00332CA0 File Offset: 0x00330EA0
		public static IShowTimelineRoleBuff GetRootAsIShowTimelineRoleBuff(ByteBuffer _bb)
		{
			return IShowTimelineRoleBuff.GetRootAsIShowTimelineRoleBuff(_bb, default(IShowTimelineRoleBuff));
		}

		// Token: 0x06016538 RID: 91448 RVA: 0x00332CBC File Offset: 0x00330EBC
		public static IShowTimelineRoleBuff GetRootAsIShowTimelineRoleBuff(ByteBuffer _bb, IShowTimelineRoleBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016539 RID: 91449 RVA: 0x00332CD9 File Offset: 0x00330ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601653A RID: 91450 RVA: 0x00332CE8 File Offset: 0x00330EE8
		public IShowTimelineRoleBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EA4 RID: 28324
		// (get) Token: 0x0601653B RID: 91451 RVA: 0x00332CF8 File Offset: 0x00330EF8
		public int RoleId
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

		// Token: 0x0601653C RID: 91452 RVA: 0x00332D34 File Offset: 0x00330F34
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17006EA5 RID: 28325
		// (get) Token: 0x0601653D RID: 91453 RVA: 0x00332D74 File Offset: 0x00330F74
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601653E RID: 91454 RVA: 0x00332D9F File Offset: 0x00330F9F
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x0601653F RID: 91455 RVA: 0x00332DAE File Offset: 0x00330FAE
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x06016540 RID: 91456 RVA: 0x00332DBC File Offset: 0x00330FBC
		public static Offset<IShowTimelineRoleBuff> CreateIShowTimelineRoleBuff(FlatBufferBuilder builder, int RoleId = 0, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IShowTimelineRoleBuff.AddBuffIds(builder, BuffIdsOffset);
			IShowTimelineRoleBuff.AddRoleId(builder, RoleId);
			return IShowTimelineRoleBuff.EndIShowTimelineRoleBuff(builder);
		}

		// Token: 0x06016541 RID: 91457 RVA: 0x00332DD9 File Offset: 0x00330FD9
		public static void StartIShowTimelineRoleBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016542 RID: 91458 RVA: 0x00332DE2 File Offset: 0x00330FE2
		public static void AddRoleId(FlatBufferBuilder builder, int roleId)
		{
			builder.AddInt(0, roleId, 0);
		}

		// Token: 0x06016543 RID: 91459 RVA: 0x00332DED File Offset: 0x00330FED
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(1, buffIdsOffset.Value, 0);
		}

		// Token: 0x06016544 RID: 91460 RVA: 0x00332E00 File Offset: 0x00331000
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016545 RID: 91461 RVA: 0x00332E37 File Offset: 0x00331037
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06016546 RID: 91462 RVA: 0x00332E51 File Offset: 0x00331051
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06016547 RID: 91463 RVA: 0x00332E6F File Offset: 0x0033106F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016548 RID: 91464 RVA: 0x00332E88 File Offset: 0x00331088
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06016549 RID: 91465 RVA: 0x00332E93 File Offset: 0x00331093
		public static Offset<IShowTimelineRoleBuff> EndIShowTimelineRoleBuff(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineRoleBuff>(builder.EndTable());
		}

		// Token: 0x0601654A RID: 91466 RVA: 0x00332EA0 File Offset: 0x003310A0
		public IShowTimelineRoleBuffT UnPack()
		{
			IShowTimelineRoleBuffT showTimelineRoleBuffT = new IShowTimelineRoleBuffT();
			this.UnPackTo(showTimelineRoleBuffT);
			return showTimelineRoleBuffT;
		}

		// Token: 0x0601654B RID: 91467 RVA: 0x00332EBC File Offset: 0x003310BC
		public void UnPackTo(IShowTimelineRoleBuffT _o)
		{
			_o.RoleId = this.RoleId;
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x0601654C RID: 91468 RVA: 0x00332F04 File Offset: 0x00331104
		public static Offset<IShowTimelineRoleBuff> Pack(FlatBufferBuilder builder, IShowTimelineRoleBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineRoleBuff>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IShowTimelineRoleBuff.CreateBuffIdsVector(builder, data);
			}
			return IShowTimelineRoleBuff.CreateIShowTimelineRoleBuff(builder, _o.RoleId, buffIdsOffset);
		}

		// Token: 0x0400BAD3 RID: 47827
		private Table __p;
	}
}
