using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200509C RID: 20636
	public struct IDollGrabInfiniteStageConfig : IFlatbufferObject
	{
		// Token: 0x170095E7 RID: 38375
		// (get) Token: 0x06021225 RID: 135717 RVA: 0x0049AAA2 File Offset: 0x00498CA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021226 RID: 135718 RVA: 0x0049AAAF File Offset: 0x00498CAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021227 RID: 135719 RVA: 0x0049AAB8 File Offset: 0x00498CB8
		public static IDollGrabInfiniteStageConfig GetRootAsIDollGrabInfiniteStageConfig(ByteBuffer _bb)
		{
			return IDollGrabInfiniteStageConfig.GetRootAsIDollGrabInfiniteStageConfig(_bb, default(IDollGrabInfiniteStageConfig));
		}

		// Token: 0x06021228 RID: 135720 RVA: 0x0049AAD4 File Offset: 0x00498CD4
		public static IDollGrabInfiniteStageConfig GetRootAsIDollGrabInfiniteStageConfig(ByteBuffer _bb, IDollGrabInfiniteStageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021229 RID: 135721 RVA: 0x0049AAF1 File Offset: 0x00498CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602122A RID: 135722 RVA: 0x0049AB00 File Offset: 0x00498D00
		public IDollGrabInfiniteStageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095E8 RID: 38376
		// (get) Token: 0x0602122B RID: 135723 RVA: 0x0049AB10 File Offset: 0x00498D10
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

		// Token: 0x170095E9 RID: 38377
		// (get) Token: 0x0602122C RID: 135724 RVA: 0x0049AB50 File Offset: 0x00498D50
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

		// Token: 0x0602122D RID: 135725 RVA: 0x0049ABAD File Offset: 0x00498DAD
		public static Offset<IDollGrabInfiniteStageConfig> CreateIDollGrabInfiniteStageConfig(FlatBufferBuilder builder, float Duration = 0f, Offset<IDollGrabStageAudioState> AudioStateOffset = default(Offset<IDollGrabStageAudioState>))
		{
			builder.StartTable(2);
			IDollGrabInfiniteStageConfig.AddAudioState(builder, AudioStateOffset);
			IDollGrabInfiniteStageConfig.AddDuration(builder, Duration);
			return IDollGrabInfiniteStageConfig.EndIDollGrabInfiniteStageConfig(builder);
		}

		// Token: 0x0602122E RID: 135726 RVA: 0x0049ABCA File Offset: 0x00498DCA
		public static void StartIDollGrabInfiniteStageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602122F RID: 135727 RVA: 0x0049ABD3 File Offset: 0x00498DD3
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(0, duration, 0.0);
		}

		// Token: 0x06021230 RID: 135728 RVA: 0x0049ABE6 File Offset: 0x00498DE6
		public static void AddAudioState(FlatBufferBuilder builder, Offset<IDollGrabStageAudioState> audioStateOffset)
		{
			builder.AddOffset(1, audioStateOffset.Value, 0);
		}

		// Token: 0x06021231 RID: 135729 RVA: 0x0049ABF6 File Offset: 0x00498DF6
		public static Offset<IDollGrabInfiniteStageConfig> EndIDollGrabInfiniteStageConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDollGrabInfiniteStageConfig>(builder.EndTable());
		}

		// Token: 0x06021232 RID: 135730 RVA: 0x0049AC04 File Offset: 0x00498E04
		public IDollGrabInfiniteStageConfigT UnPack()
		{
			IDollGrabInfiniteStageConfigT dollGrabInfiniteStageConfigT = new IDollGrabInfiniteStageConfigT();
			this.UnPackTo(dollGrabInfiniteStageConfigT);
			return dollGrabInfiniteStageConfigT;
		}

		// Token: 0x06021233 RID: 135731 RVA: 0x0049AC20 File Offset: 0x00498E20
		public void UnPackTo(IDollGrabInfiniteStageConfigT _o)
		{
			_o.Duration = this.Duration;
			_o.AudioState = ((this.AudioState != null) ? this.AudioState.Value.UnPack() : null);
		}

		// Token: 0x06021234 RID: 135732 RVA: 0x0049AC68 File Offset: 0x00498E68
		public static Offset<IDollGrabInfiniteStageConfig> Pack(FlatBufferBuilder builder, IDollGrabInfiniteStageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDollGrabInfiniteStageConfig>);
			}
			Offset<IDollGrabStageAudioState> audioStateOffset = (_o.AudioState == null) ? default(Offset<IDollGrabStageAudioState>) : IDollGrabStageAudioState.Pack(builder, _o.AudioState);
			return IDollGrabInfiniteStageConfig.CreateIDollGrabInfiniteStageConfig(builder, _o.Duration, audioStateOffset);
		}

		// Token: 0x0400E0BA RID: 57530
		private Table __p;
	}
}
