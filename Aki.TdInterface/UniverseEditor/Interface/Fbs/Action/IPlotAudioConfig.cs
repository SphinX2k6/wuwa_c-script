using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4D RID: 27981
	public struct IPlotAudioConfig : IFlatbufferObject
	{
		// Token: 0x1700D0B6 RID: 53430
		// (get) Token: 0x06031689 RID: 202377 RVA: 0x006B3437 File Offset: 0x006B1637
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603168A RID: 202378 RVA: 0x006B3444 File Offset: 0x006B1644
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603168B RID: 202379 RVA: 0x006B344C File Offset: 0x006B164C
		public static IPlotAudioConfig GetRootAsIPlotAudioConfig(ByteBuffer _bb)
		{
			return IPlotAudioConfig.GetRootAsIPlotAudioConfig(_bb, default(IPlotAudioConfig));
		}

		// Token: 0x0603168C RID: 202380 RVA: 0x006B3468 File Offset: 0x006B1668
		public static IPlotAudioConfig GetRootAsIPlotAudioConfig(ByteBuffer _bb, IPlotAudioConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603168D RID: 202381 RVA: 0x006B3485 File Offset: 0x006B1685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603168E RID: 202382 RVA: 0x006B3494 File Offset: 0x006B1694
		public IPlotAudioConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0B7 RID: 53431
		// (get) Token: 0x0603168F RID: 202383 RVA: 0x006B34A4 File Offset: 0x006B16A4
		public IPlotVoiceFadeOutOnInterrupt? VoiceFadeOutOnInterrupt
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPlotVoiceFadeOutOnInterrupt?(default(IPlotVoiceFadeOutOnInterrupt).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031690 RID: 202384 RVA: 0x006B3501 File Offset: 0x006B1701
		public static Offset<IPlotAudioConfig> CreateIPlotAudioConfig(FlatBufferBuilder builder, Offset<IPlotVoiceFadeOutOnInterrupt> VoiceFadeOutOnInterruptOffset = default(Offset<IPlotVoiceFadeOutOnInterrupt>))
		{
			builder.StartTable(1);
			IPlotAudioConfig.AddVoiceFadeOutOnInterrupt(builder, VoiceFadeOutOnInterruptOffset);
			return IPlotAudioConfig.EndIPlotAudioConfig(builder);
		}

		// Token: 0x06031691 RID: 202385 RVA: 0x006B3517 File Offset: 0x006B1717
		public static void StartIPlotAudioConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031692 RID: 202386 RVA: 0x006B3520 File Offset: 0x006B1720
		public static void AddVoiceFadeOutOnInterrupt(FlatBufferBuilder builder, Offset<IPlotVoiceFadeOutOnInterrupt> voiceFadeOutOnInterruptOffset)
		{
			builder.AddOffset(0, voiceFadeOutOnInterruptOffset.Value, 0);
		}

		// Token: 0x06031693 RID: 202387 RVA: 0x006B3530 File Offset: 0x006B1730
		public static Offset<IPlotAudioConfig> EndIPlotAudioConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlotAudioConfig>(builder.EndTable());
		}

		// Token: 0x06031694 RID: 202388 RVA: 0x006B3540 File Offset: 0x006B1740
		public IPlotAudioConfigT UnPack()
		{
			IPlotAudioConfigT plotAudioConfigT = new IPlotAudioConfigT();
			this.UnPackTo(plotAudioConfigT);
			return plotAudioConfigT;
		}

		// Token: 0x06031695 RID: 202389 RVA: 0x006B355C File Offset: 0x006B175C
		public void UnPackTo(IPlotAudioConfigT _o)
		{
			_o.VoiceFadeOutOnInterrupt = ((this.VoiceFadeOutOnInterrupt != null) ? this.VoiceFadeOutOnInterrupt.Value.UnPack() : null);
		}

		// Token: 0x06031696 RID: 202390 RVA: 0x006B3598 File Offset: 0x006B1798
		public static Offset<IPlotAudioConfig> Pack(FlatBufferBuilder builder, IPlotAudioConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotAudioConfig>);
			}
			Offset<IPlotVoiceFadeOutOnInterrupt> voiceFadeOutOnInterruptOffset = (_o.VoiceFadeOutOnInterrupt == null) ? default(Offset<IPlotVoiceFadeOutOnInterrupt>) : IPlotVoiceFadeOutOnInterrupt.Pack(builder, _o.VoiceFadeOutOnInterrupt);
			return IPlotAudioConfig.CreateIPlotAudioConfig(builder, voiceFadeOutOnInterruptOffset);
		}

		// Token: 0x04011702 RID: 71426
		private Table __p;
	}
}
