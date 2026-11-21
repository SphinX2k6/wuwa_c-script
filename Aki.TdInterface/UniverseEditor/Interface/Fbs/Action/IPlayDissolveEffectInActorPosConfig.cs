using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007454 RID: 29780
	public struct IPlayDissolveEffectInActorPosConfig : IFlatbufferObject
	{
		// Token: 0x1700DADE RID: 56030
		// (get) Token: 0x06034223 RID: 213539 RVA: 0x00706484 File Offset: 0x00704684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034224 RID: 213540 RVA: 0x00706491 File Offset: 0x00704691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x06034225 RID: 213541 RVA: 0x007064A0 File Offset: 0x007046A0
		public IPlayDissolveEffectInActorPosConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DADF RID: 56031
		// (get) Token: 0x06034226 RID: 213542 RVA: 0x007064B0 File Offset: 0x007046B0
		public EAspectRatio AspectRatio
		{
			get
			{
				return (EAspectRatio)this.__p.bb.Get(this.__p.bb_pos);
			}
		}

		// Token: 0x06034227 RID: 213543 RVA: 0x007064CD File Offset: 0x007046CD
		public static Offset<IPlayDissolveEffectInActorPosConfig> CreateIPlayDissolveEffectInActorPosConfig(FlatBufferBuilder builder, EAspectRatio AspectRatio)
		{
			builder.Prep(1, 1);
			builder.PutByte((byte)AspectRatio);
			return new Offset<IPlayDissolveEffectInActorPosConfig>(builder.Offset);
		}

		// Token: 0x06034228 RID: 213544 RVA: 0x007064EC File Offset: 0x007046EC
		public IPlayDissolveEffectInActorPosConfigT UnPack()
		{
			IPlayDissolveEffectInActorPosConfigT playDissolveEffectInActorPosConfigT = new IPlayDissolveEffectInActorPosConfigT();
			this.UnPackTo(playDissolveEffectInActorPosConfigT);
			return playDissolveEffectInActorPosConfigT;
		}

		// Token: 0x06034229 RID: 213545 RVA: 0x00706507 File Offset: 0x00704707
		public void UnPackTo(IPlayDissolveEffectInActorPosConfigT _o)
		{
			_o.AspectRatio = this.AspectRatio;
		}

		// Token: 0x0603422A RID: 213546 RVA: 0x00706518 File Offset: 0x00704718
		public static Offset<IPlayDissolveEffectInActorPosConfig> Pack(FlatBufferBuilder builder, IPlayDissolveEffectInActorPosConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayDissolveEffectInActorPosConfig>);
			}
			return IPlayDissolveEffectInActorPosConfig.CreateIPlayDissolveEffectInActorPosConfig(builder, _o.AspectRatio);
		}

		// Token: 0x040125C8 RID: 75208
		private Struct __p;
	}
}
