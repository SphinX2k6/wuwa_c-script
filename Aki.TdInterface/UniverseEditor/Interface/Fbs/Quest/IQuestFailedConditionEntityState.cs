using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004421 RID: 17441
	public struct IQuestFailedConditionEntityState : IFlatbufferObject
	{
		// Token: 0x170078C3 RID: 30915
		// (get) Token: 0x06018F1E RID: 102174 RVA: 0x0038ED06 File Offset: 0x0038CF06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F1F RID: 102175 RVA: 0x0038ED13 File Offset: 0x0038CF13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F20 RID: 102176 RVA: 0x0038ED1C File Offset: 0x0038CF1C
		public static IQuestFailedConditionEntityState GetRootAsIQuestFailedConditionEntityState(ByteBuffer _bb)
		{
			return IQuestFailedConditionEntityState.GetRootAsIQuestFailedConditionEntityState(_bb, default(IQuestFailedConditionEntityState));
		}

		// Token: 0x06018F21 RID: 102177 RVA: 0x0038ED38 File Offset: 0x0038CF38
		public static IQuestFailedConditionEntityState GetRootAsIQuestFailedConditionEntityState(ByteBuffer _bb, IQuestFailedConditionEntityState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F22 RID: 102178 RVA: 0x0038ED55 File Offset: 0x0038CF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F23 RID: 102179 RVA: 0x0038ED64 File Offset: 0x0038CF64
		public IQuestFailedConditionEntityState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06018F24 RID: 102180 RVA: 0x0038ED74 File Offset: 0x0038CF74
		public IEntityStateCondition? Conditions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170078C4 RID: 30916
		// (get) Token: 0x06018F25 RID: 102181 RVA: 0x0038EDD4 File Offset: 0x0038CFD4
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

		// Token: 0x06018F26 RID: 102182 RVA: 0x0038EDFF File Offset: 0x0038CFFF
		public static Offset<IQuestFailedConditionEntityState> CreateIQuestFailedConditionEntityState(FlatBufferBuilder builder, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IQuestFailedConditionEntityState.AddConditions(builder, ConditionsOffset);
			return IQuestFailedConditionEntityState.EndIQuestFailedConditionEntityState(builder);
		}

		// Token: 0x06018F27 RID: 102183 RVA: 0x0038EE15 File Offset: 0x0038D015
		public static void StartIQuestFailedConditionEntityState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018F28 RID: 102184 RVA: 0x0038EE1E File Offset: 0x0038D01E
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06018F29 RID: 102185 RVA: 0x0038EE30 File Offset: 0x0038D030
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018F2A RID: 102186 RVA: 0x0038EE70 File Offset: 0x0038D070
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<IEntityStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F2B RID: 102187 RVA: 0x0038EE8A File Offset: 0x0038D08A
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018F2C RID: 102188 RVA: 0x0038EEA8 File Offset: 0x0038D0A8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018F2D RID: 102189 RVA: 0x0038EEC1 File Offset: 0x0038D0C1
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018F2E RID: 102190 RVA: 0x0038EECC File Offset: 0x0038D0CC
		public static Offset<IQuestFailedConditionEntityState> EndIQuestFailedConditionEntityState(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConditionEntityState>(builder.EndTable());
		}

		// Token: 0x06018F2F RID: 102191 RVA: 0x0038EEDC File Offset: 0x0038D0DC
		public IQuestFailedConditionEntityStateT UnPack()
		{
			IQuestFailedConditionEntityStateT questFailedConditionEntityStateT = new IQuestFailedConditionEntityStateT();
			this.UnPackTo(questFailedConditionEntityStateT);
			return questFailedConditionEntityStateT;
		}

		// Token: 0x06018F30 RID: 102192 RVA: 0x0038EEF8 File Offset: 0x0038D0F8
		public void UnPackTo(IQuestFailedConditionEntityStateT _o)
		{
			_o.Conditions = new List<IEntityStateConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018F31 RID: 102193 RVA: 0x0038EF58 File Offset: 0x0038D158
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

		// Token: 0x0400C4C7 RID: 50375
		private Table __p;
	}
}
