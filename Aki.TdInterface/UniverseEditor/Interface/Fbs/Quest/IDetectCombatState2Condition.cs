using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DCD RID: 15821
	public struct IDetectCombatState2Condition : IFlatbufferObject
	{
		// Token: 0x17006D37 RID: 27959
		// (get) Token: 0x0601614B RID: 90443 RVA: 0x00331310 File Offset: 0x0032F510
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601614C RID: 90444 RVA: 0x0033131D File Offset: 0x0032F51D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601614D RID: 90445 RVA: 0x00331324 File Offset: 0x0032F524
		public static IDetectCombatState2Condition GetRootAsIDetectCombatState2Condition(ByteBuffer _bb)
		{
			return IDetectCombatState2Condition.GetRootAsIDetectCombatState2Condition(_bb, default(IDetectCombatState2Condition));
		}

		// Token: 0x0601614E RID: 90446 RVA: 0x00331340 File Offset: 0x0032F540
		public static IDetectCombatState2Condition GetRootAsIDetectCombatState2Condition(ByteBuffer _bb, IDetectCombatState2Condition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601614F RID: 90447 RVA: 0x0033135D File Offset: 0x0032F55D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016150 RID: 90448 RVA: 0x0033136C File Offset: 0x0032F56C
		public IDetectCombatState2Condition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D38 RID: 27960
		// (get) Token: 0x06016151 RID: 90449 RVA: 0x0033137C File Offset: 0x0032F57C
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

		// Token: 0x17006D39 RID: 27961
		// (get) Token: 0x06016152 RID: 90450 RVA: 0x003313B8 File Offset: 0x0032F5B8
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

		// Token: 0x17006D3A RID: 27962
		// (get) Token: 0x06016153 RID: 90451 RVA: 0x00331418 File Offset: 0x0032F618
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

		// Token: 0x06016154 RID: 90452 RVA: 0x00331454 File Offset: 0x0032F654
		public ICombatState2Condition? Conditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ICombatState2Condition?(default(ICombatState2Condition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006D3B RID: 27963
		// (get) Token: 0x06016155 RID: 90453 RVA: 0x003314B8 File Offset: 0x0032F6B8
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

		// Token: 0x06016156 RID: 90454 RVA: 0x003314E4 File Offset: 0x0032F6E4
		public static Offset<IDetectCombatState2Condition> CreateIDetectCombatState2Condition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IDetectCombatState2Condition.AddConditions(builder, ConditionsOffset);
			IDetectCombatState2Condition.AddPreConditions(builder, PreConditionsOffset);
			IDetectCombatState2Condition.AddCount(builder, Count);
			IDetectCombatState2Condition.AddType(builder, Type);
			return IDetectCombatState2Condition.EndIDetectCombatState2Condition(builder);
		}

		// Token: 0x06016157 RID: 90455 RVA: 0x00331510 File Offset: 0x0032F710
		public static void StartIDetectCombatState2Condition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016158 RID: 90456 RVA: 0x00331519 File Offset: 0x0032F719
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016159 RID: 90457 RVA: 0x00331524 File Offset: 0x0032F724
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601615A RID: 90458 RVA: 0x00331534 File Offset: 0x0032F734
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x0601615B RID: 90459 RVA: 0x0033153F File Offset: 0x0032F73F
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(3, conditionsOffset.Value, 0);
		}

		// Token: 0x0601615C RID: 90460 RVA: 0x00331550 File Offset: 0x0032F750
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICombatState2Condition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601615D RID: 90461 RVA: 0x00331590 File Offset: 0x0032F790
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICombatState2Condition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICombatState2Condition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601615E RID: 90462 RVA: 0x003315AA File Offset: 0x0032F7AA
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICombatState2Condition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICombatState2Condition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601615F RID: 90463 RVA: 0x003315C8 File Offset: 0x0032F7C8
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICombatState2Condition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016160 RID: 90464 RVA: 0x003315E1 File Offset: 0x0032F7E1
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016161 RID: 90465 RVA: 0x003315EC File Offset: 0x0032F7EC
		public static Offset<IDetectCombatState2Condition> EndIDetectCombatState2Condition(FlatBufferBuilder builder)
		{
			return new Offset<IDetectCombatState2Condition>(builder.EndTable());
		}

		// Token: 0x06016162 RID: 90466 RVA: 0x003315FC File Offset: 0x0032F7FC
		public IDetectCombatState2ConditionT UnPack()
		{
			IDetectCombatState2ConditionT detectCombatState2ConditionT = new IDetectCombatState2ConditionT();
			this.UnPackTo(detectCombatState2ConditionT);
			return detectCombatState2ConditionT;
		}

		// Token: 0x06016163 RID: 90467 RVA: 0x00331618 File Offset: 0x0032F818
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

		// Token: 0x06016164 RID: 90468 RVA: 0x003316C0 File Offset: 0x0032F8C0
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

		// Token: 0x0400B70F RID: 46863
		private Table __p;
	}
}
