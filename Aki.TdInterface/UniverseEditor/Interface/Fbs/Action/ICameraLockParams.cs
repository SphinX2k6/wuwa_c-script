using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F2 RID: 26866
	public struct ICameraLockParams : IFlatbufferObject
	{
		// Token: 0x1700C581 RID: 50561
		// (get) Token: 0x0602DFE6 RID: 188390 RVA: 0x006493E3 File Offset: 0x006475E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFE7 RID: 188391 RVA: 0x006493F0 File Offset: 0x006475F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFE8 RID: 188392 RVA: 0x006493F8 File Offset: 0x006475F8
		public static ICameraLockParams GetRootAsICameraLockParams(ByteBuffer _bb)
		{
			return ICameraLockParams.GetRootAsICameraLockParams(_bb, default(ICameraLockParams));
		}

		// Token: 0x0602DFE9 RID: 188393 RVA: 0x00649414 File Offset: 0x00647614
		public static ICameraLockParams GetRootAsICameraLockParams(ByteBuffer _bb, ICameraLockParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFEA RID: 188394 RVA: 0x00649431 File Offset: 0x00647631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFEB RID: 188395 RVA: 0x00649440 File Offset: 0x00647640
		public ICameraLockParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C582 RID: 50562
		// (get) Token: 0x0602DFEC RID: 188396 RVA: 0x00649450 File Offset: 0x00647650
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

		// Token: 0x1700C583 RID: 50563
		// (get) Token: 0x0602DFED RID: 188397 RVA: 0x00649490 File Offset: 0x00647690
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

		// Token: 0x1700C584 RID: 50564
		// (get) Token: 0x0602DFEE RID: 188398 RVA: 0x006494D0 File Offset: 0x006476D0
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

		// Token: 0x1700C585 RID: 50565
		// (get) Token: 0x0602DFEF RID: 188399 RVA: 0x00649510 File Offset: 0x00647710
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

		// Token: 0x1700C586 RID: 50566
		// (get) Token: 0x0602DFF0 RID: 188400 RVA: 0x00649554 File Offset: 0x00647754
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

		// Token: 0x1700C587 RID: 50567
		// (get) Token: 0x0602DFF1 RID: 188401 RVA: 0x00649598 File Offset: 0x00647798
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

		// Token: 0x1700C588 RID: 50568
		// (get) Token: 0x0602DFF2 RID: 188402 RVA: 0x006495DC File Offset: 0x006477DC
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

		// Token: 0x1700C589 RID: 50569
		// (get) Token: 0x0602DFF3 RID: 188403 RVA: 0x00649620 File Offset: 0x00647820
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

		// Token: 0x1700C58A RID: 50570
		// (get) Token: 0x0602DFF4 RID: 188404 RVA: 0x00649664 File Offset: 0x00647864
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

		// Token: 0x1700C58B RID: 50571
		// (get) Token: 0x0602DFF5 RID: 188405 RVA: 0x006496A8 File Offset: 0x006478A8
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

		// Token: 0x1700C58C RID: 50572
		// (get) Token: 0x0602DFF6 RID: 188406 RVA: 0x006496EC File Offset: 0x006478EC
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

		// Token: 0x1700C58D RID: 50573
		// (get) Token: 0x0602DFF7 RID: 188407 RVA: 0x00649730 File Offset: 0x00647930
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

		// Token: 0x1700C58E RID: 50574
		// (get) Token: 0x0602DFF8 RID: 188408 RVA: 0x00649774 File Offset: 0x00647974
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

		// Token: 0x1700C58F RID: 50575
		// (get) Token: 0x0602DFF9 RID: 188409 RVA: 0x006497B8 File Offset: 0x006479B8
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

		// Token: 0x1700C590 RID: 50576
		// (get) Token: 0x0602DFFA RID: 188410 RVA: 0x006497FC File Offset: 0x006479FC
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

		// Token: 0x0602DFFB RID: 188411 RVA: 0x00649840 File Offset: 0x00647A40
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

		// Token: 0x0602DFFC RID: 188412 RVA: 0x006498D0 File Offset: 0x00647AD0
		public static void StartICameraLockParams(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x0602DFFD RID: 188413 RVA: 0x006498DA File Offset: 0x00647ADA
		public static void AddRelativeYawHardMin(FlatBufferBuilder builder, float relativeYawHardMin)
		{
			builder.AddFloat(0, relativeYawHardMin, 0.0);
		}

		// Token: 0x0602DFFE RID: 188414 RVA: 0x006498ED File Offset: 0x00647AED
		public static void AddRelativeYawHardMax(FlatBufferBuilder builder, float relativeYawHardMax)
		{
			builder.AddFloat(1, relativeYawHardMax, 0.0);
		}

		// Token: 0x0602DFFF RID: 188415 RVA: 0x00649900 File Offset: 0x00647B00
		public static void AddRelativePitchHardMin(FlatBufferBuilder builder, float relativePitchHardMin)
		{
			builder.AddFloat(2, relativePitchHardMin, 0.0);
		}

		// Token: 0x0602E000 RID: 188416 RVA: 0x00649913 File Offset: 0x00647B13
		public static void AddRelativePitchHardMax(FlatBufferBuilder builder, float relativePitchHardMax)
		{
			builder.AddFloat(3, relativePitchHardMax, 0.0);
		}

		// Token: 0x0602E001 RID: 188417 RVA: 0x00649926 File Offset: 0x00647B26
		public static void AddYawSignAdaptionLockDirection(FlatBufferBuilder builder, float yawSignAdaptionLockDirection)
		{
			builder.AddFloat(4, yawSignAdaptionLockDirection, 0.0);
		}

		// Token: 0x0602E002 RID: 188418 RVA: 0x00649939 File Offset: 0x00647B39
		public static void AddRelativeRotationLagYawSpeedMin(FlatBufferBuilder builder, float relativeRotationLagYawSpeedMin)
		{
			builder.AddFloat(5, relativeRotationLagYawSpeedMin, 0.0);
		}

		// Token: 0x0602E003 RID: 188419 RVA: 0x0064994C File Offset: 0x00647B4C
		public static void AddRelativeRotationLagYawSpeedMax(FlatBufferBuilder builder, float relativeRotationLagYawSpeedMax)
		{
			builder.AddFloat(6, relativeRotationLagYawSpeedMax, 0.0);
		}

		// Token: 0x0602E004 RID: 188420 RVA: 0x0064995F File Offset: 0x00647B5F
		public static void AddRelativeRotationLagYawAngleRange(FlatBufferBuilder builder, float relativeRotationLagYawAngleRange)
		{
			builder.AddFloat(7, relativeRotationLagYawAngleRange, 0.0);
		}

		// Token: 0x0602E005 RID: 188421 RVA: 0x00649972 File Offset: 0x00647B72
		public static void AddRelativeRotationLagPitchSpeedMin(FlatBufferBuilder builder, float relativeRotationLagPitchSpeedMin)
		{
			builder.AddFloat(8, relativeRotationLagPitchSpeedMin, 0.0);
		}

		// Token: 0x0602E006 RID: 188422 RVA: 0x00649985 File Offset: 0x00647B85
		public static void AddRelativeRotationLagPitchSpeedMax(FlatBufferBuilder builder, float relativeRotationLagPitchSpeedMax)
		{
			builder.AddFloat(9, relativeRotationLagPitchSpeedMax, 0.0);
		}

		// Token: 0x0602E007 RID: 188423 RVA: 0x00649999 File Offset: 0x00647B99
		public static void AddRelativeRotationLagPitchAngleRange(FlatBufferBuilder builder, float relativeRotationLagPitchAngleRange)
		{
			builder.AddFloat(10, relativeRotationLagPitchAngleRange, 0.0);
		}

		// Token: 0x0602E008 RID: 188424 RVA: 0x006499AD File Offset: 0x00647BAD
		public static void AddRelativeRotationLagRatioMin(FlatBufferBuilder builder, float relativeRotationLagRatioMin)
		{
			builder.AddFloat(11, relativeRotationLagRatioMin, 0.0);
		}

		// Token: 0x0602E009 RID: 188425 RVA: 0x006499C1 File Offset: 0x00647BC1
		public static void AddRelativeRotationLagRatioMax(FlatBufferBuilder builder, float relativeRotationLagRatioMax)
		{
			builder.AddFloat(12, relativeRotationLagRatioMax, 0.0);
		}

		// Token: 0x0602E00A RID: 188426 RVA: 0x006499D5 File Offset: 0x00647BD5
		public static void AddRelativeRotationLagDistanceRangeMin(FlatBufferBuilder builder, float relativeRotationLagDistanceRangeMin)
		{
			builder.AddFloat(13, relativeRotationLagDistanceRangeMin, 0.0);
		}

		// Token: 0x0602E00B RID: 188427 RVA: 0x006499E9 File Offset: 0x00647BE9
		public static void AddRelativeRotationLagDistanceRangeMax(FlatBufferBuilder builder, float relativeRotationLagDistanceRangeMax)
		{
			builder.AddFloat(14, relativeRotationLagDistanceRangeMax, 0.0);
		}

		// Token: 0x0602E00C RID: 188428 RVA: 0x006499FD File Offset: 0x00647BFD
		public static Offset<ICameraLockParams> EndICameraLockParams(FlatBufferBuilder builder)
		{
			return new Offset<ICameraLockParams>(builder.EndTable());
		}

		// Token: 0x0602E00D RID: 188429 RVA: 0x00649A0C File Offset: 0x00647C0C
		public ICameraLockParamsT UnPack()
		{
			ICameraLockParamsT cameraLockParamsT = new ICameraLockParamsT();
			this.UnPackTo(cameraLockParamsT);
			return cameraLockParamsT;
		}

		// Token: 0x0602E00E RID: 188430 RVA: 0x00649A28 File Offset: 0x00647C28
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

		// Token: 0x0602E00F RID: 188431 RVA: 0x00649AEC File Offset: 0x00647CEC
		public static Offset<ICameraLockParams> Pack(FlatBufferBuilder builder, ICameraLockParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraLockParams>);
			}
			return ICameraLockParams.CreateICameraLockParams(builder, _o.RelativeYawHardMin, _o.RelativeYawHardMax, _o.RelativePitchHardMin, _o.RelativePitchHardMax, _o.YawSignAdaptionLockDirection, _o.RelativeRotationLagYawSpeedMin, _o.RelativeRotationLagYawSpeedMax, _o.RelativeRotationLagYawAngleRange, _o.RelativeRotationLagPitchSpeedMin, _o.RelativeRotationLagPitchSpeedMax, _o.RelativeRotationLagPitchAngleRange, _o.RelativeRotationLagRatioMin, _o.RelativeRotationLagRatioMax, _o.RelativeRotationLagDistanceRangeMin, _o.RelativeRotationLagDistanceRangeMax);
		}

		// Token: 0x040115FB RID: 71163
		private Table __p;
	}
}
