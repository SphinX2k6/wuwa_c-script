using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A4 RID: 31140
	public struct IStopGuestUiAnimation : IFlatbufferObject
	{
		// Token: 0x1700E46E RID: 58478
		// (get) Token: 0x06036DED RID: 224749 RVA: 0x00756C05 File Offset: 0x00754E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DEE RID: 224750 RVA: 0x00756C12 File Offset: 0x00754E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DEF RID: 224751 RVA: 0x00756C1C File Offset: 0x00754E1C
		public static IStopGuestUiAnimation GetRootAsIStopGuestUiAnimation(ByteBuffer _bb)
		{
			return IStopGuestUiAnimation.GetRootAsIStopGuestUiAnimation(_bb, default(IStopGuestUiAnimation));
		}

		// Token: 0x06036DF0 RID: 224752 RVA: 0x00756C38 File Offset: 0x00754E38
		public static IStopGuestUiAnimation GetRootAsIStopGuestUiAnimation(ByteBuffer _bb, IStopGuestUiAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DF1 RID: 224753 RVA: 0x00756C55 File Offset: 0x00754E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DF2 RID: 224754 RVA: 0x00756C64 File Offset: 0x00754E64
		public IStopGuestUiAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E46F RID: 58479
		// (get) Token: 0x06036DF3 RID: 224755 RVA: 0x00756C74 File Offset: 0x00754E74
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

		// Token: 0x1700E470 RID: 58480
		// (get) Token: 0x06036DF4 RID: 224756 RVA: 0x00756CB0 File Offset: 0x00754EB0
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

		// Token: 0x06036DF5 RID: 224757 RVA: 0x00756D0D File Offset: 0x00754F0D
		public static Offset<IStopGuestUiAnimation> CreateIStopGuestUiAnimation(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play, Offset<IStopGuestCartethyia> StopGuestUiAnimationOffset = default(Offset<IStopGuestCartethyia>))
		{
			builder.StartTable(2);
			IStopGuestUiAnimation.AddStopGuestUiAnimation(builder, StopGuestUiAnimationOffset);
			IStopGuestUiAnimation.AddType(builder, Type);
			return IStopGuestUiAnimation.EndIStopGuestUiAnimation(builder);
		}

		// Token: 0x06036DF6 RID: 224758 RVA: 0x00756D2A File Offset: 0x00754F2A
		public static void StartIStopGuestUiAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036DF7 RID: 224759 RVA: 0x00756D33 File Offset: 0x00754F33
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036DF8 RID: 224760 RVA: 0x00756D3E File Offset: 0x00754F3E
		public static void AddStopGuestUiAnimation(FlatBufferBuilder builder, Offset<IStopGuestCartethyia> stopGuestUiAnimationOffset)
		{
			builder.AddOffset(1, stopGuestUiAnimationOffset.Value, 0);
		}

		// Token: 0x06036DF9 RID: 224761 RVA: 0x00756D4E File Offset: 0x00754F4E
		public static Offset<IStopGuestUiAnimation> EndIStopGuestUiAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestUiAnimation>(builder.EndTable());
		}

		// Token: 0x06036DFA RID: 224762 RVA: 0x00756D5C File Offset: 0x00754F5C
		public IStopGuestUiAnimationT UnPack()
		{
			IStopGuestUiAnimationT stopGuestUiAnimationT = new IStopGuestUiAnimationT();
			this.UnPackTo(stopGuestUiAnimationT);
			return stopGuestUiAnimationT;
		}

		// Token: 0x06036DFB RID: 224763 RVA: 0x00756D78 File Offset: 0x00754F78
		public void UnPackTo(IStopGuestUiAnimationT _o)
		{
			_o.Type = this.Type;
			_o.StopGuestUiAnimation = ((this.StopGuestUiAnimation != null) ? this.StopGuestUiAnimation.Value.UnPack() : null);
		}

		// Token: 0x06036DFC RID: 224764 RVA: 0x00756DC0 File Offset: 0x00754FC0
		public static Offset<IStopGuestUiAnimation> Pack(FlatBufferBuilder builder, IStopGuestUiAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestUiAnimation>);
			}
			Offset<IStopGuestCartethyia> stopGuestUiAnimationOffset = (_o.StopGuestUiAnimation == null) ? default(Offset<IStopGuestCartethyia>) : IStopGuestCartethyia.Pack(builder, _o.StopGuestUiAnimation);
			return IStopGuestUiAnimation.CreateIStopGuestUiAnimation(builder, _o.Type, stopGuestUiAnimationOffset);
		}

		// Token: 0x04012CB2 RID: 76978
		private Table __p;
	}
}
