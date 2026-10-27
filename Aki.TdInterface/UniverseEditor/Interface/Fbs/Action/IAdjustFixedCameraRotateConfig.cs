using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006152 RID: 24914
	public struct IAdjustFixedCameraRotateConfig : IFlatbufferObject
	{
		// Token: 0x1700B8D0 RID: 47312
		// (get) Token: 0x0602AC4C RID: 175180 RVA: 0x005E5593 File Offset: 0x005E3793
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AC4D RID: 175181 RVA: 0x005E55A0 File Offset: 0x005E37A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AC4E RID: 175182 RVA: 0x005E55A8 File Offset: 0x005E37A8
		public static IAdjustFixedCameraRotateConfig GetRootAsIAdjustFixedCameraRotateConfig(ByteBuffer _bb)
		{
			return IAdjustFixedCameraRotateConfig.GetRootAsIAdjustFixedCameraRotateConfig(_bb, default(IAdjustFixedCameraRotateConfig));
		}

		// Token: 0x0602AC4F RID: 175183 RVA: 0x005E55C4 File Offset: 0x005E37C4
		public static IAdjustFixedCameraRotateConfig GetRootAsIAdjustFixedCameraRotateConfig(ByteBuffer _bb, IAdjustFixedCameraRotateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AC50 RID: 175184 RVA: 0x005E55E1 File Offset: 0x005E37E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AC51 RID: 175185 RVA: 0x005E55F0 File Offset: 0x005E37F0
		public IAdjustFixedCameraRotateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8D1 RID: 47313
		// (get) Token: 0x0602AC52 RID: 175186 RVA: 0x005E5600 File Offset: 0x005E3800
		public float YawLimitMin
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D2 RID: 47314
		// (get) Token: 0x0602AC53 RID: 175187 RVA: 0x005E5640 File Offset: 0x005E3840
		public float YawLimitMax
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D3 RID: 47315
		// (get) Token: 0x0602AC54 RID: 175188 RVA: 0x005E5680 File Offset: 0x005E3880
		public float PitchLimitMin
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D4 RID: 47316
		// (get) Token: 0x0602AC55 RID: 175189 RVA: 0x005E56C0 File Offset: 0x005E38C0
		public float PitchLimitMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D5 RID: 47317
		// (get) Token: 0x0602AC56 RID: 175190 RVA: 0x005E5704 File Offset: 0x005E3904
		public float YawRotateSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D6 RID: 47318
		// (get) Token: 0x0602AC57 RID: 175191 RVA: 0x005E5748 File Offset: 0x005E3948
		public float PitchRotateSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602AC58 RID: 175192 RVA: 0x005E5789 File Offset: 0x005E3989
		public static Offset<IAdjustFixedCameraRotateConfig> CreateIAdjustFixedCameraRotateConfig(FlatBufferBuilder builder, float YawLimitMin = 0f, float YawLimitMax = 0f, float PitchLimitMin = 0f, float PitchLimitMax = 0f, float YawRotateSpeed = 0f, float PitchRotateSpeed = 0f)
		{
			builder.StartTable(6);
			IAdjustFixedCameraRotateConfig.AddPitchRotateSpeed(builder, PitchRotateSpeed);
			IAdjustFixedCameraRotateConfig.AddYawRotateSpeed(builder, YawRotateSpeed);
			IAdjustFixedCameraRotateConfig.AddPitchLimitMax(builder, PitchLimitMax);
			IAdjustFixedCameraRotateConfig.AddPitchLimitMin(builder, PitchLimitMin);
			IAdjustFixedCameraRotateConfig.AddYawLimitMax(builder, YawLimitMax);
			IAdjustFixedCameraRotateConfig.AddYawLimitMin(builder, YawLimitMin);
			return IAdjustFixedCameraRotateConfig.EndIAdjustFixedCameraRotateConfig(builder);
		}

		// Token: 0x0602AC59 RID: 175193 RVA: 0x005E57C5 File Offset: 0x005E39C5
		public static void StartIAdjustFixedCameraRotateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602AC5A RID: 175194 RVA: 0x005E57CE File Offset: 0x005E39CE
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(0, yawLimitMin, 0.0);
		}

		// Token: 0x0602AC5B RID: 175195 RVA: 0x005E57E1 File Offset: 0x005E39E1
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(1, yawLimitMax, 0.0);
		}

		// Token: 0x0602AC5C RID: 175196 RVA: 0x005E57F4 File Offset: 0x005E39F4
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(2, pitchLimitMin, 0.0);
		}

		// Token: 0x0602AC5D RID: 175197 RVA: 0x005E5807 File Offset: 0x005E3A07
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(3, pitchLimitMax, 0.0);
		}

		// Token: 0x0602AC5E RID: 175198 RVA: 0x005E581A File Offset: 0x005E3A1A
		public static void AddYawRotateSpeed(FlatBufferBuilder builder, float yawRotateSpeed)
		{
			builder.AddFloat(4, yawRotateSpeed, 0.0);
		}

		// Token: 0x0602AC5F RID: 175199 RVA: 0x005E582D File Offset: 0x005E3A2D
		public static void AddPitchRotateSpeed(FlatBufferBuilder builder, float pitchRotateSpeed)
		{
			builder.AddFloat(5, pitchRotateSpeed, 0.0);
		}

		// Token: 0x0602AC60 RID: 175200 RVA: 0x005E5840 File Offset: 0x005E3A40
		public static Offset<IAdjustFixedCameraRotateConfig> EndIAdjustFixedCameraRotateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCameraRotateConfig>(builder.EndTable());
		}

		// Token: 0x0602AC61 RID: 175201 RVA: 0x005E5850 File Offset: 0x005E3A50
		public IAdjustFixedCameraRotateConfigT UnPack()
		{
			IAdjustFixedCameraRotateConfigT adjustFixedCameraRotateConfigT = new IAdjustFixedCameraRotateConfigT();
			this.UnPackTo(adjustFixedCameraRotateConfigT);
			return adjustFixedCameraRotateConfigT;
		}

		// Token: 0x0602AC62 RID: 175202 RVA: 0x005E586C File Offset: 0x005E3A6C
		public void UnPackTo(IAdjustFixedCameraRotateConfigT _o)
		{
			_o.YawLimitMin = this.YawLimitMin;
			_o.YawLimitMax = this.YawLimitMax;
			_o.PitchLimitMin = this.PitchLimitMin;
			_o.PitchLimitMax = this.PitchLimitMax;
			_o.YawRotateSpeed = this.YawRotateSpeed;
			_o.PitchRotateSpeed = this.PitchRotateSpeed;
		}

		// Token: 0x0602AC63 RID: 175203 RVA: 0x005E58C4 File Offset: 0x005E3AC4
		public static Offset<IAdjustFixedCameraRotateConfig> Pack(FlatBufferBuilder builder, IAdjustFixedCameraRotateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedCameraRotateConfig>);
			}
			return IAdjustFixedCameraRotateConfig.CreateIAdjustFixedCameraRotateConfig(builder, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.YawRotateSpeed, _o.PitchRotateSpeed);
		}

		// Token: 0x040105C3 RID: 67011
		private Table __p;
	}
}
