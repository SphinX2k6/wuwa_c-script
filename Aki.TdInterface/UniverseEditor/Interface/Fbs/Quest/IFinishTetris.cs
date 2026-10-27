using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E4E RID: 15950
	public struct IFinishTetris : IFlatbufferObject
	{
		// Token: 0x17006E82 RID: 28290
		// (get) Token: 0x060166C4 RID: 91844 RVA: 0x0033D8BE File Offset: 0x0033BABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060166C5 RID: 91845 RVA: 0x0033D8CB File Offset: 0x0033BACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060166C6 RID: 91846 RVA: 0x0033D8D4 File Offset: 0x0033BAD4
		public static IFinishTetris GetRootAsIFinishTetris(ByteBuffer _bb)
		{
			return IFinishTetris.GetRootAsIFinishTetris(_bb, default(IFinishTetris));
		}

		// Token: 0x060166C7 RID: 91847 RVA: 0x0033D8F0 File Offset: 0x0033BAF0
		public static IFinishTetris GetRootAsIFinishTetris(ByteBuffer _bb, IFinishTetris obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060166C8 RID: 91848 RVA: 0x0033D90D File Offset: 0x0033BB0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060166C9 RID: 91849 RVA: 0x0033D91C File Offset: 0x0033BB1C
		public IFinishTetris __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E83 RID: 28291
		// (get) Token: 0x060166CA RID: 91850 RVA: 0x0033D92C File Offset: 0x0033BB2C
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

		// Token: 0x17006E84 RID: 28292
		// (get) Token: 0x060166CB RID: 91851 RVA: 0x0033D968 File Offset: 0x0033BB68
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

		// Token: 0x17006E85 RID: 28293
		// (get) Token: 0x060166CC RID: 91852 RVA: 0x0033D9C8 File Offset: 0x0033BBC8
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

		// Token: 0x17006E86 RID: 28294
		// (get) Token: 0x060166CD RID: 91853 RVA: 0x0033DA04 File Offset: 0x0033BC04
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

		// Token: 0x060166CE RID: 91854 RVA: 0x0033DA44 File Offset: 0x0033BC44
		public TTable? PlayMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060166CF RID: 91855 RVA: 0x0033DA8C File Offset: 0x0033BC8C
		public ITetrisPlayModeEndless PlayModeAsITetrisPlayModeEndless()
		{
			return this.PlayMode<ITetrisPlayModeEndless>().Value;
		}

		// Token: 0x060166D0 RID: 91856 RVA: 0x0033DAA8 File Offset: 0x0033BCA8
		public ITetrisPlayModeMainLine PlayModeAsITetrisPlayModeMainLine()
		{
			return this.PlayMode<ITetrisPlayModeMainLine>().Value;
		}

		// Token: 0x060166D1 RID: 91857 RVA: 0x0033DAC4 File Offset: 0x0033BCC4
		public ITetrisPlayModeNormal PlayModeAsITetrisPlayModeNormal()
		{
			return this.PlayMode<ITetrisPlayModeNormal>().Value;
		}

		// Token: 0x17006E87 RID: 28295
		// (get) Token: 0x060166D2 RID: 91858 RVA: 0x0033DAE0 File Offset: 0x0033BCE0
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

		// Token: 0x17006E88 RID: 28296
		// (get) Token: 0x060166D3 RID: 91859 RVA: 0x0033DB20 File Offset: 0x0033BD20
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

		// Token: 0x17006E89 RID: 28297
		// (get) Token: 0x060166D4 RID: 91860 RVA: 0x0033DB64 File Offset: 0x0033BD64
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

		// Token: 0x17006E8A RID: 28298
		// (get) Token: 0x060166D5 RID: 91861 RVA: 0x0033DBA8 File Offset: 0x0033BDA8
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

		// Token: 0x060166D6 RID: 91862 RVA: 0x0033DC08 File Offset: 0x0033BE08
		public string AvailableCombineBlocks(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006E8B RID: 28299
		// (get) Token: 0x060166D7 RID: 91863 RVA: 0x0033DC44 File Offset: 0x0033BE44
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

		// Token: 0x17006E8C RID: 28300
		// (get) Token: 0x060166D8 RID: 91864 RVA: 0x0033DC70 File Offset: 0x0033BE70
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

		// Token: 0x060166D9 RID: 91865 RVA: 0x0033DCB0 File Offset: 0x0033BEB0
		public TTable? IsSuccessVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060166DA RID: 91866 RVA: 0x0033DCF8 File Offset: 0x0033BEF8
		public IConstVarRef IsSuccessVarAsIConstVarRef()
		{
			return this.IsSuccessVar<IConstVarRef>().Value;
		}

		// Token: 0x060166DB RID: 91867 RVA: 0x0033DD14 File Offset: 0x0033BF14
		public IGlobalVarRef IsSuccessVarAsIGlobalVarRef()
		{
			return this.IsSuccessVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060166DC RID: 91868 RVA: 0x0033DD30 File Offset: 0x0033BF30
		public IOtherVarRef IsSuccessVarAsIOtherVarRef()
		{
			return this.IsSuccessVar<IOtherVarRef>().Value;
		}

		// Token: 0x060166DD RID: 91869 RVA: 0x0033DD4C File Offset: 0x0033BF4C
		public ISelfVarRef IsSuccessVarAsISelfVarRef()
		{
			return this.IsSuccessVar<ISelfVarRef>().Value;
		}

		// Token: 0x060166DE RID: 91870 RVA: 0x0033DD68 File Offset: 0x0033BF68
		public ISystemVarRef IsSuccessVarAsISystemVarRef()
		{
			return this.IsSuccessVar<ISystemVarRef>().Value;
		}

		// Token: 0x17006E8D RID: 28301
		// (get) Token: 0x060166DF RID: 91871 RVA: 0x0033DD84 File Offset: 0x0033BF84
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

		// Token: 0x060166E0 RID: 91872 RVA: 0x0033DDC4 File Offset: 0x0033BFC4
		public TTable? IsInitializedVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060166E1 RID: 91873 RVA: 0x0033DE0C File Offset: 0x0033C00C
		public IConstVarRef IsInitializedVarAsIConstVarRef()
		{
			return this.IsInitializedVar<IConstVarRef>().Value;
		}

		// Token: 0x060166E2 RID: 91874 RVA: 0x0033DE28 File Offset: 0x0033C028
		public IGlobalVarRef IsInitializedVarAsIGlobalVarRef()
		{
			return this.IsInitializedVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060166E3 RID: 91875 RVA: 0x0033DE44 File Offset: 0x0033C044
		public IOtherVarRef IsInitializedVarAsIOtherVarRef()
		{
			return this.IsInitializedVar<IOtherVarRef>().Value;
		}

		// Token: 0x060166E4 RID: 91876 RVA: 0x0033DE60 File Offset: 0x0033C060
		public ISelfVarRef IsInitializedVarAsISelfVarRef()
		{
			return this.IsInitializedVar<ISelfVarRef>().Value;
		}

		// Token: 0x060166E5 RID: 91877 RVA: 0x0033DE7C File Offset: 0x0033C07C
		public ISystemVarRef IsInitializedVarAsISystemVarRef()
		{
			return this.IsInitializedVar<ISystemVarRef>().Value;
		}

		// Token: 0x17006E8E RID: 28302
		// (get) Token: 0x060166E6 RID: 91878 RVA: 0x0033DE98 File Offset: 0x0033C098
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

		// Token: 0x060166E7 RID: 91879 RVA: 0x0033DED8 File Offset: 0x0033C0D8
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

		// Token: 0x060166E8 RID: 91880 RVA: 0x0033DF68 File Offset: 0x0033C168
		public static void StartIFinishTetris(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x060166E9 RID: 91881 RVA: 0x0033DF72 File Offset: 0x0033C172
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060166EA RID: 91882 RVA: 0x0033DF7D File Offset: 0x0033C17D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060166EB RID: 91883 RVA: 0x0033DF8D File Offset: 0x0033C18D
		public static void AddOriginPosEntityId(FlatBufferBuilder builder, int originPosEntityId)
		{
			builder.AddInt(2, originPosEntityId, 0);
		}

		// Token: 0x060166EC RID: 91884 RVA: 0x0033DF98 File Offset: 0x0033C198
		public static void AddPlayModeType(FlatBufferBuilder builder, TTetrisPlayMode playModeType)
		{
			builder.AddByte(3, (byte)playModeType, 0);
		}

		// Token: 0x060166ED RID: 91885 RVA: 0x0033DFA3 File Offset: 0x0033C1A3
		public static void AddPlayMode(FlatBufferBuilder builder, int playModeOffset)
		{
			builder.AddOffset(4, playModeOffset, 0);
		}

		// Token: 0x060166EE RID: 91886 RVA: 0x0033DFAE File Offset: 0x0033C1AE
		public static void AddDirection(FlatBufferBuilder builder, ETetrisDirection direction)
		{
			builder.AddByte(5, (byte)direction, 0);
		}

		// Token: 0x060166EF RID: 91887 RVA: 0x0033DFB9 File Offset: 0x0033C1B9
		public static void AddPrepareTime(FlatBufferBuilder builder, float prepareTime)
		{
			builder.AddFloat(6, prepareTime, 0.0);
		}

		// Token: 0x060166F0 RID: 91888 RVA: 0x0033DFCC File Offset: 0x0033C1CC
		public static void AddFallSpeed(FlatBufferBuilder builder, float fallSpeed)
		{
			builder.AddFloat(7, fallSpeed, 0.0);
		}

		// Token: 0x060166F1 RID: 91889 RVA: 0x0033DFDF File Offset: 0x0033C1DF
		public static void AddPresetBlocks(FlatBufferBuilder builder, Offset<ITetrisIndexedBoard> presetBlocksOffset)
		{
			builder.AddOffset(8, presetBlocksOffset.Value, 0);
		}

		// Token: 0x060166F2 RID: 91890 RVA: 0x0033DFEF File Offset: 0x0033C1EF
		public static void AddAvailableCombineBlocks(FlatBufferBuilder builder, VectorOffset availableCombineBlocksOffset)
		{
			builder.AddOffset(9, availableCombineBlocksOffset.Value, 0);
		}

		// Token: 0x060166F3 RID: 91891 RVA: 0x0033E000 File Offset: 0x0033C200
		public static VectorOffset CreateAvailableCombineBlocksVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060166F4 RID: 91892 RVA: 0x0033E040 File Offset: 0x0033C240
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060166F5 RID: 91893 RVA: 0x0033E05A File Offset: 0x0033C25A
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060166F6 RID: 91894 RVA: 0x0033E078 File Offset: 0x0033C278
		public static VectorOffset CreateAvailableCombineBlocksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060166F7 RID: 91895 RVA: 0x0033E091 File Offset: 0x0033C291
		public static void StartAvailableCombineBlocksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060166F8 RID: 91896 RVA: 0x0033E09C File Offset: 0x0033C29C
		public static void AddIsSuccessVarType(FlatBufferBuilder builder, TVarRef isSuccessVarType)
		{
			builder.AddByte(10, (byte)isSuccessVarType, 0);
		}

		// Token: 0x060166F9 RID: 91897 RVA: 0x0033E0A8 File Offset: 0x0033C2A8
		public static void AddIsSuccessVar(FlatBufferBuilder builder, int isSuccessVarOffset)
		{
			builder.AddOffset(11, isSuccessVarOffset, 0);
		}

		// Token: 0x060166FA RID: 91898 RVA: 0x0033E0B4 File Offset: 0x0033C2B4
		public static void AddIsInitializedVarType(FlatBufferBuilder builder, TVarRef isInitializedVarType)
		{
			builder.AddByte(12, (byte)isInitializedVarType, 0);
		}

		// Token: 0x060166FB RID: 91899 RVA: 0x0033E0C0 File Offset: 0x0033C2C0
		public static void AddIsInitializedVar(FlatBufferBuilder builder, int isInitializedVarOffset)
		{
			builder.AddOffset(13, isInitializedVarOffset, 0);
		}

		// Token: 0x060166FC RID: 91900 RVA: 0x0033E0CC File Offset: 0x0033C2CC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x060166FD RID: 91901 RVA: 0x0033E0D8 File Offset: 0x0033C2D8
		public static Offset<IFinishTetris> EndIFinishTetris(FlatBufferBuilder builder)
		{
			return new Offset<IFinishTetris>(builder.EndTable());
		}

		// Token: 0x060166FE RID: 91902 RVA: 0x0033E0E8 File Offset: 0x0033C2E8
		public IFinishTetrisT UnPack()
		{
			IFinishTetrisT finishTetrisT = new IFinishTetrisT();
			this.UnPackTo(finishTetrisT);
			return finishTetrisT;
		}

		// Token: 0x060166FF RID: 91903 RVA: 0x0033E104 File Offset: 0x0033C304
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

		// Token: 0x06016700 RID: 91904 RVA: 0x0033E5A0 File Offset: 0x0033C7A0
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

		// Token: 0x0400B7F1 RID: 47089
		private Table __p;
	}
}
