using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADE RID: 15070
	public struct ISystemVarRef : IFlatbufferObject
	{
		// Token: 0x17006761 RID: 26465
		// (get) Token: 0x06014857 RID: 84055 RVA: 0x002FCFB4 File Offset: 0x002FB1B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014858 RID: 84056 RVA: 0x002FCFC1 File Offset: 0x002FB1C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014859 RID: 84057 RVA: 0x002FCFC8 File Offset: 0x002FB1C8
		public static ISystemVarRef GetRootAsISystemVarRef(ByteBuffer _bb)
		{
			return ISystemVarRef.GetRootAsISystemVarRef(_bb, default(ISystemVarRef));
		}

		// Token: 0x0601485A RID: 84058 RVA: 0x002FCFE4 File Offset: 0x002FB1E4
		public static ISystemVarRef GetRootAsISystemVarRef(ByteBuffer _bb, ISystemVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601485B RID: 84059 RVA: 0x002FD001 File Offset: 0x002FB201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601485C RID: 84060 RVA: 0x002FD010 File Offset: 0x002FB210
		public ISystemVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006762 RID: 26466
		// (get) Token: 0x0601485D RID: 84061 RVA: 0x002FD020 File Offset: 0x002FB220
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006763 RID: 26467
		// (get) Token: 0x0601485E RID: 84062 RVA: 0x002FD05C File Offset: 0x002FB25C
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006764 RID: 26468
		// (get) Token: 0x0601485F RID: 84063 RVA: 0x002FD098 File Offset: 0x002FB298
		public TSystemVar VarType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSystemVar.NONE;
				}
				return (TSystemVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014860 RID: 84064 RVA: 0x002FD0D4 File Offset: 0x002FB2D4
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014861 RID: 84065 RVA: 0x002FD11C File Offset: 0x002FB31C
		public IBvbAdjustPosPreference VarAsIBvbAdjustPosPreference()
		{
			return this.Var<IBvbAdjustPosPreference>().Value;
		}

		// Token: 0x06014862 RID: 84066 RVA: 0x002FD138 File Offset: 0x002FB338
		public IBvbCurRound VarAsIBvbCurRound()
		{
			return this.Var<IBvbCurRound>().Value;
		}

		// Token: 0x06014863 RID: 84067 RVA: 0x002FD154 File Offset: 0x002FB354
		public IBvbDungeonStage VarAsIBvbDungeonStage()
		{
			return this.Var<IBvbDungeonStage>().Value;
		}

		// Token: 0x06014864 RID: 84068 RVA: 0x002FD170 File Offset: 0x002FB370
		public IBvbFetchHandCard VarAsIBvbFetchHandCard()
		{
			return this.Var<IBvbFetchHandCard>().Value;
		}

		// Token: 0x06014865 RID: 84069 RVA: 0x002FD18C File Offset: 0x002FB38C
		public IBvbGetBoardCard VarAsIBvbGetBoardCard()
		{
			return this.Var<IBvbGetBoardCard>().Value;
		}

		// Token: 0x06014866 RID: 84070 RVA: 0x002FD1A8 File Offset: 0x002FB3A8
		public IBvbGetCardChangeUse VarAsIBvbGetCardChangeUse()
		{
			return this.Var<IBvbGetCardChangeUse>().Value;
		}

		// Token: 0x06014867 RID: 84071 RVA: 0x002FD1C4 File Offset: 0x002FB3C4
		public IBvbGetCardEvolvedUse VarAsIBvbGetCardEvolvedUse()
		{
			return this.Var<IBvbGetCardEvolvedUse>().Value;
		}

		// Token: 0x06014868 RID: 84072 RVA: 0x002FD1E0 File Offset: 0x002FB3E0
		public IBvbGetCardPos VarAsIBvbGetCardPos()
		{
			return this.Var<IBvbGetCardPos>().Value;
		}

		// Token: 0x06014869 RID: 84073 RVA: 0x002FD1FC File Offset: 0x002FB3FC
		public IBvbMaxBoardCardCount VarAsIBvbMaxBoardCardCount()
		{
			return this.Var<IBvbMaxBoardCardCount>().Value;
		}

		// Token: 0x0601486A RID: 84074 RVA: 0x002FD218 File Offset: 0x002FB418
		public IBvbMaxRound VarAsIBvbMaxRound()
		{
			return this.Var<IBvbMaxRound>().Value;
		}

		// Token: 0x0601486B RID: 84075 RVA: 0x002FD234 File Offset: 0x002FB434
		public IBvbNpcCardNum VarAsIBvbNpcCardNum()
		{
			return this.Var<IBvbNpcCardNum>().Value;
		}

		// Token: 0x0601486C RID: 84076 RVA: 0x002FD250 File Offset: 0x002FB450
		public IBvbNpcCurBoardCardCount VarAsIBvbNpcCurBoardCardCount()
		{
			return this.Var<IBvbNpcCurBoardCardCount>().Value;
		}

		// Token: 0x0601486D RID: 84077 RVA: 0x002FD26C File Offset: 0x002FB46C
		public IBvbNpcCurEnergy VarAsIBvbNpcCurEnergy()
		{
			return this.Var<IBvbNpcCurEnergy>().Value;
		}

		// Token: 0x0601486E RID: 84078 RVA: 0x002FD288 File Offset: 0x002FB488
		public IBvbNpcHp VarAsIBvbNpcHp()
		{
			return this.Var<IBvbNpcHp>().Value;
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x002FD2A4 File Offset: 0x002FB4A4
		public IBvbNpcHpValue VarAsIBvbNpcHpValue()
		{
			return this.Var<IBvbNpcHpValue>().Value;
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x002FD2C0 File Offset: 0x002FB4C0
		public IBvbNpcScore VarAsIBvbNpcScore()
		{
			return this.Var<IBvbNpcScore>().Value;
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x002FD2DC File Offset: 0x002FB4DC
		public IBvbPlayerHp VarAsIBvbPlayerHp()
		{
			return this.Var<IBvbPlayerHp>().Value;
		}

		// Token: 0x06014872 RID: 84082 RVA: 0x002FD2F8 File Offset: 0x002FB4F8
		public IBvbPlayerHpValue VarAsIBvbPlayerHpValue()
		{
			return this.Var<IBvbPlayerHpValue>().Value;
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x002FD314 File Offset: 0x002FB514
		public IBvbPlayerScore VarAsIBvbPlayerScore()
		{
			return this.Var<IBvbPlayerScore>().Value;
		}

		// Token: 0x06014874 RID: 84084 RVA: 0x002FD330 File Offset: 0x002FB530
		public IBvbRemainEvolveTimeThisTurn VarAsIBvbRemainEvolveTimeThisTurn()
		{
			return this.Var<IBvbRemainEvolveTimeThisTurn>().Value;
		}

		// Token: 0x06014875 RID: 84085 RVA: 0x002FD34C File Offset: 0x002FB54C
		public ICommonHostToTargetDistance VarAsICommonHostToTargetDistance()
		{
			return this.Var<ICommonHostToTargetDistance>().Value;
		}

		// Token: 0x06014876 RID: 84086 RVA: 0x002FD368 File Offset: 0x002FB568
		public ICommonHotFixVar VarAsICommonHotFixVar()
		{
			return this.Var<ICommonHotFixVar>().Value;
		}

		// Token: 0x06014877 RID: 84087 RVA: 0x002FD384 File Offset: 0x002FB584
		public IQuestBranchPageId VarAsIQuestBranchPageId()
		{
			return this.Var<IQuestBranchPageId>().Value;
		}

		// Token: 0x06014878 RID: 84088 RVA: 0x002FD3A0 File Offset: 0x002FB5A0
		public IBvbCustomSystemVarInt VarAsIBvbCustomSystemVarInt()
		{
			return this.Var<IBvbCustomSystemVarInt>().Value;
		}

		// Token: 0x06014879 RID: 84089 RVA: 0x002FD3BC File Offset: 0x002FB5BC
		public IBvbCustomSystemVarFloat VarAsIBvbCustomSystemVarFloat()
		{
			return this.Var<IBvbCustomSystemVarFloat>().Value;
		}

		// Token: 0x0601487A RID: 84090 RVA: 0x002FD3D7 File Offset: 0x002FB5D7
		public static Offset<ISystemVarRef> CreateISystemVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, TSystemVar Var_type = TSystemVar.NONE, int VarOffset = 0)
		{
			builder.StartTable(4);
			ISystemVarRef.AddVar(builder, VarOffset);
			ISystemVarRef.AddVarType(builder, Var_type);
			ISystemVarRef.AddSource(builder, Source);
			ISystemVarRef.AddType(builder, Type);
			return ISystemVarRef.EndISystemVarRef(builder);
		}

		// Token: 0x0601487B RID: 84091 RVA: 0x002FD403 File Offset: 0x002FB603
		public static void StartISystemVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601487C RID: 84092 RVA: 0x002FD40C File Offset: 0x002FB60C
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601487D RID: 84093 RVA: 0x002FD417 File Offset: 0x002FB617
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x0601487E RID: 84094 RVA: 0x002FD422 File Offset: 0x002FB622
		public static void AddVarType(FlatBufferBuilder builder, TSystemVar varType)
		{
			builder.AddByte(2, (byte)varType, 0);
		}

		// Token: 0x0601487F RID: 84095 RVA: 0x002FD42D File Offset: 0x002FB62D
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(3, varOffset, 0);
		}

		// Token: 0x06014880 RID: 84096 RVA: 0x002FD438 File Offset: 0x002FB638
		public static Offset<ISystemVarRef> EndISystemVarRef(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarRef>(builder.EndTable());
		}

		// Token: 0x06014881 RID: 84097 RVA: 0x002FD448 File Offset: 0x002FB648
		public ISystemVarRefT UnPack()
		{
			ISystemVarRefT systemVarRefT = new ISystemVarRefT();
			this.UnPackTo(systemVarRefT);
			return systemVarRefT;
		}

		// Token: 0x06014882 RID: 84098 RVA: 0x002FD464 File Offset: 0x002FB664
		public void UnPackTo(ISystemVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
			_o.Var = new TSystemVarUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TSystemVar.IBvbAdjustPosPreference:
				_o.Var.Value = ((this.Var<IBvbAdjustPosPreference>() != null) ? this.Var<IBvbAdjustPosPreference>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbCurRound:
				_o.Var.Value = ((this.Var<IBvbCurRound>() != null) ? this.Var<IBvbCurRound>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbDungeonStage:
				_o.Var.Value = ((this.Var<IBvbDungeonStage>() != null) ? this.Var<IBvbDungeonStage>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbFetchHandCard:
				_o.Var.Value = ((this.Var<IBvbFetchHandCard>() != null) ? this.Var<IBvbFetchHandCard>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbGetBoardCard:
				_o.Var.Value = ((this.Var<IBvbGetBoardCard>() != null) ? this.Var<IBvbGetBoardCard>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbGetCardChangeUse:
				_o.Var.Value = ((this.Var<IBvbGetCardChangeUse>() != null) ? this.Var<IBvbGetCardChangeUse>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbGetCardEvolvedUse:
				_o.Var.Value = ((this.Var<IBvbGetCardEvolvedUse>() != null) ? this.Var<IBvbGetCardEvolvedUse>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbGetCardPos:
				_o.Var.Value = ((this.Var<IBvbGetCardPos>() != null) ? this.Var<IBvbGetCardPos>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbMaxBoardCardCount:
				_o.Var.Value = ((this.Var<IBvbMaxBoardCardCount>() != null) ? this.Var<IBvbMaxBoardCardCount>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbMaxRound:
				_o.Var.Value = ((this.Var<IBvbMaxRound>() != null) ? this.Var<IBvbMaxRound>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcCardNum:
				_o.Var.Value = ((this.Var<IBvbNpcCardNum>() != null) ? this.Var<IBvbNpcCardNum>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcCurBoardCardCount:
				_o.Var.Value = ((this.Var<IBvbNpcCurBoardCardCount>() != null) ? this.Var<IBvbNpcCurBoardCardCount>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcCurEnergy:
				_o.Var.Value = ((this.Var<IBvbNpcCurEnergy>() != null) ? this.Var<IBvbNpcCurEnergy>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcHp:
				_o.Var.Value = ((this.Var<IBvbNpcHp>() != null) ? this.Var<IBvbNpcHp>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcHpValue:
				_o.Var.Value = ((this.Var<IBvbNpcHpValue>() != null) ? this.Var<IBvbNpcHpValue>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbNpcScore:
				_o.Var.Value = ((this.Var<IBvbNpcScore>() != null) ? this.Var<IBvbNpcScore>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbPlayerHp:
				_o.Var.Value = ((this.Var<IBvbPlayerHp>() != null) ? this.Var<IBvbPlayerHp>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbPlayerHpValue:
				_o.Var.Value = ((this.Var<IBvbPlayerHpValue>() != null) ? this.Var<IBvbPlayerHpValue>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbPlayerScore:
				_o.Var.Value = ((this.Var<IBvbPlayerScore>() != null) ? this.Var<IBvbPlayerScore>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbRemainEvolveTimeThisTurn:
				_o.Var.Value = ((this.Var<IBvbRemainEvolveTimeThisTurn>() != null) ? this.Var<IBvbRemainEvolveTimeThisTurn>().Value.UnPack() : null);
				return;
			case TSystemVar.ICommonHostToTargetDistance:
				_o.Var.Value = ((this.Var<ICommonHostToTargetDistance>() != null) ? this.Var<ICommonHostToTargetDistance>().Value.UnPack() : null);
				return;
			case TSystemVar.ICommonHotFixVar:
				_o.Var.Value = ((this.Var<ICommonHotFixVar>() != null) ? this.Var<ICommonHotFixVar>().Value.UnPack() : null);
				return;
			case TSystemVar.IQuestBranchPageId:
				_o.Var.Value = ((this.Var<IQuestBranchPageId>() != null) ? this.Var<IQuestBranchPageId>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbCustomSystemVarInt:
				_o.Var.Value = ((this.Var<IBvbCustomSystemVarInt>() != null) ? this.Var<IBvbCustomSystemVarInt>().Value.UnPack() : null);
				return;
			case TSystemVar.IBvbCustomSystemVarFloat:
				_o.Var.Value = ((this.Var<IBvbCustomSystemVarFloat>() != null) ? this.Var<IBvbCustomSystemVarFloat>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06014883 RID: 84099 RVA: 0x002FDA8C File Offset: 0x002FBC8C
		public static Offset<ISystemVarRef> Pack(FlatBufferBuilder builder, ISystemVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISystemVarRef>);
			}
			TSystemVar var_type = (_o.Var == null) ? TSystemVar.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TSystemVarUnion.Pack(builder, _o.Var);
			return ISystemVarRef.CreateISystemVarRef(builder, _o.Type, _o.Source, var_type, varOffset);
		}

		// Token: 0x0400AF9E RID: 44958
		private Table __p;
	}
}
