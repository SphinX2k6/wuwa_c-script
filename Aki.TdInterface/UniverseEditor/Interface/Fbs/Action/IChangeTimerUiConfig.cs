using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006335 RID: 25397
	public struct IChangeTimerUiConfig : IFlatbufferObject
	{
		// Token: 0x1700BD8B RID: 48523
		// (get) Token: 0x0602BEE2 RID: 179938 RVA: 0x00609DFE File Offset: 0x00607FFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEE3 RID: 179939 RVA: 0x00609E0B File Offset: 0x0060800B
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602BEE4 RID: 179940 RVA: 0x00609E1A File Offset: 0x0060801A
		public IChangeTimerUiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD8C RID: 48524
		// (get) Token: 0x0602BEE5 RID: 179941 RVA: 0x00609E2A File Offset: 0x0060802A
		public EChangeTimerUiType UiType
		{
			get
			{
				return (EChangeTimerUiType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x0602BEE6 RID: 179942 RVA: 0x00609E47 File Offset: 0x00608047
		public static Offset<IChangeTimerUiConfig> CreateIChangeTimerUiConfig(FlatBufferBuilder builder, EChangeTimerUiType UiType)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)UiType);
			return new Offset<IChangeTimerUiConfig>(builder.Offset);
		}

		// Token: 0x0602BEE7 RID: 179943 RVA: 0x00609E64 File Offset: 0x00608064
		public IChangeTimerUiConfigT UnPack()
		{
			IChangeTimerUiConfigT changeTimerUiConfigT = new IChangeTimerUiConfigT();
			this.UnPackTo(changeTimerUiConfigT);
			return changeTimerUiConfigT;
		}

		// Token: 0x0602BEE8 RID: 179944 RVA: 0x00609E7F File Offset: 0x0060807F
		public void UnPackTo(IChangeTimerUiConfigT _o)
		{
			_o.UiType = this.UiType;
		}

		// Token: 0x0602BEE9 RID: 179945 RVA: 0x00609E90 File Offset: 0x00608090
		public static Offset<IChangeTimerUiConfig> Pack(FlatBufferBuilder builder, IChangeTimerUiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTimerUiConfig>);
			}
			return IChangeTimerUiConfig.CreateIChangeTimerUiConfig(builder, _o.UiType);
		}

		// Token: 0x040108FC RID: 67836
		private Struct __p;
	}
}
