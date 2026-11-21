using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072B2 RID: 29362
	public struct IMovieBackgroundFadeData : IFlatbufferObject
	{
		// Token: 0x1700D74D RID: 55117
		// (get) Token: 0x060332F7 RID: 209655 RVA: 0x006E8335 File Offset: 0x006E6535
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060332F8 RID: 209656 RVA: 0x006E8342 File Offset: 0x006E6542
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060332F9 RID: 209657 RVA: 0x006E8351 File Offset: 0x006E6551
		public IMovieBackgroundFadeData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D74E RID: 55118
		// (get) Token: 0x060332FA RID: 209658 RVA: 0x006E8361 File Offset: 0x006E6561
		public EMovieBackgroundType FadeInBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x1700D74F RID: 55119
		// (get) Token: 0x060332FB RID: 209659 RVA: 0x006E837E File Offset: 0x006E657E
		public EMovieBackgroundType FadeOutBackgroundType
		{
			get
			{
				return (EMovieBackgroundType)this.__p.bb.Get(this.__p.bb_pos + 1);
			}
		}

		// Token: 0x060332FC RID: 209660 RVA: 0x006E839D File Offset: 0x006E659D
		public static Offset<IMovieBackgroundFadeData> CreateIMovieBackgroundFadeData(FlatBufferBuilder builder, EMovieBackgroundType FadeInBackgroundType, EMovieBackgroundType FadeOutBackgroundType)
		{
			builder.Prep(1, 2);
			builder.PutByte((byte)FadeOutBackgroundType);
			builder.PutByte((byte)FadeInBackgroundType);
			return new Offset<IMovieBackgroundFadeData>(builder.Offset);
		}

		// Token: 0x060332FD RID: 209661 RVA: 0x006E83C0 File Offset: 0x006E65C0
		public IMovieBackgroundFadeDataT UnPack()
		{
			IMovieBackgroundFadeDataT movieBackgroundFadeDataT = new IMovieBackgroundFadeDataT();
			this.UnPackTo(movieBackgroundFadeDataT);
			return movieBackgroundFadeDataT;
		}

		// Token: 0x060332FE RID: 209662 RVA: 0x006E83DB File Offset: 0x006E65DB
		public void UnPackTo(IMovieBackgroundFadeDataT _o)
		{
			_o.FadeInBackgroundType = this.FadeInBackgroundType;
			_o.FadeOutBackgroundType = this.FadeOutBackgroundType;
		}

		// Token: 0x060332FF RID: 209663 RVA: 0x006E83F8 File Offset: 0x006E65F8
		public static Offset<IMovieBackgroundFadeData> Pack(FlatBufferBuilder builder, IMovieBackgroundFadeDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovieBackgroundFadeData>);
			}
			return IMovieBackgroundFadeData.CreateIMovieBackgroundFadeData(builder, _o.FadeInBackgroundType, _o.FadeOutBackgroundType);
		}

		// Token: 0x0401234E RID: 74574
		private Struct __p;
	}
}
