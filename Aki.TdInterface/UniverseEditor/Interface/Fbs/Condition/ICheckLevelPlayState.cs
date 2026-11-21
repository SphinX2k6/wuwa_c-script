using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F92 RID: 20370
	public struct ICheckLevelPlayState : IFlatbufferObject
	{
		// Token: 0x170091AB RID: 37291
		// (get) Token: 0x0601FBAB RID: 129963 RVA: 0x00468E44 File Offset: 0x00467044
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FBAC RID: 129964 RVA: 0x00468E51 File Offset: 0x00467051
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FBAD RID: 129965 RVA: 0x00468E58 File Offset: 0x00467058
		public static ICheckLevelPlayState GetRootAsICheckLevelPlayState(ByteBuffer _bb)
		{
			return ICheckLevelPlayState.GetRootAsICheckLevelPlayState(_bb, default(ICheckLevelPlayState));
		}

		// Token: 0x0601FBAE RID: 129966 RVA: 0x00468E74 File Offset: 0x00467074
		public static ICheckLevelPlayState GetRootAsICheckLevelPlayState(ByteBuffer _bb, ICheckLevelPlayState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FBAF RID: 129967 RVA: 0x00468E91 File Offset: 0x00467091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FBB0 RID: 129968 RVA: 0x00468EA0 File Offset: 0x004670A0
		public ICheckLevelPlayState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091AC RID: 37292
		// (get) Token: 0x0601FBB1 RID: 129969 RVA: 0x00468EB0 File Offset: 0x004670B0
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

		// Token: 0x170091AD RID: 37293
		// (get) Token: 0x0601FBB2 RID: 129970 RVA: 0x00468EEC File Offset: 0x004670EC
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091AE RID: 37294
		// (get) Token: 0x0601FBB3 RID: 129971 RVA: 0x00468F28 File Offset: 0x00467128
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091AF RID: 37295
		// (get) Token: 0x0601FBB4 RID: 129972 RVA: 0x00468F64 File Offset: 0x00467164
		public ELevelPlayState State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ELevelPlayState.Close;
				}
				return (ELevelPlayState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FBB5 RID: 129973 RVA: 0x00468FA1 File Offset: 0x004671A1
		public static Offset<ICheckLevelPlayState> CreateICheckLevelPlayState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LevelId = 0, ECompare Compare = ECompare.Eq, ELevelPlayState State = ELevelPlayState.Close)
		{
			builder.StartTable(4);
			ICheckLevelPlayState.AddLevelId(builder, LevelId);
			ICheckLevelPlayState.AddState(builder, State);
			ICheckLevelPlayState.AddCompare(builder, Compare);
			ICheckLevelPlayState.AddType(builder, Type);
			return ICheckLevelPlayState.EndICheckLevelPlayState(builder);
		}

		// Token: 0x0601FBB6 RID: 129974 RVA: 0x00468FCD File Offset: 0x004671CD
		public static void StartICheckLevelPlayState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601FBB7 RID: 129975 RVA: 0x00468FD6 File Offset: 0x004671D6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FBB8 RID: 129976 RVA: 0x00468FE1 File Offset: 0x004671E1
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601FBB9 RID: 129977 RVA: 0x00468FEC File Offset: 0x004671EC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601FBBA RID: 129978 RVA: 0x00468FF7 File Offset: 0x004671F7
		public static void AddState(FlatBufferBuilder builder, ELevelPlayState state)
		{
			builder.AddByte(3, (byte)state, 0);
		}

		// Token: 0x0601FBBB RID: 129979 RVA: 0x00469002 File Offset: 0x00467202
		public static Offset<ICheckLevelPlayState> EndICheckLevelPlayState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayState>(builder.EndTable());
		}

		// Token: 0x0601FBBC RID: 129980 RVA: 0x00469010 File Offset: 0x00467210
		public ICheckLevelPlayStateT UnPack()
		{
			ICheckLevelPlayStateT checkLevelPlayStateT = new ICheckLevelPlayStateT();
			this.UnPackTo(checkLevelPlayStateT);
			return checkLevelPlayStateT;
		}

		// Token: 0x0601FBBD RID: 129981 RVA: 0x0046902B File Offset: 0x0046722B
		public void UnPackTo(ICheckLevelPlayStateT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x0601FBBE RID: 129982 RVA: 0x00469060 File Offset: 0x00467260
		public static Offset<ICheckLevelPlayState> Pack(FlatBufferBuilder builder, ICheckLevelPlayStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayState>);
			}
			return ICheckLevelPlayState.CreateICheckLevelPlayState(builder, _o.Type, _o.LevelId, _o.Compare, _o.State);
		}

		// Token: 0x0400DE2D RID: 56877
		private Table __p;
	}
}
