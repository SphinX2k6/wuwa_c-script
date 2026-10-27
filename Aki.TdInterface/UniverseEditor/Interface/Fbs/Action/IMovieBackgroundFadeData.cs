using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6C RID: 27500
	public struct IMovieBackgroundFadeData : IFlatbufferObject
	{
		// Token: 0x1700CC68 RID: 52328
		// (get) Token: 0x0603049F RID: 197791 RVA: 0x0068FD15 File Offset: 0x0068DF15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304A0 RID: 197792 RVA: 0x0068FD22 File Offset: 0x0068DF22
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060304A1 RID: 197793 RVA: 0x0068FD31 File Offset: 0x0068DF31
		public IMovieBackgroundFadeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC69 RID: 52329
		// (get) Token: 0x060304A2 RID: 197794 RVA: 0x0068FD41 File Offset: 0x0068DF41
		public EMovieBackgroundType FadeInBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC6A RID: 52330
		// (get) Token: 0x060304A3 RID: 197795 RVA: 0x0068FD5E File Offset: 0x0068DF5E
		public EMovieBackgroundType FadeOutBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x060304A4 RID: 197796 RVA: 0x0068FD7D File Offset: 0x0068DF7D
		public static Offset<IMovieBackgroundFadeData> CreateIMovieBackgroundFadeData(FlatBufferBuilder builder, EMovieBackgroundType FadeInBackgroundType, EMovieBackgroundType FadeOutBackgroundType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)FadeOutBackgroundType);
			builder.PutByte((byte)FadeInBackgroundType);
			return new Offset<IMovieBackgroundFadeData>(builder.Offset);
		}

		// Token: 0x060304A5 RID: 197797 RVA: 0x0068FDA0 File Offset: 0x0068DFA0
		public IMovieBackgroundFadeDataT UnPack()
		{
			IMovieBackgroundFadeDataT movieBackgroundFadeDataT = new IMovieBackgroundFadeDataT();
			this.UnPackTo(movieBackgroundFadeDataT);
			return movieBackgroundFadeDataT;
		}

		// Token: 0x060304A6 RID: 197798 RVA: 0x0068FDBB File Offset: 0x0068DFBB
		public void UnPackTo(IMovieBackgroundFadeDataT _o)
		{
			_o.FadeInBackgroundType = this.FadeInBackgroundType;
			_o.FadeOutBackgroundType = this.FadeOutBackgroundType;
		}

		// Token: 0x060304A7 RID: 197799 RVA: 0x0068FDD8 File Offset: 0x0068DFD8
		public static Offset<IMovieBackgroundFadeData> Pack(FlatBufferBuilder builder, IMovieBackgroundFadeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovieBackgroundFadeData>);
			}
			return IMovieBackgroundFadeData.CreateIMovieBackgroundFadeData(builder, _o.FadeInBackgroundType, _o.FadeOutBackgroundType);
		}

		// Token: 0x04011425 RID: 70693
		private Struct __p;
	}
}
