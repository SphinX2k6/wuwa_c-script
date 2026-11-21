using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545D RID: 21597
	public struct IBuffAreaStateConfig : IFlatbufferObject
	{
		// Token: 0x1700998F RID: 39311
		// (get) Token: 0x06021E8C RID: 138892 RVA: 0x004AC8DC File Offset: 0x004AAADC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E8D RID: 138893 RVA: 0x004AC8E9 File Offset: 0x004AAAE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E8E RID: 138894 RVA: 0x004AC8F0 File Offset: 0x004AAAF0
		public static IBuffAreaStateConfig GetRootAsIBuffAreaStateConfig(ByteBuffer _bb)
		{
			return IBuffAreaStateConfig.GetRootAsIBuffAreaStateConfig(_bb, default(IBuffAreaStateConfig));
		}

		// Token: 0x06021E8F RID: 138895 RVA: 0x004AC90C File Offset: 0x004AAB0C
		public static IBuffAreaStateConfig GetRootAsIBuffAreaStateConfig(ByteBuffer _bb, IBuffAreaStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E90 RID: 138896 RVA: 0x004AC929 File Offset: 0x004AAB29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E91 RID: 138897 RVA: 0x004AC938 File Offset: 0x004AAB38
		public IBuffAreaStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009990 RID: 39312
		// (get) Token: 0x06021E92 RID: 138898 RVA: 0x004AC948 File Offset: 0x004AAB48
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

		// Token: 0x06021E93 RID: 138899 RVA: 0x004AC97F File Offset: 0x004AAB7F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021E94 RID: 138900 RVA: 0x004AC98E File Offset: 0x004AAB8E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06021E95 RID: 138901 RVA: 0x004AC99C File Offset: 0x004AAB9C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17009991 RID: 39313
		// (get) Token: 0x06021E96 RID: 138902 RVA: 0x004AC9DC File Offset: 0x004AABDC
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

		// Token: 0x06021E97 RID: 138903 RVA: 0x004ACA07 File Offset: 0x004AAC07
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06021E98 RID: 138904 RVA: 0x004ACA16 File Offset: 0x004AAC16
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6);
		}

		// Token: 0x17009992 RID: 39314
		// (get) Token: 0x06021E99 RID: 138905 RVA: 0x004ACA24 File Offset: 0x004AAC24
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

		// Token: 0x06021E9A RID: 138906 RVA: 0x004ACA81 File Offset: 0x004AAC81
		public static Offset<IBuffAreaStateConfig> CreateIBuffAreaStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), VectorOffset BuffIdsOffset = default(VectorOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			IBuffAreaStateConfig.AddCondition(builder, ConditionOffset);
			IBuffAreaStateConfig.AddBuffIds(builder, BuffIdsOffset);
			IBuffAreaStateConfig.AddState(builder, StateOffset);
			return IBuffAreaStateConfig.EndIBuffAreaStateConfig(builder);
		}

		// Token: 0x06021E9B RID: 138907 RVA: 0x004ACAA5 File Offset: 0x004AACA5
		public static void StartIBuffAreaStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021E9C RID: 138908 RVA: 0x004ACAAE File Offset: 0x004AACAE
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06021E9D RID: 138909 RVA: 0x004ACABE File Offset: 0x004AACBE
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(1, buffIdsOffset.Value, 0);
		}

		// Token: 0x06021E9E RID: 138910 RVA: 0x004ACAD0 File Offset: 0x004AACD0
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021E9F RID: 138911 RVA: 0x004ACB07 File Offset: 0x004AAD07
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EA0 RID: 138912 RVA: 0x004ACB21 File Offset: 0x004AAD21
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EA1 RID: 138913 RVA: 0x004ACB3F File Offset: 0x004AAD3F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021EA2 RID: 138914 RVA: 0x004ACB58 File Offset: 0x004AAD58
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06021EA3 RID: 138915 RVA: 0x004ACB63 File Offset: 0x004AAD63
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06021EA4 RID: 138916 RVA: 0x004ACB73 File Offset: 0x004AAD73
		public static Offset<IBuffAreaStateConfig> EndIBuffAreaStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBuffAreaStateConfig>(builder.EndTable());
		}

		// Token: 0x06021EA5 RID: 138917 RVA: 0x004ACB80 File Offset: 0x004AAD80
		public IBuffAreaStateConfigT UnPack()
		{
			IBuffAreaStateConfigT buffAreaStateConfigT = new IBuffAreaStateConfigT();
			this.UnPackTo(buffAreaStateConfigT);
			return buffAreaStateConfigT;
		}

		// Token: 0x06021EA6 RID: 138918 RVA: 0x004ACB9C File Offset: 0x004AAD9C
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

		// Token: 0x06021EA7 RID: 138919 RVA: 0x004ACC14 File Offset: 0x004AAE14
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

		// Token: 0x0400E93C RID: 59708
		private Table __p;
	}
}
