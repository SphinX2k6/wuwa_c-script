using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F2B RID: 20267
	public struct IBuffAreaStateConfig : IFlatbufferObject
	{
		// Token: 0x1700920D RID: 37389
		// (get) Token: 0x0602011C RID: 131356 RVA: 0x00476548 File Offset: 0x00474748
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602011D RID: 131357 RVA: 0x00476555 File Offset: 0x00474755
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602011E RID: 131358 RVA: 0x0047655C File Offset: 0x0047475C
		public static IBuffAreaStateConfig GetRootAsIBuffAreaStateConfig(ByteBuffer _bb)
		{
			return IBuffAreaStateConfig.GetRootAsIBuffAreaStateConfig(_bb, default(IBuffAreaStateConfig));
		}

		// Token: 0x0602011F RID: 131359 RVA: 0x00476578 File Offset: 0x00474778
		public static IBuffAreaStateConfig GetRootAsIBuffAreaStateConfig(ByteBuffer _bb, IBuffAreaStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020120 RID: 131360 RVA: 0x00476595 File Offset: 0x00474795
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020121 RID: 131361 RVA: 0x004765A4 File Offset: 0x004747A4
		public IBuffAreaStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700920E RID: 37390
		// (get) Token: 0x06020122 RID: 131362 RVA: 0x004765B4 File Offset: 0x004747B4
		public string State
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

		// Token: 0x06020123 RID: 131363 RVA: 0x004765EB File Offset: 0x004747EB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06020124 RID: 131364 RVA: 0x004765FA File Offset: 0x004747FA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06020125 RID: 131365 RVA: 0x00476608 File Offset: 0x00474808
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700920F RID: 37391
		// (get) Token: 0x06020126 RID: 131366 RVA: 0x00476648 File Offset: 0x00474848
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

		// Token: 0x06020127 RID: 131367 RVA: 0x00476673 File Offset: 0x00474873
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06020128 RID: 131368 RVA: 0x00476682 File Offset: 0x00474882
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x17009210 RID: 37392
		// (get) Token: 0x06020129 RID: 131369 RVA: 0x00476690 File Offset: 0x00474890
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602012A RID: 131370 RVA: 0x004766ED File Offset: 0x004748ED
		public static Offset<IBuffAreaStateConfig> CreateIBuffAreaStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), VectorOffset BuffIdsOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IBuffAreaStateConfig.AddCondition(builder, ConditionOffset);
			IBuffAreaStateConfig.AddBuffIds(builder, BuffIdsOffset);
			IBuffAreaStateConfig.AddState(builder, StateOffset);
			return IBuffAreaStateConfig.EndIBuffAreaStateConfig(builder);
		}

		// Token: 0x0602012B RID: 131371 RVA: 0x00476711 File Offset: 0x00474911
		public static void StartIBuffAreaStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602012C RID: 131372 RVA: 0x0047671A File Offset: 0x0047491A
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602012D RID: 131373 RVA: 0x0047672A File Offset: 0x0047492A
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(1, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602012E RID: 131374 RVA: 0x0047673C File Offset: 0x0047493C
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602012F RID: 131375 RVA: 0x00476773 File Offset: 0x00474973
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06020130 RID: 131376 RVA: 0x0047678D File Offset: 0x0047498D
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06020131 RID: 131377 RVA: 0x004767AB File Offset: 0x004749AB
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020132 RID: 131378 RVA: 0x004767C4 File Offset: 0x004749C4
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06020133 RID: 131379 RVA: 0x004767CF File Offset: 0x004749CF
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06020134 RID: 131380 RVA: 0x004767DF File Offset: 0x004749DF
		public static Offset<IBuffAreaStateConfig> EndIBuffAreaStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffAreaStateConfig>(builder.EndTable());
		}

		// Token: 0x06020135 RID: 131381 RVA: 0x004767EC File Offset: 0x004749EC
		public IBuffAreaStateConfigT UnPack()
		{
			IBuffAreaStateConfigT buffAreaStateConfigT = new IBuffAreaStateConfigT();
			this.UnPackTo(buffAreaStateConfigT);
			return buffAreaStateConfigT;
		}

		// Token: 0x06020136 RID: 131382 RVA: 0x00476808 File Offset: 0x00474A08
		public void UnPackTo(IBuffAreaStateConfigT _o)
		{
			_o.State = this.State;
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06020137 RID: 131383 RVA: 0x00476880 File Offset: 0x00474A80
		public static Offset<IBuffAreaStateConfig> Pack(FlatBufferBuilder builder, IBuffAreaStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuffAreaStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IBuffAreaStateConfig.CreateBuffIdsVector(builder, data);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IBuffAreaStateConfig.CreateIBuffAreaStateConfig(builder, stateOffset, buffIdsOffset, conditionOffset);
		}

		// Token: 0x0400DD8D RID: 56717
		private Table __p;
	}
}
