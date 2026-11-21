using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681D RID: 26653
	public struct IAudioState : IFlatbufferObject
	{
		// Token: 0x1700C3FA RID: 50170
		// (get) Token: 0x0602D8AF RID: 186543 RVA: 0x0063BB6C File Offset: 0x00639D6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D8B0 RID: 186544 RVA: 0x0063BB79 File Offset: 0x00639D79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D8B1 RID: 186545 RVA: 0x0063BB80 File Offset: 0x00639D80
		public static IAudioState GetRootAsIAudioState(ByteBuffer _bb)
		{
			return IAudioState.GetRootAsIAudioState(_bb, default(IAudioState));
		}

		// Token: 0x0602D8B2 RID: 186546 RVA: 0x0063BB9C File Offset: 0x00639D9C
		public static IAudioState GetRootAsIAudioState(ByteBuffer _bb, IAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D8B3 RID: 186547 RVA: 0x0063BBB9 File Offset: 0x00639DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D8B4 RID: 186548 RVA: 0x0063BBC8 File Offset: 0x00639DC8
		public IAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3FB RID: 50171
		// (get) Token: 0x0602D8B5 RID: 186549 RVA: 0x0063BBD8 File Offset: 0x00639DD8
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

		// Token: 0x0602D8B6 RID: 186550 RVA: 0x0063BC0F File Offset: 0x00639E0F
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602D8B7 RID: 186551 RVA: 0x0063BC1E File Offset: 0x00639E1E
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C3FC RID: 50172
		// (get) Token: 0x0602D8B8 RID: 186552 RVA: 0x0063BC2C File Offset: 0x00639E2C
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

		// Token: 0x0602D8B9 RID: 186553 RVA: 0x0063BC63 File Offset: 0x00639E63
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D8BA RID: 186554 RVA: 0x0063BC72 File Offset: 0x00639E72
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602D8BB RID: 186555 RVA: 0x0063BC80 File Offset: 0x00639E80
		public static Offset<IAudioState> CreateIAudioState(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAudioState.AddState(builder, StateOffset);
			IAudioState.AddGroup(builder, GroupOffset);
			return IAudioState.EndIAudioState(builder);
		}

		// Token: 0x0602D8BC RID: 186556 RVA: 0x0063BC9D File Offset: 0x00639E9D
		public static void StartIAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D8BD RID: 186557 RVA: 0x0063BCA6 File Offset: 0x00639EA6
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x0602D8BE RID: 186558 RVA: 0x0063BCB6 File Offset: 0x00639EB6
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602D8BF RID: 186559 RVA: 0x0063BCC6 File Offset: 0x00639EC6
		public static Offset<IAudioState> EndIAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IAudioState>(builder.EndTable());
		}

		// Token: 0x0602D8C0 RID: 186560 RVA: 0x0063BCD4 File Offset: 0x00639ED4
		public IAudioStateT UnPack()
		{
			IAudioStateT audioStateT = new IAudioStateT();
			this.UnPackTo(audioStateT);
			return audioStateT;
		}

		// Token: 0x0602D8C1 RID: 186561 RVA: 0x0063BCEF File Offset: 0x00639EEF
		public void UnPackTo(IAudioStateT _o)
		{
			_o.Group = this.Group;
			_o.State = this.State;
		}

		// Token: 0x0602D8C2 RID: 186562 RVA: 0x0063BD0C File Offset: 0x00639F0C
		public static Offset<IAudioState> Pack(FlatBufferBuilder builder, IAudioStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioState>);
			}
			StringOffset groupOffset = (_o.Group == null) ? default(StringOffset) : builder.CreateString(_o.Group);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IAudioState.CreateIAudioState(builder, groupOffset, stateOffset);
		}

		// Token: 0x040114E0 RID: 70880
		private Table __p;
	}
}
