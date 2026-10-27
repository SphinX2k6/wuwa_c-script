using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D4F RID: 15695
	public struct ICheckLevelPlayQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006BB4 RID: 27572
		// (get) Token: 0x06015B3B RID: 88891 RVA: 0x00321932 File Offset: 0x0031FB32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B3C RID: 88892 RVA: 0x0032193F File Offset: 0x0031FB3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B3D RID: 88893 RVA: 0x00321948 File Offset: 0x0031FB48
		public static ICheckLevelPlayQuestCondition GetRootAsICheckLevelPlayQuestCondition(ByteBuffer _bb)
		{
			return ICheckLevelPlayQuestCondition.GetRootAsICheckLevelPlayQuestCondition(_bb, default(ICheckLevelPlayQuestCondition));
		}

		// Token: 0x06015B3E RID: 88894 RVA: 0x00321964 File Offset: 0x0031FB64
		public static ICheckLevelPlayQuestCondition GetRootAsICheckLevelPlayQuestCondition(ByteBuffer _bb, ICheckLevelPlayQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B3F RID: 88895 RVA: 0x00321981 File Offset: 0x0031FB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B40 RID: 88896 RVA: 0x00321990 File Offset: 0x0031FB90
		public ICheckLevelPlayQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BB5 RID: 27573
		// (get) Token: 0x06015B41 RID: 88897 RVA: 0x003219A0 File Offset: 0x0031FBA0
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

		// Token: 0x17006BB6 RID: 27574
		// (get) Token: 0x06015B42 RID: 88898 RVA: 0x003219DC File Offset: 0x0031FBDC
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

		// Token: 0x06015B43 RID: 88899 RVA: 0x00321A3C File Offset: 0x0031FC3C
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006BB7 RID: 27575
		// (get) Token: 0x06015B44 RID: 88900 RVA: 0x00321A7C File Offset: 0x0031FC7C
		public int LevelPlayIdsLength
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

		// Token: 0x06015B45 RID: 88901 RVA: 0x00321AA7 File Offset: 0x0031FCA7
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06015B46 RID: 88902 RVA: 0x00321AB6 File Offset: 0x0031FCB6
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17006BB8 RID: 27576
		// (get) Token: 0x06015B47 RID: 88903 RVA: 0x00321AC4 File Offset: 0x0031FCC4
		public int CompleteNumber
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015B48 RID: 88904 RVA: 0x00321B01 File Offset: 0x0031FD01
		public static Offset<ICheckLevelPlayQuestCondition> CreateICheckLevelPlayQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset LevelPlayIdsOffset = default(VectorOffset), int CompleteNumber = 0)
		{
			builder.StartTable(4);
			ICheckLevelPlayQuestCondition.AddCompleteNumber(builder, CompleteNumber);
			ICheckLevelPlayQuestCondition.AddLevelPlayIds(builder, LevelPlayIdsOffset);
			ICheckLevelPlayQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckLevelPlayQuestCondition.AddType(builder, Type);
			return ICheckLevelPlayQuestCondition.EndICheckLevelPlayQuestCondition(builder);
		}

		// Token: 0x06015B49 RID: 88905 RVA: 0x00321B2D File Offset: 0x0031FD2D
		public static void StartICheckLevelPlayQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015B4A RID: 88906 RVA: 0x00321B36 File Offset: 0x0031FD36
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B4B RID: 88907 RVA: 0x00321B41 File Offset: 0x0031FD41
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015B4C RID: 88908 RVA: 0x00321B51 File Offset: 0x0031FD51
		public static void AddLevelPlayIds(FlatBufferBuilder builder, VectorOffset levelPlayIdsOffset)
		{
			builder.AddOffset(2, levelPlayIdsOffset.Value, 0);
		}

		// Token: 0x06015B4D RID: 88909 RVA: 0x00321B64 File Offset: 0x0031FD64
		public static VectorOffset CreateLevelPlayIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06015B4E RID: 88910 RVA: 0x00321B9B File Offset: 0x0031FD9B
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B4F RID: 88911 RVA: 0x00321BB5 File Offset: 0x0031FDB5
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06015B50 RID: 88912 RVA: 0x00321BD3 File Offset: 0x0031FDD3
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06015B51 RID: 88913 RVA: 0x00321BEC File Offset: 0x0031FDEC
		public static void StartLevelPlayIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015B52 RID: 88914 RVA: 0x00321BF7 File Offset: 0x0031FDF7
		public static void AddCompleteNumber(FlatBufferBuilder builder, int completeNumber)
		{
			builder.AddInt(3, completeNumber, 0);
		}

		// Token: 0x06015B53 RID: 88915 RVA: 0x00321C02 File Offset: 0x0031FE02
		public static Offset<ICheckLevelPlayQuestCondition> EndICheckLevelPlayQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015B54 RID: 88916 RVA: 0x00321C10 File Offset: 0x0031FE10
		public ICheckLevelPlayQuestConditionT UnPack()
		{
			ICheckLevelPlayQuestConditionT checkLevelPlayQuestConditionT = new ICheckLevelPlayQuestConditionT();
			this.UnPackTo(checkLevelPlayQuestConditionT);
			return checkLevelPlayQuestConditionT;
		}

		// Token: 0x06015B55 RID: 88917 RVA: 0x00321C2C File Offset: 0x0031FE2C
		public void UnPackTo(ICheckLevelPlayQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.LevelPlayIds = new List<int>();
			for (int i = 0; i < this.LevelPlayIdsLength; i++)
			{
				_o.LevelPlayIds.Add(this.LevelPlayIds(i));
			}
			_o.CompleteNumber = this.CompleteNumber;
		}

		// Token: 0x06015B56 RID: 88918 RVA: 0x00321CB0 File Offset: 0x0031FEB0
		public static Offset<ICheckLevelPlayQuestCondition> Pack(FlatBufferBuilder builder, ICheckLevelPlayQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset levelPlayIdsOffset = default(VectorOffset);
			if (_o.LevelPlayIds != null)
			{
				int[] data = _o.LevelPlayIds.ToArray();
				levelPlayIdsOffset = ICheckLevelPlayQuestCondition.CreateLevelPlayIdsVector(builder, data);
			}
			return ICheckLevelPlayQuestCondition.CreateICheckLevelPlayQuestCondition(builder, _o.Type, preConditionsOffset, levelPlayIdsOffset, _o.CompleteNumber);
		}

		// Token: 0x0400B62A RID: 46634
		private Table __p;
	}
}
