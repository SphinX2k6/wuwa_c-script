using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004211 RID: 16913
	public struct ITrackRuleFindLastMatchState : IFlatbufferObject
	{
		// Token: 0x17007825 RID: 30757
		// (get) Token: 0x06018FE1 RID: 102369 RVA: 0x00398D61 File Offset: 0x00396F61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018FE2 RID: 102370 RVA: 0x00398D6E File Offset: 0x00396F6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018FE3 RID: 102371 RVA: 0x00398D78 File Offset: 0x00396F78
		public static ITrackRuleFindLastMatchState GetRootAsITrackRuleFindLastMatchState(ByteBuffer _bb)
		{
			return ITrackRuleFindLastMatchState.GetRootAsITrackRuleFindLastMatchState(_bb, default(ITrackRuleFindLastMatchState));
		}

		// Token: 0x06018FE4 RID: 102372 RVA: 0x00398D94 File Offset: 0x00396F94
		public static ITrackRuleFindLastMatchState GetRootAsITrackRuleFindLastMatchState(ByteBuffer _bb, ITrackRuleFindLastMatchState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018FE5 RID: 102373 RVA: 0x00398DB1 File Offset: 0x00396FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018FE6 RID: 102374 RVA: 0x00398DC0 File Offset: 0x00396FC0
		public ITrackRuleFindLastMatchState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007826 RID: 30758
		// (get) Token: 0x06018FE7 RID: 102375 RVA: 0x00398DD0 File Offset: 0x00396FD0
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

		// Token: 0x17007827 RID: 30759
		// (get) Token: 0x06018FE8 RID: 102376 RVA: 0x00398E0C File Offset: 0x0039700C
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

		// Token: 0x06018FE9 RID: 102377 RVA: 0x00398E43 File Offset: 0x00397043
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06018FEA RID: 102378 RVA: 0x00398E52 File Offset: 0x00397052
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06018FEB RID: 102379 RVA: 0x00398E60 File Offset: 0x00397060
		public static Offset<ITrackRuleFindLastMatchState> CreateITrackRuleFindLastMatchState(FlatBufferBuilder builder, ETrackRuleType Type = ETrackRuleType.FindLastMatchState, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITrackRuleFindLastMatchState.AddState(builder, StateOffset);
			ITrackRuleFindLastMatchState.AddType(builder, Type);
			return ITrackRuleFindLastMatchState.EndITrackRuleFindLastMatchState(builder);
		}

		// Token: 0x06018FEC RID: 102380 RVA: 0x00398E7D File Offset: 0x0039707D
		public static void StartITrackRuleFindLastMatchState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018FED RID: 102381 RVA: 0x00398E86 File Offset: 0x00397086
		public static void AddType(FlatBufferBuilder builder, ETrackRuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018FEE RID: 102382 RVA: 0x00398E91 File Offset: 0x00397091
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06018FEF RID: 102383 RVA: 0x00398EA1 File Offset: 0x003970A1
		public static Offset<ITrackRuleFindLastMatchState> EndITrackRuleFindLastMatchState(FlatBufferBuilder builder)
		{
			return new Offset<ITrackRuleFindLastMatchState>(builder.EndTable());
		}

		// Token: 0x06018FF0 RID: 102384 RVA: 0x00398EB0 File Offset: 0x003970B0
		public ITrackRuleFindLastMatchStateT UnPack()
		{
			ITrackRuleFindLastMatchStateT trackRuleFindLastMatchStateT = new ITrackRuleFindLastMatchStateT();
			this.UnPackTo(trackRuleFindLastMatchStateT);
			return trackRuleFindLastMatchStateT;
		}

		// Token: 0x06018FF1 RID: 102385 RVA: 0x00398ECB File Offset: 0x003970CB
		public void UnPackTo(ITrackRuleFindLastMatchStateT _o)
		{
			_o.Type = this.Type;
			_o.State = this.State;
		}

		// Token: 0x06018FF2 RID: 102386 RVA: 0x00398EE8 File Offset: 0x003970E8
		public static Offset<ITrackRuleFindLastMatchState> Pack(FlatBufferBuilder builder, ITrackRuleFindLastMatchStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackRuleFindLastMatchState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return ITrackRuleFindLastMatchState.CreateITrackRuleFindLastMatchState(builder, _o.Type, stateOffset);
		}

		// Token: 0x0400BE82 RID: 48770
		private Table __p;
	}
}
