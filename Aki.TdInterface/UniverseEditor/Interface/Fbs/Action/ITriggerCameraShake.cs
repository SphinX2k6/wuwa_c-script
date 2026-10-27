using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007472 RID: 29810
	public struct ITriggerCameraShake : IFlatbufferObject
	{
		// Token: 0x1700E23D RID: 57917
		// (get) Token: 0x0603627E RID: 221822 RVA: 0x0075CE33 File Offset: 0x0075B033
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603627F RID: 221823 RVA: 0x0075CE40 File Offset: 0x0075B040
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036280 RID: 221824 RVA: 0x0075CE48 File Offset: 0x0075B048
		public static ITriggerCameraShake GetRootAsITriggerCameraShake(ByteBuffer _bb)
		{
			return ITriggerCameraShake.GetRootAsITriggerCameraShake(_bb, default(ITriggerCameraShake));
		}

		// Token: 0x06036281 RID: 221825 RVA: 0x0075CE64 File Offset: 0x0075B064
		public static ITriggerCameraShake GetRootAsITriggerCameraShake(ByteBuffer _bb, ITriggerCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036282 RID: 221826 RVA: 0x0075CE81 File Offset: 0x0075B081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036283 RID: 221827 RVA: 0x0075CE90 File Offset: 0x0075B090
		public ITriggerCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E23E RID: 57918
		// (get) Token: 0x06036284 RID: 221828 RVA: 0x0075CEA0 File Offset: 0x0075B0A0
		public TCameraShakeConfig CameraShakeConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCameraShakeConfig.NONE;
				}
				return (TCameraShakeConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036285 RID: 221829 RVA: 0x0075CEDC File Offset: 0x0075B0DC
		public TTable? CameraShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036286 RID: 221830 RVA: 0x0075CF20 File Offset: 0x0075B120
		public IConstantCameraShake CameraShakeConfigAsIConstantCameraShake()
		{
			return this.CameraShakeConfig<IConstantCameraShake>().Value;
		}

		// Token: 0x06036287 RID: 221831 RVA: 0x0075CF3C File Offset: 0x0075B13C
		public ILinearOverRangeCameraShake CameraShakeConfigAsILinearOverRangeCameraShake()
		{
			return this.CameraShakeConfig<ILinearOverRangeCameraShake>().Value;
		}

		// Token: 0x1700E23F RID: 57919
		// (get) Token: 0x06036288 RID: 221832 RVA: 0x0075CF58 File Offset: 0x0075B158
		public string CameraShakeBp
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036289 RID: 221833 RVA: 0x0075CF8F File Offset: 0x0075B18F
		public Span<byte> GetCameraShakeBpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603628A RID: 221834 RVA: 0x0075CF9E File Offset: 0x0075B19E
		public byte[] GetCameraShakeBpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603628B RID: 221835 RVA: 0x0075CFAC File Offset: 0x0075B1AC
		public static Offset<ITriggerCameraShake> CreateITriggerCameraShake(FlatBufferBuilder builder, TCameraShakeConfig CameraShakeConfig_type = TCameraShakeConfig.NONE, int CameraShakeConfigOffset = 0, StringOffset CameraShakeBpOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITriggerCameraShake.AddCameraShakeBp(builder, CameraShakeBpOffset);
			ITriggerCameraShake.AddCameraShakeConfig(builder, CameraShakeConfigOffset);
			ITriggerCameraShake.AddCameraShakeConfigType(builder, CameraShakeConfig_type);
			return ITriggerCameraShake.EndITriggerCameraShake(builder);
		}

		// Token: 0x0603628C RID: 221836 RVA: 0x0075CFD0 File Offset: 0x0075B1D0
		public static void StartITriggerCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603628D RID: 221837 RVA: 0x0075CFD9 File Offset: 0x0075B1D9
		public static void AddCameraShakeConfigType(FlatBufferBuilder builder, TCameraShakeConfig cameraShakeConfigType)
		{
			builder.AddByte(0, (byte)cameraShakeConfigType, 0);
		}

		// Token: 0x0603628E RID: 221838 RVA: 0x0075CFE4 File Offset: 0x0075B1E4
		public static void AddCameraShakeConfig(FlatBufferBuilder builder, int cameraShakeConfigOffset)
		{
			builder.AddOffset(1, cameraShakeConfigOffset, 0);
		}

		// Token: 0x0603628F RID: 221839 RVA: 0x0075CFEF File Offset: 0x0075B1EF
		public static void AddCameraShakeBp(FlatBufferBuilder builder, StringOffset cameraShakeBpOffset)
		{
			builder.AddOffset(2, cameraShakeBpOffset.Value, 0);
		}

		// Token: 0x06036290 RID: 221840 RVA: 0x0075CFFF File Offset: 0x0075B1FF
		public static Offset<ITriggerCameraShake> EndITriggerCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerCameraShake>(builder.EndTable());
		}

		// Token: 0x06036291 RID: 221841 RVA: 0x0075D00C File Offset: 0x0075B20C
		public ITriggerCameraShakeT UnPack()
		{
			ITriggerCameraShakeT triggerCameraShakeT = new ITriggerCameraShakeT();
			this.UnPackTo(triggerCameraShakeT);
			return triggerCameraShakeT;
		}

		// Token: 0x06036292 RID: 221842 RVA: 0x0075D028 File Offset: 0x0075B228
		public void UnPackTo(ITriggerCameraShakeT _o)
		{
			_o.CameraShakeConfig = new TCameraShakeConfigUnion();
			_o.CameraShakeConfig.Type = this.CameraShakeConfigType;
			TCameraShakeConfig cameraShakeConfigType = this.CameraShakeConfigType;
			if (cameraShakeConfigType != TCameraShakeConfig.IConstantCameraShake)
			{
				if (cameraShakeConfigType == TCameraShakeConfig.ILinearOverRangeCameraShake)
				{
					_o.CameraShakeConfig.Value = ((this.CameraShakeConfig<ILinearOverRangeCameraShake>() != null) ? this.CameraShakeConfig<ILinearOverRangeCameraShake>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CameraShakeConfig.Value = ((this.CameraShakeConfig<IConstantCameraShake>() != null) ? this.CameraShakeConfig<IConstantCameraShake>().Value.UnPack() : null);
			}
			_o.CameraShakeBp = this.CameraShakeBp;
		}

		// Token: 0x06036293 RID: 221843 RVA: 0x0075D0DC File Offset: 0x0075B2DC
		public static Offset<ITriggerCameraShake> Pack(FlatBufferBuilder builder, ITriggerCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerCameraShake>);
			}
			TCameraShakeConfig cameraShakeConfig_type = (_o.CameraShakeConfig == null) ? TCameraShakeConfig.NONE : _o.CameraShakeConfig.Type;
			int cameraShakeConfigOffset = (_o.CameraShakeConfig == null) ? 0 : TCameraShakeConfigUnion.Pack(builder, _o.CameraShakeConfig);
			StringOffset cameraShakeBpOffset = (_o.CameraShakeBp == null) ? default(StringOffset) : builder.CreateString(_o.CameraShakeBp);
			return ITriggerCameraShake.CreateITriggerCameraShake(builder, cameraShakeConfig_type, cameraShakeConfigOffset, cameraShakeBpOffset);
		}

		// Token: 0x040122FD RID: 74493
		private Table __p;
	}
}
