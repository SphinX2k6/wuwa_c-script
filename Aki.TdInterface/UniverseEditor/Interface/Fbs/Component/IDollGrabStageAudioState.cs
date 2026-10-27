using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AB RID: 20651
	public struct IDollGrabStageAudioState : IFlatbufferObject
	{
		// Token: 0x17009614 RID: 38420
		// (get) Token: 0x060212C9 RID: 135881 RVA: 0x0049C0A7 File Offset: 0x0049A2A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060212CA RID: 135882 RVA: 0x0049C0B4 File Offset: 0x0049A2B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060212CB RID: 135883 RVA: 0x0049C0BC File Offset: 0x0049A2BC
		public static IDollGrabStageAudioState GetRootAsIDollGrabStageAudioState(ByteBuffer _bb)
		{
			return IDollGrabStageAudioState.GetRootAsIDollGrabStageAudioState(_bb, default(IDollGrabStageAudioState));
		}

		// Token: 0x060212CC RID: 135884 RVA: 0x0049C0D8 File Offset: 0x0049A2D8
		public static IDollGrabStageAudioState GetRootAsIDollGrabStageAudioState(ByteBuffer _bb, IDollGrabStageAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060212CD RID: 135885 RVA: 0x0049C0F5 File Offset: 0x0049A2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060212CE RID: 135886 RVA: 0x0049C104 File Offset: 0x0049A304
		public IDollGrabStageAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009615 RID: 38421
		// (get) Token: 0x060212CF RID: 135887 RVA: 0x0049C114 File Offset: 0x0049A314
		public string Group
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

		// Token: 0x060212D0 RID: 135888 RVA: 0x0049C14B File Offset: 0x0049A34B
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060212D1 RID: 135889 RVA: 0x0049C15A File Offset: 0x0049A35A
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009616 RID: 38422
		// (get) Token: 0x060212D2 RID: 135890 RVA: 0x0049C168 File Offset: 0x0049A368
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

		// Token: 0x060212D3 RID: 135891 RVA: 0x0049C19F File Offset: 0x0049A39F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060212D4 RID: 135892 RVA: 0x0049C1AE File Offset: 0x0049A3AE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060212D5 RID: 135893 RVA: 0x0049C1BC File Offset: 0x0049A3BC
		public static Offset<IDollGrabStageAudioState> CreateIDollGrabStageAudioState(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDollGrabStageAudioState.AddState(builder, StateOffset);
			IDollGrabStageAudioState.AddGroup(builder, GroupOffset);
			return IDollGrabStageAudioState.EndIDollGrabStageAudioState(builder);
		}

		// Token: 0x060212D6 RID: 135894 RVA: 0x0049C1D9 File Offset: 0x0049A3D9
		public static void StartIDollGrabStageAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060212D7 RID: 135895 RVA: 0x0049C1E2 File Offset: 0x0049A3E2
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x060212D8 RID: 135896 RVA: 0x0049C1F2 File Offset: 0x0049A3F2
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060212D9 RID: 135897 RVA: 0x0049C202 File Offset: 0x0049A402
		public static Offset<IDollGrabStageAudioState> EndIDollGrabStageAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabStageAudioState>(builder.EndTable());
		}

		// Token: 0x060212DA RID: 135898 RVA: 0x0049C210 File Offset: 0x0049A410
		public IDollGrabStageAudioStateT UnPack()
		{
			IDollGrabStageAudioStateT dollGrabStageAudioStateT = new IDollGrabStageAudioStateT();
			this.UnPackTo(dollGrabStageAudioStateT);
			return dollGrabStageAudioStateT;
		}

		// Token: 0x060212DB RID: 135899 RVA: 0x0049C22B File Offset: 0x0049A42B
		public void UnPackTo(IDollGrabStageAudioStateT _o)
		{
			_o.Group = this.Group;
			_o.State = this.State;
		}

		// Token: 0x060212DC RID: 135900 RVA: 0x0049C248 File Offset: 0x0049A448
		public static Offset<IDollGrabStageAudioState> Pack(FlatBufferBuilder builder, IDollGrabStageAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabStageAudioState>);
			}
			StringOffset groupOffset = (_o.Group == null) ? default(StringOffset) : builder.CreateString(_o.Group);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IDollGrabStageAudioState.CreateIDollGrabStageAudioState(builder, groupOffset, stateOffset);
		}

		// Token: 0x0400E0D3 RID: 57555
		private Table __p;
	}
}
