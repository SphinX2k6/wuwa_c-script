using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200497F RID: 18815
	public struct ICheckAiState : IFlatbufferObject
	{
		// Token: 0x170087E1 RID: 34785
		// (get) Token: 0x0601D53E RID: 120126 RVA: 0x00422C48 File Offset: 0x00420E48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D53F RID: 120127 RVA: 0x00422C55 File Offset: 0x00420E55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D540 RID: 120128 RVA: 0x00422C5C File Offset: 0x00420E5C
		public static ICheckAiState GetRootAsICheckAiState(ByteBuffer _bb)
		{
			return ICheckAiState.GetRootAsICheckAiState(_bb, default(ICheckAiState));
		}

		// Token: 0x0601D541 RID: 120129 RVA: 0x00422C78 File Offset: 0x00420E78
		public static ICheckAiState GetRootAsICheckAiState(ByteBuffer _bb, ICheckAiState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x00422C95 File Offset: 0x00420E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D543 RID: 120131 RVA: 0x00422CA4 File Offset: 0x00420EA4
		public ICheckAiState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087E2 RID: 34786
		// (get) Token: 0x0601D544 RID: 120132 RVA: 0x00422CB4 File Offset: 0x00420EB4
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

		// Token: 0x170087E3 RID: 34787
		// (get) Token: 0x0601D545 RID: 120133 RVA: 0x00422CF0 File Offset: 0x00420EF0
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170087E4 RID: 34788
		// (get) Token: 0x0601D546 RID: 120134 RVA: 0x00422D2C File Offset: 0x00420F2C
		public EAiStateType StateType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EAiStateType.AnimalStandUp;
				}
				return (EAiStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D547 RID: 120135 RVA: 0x00422D68 File Offset: 0x00420F68
		public static Offset<ICheckAiState> CreateICheckAiState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, EAiStateType StateType = EAiStateType.AnimalStandUp)
		{
			builder.StartTable(3);
			ICheckAiState.AddStateType(builder, StateType);
			ICheckAiState.AddCompare(builder, Compare);
			ICheckAiState.AddType(builder, Type);
			return ICheckAiState.EndICheckAiState(builder);
		}

		// Token: 0x0601D548 RID: 120136 RVA: 0x00422D8C File Offset: 0x00420F8C
		public static void StartICheckAiState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D549 RID: 120137 RVA: 0x00422D95 File Offset: 0x00420F95
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D54A RID: 120138 RVA: 0x00422DA0 File Offset: 0x00420FA0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601D54B RID: 120139 RVA: 0x00422DAB File Offset: 0x00420FAB
		public static void AddStateType(FlatBufferBuilder builder, EAiStateType stateType)
		{
			builder.AddByte(2, (byte)stateType, 0);
		}

		// Token: 0x0601D54C RID: 120140 RVA: 0x00422DB6 File Offset: 0x00420FB6
		public static Offset<ICheckAiState> EndICheckAiState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAiState>(builder.EndTable());
		}

		// Token: 0x0601D54D RID: 120141 RVA: 0x00422DC4 File Offset: 0x00420FC4
		public ICheckAiStateT UnPack()
		{
			ICheckAiStateT checkAiStateT = new ICheckAiStateT();
			this.UnPackTo(checkAiStateT);
			return checkAiStateT;
		}

		// Token: 0x0601D54E RID: 120142 RVA: 0x00422DDF File Offset: 0x00420FDF
		public void UnPackTo(ICheckAiStateT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.StateType = this.StateType;
		}

		// Token: 0x0601D54F RID: 120143 RVA: 0x00422E08 File Offset: 0x00421008
		public static Offset<ICheckAiState> Pack(FlatBufferBuilder builder, ICheckAiStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAiState>);
			}
			return ICheckAiState.CreateICheckAiState(builder, _o.Type, _o.Compare, _o.StateType);
		}

		// Token: 0x0400D189 RID: 53641
		private Table __p;
	}
}
