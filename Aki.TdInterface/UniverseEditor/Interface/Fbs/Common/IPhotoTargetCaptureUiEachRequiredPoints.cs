using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006473 RID: 25715
	public struct IPhotoTargetCaptureUiEachRequiredPoints : IFlatbufferObject
	{
		// Token: 0x1700BDC4 RID: 48580
		// (get) Token: 0x0602BB24 RID: 178980 RVA: 0x005F2444 File Offset: 0x005F0644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB25 RID: 178981 RVA: 0x005F2451 File Offset: 0x005F0651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB26 RID: 178982 RVA: 0x005F2458 File Offset: 0x005F0658
		public static IPhotoTargetCaptureUiEachRequiredPoints GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiEachRequiredPoints.GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(_bb, default(IPhotoTargetCaptureUiEachRequiredPoints));
		}

		// Token: 0x0602BB27 RID: 178983 RVA: 0x005F2474 File Offset: 0x005F0674
		public static IPhotoTargetCaptureUiEachRequiredPoints GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(ByteBuffer _bb, IPhotoTargetCaptureUiEachRequiredPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB28 RID: 178984 RVA: 0x005F2491 File Offset: 0x005F0691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB29 RID: 178985 RVA: 0x005F24A0 File Offset: 0x005F06A0
		public IPhotoTargetCaptureUiEachRequiredPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDC5 RID: 48581
		// (get) Token: 0x0602BB2A RID: 178986 RVA: 0x005F24B0 File Offset: 0x005F06B0
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

		// Token: 0x0602BB2B RID: 178987 RVA: 0x005F24EC File Offset: 0x005F06EC
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> CreateIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiEachRequiredPoints.AddType(builder, Type);
			return IPhotoTargetCaptureUiEachRequiredPoints.EndIPhotoTargetCaptureUiEachRequiredPoints(builder);
		}

		// Token: 0x0602BB2C RID: 178988 RVA: 0x005F2502 File Offset: 0x005F0702
		public static void StartIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BB2D RID: 178989 RVA: 0x005F250B File Offset: 0x005F070B
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB2E RID: 178990 RVA: 0x005F2516 File Offset: 0x005F0716
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> EndIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiEachRequiredPoints>(builder.EndTable());
		}

		// Token: 0x0602BB2F RID: 178991 RVA: 0x005F2524 File Offset: 0x005F0724
		public IPhotoTargetCaptureUiEachRequiredPointsT UnPack()
		{
			IPhotoTargetCaptureUiEachRequiredPointsT photoTargetCaptureUiEachRequiredPointsT = new IPhotoTargetCaptureUiEachRequiredPointsT();
			this.UnPackTo(photoTargetCaptureUiEachRequiredPointsT);
			return photoTargetCaptureUiEachRequiredPointsT;
		}

		// Token: 0x0602BB30 RID: 178992 RVA: 0x005F253F File Offset: 0x005F073F
		public void UnPackTo(IPhotoTargetCaptureUiEachRequiredPointsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BB31 RID: 178993 RVA: 0x005F2550 File Offset: 0x005F0750
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiEachRequiredPointsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiEachRequiredPoints>);
			}
			return IPhotoTargetCaptureUiEachRequiredPoints.CreateIPhotoTargetCaptureUiEachRequiredPoints(builder, _o.Type);
		}

		// Token: 0x04010594 RID: 66964
		private Table __p;
	}
}
