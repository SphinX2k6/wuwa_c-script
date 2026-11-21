using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200466D RID: 18029
	public struct ITrackRuleFindLastMatchState : IFlatbufferObject
	{
		// Token: 0x17007E56 RID: 32342
		// (get) Token: 0x0601A74D RID: 108365 RVA: 0x003C4439 File Offset: 0x003C2639
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A74E RID: 108366 RVA: 0x003C4446 File Offset: 0x003C2646
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A74F RID: 108367 RVA: 0x003C4450 File Offset: 0x003C2650
		public static ITrackRuleFindLastMatchState GetRootAsITrackRuleFindLastMatchState(ByteBuffer _bb)
		{
			return ITrackRuleFindLastMatchState.GetRootAsITrackRuleFindLastMatchState(_bb, default(ITrackRuleFindLastMatchState));
		}

		// Token: 0x0601A750 RID: 108368 RVA: 0x003C446C File Offset: 0x003C266C
		public static ITrackRuleFindLastMatchState GetRootAsITrackRuleFindLastMatchState(ByteBuffer _bb, ITrackRuleFindLastMatchState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A751 RID: 108369 RVA: 0x003C4489 File Offset: 0x003C2689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A752 RID: 108370 RVA: 0x003C4498 File Offset: 0x003C2698
		public ITrackRuleFindLastMatchState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E57 RID: 32343
		// (get) Token: 0x0601A753 RID: 108371 RVA: 0x003C44A8 File Offset: 0x003C26A8
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

		// Token: 0x17007E58 RID: 32344
		// (get) Token: 0x0601A754 RID: 108372 RVA: 0x003C44E4 File Offset: 0x003C26E4
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

		// Token: 0x0601A755 RID: 108373 RVA: 0x003C451B File Offset: 0x003C271B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601A756 RID: 108374 RVA: 0x003C452A File Offset: 0x003C272A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601A757 RID: 108375 RVA: 0x003C4538 File Offset: 0x003C2738
		public static Offset<ITrackRuleFindLastMatchState> CreateITrackRuleFindLastMatchState(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackRuleFindLastMatchState.AddState(builder, StateOffset);
			ITrackRuleFindLastMatchState.AddType(builder, Type);
			return ITrackRuleFindLastMatchState.EndITrackRuleFindLastMatchState(builder);
		}

		// Token: 0x0601A758 RID: 108376 RVA: 0x003C4555 File Offset: 0x003C2755
		public static void StartITrackRuleFindLastMatchState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A759 RID: 108377 RVA: 0x003C455E File Offset: 0x003C275E
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A75A RID: 108378 RVA: 0x003C4569 File Offset: 0x003C2769
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0601A75B RID: 108379 RVA: 0x003C4579 File Offset: 0x003C2779
		public static Offset<ITrackRuleFindLastMatchState> EndITrackRuleFindLastMatchState(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleFindLastMatchState>(builder.EndTable());
		}

		// Token: 0x0601A75C RID: 108380 RVA: 0x003C4588 File Offset: 0x003C2788
		public ITrackRuleFindLastMatchStateT UnPack()
		{
			ITrackRuleFindLastMatchStateT trackRuleFindLastMatchStateT = new ITrackRuleFindLastMatchStateT();
			this.UnPackTo(trackRuleFindLastMatchStateT);
			return trackRuleFindLastMatchStateT;
		}

		// Token: 0x0601A75D RID: 108381 RVA: 0x003C45A3 File Offset: 0x003C27A3
		public void UnPackTo(ITrackRuleFindLastMatchStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x0601A75E RID: 108382 RVA: 0x003C45C0 File Offset: 0x003C27C0
		public static Offset<ITrackRuleFindLastMatchState> Pack(FlatBufferBuilder builder, ITrackRuleFindLastMatchStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleFindLastMatchState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ITrackRuleFindLastMatchState.CreateITrackRuleFindLastMatchState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400C88F RID: 51343
		private Table __p;
	}
}
