using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3C RID: 24124
	public struct IPhotoTargetCaptureUiRequiredPointsCenter : IFlatbufferObject
	{
		// Token: 0x1700B464 RID: 46180
		// (get) Token: 0x060294BE RID: 169150 RVA: 0x005A9A01 File Offset: 0x005A7C01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060294BF RID: 169151 RVA: 0x005A9A0E File Offset: 0x005A7C0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060294C0 RID: 169152 RVA: 0x005A9A18 File Offset: 0x005A7C18
		public static IPhotoTargetCaptureUiRequiredPointsCenter GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiRequiredPointsCenter.GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(_bb, default(IPhotoTargetCaptureUiRequiredPointsCenter));
		}

		// Token: 0x060294C1 RID: 169153 RVA: 0x005A9A34 File Offset: 0x005A7C34
		public static IPhotoTargetCaptureUiRequiredPointsCenter GetRootAsIPhotoTargetCaptureUiRequiredPointsCenter(ByteBuffer _bb, IPhotoTargetCaptureUiRequiredPointsCenter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060294C2 RID: 169154 RVA: 0x005A9A51 File Offset: 0x005A7C51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060294C3 RID: 169155 RVA: 0x005A9A60 File Offset: 0x005A7C60
		public IPhotoTargetCaptureUiRequiredPointsCenter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B465 RID: 46181
		// (get) Token: 0x060294C4 RID: 169156 RVA: 0x005A9A70 File Offset: 0x005A7C70
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

		// Token: 0x060294C5 RID: 169157 RVA: 0x005A9AAC File Offset: 0x005A7CAC
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> CreateIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiRequiredPointsCenter.AddType(builder, Type);
			return IPhotoTargetCaptureUiRequiredPointsCenter.EndIPhotoTargetCaptureUiRequiredPointsCenter(builder);
		}

		// Token: 0x060294C6 RID: 169158 RVA: 0x005A9AC2 File Offset: 0x005A7CC2
		public static void StartIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060294C7 RID: 169159 RVA: 0x005A9ACB File Offset: 0x005A7CCB
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294C8 RID: 169160 RVA: 0x005A9AD6 File Offset: 0x005A7CD6
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> EndIPhotoTargetCaptureUiRequiredPointsCenter(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiRequiredPointsCenter>(builder.EndTable());
		}

		// Token: 0x060294C9 RID: 169161 RVA: 0x005A9AE4 File Offset: 0x005A7CE4
		public IPhotoTargetCaptureUiRequiredPointsCenterT UnPack()
		{
			IPhotoTargetCaptureUiRequiredPointsCenterT photoTargetCaptureUiRequiredPointsCenterT = new IPhotoTargetCaptureUiRequiredPointsCenterT();
			this.UnPackTo(photoTargetCaptureUiRequiredPointsCenterT);
			return photoTargetCaptureUiRequiredPointsCenterT;
		}

		// Token: 0x060294CA RID: 169162 RVA: 0x005A9AFF File Offset: 0x005A7CFF
		public void UnPackTo(IPhotoTargetCaptureUiRequiredPointsCenterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060294CB RID: 169163 RVA: 0x005A9B10 File Offset: 0x005A7D10
		public static Offset<IPhotoTargetCaptureUiRequiredPointsCenter> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiRequiredPointsCenterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiRequiredPointsCenter>);
			}
			return IPhotoTargetCaptureUiRequiredPointsCenter.CreateIPhotoTargetCaptureUiRequiredPointsCenter(builder, _o.Type);
		}

		// Token: 0x0400F83D RID: 63549
		private Table __p;
	}
}
