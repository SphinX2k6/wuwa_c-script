using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1D RID: 27933
	public struct IPlayGuestUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700CFFB RID: 53243
		// (get) Token: 0x0603141A RID: 201754 RVA: 0x006AE2A4 File Offset: 0x006AC4A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603141B RID: 201755 RVA: 0x006AE2B1 File Offset: 0x006AC4B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603141C RID: 201756 RVA: 0x006AE2B8 File Offset: 0x006AC4B8
		public static IPlayGuestUiAnimationType GetRootAsIPlayGuestUiAnimationType(ByteBuffer _bb)
		{
			return IPlayGuestUiAnimationType.GetRootAsIPlayGuestUiAnimationType(_bb, default(IPlayGuestUiAnimationType));
		}

		// Token: 0x0603141D RID: 201757 RVA: 0x006AE2D4 File Offset: 0x006AC4D4
		public static IPlayGuestUiAnimationType GetRootAsIPlayGuestUiAnimationType(ByteBuffer _bb, IPlayGuestUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603141E RID: 201758 RVA: 0x006AE2F1 File Offset: 0x006AC4F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603141F RID: 201759 RVA: 0x006AE300 File Offset: 0x006AC500
		public IPlayGuestUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFFC RID: 53244
		// (get) Token: 0x06031420 RID: 201760 RVA: 0x006AE310 File Offset: 0x006AC510
		public EGuestUiAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return (EGuestUiAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031421 RID: 201761 RVA: 0x006AE34C File Offset: 0x006AC54C
		public static Offset<IPlayGuestUiAnimationType> CreateIPlayGuestUiAnimationType(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IPlayGuestUiAnimationType.AddType(builder, Type);
			return IPlayGuestUiAnimationType.EndIPlayGuestUiAnimationType(builder);
		}

		// Token: 0x06031422 RID: 201762 RVA: 0x006AE362 File Offset: 0x006AC562
		public static void StartIPlayGuestUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031423 RID: 201763 RVA: 0x006AE36B File Offset: 0x006AC56B
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031424 RID: 201764 RVA: 0x006AE376 File Offset: 0x006AC576
		public static Offset<IPlayGuestUiAnimationType> EndIPlayGuestUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestUiAnimationType>(builder.EndTable());
		}

		// Token: 0x06031425 RID: 201765 RVA: 0x006AE384 File Offset: 0x006AC584
		public IPlayGuestUiAnimationTypeT UnPack()
		{
			IPlayGuestUiAnimationTypeT playGuestUiAnimationTypeT = new IPlayGuestUiAnimationTypeT();
			this.UnPackTo(playGuestUiAnimationTypeT);
			return playGuestUiAnimationTypeT;
		}

		// Token: 0x06031426 RID: 201766 RVA: 0x006AE39F File Offset: 0x006AC59F
		public void UnPackTo(IPlayGuestUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031427 RID: 201767 RVA: 0x006AE3B0 File Offset: 0x006AC5B0
		public static Offset<IPlayGuestUiAnimationType> Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestUiAnimationType>);
			}
			return IPlayGuestUiAnimationType.CreateIPlayGuestUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04011698 RID: 71320
		private Table __p;
	}
}
