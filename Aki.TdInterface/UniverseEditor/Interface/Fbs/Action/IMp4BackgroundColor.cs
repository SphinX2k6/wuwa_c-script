using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7A RID: 27514
	public struct IMp4BackgroundColor : IFlatbufferObject
	{
		// Token: 0x1700CC81 RID: 52353
		// (get) Token: 0x06030509 RID: 197897 RVA: 0x00690876 File Offset: 0x0068EA76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603050A RID: 197898 RVA: 0x00690883 File Offset: 0x0068EA83
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0603050B RID: 197899 RVA: 0x00690892 File Offset: 0x0068EA92
		public IMp4BackgroundColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC82 RID: 52354
		// (get) Token: 0x0603050C RID: 197900 RVA: 0x006908A2 File Offset: 0x0068EAA2
		public EMp4BackgroundColor FadeIn
		{
			get
			{
				return (EMp4BackgroundColor)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC83 RID: 52355
		// (get) Token: 0x0603050D RID: 197901 RVA: 0x006908BF File Offset: 0x0068EABF
		public EMp4BackgroundColor FadeOut
		{
			get
			{
				return (EMp4BackgroundColor)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x0603050E RID: 197902 RVA: 0x006908DE File Offset: 0x0068EADE
		public static Offset<IMp4BackgroundColor> CreateIMp4BackgroundColor(FlatBufferBuilder builder, EMp4BackgroundColor FadeIn, EMp4BackgroundColor FadeOut)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)FadeOut);
			builder.PutByte((byte)FadeIn);
			return new Offset<IMp4BackgroundColor>(builder.Offset);
		}

		// Token: 0x0603050F RID: 197903 RVA: 0x00690904 File Offset: 0x0068EB04
		public IMp4BackgroundColorT UnPack()
		{
			IMp4BackgroundColorT mp4BackgroundColorT = new IMp4BackgroundColorT();
			this.UnPackTo(mp4BackgroundColorT);
			return mp4BackgroundColorT;
		}

		// Token: 0x06030510 RID: 197904 RVA: 0x0069091F File Offset: 0x0068EB1F
		public void UnPackTo(IMp4BackgroundColorT _o)
		{
			_o.FadeIn = this.FadeIn;
			_o.FadeOut = this.FadeOut;
		}

		// Token: 0x06030511 RID: 197905 RVA: 0x0069093C File Offset: 0x0068EB3C
		public static Offset<IMp4BackgroundColor> Pack(FlatBufferBuilder builder, IMp4BackgroundColorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4BackgroundColor>);
			}
			return IMp4BackgroundColor.CreateIMp4BackgroundColor(builder, _o.FadeIn, _o.FadeOut);
		}

		// Token: 0x04011434 RID: 70708
		private Struct __p;
	}
}
