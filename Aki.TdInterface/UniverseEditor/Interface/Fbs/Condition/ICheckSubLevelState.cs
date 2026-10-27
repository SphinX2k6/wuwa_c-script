using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B2F RID: 19247
	public struct ICheckSubLevelState : IFlatbufferObject
	{
		// Token: 0x17008BA0 RID: 35744
		// (get) Token: 0x0601E486 RID: 124038 RVA: 0x0043E736 File Offset: 0x0043C936
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E487 RID: 124039 RVA: 0x0043E743 File Offset: 0x0043C943
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E488 RID: 124040 RVA: 0x0043E74C File Offset: 0x0043C94C
		public static ICheckSubLevelState GetRootAsICheckSubLevelState(ByteBuffer _bb)
		{
			return ICheckSubLevelState.GetRootAsICheckSubLevelState(_bb, default(ICheckSubLevelState));
		}

		// Token: 0x0601E489 RID: 124041 RVA: 0x0043E768 File Offset: 0x0043C968
		public static ICheckSubLevelState GetRootAsICheckSubLevelState(ByteBuffer _bb, ICheckSubLevelState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E48A RID: 124042 RVA: 0x0043E785 File Offset: 0x0043C985
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E48B RID: 124043 RVA: 0x0043E794 File Offset: 0x0043C994
		public ICheckSubLevelState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BA1 RID: 35745
		// (get) Token: 0x0601E48C RID: 124044 RVA: 0x0043E7A4 File Offset: 0x0043C9A4
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

		// Token: 0x17008BA2 RID: 35746
		// (get) Token: 0x0601E48D RID: 124045 RVA: 0x0043E7E0 File Offset: 0x0043C9E0
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

		// Token: 0x0601E48E RID: 124046 RVA: 0x0043E81C File Offset: 0x0043CA1C
		public ICheckSubLevelStateConfig? CheckList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICheckSubLevelStateConfig?(default(ICheckSubLevelStateConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008BA3 RID: 35747
		// (get) Token: 0x0601E48F RID: 124047 RVA: 0x0043E87C File Offset: 0x0043CA7C
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

		// Token: 0x0601E490 RID: 124048 RVA: 0x0043E8A7 File Offset: 0x0043CAA7
		public static Offset<ICheckSubLevelState> CreateICheckSubLevelState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EConditionCount ConditionCount = EConditionCount.All, VectorOffset CheckListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckSubLevelState.AddCheckList(builder, CheckListOffset);
			ICheckSubLevelState.AddConditionCount(builder, ConditionCount);
			ICheckSubLevelState.AddType(builder, Type);
			return ICheckSubLevelState.EndICheckSubLevelState(builder);
		}

		// Token: 0x0601E491 RID: 124049 RVA: 0x0043E8CB File Offset: 0x0043CACB
		public static void StartICheckSubLevelState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E492 RID: 124050 RVA: 0x0043E8D4 File Offset: 0x0043CAD4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E493 RID: 124051 RVA: 0x0043E8DF File Offset: 0x0043CADF
		public static void AddConditionCount(FlatBufferBuilder builder, EConditionCount conditionCount)
		{
			builder.AddByte(1, (byte)conditionCount, 0);
		}

		// Token: 0x0601E494 RID: 124052 RVA: 0x0043E8EA File Offset: 0x0043CAEA
		public static void AddCheckList(FlatBufferBuilder builder, VectorOffset checkListOffset)
		{
			builder.AddOffset(2, checkListOffset.Value, 0);
		}

		// Token: 0x0601E495 RID: 124053 RVA: 0x0043E8FC File Offset: 0x0043CAFC
		public static VectorOffset CreateCheckListVector(FlatBufferBuilder builder, Offset<ICheckSubLevelStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E496 RID: 124054 RVA: 0x0043E93C File Offset: 0x0043CB3C
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, Offset<ICheckSubLevelStateConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E497 RID: 124055 RVA: 0x0043E956 File Offset: 0x0043CB56
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckSubLevelStateConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E498 RID: 124056 RVA: 0x0043E974 File Offset: 0x0043CB74
		public static VectorOffset CreateCheckListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckSubLevelStateConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E499 RID: 124057 RVA: 0x0043E98D File Offset: 0x0043CB8D
		public static void StartCheckListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E49A RID: 124058 RVA: 0x0043E998 File Offset: 0x0043CB98
		public static Offset<ICheckSubLevelState> EndICheckSubLevelState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSubLevelState>(builder.EndTable());
		}

		// Token: 0x0601E49B RID: 124059 RVA: 0x0043E9A8 File Offset: 0x0043CBA8
		public ICheckSubLevelStateT UnPack()
		{
			ICheckSubLevelStateT checkSubLevelStateT = new ICheckSubLevelStateT();
			this.UnPackTo(checkSubLevelStateT);
			return checkSubLevelStateT;
		}

		// Token: 0x0601E49C RID: 124060 RVA: 0x0043E9C4 File Offset: 0x0043CBC4
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

		// Token: 0x0601E49D RID: 124061 RVA: 0x0043EA3C File Offset: 0x0043CC3C
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

		// Token: 0x0400D3D4 RID: 54228
		private Table __p;
	}
}
