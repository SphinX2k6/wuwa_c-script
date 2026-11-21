using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B1 RID: 16817
	public struct ICompareActorVar : IFlatbufferObject
	{
		// Token: 0x1700722E RID: 29230
		// (get) Token: 0x060173B1 RID: 95153 RVA: 0x00350E18 File Offset: 0x0034F018
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060173B2 RID: 95154 RVA: 0x00350E25 File Offset: 0x0034F025
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060173B3 RID: 95155 RVA: 0x00350E2C File Offset: 0x0034F02C
		public static ICompareActorVar GetRootAsICompareActorVar(ByteBuffer _bb)
		{
			return ICompareActorVar.GetRootAsICompareActorVar(_bb, default(ICompareActorVar));
		}

		// Token: 0x060173B4 RID: 95156 RVA: 0x00350E48 File Offset: 0x0034F048
		public static ICompareActorVar GetRootAsICompareActorVar(ByteBuffer _bb, ICompareActorVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060173B5 RID: 95157 RVA: 0x00350E65 File Offset: 0x0034F065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060173B6 RID: 95158 RVA: 0x00350E74 File Offset: 0x0034F074
		public ICompareActorVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700722F RID: 29231
		// (get) Token: 0x060173B7 RID: 95159 RVA: 0x00350E84 File Offset: 0x0034F084
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

		// Token: 0x17007230 RID: 29232
		// (get) Token: 0x060173B8 RID: 95160 RVA: 0x00350EC0 File Offset: 0x0034F0C0
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

		// Token: 0x17007231 RID: 29233
		// (get) Token: 0x060173B9 RID: 95161 RVA: 0x00350F20 File Offset: 0x0034F120
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

		// Token: 0x060173BA RID: 95162 RVA: 0x00350F5C File Offset: 0x0034F15C
		public ICompareActorVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICompareActorVarInChildQuest?(default(ICompareActorVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007232 RID: 29234
		// (get) Token: 0x060173BB RID: 95163 RVA: 0x00350FC0 File Offset: 0x0034F1C0
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

		// Token: 0x060173BC RID: 95164 RVA: 0x00350FEC File Offset: 0x0034F1EC
		public static Offset<ICompareActorVar> CreateICompareActorVar(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICompareActorVar.AddConditions(builder, ConditionsOffset);
			ICompareActorVar.AddPreConditions(builder, PreConditionsOffset);
			ICompareActorVar.AddCount(builder, Count);
			ICompareActorVar.AddType(builder, Type);
			return ICompareActorVar.EndICompareActorVar(builder);
		}

		// Token: 0x060173BD RID: 95165 RVA: 0x00351018 File Offset: 0x0034F218
		public static void StartICompareActorVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060173BE RID: 95166 RVA: 0x00351021 File Offset: 0x0034F221
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060173BF RID: 95167 RVA: 0x0035102C File Offset: 0x0034F22C
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060173C0 RID: 95168 RVA: 0x0035103C File Offset: 0x0034F23C
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x060173C1 RID: 95169 RVA: 0x00351047 File Offset: 0x0034F247
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x060173C2 RID: 95170 RVA: 0x00351058 File Offset: 0x0034F258
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareActorVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x00351098 File Offset: 0x0034F298
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareActorVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x003510B2 File Offset: 0x0034F2B2
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareActorVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x003510D0 File Offset: 0x0034F2D0
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060173C6 RID: 95174 RVA: 0x003510E9 File Offset: 0x0034F2E9
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060173C7 RID: 95175 RVA: 0x003510F4 File Offset: 0x0034F2F4
		public static Offset<ICompareActorVar> EndICompareActorVar(FlatBufferBuilder builder)
		{
			return new Offset<ICompareActorVar>(builder.EndTable());
		}

		// Token: 0x060173C8 RID: 95176 RVA: 0x00351104 File Offset: 0x0034F304
		public ICompareActorVarT UnPack()
		{
			ICompareActorVarT compareActorVarT = new ICompareActorVarT();
			this.UnPackTo(compareActorVarT);
			return compareActorVarT;
		}

		// Token: 0x060173C9 RID: 95177 RVA: 0x00351120 File Offset: 0x0034F320
		public void UnPackTo(ICompareActorVarT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Conditions = new List<ICompareActorVarInChildQuestT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060173CA RID: 95178 RVA: 0x003511C8 File Offset: 0x0034F3C8
		public static Offset<ICompareActorVar> Pack(FlatBufferBuilder builder, ICompareActorVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareActorVar>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICompareActorVarInChildQuest>[] array = new Offset<ICompareActorVarInChildQuest>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICompareActorVarInChildQuest.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICompareActorVar.CreateConditionsVector(builder, array);
			}
			return ICompareActorVar.CreateICompareActorVar(builder, _o.Type, preConditionsOffset, _o.Count, conditionsOffset);
		}

		// Token: 0x0400C052 RID: 49234
		private Table __p;
	}
}
