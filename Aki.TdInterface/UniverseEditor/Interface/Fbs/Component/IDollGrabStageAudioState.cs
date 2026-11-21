using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005610 RID: 22032
	public struct IDollGrabStageAudioState : IFlatbufferObject
	{
		// Token: 0x17009E01 RID: 40449
		// (get) Token: 0x0602321D RID: 143901 RVA: 0x004D6033 File Offset: 0x004D4233
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602321E RID: 143902 RVA: 0x004D6040 File Offset: 0x004D4240
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602321F RID: 143903 RVA: 0x004D6048 File Offset: 0x004D4248
		public static IDollGrabStageAudioState GetRootAsIDollGrabStageAudioState(ByteBuffer _bb)
		{
			return IDollGrabStageAudioState.GetRootAsIDollGrabStageAudioState(_bb, default(IDollGrabStageAudioState));
		}

		// Token: 0x06023220 RID: 143904 RVA: 0x004D6064 File Offset: 0x004D4264
		public static IDollGrabStageAudioState GetRootAsIDollGrabStageAudioState(ByteBuffer _bb, IDollGrabStageAudioState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023221 RID: 143905 RVA: 0x004D6081 File Offset: 0x004D4281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023222 RID: 143906 RVA: 0x004D6090 File Offset: 0x004D4290
		public IDollGrabStageAudioState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E02 RID: 40450
		// (get) Token: 0x06023223 RID: 143907 RVA: 0x004D60A0 File Offset: 0x004D42A0
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

		// Token: 0x06023224 RID: 143908 RVA: 0x004D60D7 File Offset: 0x004D42D7
		public Span<byte> GetGroupBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06023225 RID: 143909 RVA: 0x004D60E6 File Offset: 0x004D42E6
		public byte[] GetGroupArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17009E03 RID: 40451
		// (get) Token: 0x06023226 RID: 143910 RVA: 0x004D60F4 File Offset: 0x004D42F4
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

		// Token: 0x06023227 RID: 143911 RVA: 0x004D612B File Offset: 0x004D432B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06023228 RID: 143912 RVA: 0x004D613A File Offset: 0x004D433A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06023229 RID: 143913 RVA: 0x004D6148 File Offset: 0x004D4348
		public static Offset<IDollGrabStageAudioState> CreateIDollGrabStageAudioState(FlatBufferBuilder builder, StringOffset GroupOffset = default(StringOffset), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDollGrabStageAudioState.AddState(builder, StateOffset);
			IDollGrabStageAudioState.AddGroup(builder, GroupOffset);
			return IDollGrabStageAudioState.EndIDollGrabStageAudioState(builder);
		}

		// Token: 0x0602322A RID: 143914 RVA: 0x004D6165 File Offset: 0x004D4365
		public static void StartIDollGrabStageAudioState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602322B RID: 143915 RVA: 0x004D616E File Offset: 0x004D436E
		public static void AddGroup(FlatBufferBuilder builder, StringOffset groupOffset)
		{
			builder.AddOffset(0, groupOffset.Value, 0);
		}

		// Token: 0x0602322C RID: 143916 RVA: 0x004D617E File Offset: 0x004D437E
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x0602322D RID: 143917 RVA: 0x004D618E File Offset: 0x004D438E
		public static Offset<IDollGrabStageAudioState> EndIDollGrabStageAudioState(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabStageAudioState>(builder.EndTable());
		}

		// Token: 0x0602322E RID: 143918 RVA: 0x004D619C File Offset: 0x004D439C
		public IDollGrabStageAudioStateT UnPack()
		{
			IDollGrabStageAudioStateT dollGrabStageAudioStateT = new IDollGrabStageAudioStateT();
			this.UnPackTo(dollGrabStageAudioStateT);
			return dollGrabStageAudioStateT;
		}

		// Token: 0x0602322F RID: 143919 RVA: 0x004D61B7 File Offset: 0x004D43B7
		public void UnPackTo(IDollGrabStageAudioStateT _o)
		{
			_o.Group = this.Group;
			_o.State = this.State;
		}

		// Token: 0x06023230 RID: 143920 RVA: 0x004D61D4 File Offset: 0x004D43D4
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

		// Token: 0x0400ECD0 RID: 60624
		private Table __p;
	}
}
