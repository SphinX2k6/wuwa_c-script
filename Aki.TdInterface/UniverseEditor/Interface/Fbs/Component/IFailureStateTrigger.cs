using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005228 RID: 21032
	public struct IFailureStateTrigger : IFlatbufferObject
	{
		// Token: 0x17009A08 RID: 39432
		// (get) Token: 0x060222FD RID: 140029 RVA: 0x004BE0DB File Offset: 0x004BC2DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222FE RID: 140030 RVA: 0x004BE0E8 File Offset: 0x004BC2E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222FF RID: 140031 RVA: 0x004BE0F0 File Offset: 0x004BC2F0
		public static IFailureStateTrigger GetRootAsIFailureStateTrigger(ByteBuffer _bb)
		{
			return IFailureStateTrigger.GetRootAsIFailureStateTrigger(_bb, default(IFailureStateTrigger));
		}

		// Token: 0x06022300 RID: 140032 RVA: 0x004BE10C File Offset: 0x004BC30C
		public static IFailureStateTrigger GetRootAsIFailureStateTrigger(ByteBuffer _bb, IFailureStateTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022301 RID: 140033 RVA: 0x004BE129 File Offset: 0x004BC329
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022302 RID: 140034 RVA: 0x004BE138 File Offset: 0x004BC338
		public IFailureStateTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06022303 RID: 140035 RVA: 0x004BE148 File Offset: 0x004BC348
		public TEntityGroupFailureCondition FailureConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TEntityGroupFailureCondition.NONE;
			}
			return (TEntityGroupFailureCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009A09 RID: 39433
		// (get) Token: 0x06022304 RID: 140036 RVA: 0x004BE188 File Offset: 0x004BC388
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

		// Token: 0x06022305 RID: 140037 RVA: 0x004BE1B3 File Offset: 0x004BC3B3
		public Span<TEntityGroupFailureCondition> GetFailureConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TEntityGroupFailureCondition>(4, 1);
		}

		// Token: 0x06022306 RID: 140038 RVA: 0x004BE1C4 File Offset: 0x004BC3C4
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

		// Token: 0x06022307 RID: 140039 RVA: 0x004BE230 File Offset: 0x004BC430
		public TTable? FailureConditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17009A0A RID: 39434
		// (get) Token: 0x06022308 RID: 140040 RVA: 0x004BE278 File Offset: 0x004BC478
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

		// Token: 0x17009A0B RID: 39435
		// (get) Token: 0x06022309 RID: 140041 RVA: 0x004BE2A4 File Offset: 0x004BC4A4
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

		// Token: 0x0602230A RID: 140042 RVA: 0x004BE301 File Offset: 0x004BC501
		public static Offset<IFailureStateTrigger> CreateIFailureStateTrigger(FlatBufferBuilder builder, VectorOffset FailureConditions_typeOffset = default(VectorOffset), VectorOffset FailureConditionsOffset = default(VectorOffset), Offset<IOperationsAfterEntityGroupFailure> FailureOperationsOffset = default(Offset<IOperationsAfterEntityGroupFailure>))
		{
			builder.StartTable(3);
			IFailureStateTrigger.AddFailureOperations(builder, FailureOperationsOffset);
			IFailureStateTrigger.AddFailureConditions(builder, FailureConditionsOffset);
			IFailureStateTrigger.AddFailureConditionsType(builder, FailureConditions_typeOffset);
			return IFailureStateTrigger.EndIFailureStateTrigger(builder);
		}

		// Token: 0x0602230B RID: 140043 RVA: 0x004BE325 File Offset: 0x004BC525
		public static void StartIFailureStateTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602230C RID: 140044 RVA: 0x004BE32E File Offset: 0x004BC52E
		public static void AddFailureConditionsType(FlatBufferBuilder builder, VectorOffset failureConditionsTypeOffset)
		{
			builder.AddOffset(0, failureConditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602230D RID: 140045 RVA: 0x004BE340 File Offset: 0x004BC540
		public static VectorOffset CreateFailureConditionsTypeVector(FlatBufferBuilder builder, TEntityGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602230E RID: 140046 RVA: 0x004BE377 File Offset: 0x004BC577
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, TEntityGroupFailureCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TEntityGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602230F RID: 140047 RVA: 0x004BE391 File Offset: 0x004BC591
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TEntityGroupFailureCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TEntityGroupFailureCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06022310 RID: 140048 RVA: 0x004BE3AF File Offset: 0x004BC5AF
		public static VectorOffset CreateFailureConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TEntityGroupFailureCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022311 RID: 140049 RVA: 0x004BE3C8 File Offset: 0x004BC5C8
		public static void StartFailureConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06022312 RID: 140050 RVA: 0x004BE3D3 File Offset: 0x004BC5D3
		public static void AddFailureConditions(FlatBufferBuilder builder, VectorOffset failureConditionsOffset)
		{
			builder.AddOffset(1, failureConditionsOffset.Value, 0);
		}

		// Token: 0x06022313 RID: 140051 RVA: 0x004BE3E4 File Offset: 0x004BC5E4
		public static VectorOffset CreateFailureConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06022314 RID: 140052 RVA: 0x004BE41B File Offset: 0x004BC61B
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x004BE435 File Offset: 0x004BC635
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x004BE453 File Offset: 0x004BC653
		public static VectorOffset CreateFailureConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022317 RID: 140055 RVA: 0x004BE46C File Offset: 0x004BC66C
		public static void StartFailureConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022318 RID: 140056 RVA: 0x004BE477 File Offset: 0x004BC677
		public static void AddFailureOperations(FlatBufferBuilder builder, Offset<IOperationsAfterEntityGroupFailure> failureOperationsOffset)
		{
			builder.AddOffset(2, failureOperationsOffset.Value, 0);
		}

		// Token: 0x06022319 RID: 140057 RVA: 0x004BE487 File Offset: 0x004BC687
		public static Offset<IFailureStateTrigger> EndIFailureStateTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IFailureStateTrigger>(builder.EndTable());
		}

		// Token: 0x0602231A RID: 140058 RVA: 0x004BE494 File Offset: 0x004BC694
		public IFailureStateTriggerT UnPack()
		{
			IFailureStateTriggerT failureStateTriggerT = new IFailureStateTriggerT();
			this.UnPackTo(failureStateTriggerT);
			return failureStateTriggerT;
		}

		// Token: 0x0602231B RID: 140059 RVA: 0x004BE4B0 File Offset: 0x004BC6B0
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

		// Token: 0x0602231C RID: 140060 RVA: 0x004BE5AC File Offset: 0x004BC7AC
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

		// Token: 0x0400E363 RID: 58211
		private Table __p;
	}
}
