using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F7 RID: 30199
	public struct IRenjuChess : IFlatbufferObject
	{
		// Token: 0x1700DDF3 RID: 56819
		// (get) Token: 0x06034FC6 RID: 217030 RVA: 0x0071E40D File Offset: 0x0071C60D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034FC7 RID: 217031 RVA: 0x0071E41A File Offset: 0x0071C61A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034FC8 RID: 217032 RVA: 0x0071E424 File Offset: 0x0071C624
		public static IRenjuChess GetRootAsIRenjuChess(ByteBuffer _bb)
		{
			return IRenjuChess.GetRootAsIRenjuChess(_bb, default(IRenjuChess));
		}

		// Token: 0x06034FC9 RID: 217033 RVA: 0x0071E440 File Offset: 0x0071C640
		public static IRenjuChess GetRootAsIRenjuChess(ByteBuffer _bb, IRenjuChess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034FCA RID: 217034 RVA: 0x0071E45D File Offset: 0x0071C65D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034FCB RID: 217035 RVA: 0x0071E46C File Offset: 0x0071C66C
		public IRenjuChess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDF4 RID: 56820
		// (get) Token: 0x06034FCC RID: 217036 RVA: 0x0071E47C File Offset: 0x0071C67C
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

		// Token: 0x1700DDF5 RID: 56821
		// (get) Token: 0x06034FCD RID: 217037 RVA: 0x0071E4B8 File Offset: 0x0071C6B8
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

		// Token: 0x1700DDF6 RID: 56822
		// (get) Token: 0x06034FCE RID: 217038 RVA: 0x0071E4F4 File Offset: 0x0071C6F4
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

		// Token: 0x06034FCF RID: 217039 RVA: 0x0071E530 File Offset: 0x0071C730
		public TTable? CameraConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06034FD0 RID: 217040 RVA: 0x0071E578 File Offset: 0x0071C778
		public IAdjustAxisLockCamera CameraConfigAsIAdjustAxisLockCamera()
		{
			return this.CameraConfig<IAdjustAxisLockCamera>().Value;
		}

		// Token: 0x06034FD1 RID: 217041 RVA: 0x0071E594 File Offset: 0x0071C794
		public IAdjustBasicCamera CameraConfigAsIAdjustBasicCamera()
		{
			return this.CameraConfig<IAdjustBasicCamera>().Value;
		}

		// Token: 0x06034FD2 RID: 217042 RVA: 0x0071E5B0 File Offset: 0x0071C7B0
		public IAdjustDialogCamera CameraConfigAsIAdjustDialogCamera()
		{
			return this.CameraConfig<IAdjustDialogCamera>().Value;
		}

		// Token: 0x06034FD3 RID: 217043 RVA: 0x0071E5CC File Offset: 0x0071C7CC
		public IAdjustFirstPersonCamera CameraConfigAsIAdjustFirstPersonCamera()
		{
			return this.CameraConfig<IAdjustFirstPersonCamera>().Value;
		}

		// Token: 0x06034FD4 RID: 217044 RVA: 0x0071E5E8 File Offset: 0x0071C7E8
		public IAdjustFixedCamera CameraConfigAsIAdjustFixedCamera()
		{
			return this.CameraConfig<IAdjustFixedCamera>().Value;
		}

		// Token: 0x06034FD5 RID: 217045 RVA: 0x0071E604 File Offset: 0x0071C804
		public IAdjustFixedLookAtCamera CameraConfigAsIAdjustFixedLookAtCamera()
		{
			return this.CameraConfig<IAdjustFixedLookAtCamera>().Value;
		}

		// Token: 0x06034FD6 RID: 217046 RVA: 0x0071E620 File Offset: 0x0071C820
		public IAdjustFixedSurveillanceCamera CameraConfigAsIAdjustFixedSurveillanceCamera()
		{
			return this.CameraConfig<IAdjustFixedSurveillanceCamera>().Value;
		}

		// Token: 0x06034FD7 RID: 217047 RVA: 0x0071E63C File Offset: 0x0071C83C
		public IAdjustHorizontalCamera CameraConfigAsIAdjustHorizontalCamera()
		{
			return this.CameraConfig<IAdjustHorizontalCamera>().Value;
		}

		// Token: 0x06034FD8 RID: 217048 RVA: 0x0071E658 File Offset: 0x0071C858
		public IAdjustZoneFollowCamera CameraConfigAsIAdjustZoneFollowCamera()
		{
			return this.CameraConfig<IAdjustZoneFollowCamera>().Value;
		}

		// Token: 0x06034FD9 RID: 217049 RVA: 0x0071E673 File Offset: 0x0071C873
		public static Offset<IRenjuChess> CreateIRenjuChess(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int Chessboard = 0, TAdjustPlayerCameraOption CameraConfig_type = TAdjustPlayerCameraOption.NONE, int CameraConfigOffset = 0)
		{
			builder.StartTable(4);
			IRenjuChess.AddCameraConfig(builder, CameraConfigOffset);
			IRenjuChess.AddChessboard(builder, Chessboard);
			IRenjuChess.AddCameraConfigType(builder, CameraConfig_type);
			IRenjuChess.AddType(builder, Type);
			return IRenjuChess.EndIRenjuChess(builder);
		}

		// Token: 0x06034FDA RID: 217050 RVA: 0x0071E69F File Offset: 0x0071C89F
		public static void StartIRenjuChess(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034FDB RID: 217051 RVA: 0x0071E6A8 File Offset: 0x0071C8A8
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034FDC RID: 217052 RVA: 0x0071E6B3 File Offset: 0x0071C8B3
		public static void AddChessboard(FlatBufferBuilder builder, int chessboard)
		{
			builder.AddInt(1, chessboard, 0);
		}

		// Token: 0x06034FDD RID: 217053 RVA: 0x0071E6BE File Offset: 0x0071C8BE
		public static void AddCameraConfigType(FlatBufferBuilder builder, TAdjustPlayerCameraOption cameraConfigType)
		{
			builder.AddByte(2, (byte)cameraConfigType, 0);
		}

		// Token: 0x06034FDE RID: 217054 RVA: 0x0071E6C9 File Offset: 0x0071C8C9
		public static void AddCameraConfig(FlatBufferBuilder builder, int cameraConfigOffset)
		{
			builder.AddOffset(3, cameraConfigOffset, 0);
		}

		// Token: 0x06034FDF RID: 217055 RVA: 0x0071E6D4 File Offset: 0x0071C8D4
		public static Offset<IRenjuChess> EndIRenjuChess(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuChess>(builder.EndTable());
		}

		// Token: 0x06034FE0 RID: 217056 RVA: 0x0071E6E4 File Offset: 0x0071C8E4
		public IRenjuChessT UnPack()
		{
			IRenjuChessT renjuChessT = new IRenjuChessT();
			this.UnPackTo(renjuChessT);
			return renjuChessT;
		}

		// Token: 0x06034FE1 RID: 217057 RVA: 0x0071E700 File Offset: 0x0071C900
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

		// Token: 0x06034FE2 RID: 217058 RVA: 0x0071E968 File Offset: 0x0071CB68
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

		// Token: 0x040127E5 RID: 75749
		private Table __p;
	}
}
