using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC3 RID: 19139
	public struct ICheckLevelPlayState : IFlatbufferObject
	{
		// Token: 0x17008ABE RID: 35518
		// (get) Token: 0x0601E0C2 RID: 123074 RVA: 0x00437624 File Offset: 0x00435824
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E0C3 RID: 123075 RVA: 0x00437631 File Offset: 0x00435831
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E0C4 RID: 123076 RVA: 0x00437638 File Offset: 0x00435838
		public static ICheckLevelPlayState GetRootAsICheckLevelPlayState(ByteBuffer _bb)
		{
			return ICheckLevelPlayState.GetRootAsICheckLevelPlayState(_bb, default(ICheckLevelPlayState));
		}

		// Token: 0x0601E0C5 RID: 123077 RVA: 0x00437654 File Offset: 0x00435854
		public static ICheckLevelPlayState GetRootAsICheckLevelPlayState(ByteBuffer _bb, ICheckLevelPlayState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E0C6 RID: 123078 RVA: 0x00437671 File Offset: 0x00435871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E0C7 RID: 123079 RVA: 0x00437680 File Offset: 0x00435880
		public ICheckLevelPlayState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008ABF RID: 35519
		// (get) Token: 0x0601E0C8 RID: 123080 RVA: 0x00437690 File Offset: 0x00435890
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

		// Token: 0x17008AC0 RID: 35520
		// (get) Token: 0x0601E0C9 RID: 123081 RVA: 0x004376CC File Offset: 0x004358CC
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

		// Token: 0x17008AC1 RID: 35521
		// (get) Token: 0x0601E0CA RID: 123082 RVA: 0x00437708 File Offset: 0x00435908
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

		// Token: 0x17008AC2 RID: 35522
		// (get) Token: 0x0601E0CB RID: 123083 RVA: 0x00437744 File Offset: 0x00435944
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

		// Token: 0x0601E0CC RID: 123084 RVA: 0x00437781 File Offset: 0x00435981
		public static Offset<ICheckLevelPlayState> CreateICheckLevelPlayState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int LevelId = 0, ECompare Compare = ECompare.Eq, ELevelPlayState State = ELevelPlayState.Close)
		{
			builder.StartTable(4);
			ICheckLevelPlayState.AddLevelId(builder, LevelId);
			ICheckLevelPlayState.AddState(builder, State);
			ICheckLevelPlayState.AddCompare(builder, Compare);
			ICheckLevelPlayState.AddType(builder, Type);
			return ICheckLevelPlayState.EndICheckLevelPlayState(builder);
		}

		// Token: 0x0601E0CD RID: 123085 RVA: 0x004377AD File Offset: 0x004359AD
		public static void StartICheckLevelPlayState(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E0CE RID: 123086 RVA: 0x004377B6 File Offset: 0x004359B6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E0CF RID: 123087 RVA: 0x004377C1 File Offset: 0x004359C1
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(1, levelId, 0);
		}

		// Token: 0x0601E0D0 RID: 123088 RVA: 0x004377CC File Offset: 0x004359CC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E0D1 RID: 123089 RVA: 0x004377D7 File Offset: 0x004359D7
		public static void AddState(FlatBufferBuilder builder, ELevelPlayState state)
		{
			builder.AddByte(3, (byte)state, 0);
		}

		// Token: 0x0601E0D2 RID: 123090 RVA: 0x004377E2 File Offset: 0x004359E2
		public static Offset<ICheckLevelPlayState> EndICheckLevelPlayState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckLevelPlayState>(builder.EndTable());
		}

		// Token: 0x0601E0D3 RID: 123091 RVA: 0x004377F0 File Offset: 0x004359F0
		public ICheckLevelPlayStateT UnPack()
		{
			ICheckLevelPlayStateT checkLevelPlayStateT = new ICheckLevelPlayStateT();
			this.UnPackTo(checkLevelPlayStateT);
			return checkLevelPlayStateT;
		}

		// Token: 0x0601E0D4 RID: 123092 RVA: 0x0043780B File Offset: 0x00435A0B
		public void UnPackTo(ICheckLevelPlayStateT _o)
		{
			_o.Type = this.Type;
			_o.LevelId = this.LevelId;
			_o.Compare = this.Compare;
			_o.State = this.State;
		}

		// Token: 0x0601E0D5 RID: 123093 RVA: 0x00437840 File Offset: 0x00435A40
		public static Offset<ICheckLevelPlayState> Pack(FlatBufferBuilder builder, ICheckLevelPlayStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckLevelPlayState>);
			}
			return ICheckLevelPlayState.CreateICheckLevelPlayState(builder, _o.Type, _o.LevelId, _o.Compare, _o.State);
		}

		// Token: 0x0400D348 RID: 54088
		private Table __p;
	}
}
