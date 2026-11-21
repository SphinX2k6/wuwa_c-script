using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A7 RID: 31143
	public struct IStopGuestUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700E473 RID: 58483
		// (get) Token: 0x06036E03 RID: 224771 RVA: 0x00756E94 File Offset: 0x00755094
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E04 RID: 224772 RVA: 0x00756EA1 File Offset: 0x007550A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E05 RID: 224773 RVA: 0x00756EA8 File Offset: 0x007550A8
		public static IStopGuestUiAnimationType GetRootAsIStopGuestUiAnimationType(ByteBuffer _bb)
		{
			return IStopGuestUiAnimationType.GetRootAsIStopGuestUiAnimationType(_bb, default(IStopGuestUiAnimationType));
		}

		// Token: 0x06036E06 RID: 224774 RVA: 0x00756EC4 File Offset: 0x007550C4
		public static IStopGuestUiAnimationType GetRootAsIStopGuestUiAnimationType(ByteBuffer _bb, IStopGuestUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E07 RID: 224775 RVA: 0x00756EE1 File Offset: 0x007550E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E08 RID: 224776 RVA: 0x00756EF0 File Offset: 0x007550F0
		public IStopGuestUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E474 RID: 58484
		// (get) Token: 0x06036E09 RID: 224777 RVA: 0x00756F00 File Offset: 0x00755100
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

		// Token: 0x06036E0A RID: 224778 RVA: 0x00756F3C File Offset: 0x0075513C
		public static Offset<IStopGuestUiAnimationType> CreateIStopGuestUiAnimationType(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IStopGuestUiAnimationType.AddType(builder, Type);
			return IStopGuestUiAnimationType.EndIStopGuestUiAnimationType(builder);
		}

		// Token: 0x06036E0B RID: 224779 RVA: 0x00756F52 File Offset: 0x00755152
		public static void StartIStopGuestUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036E0C RID: 224780 RVA: 0x00756F5B File Offset: 0x0075515B
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E0D RID: 224781 RVA: 0x00756F66 File Offset: 0x00755166
		public static Offset<IStopGuestUiAnimationType> EndIStopGuestUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestUiAnimationType>(builder.EndTable());
		}

		// Token: 0x06036E0E RID: 224782 RVA: 0x00756F74 File Offset: 0x00755174
		public IStopGuestUiAnimationTypeT UnPack()
		{
			IStopGuestUiAnimationTypeT stopGuestUiAnimationTypeT = new IStopGuestUiAnimationTypeT();
			this.UnPackTo(stopGuestUiAnimationTypeT);
			return stopGuestUiAnimationTypeT;
		}

		// Token: 0x06036E0F RID: 224783 RVA: 0x00756F8F File Offset: 0x0075518F
		public void UnPackTo(IStopGuestUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036E10 RID: 224784 RVA: 0x00756FA0 File Offset: 0x007551A0
		public static Offset<IStopGuestUiAnimationType> Pack(FlatBufferBuilder builder, IStopGuestUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestUiAnimationType>);
			}
			return IStopGuestUiAnimationType.CreateIStopGuestUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04012CB5 RID: 76981
		private Table __p;
	}
}
