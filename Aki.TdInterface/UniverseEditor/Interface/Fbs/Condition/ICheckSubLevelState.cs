using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005016 RID: 20502
	public struct ICheckSubLevelState : IFlatbufferObject
	{
		// Token: 0x170092B0 RID: 37552
		// (get) Token: 0x06020011 RID: 131089 RVA: 0x00470EE2 File Offset: 0x0046F0E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020012 RID: 131090 RVA: 0x00470EEF File Offset: 0x0046F0EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020013 RID: 131091 RVA: 0x00470EF8 File Offset: 0x0046F0F8
		public static ICheckSubLevelState GetRootAsICheckSubLevelState(ByteBuffer _bb)
		{
			return ICheckSubLevelState.GetRootAsICheckSubLevelState(_bb, default(ICheckSubLevelState));
		}

		// Token: 0x06020014 RID: 131092 RVA: 0x00470F14 File Offset: 0x0046F114
		public static ICheckSubLevelState GetRootAsICheckSubLevelState(ByteBuffer _bb, ICheckSubLevelState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020015 RID: 131093 RVA: 0x00470F31 File Offset: 0x0046F131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020016 RID: 131094 RVA: 0x00470F40 File Offset: 0x0046F140
		public ICheckSubLevelState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092B1 RID: 37553
		// (get) Token: 0x06020017 RID: 131095 RVA: 0x00470F50 File Offset: 0x0046F150
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092B2 RID: 37554
		// (get) Token: 0x06020018 RID: 131096 RVA: 0x00470F8C File Offset: 0x0046F18C
		public EConditionCount ConditionCount
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020019 RID: 131097 RVA: 0x00470FC8 File Offset: 0x0046F1C8
		public ICheckSubLevelStateConfig? CheckList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICheckSubLevelStateConfig?(default(ICheckSubLevelStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170092B3 RID: 37555
		// (get) Token: 0x0602001A RID: 131098 RVA: 0x00471028 File Offset: 0x0046F228
		public int CheckListLength
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

		// Token: 0x0602001B RID: 131099 RVA: 0x00471053 File Offset: 0x0046F253
		public static Offset<ICheckSubLevelState> CreateICheckSubLevelState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EConditionCount ConditionCount = EConditionCount.All, VectorOffset CheckListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckSubLevelState.AddCheckList(builder, CheckListOffset);
			ICheckSubLevelState.AddConditionCount(builder, ConditionCount);
			ICheckSubLevelState.AddType(builder, Type);
			return ICheckSubLevelState.EndICheckSubLevelState(builder);
		}

		// Token: 0x0602001C RID: 131100 RVA: 0x00471077 File Offset: 0x0046F277
		public static void StartICheckSubLevelState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602001D RID: 131101 RVA: 0x00471080 File Offset: 0x0046F280
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602001E RID: 131102 RVA: 0x0047108B File Offset: 0x0046F28B
		public static void AddConditionCount(FlatBufferBuilder builder, EConditionCount conditionCount)
		{
			builder.AddByte(1, (byte)conditionCount, 0);
		}

		// Token: 0x0602001F RID: 131103 RVA: 0x00471096 File Offset: 0x0046F296
		public static void AddCheckList(FlatBufferBuilder builder, VectorOffset checkListOffset)
		{
			builder.AddOffset(2, checkListOffset.Value, 0);
		}

		// Token: 0x06020020 RID: 131104 RVA: 0x004710A8 File Offset: 0x0046F2A8
		public static VectorOffset CreateCheckListVector(FlatBufferBuilder builder, Offset<ICheckSubLevelStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020021 RID: 131105 RVA: 0x004710E8 File Offset: 0x0046F2E8
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, Offset<ICheckSubLevelStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020022 RID: 131106 RVA: 0x00471102 File Offset: 0x0046F302
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckSubLevelStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020023 RID: 131107 RVA: 0x00471120 File Offset: 0x0046F320
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020024 RID: 131108 RVA: 0x00471139 File Offset: 0x0046F339
		public static void StartCheckListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020025 RID: 131109 RVA: 0x00471144 File Offset: 0x0046F344
		public static Offset<ICheckSubLevelState> EndICheckSubLevelState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSubLevelState>(builder.EndTable());
		}

		// Token: 0x06020026 RID: 131110 RVA: 0x00471154 File Offset: 0x0046F354
		public ICheckSubLevelStateT UnPack()
		{
			ICheckSubLevelStateT checkSubLevelStateT = new ICheckSubLevelStateT();
			this.UnPackTo(checkSubLevelStateT);
			return checkSubLevelStateT;
		}

		// Token: 0x06020027 RID: 131111 RVA: 0x00471170 File Offset: 0x0046F370
		public void UnPackTo(ICheckSubLevelStateT _o)
		{
			_o.Type = this.Type;
			_o.ConditionCount = this.ConditionCount;
			_o.CheckList = new List<ICheckSubLevelStateConfigT>();
			for (int i = 0; i < this.CheckListLength; i++)
			{
				_o.CheckList.Add((this.CheckList(i) != null) ? this.CheckList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06020028 RID: 131112 RVA: 0x004711E8 File Offset: 0x0046F3E8
		public static Offset<ICheckSubLevelState> Pack(FlatBufferBuilder builder, ICheckSubLevelStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSubLevelState>);
			}
			VectorOffset checkListOffset = default(VectorOffset);
			if (_o.CheckList != null)
			{
				Offset<ICheckSubLevelStateConfig>[] array = new Offset<ICheckSubLevelStateConfig>[_o.CheckList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICheckSubLevelStateConfig.Pack(builder, _o.CheckList[i]);
				}
				checkListOffset = ICheckSubLevelState.CreateCheckListVector(builder, array);
			}
			return ICheckSubLevelState.CreateICheckSubLevelState(builder, _o.Type, _o.ConditionCount, checkListOffset);
		}

		// Token: 0x0400DED3 RID: 57043
		private Table __p;
	}
}
