using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9A RID: 15770
	public struct ICompareActorVar : IFlatbufferObject
	{
		// Token: 0x17006C74 RID: 27764
		// (get) Token: 0x06015E79 RID: 89721 RVA: 0x00329AEC File Offset: 0x00327CEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E7A RID: 89722 RVA: 0x00329AF9 File Offset: 0x00327CF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E7B RID: 89723 RVA: 0x00329B00 File Offset: 0x00327D00
		public static ICompareActorVar GetRootAsICompareActorVar(ByteBuffer _bb)
		{
			return ICompareActorVar.GetRootAsICompareActorVar(_bb, default(ICompareActorVar));
		}

		// Token: 0x06015E7C RID: 89724 RVA: 0x00329B1C File Offset: 0x00327D1C
		public static ICompareActorVar GetRootAsICompareActorVar(ByteBuffer _bb, ICompareActorVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E7D RID: 89725 RVA: 0x00329B39 File Offset: 0x00327D39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E7E RID: 89726 RVA: 0x00329B48 File Offset: 0x00327D48
		public ICompareActorVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C75 RID: 27765
		// (get) Token: 0x06015E7F RID: 89727 RVA: 0x00329B58 File Offset: 0x00327D58
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

		// Token: 0x17006C76 RID: 27766
		// (get) Token: 0x06015E80 RID: 89728 RVA: 0x00329B94 File Offset: 0x00327D94
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

		// Token: 0x17006C77 RID: 27767
		// (get) Token: 0x06015E81 RID: 89729 RVA: 0x00329BF4 File Offset: 0x00327DF4
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

		// Token: 0x06015E82 RID: 89730 RVA: 0x00329C30 File Offset: 0x00327E30
		public ICompareActorVarInChildQuest? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICompareActorVarInChildQuest?(default(ICompareActorVarInChildQuest).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006C78 RID: 27768
		// (get) Token: 0x06015E83 RID: 89731 RVA: 0x00329C94 File Offset: 0x00327E94
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

		// Token: 0x06015E84 RID: 89732 RVA: 0x00329CC0 File Offset: 0x00327EC0
		public static Offset<ICompareActorVar> CreateICompareActorVar(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ICompareActorVar.AddConditions(builder, ConditionsOffset);
			ICompareActorVar.AddPreConditions(builder, PreConditionsOffset);
			ICompareActorVar.AddCount(builder, Count);
			ICompareActorVar.AddType(builder, Type);
			return ICompareActorVar.EndICompareActorVar(builder);
		}

		// Token: 0x06015E85 RID: 89733 RVA: 0x00329CEC File Offset: 0x00327EEC
		public static void StartICompareActorVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015E86 RID: 89734 RVA: 0x00329CF5 File Offset: 0x00327EF5
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E87 RID: 89735 RVA: 0x00329D00 File Offset: 0x00327F00
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015E88 RID: 89736 RVA: 0x00329D10 File Offset: 0x00327F10
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x06015E89 RID: 89737 RVA: 0x00329D1B File Offset: 0x00327F1B
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x06015E8A RID: 89738 RVA: 0x00329D2C File Offset: 0x00327F2C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareActorVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06015E8B RID: 89739 RVA: 0x00329D6C File Offset: 0x00327F6C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareActorVarInChildQuest>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015E8C RID: 89740 RVA: 0x00329D86 File Offset: 0x00327F86
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareActorVarInChildQuest>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(data);
			return builder.EndVector();
		}

		// Token: 0x06015E8D RID: 89741 RVA: 0x00329DA4 File Offset: 0x00327FA4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareActorVarInChildQuest>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015E8E RID: 89742 RVA: 0x00329DBD File Offset: 0x00327FBD
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015E8F RID: 89743 RVA: 0x00329DC8 File Offset: 0x00327FC8
		public static Offset<ICompareActorVar> EndICompareActorVar(FlatBufferBuilder builder)
		{
			return new Offset<ICompareActorVar>(builder.EndTable());
		}

		// Token: 0x06015E90 RID: 89744 RVA: 0x00329DD8 File Offset: 0x00327FD8
		public ICompareActorVarT UnPack()
		{
			ICompareActorVarT compareActorVarT = new ICompareActorVarT();
			this.UnPackTo(compareActorVarT);
			return compareActorVarT;
		}

		// Token: 0x06015E91 RID: 89745 RVA: 0x00329DF4 File Offset: 0x00327FF4
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

		// Token: 0x06015E92 RID: 89746 RVA: 0x00329E9C File Offset: 0x0032809C
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

		// Token: 0x0400B6A5 RID: 46757
		private Table __p;
	}
}
