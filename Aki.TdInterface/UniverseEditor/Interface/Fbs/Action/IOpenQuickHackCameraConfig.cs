using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007388 RID: 29576
	public struct IOpenQuickHackCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700D8F5 RID: 55541
		// (get) Token: 0x06033A31 RID: 211505 RVA: 0x006F5E0C File Offset: 0x006F400C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033A32 RID: 211506 RVA: 0x006F5E19 File Offset: 0x006F4019
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033A33 RID: 211507 RVA: 0x006F5E20 File Offset: 0x006F4020
		public static IOpenQuickHackCameraConfig GetRootAsIOpenQuickHackCameraConfig(ByteBuffer _bb)
		{
			return IOpenQuickHackCameraConfig.GetRootAsIOpenQuickHackCameraConfig(_bb, default(IOpenQuickHackCameraConfig));
		}

		// Token: 0x06033A34 RID: 211508 RVA: 0x006F5E3C File Offset: 0x006F403C
		public static IOpenQuickHackCameraConfig GetRootAsIOpenQuickHackCameraConfig(ByteBuffer _bb, IOpenQuickHackCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033A35 RID: 211509 RVA: 0x006F5E59 File Offset: 0x006F4059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033A36 RID: 211510 RVA: 0x006F5E68 File Offset: 0x006F4068
		public IOpenQuickHackCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8F6 RID: 55542
		// (get) Token: 0x06033A37 RID: 211511 RVA: 0x006F5E78 File Offset: 0x006F4078
		public bool AutoOpenSystem
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D8F7 RID: 55543
		// (get) Token: 0x06033A38 RID: 211512 RVA: 0x006F5EB8 File Offset: 0x006F40B8
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

		// Token: 0x1700D8F8 RID: 55544
		// (get) Token: 0x06033A39 RID: 211513 RVA: 0x006F5F18 File Offset: 0x006F4118
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

		// Token: 0x1700D8F9 RID: 55545
		// (get) Token: 0x06033A3A RID: 211514 RVA: 0x006F5F78 File Offset: 0x006F4178
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

		// Token: 0x1700D8FA RID: 55546
		// (get) Token: 0x06033A3B RID: 211515 RVA: 0x006F5FD8 File Offset: 0x006F41D8
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

		// Token: 0x06033A3C RID: 211516 RVA: 0x006F6015 File Offset: 0x006F4215
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

		// Token: 0x06033A3D RID: 211517 RVA: 0x006F6049 File Offset: 0x006F4249
		public static void StartIOpenQuickHackCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033A3E RID: 211518 RVA: 0x006F6052 File Offset: 0x006F4252
		public static void AddAutoOpenSystem(FlatBufferBuilder builder, bool autoOpenSystem)
		{
			builder.AddBool(0, autoOpenSystem, false);
		}

		// Token: 0x06033A3F RID: 211519 RVA: 0x006F605D File Offset: 0x006F425D
		public static void AddRelativePos(FlatBufferBuilder builder, Offset<IVectorInfo> relativePosOffset)
		{
			builder.AddOffset(1, relativePosOffset.Value, 0);
		}

		// Token: 0x06033A40 RID: 211520 RVA: 0x006F606D File Offset: 0x006F426D
		public static void AddFovConfig(FlatBufferBuilder builder, Offset<IOpenQuickHackCameraFovConfig> fovConfigOffset)
		{
			builder.AddOffset(2, fovConfigOffset.Value, 0);
		}

		// Token: 0x06033A41 RID: 211521 RVA: 0x006F607D File Offset: 0x006F427D
		public static void AddRotateConfig(FlatBufferBuilder builder, Offset<IAdjustFixedCameraRotateConfig> rotateConfigOffset)
		{
			builder.AddOffset(3, rotateConfigOffset.Value, 0);
		}

		// Token: 0x06033A42 RID: 211522 RVA: 0x006F608D File Offset: 0x006F428D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06033A43 RID: 211523 RVA: 0x006F6098 File Offset: 0x006F4298
		public static Offset<IOpenQuickHackCameraConfig> EndIOpenQuickHackCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOpenQuickHackCameraConfig>(builder.EndTable());
		}

		// Token: 0x06033A44 RID: 211524 RVA: 0x006F60A8 File Offset: 0x006F42A8
		public IOpenQuickHackCameraConfigT UnPack()
		{
			IOpenQuickHackCameraConfigT openQuickHackCameraConfigT = new IOpenQuickHackCameraConfigT();
			this.UnPackTo(openQuickHackCameraConfigT);
			return openQuickHackCameraConfigT;
		}

		// Token: 0x06033A45 RID: 211525 RVA: 0x006F60C4 File Offset: 0x006F42C4
		public void UnPackTo(IOpenQuickHackCameraConfigT _o)
		{
			_o.AutoOpenSystem = this.AutoOpenSystem;
			_o.RelativePos = ((this.RelativePos != null) ? this.RelativePos.Value.UnPack() : null);
			_o.FovConfig = ((this.FovConfig != null) ? this.FovConfig.Value.UnPack() : null);
			_o.RotateConfig = ((this.RotateConfig != null) ? this.RotateConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033A46 RID: 211526 RVA: 0x006F617C File Offset: 0x006F437C
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

		// Token: 0x0401247F RID: 74879
		private Table __p;
	}
}
