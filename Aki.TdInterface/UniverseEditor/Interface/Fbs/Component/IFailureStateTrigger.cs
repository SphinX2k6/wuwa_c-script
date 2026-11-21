using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005790 RID: 22416
	public struct IFailureStateTrigger : IFlatbufferObject
	{
		// Token: 0x1700A204 RID: 41476
		// (get) Token: 0x06024293 RID: 148115 RVA: 0x004F8B9F File Offset: 0x004F6D9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024294 RID: 148116 RVA: 0x004F8BAC File Offset: 0x004F6DAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024295 RID: 148117 RVA: 0x004F8BB4 File Offset: 0x004F6DB4
		public static IFailureStateTrigger GetRootAsIFailureStateTrigger(ByteBuffer _bb)
		{
			return IFailureStateTrigger.GetRootAsIFailureStateTrigger(_bb, default(IFailureStateTrigger));
		}

		// Token: 0x06024296 RID: 148118 RVA: 0x004F8BD0 File Offset: 0x004F6DD0
		public static IFailureStateTrigger GetRootAsIFailureStateTrigger(ByteBuffer _bb, IFailureStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024297 RID: 148119 RVA: 0x004F8BED File Offset: 0x004F6DED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024298 RID: 148120 RVA: 0x004F8BFC File Offset: 0x004F6DFC
		public IFailureStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06024299 RID: 148121 RVA: 0x004F8C0C File Offset: 0x004F6E0C
		public TEntityGroupFailureCondition FailureConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TEntityGroupFailureCondition.NONE;
			}
			return (TEntityGroupFailureCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700A205 RID: 41477
		// (get) Token: 0x0602429A RID: 148122 RVA: 0x004F8C4C File Offset: 0x004F6E4C
		public int FailureConditionsTypeLength
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

		// Token: 0x0602429B RID: 148123 RVA: 0x004F8C77 File Offset: 0x004F6E77
		public Span<TEntityGroupFailureCondition> GetFailureConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TEntityGroupFailureCondition>(4, 1);
		}

		// Token: 0x0602429C RID: 148124 RVA: 0x004F8C88 File Offset: 0x004F6E88
		public TEntityGroupFailureCondition[] GetFailureConditionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TEntityGroupFailureCondition[] array = new TEntityGroupFailureCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TEntityGroupFailureCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0602429D RID: 148125 RVA: 0x004F8CF4 File Offset: 0x004F6EF4
		public TTable? FailureConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700A206 RID: 41478
		// (get) Token: 0x0602429E RID: 148126 RVA: 0x004F8D3C File Offset: 0x004F6F3C
		public int FailureConditionsLength
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

		// Token: 0x1700A207 RID: 41479
		// (get) Token: 0x0602429F RID: 148127 RVA: 0x004F8D68 File Offset: 0x004F6F68
		public IOperationsAfterEntityGroupFailure? FailureOperations
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IOperationsAfterEntityGroupFailure?(default(IOperationsAfterEntityGroupFailure).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060242A0 RID: 148128 RVA: 0x004F8DC5 File Offset: 0x004F6FC5
		public static Offset<IFailureStateTrigger> CreateIFailureStateTrigger(FlatBufferBuilder builder, VectorOffset FailureConditions_typeOffset = default(VectorOffset), VectorOffset FailureConditionsOffset = default(VectorOffset), Offset<IOperationsAfterEntityGroupFailure> FailureOperationsOffset = default(Offset<IOperationsAfterEntityGroupFailure>))
		{
			builder.StartTable(3);
			IFailureStateTrigger.AddFailureOperations(builder, FailureOperationsOffset);
			IFailureStateTrigger.AddFailureConditions(builder, FailureConditionsOffset);
			IFailureStateTrigger.AddFailureConditionsType(builder, FailureConditions_typeOffset);
			return IFailureStateTrigger.EndIFailureStateTrigger(builder);
		}

		// Token: 0x060242A1 RID: 148129 RVA: 0x004F8DE9 File Offset: 0x004F6FE9
		public static void StartIFailureStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060242A2 RID: 148130 RVA: 0x004F8DF2 File Offset: 0x004F6FF2
		public static void AddFailureConditionsType(FlatBufferBuilder builder, VectorOffset failureConditionsTypeOffset)
		{
			builder.AddOffset(0, failureConditionsTypeOffset.Value, 0);
		}

		// Token: 0x060242A3 RID: 148131 RVA: 0x004F8E04 File Offset: 0x004F7004
		public static VectorOffset CreateFailureConditionsTypeVector(FlatBufferBuilder builder, TEntityGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060242A4 RID: 148132 RVA: 0x004F8E3B File Offset: 0x004F703B
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, TEntityGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TEntityGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060242A5 RID: 148133 RVA: 0x004F8E55 File Offset: 0x004F7055
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TEntityGroupFailureCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TEntityGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x060242A6 RID: 148134 RVA: 0x004F8E73 File Offset: 0x004F7073
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TEntityGroupFailureCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060242A7 RID: 148135 RVA: 0x004F8E8C File Offset: 0x004F708C
		public static void StartFailureConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060242A8 RID: 148136 RVA: 0x004F8E97 File Offset: 0x004F7097
		public static void AddFailureConditions(FlatBufferBuilder builder, VectorOffset failureConditionsOffset)
		{
			builder.AddOffset(1, failureConditionsOffset.Value, 0);
		}

		// Token: 0x060242A9 RID: 148137 RVA: 0x004F8EA8 File Offset: 0x004F70A8
		public static VectorOffset CreateFailureConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060242AA RID: 148138 RVA: 0x004F8EDF File Offset: 0x004F70DF
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060242AB RID: 148139 RVA: 0x004F8EF9 File Offset: 0x004F70F9
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060242AC RID: 148140 RVA: 0x004F8F17 File Offset: 0x004F7117
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060242AD RID: 148141 RVA: 0x004F8F30 File Offset: 0x004F7130
		public static void StartFailureConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060242AE RID: 148142 RVA: 0x004F8F3B File Offset: 0x004F713B
		public static void AddFailureOperations(FlatBufferBuilder builder, Offset<IOperationsAfterEntityGroupFailure> failureOperationsOffset)
		{
			builder.AddOffset(2, failureOperationsOffset.Value, 0);
		}

		// Token: 0x060242AF RID: 148143 RVA: 0x004F8F4B File Offset: 0x004F714B
		public static Offset<IFailureStateTrigger> EndIFailureStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IFailureStateTrigger>(builder.EndTable());
		}

		// Token: 0x060242B0 RID: 148144 RVA: 0x004F8F58 File Offset: 0x004F7158
		public IFailureStateTriggerT UnPack()
		{
			IFailureStateTriggerT failureStateTriggerT = new IFailureStateTriggerT();
			this.UnPackTo(failureStateTriggerT);
			return failureStateTriggerT;
		}

		// Token: 0x060242B1 RID: 148145 RVA: 0x004F8F74 File Offset: 0x004F7174
		public void UnPackTo(IFailureStateTriggerT _o)
		{
			_o.FailureConditions = new List<TEntityGroupFailureConditionUnion>();
			for (int i = 0; i < this.FailureConditionsLength; i++)
			{
				TEntityGroupFailureConditionUnion tentityGroupFailureConditionUnion = new TEntityGroupFailureConditionUnion();
				tentityGroupFailureConditionUnion.Type = this.FailureConditionsType(i);
				TEntityGroupFailureCondition tentityGroupFailureCondition = this.FailureConditionsType(i);
				if (tentityGroupFailureCondition != TEntityGroupFailureCondition.IEntityGroupFailureArbitraryState)
				{
					if (tentityGroupFailureCondition == TEntityGroupFailureCondition.IEntityGroupFailureSequentialState)
					{
						tentityGroupFailureConditionUnion.Value = ((this.FailureConditions<IEntityGroupFailureSequentialState>(i) != null) ? this.FailureConditions<IEntityGroupFailureSequentialState>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tentityGroupFailureConditionUnion.Value = ((this.FailureConditions<IEntityGroupFailureArbitraryState>(i) != null) ? this.FailureConditions<IEntityGroupFailureArbitraryState>(i).Value.UnPack() : null);
				}
				_o.FailureConditions.Add(tentityGroupFailureConditionUnion);
			}
			_o.FailureOperations = ((this.FailureOperations != null) ? this.FailureOperations.Value.UnPack() : null);
		}

		// Token: 0x060242B2 RID: 148146 RVA: 0x004F9070 File Offset: 0x004F7270
		public static Offset<IFailureStateTrigger> Pack(FlatBufferBuilder builder, IFailureStateTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailureStateTrigger>);
			}
			VectorOffset failureConditions_typeOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				TEntityGroupFailureCondition[] array = new TEntityGroupFailureCondition[_o.FailureConditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.FailureConditions[i].Type;
				}
				failureConditions_typeOffset = IFailureStateTrigger.CreateFailureConditionsTypeVector(builder, array);
			}
			VectorOffset failureConditionsOffset = default(VectorOffset);
			if (_o.FailureConditions != null)
			{
				int[] array2 = new int[_o.FailureConditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TEntityGroupFailureConditionUnion.Pack(builder, _o.FailureConditions[j]);
				}
				failureConditionsOffset = IFailureStateTrigger.CreateFailureConditionsVector(builder, array2);
			}
			Offset<IOperationsAfterEntityGroupFailure> failureOperationsOffset = (_o.FailureOperations == null) ? default(Offset<IOperationsAfterEntityGroupFailure>) : IOperationsAfterEntityGroupFailure.Pack(builder, _o.FailureOperations);
			return IFailureStateTrigger.CreateIFailureStateTrigger(builder, failureConditions_typeOffset, failureConditionsOffset, failureOperationsOffset);
		}

		// Token: 0x0400EF69 RID: 61289
		private Table __p;
	}
}
