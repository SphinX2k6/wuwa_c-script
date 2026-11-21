using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007498 RID: 29848
	public struct IPlayGuestUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700DB41 RID: 56129
		// (get) Token: 0x06034412 RID: 214034 RVA: 0x007098E8 File Offset: 0x00707AE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034413 RID: 214035 RVA: 0x007098F5 File Offset: 0x00707AF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034414 RID: 214036 RVA: 0x007098FC File Offset: 0x00707AFC
		public static IPlayGuestUiAnimationType GetRootAsIPlayGuestUiAnimationType(ByteBuffer _bb)
		{
			return IPlayGuestUiAnimationType.GetRootAsIPlayGuestUiAnimationType(_bb, default(IPlayGuestUiAnimationType));
		}

		// Token: 0x06034415 RID: 214037 RVA: 0x00709918 File Offset: 0x00707B18
		public static IPlayGuestUiAnimationType GetRootAsIPlayGuestUiAnimationType(ByteBuffer _bb, IPlayGuestUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034416 RID: 214038 RVA: 0x00709935 File Offset: 0x00707B35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034417 RID: 214039 RVA: 0x00709944 File Offset: 0x00707B44
		public IPlayGuestUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB42 RID: 56130
		// (get) Token: 0x06034418 RID: 214040 RVA: 0x00709954 File Offset: 0x00707B54
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

		// Token: 0x06034419 RID: 214041 RVA: 0x00709990 File Offset: 0x00707B90
		public static Offset<IPlayGuestUiAnimationType> CreateIPlayGuestUiAnimationType(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IPlayGuestUiAnimationType.AddType(builder, Type);
			return IPlayGuestUiAnimationType.EndIPlayGuestUiAnimationType(builder);
		}

		// Token: 0x0603441A RID: 214042 RVA: 0x007099A6 File Offset: 0x00707BA6
		public static void StartIPlayGuestUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603441B RID: 214043 RVA: 0x007099AF File Offset: 0x00707BAF
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603441C RID: 214044 RVA: 0x007099BA File Offset: 0x00707BBA
		public static Offset<IPlayGuestUiAnimationType> EndIPlayGuestUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IPlayGuestUiAnimationType>(builder.EndTable());
		}

		// Token: 0x0603441D RID: 214045 RVA: 0x007099C8 File Offset: 0x00707BC8
		public IPlayGuestUiAnimationTypeT UnPack()
		{
			IPlayGuestUiAnimationTypeT playGuestUiAnimationTypeT = new IPlayGuestUiAnimationTypeT();
			this.UnPackTo(playGuestUiAnimationTypeT);
			return playGuestUiAnimationTypeT;
		}

		// Token: 0x0603441E RID: 214046 RVA: 0x007099E3 File Offset: 0x00707BE3
		public void UnPackTo(IPlayGuestUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603441F RID: 214047 RVA: 0x007099F4 File Offset: 0x00707BF4
		public static Offset<IPlayGuestUiAnimationType> Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayGuestUiAnimationType>);
			}
			return IPlayGuestUiAnimationType.CreateIPlayGuestUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04012613 RID: 75283
		private Table __p;
	}
}
