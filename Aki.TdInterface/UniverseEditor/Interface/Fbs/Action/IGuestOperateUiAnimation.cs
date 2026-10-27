using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AF RID: 26799
	public struct IGuestOperateUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700C6EE RID: 50926
		// (get) Token: 0x0602EBE2 RID: 191458 RVA: 0x0065F17D File Offset: 0x0065D37D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBE3 RID: 191459 RVA: 0x0065F18A File Offset: 0x0065D38A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBE4 RID: 191460 RVA: 0x0065F194 File Offset: 0x0065D394
		public static IGuestOperateUiAnimation GetRootAsIGuestOperateUiAnimation(ByteBuffer _bb)
		{
			return IGuestOperateUiAnimation.GetRootAsIGuestOperateUiAnimation(_bb, default(IGuestOperateUiAnimation));
		}

		// Token: 0x0602EBE5 RID: 191461 RVA: 0x0065F1B0 File Offset: 0x0065D3B0
		public static IGuestOperateUiAnimation GetRootAsIGuestOperateUiAnimation(ByteBuffer _bb, IGuestOperateUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBE6 RID: 191462 RVA: 0x0065F1CD File Offset: 0x0065D3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBE7 RID: 191463 RVA: 0x0065F1DC File Offset: 0x0065D3DC
		public IGuestOperateUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6EF RID: 50927
		// (get) Token: 0x0602EBE8 RID: 191464 RVA: 0x0065F1EC File Offset: 0x0065D3EC
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

		// Token: 0x0602EBE9 RID: 191465 RVA: 0x0065F228 File Offset: 0x0065D428
		public TTable? UiAnimationConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EBEA RID: 191466 RVA: 0x0065F26C File Offset: 0x0065D46C
		public IPlayGuestUiAnimation UiAnimationConfigAsIPlayGuestUiAnimation()
		{
			return this.UiAnimationConfig<IPlayGuestUiAnimation>().Value;
		}

		// Token: 0x0602EBEB RID: 191467 RVA: 0x0065F288 File Offset: 0x0065D488
		public IStopGuestUiAnimation UiAnimationConfigAsIStopGuestUiAnimation()
		{
			return this.UiAnimationConfig<IStopGuestUiAnimation>().Value;
		}

		// Token: 0x0602EBEC RID: 191468 RVA: 0x0065F2A3 File Offset: 0x0065D4A3
		public static Offset<IGuestOperateUiAnimation> CreateIGuestOperateUiAnimation(FlatBufferBuilder builder, TGuestOperateUiAnimation UiAnimationConfig_type = TGuestOperateUiAnimation.NONE, int UiAnimationConfigOffset = 0)
		{
			builder.StartTable(2);
			IGuestOperateUiAnimation.AddUiAnimationConfig(builder, UiAnimationConfigOffset);
			IGuestOperateUiAnimation.AddUiAnimationConfigType(builder, UiAnimationConfig_type);
			return IGuestOperateUiAnimation.EndIGuestOperateUiAnimation(builder);
		}

		// Token: 0x0602EBED RID: 191469 RVA: 0x0065F2C0 File Offset: 0x0065D4C0
		public static void StartIGuestOperateUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EBEE RID: 191470 RVA: 0x0065F2C9 File Offset: 0x0065D4C9
		public static void AddUiAnimationConfigType(FlatBufferBuilder builder, TGuestOperateUiAnimation uiAnimationConfigType)
		{
			builder.AddByte(0, (byte)uiAnimationConfigType, 0);
		}

		// Token: 0x0602EBEF RID: 191471 RVA: 0x0065F2D4 File Offset: 0x0065D4D4
		public static void AddUiAnimationConfig(FlatBufferBuilder builder, int uiAnimationConfigOffset)
		{
			builder.AddOffset(1, uiAnimationConfigOffset, 0);
		}

		// Token: 0x0602EBF0 RID: 191472 RVA: 0x0065F2DF File Offset: 0x0065D4DF
		public static Offset<IGuestOperateUiAnimation> EndIGuestOperateUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IGuestOperateUiAnimation>(builder.EndTable());
		}

		// Token: 0x0602EBF1 RID: 191473 RVA: 0x0065F2EC File Offset: 0x0065D4EC
		public IGuestOperateUiAnimationT UnPack()
		{
			IGuestOperateUiAnimationT guestOperateUiAnimationT = new IGuestOperateUiAnimationT();
			this.UnPackTo(guestOperateUiAnimationT);
			return guestOperateUiAnimationT;
		}

		// Token: 0x0602EBF2 RID: 191474 RVA: 0x0065F308 File Offset: 0x0065D508
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

		// Token: 0x0602EBF3 RID: 191475 RVA: 0x0065F3AC File Offset: 0x0065D5AC
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

		// Token: 0x04011003 RID: 69635
		private Table __p;
	}
}
