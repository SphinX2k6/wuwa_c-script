using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048EA RID: 18666
	public struct IDartSkillConditionGroup : IFlatbufferObject
	{
		// Token: 0x17008206 RID: 33286
		// (get) Token: 0x0601BA37 RID: 113207 RVA: 0x003E86AD File Offset: 0x003E68AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BA38 RID: 113208 RVA: 0x003E86BA File Offset: 0x003E68BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BA39 RID: 113209 RVA: 0x003E86C4 File Offset: 0x003E68C4
		public static IDartSkillConditionGroup GetRootAsIDartSkillConditionGroup(ByteBuffer _bb)
		{
			return IDartSkillConditionGroup.GetRootAsIDartSkillConditionGroup(_bb, default(IDartSkillConditionGroup));
		}

		// Token: 0x0601BA3A RID: 113210 RVA: 0x003E86E0 File Offset: 0x003E68E0
		public static IDartSkillConditionGroup GetRootAsIDartSkillConditionGroup(ByteBuffer _bb, IDartSkillConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BA3B RID: 113211 RVA: 0x003E86FD File Offset: 0x003E68FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BA3C RID: 113212 RVA: 0x003E870C File Offset: 0x003E690C
		public IDartSkillConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008207 RID: 33287
		// (get) Token: 0x0601BA3D RID: 113213 RVA: 0x003E871C File Offset: 0x003E691C
		public EConditionCount Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA3E RID: 113214 RVA: 0x003E8758 File Offset: 0x003E6958
		public TDartSkillCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TDartSkillCondition.NONE;
			}
			return (TDartSkillCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17008208 RID: 33288
		// (get) Token: 0x0601BA3F RID: 113215 RVA: 0x003E8798 File Offset: 0x003E6998
		public int ConditionsTypeLength
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

		// Token: 0x0601BA40 RID: 113216 RVA: 0x003E87C3 File Offset: 0x003E69C3
		public Span<TDartSkillCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TDartSkillCondition>(6, 1);
		}

		// Token: 0x0601BA41 RID: 113217 RVA: 0x003E87D4 File Offset: 0x003E69D4
		public TDartSkillCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TDartSkillCondition[] array = new TDartSkillCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TDartSkillCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601BA42 RID: 113218 RVA: 0x003E8840 File Offset: 0x003E6A40
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17008209 RID: 33289
		// (get) Token: 0x0601BA43 RID: 113219 RVA: 0x003E8888 File Offset: 0x003E6A88
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601BA44 RID: 113220 RVA: 0x003E88B3 File Offset: 0x003E6AB3
		public static Offset<IDartSkillConditionGroup> CreateIDartSkillConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IDartSkillConditionGroup.AddConditions(builder, ConditionsOffset);
			IDartSkillConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			IDartSkillConditionGroup.AddType(builder, Type);
			return IDartSkillConditionGroup.EndIDartSkillConditionGroup(builder);
		}

		// Token: 0x0601BA45 RID: 113221 RVA: 0x003E88D7 File Offset: 0x003E6AD7
		public static void StartIDartSkillConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BA46 RID: 113222 RVA: 0x003E88E0 File Offset: 0x003E6AE0
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BA47 RID: 113223 RVA: 0x003E88EB File Offset: 0x003E6AEB
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0601BA48 RID: 113224 RVA: 0x003E88FC File Offset: 0x003E6AFC
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TDartSkillCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BA49 RID: 113225 RVA: 0x003E8933 File Offset: 0x003E6B33
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TDartSkillCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TDartSkillCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA4A RID: 113226 RVA: 0x003E894D File Offset: 0x003E6B4D
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TDartSkillCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TDartSkillCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA4B RID: 113227 RVA: 0x003E896B File Offset: 0x003E6B6B
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TDartSkillCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BA4C RID: 113228 RVA: 0x003E8984 File Offset: 0x003E6B84
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601BA4D RID: 113229 RVA: 0x003E898F File Offset: 0x003E6B8F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0601BA4E RID: 113230 RVA: 0x003E89A0 File Offset: 0x003E6BA0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BA4F RID: 113231 RVA: 0x003E89D7 File Offset: 0x003E6BD7
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA50 RID: 113232 RVA: 0x003E89F1 File Offset: 0x003E6BF1
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BA51 RID: 113233 RVA: 0x003E8A0F File Offset: 0x003E6C0F
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BA52 RID: 113234 RVA: 0x003E8A28 File Offset: 0x003E6C28
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BA53 RID: 113235 RVA: 0x003E8A33 File Offset: 0x003E6C33
		public static Offset<IDartSkillConditionGroup> EndIDartSkillConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillConditionGroup>(builder.EndTable());
		}

		// Token: 0x0601BA54 RID: 113236 RVA: 0x003E8A40 File Offset: 0x003E6C40
		public IDartSkillConditionGroupT UnPack()
		{
			IDartSkillConditionGroupT dartSkillConditionGroupT = new IDartSkillConditionGroupT();
			this.UnPackTo(dartSkillConditionGroupT);
			return dartSkillConditionGroupT;
		}

		// Token: 0x0601BA55 RID: 113237 RVA: 0x003E8A5C File Offset: 0x003E6C5C
		public void UnPackTo(IDartSkillConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<TDartSkillConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TDartSkillConditionUnion tdartSkillConditionUnion = new TDartSkillConditionUnion();
				tdartSkillConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TDartSkillCondition.IBehindScoreGeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IBehindScoreGeCondition>(i) != null) ? this.Conditions<IBehindScoreGeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IBehindScoreLeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IBehindScoreLeCondition>(i) != null) ? this.Conditions<IBehindScoreLeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IFirstRoundsCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IFirstRoundsCondition>(i) != null) ? this.Conditions<IFirstRoundsCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreCanWinCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreCanWinCondition>(i) != null) ? this.Conditions<IRemainScoreCanWinCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreGeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreGeCondition>(i) != null) ? this.Conditions<IRemainScoreGeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRemainScoreLeCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRemainScoreLeCondition>(i) != null) ? this.Conditions<IRemainScoreLeCondition>(i).Value.UnPack() : null);
					break;
				case TDartSkillCondition.IRoundIndexCondition:
					tdartSkillConditionUnion.Value = ((this.Conditions<IRoundIndexCondition>(i) != null) ? this.Conditions<IRoundIndexCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(tdartSkillConditionUnion);
			}
		}

		// Token: 0x0601BA56 RID: 113238 RVA: 0x003E8C6C File Offset: 0x003E6E6C
		public static Offset<IDartSkillConditionGroup> Pack(FlatBufferBuilder builder, IDartSkillConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillConditionGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TDartSkillCondition[] array = new TDartSkillCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IDartSkillConditionGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TDartSkillConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IDartSkillConditionGroup.CreateConditionsVector(builder, array2);
			}
			return IDartSkillConditionGroup.CreateIDartSkillConditionGroup(builder, _o.Type, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400CEA6 RID: 52902
		private Table __p;
	}
}
