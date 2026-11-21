using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004208 RID: 16904
	public struct IDetectCombatState2Condition : IFlatbufferObject
	{
		// Token: 0x17007317 RID: 29463
		// (get) Token: 0x0601776A RID: 96106 RVA: 0x00359D14 File Offset: 0x00357F14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x00359D21 File Offset: 0x00357F21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601776C RID: 96108 RVA: 0x00359D28 File Offset: 0x00357F28
		public static IDetectCombatState2Condition GetRootAsIDetectCombatState2Condition(ByteBuffer _bb)
		{
			return IDetectCombatState2Condition.GetRootAsIDetectCombatState2Condition(_bb, default(IDetectCombatState2Condition));
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x00359D44 File Offset: 0x00357F44
		public static IDetectCombatState2Condition GetRootAsIDetectCombatState2Condition(ByteBuffer _bb, IDetectCombatState2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x00359D61 File Offset: 0x00357F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x00359D70 File Offset: 0x00357F70
		public IDetectCombatState2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007318 RID: 29464
		// (get) Token: 0x06017770 RID: 96112 RVA: 0x00359D80 File Offset: 0x00357F80
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007319 RID: 29465
		// (get) Token: 0x06017771 RID: 96113 RVA: 0x00359DBC File Offset: 0x00357FBC
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700731A RID: 29466
		// (get) Token: 0x06017772 RID: 96114 RVA: 0x00359E1C File Offset: 0x0035801C
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017773 RID: 96115 RVA: 0x00359E58 File Offset: 0x00358058
		public ICombatState2Condition? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICombatState2Condition?(default(ICombatState2Condition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700731B RID: 29467
		// (get) Token: 0x06017774 RID: 96116 RVA: 0x00359EBC File Offset: 0x003580BC
		public int ConditionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x00359EE8 File Offset: 0x003580E8
		public static Offset<IDetectCombatState2Condition> CreateIDetectCombatState2Condition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IDetectCombatState2Condition.AddConditions(builder, ConditionsOffset);
			IDetectCombatState2Condition.AddPreConditions(builder, PreConditionsOffset);
			IDetectCombatState2Condition.AddCount(builder, Count);
			IDetectCombatState2Condition.AddType(builder, Type);
			return IDetectCombatState2Condition.EndIDetectCombatState2Condition(builder);
		}

		// Token: 0x06017776 RID: 96118 RVA: 0x00359F14 File Offset: 0x00358114
		public static void StartIDetectCombatState2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017777 RID: 96119 RVA: 0x00359F1D File Offset: 0x0035811D
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017778 RID: 96120 RVA: 0x00359F28 File Offset: 0x00358128
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017779 RID: 96121 RVA: 0x00359F38 File Offset: 0x00358138
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x0601777A RID: 96122 RVA: 0x00359F43 File Offset: 0x00358143
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x00359F54 File Offset: 0x00358154
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICombatState2Condition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601777C RID: 96124 RVA: 0x00359F94 File Offset: 0x00358194
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICombatState2Condition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICombatState2Condition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601777D RID: 96125 RVA: 0x00359FAE File Offset: 0x003581AE
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICombatState2Condition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICombatState2Condition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601777E RID: 96126 RVA: 0x00359FCC File Offset: 0x003581CC
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICombatState2Condition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601777F RID: 96127 RVA: 0x00359FE5 File Offset: 0x003581E5
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017780 RID: 96128 RVA: 0x00359FF0 File Offset: 0x003581F0
		public static Offset<IDetectCombatState2Condition> EndIDetectCombatState2Condition(FlatBufferBuilder builder)
		{
			return new Offset<IDetectCombatState2Condition>(builder.EndTable());
		}

		// Token: 0x06017781 RID: 96129 RVA: 0x0035A000 File Offset: 0x00358200
		public IDetectCombatState2ConditionT UnPack()
		{
			IDetectCombatState2ConditionT detectCombatState2ConditionT = new IDetectCombatState2ConditionT();
			this.UnPackTo(detectCombatState2ConditionT);
			return detectCombatState2ConditionT;
		}

		// Token: 0x06017782 RID: 96130 RVA: 0x0035A01C File Offset: 0x0035821C
		public void UnPackTo(IDetectCombatState2ConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Conditions = new List<ICombatState2ConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017783 RID: 96131 RVA: 0x0035A0C4 File Offset: 0x003582C4
		public static Offset<IDetectCombatState2Condition> Pack(FlatBufferBuilder builder, IDetectCombatState2ConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDetectCombatState2Condition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICombatState2Condition>[] array = new Offset<ICombatState2Condition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICombatState2Condition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IDetectCombatState2Condition.CreateConditionsVector(builder, array);
			}
			return IDetectCombatState2Condition.CreateIDetectCombatState2Condition(builder, _o.Type, preConditionsOffset, _o.Count, conditionsOffset);
		}

		// Token: 0x0400C0E3 RID: 49379
		private Table __p;
	}
}
