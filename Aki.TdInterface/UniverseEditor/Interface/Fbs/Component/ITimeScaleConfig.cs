using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8E RID: 23182
	public struct ITimeScaleConfig : IFlatbufferObject
	{
		// Token: 0x1700AEA3 RID: 44707
		// (get) Token: 0x060277E1 RID: 161761 RVA: 0x0056F199 File Offset: 0x0056D399
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060277E2 RID: 161762 RVA: 0x0056F1A6 File Offset: 0x0056D3A6
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060277E3 RID: 161763 RVA: 0x0056F1B5 File Offset: 0x0056D3B5
		public ITimeScaleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEA4 RID: 44708
		// (get) Token: 0x060277E4 RID: 161764 RVA: 0x0056F1C5 File Offset: 0x0056D3C5
		public bool IgnoreGlobalTimeScale
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060277E5 RID: 161765 RVA: 0x0056F1E5 File Offset: 0x0056D3E5
		public static Offset<ITimeScaleConfig> CreateITimeScaleConfig(FlatBufferBuilder builder, bool IgnoreGlobalTimeScale)
		{
			builder.Prep(1, 1);
			builder.PutBool(IgnoreGlobalTimeScale);
			return new Offset<ITimeScaleConfig>(builder.Offset);
		}

		// Token: 0x060277E6 RID: 161766 RVA: 0x0056F204 File Offset: 0x0056D404
		public ITimeScaleConfigT UnPack()
		{
			ITimeScaleConfigT timeScaleConfigT = new ITimeScaleConfigT();
			this.UnPackTo(timeScaleConfigT);
			return timeScaleConfigT;
		}

		// Token: 0x060277E7 RID: 161767 RVA: 0x0056F21F File Offset: 0x0056D41F
		public void UnPackTo(ITimeScaleConfigT _o)
		{
			_o.IgnoreGlobalTimeScale = this.IgnoreGlobalTimeScale;
		}

		// Token: 0x060277E8 RID: 161768 RVA: 0x0056F230 File Offset: 0x0056D430
		public static Offset<ITimeScaleConfig> Pack(FlatBufferBuilder builder, ITimeScaleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScaleConfig>);
			}
			return ITimeScaleConfig.CreateITimeScaleConfig(builder, _o.IgnoreGlobalTimeScale);
		}

		// Token: 0x0400F14A RID: 61770
		private Struct __p;
	}
}
