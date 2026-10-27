using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1A RID: 27930
	public struct IPlayGuestUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700CFF6 RID: 53238
		// (get) Token: 0x06031404 RID: 201732 RVA: 0x006AE015 File Offset: 0x006AC215
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031405 RID: 201733 RVA: 0x006AE022 File Offset: 0x006AC222
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031406 RID: 201734 RVA: 0x006AE02C File Offset: 0x006AC22C
		public static IPlayGuestUiAnimation GetRootAsIPlayGuestUiAnimation(ByteBuffer _bb)
		{
			return IPlayGuestUiAnimation.GetRootAsIPlayGuestUiAnimation(_bb, default(IPlayGuestUiAnimation));
		}

		// Token: 0x06031407 RID: 201735 RVA: 0x006AE048 File Offset: 0x006AC248
		public static IPlayGuestUiAnimation GetRootAsIPlayGuestUiAnimation(ByteBuffer _bb, IPlayGuestUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031408 RID: 201736 RVA: 0x006AE065 File Offset: 0x006AC265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031409 RID: 201737 RVA: 0x006AE074 File Offset: 0x006AC274
		public IPlayGuestUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFF7 RID: 53239
		// (get) Token: 0x0603140A RID: 201738 RVA: 0x006AE084 File Offset: 0x006AC284
		public EGuestOperateUiAnimation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestOperateUiAnimation.Play;
				}
				return (EGuestOperateUiAnimation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFF8 RID: 53240
		// (get) Token: 0x0603140B RID: 201739 RVA: 0x006AE0C0 File Offset: 0x006AC2C0
		public IPlayGuestCartethyia? PlayGuestUiAnimation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayGuestCartethyia?(default(IPlayGuestCartethyia).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0603140C RID: 201740 RVA: 0x006AE11D File Offset: 0x006AC31D
		public static Offset<IPlayGuestUiAnimation> CreateIPlayGuestUiAnimation(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play, Offset<IPlayGuestCartethyia> PlayGuestUiAnimationOffset = default(Offset<IPlayGuestCartethyia>))
		{
			builder.StartTable(2);
			IPlayGuestUiAnimation.AddPlayGuestUiAnimation(builder, PlayGuestUiAnimationOffset);
			IPlayGuestUiAnimation.AddType(builder, Type);
			return IPlayGuestUiAnimation.EndIPlayGuestUiAnimation(builder);
		}

		// Token: 0x0603140D RID: 201741 RVA: 0x006AE13A File Offset: 0x006AC33A
		public static void StartIPlayGuestUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603140E RID: 201742 RVA: 0x006AE143 File Offset: 0x006AC343
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603140F RID: 201743 RVA: 0x006AE14E File Offset: 0x006AC34E
		public static void AddPlayGuestUiAnimation(FlatBufferBuilder builder, Offset<IPlayGuestCartethyia> playGuestUiAnimationOffset)
		{
			builder.AddOffset(1, playGuestUiAnimationOffset.Value, 0);
		}

		// Token: 0x06031410 RID: 201744 RVA: 0x006AE15E File Offset: 0x006AC35E
		public static Offset<IPlayGuestUiAnimation> EndIPlayGuestUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestUiAnimation>(builder.EndTable());
		}

		// Token: 0x06031411 RID: 201745 RVA: 0x006AE16C File Offset: 0x006AC36C
		public IPlayGuestUiAnimationT UnPack()
		{
			IPlayGuestUiAnimationT playGuestUiAnimationT = new IPlayGuestUiAnimationT();
			this.UnPackTo(playGuestUiAnimationT);
			return playGuestUiAnimationT;
		}

		// Token: 0x06031412 RID: 201746 RVA: 0x006AE188 File Offset: 0x006AC388
		public void UnPackTo(IPlayGuestUiAnimationT _o)
		{
			_o.Type = this.Type;
			_o.PlayGuestUiAnimation = ((this.PlayGuestUiAnimation != null) ? this.PlayGuestUiAnimation.Value.UnPack() : null);
		}

		// Token: 0x06031413 RID: 201747 RVA: 0x006AE1D0 File Offset: 0x006AC3D0
		public static Offset<IPlayGuestUiAnimation> Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestUiAnimation>);
			}
			Offset<IPlayGuestCartethyia> playGuestUiAnimationOffset = (_o.PlayGuestUiAnimation == null) ? default(Offset<IPlayGuestCartethyia>) : IPlayGuestCartethyia.Pack(builder, _o.PlayGuestUiAnimation);
			return IPlayGuestUiAnimation.CreateIPlayGuestUiAnimation(builder, _o.Type, playGuestUiAnimationOffset);
		}

		// Token: 0x04011695 RID: 71317
		private Table __p;
	}
}
