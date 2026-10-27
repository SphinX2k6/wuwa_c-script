using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E39 RID: 24121
	public struct IPhotoTargetCaptureUiEntityZero : IFlatbufferObject
	{
		// Token: 0x1700B461 RID: 46177
		// (get) Token: 0x060294AC RID: 169132 RVA: 0x005A9889 File Offset: 0x005A7A89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060294AD RID: 169133 RVA: 0x005A9896 File Offset: 0x005A7A96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060294AE RID: 169134 RVA: 0x005A98A0 File Offset: 0x005A7AA0
		public static IPhotoTargetCaptureUiEntityZero GetRootAsIPhotoTargetCaptureUiEntityZero(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiEntityZero.GetRootAsIPhotoTargetCaptureUiEntityZero(_bb, default(IPhotoTargetCaptureUiEntityZero));
		}

		// Token: 0x060294AF RID: 169135 RVA: 0x005A98BC File Offset: 0x005A7ABC
		public static IPhotoTargetCaptureUiEntityZero GetRootAsIPhotoTargetCaptureUiEntityZero(ByteBuffer _bb, IPhotoTargetCaptureUiEntityZero obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060294B0 RID: 169136 RVA: 0x005A98D9 File Offset: 0x005A7AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060294B1 RID: 169137 RVA: 0x005A98E8 File Offset: 0x005A7AE8
		public IPhotoTargetCaptureUiEntityZero __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B462 RID: 46178
		// (get) Token: 0x060294B2 RID: 169138 RVA: 0x005A98F8 File Offset: 0x005A7AF8
		public EPhotoTargetCaptureUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPhotoTargetCaptureUiType.RequiredPointsCenter;
				}
				return (EPhotoTargetCaptureUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060294B3 RID: 169139 RVA: 0x005A9934 File Offset: 0x005A7B34
		public static Offset<IPhotoTargetCaptureUiEntityZero> CreateIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiEntityZero.AddType(builder, Type);
			return IPhotoTargetCaptureUiEntityZero.EndIPhotoTargetCaptureUiEntityZero(builder);
		}

		// Token: 0x060294B4 RID: 169140 RVA: 0x005A994A File Offset: 0x005A7B4A
		public static void StartIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060294B5 RID: 169141 RVA: 0x005A9953 File Offset: 0x005A7B53
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294B6 RID: 169142 RVA: 0x005A995E File Offset: 0x005A7B5E
		public static Offset<IPhotoTargetCaptureUiEntityZero> EndIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiEntityZero>(builder.EndTable());
		}

		// Token: 0x060294B7 RID: 169143 RVA: 0x005A996C File Offset: 0x005A7B6C
		public IPhotoTargetCaptureUiEntityZeroT UnPack()
		{
			IPhotoTargetCaptureUiEntityZeroT photoTargetCaptureUiEntityZeroT = new IPhotoTargetCaptureUiEntityZeroT();
			this.UnPackTo(photoTargetCaptureUiEntityZeroT);
			return photoTargetCaptureUiEntityZeroT;
		}

		// Token: 0x060294B8 RID: 169144 RVA: 0x005A9987 File Offset: 0x005A7B87
		public void UnPackTo(IPhotoTargetCaptureUiEntityZeroT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060294B9 RID: 169145 RVA: 0x005A9998 File Offset: 0x005A7B98
		public static Offset<IPhotoTargetCaptureUiEntityZero> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiEntityZeroT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiEntityZero>);
			}
			return IPhotoTargetCaptureUiEntityZero.CreateIPhotoTargetCaptureUiEntityZero(builder, _o.Type);
		}

		// Token: 0x0400F83B RID: 63547
		private Table __p;
	}
}
