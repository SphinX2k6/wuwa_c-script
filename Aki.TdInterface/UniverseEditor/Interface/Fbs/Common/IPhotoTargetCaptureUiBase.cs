using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E2D RID: 24109
	public struct IPhotoTargetCaptureUiBase : IFlatbufferObject
	{
		// Token: 0x1700B454 RID: 46164
		// (get) Token: 0x0602945A RID: 169050 RVA: 0x005A9026 File Offset: 0x005A7226
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602945B RID: 169051 RVA: 0x005A9033 File Offset: 0x005A7233
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602945C RID: 169052 RVA: 0x005A903C File Offset: 0x005A723C
		public static IPhotoTargetCaptureUiBase GetRootAsIPhotoTargetCaptureUiBase(ByteBuffer _bb)
		{
			return IPhotoTargetCaptureUiBase.GetRootAsIPhotoTargetCaptureUiBase(_bb, default(IPhotoTargetCaptureUiBase));
		}

		// Token: 0x0602945D RID: 169053 RVA: 0x005A9058 File Offset: 0x005A7258
		public static IPhotoTargetCaptureUiBase GetRootAsIPhotoTargetCaptureUiBase(ByteBuffer _bb, IPhotoTargetCaptureUiBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602945E RID: 169054 RVA: 0x005A9075 File Offset: 0x005A7275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602945F RID: 169055 RVA: 0x005A9084 File Offset: 0x005A7284
		public IPhotoTargetCaptureUiBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B455 RID: 46165
		// (get) Token: 0x06029460 RID: 169056 RVA: 0x005A9094 File Offset: 0x005A7294
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

		// Token: 0x06029461 RID: 169057 RVA: 0x005A90D0 File Offset: 0x005A72D0
		public static Offset<IPhotoTargetCaptureUiBase> CreateIPhotoTargetCaptureUiBase(FlatBufferBuilder builder, EPhotoTargetCaptureUiType Type = EPhotoTargetCaptureUiType.RequiredPointsCenter)
		{
			builder.StartTable(1);
			IPhotoTargetCaptureUiBase.AddType(builder, Type);
			return IPhotoTargetCaptureUiBase.EndIPhotoTargetCaptureUiBase(builder);
		}

		// Token: 0x06029462 RID: 169058 RVA: 0x005A90E6 File Offset: 0x005A72E6
		public static void StartIPhotoTargetCaptureUiBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029463 RID: 169059 RVA: 0x005A90EF File Offset: 0x005A72EF
		public static void AddType(FlatBufferBuilder builder, EPhotoTargetCaptureUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029464 RID: 169060 RVA: 0x005A90FA File Offset: 0x005A72FA
		public static Offset<IPhotoTargetCaptureUiBase> EndIPhotoTargetCaptureUiBase(FlatBufferBuilder builder)
		{
			return new Offset<IPhotoTargetCaptureUiBase>(builder.EndTable());
		}

		// Token: 0x06029465 RID: 169061 RVA: 0x005A9108 File Offset: 0x005A7308
		public IPhotoTargetCaptureUiBaseT UnPack()
		{
			IPhotoTargetCaptureUiBaseT photoTargetCaptureUiBaseT = new IPhotoTargetCaptureUiBaseT();
			this.UnPackTo(photoTargetCaptureUiBaseT);
			return photoTargetCaptureUiBaseT;
		}

		// Token: 0x06029466 RID: 169062 RVA: 0x005A9123 File Offset: 0x005A7323
		public void UnPackTo(IPhotoTargetCaptureUiBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029467 RID: 169063 RVA: 0x005A9134 File Offset: 0x005A7334
		public static Offset<IPhotoTargetCaptureUiBase> Pack(FlatBufferBuilder builder, IPhotoTargetCaptureUiBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotoTargetCaptureUiBase>);
			}
			return IPhotoTargetCaptureUiBase.CreateIPhotoTargetCaptureUiBase(builder, _o.Type);
		}

		// Token: 0x0400F82B RID: 63531
		private Table __p;
	}
}
