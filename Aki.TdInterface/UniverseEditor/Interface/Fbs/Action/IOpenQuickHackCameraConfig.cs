using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C21 RID: 27681
	public struct IOpenQuickHackCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CDDA RID: 52698
		// (get) Token: 0x06030ADD RID: 199389 RVA: 0x0069BB10 File Offset: 0x00699D10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030ADE RID: 199390 RVA: 0x0069BB1D File Offset: 0x00699D1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030ADF RID: 199391 RVA: 0x0069BB24 File Offset: 0x00699D24
		public static IOpenQuickHackCameraConfig GetRootAsIOpenQuickHackCameraConfig(ByteBuffer _bb)
		{
			return IOpenQuickHackCameraConfig.GetRootAsIOpenQuickHackCameraConfig(_bb, default(IOpenQuickHackCameraConfig));
		}

		// Token: 0x06030AE0 RID: 199392 RVA: 0x0069BB40 File Offset: 0x00699D40
		public static IOpenQuickHackCameraConfig GetRootAsIOpenQuickHackCameraConfig(ByteBuffer _bb, IOpenQuickHackCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030AE1 RID: 199393 RVA: 0x0069BB5D File Offset: 0x00699D5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030AE2 RID: 199394 RVA: 0x0069BB6C File Offset: 0x00699D6C
		public IOpenQuickHackCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDDB RID: 52699
		// (get) Token: 0x06030AE3 RID: 199395 RVA: 0x0069BB7C File Offset: 0x00699D7C
		public bool AutoOpenSystem
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CDDC RID: 52700
		// (get) Token: 0x06030AE4 RID: 199396 RVA: 0x0069BBBC File Offset: 0x00699DBC
		public IVectorInfo? RelativePos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CDDD RID: 52701
		// (get) Token: 0x06030AE5 RID: 199397 RVA: 0x0069BC1C File Offset: 0x00699E1C
		public IOpenQuickHackCameraFovConfig? FovConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IOpenQuickHackCameraFovConfig?(default(IOpenQuickHackCameraFovConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CDDE RID: 52702
		// (get) Token: 0x06030AE6 RID: 199398 RVA: 0x0069BC7C File Offset: 0x00699E7C
		public IAdjustFixedCameraRotateConfig? RotateConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IAdjustFixedCameraRotateConfig?(default(IAdjustFixedCameraRotateConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CDDF RID: 52703
		// (get) Token: 0x06030AE7 RID: 199399 RVA: 0x0069BCDC File Offset: 0x00699EDC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030AE8 RID: 199400 RVA: 0x0069BD19 File Offset: 0x00699F19
		public static Offset<IOpenQuickHackCameraConfig> CreateIOpenQuickHackCameraConfig(FlatBufferBuilder builder, bool AutoOpenSystem = false, Offset<IVectorInfo> RelativePosOffset = default(Offset<IVectorInfo>), Offset<IOpenQuickHackCameraFovConfig> FovConfigOffset = default(Offset<IOpenQuickHackCameraFovConfig>), Offset<IAdjustFixedCameraRotateConfig> RotateConfigOffset = default(Offset<IAdjustFixedCameraRotateConfig>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IOpenQuickHackCameraConfig.AddRotateConfig(builder, RotateConfigOffset);
			IOpenQuickHackCameraConfig.AddFovConfig(builder, FovConfigOffset);
			IOpenQuickHackCameraConfig.AddRelativePos(builder, RelativePosOffset);
			IOpenQuickHackCameraConfig.AddNullMask(builder, NullMask);
			IOpenQuickHackCameraConfig.AddAutoOpenSystem(builder, AutoOpenSystem);
			return IOpenQuickHackCameraConfig.EndIOpenQuickHackCameraConfig(builder);
		}

		// Token: 0x06030AE9 RID: 199401 RVA: 0x0069BD4D File Offset: 0x00699F4D
		public static void StartIOpenQuickHackCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030AEA RID: 199402 RVA: 0x0069BD56 File Offset: 0x00699F56
		public static void AddAutoOpenSystem(FlatBufferBuilder builder, bool autoOpenSystem)
		{
			builder.AddBool(0, autoOpenSystem, false);
		}

		// Token: 0x06030AEB RID: 199403 RVA: 0x0069BD61 File Offset: 0x00699F61
		public static void AddRelativePos(FlatBufferBuilder builder, Offset<IVectorInfo> relativePosOffset)
		{
			builder.AddOffset(1, relativePosOffset.Value, 0);
		}

		// Token: 0x06030AEC RID: 199404 RVA: 0x0069BD71 File Offset: 0x00699F71
		public static void AddFovConfig(FlatBufferBuilder builder, Offset<IOpenQuickHackCameraFovConfig> fovConfigOffset)
		{
			builder.AddOffset(2, fovConfigOffset.Value, 0);
		}

		// Token: 0x06030AED RID: 199405 RVA: 0x0069BD81 File Offset: 0x00699F81
		public static void AddRotateConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset)
		{
			builder.AddOffset(3, rotateConfigOffset.Value, 0);
		}

		// Token: 0x06030AEE RID: 199406 RVA: 0x0069BD91 File Offset: 0x00699F91
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06030AEF RID: 199407 RVA: 0x0069BD9C File Offset: 0x00699F9C
		public static Offset<IOpenQuickHackCameraConfig> EndIOpenQuickHackCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackCameraConfig>(builder.EndTable());
		}

		// Token: 0x06030AF0 RID: 199408 RVA: 0x0069BDAC File Offset: 0x00699FAC
		public IOpenQuickHackCameraConfigT UnPack()
		{
			IOpenQuickHackCameraConfigT openQuickHackCameraConfigT = new IOpenQuickHackCameraConfigT();
			this.UnPackTo(openQuickHackCameraConfigT);
			return openQuickHackCameraConfigT;
		}

		// Token: 0x06030AF1 RID: 199409 RVA: 0x0069BDC8 File Offset: 0x00699FC8
		public void UnPackTo(IOpenQuickHackCameraConfigT _o)
		{
			_o.AutoOpenSystem = this.AutoOpenSystem;
			_o.RelativePos = ((this.RelativePos != null) ? this.RelativePos.Value.UnPack() : null);
			_o.FovConfig = ((this.FovConfig != null) ? this.FovConfig.Value.UnPack() : null);
			_o.RotateConfig = ((this.RotateConfig != null) ? this.RotateConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030AF2 RID: 199410 RVA: 0x0069BE80 File Offset: 0x0069A080
		public static Offset<IOpenQuickHackCameraConfig> Pack(FlatBufferBuilder builder, IOpenQuickHackCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenQuickHackCameraConfig>);
			}
			Offset<IVectorInfo> relativePosOffset = (_o.RelativePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePos);
			Offset<IOpenQuickHackCameraFovConfig> fovConfigOffset = (_o.FovConfig == null) ? default(Offset<IOpenQuickHackCameraFovConfig>) : IOpenQuickHackCameraFovConfig.Pack(builder, _o.FovConfig);
			Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset = (_o.RotateConfig == null) ? default(Offset<IAdjustFixedCameraRotateConfig>) : IAdjustFixedCameraRotateConfig.Pack(builder, _o.RotateConfig);
			return IOpenQuickHackCameraConfig.CreateIOpenQuickHackCameraConfig(builder, _o.AutoOpenSystem, relativePosOffset, fovConfigOffset, rotateConfigOffset, _o.NullMask);
		}

		// Token: 0x04011528 RID: 70952
		private Table __p;
	}
}
