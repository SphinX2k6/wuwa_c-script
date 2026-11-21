using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004166 RID: 16742
	public struct ICheckLevelPlayQuestCondition : IFlatbufferObject
	{
		// Token: 0x1700716E RID: 29038
		// (get) Token: 0x06017073 RID: 94323 RVA: 0x00348BAA File Offset: 0x00346DAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017074 RID: 94324 RVA: 0x00348BB7 File Offset: 0x00346DB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017075 RID: 94325 RVA: 0x00348BC0 File Offset: 0x00346DC0
		public static ICheckLevelPlayQuestCondition GetRootAsICheckLevelPlayQuestCondition(ByteBuffer _bb)
		{
			return ICheckLevelPlayQuestCondition.GetRootAsICheckLevelPlayQuestCondition(_bb, default(ICheckLevelPlayQuestCondition));
		}

		// Token: 0x06017076 RID: 94326 RVA: 0x00348BDC File Offset: 0x00346DDC
		public static ICheckLevelPlayQuestCondition GetRootAsICheckLevelPlayQuestCondition(ByteBuffer _bb, ICheckLevelPlayQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017077 RID: 94327 RVA: 0x00348BF9 File Offset: 0x00346DF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017078 RID: 94328 RVA: 0x00348C08 File Offset: 0x00346E08
		public ICheckLevelPlayQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700716F RID: 29039
		// (get) Token: 0x06017079 RID: 94329 RVA: 0x00348C18 File Offset: 0x00346E18
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

		// Token: 0x17007170 RID: 29040
		// (get) Token: 0x0601707A RID: 94330 RVA: 0x00348C54 File Offset: 0x00346E54
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

		// Token: 0x0601707B RID: 94331 RVA: 0x00348CB4 File Offset: 0x00346EB4
		public int LevelPlayIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007171 RID: 29041
		// (get) Token: 0x0601707C RID: 94332 RVA: 0x00348CF4 File Offset: 0x00346EF4
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

		// Token: 0x0601707D RID: 94333 RVA: 0x00348D1F File Offset: 0x00346F1F
		public Span<int> GetLevelPlayIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601707E RID: 94334 RVA: 0x00348D2E File Offset: 0x00346F2E
		public int[] GetLevelPlayIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007172 RID: 29042
		// (get) Token: 0x0601707F RID: 94335 RVA: 0x00348D3C File Offset: 0x00346F3C
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

		// Token: 0x06017080 RID: 94336 RVA: 0x00348D79 File Offset: 0x00346F79
		public static Offset<ICheckLevelPlayQuestCondition> CreateICheckLevelPlayQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset LevelPlayIdsOffset = default(VectorOffset), int CompleteNumber = 0)
		{
			builder.StartTable(4);
			ICheckLevelPlayQuestCondition.AddCompleteNumber(builder, CompleteNumber);
			ICheckLevelPlayQuestCondition.AddLevelPlayIds(builder, LevelPlayIdsOffset);
			ICheckLevelPlayQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckLevelPlayQuestCondition.AddType(builder, Type);
			return ICheckLevelPlayQuestCondition.EndICheckLevelPlayQuestCondition(builder);
		}

		// Token: 0x06017081 RID: 94337 RVA: 0x00348DA5 File Offset: 0x00346FA5
		public static void StartICheckLevelPlayQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017082 RID: 94338 RVA: 0x00348DAE File Offset: 0x00346FAE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017083 RID: 94339 RVA: 0x00348DB9 File Offset: 0x00346FB9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017084 RID: 94340 RVA: 0x00348DC9 File Offset: 0x00346FC9
		public static void AddLevelPlayIds(FlatBufferBuilder builder, VectorOffset levelPlayIdsOffset)
		{
			builder.AddOffset(2, levelPlayIdsOffset.Value, 0);
		}

		// Token: 0x06017085 RID: 94341 RVA: 0x00348DDC File Offset: 0x00346FDC
		public static VectorOffset CreateLevelPlayIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017086 RID: 94342 RVA: 0x00348E13 File Offset: 0x00347013
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017087 RID: 94343 RVA: 0x00348E2D File Offset: 0x0034702D
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017088 RID: 94344 RVA: 0x00348E4B File Offset: 0x0034704B
		public static VectorOffset CreateLevelPlayIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017089 RID: 94345 RVA: 0x00348E64 File Offset: 0x00347064
		public static void StartLevelPlayIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601708A RID: 94346 RVA: 0x00348E6F File Offset: 0x0034706F
		public static void AddCompleteNumber(FlatBufferBuilder builder, int completeNumber)
		{
			builder.AddInt(3, completeNumber, 0);
		}

		// Token: 0x0601708B RID: 94347 RVA: 0x00348E7A File Offset: 0x0034707A
		public static Offset<ICheckLevelPlayQuestCondition> EndICheckLevelPlayQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601708C RID: 94348 RVA: 0x00348E88 File Offset: 0x00347088
		public ICheckLevelPlayQuestConditionT UnPack()
		{
			ICheckLevelPlayQuestConditionT checkLevelPlayQuestConditionT = new ICheckLevelPlayQuestConditionT();
			this.UnPackTo(checkLevelPlayQuestConditionT);
			return checkLevelPlayQuestConditionT;
		}

		// Token: 0x0601708D RID: 94349 RVA: 0x00348EA4 File Offset: 0x003470A4
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

		// Token: 0x0601708E RID: 94350 RVA: 0x00348F28 File Offset: 0x00347128
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

		// Token: 0x0400BFD7 RID: 49111
		private Table __p;
	}
}
