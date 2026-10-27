using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061AF RID: 25007
	public struct IAudioState : IFlatbufferObject
	{
		// Token: 0x1700BA77 RID: 47735
		// (get) Token: 0x0602B168 RID: 176488 RVA: 0x005F10F8 File Offset: 0x005EF2F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B169 RID: 176489 RVA: 0x005F1105 File Offset: 0x005EF305
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B16A RID: 176490 RVA: 0x005F110C File Offset: 0x005EF30C
		public static IAudioState GetRootAsIAudioState(ByteBuffer _bb)
		{
			return IAudioState.GetRootAsIAudioState(_bb, default(IAudioState));
		}

		// Token: 0x0602B16B RID: 176491 RVA: 0x005F1128 File Offset: 0x005EF328
		public static IAudioState GetRootAsIAudioState(ByteBuffer _bb, IAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B16C RID: 176492 RVA: 0x005F1145 File Offset: 0x005EF345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B16D RID: 176493 RVA: 0x005F1154 File Offset: 0x005EF354
		public IAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA78 RID: 47736
		// (get) Token: 0x0602B16E RID: 176494 RVA: 0x005F1164 File Offset: 0x005EF364
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

		// Token: 0x0602B16F RID: 176495 RVA: 0x005F119B File Offset: 0x005EF39B
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B170 RID: 176496 RVA: 0x005F11AA File Offset: 0x005EF3AA
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BA79 RID: 47737
		// (get) Token: 0x0602B171 RID: 176497 RVA: 0x005F11B8 File Offset: 0x005EF3B8
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

		// Token: 0x0602B172 RID: 176498 RVA: 0x005F11EF File Offset: 0x005EF3EF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602B173 RID: 176499 RVA: 0x005F11FE File Offset: 0x005EF3FE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602B174 RID: 176500 RVA: 0x005F120C File Offset: 0x005EF40C
		public static Offset<IAudioState> CreateIAudioState(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAudioState.AddState(builder, StateOffset);
			IAudioState.AddGroup(builder, GroupOffset);
			return IAudioState.EndIAudioState(builder);
		}

		// Token: 0x0602B175 RID: 176501 RVA: 0x005F1229 File Offset: 0x005EF429
		public static void StartIAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B176 RID: 176502 RVA: 0x005F1232 File Offset: 0x005EF432
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x0602B177 RID: 176503 RVA: 0x005F1242 File Offset: 0x005EF442
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602B178 RID: 176504 RVA: 0x005F1252 File Offset: 0x005EF452
		public static Offset<IAudioState> EndIAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IAudioState>(builder.EndTable());
		}

		// Token: 0x0602B179 RID: 176505 RVA: 0x005F1260 File Offset: 0x005EF460
		public IAudioStateT UnPack()
		{
			IAudioStateT audioStateT = new IAudioStateT();
			this.UnPackTo(audioStateT);
			return audioStateT;
		}

		// Token: 0x0602B17A RID: 176506 RVA: 0x005F127B File Offset: 0x005EF47B
		public void UnPackTo(IAudioStateT _o)
		{
			_o.Group = this.Group;
			_o.State = this.State;
		}

		// Token: 0x0602B17B RID: 176507 RVA: 0x005F1298 File Offset: 0x005EF498
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

		// Token: 0x040106CE RID: 67278
		private Table __p;
	}
}
