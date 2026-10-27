using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CF RID: 29135
	public struct IStopGuestUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700D875 RID: 55413
		// (get) Token: 0x06033AEB RID: 211691 RVA: 0x006F58A5 File Offset: 0x006F3AA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033AEC RID: 211692 RVA: 0x006F58B2 File Offset: 0x006F3AB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033AED RID: 211693 RVA: 0x006F58BC File Offset: 0x006F3ABC
		public static IStopGuestUiAnimation GetRootAsIStopGuestUiAnimation(ByteBuffer _bb)
		{
			return IStopGuestUiAnimation.GetRootAsIStopGuestUiAnimation(_bb, default(IStopGuestUiAnimation));
		}

		// Token: 0x06033AEE RID: 211694 RVA: 0x006F58D8 File Offset: 0x006F3AD8
		public static IStopGuestUiAnimation GetRootAsIStopGuestUiAnimation(ByteBuffer _bb, IStopGuestUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033AEF RID: 211695 RVA: 0x006F58F5 File Offset: 0x006F3AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033AF0 RID: 211696 RVA: 0x006F5904 File Offset: 0x006F3B04
		public IStopGuestUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D876 RID: 55414
		// (get) Token: 0x06033AF1 RID: 211697 RVA: 0x006F5914 File Offset: 0x006F3B14
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

		// Token: 0x1700D877 RID: 55415
		// (get) Token: 0x06033AF2 RID: 211698 RVA: 0x006F5950 File Offset: 0x006F3B50
		public IStopGuestCartethyia? StopGuestUiAnimation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IStopGuestCartethyia?(default(IStopGuestCartethyia).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06033AF3 RID: 211699 RVA: 0x006F59AD File Offset: 0x006F3BAD
		public static Offset<IStopGuestUiAnimation> CreateIStopGuestUiAnimation(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play, Offset<IStopGuestCartethyia> StopGuestUiAnimationOffset = default(Offset<IStopGuestCartethyia>))
		{
			builder.StartTable(2);
			IStopGuestUiAnimation.AddStopGuestUiAnimation(builder, StopGuestUiAnimationOffset);
			IStopGuestUiAnimation.AddType(builder, Type);
			return IStopGuestUiAnimation.EndIStopGuestUiAnimation(builder);
		}

		// Token: 0x06033AF4 RID: 211700 RVA: 0x006F59CA File Offset: 0x006F3BCA
		public static void StartIStopGuestUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033AF5 RID: 211701 RVA: 0x006F59D3 File Offset: 0x006F3BD3
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033AF6 RID: 211702 RVA: 0x006F59DE File Offset: 0x006F3BDE
		public static void AddStopGuestUiAnimation(FlatBufferBuilder builder, Offset<IStopGuestCartethyia> stopGuestUiAnimationOffset)
		{
			builder.AddOffset(1, stopGuestUiAnimationOffset.Value, 0);
		}

		// Token: 0x06033AF7 RID: 211703 RVA: 0x006F59EE File Offset: 0x006F3BEE
		public static Offset<IStopGuestUiAnimation> EndIStopGuestUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestUiAnimation>(builder.EndTable());
		}

		// Token: 0x06033AF8 RID: 211704 RVA: 0x006F59FC File Offset: 0x006F3BFC
		public IStopGuestUiAnimationT UnPack()
		{
			IStopGuestUiAnimationT stopGuestUiAnimationT = new IStopGuestUiAnimationT();
			this.UnPackTo(stopGuestUiAnimationT);
			return stopGuestUiAnimationT;
		}

		// Token: 0x06033AF9 RID: 211705 RVA: 0x006F5A18 File Offset: 0x006F3C18
		public void UnPackTo(IStopGuestUiAnimationT _o)
		{
			_o.Type = this.Type;
			_o.StopGuestUiAnimation = ((this.StopGuestUiAnimation != null) ? this.StopGuestUiAnimation.Value.UnPack() : null);
		}

		// Token: 0x06033AFA RID: 211706 RVA: 0x006F5A60 File Offset: 0x006F3C60
		public static Offset<IStopGuestUiAnimation> Pack(FlatBufferBuilder builder, IStopGuestUiAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestUiAnimation>);
			}
			Offset<IStopGuestCartethyia> stopGuestUiAnimationOffset = (_o.StopGuestUiAnimation == null) ? default(Offset<IStopGuestCartethyia>) : IStopGuestCartethyia.Pack(builder, _o.StopGuestUiAnimation);
			return IStopGuestUiAnimation.CreateIStopGuestUiAnimation(builder, _o.Type, stopGuestUiAnimationOffset);
		}

		// Token: 0x04011CB0 RID: 72880
		private Table __p;
	}
}
