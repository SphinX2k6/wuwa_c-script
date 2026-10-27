using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB0 RID: 23472
	public struct IWuWaGoGridLinkData : IFlatbufferObject
	{
		// Token: 0x1700B15E RID: 45406
		// (get) Token: 0x06028329 RID: 164649 RVA: 0x0058626F File Offset: 0x0058446F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602832A RID: 164650 RVA: 0x0058627C File Offset: 0x0058447C
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602832B RID: 164651 RVA: 0x0058628B File Offset: 0x0058448B
		public IWuWaGoGridLinkData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B15F RID: 45407
		// (get) Token: 0x0602832C RID: 164652 RVA: 0x0058629B File Offset: 0x0058449B
		public EWuWaGoGridLinkType GridLinkType
		{
			get
			{
				return (EWuWaGoGridLinkType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700B160 RID: 45408
		// (get) Token: 0x0602832D RID: 164653 RVA: 0x005862B8 File Offset: 0x005844B8
		public EWuWaGoGridRotationType RotationType
		{
			get
			{
				return (EWuWaGoGridRotationType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x0602832E RID: 164654 RVA: 0x005862D7 File Offset: 0x005844D7
		public static Offset<IWuWaGoGridLinkData> CreateIWuWaGoGridLinkData(FlatBufferBuilder builder, EWuWaGoGridLinkType GridLinkType, EWuWaGoGridRotationType RotationType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)RotationType);
			builder.PutByte((byte)GridLinkType);
			return new Offset<IWuWaGoGridLinkData>(builder.Offset);
		}

		// Token: 0x0602832F RID: 164655 RVA: 0x005862FC File Offset: 0x005844FC
		public IWuWaGoGridLinkDataT UnPack()
		{
			IWuWaGoGridLinkDataT wuWaGoGridLinkDataT = new IWuWaGoGridLinkDataT();
			this.UnPackTo(wuWaGoGridLinkDataT);
			return wuWaGoGridLinkDataT;
		}

		// Token: 0x06028330 RID: 164656 RVA: 0x00586317 File Offset: 0x00584517
		public void UnPackTo(IWuWaGoGridLinkDataT _o)
		{
			_o.GridLinkType = this.GridLinkType;
			_o.RotationType = this.RotationType;
		}

		// Token: 0x06028331 RID: 164657 RVA: 0x00586334 File Offset: 0x00584534
		public static Offset<IWuWaGoGridLinkData> Pack(FlatBufferBuilder builder, IWuWaGoGridLinkDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoGridLinkData>);
			}
			return IWuWaGoGridLinkData.CreateIWuWaGoGridLinkData(builder, _o.GridLinkType, _o.RotationType);
		}

		// Token: 0x0400F325 RID: 62245
		private Struct __p;
	}
}
