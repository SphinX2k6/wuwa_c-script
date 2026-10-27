using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B2 RID: 26802
	public struct IGuestOperateUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700C6F1 RID: 50929
		// (get) Token: 0x0602EBF8 RID: 191480 RVA: 0x0065F475 File Offset: 0x0065D675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EBF9 RID: 191481 RVA: 0x0065F482 File Offset: 0x0065D682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EBFA RID: 191482 RVA: 0x0065F48C File Offset: 0x0065D68C
		public static IGuestOperateUiAnimationType GetRootAsIGuestOperateUiAnimationType(ByteBuffer _bb)
		{
			return IGuestOperateUiAnimationType.GetRootAsIGuestOperateUiAnimationType(_bb, default(IGuestOperateUiAnimationType));
		}

		// Token: 0x0602EBFB RID: 191483 RVA: 0x0065F4A8 File Offset: 0x0065D6A8
		public static IGuestOperateUiAnimationType GetRootAsIGuestOperateUiAnimationType(ByteBuffer _bb, IGuestOperateUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EBFC RID: 191484 RVA: 0x0065F4C5 File Offset: 0x0065D6C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EBFD RID: 191485 RVA: 0x0065F4D4 File Offset: 0x0065D6D4
		public IGuestOperateUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6F2 RID: 50930
		// (get) Token: 0x0602EBFE RID: 191486 RVA: 0x0065F4E4 File Offset: 0x0065D6E4
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

		// Token: 0x0602EBFF RID: 191487 RVA: 0x0065F520 File Offset: 0x0065D720
		public static Offset<IGuestOperateUiAnimationType> CreateIGuestOperateUiAnimationType(FlatBufferBuilder builder, EGuestOperateUiAnimation Type = EGuestOperateUiAnimation.Play)
		{
			builder.StartTable(1);
			IGuestOperateUiAnimationType.AddType(builder, Type);
			return IGuestOperateUiAnimationType.EndIGuestOperateUiAnimationType(builder);
		}

		// Token: 0x0602EC00 RID: 191488 RVA: 0x0065F536 File Offset: 0x0065D736
		public static void StartIGuestOperateUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EC01 RID: 191489 RVA: 0x0065F53F File Offset: 0x0065D73F
		public static void AddType(FlatBufferBuilder builder, EGuestOperateUiAnimation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EC02 RID: 191490 RVA: 0x0065F54A File Offset: 0x0065D74A
		public static Offset<IGuestOperateUiAnimationType> EndIGuestOperateUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IGuestOperateUiAnimationType>(builder.EndTable());
		}

		// Token: 0x0602EC03 RID: 191491 RVA: 0x0065F558 File Offset: 0x0065D758
		public IGuestOperateUiAnimationTypeT UnPack()
		{
			IGuestOperateUiAnimationTypeT guestOperateUiAnimationTypeT = new IGuestOperateUiAnimationTypeT();
			this.UnPackTo(guestOperateUiAnimationTypeT);
			return guestOperateUiAnimationTypeT;
		}

		// Token: 0x0602EC04 RID: 191492 RVA: 0x0065F573 File Offset: 0x0065D773
		public void UnPackTo(IGuestOperateUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EC05 RID: 191493 RVA: 0x0065F584 File Offset: 0x0065D784
		public static Offset<IGuestOperateUiAnimationType> Pack(FlatBufferBuilder builder, IGuestOperateUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuestOperateUiAnimationType>);
			}
			return IGuestOperateUiAnimationType.CreateIGuestOperateUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04011005 RID: 69637
		private Table __p;
	}
}
