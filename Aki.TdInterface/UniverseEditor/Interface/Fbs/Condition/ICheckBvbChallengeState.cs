using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200498E RID: 18830
	public struct ICheckBvbChallengeState : IFlatbufferObject
	{
		// Token: 0x17008804 RID: 34820
		// (get) Token: 0x0601D5C6 RID: 120262 RVA: 0x00423B50 File Offset: 0x00421D50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5C7 RID: 120263 RVA: 0x00423B5D File Offset: 0x00421D5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x00423B64 File Offset: 0x00421D64
		public static ICheckBvbChallengeState GetRootAsICheckBvbChallengeState(ByteBuffer _bb)
		{
			return ICheckBvbChallengeState.GetRootAsICheckBvbChallengeState(_bb, default(ICheckBvbChallengeState));
		}

		// Token: 0x0601D5C9 RID: 120265 RVA: 0x00423B80 File Offset: 0x00421D80
		public static ICheckBvbChallengeState GetRootAsICheckBvbChallengeState(ByteBuffer _bb, ICheckBvbChallengeState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5CA RID: 120266 RVA: 0x00423B9D File Offset: 0x00421D9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5CB RID: 120267 RVA: 0x00423BAC File Offset: 0x00421DAC
		public ICheckBvbChallengeState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008805 RID: 34821
		// (get) Token: 0x0601D5CC RID: 120268 RVA: 0x00423BBC File Offset: 0x00421DBC
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

		// Token: 0x17008806 RID: 34822
		// (get) Token: 0x0601D5CD RID: 120269 RVA: 0x00423BF8 File Offset: 0x00421DF8
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

		// Token: 0x17008807 RID: 34823
		// (get) Token: 0x0601D5CE RID: 120270 RVA: 0x00423C34 File Offset: 0x00421E34
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

		// Token: 0x0601D5CF RID: 120271 RVA: 0x00423C70 File Offset: 0x00421E70
		public static Offset<ICheckBvbChallengeState> CreateICheckBvbChallengeState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int ChallengeId = 0, EBvbChallengeStateType ChallengeState = EBvbChallengeStateType.Default)
		{
			builder.StartTable(3);
			ICheckBvbChallengeState.AddChallengeId(builder, ChallengeId);
			ICheckBvbChallengeState.AddChallengeState(builder, ChallengeState);
			ICheckBvbChallengeState.AddType(builder, Type);
			return ICheckBvbChallengeState.EndICheckBvbChallengeState(builder);
		}

		// Token: 0x0601D5D0 RID: 120272 RVA: 0x00423C94 File Offset: 0x00421E94
		public static void StartICheckBvbChallengeState(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D5D1 RID: 120273 RVA: 0x00423C9D File Offset: 0x00421E9D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D5D2 RID: 120274 RVA: 0x00423CA8 File Offset: 0x00421EA8
		public static void AddChallengeId(FlatBufferBuilder builder, int challengeId)
		{
			builder.AddInt(1, challengeId, 0);
		}

		// Token: 0x0601D5D3 RID: 120275 RVA: 0x00423CB3 File Offset: 0x00421EB3
		public static void AddChallengeState(FlatBufferBuilder builder, EBvbChallengeStateType challengeState)
		{
			builder.AddByte(2, (byte)challengeState, 0);
		}

		// Token: 0x0601D5D4 RID: 120276 RVA: 0x00423CBE File Offset: 0x00421EBE
		public static Offset<ICheckBvbChallengeState> EndICheckBvbChallengeState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckBvbChallengeState>(builder.EndTable());
		}

		// Token: 0x0601D5D5 RID: 120277 RVA: 0x00423CCC File Offset: 0x00421ECC
		public ICheckBvbChallengeStateT UnPack()
		{
			ICheckBvbChallengeStateT checkBvbChallengeStateT = new ICheckBvbChallengeStateT();
			this.UnPackTo(checkBvbChallengeStateT);
			return checkBvbChallengeStateT;
		}

		// Token: 0x0601D5D6 RID: 120278 RVA: 0x00423CE7 File Offset: 0x00421EE7
		public void UnPackTo(ICheckBvbChallengeStateT _o)
		{
			_o.Type = this.Type;
			_o.ChallengeId = this.ChallengeId;
			_o.ChallengeState = this.ChallengeState;
		}

		// Token: 0x0601D5D7 RID: 120279 RVA: 0x00423D10 File Offset: 0x00421F10
		public static Offset<ICheckBvbChallengeState> Pack(FlatBufferBuilder builder, ICheckBvbChallengeStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckBvbChallengeState>);
			}
			return ICheckBvbChallengeState.CreateICheckBvbChallengeState(builder, _o.Type, _o.ChallengeId, _o.ChallengeState);
		}

		// Token: 0x0400D19D RID: 53661
		private Table __p;
	}
}
