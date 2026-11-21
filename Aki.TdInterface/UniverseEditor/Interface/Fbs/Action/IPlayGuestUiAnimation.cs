using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007495 RID: 29845
	public struct IPlayGuestUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700DB3C RID: 56124
		// (get) Token: 0x060343FC RID: 214012 RVA: 0x00709659 File Offset: 0x00707859
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060343FD RID: 214013 RVA: 0x00709666 File Offset: 0x00707866
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060343FE RID: 214014 RVA: 0x00709670 File Offset: 0x00707870
		public static IPlayGuestUiAnimation GetRootAsIPlayGuestUiAnimation(ByteBuffer _bb)
		{
			return IPlayGuestUiAnimation.GetRootAsIPlayGuestUiAnimation(_bb, default(IPlayGuestUiAnimation));
		}

		// Token: 0x060343FF RID: 214015 RVA: 0x0070968C File Offset: 0x0070788C
		public static IPlayGuestUiAnimation GetRootAsIPlayGuestUiAnimation(ByteBuffer _bb, IPlayGuestUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034400 RID: 214016 RVA: 0x007096A9 File Offset: 0x007078A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034401 RID: 214017 RVA: 0x007096B8 File Offset: 0x007078B8
		public IPlayGuestUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB3D RID: 56125
		// (get) Token: 0x06034402 RID: 214018 RVA: 0x007096C8 File Offset: 0x007078C8
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

		// Token: 0x1700DB3E RID: 56126
		// (get) Token: 0x06034403 RID: 214019 RVA: 0x00709704 File Offset: 0x00707904
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

		// Token: 0x06034404 RID: 214020 RVA: 0x00709761 File Offset: 0x00707961
		public static Offset<IPlayGuestUiAnimation> CreateIPlayGuestUiAnimation(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play, Offset<IPlayGuestCartethyia> PlayGuestUiAnimationOffset = default(Offset<IPlayGuestCartethyia>))
		{
			builder.StartTable(2);
			IPlayGuestUiAnimation.AddPlayGuestUiAnimation(builder, PlayGuestUiAnimationOffset);
			IPlayGuestUiAnimation.AddType(builder, Type);
			return IPlayGuestUiAnimation.EndIPlayGuestUiAnimation(builder);
		}

		// Token: 0x06034405 RID: 214021 RVA: 0x0070977E File Offset: 0x0070797E
		public static void StartIPlayGuestUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034406 RID: 214022 RVA: 0x00709787 File Offset: 0x00707987
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034407 RID: 214023 RVA: 0x00709792 File Offset: 0x00707992
		public static void AddPlayGuestUiAnimation(FlatBufferBuilder builder, Offset<IPlayGuestCartethyia> playGuestUiAnimationOffset)
		{
			builder.AddOffset(1, playGuestUiAnimationOffset.Value, 0);
		}

		// Token: 0x06034408 RID: 214024 RVA: 0x007097A2 File Offset: 0x007079A2
		public static Offset<IPlayGuestUiAnimation> EndIPlayGuestUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestUiAnimation>(builder.EndTable());
		}

		// Token: 0x06034409 RID: 214025 RVA: 0x007097B0 File Offset: 0x007079B0
		public IPlayGuestUiAnimationT UnPack()
		{
			IPlayGuestUiAnimationT playGuestUiAnimationT = new IPlayGuestUiAnimationT();
			this.UnPackTo(playGuestUiAnimationT);
			return playGuestUiAnimationT;
		}

		// Token: 0x0603440A RID: 214026 RVA: 0x007097CC File Offset: 0x007079CC
		public void UnPackTo(IPlayGuestUiAnimationT _o)
		{
			_o.Type = this.Type;
			_o.PlayGuestUiAnimation = ((this.PlayGuestUiAnimation != null) ? this.PlayGuestUiAnimation.Value.UnPack() : null);
		}

		// Token: 0x0603440B RID: 214027 RVA: 0x00709814 File Offset: 0x00707A14
		public static Offset<IPlayGuestUiAnimation> Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestUiAnimation>);
			}
			Offset<IPlayGuestCartethyia> playGuestUiAnimationOffset = (_o.PlayGuestUiAnimation == null) ? default(Offset<IPlayGuestCartethyia>) : IPlayGuestCartethyia.Pack(builder, _o.PlayGuestUiAnimation);
			return IPlayGuestUiAnimation.CreateIPlayGuestUiAnimation(builder, _o.Type, playGuestUiAnimationOffset);
		}

		// Token: 0x04012610 RID: 75280
		private Table __p;
	}
}
