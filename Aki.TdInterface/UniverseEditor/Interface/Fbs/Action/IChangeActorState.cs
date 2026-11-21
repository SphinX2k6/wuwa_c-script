using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006937 RID: 26935
	public struct IChangeActorState : IFlatbufferObject
	{
		// Token: 0x1700C64C RID: 50764
		// (get) Token: 0x0602E2A2 RID: 189090 RVA: 0x0064EB41 File Offset: 0x0064CD41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2A3 RID: 189091 RVA: 0x0064EB4E File Offset: 0x0064CD4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2A4 RID: 189092 RVA: 0x0064EB58 File Offset: 0x0064CD58
		public static IChangeActorState GetRootAsIChangeActorState(ByteBuffer _bb)
		{
			return IChangeActorState.GetRootAsIChangeActorState(_bb, default(IChangeActorState));
		}

		// Token: 0x0602E2A5 RID: 189093 RVA: 0x0064EB74 File Offset: 0x0064CD74
		public static IChangeActorState GetRootAsIChangeActorState(ByteBuffer _bb, IChangeActorState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2A6 RID: 189094 RVA: 0x0064EB91 File Offset: 0x0064CD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2A7 RID: 189095 RVA: 0x0064EBA0 File Offset: 0x0064CDA0
		public IChangeActorState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C64D RID: 50765
		// (get) Token: 0x0602E2A8 RID: 189096 RVA: 0x0064EBB0 File Offset: 0x0064CDB0
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E2A9 RID: 189097 RVA: 0x0064EBE7 File Offset: 0x0064CDE7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E2AA RID: 189098 RVA: 0x0064EBF6 File Offset: 0x0064CDF6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602E2AB RID: 189099 RVA: 0x0064EC04 File Offset: 0x0064CE04
		public static Offset<IChangeActorState> CreateIChangeActorState(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IChangeActorState.AddState(builder, StateOffset);
			return IChangeActorState.EndIChangeActorState(builder);
		}

		// Token: 0x0602E2AC RID: 189100 RVA: 0x0064EC1A File Offset: 0x0064CE1A
		public static void StartIChangeActorState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E2AD RID: 189101 RVA: 0x0064EC23 File Offset: 0x0064CE23
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x0602E2AE RID: 189102 RVA: 0x0064EC33 File Offset: 0x0064CE33
		public static Offset<IChangeActorState> EndIChangeActorState(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorState>(builder.EndTable());
		}

		// Token: 0x0602E2AF RID: 189103 RVA: 0x0064EC40 File Offset: 0x0064CE40
		public IChangeActorStateT UnPack()
		{
			IChangeActorStateT changeActorStateT = new IChangeActorStateT();
			this.UnPackTo(changeActorStateT);
			return changeActorStateT;
		}

		// Token: 0x0602E2B0 RID: 189104 RVA: 0x0064EC5B File Offset: 0x0064CE5B
		public void UnPackTo(IChangeActorStateT _o)
		{
			_o.State = this.State;
		}

		// Token: 0x0602E2B1 RID: 189105 RVA: 0x0064EC6C File Offset: 0x0064CE6C
		public static Offset<IChangeActorState> Pack(FlatBufferBuilder builder, IChangeActorStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorState>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeActorState.CreateIChangeActorState(builder, stateOffset);
		}

		// Token: 0x04011683 RID: 71299
		private Table __p;
	}
}
