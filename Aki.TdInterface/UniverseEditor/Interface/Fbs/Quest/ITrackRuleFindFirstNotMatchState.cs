using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200466A RID: 18026
	public struct ITrackRuleFindFirstNotMatchState : IFlatbufferObject
	{
		// Token: 0x17007E51 RID: 32337
		// (get) Token: 0x0601A735 RID: 108341 RVA: 0x003C4208 File Offset: 0x003C2408
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A736 RID: 108342 RVA: 0x003C4215 File Offset: 0x003C2415
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A737 RID: 108343 RVA: 0x003C421C File Offset: 0x003C241C
		public static ITrackRuleFindFirstNotMatchState GetRootAsITrackRuleFindFirstNotMatchState(ByteBuffer _bb)
		{
			return ITrackRuleFindFirstNotMatchState.GetRootAsITrackRuleFindFirstNotMatchState(_bb, default(ITrackRuleFindFirstNotMatchState));
		}

		// Token: 0x0601A738 RID: 108344 RVA: 0x003C4238 File Offset: 0x003C2438
		public static ITrackRuleFindFirstNotMatchState GetRootAsITrackRuleFindFirstNotMatchState(ByteBuffer _bb, ITrackRuleFindFirstNotMatchState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A739 RID: 108345 RVA: 0x003C4255 File Offset: 0x003C2455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A73A RID: 108346 RVA: 0x003C4264 File Offset: 0x003C2464
		public ITrackRuleFindFirstNotMatchState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E52 RID: 32338
		// (get) Token: 0x0601A73B RID: 108347 RVA: 0x003C4274 File Offset: 0x003C2474
		public ETrackRuleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackRuleType.FindLastMatchState;
				}
				return (ETrackRuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E53 RID: 32339
		// (get) Token: 0x0601A73C RID: 108348 RVA: 0x003C42B0 File Offset: 0x003C24B0
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A73D RID: 108349 RVA: 0x003C42E7 File Offset: 0x003C24E7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A73E RID: 108350 RVA: 0x003C42F6 File Offset: 0x003C24F6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A73F RID: 108351 RVA: 0x003C4304 File Offset: 0x003C2504
		public static Offset<ITrackRuleFindFirstNotMatchState> CreateITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackRuleFindFirstNotMatchState.AddState(builder, StateOffset);
			ITrackRuleFindFirstNotMatchState.AddType(builder, Type);
			return ITrackRuleFindFirstNotMatchState.EndITrackRuleFindFirstNotMatchState(builder);
		}

		// Token: 0x0601A740 RID: 108352 RVA: 0x003C4321 File Offset: 0x003C2521
		public static void StartITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A741 RID: 108353 RVA: 0x003C432A File Offset: 0x003C252A
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A742 RID: 108354 RVA: 0x003C4335 File Offset: 0x003C2535
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601A743 RID: 108355 RVA: 0x003C4345 File Offset: 0x003C2545
		public static Offset<ITrackRuleFindFirstNotMatchState> EndITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleFindFirstNotMatchState>(builder.EndTable());
		}

		// Token: 0x0601A744 RID: 108356 RVA: 0x003C4354 File Offset: 0x003C2554
		public ITrackRuleFindFirstNotMatchStateT UnPack()
		{
			ITrackRuleFindFirstNotMatchStateT trackRuleFindFirstNotMatchStateT = new ITrackRuleFindFirstNotMatchStateT();
			this.UnPackTo(trackRuleFindFirstNotMatchStateT);
			return trackRuleFindFirstNotMatchStateT;
		}

		// Token: 0x0601A745 RID: 108357 RVA: 0x003C436F File Offset: 0x003C256F
		public void UnPackTo(ITrackRuleFindFirstNotMatchStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0601A746 RID: 108358 RVA: 0x003C438C File Offset: 0x003C258C
		public static Offset<ITrackRuleFindFirstNotMatchState> Pack(FlatBufferBuilder builder, ITrackRuleFindFirstNotMatchStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleFindFirstNotMatchState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ITrackRuleFindFirstNotMatchState.CreateITrackRuleFindFirstNotMatchState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400C88C RID: 51340
		private Table __p;
	}
}
