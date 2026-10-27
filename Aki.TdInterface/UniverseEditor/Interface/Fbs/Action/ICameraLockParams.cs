using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006281 RID: 25217
	public struct ICameraLockParams : IFlatbufferObject
	{
		// Token: 0x1700BBF9 RID: 48121
		// (get) Token: 0x0602B885 RID: 178309 RVA: 0x005FE5DB File Offset: 0x005FC7DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B886 RID: 178310 RVA: 0x005FE5E8 File Offset: 0x005FC7E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B887 RID: 178311 RVA: 0x005FE5F0 File Offset: 0x005FC7F0
		public static ICameraLockParams GetRootAsICameraLockParams(ByteBuffer _bb)
		{
			return ICameraLockParams.GetRootAsICameraLockParams(_bb, default(ICameraLockParams));
		}

		// Token: 0x0602B888 RID: 178312 RVA: 0x005FE60C File Offset: 0x005FC80C
		public static ICameraLockParams GetRootAsICameraLockParams(ByteBuffer _bb, ICameraLockParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B889 RID: 178313 RVA: 0x005FE629 File Offset: 0x005FC829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B88A RID: 178314 RVA: 0x005FE638 File Offset: 0x005FC838
		public ICameraLockParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBFA RID: 48122
		// (get) Token: 0x0602B88B RID: 178315 RVA: 0x005FE648 File Offset: 0x005FC848
		public float RelativeYawHardMin
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

		// Token: 0x1700BBFB RID: 48123
		// (get) Token: 0x0602B88C RID: 178316 RVA: 0x005FE688 File Offset: 0x005FC888
		public float RelativeYawHardMax
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

		// Token: 0x1700BBFC RID: 48124
		// (get) Token: 0x0602B88D RID: 178317 RVA: 0x005FE6C8 File Offset: 0x005FC8C8
		public float RelativePitchHardMin
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

		// Token: 0x1700BBFD RID: 48125
		// (get) Token: 0x0602B88E RID: 178318 RVA: 0x005FE708 File Offset: 0x005FC908
		public float RelativePitchHardMax
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

		// Token: 0x1700BBFE RID: 48126
		// (get) Token: 0x0602B88F RID: 178319 RVA: 0x005FE74C File Offset: 0x005FC94C
		public float YawSignAdaptionLockDirection
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

		// Token: 0x1700BBFF RID: 48127
		// (get) Token: 0x0602B890 RID: 178320 RVA: 0x005FE790 File Offset: 0x005FC990
		public float RelativeRotationLagYawSpeedMin
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

		// Token: 0x1700BC00 RID: 48128
		// (get) Token: 0x0602B891 RID: 178321 RVA: 0x005FE7D4 File Offset: 0x005FC9D4
		public float RelativeRotationLagYawSpeedMax
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC01 RID: 48129
		// (get) Token: 0x0602B892 RID: 178322 RVA: 0x005FE818 File Offset: 0x005FCA18
		public float RelativeRotationLagYawAngleRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC02 RID: 48130
		// (get) Token: 0x0602B893 RID: 178323 RVA: 0x005FE85C File Offset: 0x005FCA5C
		public float RelativeRotationLagPitchSpeedMin
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC03 RID: 48131
		// (get) Token: 0x0602B894 RID: 178324 RVA: 0x005FE8A0 File Offset: 0x005FCAA0
		public float RelativeRotationLagPitchSpeedMax
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC04 RID: 48132
		// (get) Token: 0x0602B895 RID: 178325 RVA: 0x005FE8E4 File Offset: 0x005FCAE4
		public float RelativeRotationLagPitchAngleRange
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC05 RID: 48133
		// (get) Token: 0x0602B896 RID: 178326 RVA: 0x005FE928 File Offset: 0x005FCB28
		public float RelativeRotationLagRatioMin
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC06 RID: 48134
		// (get) Token: 0x0602B897 RID: 178327 RVA: 0x005FE96C File Offset: 0x005FCB6C
		public float RelativeRotationLagRatioMax
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC07 RID: 48135
		// (get) Token: 0x0602B898 RID: 178328 RVA: 0x005FE9B0 File Offset: 0x005FCBB0
		public float RelativeRotationLagDistanceRangeMin
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC08 RID: 48136
		// (get) Token: 0x0602B899 RID: 178329 RVA: 0x005FE9F4 File Offset: 0x005FCBF4
		public float RelativeRotationLagDistanceRangeMax
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B89A RID: 178330 RVA: 0x005FEA38 File Offset: 0x005FCC38
		public static Offset<ICameraLockParams> CreateICameraLockParams(FlatBufferBuilder builder, float RelativeYawHardMin = 0f, float RelativeYawHardMax = 0f, float RelativePitchHardMin = 0f, float RelativePitchHardMax = 0f, float YawSignAdaptionLockDirection = 0f, float RelativeRotationLagYawSpeedMin = 0f, float RelativeRotationLagYawSpeedMax = 0f, float RelativeRotationLagYawAngleRange = 0f, float RelativeRotationLagPitchSpeedMin = 0f, float RelativeRotationLagPitchSpeedMax = 0f, float RelativeRotationLagPitchAngleRange = 0f, float RelativeRotationLagRatioMin = 0f, float RelativeRotationLagRatioMax = 0f, float RelativeRotationLagDistanceRangeMin = 0f, float RelativeRotationLagDistanceRangeMax = 0f)
		{
			builder.StartTable(15);
			ICameraLockParams.AddRelativeRotationLagDistanceRangeMax(builder, RelativeRotationLagDistanceRangeMax);
			ICameraLockParams.AddRelativeRotationLagDistanceRangeMin(builder, RelativeRotationLagDistanceRangeMin);
			ICameraLockParams.AddRelativeRotationLagRatioMax(builder, RelativeRotationLagRatioMax);
			ICameraLockParams.AddRelativeRotationLagRatioMin(builder, RelativeRotationLagRatioMin);
			ICameraLockParams.AddRelativeRotationLagPitchAngleRange(builder, RelativeRotationLagPitchAngleRange);
			ICameraLockParams.AddRelativeRotationLagPitchSpeedMax(builder, RelativeRotationLagPitchSpeedMax);
			ICameraLockParams.AddRelativeRotationLagPitchSpeedMin(builder, RelativeRotationLagPitchSpeedMin);
			ICameraLockParams.AddRelativeRotationLagYawAngleRange(builder, RelativeRotationLagYawAngleRange);
			ICameraLockParams.AddRelativeRotationLagYawSpeedMax(builder, RelativeRotationLagYawSpeedMax);
			ICameraLockParams.AddRelativeRotationLagYawSpeedMin(builder, RelativeRotationLagYawSpeedMin);
			ICameraLockParams.AddYawSignAdaptionLockDirection(builder, YawSignAdaptionLockDirection);
			ICameraLockParams.AddRelativePitchHardMax(builder, RelativePitchHardMax);
			ICameraLockParams.AddRelativePitchHardMin(builder, RelativePitchHardMin);
			ICameraLockParams.AddRelativeYawHardMax(builder, RelativeYawHardMax);
			ICameraLockParams.AddRelativeYawHardMin(builder, RelativeYawHardMin);
			return ICameraLockParams.EndICameraLockParams(builder);
		}

		// Token: 0x0602B89B RID: 178331 RVA: 0x005FEAC8 File Offset: 0x005FCCC8
		public static void StartICameraLockParams(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0602B89C RID: 178332 RVA: 0x005FEAD2 File Offset: 0x005FCCD2
		public static void AddRelativeYawHardMin(FlatBufferBuilder builder, float relativeYawHardMin)
		{
			builder.AddFloat(0, relativeYawHardMin, 0.0);
		}

		// Token: 0x0602B89D RID: 178333 RVA: 0x005FEAE5 File Offset: 0x005FCCE5
		public static void AddRelativeYawHardMax(FlatBufferBuilder builder, float relativeYawHardMax)
		{
			builder.AddFloat(1, relativeYawHardMax, 0.0);
		}

		// Token: 0x0602B89E RID: 178334 RVA: 0x005FEAF8 File Offset: 0x005FCCF8
		public static void AddRelativePitchHardMin(FlatBufferBuilder builder, float relativePitchHardMin)
		{
			builder.AddFloat(2, relativePitchHardMin, 0.0);
		}

		// Token: 0x0602B89F RID: 178335 RVA: 0x005FEB0B File Offset: 0x005FCD0B
		public static void AddRelativePitchHardMax(FlatBufferBuilder builder, float relativePitchHardMax)
		{
			builder.AddFloat(3, relativePitchHardMax, 0.0);
		}

		// Token: 0x0602B8A0 RID: 178336 RVA: 0x005FEB1E File Offset: 0x005FCD1E
		public static void AddYawSignAdaptionLockDirection(FlatBufferBuilder builder, float yawSignAdaptionLockDirection)
		{
			builder.AddFloat(4, yawSignAdaptionLockDirection, 0.0);
		}

		// Token: 0x0602B8A1 RID: 178337 RVA: 0x005FEB31 File Offset: 0x005FCD31
		public static void AddRelativeRotationLagYawSpeedMin(FlatBufferBuilder builder, float relativeRotationLagYawSpeedMin)
		{
			builder.AddFloat(5, relativeRotationLagYawSpeedMin, 0.0);
		}

		// Token: 0x0602B8A2 RID: 178338 RVA: 0x005FEB44 File Offset: 0x005FCD44
		public static void AddRelativeRotationLagYawSpeedMax(FlatBufferBuilder builder, float relativeRotationLagYawSpeedMax)
		{
			builder.AddFloat(6, relativeRotationLagYawSpeedMax, 0.0);
		}

		// Token: 0x0602B8A3 RID: 178339 RVA: 0x005FEB57 File Offset: 0x005FCD57
		public static void AddRelativeRotationLagYawAngleRange(FlatBufferBuilder builder, float relativeRotationLagYawAngleRange)
		{
			builder.AddFloat(7, relativeRotationLagYawAngleRange, 0.0);
		}

		// Token: 0x0602B8A4 RID: 178340 RVA: 0x005FEB6A File Offset: 0x005FCD6A
		public static void AddRelativeRotationLagPitchSpeedMin(FlatBufferBuilder builder, float relativeRotationLagPitchSpeedMin)
		{
			builder.AddFloat(8, relativeRotationLagPitchSpeedMin, 0.0);
		}

		// Token: 0x0602B8A5 RID: 178341 RVA: 0x005FEB7D File Offset: 0x005FCD7D
		public static void AddRelativeRotationLagPitchSpeedMax(FlatBufferBuilder builder, float relativeRotationLagPitchSpeedMax)
		{
			builder.AddFloat(9, relativeRotationLagPitchSpeedMax, 0.0);
		}

		// Token: 0x0602B8A6 RID: 178342 RVA: 0x005FEB91 File Offset: 0x005FCD91
		public static void AddRelativeRotationLagPitchAngleRange(FlatBufferBuilder builder, float relativeRotationLagPitchAngleRange)
		{
			builder.AddFloat(10, relativeRotationLagPitchAngleRange, 0.0);
		}

		// Token: 0x0602B8A7 RID: 178343 RVA: 0x005FEBA5 File Offset: 0x005FCDA5
		public static void AddRelativeRotationLagRatioMin(FlatBufferBuilder builder, float relativeRotationLagRatioMin)
		{
			builder.AddFloat(11, relativeRotationLagRatioMin, 0.0);
		}

		// Token: 0x0602B8A8 RID: 178344 RVA: 0x005FEBB9 File Offset: 0x005FCDB9
		public static void AddRelativeRotationLagRatioMax(FlatBufferBuilder builder, float relativeRotationLagRatioMax)
		{
			builder.AddFloat(12, relativeRotationLagRatioMax, 0.0);
		}

		// Token: 0x0602B8A9 RID: 178345 RVA: 0x005FEBCD File Offset: 0x005FCDCD
		public static void AddRelativeRotationLagDistanceRangeMin(FlatBufferBuilder builder, float relativeRotationLagDistanceRangeMin)
		{
			builder.AddFloat(13, relativeRotationLagDistanceRangeMin, 0.0);
		}

		// Token: 0x0602B8AA RID: 178346 RVA: 0x005FEBE1 File Offset: 0x005FCDE1
		public static void AddRelativeRotationLagDistanceRangeMax(FlatBufferBuilder builder, float relativeRotationLagDistanceRangeMax)
		{
			builder.AddFloat(14, relativeRotationLagDistanceRangeMax, 0.0);
		}

		// Token: 0x0602B8AB RID: 178347 RVA: 0x005FEBF5 File Offset: 0x005FCDF5
		public static Offset<ICameraLockParams> EndICameraLockParams(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockParams>(builder.EndTable());
		}

		// Token: 0x0602B8AC RID: 178348 RVA: 0x005FEC04 File Offset: 0x005FCE04
		public ICameraLockParamsT UnPack()
		{
			ICameraLockParamsT cameraLockParamsT = new ICameraLockParamsT();
			this.UnPackTo(cameraLockParamsT);
			return cameraLockParamsT;
		}

		// Token: 0x0602B8AD RID: 178349 RVA: 0x005FEC20 File Offset: 0x005FCE20
		public void UnPackTo(ICameraLockParamsT _o)
		{
			_o.RelativeYawHardMin = this.RelativeYawHardMin;
			_o.RelativeYawHardMax = this.RelativeYawHardMax;
			_o.RelativePitchHardMin = this.RelativePitchHardMin;
			_o.RelativePitchHardMax = this.RelativePitchHardMax;
			_o.YawSignAdaptionLockDirection = this.YawSignAdaptionLockDirection;
			_o.RelativeRotationLagYawSpeedMin = this.RelativeRotationLagYawSpeedMin;
			_o.RelativeRotationLagYawSpeedMax = this.RelativeRotationLagYawSpeedMax;
			_o.RelativeRotationLagYawAngleRange = this.RelativeRotationLagYawAngleRange;
			_o.RelativeRotationLagPitchSpeedMin = this.RelativeRotationLagPitchSpeedMin;
			_o.RelativeRotationLagPitchSpeedMax = this.RelativeRotationLagPitchSpeedMax;
			_o.RelativeRotationLagPitchAngleRange = this.RelativeRotationLagPitchAngleRange;
			_o.RelativeRotationLagRatioMin = this.RelativeRotationLagRatioMin;
			_o.RelativeRotationLagRatioMax = this.RelativeRotationLagRatioMax;
			_o.RelativeRotationLagDistanceRangeMin = this.RelativeRotationLagDistanceRangeMin;
			_o.RelativeRotationLagDistanceRangeMax = this.RelativeRotationLagDistanceRangeMax;
		}

		// Token: 0x0602B8AE RID: 178350 RVA: 0x005FECE4 File Offset: 0x005FCEE4
		public static Offset<ICameraLockParams> Pack(FlatBufferBuilder builder, ICameraLockParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockParams>);
			}
			return ICameraLockParams.CreateICameraLockParams(builder, _o.RelativeYawHardMin, _o.RelativeYawHardMax, _o.RelativePitchHardMin, _o.RelativePitchHardMax, _o.YawSignAdaptionLockDirection, _o.RelativeRotationLagYawSpeedMin, _o.RelativeRotationLagYawSpeedMax, _o.RelativeRotationLagYawAngleRange, _o.RelativeRotationLagPitchSpeedMin, _o.RelativeRotationLagPitchSpeedMax, _o.RelativeRotationLagPitchAngleRange, _o.RelativeRotationLagRatioMin, _o.RelativeRotationLagRatioMax, _o.RelativeRotationLagDistanceRangeMin, _o.RelativeRotationLagDistanceRangeMax);
		}

		// Token: 0x040107E6 RID: 67558
		private Table __p;
	}
}
