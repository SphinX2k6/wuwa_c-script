using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B7 RID: 26551
	public struct IAdjustFixedCameraRotateConfig : IFlatbufferObject
	{
		// Token: 0x1700C240 RID: 49728
		// (get) Token: 0x0602D345 RID: 185157 RVA: 0x0062F76F File Offset: 0x0062D96F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D346 RID: 185158 RVA: 0x0062F77C File Offset: 0x0062D97C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D347 RID: 185159 RVA: 0x0062F784 File Offset: 0x0062D984
		public static IAdjustFixedCameraRotateConfig GetRootAsIAdjustFixedCameraRotateConfig(ByteBuffer _bb)
		{
			return IAdjustFixedCameraRotateConfig.GetRootAsIAdjustFixedCameraRotateConfig(_bb, default(IAdjustFixedCameraRotateConfig));
		}

		// Token: 0x0602D348 RID: 185160 RVA: 0x0062F7A0 File Offset: 0x0062D9A0
		public static IAdjustFixedCameraRotateConfig GetRootAsIAdjustFixedCameraRotateConfig(ByteBuffer _bb, IAdjustFixedCameraRotateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D349 RID: 185161 RVA: 0x0062F7BD File Offset: 0x0062D9BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D34A RID: 185162 RVA: 0x0062F7CC File Offset: 0x0062D9CC
		public IAdjustFixedCameraRotateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C241 RID: 49729
		// (get) Token: 0x0602D34B RID: 185163 RVA: 0x0062F7DC File Offset: 0x0062D9DC
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

		// Token: 0x1700C242 RID: 49730
		// (get) Token: 0x0602D34C RID: 185164 RVA: 0x0062F81C File Offset: 0x0062DA1C
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

		// Token: 0x1700C243 RID: 49731
		// (get) Token: 0x0602D34D RID: 185165 RVA: 0x0062F85C File Offset: 0x0062DA5C
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

		// Token: 0x1700C244 RID: 49732
		// (get) Token: 0x0602D34E RID: 185166 RVA: 0x0062F89C File Offset: 0x0062DA9C
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

		// Token: 0x1700C245 RID: 49733
		// (get) Token: 0x0602D34F RID: 185167 RVA: 0x0062F8E0 File Offset: 0x0062DAE0
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

		// Token: 0x1700C246 RID: 49734
		// (get) Token: 0x0602D350 RID: 185168 RVA: 0x0062F924 File Offset: 0x0062DB24
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

		// Token: 0x0602D351 RID: 185169 RVA: 0x0062F965 File Offset: 0x0062DB65
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

		// Token: 0x0602D352 RID: 185170 RVA: 0x0062F9A1 File Offset: 0x0062DBA1
		public static void StartIAdjustFixedCameraRotateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602D353 RID: 185171 RVA: 0x0062F9AA File Offset: 0x0062DBAA
		public static void AddYawLimitMin(FlatBufferBuilder builder, float yawLimitMin)
		{
			builder.AddFloat(0, yawLimitMin, 0.0);
		}

		// Token: 0x0602D354 RID: 185172 RVA: 0x0062F9BD File Offset: 0x0062DBBD
		public static void AddYawLimitMax(FlatBufferBuilder builder, float yawLimitMax)
		{
			builder.AddFloat(1, yawLimitMax, 0.0);
		}

		// Token: 0x0602D355 RID: 185173 RVA: 0x0062F9D0 File Offset: 0x0062DBD0
		public static void AddPitchLimitMin(FlatBufferBuilder builder, float pitchLimitMin)
		{
			builder.AddFloat(2, pitchLimitMin, 0.0);
		}

		// Token: 0x0602D356 RID: 185174 RVA: 0x0062F9E3 File Offset: 0x0062DBE3
		public static void AddPitchLimitMax(FlatBufferBuilder builder, float pitchLimitMax)
		{
			builder.AddFloat(3, pitchLimitMax, 0.0);
		}

		// Token: 0x0602D357 RID: 185175 RVA: 0x0062F9F6 File Offset: 0x0062DBF6
		public static void AddYawRotateSpeed(FlatBufferBuilder builder, float yawRotateSpeed)
		{
			builder.AddFloat(4, yawRotateSpeed, 0.0);
		}

		// Token: 0x0602D358 RID: 185176 RVA: 0x0062FA09 File Offset: 0x0062DC09
		public static void AddPitchRotateSpeed(FlatBufferBuilder builder, float pitchRotateSpeed)
		{
			builder.AddFloat(5, pitchRotateSpeed, 0.0);
		}

		// Token: 0x0602D359 RID: 185177 RVA: 0x0062FA1C File Offset: 0x0062DC1C
		public static Offset<IAdjustFixedCameraRotateConfig> EndIAdjustFixedCameraRotateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedCameraRotateConfig>(builder.EndTable());
		}

		// Token: 0x0602D35A RID: 185178 RVA: 0x0062FA2C File Offset: 0x0062DC2C
		public IAdjustFixedCameraRotateConfigT UnPack()
		{
			IAdjustFixedCameraRotateConfigT adjustFixedCameraRotateConfigT = new IAdjustFixedCameraRotateConfigT();
			this.UnPackTo(adjustFixedCameraRotateConfigT);
			return adjustFixedCameraRotateConfigT;
		}

		// Token: 0x0602D35B RID: 185179 RVA: 0x0062FA48 File Offset: 0x0062DC48
		public void UnPackTo(IAdjustFixedCameraRotateConfigT _o)
		{
			_o.YawLimitMin = this.YawLimitMin;
			_o.YawLimitMax = this.YawLimitMax;
			_o.PitchLimitMin = this.PitchLimitMin;
			_o.PitchLimitMax = this.PitchLimitMax;
			_o.YawRotateSpeed = this.YawRotateSpeed;
			_o.PitchRotateSpeed = this.PitchRotateSpeed;
		}

		// Token: 0x0602D35C RID: 185180 RVA: 0x0062FAA0 File Offset: 0x0062DCA0
		public static Offset<IAdjustFixedCameraRotateConfig> Pack(FlatBufferBuilder builder, IAdjustFixedCameraRotateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedCameraRotateConfig>);
			}
			return IAdjustFixedCameraRotateConfig.CreateIAdjustFixedCameraRotateConfig(builder, _o.YawLimitMin, _o.YawLimitMax, _o.PitchLimitMin, _o.PitchLimitMax, _o.YawRotateSpeed, _o.PitchRotateSpeed);
		}

		// Token: 0x040113CA RID: 70602
		private Table __p;
	}
}
