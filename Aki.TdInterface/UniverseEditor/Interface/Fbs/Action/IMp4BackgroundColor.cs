using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072C0 RID: 29376
	public struct IMp4BackgroundColor : IFlatbufferObject
	{
		// Token: 0x1700D766 RID: 55142
		// (get) Token: 0x06033361 RID: 209761 RVA: 0x006E8E96 File Offset: 0x006E7096
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033362 RID: 209762 RVA: 0x006E8EA3 File Offset: 0x006E70A3
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06033363 RID: 209763 RVA: 0x006E8EB2 File Offset: 0x006E70B2
		public IMp4BackgroundColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D767 RID: 55143
		// (get) Token: 0x06033364 RID: 209764 RVA: 0x006E8EC2 File Offset: 0x006E70C2
		public EMp4BackgroundColor FadeIn
		{
			get
			{
				return (EMp4BackgroundColor)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700D768 RID: 55144
		// (get) Token: 0x06033365 RID: 209765 RVA: 0x006E8EDF File Offset: 0x006E70DF
		public EMp4BackgroundColor FadeOut
		{
			get
			{
				return (EMp4BackgroundColor)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x06033366 RID: 209766 RVA: 0x006E8EFE File Offset: 0x006E70FE
		public static Offset<IMp4BackgroundColor> CreateIMp4BackgroundColor(FlatBufferBuilder builder, EMp4BackgroundColor FadeIn, EMp4BackgroundColor FadeOut)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)FadeOut);
			builder.PutByte((byte)FadeIn);
			return new Offset<IMp4BackgroundColor>(builder.Offset);
		}

		// Token: 0x06033367 RID: 209767 RVA: 0x006E8F24 File Offset: 0x006E7124
		public IMp4BackgroundColorT UnPack()
		{
			IMp4BackgroundColorT mp4BackgroundColorT = new IMp4BackgroundColorT();
			this.UnPackTo(mp4BackgroundColorT);
			return mp4BackgroundColorT;
		}

		// Token: 0x06033368 RID: 209768 RVA: 0x006E8F3F File Offset: 0x006E713F
		public void UnPackTo(IMp4BackgroundColorT _o)
		{
			_o.FadeIn = this.FadeIn;
			_o.FadeOut = this.FadeOut;
		}

		// Token: 0x06033369 RID: 209769 RVA: 0x006E8F5C File Offset: 0x006E715C
		public static Offset<IMp4BackgroundColor> Pack(FlatBufferBuilder builder, IMp4BackgroundColorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4BackgroundColor>);
			}
			return IMp4BackgroundColor.CreateIMp4BackgroundColor(builder, _o.FadeIn, _o.FadeOut);
		}

		// Token: 0x0401235D RID: 74589
		private Struct __p;
	}
}
