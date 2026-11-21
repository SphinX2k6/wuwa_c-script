using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004289 RID: 17033
	public struct IFinishTetris : IFlatbufferObject
	{
		// Token: 0x17007466 RID: 29798
		// (get) Token: 0x06017CEB RID: 97515 RVA: 0x003663EE File Offset: 0x003645EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017CEC RID: 97516 RVA: 0x003663FB File Offset: 0x003645FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017CED RID: 97517 RVA: 0x00366404 File Offset: 0x00364604
		public static IFinishTetris GetRootAsIFinishTetris(ByteBuffer _bb)
		{
			return IFinishTetris.GetRootAsIFinishTetris(_bb, default(IFinishTetris));
		}

		// Token: 0x06017CEE RID: 97518 RVA: 0x00366420 File Offset: 0x00364620
		public static IFinishTetris GetRootAsIFinishTetris(ByteBuffer _bb, IFinishTetris obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017CEF RID: 97519 RVA: 0x0036643D File Offset: 0x0036463D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017CF0 RID: 97520 RVA: 0x0036644C File Offset: 0x0036464C
		public IFinishTetris __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007467 RID: 29799
		// (get) Token: 0x06017CF1 RID: 97521 RVA: 0x0036645C File Offset: 0x0036465C
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

		// Token: 0x17007468 RID: 29800
		// (get) Token: 0x06017CF2 RID: 97522 RVA: 0x00366498 File Offset: 0x00364698
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

		// Token: 0x17007469 RID: 29801
		// (get) Token: 0x06017CF3 RID: 97523 RVA: 0x003664F8 File Offset: 0x003646F8
		public int OriginPosEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700746A RID: 29802
		// (get) Token: 0x06017CF4 RID: 97524 RVA: 0x00366534 File Offset: 0x00364734
		public TTetrisPlayMode PlayModeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TTetrisPlayMode.NONE;
				}
				return (TTetrisPlayMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017CF5 RID: 97525 RVA: 0x00366574 File Offset: 0x00364774
		public TTable? PlayMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017CF6 RID: 97526 RVA: 0x003665BC File Offset: 0x003647BC
		public ITetrisPlayModeEndless PlayModeAsITetrisPlayModeEndless()
		{
			return this.PlayMode<ITetrisPlayModeEndless>().Value;
		}

		// Token: 0x06017CF7 RID: 97527 RVA: 0x003665D8 File Offset: 0x003647D8
		public ITetrisPlayModeMainLine PlayModeAsITetrisPlayModeMainLine()
		{
			return this.PlayMode<ITetrisPlayModeMainLine>().Value;
		}

		// Token: 0x06017CF8 RID: 97528 RVA: 0x003665F4 File Offset: 0x003647F4
		public ITetrisPlayModeNormal PlayModeAsITetrisPlayModeNormal()
		{
			return this.PlayMode<ITetrisPlayModeNormal>().Value;
		}

		// Token: 0x1700746B RID: 29803
		// (get) Token: 0x06017CF9 RID: 97529 RVA: 0x00366610 File Offset: 0x00364810
		public ETetrisDirection Direction
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return ETetrisDirection.UpDown;
				}
				return (ETetrisDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700746C RID: 29804
		// (get) Token: 0x06017CFA RID: 97530 RVA: 0x00366650 File Offset: 0x00364850
		public float PrepareTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700746D RID: 29805
		// (get) Token: 0x06017CFB RID: 97531 RVA: 0x00366694 File Offset: 0x00364894
		public float FallSpeed
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700746E RID: 29806
		// (get) Token: 0x06017CFC RID: 97532 RVA: 0x003666D8 File Offset: 0x003648D8
		public ITetrisIndexedBoard? PresetBlocks
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new ITetrisIndexedBoard?(default(ITetrisIndexedBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017CFD RID: 97533 RVA: 0x00366738 File Offset: 0x00364938
		public string AvailableCombineBlocks(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700746F RID: 29807
		// (get) Token: 0x06017CFE RID: 97534 RVA: 0x00366774 File Offset: 0x00364974
		public int AvailableCombineBlocksLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007470 RID: 29808
		// (get) Token: 0x06017CFF RID: 97535 RVA: 0x003667A0 File Offset: 0x003649A0
		public TVarRef IsSuccessVarType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D00 RID: 97536 RVA: 0x003667E0 File Offset: 0x003649E0
		public TTable? IsSuccessVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017D01 RID: 97537 RVA: 0x00366828 File Offset: 0x00364A28
		public IConstVarRef IsSuccessVarAsIConstVarRef()
		{
			return this.IsSuccessVar<IConstVarRef>().Value;
		}

		// Token: 0x06017D02 RID: 97538 RVA: 0x00366844 File Offset: 0x00364A44
		public IGlobalVarRef IsSuccessVarAsIGlobalVarRef()
		{
			return this.IsSuccessVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06017D03 RID: 97539 RVA: 0x00366860 File Offset: 0x00364A60
		public IOtherVarRef IsSuccessVarAsIOtherVarRef()
		{
			return this.IsSuccessVar<IOtherVarRef>().Value;
		}

		// Token: 0x06017D04 RID: 97540 RVA: 0x0036687C File Offset: 0x00364A7C
		public ISelfVarRef IsSuccessVarAsISelfVarRef()
		{
			return this.IsSuccessVar<ISelfVarRef>().Value;
		}

		// Token: 0x06017D05 RID: 97541 RVA: 0x00366898 File Offset: 0x00364A98
		public ISystemVarRef IsSuccessVarAsISystemVarRef()
		{
			return this.IsSuccessVar<ISystemVarRef>().Value;
		}

		// Token: 0x17007471 RID: 29809
		// (get) Token: 0x06017D06 RID: 97542 RVA: 0x003668B4 File Offset: 0x00364AB4
		public TVarRef IsInitializedVarType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D07 RID: 97543 RVA: 0x003668F4 File Offset: 0x00364AF4
		public TTable? IsInitializedVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017D08 RID: 97544 RVA: 0x0036693C File Offset: 0x00364B3C
		public IConstVarRef IsInitializedVarAsIConstVarRef()
		{
			return this.IsInitializedVar<IConstVarRef>().Value;
		}

		// Token: 0x06017D09 RID: 97545 RVA: 0x00366958 File Offset: 0x00364B58
		public IGlobalVarRef IsInitializedVarAsIGlobalVarRef()
		{
			return this.IsInitializedVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06017D0A RID: 97546 RVA: 0x00366974 File Offset: 0x00364B74
		public IOtherVarRef IsInitializedVarAsIOtherVarRef()
		{
			return this.IsInitializedVar<IOtherVarRef>().Value;
		}

		// Token: 0x06017D0B RID: 97547 RVA: 0x00366990 File Offset: 0x00364B90
		public ISelfVarRef IsInitializedVarAsISelfVarRef()
		{
			return this.IsInitializedVar<ISelfVarRef>().Value;
		}

		// Token: 0x06017D0C RID: 97548 RVA: 0x003669AC File Offset: 0x00364BAC
		public ISystemVarRef IsInitializedVarAsISystemVarRef()
		{
			return this.IsInitializedVar<ISystemVarRef>().Value;
		}

		// Token: 0x17007472 RID: 29810
		// (get) Token: 0x06017D0D RID: 97549 RVA: 0x003669C8 File Offset: 0x00364BC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D0E RID: 97550 RVA: 0x00366A08 File Offset: 0x00364C08
		public static Offset<IFinishTetris> CreateIFinishTetris(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int OriginPosEntityId = 0, TTetrisPlayMode PlayMode_type = TTetrisPlayMode.NONE, int PlayModeOffset = 0, ETetrisDirection Direction = ETetrisDirection.UpDown, float PrepareTime = 0f, float FallSpeed = 0f, Offset<ITetrisIndexedBoard> PresetBlocksOffset = default(Offset<ITetrisIndexedBoard>), VectorOffset AvailableCombineBlocksOffset = default(VectorOffset), TVarRef IsSuccessVar_type = TVarRef.NONE, int IsSuccessVarOffset = 0, TVarRef IsInitializedVar_type = TVarRef.NONE, int IsInitializedVarOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(15);
			IFinishTetris.AddIsInitializedVar(builder, IsInitializedVarOffset);
			IFinishTetris.AddIsSuccessVar(builder, IsSuccessVarOffset);
			IFinishTetris.AddAvailableCombineBlocks(builder, AvailableCombineBlocksOffset);
			IFinishTetris.AddPresetBlocks(builder, PresetBlocksOffset);
			IFinishTetris.AddFallSpeed(builder, FallSpeed);
			IFinishTetris.AddPrepareTime(builder, PrepareTime);
			IFinishTetris.AddPlayMode(builder, PlayModeOffset);
			IFinishTetris.AddOriginPosEntityId(builder, OriginPosEntityId);
			IFinishTetris.AddPreConditions(builder, PreConditionsOffset);
			IFinishTetris.AddNullMask(builder, NullMask);
			IFinishTetris.AddIsInitializedVarType(builder, IsInitializedVar_type);
			IFinishTetris.AddIsSuccessVarType(builder, IsSuccessVar_type);
			IFinishTetris.AddDirection(builder, Direction);
			IFinishTetris.AddPlayModeType(builder, PlayMode_type);
			IFinishTetris.AddType(builder, Type);
			return IFinishTetris.EndIFinishTetris(builder);
		}

		// Token: 0x06017D0F RID: 97551 RVA: 0x00366A98 File Offset: 0x00364C98
		public static void StartIFinishTetris(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x06017D10 RID: 97552 RVA: 0x00366AA2 File Offset: 0x00364CA2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x00366AAD File Offset: 0x00364CAD
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017D12 RID: 97554 RVA: 0x00366ABD File Offset: 0x00364CBD
		public static void AddOriginPosEntityId(FlatBufferBuilder builder, int originPosEntityId)
		{
			builder.AddInt(2, originPosEntityId, 0);
		}

		// Token: 0x06017D13 RID: 97555 RVA: 0x00366AC8 File Offset: 0x00364CC8
		public static void AddPlayModeType(FlatBufferBuilder builder, TTetrisPlayMode playModeType)
		{
			builder.AddByte(3, (byte)playModeType, 0);
		}

		// Token: 0x06017D14 RID: 97556 RVA: 0x00366AD3 File Offset: 0x00364CD3
		public static void AddPlayMode(FlatBufferBuilder builder, int playModeOffset)
		{
			builder.AddOffset(4, playModeOffset, 0);
		}

		// Token: 0x06017D15 RID: 97557 RVA: 0x00366ADE File Offset: 0x00364CDE
		public static void AddDirection(FlatBufferBuilder builder, ETetrisDirection direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x06017D16 RID: 97558 RVA: 0x00366AE9 File Offset: 0x00364CE9
		public static void AddPrepareTime(FlatBufferBuilder builder, float prepareTime)
		{
			builder.AddFloat(6, prepareTime, 0.0);
		}

		// Token: 0x06017D17 RID: 97559 RVA: 0x00366AFC File Offset: 0x00364CFC
		public static void AddFallSpeed(FlatBufferBuilder builder, float fallSpeed)
		{
			builder.AddFloat(7, fallSpeed, 0.0);
		}

		// Token: 0x06017D18 RID: 97560 RVA: 0x00366B0F File Offset: 0x00364D0F
		public static void AddPresetBlocks(FlatBufferBuilder builder, Offset<ITetrisIndexedBoard> presetBlocksOffset)
		{
			builder.AddOffset(8, presetBlocksOffset.Value, 0);
		}

		// Token: 0x06017D19 RID: 97561 RVA: 0x00366B1F File Offset: 0x00364D1F
		public static void AddAvailableCombineBlocks(FlatBufferBuilder builder, VectorOffset availableCombineBlocksOffset)
		{
			builder.AddOffset(9, availableCombineBlocksOffset.Value, 0);
		}

		// Token: 0x06017D1A RID: 97562 RVA: 0x00366B30 File Offset: 0x00364D30
		public static VectorOffset CreateAvailableCombineBlocksVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017D1B RID: 97563 RVA: 0x00366B70 File Offset: 0x00364D70
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D1C RID: 97564 RVA: 0x00366B8A File Offset: 0x00364D8A
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017D1D RID: 97565 RVA: 0x00366BA8 File Offset: 0x00364DA8
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017D1E RID: 97566 RVA: 0x00366BC1 File Offset: 0x00364DC1
		public static void StartAvailableCombineBlocksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017D1F RID: 97567 RVA: 0x00366BCC File Offset: 0x00364DCC
		public static void AddIsSuccessVarType(FlatBufferBuilder builder, TVarRef isSuccessVarType)
		{
			builder.AddByte(10, (byte)isSuccessVarType, 0);
		}

		// Token: 0x06017D20 RID: 97568 RVA: 0x00366BD8 File Offset: 0x00364DD8
		public static void AddIsSuccessVar(FlatBufferBuilder builder, int isSuccessVarOffset)
		{
			builder.AddOffset(11, isSuccessVarOffset, 0);
		}

		// Token: 0x06017D21 RID: 97569 RVA: 0x00366BE4 File Offset: 0x00364DE4
		public static void AddIsInitializedVarType(FlatBufferBuilder builder, TVarRef isInitializedVarType)
		{
			builder.AddByte(12, (byte)isInitializedVarType, 0);
		}

		// Token: 0x06017D22 RID: 97570 RVA: 0x00366BF0 File Offset: 0x00364DF0
		public static void AddIsInitializedVar(FlatBufferBuilder builder, int isInitializedVarOffset)
		{
			builder.AddOffset(13, isInitializedVarOffset, 0);
		}

		// Token: 0x06017D23 RID: 97571 RVA: 0x00366BFC File Offset: 0x00364DFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x06017D24 RID: 97572 RVA: 0x00366C08 File Offset: 0x00364E08
		public static Offset<IFinishTetris> EndIFinishTetris(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTetris>(builder.EndTable());
		}

		// Token: 0x06017D25 RID: 97573 RVA: 0x00366C18 File Offset: 0x00364E18
		public IFinishTetrisT UnPack()
		{
			IFinishTetrisT finishTetrisT = new IFinishTetrisT();
			this.UnPackTo(finishTetrisT);
			return finishTetrisT;
		}

		// Token: 0x06017D26 RID: 97574 RVA: 0x00366C34 File Offset: 0x00364E34
		public void UnPackTo(IFinishTetrisT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.OriginPosEntityId = this.OriginPosEntityId;
			_o.PlayMode = new TTetrisPlayModeUnion();
			_o.PlayMode.Type = this.PlayModeType;
			switch (this.PlayModeType)
			{
			case TTetrisPlayMode.ITetrisPlayModeEndless:
				_o.PlayMode.Value = ((this.PlayMode<ITetrisPlayModeEndless>() != null) ? this.PlayMode<ITetrisPlayModeEndless>().Value.UnPack() : null);
				break;
			case TTetrisPlayMode.ITetrisPlayModeMainLine:
				_o.PlayMode.Value = ((this.PlayMode<ITetrisPlayModeMainLine>() != null) ? this.PlayMode<ITetrisPlayModeMainLine>().Value.UnPack() : null);
				break;
			case TTetrisPlayMode.ITetrisPlayModeNormal:
				_o.PlayMode.Value = ((this.PlayMode<ITetrisPlayModeNormal>() != null) ? this.PlayMode<ITetrisPlayModeNormal>().Value.UnPack() : null);
				break;
			}
			_o.Direction = this.Direction;
			_o.PrepareTime = this.PrepareTime;
			_o.FallSpeed = this.FallSpeed;
			_o.PresetBlocks = ((this.PresetBlocks != null) ? this.PresetBlocks.Value.UnPack() : null);
			_o.AvailableCombineBlocks = new List<string>();
			for (int i = 0; i < this.AvailableCombineBlocksLength; i++)
			{
				_o.AvailableCombineBlocks.Add(this.AvailableCombineBlocks(i));
			}
			_o.IsSuccessVar = new TVarRefUnion();
			_o.IsSuccessVar.Type = this.IsSuccessVarType;
			switch (this.IsSuccessVarType)
			{
			case TVarRef.IConstVarRef:
				_o.IsSuccessVar.Value = ((this.IsSuccessVar<IConstVarRef>() != null) ? this.IsSuccessVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.IsSuccessVar.Value = ((this.IsSuccessVar<IGlobalVarRef>() != null) ? this.IsSuccessVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.IsSuccessVar.Value = ((this.IsSuccessVar<IOtherVarRef>() != null) ? this.IsSuccessVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.IsSuccessVar.Value = ((this.IsSuccessVar<ISelfVarRef>() != null) ? this.IsSuccessVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.IsSuccessVar.Value = ((this.IsSuccessVar<ISystemVarRef>() != null) ? this.IsSuccessVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.IsInitializedVar = new TVarRefUnion();
			_o.IsInitializedVar.Type = this.IsInitializedVarType;
			switch (this.IsInitializedVarType)
			{
			case TVarRef.IConstVarRef:
				_o.IsInitializedVar.Value = ((this.IsInitializedVar<IConstVarRef>() != null) ? this.IsInitializedVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.IsInitializedVar.Value = ((this.IsInitializedVar<IGlobalVarRef>() != null) ? this.IsInitializedVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.IsInitializedVar.Value = ((this.IsInitializedVar<IOtherVarRef>() != null) ? this.IsInitializedVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.IsInitializedVar.Value = ((this.IsInitializedVar<ISelfVarRef>() != null) ? this.IsInitializedVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.IsInitializedVar.Value = ((this.IsInitializedVar<ISystemVarRef>() != null) ? this.IsInitializedVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017D27 RID: 97575 RVA: 0x003670D0 File Offset: 0x003652D0
		public static Offset<IFinishTetris> Pack(FlatBufferBuilder builder, IFinishTetrisT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishTetris>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TTetrisPlayMode playMode_type = (_o.PlayMode == null) ? TTetrisPlayMode.NONE : _o.PlayMode.Type;
			int playModeOffset = (_o.PlayMode == null) ? 0 : TTetrisPlayModeUnion.Pack(builder, _o.PlayMode);
			Offset<ITetrisIndexedBoard> presetBlocksOffset = (_o.PresetBlocks == null) ? default(Offset<ITetrisIndexedBoard>) : ITetrisIndexedBoard.Pack(builder, _o.PresetBlocks);
			VectorOffset availableCombineBlocksOffset = default(VectorOffset);
			if (_o.AvailableCombineBlocks != null)
			{
				StringOffset[] array = new StringOffset[_o.AvailableCombineBlocks.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.AvailableCombineBlocks[i]);
				}
				availableCombineBlocksOffset = IFinishTetris.CreateAvailableCombineBlocksVector(builder, array);
			}
			TVarRef isSuccessVar_type = (_o.IsSuccessVar == null) ? TVarRef.NONE : _o.IsSuccessVar.Type;
			int isSuccessVarOffset = (_o.IsSuccessVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.IsSuccessVar);
			TVarRef isInitializedVar_type = (_o.IsInitializedVar == null) ? TVarRef.NONE : _o.IsInitializedVar.Type;
			int isInitializedVarOffset = (_o.IsInitializedVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.IsInitializedVar);
			return IFinishTetris.CreateIFinishTetris(builder, _o.Type, preConditionsOffset, _o.OriginPosEntityId, playMode_type, playModeOffset, _o.Direction, _o.PrepareTime, _o.FallSpeed, presetBlocksOffset, availableCombineBlocksOffset, isSuccessVar_type, isSuccessVarOffset, isInitializedVar_type, isInitializedVarOffset, _o.NullMask);
		}

		// Token: 0x0400C1C8 RID: 49608
		private Table __p;
	}
}
