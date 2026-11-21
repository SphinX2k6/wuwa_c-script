using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006476 RID: 25718
	public struct IPhotoTargetCaptureUiEntityZero : IFlatbufferObject
	{
		// Token: 0x1700BDC7 RID: 48583
		// (get) Token: 0x0602BB36 RID: 178998 RVA: 0x005F25B9 File Offset: 0x005F07B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB37 RID: 178999 RVA: 0x005F25C6 File Offset: 0x005F07C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB38 RID: 179000 RVA: 0x005F25D0 File Offset: 0x005F07D0
		public static IPhotoTargetCaptureUiEntityZero GetRootAsIPhotoTargetCaptureUiEntityZero(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiEntityZero.GetRootAsIPhotoTargetCaptureUiEntityZero(_bb, default(IPhotoTargetCaptureUiEntityZero));
		}

		// Token: 0x0602BB39 RID: 179001 RVA: 0x005F25EC File Offset: 0x005F07EC
		public static IPhotoTargetCaptureUiEntityZero GetRootAsIPhotoTargetCaptureUiEntityZero(ByteBuffer _bb, IPhotoTargetCaptureUiEntityZero obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB3A RID: 179002 RVA: 0x005F2609 File Offset: 0x005F0809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB3B RID: 179003 RVA: 0x005F2618 File Offset: 0x005F0818
		public IPhotoTargetCaptureUiEntityZero __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDC8 RID: 48584
		// (get) Token: 0x0602BB3C RID: 179004 RVA: 0x005F2628 File Offset: 0x005F0828
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

		// Token: 0x0602BB3D RID: 179005 RVA: 0x005F2664 File Offset: 0x005F0864
		public static Offset<IPhotoTargetCaptureUiEntityZero> CreateIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiEntityZero.AddType(builder, Type);
			return IPhotoTargetCaptureUiEntityZero.EndIPhotoTargetCaptureUiEntityZero(builder);
		}

		// Token: 0x0602BB3E RID: 179006 RVA: 0x005F267A File Offset: 0x005F087A
		public static void StartIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BB3F RID: 179007 RVA: 0x005F2683 File Offset: 0x005F0883
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB40 RID: 179008 RVA: 0x005F268E File Offset: 0x005F088E
		public static Offset<IPhotoTargetCaptureUiEntityZero> EndIPhotoTargetCaptureUiEntityZero(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiEntityZero>(builder.EndTable());
		}

		// Token: 0x0602BB41 RID: 179009 RVA: 0x005F269C File Offset: 0x005F089C
		public IPhotoTargetCaptureUiEntityZeroT UnPack()
		{
			IPhotoTargetCaptureUiEntityZeroT photoTargetCaptureUiEntityZeroT = new IPhotoTargetCaptureUiEntityZeroT();
			this.UnPackTo(photoTargetCaptureUiEntityZeroT);
			return photoTargetCaptureUiEntityZeroT;
		}

		// Token: 0x0602BB42 RID: 179010 RVA: 0x005F26B7 File Offset: 0x005F08B7
		public void UnPackTo(IPhotoTargetCaptureUiEntityZeroT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BB43 RID: 179011 RVA: 0x005F26C8 File Offset: 0x005F08C8
		public static Offset<IPhotoTargetCaptureUiEntityZero> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiEntityZeroT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiEntityZero>);
			}
			return IPhotoTargetCaptureUiEntityZero.CreateIPhotoTargetCaptureUiEntityZero(builder, _o.Type);
		}

		// Token: 0x04010596 RID: 66966
		private Table __p;
	}
}
