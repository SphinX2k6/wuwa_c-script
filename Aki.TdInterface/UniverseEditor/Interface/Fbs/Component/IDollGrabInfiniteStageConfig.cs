using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005601 RID: 22017
	public struct IDollGrabInfiniteStageConfig : IFlatbufferObject
	{
		// Token: 0x17009DD4 RID: 40404
		// (get) Token: 0x06023179 RID: 143737 RVA: 0x004D4A2E File Offset: 0x004D2C2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602317A RID: 143738 RVA: 0x004D4A3B File Offset: 0x004D2C3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602317B RID: 143739 RVA: 0x004D4A44 File Offset: 0x004D2C44
		public static IDollGrabInfiniteStageConfig GetRootAsIDollGrabInfiniteStageConfig(ByteBuffer _bb)
		{
			return IDollGrabInfiniteStageConfig.GetRootAsIDollGrabInfiniteStageConfig(_bb, default(IDollGrabInfiniteStageConfig));
		}

		// Token: 0x0602317C RID: 143740 RVA: 0x004D4A60 File Offset: 0x004D2C60
		public static IDollGrabInfiniteStageConfig GetRootAsIDollGrabInfiniteStageConfig(ByteBuffer _bb, IDollGrabInfiniteStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602317D RID: 143741 RVA: 0x004D4A7D File Offset: 0x004D2C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602317E RID: 143742 RVA: 0x004D4A8C File Offset: 0x004D2C8C
		public IDollGrabInfiniteStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009DD5 RID: 40405
		// (get) Token: 0x0602317F RID: 143743 RVA: 0x004D4A9C File Offset: 0x004D2C9C
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009DD6 RID: 40406
		// (get) Token: 0x06023180 RID: 143744 RVA: 0x004D4ADC File Offset: 0x004D2CDC
		public IDollGrabStageAudioState? AudioState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDollGrabStageAudioState?(default(IDollGrabStageAudioState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023181 RID: 143745 RVA: 0x004D4B39 File Offset: 0x004D2D39
		public static Offset<IDollGrabInfiniteStageConfig> CreateIDollGrabInfiniteStageConfig(FlatBufferBuilder builder, float Duration = 0f, Offset<IDollGrabStageAudioState> AudioStateOffset = default(Offset<IDollGrabStageAudioState>))
		{
			builder.StartTable(2);
			IDollGrabInfiniteStageConfig.AddAudioState(builder, AudioStateOffset);
			IDollGrabInfiniteStageConfig.AddDuration(builder, Duration);
			return IDollGrabInfiniteStageConfig.EndIDollGrabInfiniteStageConfig(builder);
		}

		// Token: 0x06023182 RID: 143746 RVA: 0x004D4B56 File Offset: 0x004D2D56
		public static void StartIDollGrabInfiniteStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023183 RID: 143747 RVA: 0x004D4B5F File Offset: 0x004D2D5F
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x06023184 RID: 143748 RVA: 0x004D4B72 File Offset: 0x004D2D72
		public static void AddAudioState(FlatBufferBuilder builder, Offset<IDollGrabStageAudioState> audioStateOffset)
		{
			builder.AddOffset(1, audioStateOffset.Value, 0);
		}

		// Token: 0x06023185 RID: 143749 RVA: 0x004D4B82 File Offset: 0x004D2D82
		public static Offset<IDollGrabInfiniteStageConfig> EndIDollGrabInfiniteStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteStageConfig>(builder.EndTable());
		}

		// Token: 0x06023186 RID: 143750 RVA: 0x004D4B90 File Offset: 0x004D2D90
		public IDollGrabInfiniteStageConfigT UnPack()
		{
			IDollGrabInfiniteStageConfigT dollGrabInfiniteStageConfigT = new IDollGrabInfiniteStageConfigT();
			this.UnPackTo(dollGrabInfiniteStageConfigT);
			return dollGrabInfiniteStageConfigT;
		}

		// Token: 0x06023187 RID: 143751 RVA: 0x004D4BAC File Offset: 0x004D2DAC
		public void UnPackTo(IDollGrabInfiniteStageConfigT _o)
		{
			_o.Duration = this.Duration;
			_o.AudioState = ((this.AudioState != null) ? this.AudioState.Value.UnPack() : null);
		}

		// Token: 0x06023188 RID: 143752 RVA: 0x004D4BF4 File Offset: 0x004D2DF4
		public static Offset<IDollGrabInfiniteStageConfig> Pack(FlatBufferBuilder builder, IDollGrabInfiniteStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabInfiniteStageConfig>);
			}
			Offset<IDollGrabStageAudioState> audioStateOffset = (_o.AudioState == null) ? default(Offset<IDollGrabStageAudioState>) : IDollGrabStageAudioState.Pack(builder, _o.AudioState);
			return IDollGrabInfiniteStageConfig.CreateIDollGrabInfiniteStageConfig(builder, _o.Duration, audioStateOffset);
		}

		// Token: 0x0400ECB7 RID: 60599
		private Table __p;
	}
}
