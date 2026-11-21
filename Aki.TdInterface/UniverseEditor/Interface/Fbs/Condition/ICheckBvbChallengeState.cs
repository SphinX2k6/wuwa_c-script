using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E45 RID: 20037
	public struct ICheckBvbChallengeState : IFlatbufferObject
	{
		// Token: 0x17008EBF RID: 36543
		// (get) Token: 0x0601EFEB RID: 126955 RVA: 0x00454004 File Offset: 0x00452204
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFEC RID: 126956 RVA: 0x00454011 File Offset: 0x00452211
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFED RID: 126957 RVA: 0x00454018 File Offset: 0x00452218
		public static ICheckBvbChallengeState GetRootAsICheckBvbChallengeState(ByteBuffer _bb)
		{
			return ICheckBvbChallengeState.GetRootAsICheckBvbChallengeState(_bb, default(ICheckBvbChallengeState));
		}

		// Token: 0x0601EFEE RID: 126958 RVA: 0x00454034 File Offset: 0x00452234
		public static ICheckBvbChallengeState GetRootAsICheckBvbChallengeState(ByteBuffer _bb, ICheckBvbChallengeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFEF RID: 126959 RVA: 0x00454051 File Offset: 0x00452251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFF0 RID: 126960 RVA: 0x00454060 File Offset: 0x00452260
		public ICheckBvbChallengeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EC0 RID: 36544
		// (get) Token: 0x0601EFF1 RID: 126961 RVA: 0x00454070 File Offset: 0x00452270
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

		// Token: 0x17008EC1 RID: 36545
		// (get) Token: 0x0601EFF2 RID: 126962 RVA: 0x004540AC File Offset: 0x004522AC
		public int ChallengeId
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

		// Token: 0x17008EC2 RID: 36546
		// (get) Token: 0x0601EFF3 RID: 126963 RVA: 0x004540E8 File Offset: 0x004522E8
		public EBvbChallengeStateType ChallengeState
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EBvbChallengeStateType.Default;
				}
				return (EBvbChallengeStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EFF4 RID: 126964 RVA: 0x00454124 File Offset: 0x00452324
		public static Offset<ICheckBvbChallengeState> CreateICheckBvbChallengeState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChallengeId = 0, EBvbChallengeStateType ChallengeState = EBvbChallengeStateType.Default)
		{
			builder.StartTable(3);
			ICheckBvbChallengeState.AddChallengeId(builder, ChallengeId);
			ICheckBvbChallengeState.AddChallengeState(builder, ChallengeState);
			ICheckBvbChallengeState.AddType(builder, Type);
			return ICheckBvbChallengeState.EndICheckBvbChallengeState(builder);
		}

		// Token: 0x0601EFF5 RID: 126965 RVA: 0x00454148 File Offset: 0x00452348
		public static void StartICheckBvbChallengeState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EFF6 RID: 126966 RVA: 0x00454151 File Offset: 0x00452351
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFF7 RID: 126967 RVA: 0x0045415C File Offset: 0x0045235C
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(1, challengeId, 0);
		}

		// Token: 0x0601EFF8 RID: 126968 RVA: 0x00454167 File Offset: 0x00452367
		public static void AddChallengeState(FlatBufferBuilder builder, EBvbChallengeStateType challengeState)
		{
			builder.AddByte(2, (byte)challengeState, 0);
		}

		// Token: 0x0601EFF9 RID: 126969 RVA: 0x00454172 File Offset: 0x00452372
		public static Offset<ICheckBvbChallengeState> EndICheckBvbChallengeState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckBvbChallengeState>(builder.EndTable());
		}

		// Token: 0x0601EFFA RID: 126970 RVA: 0x00454180 File Offset: 0x00452380
		public ICheckBvbChallengeStateT UnPack()
		{
			ICheckBvbChallengeStateT checkBvbChallengeStateT = new ICheckBvbChallengeStateT();
			this.UnPackTo(checkBvbChallengeStateT);
			return checkBvbChallengeStateT;
		}

		// Token: 0x0601EFFB RID: 126971 RVA: 0x0045419B File Offset: 0x0045239B
		public void UnPackTo(ICheckBvbChallengeStateT _o)
		{
			_o.Type = this.Type;
			_o.ChallengeId = this.ChallengeId;
			_o.ChallengeState = this.ChallengeState;
		}

		// Token: 0x0601EFFC RID: 126972 RVA: 0x004541C4 File Offset: 0x004523C4
		public static Offset<ICheckBvbChallengeState> Pack(FlatBufferBuilder builder, ICheckBvbChallengeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckBvbChallengeState>);
			}
			return ICheckBvbChallengeState.CreateICheckBvbChallengeState(builder, _o.Type, _o.ChallengeId, _o.ChallengeState);
		}

		// Token: 0x0400DC65 RID: 56421
		private Table __p;
	}
}
