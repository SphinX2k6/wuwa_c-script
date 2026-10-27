using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E73 RID: 28275
	public struct IRenjuChess : IFlatbufferObject
	{
		// Token: 0x1700D29C RID: 53916
		// (get) Token: 0x06031F86 RID: 204678 RVA: 0x006C26D9 File Offset: 0x006C08D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F87 RID: 204679 RVA: 0x006C26E6 File Offset: 0x006C08E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F88 RID: 204680 RVA: 0x006C26F0 File Offset: 0x006C08F0
		public static IRenjuChess GetRootAsIRenjuChess(ByteBuffer _bb)
		{
			return IRenjuChess.GetRootAsIRenjuChess(_bb, default(IRenjuChess));
		}

		// Token: 0x06031F89 RID: 204681 RVA: 0x006C270C File Offset: 0x006C090C
		public static IRenjuChess GetRootAsIRenjuChess(ByteBuffer _bb, IRenjuChess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031F8A RID: 204682 RVA: 0x006C2729 File Offset: 0x006C0929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031F8B RID: 204683 RVA: 0x006C2738 File Offset: 0x006C0938
		public IRenjuChess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D29D RID: 53917
		// (get) Token: 0x06031F8C RID: 204684 RVA: 0x006C2748 File Offset: 0x006C0948
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D29E RID: 53918
		// (get) Token: 0x06031F8D RID: 204685 RVA: 0x006C2784 File Offset: 0x006C0984
		public int Chessboard
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D29F RID: 53919
		// (get) Token: 0x06031F8E RID: 204686 RVA: 0x006C27C0 File Offset: 0x006C09C0
		public TAdjustPlayerCameraOption CameraConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TAdjustPlayerCameraOption.NONE;
				}
				return (TAdjustPlayerCameraOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031F8F RID: 204687 RVA: 0x006C27FC File Offset: 0x006C09FC
		public TTable? CameraConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06031F90 RID: 204688 RVA: 0x006C2844 File Offset: 0x006C0A44
		public IAdjustAxisLockCamera CameraConfigAsIAdjustAxisLockCamera()
		{
			return this.CameraConfig<IAdjustAxisLockCamera>().Value;
		}

		// Token: 0x06031F91 RID: 204689 RVA: 0x006C2860 File Offset: 0x006C0A60
		public IAdjustBasicCamera CameraConfigAsIAdjustBasicCamera()
		{
			return this.CameraConfig<IAdjustBasicCamera>().Value;
		}

		// Token: 0x06031F92 RID: 204690 RVA: 0x006C287C File Offset: 0x006C0A7C
		public IAdjustDialogCamera CameraConfigAsIAdjustDialogCamera()
		{
			return this.CameraConfig<IAdjustDialogCamera>().Value;
		}

		// Token: 0x06031F93 RID: 204691 RVA: 0x006C2898 File Offset: 0x006C0A98
		public IAdjustFirstPersonCamera CameraConfigAsIAdjustFirstPersonCamera()
		{
			return this.CameraConfig<IAdjustFirstPersonCamera>().Value;
		}

		// Token: 0x06031F94 RID: 204692 RVA: 0x006C28B4 File Offset: 0x006C0AB4
		public IAdjustFixedCamera CameraConfigAsIAdjustFixedCamera()
		{
			return this.CameraConfig<IAdjustFixedCamera>().Value;
		}

		// Token: 0x06031F95 RID: 204693 RVA: 0x006C28D0 File Offset: 0x006C0AD0
		public IAdjustFixedLookAtCamera CameraConfigAsIAdjustFixedLookAtCamera()
		{
			return this.CameraConfig<IAdjustFixedLookAtCamera>().Value;
		}

		// Token: 0x06031F96 RID: 204694 RVA: 0x006C28EC File Offset: 0x006C0AEC
		public IAdjustFixedSurveillanceCamera CameraConfigAsIAdjustFixedSurveillanceCamera()
		{
			return this.CameraConfig<IAdjustFixedSurveillanceCamera>().Value;
		}

		// Token: 0x06031F97 RID: 204695 RVA: 0x006C2908 File Offset: 0x006C0B08
		public IAdjustHorizontalCamera CameraConfigAsIAdjustHorizontalCamera()
		{
			return this.CameraConfig<IAdjustHorizontalCamera>().Value;
		}

		// Token: 0x06031F98 RID: 204696 RVA: 0x006C2924 File Offset: 0x006C0B24
		public IAdjustZoneFollowCamera CameraConfigAsIAdjustZoneFollowCamera()
		{
			return this.CameraConfig<IAdjustZoneFollowCamera>().Value;
		}

		// Token: 0x06031F99 RID: 204697 RVA: 0x006C293F File Offset: 0x006C0B3F
		public static Offset<IRenjuChess> CreateIRenjuChess(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Chessboard = 0, TAdjustPlayerCameraOption CameraConfig_type = TAdjustPlayerCameraOption.NONE, int CameraConfigOffset = 0)
		{
			builder.StartTable(4);
			IRenjuChess.AddCameraConfig(builder, CameraConfigOffset);
			IRenjuChess.AddChessboard(builder, Chessboard);
			IRenjuChess.AddCameraConfigType(builder, CameraConfig_type);
			IRenjuChess.AddType(builder, Type);
			return IRenjuChess.EndIRenjuChess(builder);
		}

		// Token: 0x06031F9A RID: 204698 RVA: 0x006C296B File Offset: 0x006C0B6B
		public static void StartIRenjuChess(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031F9B RID: 204699 RVA: 0x006C2974 File Offset: 0x006C0B74
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031F9C RID: 204700 RVA: 0x006C297F File Offset: 0x006C0B7F
		public static void AddChessboard(FlatBufferBuilder builder, int chessboard)
		{
			builder.AddInt(1, chessboard, 0);
		}

		// Token: 0x06031F9D RID: 204701 RVA: 0x006C298A File Offset: 0x006C0B8A
		public static void AddCameraConfigType(FlatBufferBuilder builder, TAdjustPlayerCameraOption cameraConfigType)
		{
			builder.AddByte(2, (byte)cameraConfigType, 0);
		}

		// Token: 0x06031F9E RID: 204702 RVA: 0x006C2995 File Offset: 0x006C0B95
		public static void AddCameraConfig(FlatBufferBuilder builder, int cameraConfigOffset)
		{
			builder.AddOffset(3, cameraConfigOffset, 0);
		}

		// Token: 0x06031F9F RID: 204703 RVA: 0x006C29A0 File Offset: 0x006C0BA0
		public static Offset<IRenjuChess> EndIRenjuChess(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuChess>(builder.EndTable());
		}

		// Token: 0x06031FA0 RID: 204704 RVA: 0x006C29B0 File Offset: 0x006C0BB0
		public IRenjuChessT UnPack()
		{
			IRenjuChessT renjuChessT = new IRenjuChessT();
			this.UnPackTo(renjuChessT);
			return renjuChessT;
		}

		// Token: 0x06031FA1 RID: 204705 RVA: 0x006C29CC File Offset: 0x006C0BCC
		public void UnPackTo(IRenjuChessT _o)
		{
			_o.Type = this.Type;
			_o.Chessboard = this.Chessboard;
			_o.CameraConfig = new TAdjustPlayerCameraOptionUnion();
			_o.CameraConfig.Type = this.CameraConfigType;
			switch (this.CameraConfigType)
			{
			case TAdjustPlayerCameraOption.IAdjustAxisLockCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustAxisLockCamera>() != null) ? this.CameraConfig<IAdjustAxisLockCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustBasicCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustBasicCamera>() != null) ? this.CameraConfig<IAdjustBasicCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustDialogCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustDialogCamera>() != null) ? this.CameraConfig<IAdjustDialogCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFirstPersonCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustFirstPersonCamera>() != null) ? this.CameraConfig<IAdjustFirstPersonCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustFixedCamera>() != null) ? this.CameraConfig<IAdjustFixedCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedLookAtCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustFixedLookAtCamera>() != null) ? this.CameraConfig<IAdjustFixedLookAtCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustFixedSurveillanceCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustFixedSurveillanceCamera>() != null) ? this.CameraConfig<IAdjustFixedSurveillanceCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustHorizontalCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustHorizontalCamera>() != null) ? this.CameraConfig<IAdjustHorizontalCamera>().Value.UnPack() : null);
				return;
			case TAdjustPlayerCameraOption.IAdjustZoneFollowCamera:
				_o.CameraConfig.Value = ((this.CameraConfig<IAdjustZoneFollowCamera>() != null) ? this.CameraConfig<IAdjustZoneFollowCamera>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06031FA2 RID: 204706 RVA: 0x006C2C34 File Offset: 0x006C0E34
		public static Offset<IRenjuChess> Pack(FlatBufferBuilder builder, IRenjuChessT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenjuChess>);
			}
			TAdjustPlayerCameraOption cameraConfig_type = (_o.CameraConfig == null) ? TAdjustPlayerCameraOption.NONE : _o.CameraConfig.Type;
			int cameraConfigOffset = (_o.CameraConfig == null) ? 0 : TAdjustPlayerCameraOptionUnion.Pack(builder, _o.CameraConfig);
			return IRenjuChess.CreateIRenjuChess(builder, _o.Type, _o.Chessboard, cameraConfig_type, cameraConfigOffset);
		}

		// Token: 0x04011860 RID: 71776
		private Table __p;
	}
}
