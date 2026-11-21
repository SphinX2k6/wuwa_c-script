using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005409 RID: 21513
	public struct IAudioRangeConfig : IFlatbufferObject
	{
		// Token: 0x17009859 RID: 39001
		// (get) Token: 0x06021A4F RID: 137807 RVA: 0x004A349C File Offset: 0x004A169C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A50 RID: 137808 RVA: 0x004A34A9 File Offset: 0x004A16A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A51 RID: 137809 RVA: 0x004A34B0 File Offset: 0x004A16B0
		public static IAudioRangeConfig GetRootAsIAudioRangeConfig(ByteBuffer _bb)
		{
			return IAudioRangeConfig.GetRootAsIAudioRangeConfig(_bb, default(IAudioRangeConfig));
		}

		// Token: 0x06021A52 RID: 137810 RVA: 0x004A34CC File Offset: 0x004A16CC
		public static IAudioRangeConfig GetRootAsIAudioRangeConfig(ByteBuffer _bb, IAudioRangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A53 RID: 137811 RVA: 0x004A34E9 File Offset: 0x004A16E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A54 RID: 137812 RVA: 0x004A34F8 File Offset: 0x004A16F8
		public IAudioRangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700985A RID: 39002
		// (get) Token: 0x06021A55 RID: 137813 RVA: 0x004A3508 File Offset: 0x004A1708
		public string LeaveAkEvent
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

		// Token: 0x06021A56 RID: 137814 RVA: 0x004A353F File Offset: 0x004A173F
		public Span<byte> GetLeaveAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06021A57 RID: 137815 RVA: 0x004A354E File Offset: 0x004A174E
		public byte[] GetLeaveAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06021A58 RID: 137816 RVA: 0x004A355C File Offset: 0x004A175C
		public static Offset<IAudioRangeConfig> CreateIAudioRangeConfig(FlatBufferBuilder builder, StringOffset LeaveAkEventOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IAudioRangeConfig.AddLeaveAkEvent(builder, LeaveAkEventOffset);
			return IAudioRangeConfig.EndIAudioRangeConfig(builder);
		}

		// Token: 0x06021A59 RID: 137817 RVA: 0x004A3572 File Offset: 0x004A1772
		public static void StartIAudioRangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021A5A RID: 137818 RVA: 0x004A357B File Offset: 0x004A177B
		public static void AddLeaveAkEvent(FlatBufferBuilder builder, StringOffset leaveAkEventOffset)
		{
			builder.AddOffset(0, leaveAkEventOffset.Value, 0);
		}

		// Token: 0x06021A5B RID: 137819 RVA: 0x004A358B File Offset: 0x004A178B
		public static Offset<IAudioRangeConfig> EndIAudioRangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAudioRangeConfig>(builder.EndTable());
		}

		// Token: 0x06021A5C RID: 137820 RVA: 0x004A3598 File Offset: 0x004A1798
		public IAudioRangeConfigT UnPack()
		{
			IAudioRangeConfigT audioRangeConfigT = new IAudioRangeConfigT();
			this.UnPackTo(audioRangeConfigT);
			return audioRangeConfigT;
		}

		// Token: 0x06021A5D RID: 137821 RVA: 0x004A35B3 File Offset: 0x004A17B3
		public void UnPackTo(IAudioRangeConfigT _o)
		{
			_o.LeaveAkEvent = this.LeaveAkEvent;
		}

		// Token: 0x06021A5E RID: 137822 RVA: 0x004A35C4 File Offset: 0x004A17C4
		public static Offset<IAudioRangeConfig> Pack(FlatBufferBuilder builder, IAudioRangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAudioRangeConfig>);
			}
			StringOffset leaveAkEventOffset = (_o.LeaveAkEvent == null) ? default(StringOffset) : builder.CreateString(_o.LeaveAkEvent);
			return IAudioRangeConfig.CreateIAudioRangeConfig(builder, leaveAkEventOffset);
		}

		// Token: 0x0400E88A RID: 59530
		private Table __p;
	}
}
