using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E36 RID: 24118
	public struct IPhotoTargetCaptureUiEachRequiredPoints : IFlatbufferObject
	{
		// Token: 0x1700B45E RID: 46174
		// (get) Token: 0x0602949A RID: 169114 RVA: 0x005A9714 File Offset: 0x005A7914
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602949B RID: 169115 RVA: 0x005A9721 File Offset: 0x005A7921
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602949C RID: 169116 RVA: 0x005A9728 File Offset: 0x005A7928
		public static IPhotoTargetCaptureUiEachRequiredPoints GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiEachRequiredPoints.GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(_bb, default(IPhotoTargetCaptureUiEachRequiredPoints));
		}

		// Token: 0x0602949D RID: 169117 RVA: 0x005A9744 File Offset: 0x005A7944
		public static IPhotoTargetCaptureUiEachRequiredPoints GetRootAsIPhotoTargetCaptureUiEachRequiredPoints(ByteBuffer _bb, IPhotoTargetCaptureUiEachRequiredPoints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602949E RID: 169118 RVA: 0x005A9761 File Offset: 0x005A7961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602949F RID: 169119 RVA: 0x005A9770 File Offset: 0x005A7970
		public IPhotoTargetCaptureUiEachRequiredPoints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B45F RID: 46175
		// (get) Token: 0x060294A0 RID: 169120 RVA: 0x005A9780 File Offset: 0x005A7980
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

		// Token: 0x060294A1 RID: 169121 RVA: 0x005A97BC File Offset: 0x005A79BC
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> CreateIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiEachRequiredPoints.AddType(builder, Type);
			return IPhotoTargetCaptureUiEachRequiredPoints.EndIPhotoTargetCaptureUiEachRequiredPoints(builder);
		}

		// Token: 0x060294A2 RID: 169122 RVA: 0x005A97D2 File Offset: 0x005A79D2
		public static void StartIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060294A3 RID: 169123 RVA: 0x005A97DB File Offset: 0x005A79DB
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294A4 RID: 169124 RVA: 0x005A97E6 File Offset: 0x005A79E6
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> EndIPhotoTargetCaptureUiEachRequiredPoints(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiEachRequiredPoints>(builder.EndTable());
		}

		// Token: 0x060294A5 RID: 169125 RVA: 0x005A97F4 File Offset: 0x005A79F4
		public IPhotoTargetCaptureUiEachRequiredPointsT UnPack()
		{
			IPhotoTargetCaptureUiEachRequiredPointsT photoTargetCaptureUiEachRequiredPointsT = new IPhotoTargetCaptureUiEachRequiredPointsT();
			this.UnPackTo(photoTargetCaptureUiEachRequiredPointsT);
			return photoTargetCaptureUiEachRequiredPointsT;
		}

		// Token: 0x060294A6 RID: 169126 RVA: 0x005A980F File Offset: 0x005A7A0F
		public void UnPackTo(IPhotoTargetCaptureUiEachRequiredPointsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060294A7 RID: 169127 RVA: 0x005A9820 File Offset: 0x005A7A20
		public static Offset<IPhotoTargetCaptureUiEachRequiredPoints> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiEachRequiredPointsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiEachRequiredPoints>);
			}
			return IPhotoTargetCaptureUiEachRequiredPoints.CreateIPhotoTargetCaptureUiEachRequiredPoints(builder, _o.Type);
		}

		// Token: 0x0400F839 RID: 63545
		private Table __p;
	}
}
