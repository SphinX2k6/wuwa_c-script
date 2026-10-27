using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D2 RID: 29138
	public struct IStopGuestUiAnimationType : IFlatbufferObject
	{
		// Token: 0x1700D87A RID: 55418
		// (get) Token: 0x06033B01 RID: 211713 RVA: 0x006F5B34 File Offset: 0x006F3D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B02 RID: 211714 RVA: 0x006F5B41 File Offset: 0x006F3D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B03 RID: 211715 RVA: 0x006F5B48 File Offset: 0x006F3D48
		public static IStopGuestUiAnimationType GetRootAsIStopGuestUiAnimationType(ByteBuffer _bb)
		{
			return IStopGuestUiAnimationType.GetRootAsIStopGuestUiAnimationType(_bb, default(IStopGuestUiAnimationType));
		}

		// Token: 0x06033B04 RID: 211716 RVA: 0x006F5B64 File Offset: 0x006F3D64
		public static IStopGuestUiAnimationType GetRootAsIStopGuestUiAnimationType(ByteBuffer _bb, IStopGuestUiAnimationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B05 RID: 211717 RVA: 0x006F5B81 File Offset: 0x006F3D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B06 RID: 211718 RVA: 0x006F5B90 File Offset: 0x006F3D90
		public IStopGuestUiAnimationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D87B RID: 55419
		// (get) Token: 0x06033B07 RID: 211719 RVA: 0x006F5BA0 File Offset: 0x006F3DA0
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

		// Token: 0x06033B08 RID: 211720 RVA: 0x006F5BDC File Offset: 0x006F3DDC
		public static Offset<IStopGuestUiAnimationType> CreateIStopGuestUiAnimationType(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IStopGuestUiAnimationType.AddType(builder, Type);
			return IStopGuestUiAnimationType.EndIStopGuestUiAnimationType(builder);
		}

		// Token: 0x06033B09 RID: 211721 RVA: 0x006F5BF2 File Offset: 0x006F3DF2
		public static void StartIStopGuestUiAnimationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033B0A RID: 211722 RVA: 0x006F5BFB File Offset: 0x006F3DFB
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033B0B RID: 211723 RVA: 0x006F5C06 File Offset: 0x006F3E06
		public static Offset<IStopGuestUiAnimationType> EndIStopGuestUiAnimationType(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestUiAnimationType>(builder.EndTable());
		}

		// Token: 0x06033B0C RID: 211724 RVA: 0x006F5C14 File Offset: 0x006F3E14
		public IStopGuestUiAnimationTypeT UnPack()
		{
			IStopGuestUiAnimationTypeT stopGuestUiAnimationTypeT = new IStopGuestUiAnimationTypeT();
			this.UnPackTo(stopGuestUiAnimationTypeT);
			return stopGuestUiAnimationTypeT;
		}

		// Token: 0x06033B0D RID: 211725 RVA: 0x006F5C2F File Offset: 0x006F3E2F
		public void UnPackTo(IStopGuestUiAnimationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033B0E RID: 211726 RVA: 0x006F5C40 File Offset: 0x006F3E40
		public static Offset<IStopGuestUiAnimationType> Pack(FlatBufferBuilder builder, IStopGuestUiAnimationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestUiAnimationType>);
			}
			return IStopGuestUiAnimationType.CreateIStopGuestUiAnimationType(builder, _o.Type);
		}

		// Token: 0x04011CB3 RID: 72883
		private Table __p;
	}
}
