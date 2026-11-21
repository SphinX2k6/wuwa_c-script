using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C65 RID: 31845
	public struct ITriggerCameraShake : IFlatbufferObject
	{
		// Token: 0x1700EE5A RID: 61018
		// (get) Token: 0x06039667 RID: 235111 RVA: 0x007BFB5F File Offset: 0x007BDD5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039668 RID: 235112 RVA: 0x007BFB6C File Offset: 0x007BDD6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039669 RID: 235113 RVA: 0x007BFB74 File Offset: 0x007BDD74
		public static ITriggerCameraShake GetRootAsITriggerCameraShake(ByteBuffer _bb)
		{
			return ITriggerCameraShake.GetRootAsITriggerCameraShake(_bb, default(ITriggerCameraShake));
		}

		// Token: 0x0603966A RID: 235114 RVA: 0x007BFB90 File Offset: 0x007BDD90
		public static ITriggerCameraShake GetRootAsITriggerCameraShake(ByteBuffer _bb, ITriggerCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603966B RID: 235115 RVA: 0x007BFBAD File Offset: 0x007BDDAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603966C RID: 235116 RVA: 0x007BFBBC File Offset: 0x007BDDBC
		public ITriggerCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE5B RID: 61019
		// (get) Token: 0x0603966D RID: 235117 RVA: 0x007BFBCC File Offset: 0x007BDDCC
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

		// Token: 0x0603966E RID: 235118 RVA: 0x007BFC08 File Offset: 0x007BDE08
		public TTable? CameraShakeConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603966F RID: 235119 RVA: 0x007BFC4C File Offset: 0x007BDE4C
		public IConstantCameraShake CameraShakeConfigAsIConstantCameraShake()
		{
			return this.CameraShakeConfig<IConstantCameraShake>().Value;
		}

		// Token: 0x06039670 RID: 235120 RVA: 0x007BFC68 File Offset: 0x007BDE68
		public ILinearOverRangeCameraShake CameraShakeConfigAsILinearOverRangeCameraShake()
		{
			return this.CameraShakeConfig<ILinearOverRangeCameraShake>().Value;
		}

		// Token: 0x1700EE5C RID: 61020
		// (get) Token: 0x06039671 RID: 235121 RVA: 0x007BFC84 File Offset: 0x007BDE84
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

		// Token: 0x06039672 RID: 235122 RVA: 0x007BFCBB File Offset: 0x007BDEBB
		public Span<byte> GetCameraShakeBpBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06039673 RID: 235123 RVA: 0x007BFCCA File Offset: 0x007BDECA
		public byte[] GetCameraShakeBpArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06039674 RID: 235124 RVA: 0x007BFCD8 File Offset: 0x007BDED8
		public static Offset<ITriggerCameraShake> CreateITriggerCameraShake(FlatBufferBuilder builder, TCameraShakeConfig CameraShakeConfig_type = TCameraShakeConfig.NONE, int CameraShakeConfigOffset = 0, StringOffset CameraShakeBpOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ITriggerCameraShake.AddCameraShakeBp(builder, CameraShakeBpOffset);
			ITriggerCameraShake.AddCameraShakeConfig(builder, CameraShakeConfigOffset);
			ITriggerCameraShake.AddCameraShakeConfigType(builder, CameraShakeConfig_type);
			return ITriggerCameraShake.EndITriggerCameraShake(builder);
		}

		// Token: 0x06039675 RID: 235125 RVA: 0x007BFCFC File Offset: 0x007BDEFC
		public static void StartITriggerCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039676 RID: 235126 RVA: 0x007BFD05 File Offset: 0x007BDF05
		public static void AddCameraShakeConfigType(FlatBufferBuilder builder, TCameraShakeConfig cameraShakeConfigType)
		{
			builder.AddByte(0, (byte)cameraShakeConfigType, 0);
		}

		// Token: 0x06039677 RID: 235127 RVA: 0x007BFD10 File Offset: 0x007BDF10
		public static void AddCameraShakeConfig(FlatBufferBuilder builder, int cameraShakeConfigOffset)
		{
			builder.AddOffset(1, cameraShakeConfigOffset, 0);
		}

		// Token: 0x06039678 RID: 235128 RVA: 0x007BFD1B File Offset: 0x007BDF1B
		public static void AddCameraShakeBp(FlatBufferBuilder builder, StringOffset cameraShakeBpOffset)
		{
			builder.AddOffset(2, cameraShakeBpOffset.Value, 0);
		}

		// Token: 0x06039679 RID: 235129 RVA: 0x007BFD2B File Offset: 0x007BDF2B
		public static Offset<ITriggerCameraShake> EndITriggerCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerCameraShake>(builder.EndTable());
		}

		// Token: 0x0603967A RID: 235130 RVA: 0x007BFD38 File Offset: 0x007BDF38
		public ITriggerCameraShakeT UnPack()
		{
			ITriggerCameraShakeT triggerCameraShakeT = new ITriggerCameraShakeT();
			this.UnPackTo(triggerCameraShakeT);
			return triggerCameraShakeT;
		}

		// Token: 0x0603967B RID: 235131 RVA: 0x007BFD54 File Offset: 0x007BDF54
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

		// Token: 0x0603967C RID: 235132 RVA: 0x007BFE08 File Offset: 0x007BE008
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

		// Token: 0x04013324 RID: 78628
		private Table __p;
	}
}
