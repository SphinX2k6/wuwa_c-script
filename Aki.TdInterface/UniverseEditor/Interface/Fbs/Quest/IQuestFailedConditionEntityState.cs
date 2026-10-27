using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE0 RID: 16352
	public struct IQuestFailedConditionEntityState : IFlatbufferObject
	{
		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x06017885 RID: 96389 RVA: 0x00364F12 File Offset: 0x00363112
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017886 RID: 96390 RVA: 0x00364F1F File Offset: 0x0036311F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017887 RID: 96391 RVA: 0x00364F28 File Offset: 0x00363128
		public static IQuestFailedConditionEntityState GetRootAsIQuestFailedConditionEntityState(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityState.GetRootAsIQuestFailedConditionEntityState(_bb, default(IQuestFailedConditionEntityState));
		}

		// Token: 0x06017888 RID: 96392 RVA: 0x00364F44 File Offset: 0x00363144
		public static IQuestFailedConditionEntityState GetRootAsIQuestFailedConditionEntityState(ByteBuffer _bb, IQuestFailedConditionEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017889 RID: 96393 RVA: 0x00364F61 File Offset: 0x00363161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601788A RID: 96394 RVA: 0x00364F70 File Offset: 0x00363170
		public IQuestFailedConditionEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601788B RID: 96395 RVA: 0x00364F80 File Offset: 0x00363180
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x0601788C RID: 96396 RVA: 0x00364FE0 File Offset: 0x003631E0
		public int ConditionsLength
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

		// Token: 0x0601788D RID: 96397 RVA: 0x0036500B File Offset: 0x0036320B
		public static Offset<IQuestFailedConditionEntityState> CreateIQuestFailedConditionEntityState(FlatBufferBuilder builder, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityState.AddConditions(builder, ConditionsOffset);
			return IQuestFailedConditionEntityState.EndIQuestFailedConditionEntityState(builder);
		}

		// Token: 0x0601788E RID: 96398 RVA: 0x00365021 File Offset: 0x00363221
		public static void StartIQuestFailedConditionEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601788F RID: 96399 RVA: 0x0036502A File Offset: 0x0036322A
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06017890 RID: 96400 RVA: 0x0036503C File Offset: 0x0036323C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017891 RID: 96401 RVA: 0x0036507C File Offset: 0x0036327C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017892 RID: 96402 RVA: 0x00365096 File Offset: 0x00363296
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017893 RID: 96403 RVA: 0x003650B4 File Offset: 0x003632B4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017894 RID: 96404 RVA: 0x003650CD File Offset: 0x003632CD
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017895 RID: 96405 RVA: 0x003650D8 File Offset: 0x003632D8
		public static Offset<IQuestFailedConditionEntityState> EndIQuestFailedConditionEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityState>(builder.EndTable());
		}

		// Token: 0x06017896 RID: 96406 RVA: 0x003650E8 File Offset: 0x003632E8
		public IQuestFailedConditionEntityStateT UnPack()
		{
			IQuestFailedConditionEntityStateT questFailedConditionEntityStateT = new IQuestFailedConditionEntityStateT();
			this.UnPackTo(questFailedConditionEntityStateT);
			return questFailedConditionEntityStateT;
		}

		// Token: 0x06017897 RID: 96407 RVA: 0x00365104 File Offset: 0x00363304
		public void UnPackTo(IQuestFailedConditionEntityStateT _o)
		{
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017898 RID: 96408 RVA: 0x00365164 File Offset: 0x00363364
		public static Offset<IQuestFailedConditionEntityState> Pack(FlatBufferBuilder builder, IQuestFailedConditionEntityStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConditionEntityState>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<IEntityStateCondition>[] array = new Offset<IEntityStateCondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityStateCondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IQuestFailedConditionEntityState.CreateConditionsVector(builder, array);
			}
			return IQuestFailedConditionEntityState.CreateIQuestFailedConditionEntityState(builder, conditionsOffset);
		}

		// Token: 0x0400BAE0 RID: 47840
		private Table __p;
	}
}
