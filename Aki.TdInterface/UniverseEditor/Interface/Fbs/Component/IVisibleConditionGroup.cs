using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B38 RID: 23352
	public struct IVisibleConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700B03B RID: 45115
		// (get) Token: 0x06027E88 RID: 163464 RVA: 0x0057CB84 File Offset: 0x0057AD84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027E89 RID: 163465 RVA: 0x0057CB91 File Offset: 0x0057AD91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027E8A RID: 163466 RVA: 0x0057CB98 File Offset: 0x0057AD98
		public static IVisibleConditionGroup GetRootAsIVisibleConditionGroup(ByteBuffer _bb)
		{
			return IVisibleConditionGroup.GetRootAsIVisibleConditionGroup(_bb, default(IVisibleConditionGroup));
		}

		// Token: 0x06027E8B RID: 163467 RVA: 0x0057CBB4 File Offset: 0x0057ADB4
		public static IVisibleConditionGroup GetRootAsIVisibleConditionGroup(ByteBuffer _bb, IVisibleConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027E8C RID: 163468 RVA: 0x0057CBD1 File Offset: 0x0057ADD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027E8D RID: 163469 RVA: 0x0057CBE0 File Offset: 0x0057ADE0
		public IVisibleConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06027E8E RID: 163470 RVA: 0x0057CBF0 File Offset: 0x0057ADF0
		public TVisibleCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TVisibleCondition.NONE;
			}
			return (TVisibleCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B03C RID: 45116
		// (get) Token: 0x06027E8F RID: 163471 RVA: 0x0057CC30 File Offset: 0x0057AE30
		public int ConditionsTypeLength
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

		// Token: 0x06027E90 RID: 163472 RVA: 0x0057CC5B File Offset: 0x0057AE5B
		public Span<TVisibleCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TVisibleCondition>(4, 1);
		}

		// Token: 0x06027E91 RID: 163473 RVA: 0x0057CC6C File Offset: 0x0057AE6C
		public TVisibleCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TVisibleCondition[] array = new TVisibleCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TVisibleCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06027E92 RID: 163474 RVA: 0x0057CCD8 File Offset: 0x0057AED8
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B03D RID: 45117
		// (get) Token: 0x06027E93 RID: 163475 RVA: 0x0057CD20 File Offset: 0x0057AF20
		public int ConditionsLength
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

		// Token: 0x06027E94 RID: 163476 RVA: 0x0057CD4B File Offset: 0x0057AF4B
		public static Offset<IVisibleConditionGroup> CreateIVisibleConditionGroup(FlatBufferBuilder builder, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IVisibleConditionGroup.AddConditions(builder, ConditionsOffset);
			IVisibleConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			return IVisibleConditionGroup.EndIVisibleConditionGroup(builder);
		}

		// Token: 0x06027E95 RID: 163477 RVA: 0x0057CD68 File Offset: 0x0057AF68
		public static void StartIVisibleConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027E96 RID: 163478 RVA: 0x0057CD71 File Offset: 0x0057AF71
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(0, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x06027E97 RID: 163479 RVA: 0x0057CD84 File Offset: 0x0057AF84
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TVisibleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027E98 RID: 163480 RVA: 0x0057CDBB File Offset: 0x0057AFBB
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TVisibleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisibleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E99 RID: 163481 RVA: 0x0057CDD5 File Offset: 0x0057AFD5
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisibleCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisibleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E9A RID: 163482 RVA: 0x0057CDF3 File Offset: 0x0057AFF3
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisibleCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027E9B RID: 163483 RVA: 0x0057CE0C File Offset: 0x0057B00C
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027E9C RID: 163484 RVA: 0x0057CE17 File Offset: 0x0057B017
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06027E9D RID: 163485 RVA: 0x0057CE28 File Offset: 0x0057B028
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027E9E RID: 163486 RVA: 0x0057CE5F File Offset: 0x0057B05F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027E9F RID: 163487 RVA: 0x0057CE79 File Offset: 0x0057B079
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027EA0 RID: 163488 RVA: 0x0057CE97 File Offset: 0x0057B097
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027EA1 RID: 163489 RVA: 0x0057CEB0 File Offset: 0x0057B0B0
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027EA2 RID: 163490 RVA: 0x0057CEBB File Offset: 0x0057B0BB
		public static Offset<IVisibleConditionGroup> EndIVisibleConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IVisibleConditionGroup>(builder.EndTable());
		}

		// Token: 0x06027EA3 RID: 163491 RVA: 0x0057CEC8 File Offset: 0x0057B0C8
		public IVisibleConditionGroupT UnPack()
		{
			IVisibleConditionGroupT visibleConditionGroupT = new IVisibleConditionGroupT();
			this.UnPackTo(visibleConditionGroupT);
			return visibleConditionGroupT;
		}

		// Token: 0x06027EA4 RID: 163492 RVA: 0x0057CEE4 File Offset: 0x0057B0E4
		public void UnPackTo(IVisibleConditionGroupT _o)
		{
			_o.Conditions = new List<TVisibleConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TVisibleConditionUnion tvisibleConditionUnion = new TVisibleConditionUnion();
				tvisibleConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TVisibleCondition.IClock:
					tvisibleConditionUnion.Value = ((this.Conditions<IClock>(i) != null) ? this.Conditions<IClock>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.ICompareVar:
					tvisibleConditionUnion.Value = ((this.Conditions<ICompareVar>(i) != null) ? this.Conditions<ICompareVar>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.IPreChildQuest:
					tvisibleConditionUnion.Value = ((this.Conditions<IPreChildQuest>(i) != null) ? this.Conditions<IPreChildQuest>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.IPreQuest:
					tvisibleConditionUnion.Value = ((this.Conditions<IPreQuest>(i) != null) ? this.Conditions<IPreQuest>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.ITargetEntityInvisible:
					tvisibleConditionUnion.Value = ((this.Conditions<ITargetEntityInvisible>(i) != null) ? this.Conditions<ITargetEntityInvisible>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.ITimePeriod:
					tvisibleConditionUnion.Value = ((this.Conditions<ITimePeriod>(i) != null) ? this.Conditions<ITimePeriod>(i).Value.UnPack() : null);
					break;
				case TVisibleCondition.IWeather:
					tvisibleConditionUnion.Value = ((this.Conditions<IWeather>(i) != null) ? this.Conditions<IWeather>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(tvisibleConditionUnion);
			}
		}

		// Token: 0x06027EA5 RID: 163493 RVA: 0x0057D0E8 File Offset: 0x0057B2E8
		public static Offset<IVisibleConditionGroup> Pack(FlatBufferBuilder builder, IVisibleConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisibleConditionGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TVisibleCondition[] array = new TVisibleCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IVisibleConditionGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TVisibleConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IVisibleConditionGroup.CreateConditionsVector(builder, array2);
			}
			return IVisibleConditionGroup.CreateIVisibleConditionGroup(builder, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400F263 RID: 62051
		private Table __p;
	}
}
