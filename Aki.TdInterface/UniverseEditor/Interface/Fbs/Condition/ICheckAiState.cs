using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E36 RID: 20022
	public struct ICheckAiState : IFlatbufferObject
	{
		// Token: 0x17008E9C RID: 36508
		// (get) Token: 0x0601EF63 RID: 126819 RVA: 0x004530FC File Offset: 0x004512FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF64 RID: 126820 RVA: 0x00453109 File Offset: 0x00451309
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF65 RID: 126821 RVA: 0x00453110 File Offset: 0x00451310
		public static ICheckAiState GetRootAsICheckAiState(ByteBuffer _bb)
		{
			return ICheckAiState.GetRootAsICheckAiState(_bb, default(ICheckAiState));
		}

		// Token: 0x0601EF66 RID: 126822 RVA: 0x0045312C File Offset: 0x0045132C
		public static ICheckAiState GetRootAsICheckAiState(ByteBuffer _bb, ICheckAiState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF67 RID: 126823 RVA: 0x00453149 File Offset: 0x00451349
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF68 RID: 126824 RVA: 0x00453158 File Offset: 0x00451358
		public ICheckAiState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E9D RID: 36509
		// (get) Token: 0x0601EF69 RID: 126825 RVA: 0x00453168 File Offset: 0x00451368
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

		// Token: 0x17008E9E RID: 36510
		// (get) Token: 0x0601EF6A RID: 126826 RVA: 0x004531A4 File Offset: 0x004513A4
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

		// Token: 0x17008E9F RID: 36511
		// (get) Token: 0x0601EF6B RID: 126827 RVA: 0x004531E0 File Offset: 0x004513E0
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

		// Token: 0x0601EF6C RID: 126828 RVA: 0x0045321C File Offset: 0x0045141C
		public static Offset<ICheckAiState> CreateICheckAiState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, EAiStateType StateType = EAiStateType.AnimalStandUp)
		{
			builder.StartTable(3);
			ICheckAiState.AddStateType(builder, StateType);
			ICheckAiState.AddCompare(builder, Compare);
			ICheckAiState.AddType(builder, Type);
			return ICheckAiState.EndICheckAiState(builder);
		}

		// Token: 0x0601EF6D RID: 126829 RVA: 0x00453240 File Offset: 0x00451440
		public static void StartICheckAiState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EF6E RID: 126830 RVA: 0x00453249 File Offset: 0x00451449
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF6F RID: 126831 RVA: 0x00453254 File Offset: 0x00451454
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EF70 RID: 126832 RVA: 0x0045325F File Offset: 0x0045145F
		public static void AddStateType(FlatBufferBuilder builder, EAiStateType stateType)
		{
			builder.AddByte(2, (byte)stateType, 0);
		}

		// Token: 0x0601EF71 RID: 126833 RVA: 0x0045326A File Offset: 0x0045146A
		public static Offset<ICheckAiState> EndICheckAiState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckAiState>(builder.EndTable());
		}

		// Token: 0x0601EF72 RID: 126834 RVA: 0x00453278 File Offset: 0x00451478
		public ICheckAiStateT UnPack()
		{
			ICheckAiStateT checkAiStateT = new ICheckAiStateT();
			this.UnPackTo(checkAiStateT);
			return checkAiStateT;
		}

		// Token: 0x0601EF73 RID: 126835 RVA: 0x00453293 File Offset: 0x00451493
		public void UnPackTo(ICheckAiStateT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.StateType = this.StateType;
		}

		// Token: 0x0601EF74 RID: 126836 RVA: 0x004532BC File Offset: 0x004514BC
		public static Offset<ICheckAiState> Pack(FlatBufferBuilder builder, ICheckAiStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckAiState>);
			}
			return ICheckAiState.CreateICheckAiState(builder, _o.Type, _o.Compare, _o.StateType);
		}

		// Token: 0x0400DC51 RID: 56401
		private Table __p;
	}
}
