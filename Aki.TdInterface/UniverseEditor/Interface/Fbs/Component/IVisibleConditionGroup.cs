using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200614E RID: 24910
	public struct IVisibleConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700B983 RID: 47491
		// (get) Token: 0x0602A44C RID: 173132 RVA: 0x005C45D8 File Offset: 0x005C27D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A44D RID: 173133 RVA: 0x005C45E5 File Offset: 0x005C27E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A44E RID: 173134 RVA: 0x005C45EC File Offset: 0x005C27EC
		public static IVisibleConditionGroup GetRootAsIVisibleConditionGroup(ByteBuffer _bb)
		{
			return IVisibleConditionGroup.GetRootAsIVisibleConditionGroup(_bb, default(IVisibleConditionGroup));
		}

		// Token: 0x0602A44F RID: 173135 RVA: 0x005C4608 File Offset: 0x005C2808
		public static IVisibleConditionGroup GetRootAsIVisibleConditionGroup(ByteBuffer _bb, IVisibleConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A450 RID: 173136 RVA: 0x005C4625 File Offset: 0x005C2825
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A451 RID: 173137 RVA: 0x005C4634 File Offset: 0x005C2834
		public IVisibleConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A452 RID: 173138 RVA: 0x005C4644 File Offset: 0x005C2844
		public TVisibleCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return TVisibleCondition.NONE;
			}
			return (TVisibleCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B984 RID: 47492
		// (get) Token: 0x0602A453 RID: 173139 RVA: 0x005C4684 File Offset: 0x005C2884
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

		// Token: 0x0602A454 RID: 173140 RVA: 0x005C46AF File Offset: 0x005C28AF
		public Span<TVisibleCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TVisibleCondition>(4, 1);
		}

		// Token: 0x0602A455 RID: 173141 RVA: 0x005C46C0 File Offset: 0x005C28C0
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

		// Token: 0x0602A456 RID: 173142 RVA: 0x005C472C File Offset: 0x005C292C
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B985 RID: 47493
		// (get) Token: 0x0602A457 RID: 173143 RVA: 0x005C4774 File Offset: 0x005C2974
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

		// Token: 0x0602A458 RID: 173144 RVA: 0x005C479F File Offset: 0x005C299F
		public static Offset<IVisibleConditionGroup> CreateIVisibleConditionGroup(FlatBufferBuilder builder, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IVisibleConditionGroup.AddConditions(builder, ConditionsOffset);
			IVisibleConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			return IVisibleConditionGroup.EndIVisibleConditionGroup(builder);
		}

		// Token: 0x0602A459 RID: 173145 RVA: 0x005C47BC File Offset: 0x005C29BC
		public static void StartIVisibleConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A45A RID: 173146 RVA: 0x005C47C5 File Offset: 0x005C29C5
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(0, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602A45B RID: 173147 RVA: 0x005C47D8 File Offset: 0x005C29D8
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TVisibleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A45C RID: 173148 RVA: 0x005C480F File Offset: 0x005C2A0F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TVisibleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TVisibleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A45D RID: 173149 RVA: 0x005C4829 File Offset: 0x005C2A29
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TVisibleCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TVisibleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A45E RID: 173150 RVA: 0x005C4847 File Offset: 0x005C2A47
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TVisibleCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A45F RID: 173151 RVA: 0x005C4860 File Offset: 0x005C2A60
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602A460 RID: 173152 RVA: 0x005C486B File Offset: 0x005C2A6B
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602A461 RID: 173153 RVA: 0x005C487C File Offset: 0x005C2A7C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A462 RID: 173154 RVA: 0x005C48B3 File Offset: 0x005C2AB3
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A463 RID: 173155 RVA: 0x005C48CD File Offset: 0x005C2ACD
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A464 RID: 173156 RVA: 0x005C48EB File Offset: 0x005C2AEB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A465 RID: 173157 RVA: 0x005C4904 File Offset: 0x005C2B04
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A466 RID: 173158 RVA: 0x005C490F File Offset: 0x005C2B0F
		public static Offset<IVisibleConditionGroup> EndIVisibleConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IVisibleConditionGroup>(builder.EndTable());
		}

		// Token: 0x0602A467 RID: 173159 RVA: 0x005C491C File Offset: 0x005C2B1C
		public IVisibleConditionGroupT UnPack()
		{
			IVisibleConditionGroupT visibleConditionGroupT = new IVisibleConditionGroupT();
			this.UnPackTo(visibleConditionGroupT);
			return visibleConditionGroupT;
		}

		// Token: 0x0602A468 RID: 173160 RVA: 0x005C4938 File Offset: 0x005C2B38
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
				case TVisibleCondition.ISeasonAndWeather:
					tvisibleConditionUnion.Value = ((this.Conditions<ISeasonAndWeather>(i) != null) ? this.Conditions<ISeasonAndWeather>(i).Value.UnPack() : null);
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

		// Token: 0x0602A469 RID: 173161 RVA: 0x005C4B78 File Offset: 0x005C2D78
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

		// Token: 0x0400FF69 RID: 65385
		private Table __p;
	}
}
