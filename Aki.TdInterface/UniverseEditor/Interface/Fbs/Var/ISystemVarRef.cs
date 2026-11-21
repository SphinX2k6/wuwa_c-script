using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE0 RID: 16096
	public struct ISystemVarRef : IFlatbufferObject
	{
		// Token: 0x17006CFC RID: 27900
		// (get) Token: 0x06015D01 RID: 89345 RVA: 0x00323244 File Offset: 0x00321444
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015D02 RID: 89346 RVA: 0x00323251 File Offset: 0x00321451
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015D03 RID: 89347 RVA: 0x00323258 File Offset: 0x00321458
		public static ISystemVarRef GetRootAsISystemVarRef(ByteBuffer _bb)
		{
			return ISystemVarRef.GetRootAsISystemVarRef(_bb, default(ISystemVarRef));
		}

		// Token: 0x06015D04 RID: 89348 RVA: 0x00323274 File Offset: 0x00321474
		public static ISystemVarRef GetRootAsISystemVarRef(ByteBuffer _bb, ISystemVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015D05 RID: 89349 RVA: 0x00323291 File Offset: 0x00321491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015D06 RID: 89350 RVA: 0x003232A0 File Offset: 0x003214A0
		public ISystemVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CFD RID: 27901
		// (get) Token: 0x06015D07 RID: 89351 RVA: 0x003232B0 File Offset: 0x003214B0
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

		// Token: 0x17006CFE RID: 27902
		// (get) Token: 0x06015D08 RID: 89352 RVA: 0x003232EC File Offset: 0x003214EC
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

		// Token: 0x17006CFF RID: 27903
		// (get) Token: 0x06015D09 RID: 89353 RVA: 0x00323328 File Offset: 0x00321528
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

		// Token: 0x06015D0A RID: 89354 RVA: 0x00323364 File Offset: 0x00321564
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015D0B RID: 89355 RVA: 0x003233AC File Offset: 0x003215AC
		public IBvbAdjustPosPreference VarAsIBvbAdjustPosPreference()
		{
			return this.Var<IBvbAdjustPosPreference>().Value;
		}

		// Token: 0x06015D0C RID: 89356 RVA: 0x003233C8 File Offset: 0x003215C8
		public IBvbCurRound VarAsIBvbCurRound()
		{
			return this.Var<IBvbCurRound>().Value;
		}

		// Token: 0x06015D0D RID: 89357 RVA: 0x003233E4 File Offset: 0x003215E4
		public IBvbDungeonStage VarAsIBvbDungeonStage()
		{
			return this.Var<IBvbDungeonStage>().Value;
		}

		// Token: 0x06015D0E RID: 89358 RVA: 0x00323400 File Offset: 0x00321600
		public IBvbFetchHandCard VarAsIBvbFetchHandCard()
		{
			return this.Var<IBvbFetchHandCard>().Value;
		}

		// Token: 0x06015D0F RID: 89359 RVA: 0x0032341C File Offset: 0x0032161C
		public IBvbGetBoardCard VarAsIBvbGetBoardCard()
		{
			return this.Var<IBvbGetBoardCard>().Value;
		}

		// Token: 0x06015D10 RID: 89360 RVA: 0x00323438 File Offset: 0x00321638
		public IBvbGetCardChangeUse VarAsIBvbGetCardChangeUse()
		{
			return this.Var<IBvbGetCardChangeUse>().Value;
		}

		// Token: 0x06015D11 RID: 89361 RVA: 0x00323454 File Offset: 0x00321654
		public IBvbGetCardEvolvedUse VarAsIBvbGetCardEvolvedUse()
		{
			return this.Var<IBvbGetCardEvolvedUse>().Value;
		}

		// Token: 0x06015D12 RID: 89362 RVA: 0x00323470 File Offset: 0x00321670
		public IBvbGetCardPos VarAsIBvbGetCardPos()
		{
			return this.Var<IBvbGetCardPos>().Value;
		}

		// Token: 0x06015D13 RID: 89363 RVA: 0x0032348C File Offset: 0x0032168C
		public IBvbMaxBoardCardCount VarAsIBvbMaxBoardCardCount()
		{
			return this.Var<IBvbMaxBoardCardCount>().Value;
		}

		// Token: 0x06015D14 RID: 89364 RVA: 0x003234A8 File Offset: 0x003216A8
		public IBvbMaxRound VarAsIBvbMaxRound()
		{
			return this.Var<IBvbMaxRound>().Value;
		}

		// Token: 0x06015D15 RID: 89365 RVA: 0x003234C4 File Offset: 0x003216C4
		public IBvbNpcCardNum VarAsIBvbNpcCardNum()
		{
			return this.Var<IBvbNpcCardNum>().Value;
		}

		// Token: 0x06015D16 RID: 89366 RVA: 0x003234E0 File Offset: 0x003216E0
		public IBvbNpcCurBoardCardCount VarAsIBvbNpcCurBoardCardCount()
		{
			return this.Var<IBvbNpcCurBoardCardCount>().Value;
		}

		// Token: 0x06015D17 RID: 89367 RVA: 0x003234FC File Offset: 0x003216FC
		public IBvbNpcCurEnergy VarAsIBvbNpcCurEnergy()
		{
			return this.Var<IBvbNpcCurEnergy>().Value;
		}

		// Token: 0x06015D18 RID: 89368 RVA: 0x00323518 File Offset: 0x00321718
		public IBvbNpcHp VarAsIBvbNpcHp()
		{
			return this.Var<IBvbNpcHp>().Value;
		}

		// Token: 0x06015D19 RID: 89369 RVA: 0x00323534 File Offset: 0x00321734
		public IBvbNpcHpValue VarAsIBvbNpcHpValue()
		{
			return this.Var<IBvbNpcHpValue>().Value;
		}

		// Token: 0x06015D1A RID: 89370 RVA: 0x00323550 File Offset: 0x00321750
		public IBvbNpcScore VarAsIBvbNpcScore()
		{
			return this.Var<IBvbNpcScore>().Value;
		}

		// Token: 0x06015D1B RID: 89371 RVA: 0x0032356C File Offset: 0x0032176C
		public IBvbPlayerHp VarAsIBvbPlayerHp()
		{
			return this.Var<IBvbPlayerHp>().Value;
		}

		// Token: 0x06015D1C RID: 89372 RVA: 0x00323588 File Offset: 0x00321788
		public IBvbPlayerHpValue VarAsIBvbPlayerHpValue()
		{
			return this.Var<IBvbPlayerHpValue>().Value;
		}

		// Token: 0x06015D1D RID: 89373 RVA: 0x003235A4 File Offset: 0x003217A4
		public IBvbPlayerScore VarAsIBvbPlayerScore()
		{
			return this.Var<IBvbPlayerScore>().Value;
		}

		// Token: 0x06015D1E RID: 89374 RVA: 0x003235C0 File Offset: 0x003217C0
		public IBvbRemainEvolveTimeThisTurn VarAsIBvbRemainEvolveTimeThisTurn()
		{
			return this.Var<IBvbRemainEvolveTimeThisTurn>().Value;
		}

		// Token: 0x06015D1F RID: 89375 RVA: 0x003235DC File Offset: 0x003217DC
		public ICommonHostToTargetDistance VarAsICommonHostToTargetDistance()
		{
			return this.Var<ICommonHostToTargetDistance>().Value;
		}

		// Token: 0x06015D20 RID: 89376 RVA: 0x003235F8 File Offset: 0x003217F8
		public ICommonHotFixVar VarAsICommonHotFixVar()
		{
			return this.Var<ICommonHotFixVar>().Value;
		}

		// Token: 0x06015D21 RID: 89377 RVA: 0x00323614 File Offset: 0x00321814
		public IQuestBranchPageId VarAsIQuestBranchPageId()
		{
			return this.Var<IQuestBranchPageId>().Value;
		}

		// Token: 0x06015D22 RID: 89378 RVA: 0x00323630 File Offset: 0x00321830
		public IBvbCustomSystemVarInt VarAsIBvbCustomSystemVarInt()
		{
			return this.Var<IBvbCustomSystemVarInt>().Value;
		}

		// Token: 0x06015D23 RID: 89379 RVA: 0x0032364C File Offset: 0x0032184C
		public IBvbCustomSystemVarFloat VarAsIBvbCustomSystemVarFloat()
		{
			return this.Var<IBvbCustomSystemVarFloat>().Value;
		}

		// Token: 0x06015D24 RID: 89380 RVA: 0x00323667 File Offset: 0x00321867
		public static Offset<ISystemVarRef> CreateISystemVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant, TSystemVar Var_type = TSystemVar.NONE, int VarOffset = 0)
		{
			builder.StartTable(4);
			ISystemVarRef.AddVar(builder, VarOffset);
			ISystemVarRef.AddVarType(builder, Var_type);
			ISystemVarRef.AddSource(builder, Source);
			ISystemVarRef.AddType(builder, Type);
			return ISystemVarRef.EndISystemVarRef(builder);
		}

		// Token: 0x06015D25 RID: 89381 RVA: 0x00323693 File Offset: 0x00321893
		public static void StartISystemVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015D26 RID: 89382 RVA: 0x0032369C File Offset: 0x0032189C
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015D27 RID: 89383 RVA: 0x003236A7 File Offset: 0x003218A7
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015D28 RID: 89384 RVA: 0x003236B2 File Offset: 0x003218B2
		public static void AddVarType(FlatBufferBuilder builder, TSystemVar varType)
		{
			builder.AddByte(2, (byte)varType, 0);
		}

		// Token: 0x06015D29 RID: 89385 RVA: 0x003236BD File Offset: 0x003218BD
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(3, varOffset, 0);
		}

		// Token: 0x06015D2A RID: 89386 RVA: 0x003236C8 File Offset: 0x003218C8
		public static Offset<ISystemVarRef> EndISystemVarRef(FlatBufferBuilder builder)
		{
			return new Offset<ISystemVarRef>(builder.EndTable());
		}

		// Token: 0x06015D2B RID: 89387 RVA: 0x003236D8 File Offset: 0x003218D8
		public ISystemVarRefT UnPack()
		{
			ISystemVarRefT systemVarRefT = new ISystemVarRefT();
			this.UnPackTo(systemVarRefT);
			return systemVarRefT;
		}

		// Token: 0x06015D2C RID: 89388 RVA: 0x003236F4 File Offset: 0x003218F4
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

		// Token: 0x06015D2D RID: 89389 RVA: 0x00323D1C File Offset: 0x00321F1C
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

		// Token: 0x0400B90B RID: 47371
		private Table __p;
	}
}
