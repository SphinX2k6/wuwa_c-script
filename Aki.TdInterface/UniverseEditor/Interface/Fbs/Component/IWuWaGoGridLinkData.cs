using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061C6 RID: 25030
	public struct IWuWaGoGridLinkData : IFlatbufferObject
	{
		// Token: 0x1700BAA6 RID: 47782
		// (get) Token: 0x0602A8ED RID: 174317 RVA: 0x005CDCFF File Offset: 0x005CBEFF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A8EE RID: 174318 RVA: 0x005CDD0C File Offset: 0x005CBF0C
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602A8EF RID: 174319 RVA: 0x005CDD1B File Offset: 0x005CBF1B
		public IWuWaGoGridLinkData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAA7 RID: 47783
		// (get) Token: 0x0602A8F0 RID: 174320 RVA: 0x005CDD2B File Offset: 0x005CBF2B
		public EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				return (EWuWaGoGridLinkType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700BAA8 RID: 47784
		// (get) Token: 0x0602A8F1 RID: 174321 RVA: 0x005CDD48 File Offset: 0x005CBF48
		public EWuWaGoGridRotationType RotationType
		{
			get
			{
				return (EWuWaGoGridRotationType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x0602A8F2 RID: 174322 RVA: 0x005CDD67 File Offset: 0x005CBF67
		public static Offset<IWuWaGoGridLinkData> CreateIWuWaGoGridLinkData(FlatBufferBuilder builder, EWuWaGoGridLinkType GridLinkType, EWuWaGoGridRotationType RotationType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)RotationType);
			builder.PutByte((byte)GridLinkType);
			return new Offset<IWuWaGoGridLinkData>(builder.Offset);
		}

		// Token: 0x0602A8F3 RID: 174323 RVA: 0x005CDD8C File Offset: 0x005CBF8C
		public IWuWaGoGridLinkDataT UnPack()
		{
			IWuWaGoGridLinkDataT wuWaGoGridLinkDataT = new IWuWaGoGridLinkDataT();
			this.UnPackTo(wuWaGoGridLinkDataT);
			return wuWaGoGridLinkDataT;
		}

		// Token: 0x0602A8F4 RID: 174324 RVA: 0x005CDDA7 File Offset: 0x005CBFA7
		public void UnPackTo(IWuWaGoGridLinkDataT _o)
		{
			_o.GridLinkType = this.GridLinkType;
			_o.RotationType = this.RotationType;
		}

		// Token: 0x0602A8F5 RID: 174325 RVA: 0x005CDDC4 File Offset: 0x005CBFC4
		public static Offset<IWuWaGoGridLinkData> Pack(FlatBufferBuilder builder, IWuWaGoGridLinkDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGridLinkData>);
			}
			return IWuWaGoGridLinkData.CreateIWuWaGoGridLinkData(builder, _o.GridLinkType, _o.RotationType);
		}

		// Token: 0x0401002B RID: 65579
		private Struct __p;
	}
}
