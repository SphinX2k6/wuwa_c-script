using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200609B RID: 24731
	public struct ITimeScaleConfig : IFlatbufferObject
	{
		// Token: 0x1700B7DB RID: 47067
		// (get) Token: 0x06029D59 RID: 171353 RVA: 0x005B61A5 File Offset: 0x005B43A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D5A RID: 171354 RVA: 0x005B61B2 File Offset: 0x005B43B2
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06029D5B RID: 171355 RVA: 0x005B61C1 File Offset: 0x005B43C1
		public ITimeScaleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7DC RID: 47068
		// (get) Token: 0x06029D5C RID: 171356 RVA: 0x005B61D1 File Offset: 0x005B43D1
		public bool IgnoreGlobalTimeScale
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06029D5D RID: 171357 RVA: 0x005B61F1 File Offset: 0x005B43F1
		public static Offset<ITimeScaleConfig> CreateITimeScaleConfig(FlatBufferBuilder builder, bool IgnoreGlobalTimeScale)
		{
			builder.Prep(1, 1);
			builder.PutBool(IgnoreGlobalTimeScale);
			return new Offset<ITimeScaleConfig>(builder.Offset);
		}

		// Token: 0x06029D5E RID: 171358 RVA: 0x005B6210 File Offset: 0x005B4410
		public ITimeScaleConfigT UnPack()
		{
			ITimeScaleConfigT timeScaleConfigT = new ITimeScaleConfigT();
			this.UnPackTo(timeScaleConfigT);
			return timeScaleConfigT;
		}

		// Token: 0x06029D5F RID: 171359 RVA: 0x005B622B File Offset: 0x005B442B
		public void UnPackTo(ITimeScaleConfigT _o)
		{
			_o.IgnoreGlobalTimeScale = this.IgnoreGlobalTimeScale;
		}

		// Token: 0x06029D60 RID: 171360 RVA: 0x005B623C File Offset: 0x005B443C
		public static Offset<ITimeScaleConfig> Pack(FlatBufferBuilder builder, ITimeScaleConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScaleConfig>);
			}
			return ITimeScaleConfig.CreateITimeScaleConfig(builder, _o.IgnoreGlobalTimeScale);
		}

		// Token: 0x0400FE41 RID: 65089
		private Struct __p;
	}
}
