using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F50 RID: 28496
	public struct IGuestOperateUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700D0D4 RID: 53460
		// (get) Token: 0x0603151C RID: 202012 RVA: 0x006AE1FD File Offset: 0x006AC3FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603151D RID: 202013 RVA: 0x006AE20A File Offset: 0x006AC40A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603151E RID: 202014 RVA: 0x006AE214 File Offset: 0x006AC414
		public static IGuestOperateUiAnimation GetRootAsIGuestOperateUiAnimation(ByteBuffer _bb)
		{
			return IGuestOperateUiAnimation.GetRootAsIGuestOperateUiAnimation(_bb, default(IGuestOperateUiAnimation));
		}

		// Token: 0x0603151F RID: 202015 RVA: 0x006AE230 File Offset: 0x006AC430
		public static IGuestOperateUiAnimation GetRootAsIGuestOperateUiAnimation(ByteBuffer _bb, IGuestOperateUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031520 RID: 202016 RVA: 0x006AE24D File Offset: 0x006AC44D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031521 RID: 202017 RVA: 0x006AE25C File Offset: 0x006AC45C
		public IGuestOperateUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0D5 RID: 53461
		// (get) Token: 0x06031522 RID: 202018 RVA: 0x006AE26C File Offset: 0x006AC46C
		public TGuestOperateUiAnimation UiAnimationConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TGuestOperateUiAnimation.NONE;
				}
				return (TGuestOperateUiAnimation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031523 RID: 202019 RVA: 0x006AE2A8 File Offset: 0x006AC4A8
		public TTable? UiAnimationConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031524 RID: 202020 RVA: 0x006AE2EC File Offset: 0x006AC4EC
		public IPlayGuestUiAnimation UiAnimationConfigAsIPlayGuestUiAnimation()
		{
			return this.UiAnimationConfig<IPlayGuestUiAnimation>().Value;
		}

		// Token: 0x06031525 RID: 202021 RVA: 0x006AE308 File Offset: 0x006AC508
		public IStopGuestUiAnimation UiAnimationConfigAsIStopGuestUiAnimation()
		{
			return this.UiAnimationConfig<IStopGuestUiAnimation>().Value;
		}

		// Token: 0x06031526 RID: 202022 RVA: 0x006AE323 File Offset: 0x006AC523
		public static Offset<IGuestOperateUiAnimation> CreateIGuestOperateUiAnimation(FlatBufferBuilder builder, TGuestOperateUiAnimation UiAnimationConfig_type = TGuestOperateUiAnimation.NONE, int UiAnimationConfigOffset = 0)
		{
			builder.StartTable(2);
			IGuestOperateUiAnimation.AddUiAnimationConfig(builder, UiAnimationConfigOffset);
			IGuestOperateUiAnimation.AddUiAnimationConfigType(builder, UiAnimationConfig_type);
			return IGuestOperateUiAnimation.EndIGuestOperateUiAnimation(builder);
		}

		// Token: 0x06031527 RID: 202023 RVA: 0x006AE340 File Offset: 0x006AC540
		public static void StartIGuestOperateUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031528 RID: 202024 RVA: 0x006AE349 File Offset: 0x006AC549
		public static void AddUiAnimationConfigType(FlatBufferBuilder builder, TGuestOperateUiAnimation uiAnimationConfigType)
		{
			builder.AddByte(0, (byte)uiAnimationConfigType, 0);
		}

		// Token: 0x06031529 RID: 202025 RVA: 0x006AE354 File Offset: 0x006AC554
		public static void AddUiAnimationConfig(FlatBufferBuilder builder, int uiAnimationConfigOffset)
		{
			builder.AddOffset(1, uiAnimationConfigOffset, 0);
		}

		// Token: 0x0603152A RID: 202026 RVA: 0x006AE35F File Offset: 0x006AC55F
		public static Offset<IGuestOperateUiAnimation> EndIGuestOperateUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IGuestOperateUiAnimation>(builder.EndTable());
		}

		// Token: 0x0603152B RID: 202027 RVA: 0x006AE36C File Offset: 0x006AC56C
		public IGuestOperateUiAnimationT UnPack()
		{
			IGuestOperateUiAnimationT guestOperateUiAnimationT = new IGuestOperateUiAnimationT();
			this.UnPackTo(guestOperateUiAnimationT);
			return guestOperateUiAnimationT;
		}

		// Token: 0x0603152C RID: 202028 RVA: 0x006AE388 File Offset: 0x006AC588
		public void UnPackTo(IGuestOperateUiAnimationT _o)
		{
			_o.UiAnimationConfig = new TGuestOperateUiAnimationUnion();
			_o.UiAnimationConfig.Type = this.UiAnimationConfigType;
			TGuestOperateUiAnimation uiAnimationConfigType = this.UiAnimationConfigType;
			if (uiAnimationConfigType == TGuestOperateUiAnimation.IPlayGuestUiAnimation)
			{
				_o.UiAnimationConfig.Value = ((this.UiAnimationConfig<IPlayGuestUiAnimation>() != null) ? this.UiAnimationConfig<IPlayGuestUiAnimation>().Value.UnPack() : null);
				return;
			}
			if (uiAnimationConfigType != TGuestOperateUiAnimation.IStopGuestUiAnimation)
			{
				return;
			}
			_o.UiAnimationConfig.Value = ((this.UiAnimationConfig<IStopGuestUiAnimation>() != null) ? this.UiAnimationConfig<IStopGuestUiAnimation>().Value.UnPack() : null);
		}

		// Token: 0x0603152D RID: 202029 RVA: 0x006AE42C File Offset: 0x006AC62C
		public static Offset<IGuestOperateUiAnimation> Pack(FlatBufferBuilder builder, IGuestOperateUiAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuestOperateUiAnimation>);
			}
			TGuestOperateUiAnimation uiAnimationConfig_type = (_o.UiAnimationConfig == null) ? TGuestOperateUiAnimation.NONE : _o.UiAnimationConfig.Type;
			int uiAnimationConfigOffset = (_o.UiAnimationConfig == null) ? 0 : TGuestOperateUiAnimationUnion.Pack(builder, _o.UiAnimationConfig);
			return IGuestOperateUiAnimation.CreateIGuestOperateUiAnimation(builder, uiAnimationConfig_type, uiAnimationConfigOffset);
		}

		// Token: 0x04011E58 RID: 73304
		private Table __p;
	}
}
