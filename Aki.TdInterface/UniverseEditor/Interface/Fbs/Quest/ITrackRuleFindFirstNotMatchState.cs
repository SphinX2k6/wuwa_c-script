using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420E RID: 16910
	public struct ITrackRuleFindFirstNotMatchState : IFlatbufferObject
	{
		// Token: 0x17007820 RID: 30752
		// (get) Token: 0x06018FC9 RID: 102345 RVA: 0x00398B30 File Offset: 0x00396D30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018FCA RID: 102346 RVA: 0x00398B3D File Offset: 0x00396D3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018FCB RID: 102347 RVA: 0x00398B44 File Offset: 0x00396D44
		public static ITrackRuleFindFirstNotMatchState GetRootAsITrackRuleFindFirstNotMatchState(ByteBuffer _bb)
		{
			return ITrackRuleFindFirstNotMatchState.GetRootAsITrackRuleFindFirstNotMatchState(_bb, default(ITrackRuleFindFirstNotMatchState));
		}

		// Token: 0x06018FCC RID: 102348 RVA: 0x00398B60 File Offset: 0x00396D60
		public static ITrackRuleFindFirstNotMatchState GetRootAsITrackRuleFindFirstNotMatchState(ByteBuffer _bb, ITrackRuleFindFirstNotMatchState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018FCD RID: 102349 RVA: 0x00398B7D File Offset: 0x00396D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018FCE RID: 102350 RVA: 0x00398B8C File Offset: 0x00396D8C
		public ITrackRuleFindFirstNotMatchState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007821 RID: 30753
		// (get) Token: 0x06018FCF RID: 102351 RVA: 0x00398B9C File Offset: 0x00396D9C
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

		// Token: 0x17007822 RID: 30754
		// (get) Token: 0x06018FD0 RID: 102352 RVA: 0x00398BD8 File Offset: 0x00396DD8
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

		// Token: 0x06018FD1 RID: 102353 RVA: 0x00398C0F File Offset: 0x00396E0F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018FD2 RID: 102354 RVA: 0x00398C1E File Offset: 0x00396E1E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018FD3 RID: 102355 RVA: 0x00398C2C File Offset: 0x00396E2C
		public static Offset<ITrackRuleFindFirstNotMatchState> CreateITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackRuleFindFirstNotMatchState.AddState(builder, StateOffset);
			ITrackRuleFindFirstNotMatchState.AddType(builder, Type);
			return ITrackRuleFindFirstNotMatchState.EndITrackRuleFindFirstNotMatchState(builder);
		}

		// Token: 0x06018FD4 RID: 102356 RVA: 0x00398C49 File Offset: 0x00396E49
		public static void StartITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018FD5 RID: 102357 RVA: 0x00398C52 File Offset: 0x00396E52
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018FD6 RID: 102358 RVA: 0x00398C5D File Offset: 0x00396E5D
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06018FD7 RID: 102359 RVA: 0x00398C6D File Offset: 0x00396E6D
		public static Offset<ITrackRuleFindFirstNotMatchState> EndITrackRuleFindFirstNotMatchState(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleFindFirstNotMatchState>(builder.EndTable());
		}

		// Token: 0x06018FD8 RID: 102360 RVA: 0x00398C7C File Offset: 0x00396E7C
		public ITrackRuleFindFirstNotMatchStateT UnPack()
		{
			ITrackRuleFindFirstNotMatchStateT trackRuleFindFirstNotMatchStateT = new ITrackRuleFindFirstNotMatchStateT();
			this.UnPackTo(trackRuleFindFirstNotMatchStateT);
			return trackRuleFindFirstNotMatchStateT;
		}

		// Token: 0x06018FD9 RID: 102361 RVA: 0x00398C97 File Offset: 0x00396E97
		public void UnPackTo(ITrackRuleFindFirstNotMatchStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06018FDA RID: 102362 RVA: 0x00398CB4 File Offset: 0x00396EB4
		public static Offset<ITrackRuleFindFirstNotMatchState> Pack(FlatBufferBuilder builder, ITrackRuleFindFirstNotMatchStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleFindFirstNotMatchState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ITrackRuleFindFirstNotMatchState.CreateITrackRuleFindFirstNotMatchState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400BE7F RID: 48767
		private Table __p;
	}
}
