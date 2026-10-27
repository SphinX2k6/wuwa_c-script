using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006290 RID: 25232
	public struct ICameraOffsetInMovementDirection : IFlatbufferObject
	{
		// Token: 0x1700BC45 RID: 48197
		// (get) Token: 0x0602B955 RID: 178517 RVA: 0x006000F4 File Offset: 0x005FE2F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B956 RID: 178518 RVA: 0x00600101 File Offset: 0x005FE301
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B957 RID: 178519 RVA: 0x00600108 File Offset: 0x005FE308
		public static ICameraOffsetInMovementDirection GetRootAsICameraOffsetInMovementDirection(ByteBuffer _bb)
		{
			return ICameraOffsetInMovementDirection.GetRootAsICameraOffsetInMovementDirection(_bb, default(ICameraOffsetInMovementDirection));
		}

		// Token: 0x0602B958 RID: 178520 RVA: 0x00600124 File Offset: 0x005FE324
		public static ICameraOffsetInMovementDirection GetRootAsICameraOffsetInMovementDirection(ByteBuffer _bb, ICameraOffsetInMovementDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B959 RID: 178521 RVA: 0x00600141 File Offset: 0x005FE341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B95A RID: 178522 RVA: 0x00600150 File Offset: 0x005FE350
		public ICameraOffsetInMovementDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC46 RID: 48198
		// (get) Token: 0x0602B95B RID: 178523 RVA: 0x00600160 File Offset: 0x005FE360
		public float MinInterpolationSpeed
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

		// Token: 0x1700BC47 RID: 48199
		// (get) Token: 0x0602B95C RID: 178524 RVA: 0x006001A0 File Offset: 0x005FE3A0
		public float MaxInterpolationSpeed
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

		// Token: 0x1700BC48 RID: 48200
		// (get) Token: 0x0602B95D RID: 178525 RVA: 0x006001E0 File Offset: 0x005FE3E0
		public float OffsetDistance1
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

		// Token: 0x1700BC49 RID: 48201
		// (get) Token: 0x0602B95E RID: 178526 RVA: 0x00600220 File Offset: 0x005FE420
		public float OffsetDistance2
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

		// Token: 0x1700BC4A RID: 48202
		// (get) Token: 0x0602B95F RID: 178527 RVA: 0x00600264 File Offset: 0x005FE464
		public IBaseCurve? OffsetCurve
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IBaseCurve?(default(IBaseCurve).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC4B RID: 48203
		// (get) Token: 0x0602B960 RID: 178528 RVA: 0x006002C4 File Offset: 0x005FE4C4
		public int CenteringWaitTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC4C RID: 48204
		// (get) Token: 0x0602B961 RID: 178529 RVA: 0x00600304 File Offset: 0x005FE504
		public int StartupWaitTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BC4D RID: 48205
		// (get) Token: 0x0602B962 RID: 178530 RVA: 0x00600344 File Offset: 0x005FE544
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B963 RID: 178531 RVA: 0x00600384 File Offset: 0x005FE584
		public static Offset<ICameraOffsetInMovementDirection> CreateICameraOffsetInMovementDirection(FlatBufferBuilder builder, float MinInterpolationSpeed = 0f, float MaxInterpolationSpeed = 0f, float OffsetDistance1 = 0f, float OffsetDistance2 = 0f, Offset<IBaseCurve> OffsetCurveOffset = default(Offset<IBaseCurve>), int CenteringWaitTime = 0, int StartupWaitTime = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			ICameraOffsetInMovementDirection.AddStartupWaitTime(builder, StartupWaitTime);
			ICameraOffsetInMovementDirection.AddCenteringWaitTime(builder, CenteringWaitTime);
			ICameraOffsetInMovementDirection.AddOffsetCurve(builder, OffsetCurveOffset);
			ICameraOffsetInMovementDirection.AddOffsetDistance2(builder, OffsetDistance2);
			ICameraOffsetInMovementDirection.AddOffsetDistance1(builder, OffsetDistance1);
			ICameraOffsetInMovementDirection.AddMaxInterpolationSpeed(builder, MaxInterpolationSpeed);
			ICameraOffsetInMovementDirection.AddMinInterpolationSpeed(builder, MinInterpolationSpeed);
			ICameraOffsetInMovementDirection.AddNullMask(builder, NullMask);
			return ICameraOffsetInMovementDirection.EndICameraOffsetInMovementDirection(builder);
		}

		// Token: 0x0602B964 RID: 178532 RVA: 0x006003DB File Offset: 0x005FE5DB
		public static void StartICameraOffsetInMovementDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602B965 RID: 178533 RVA: 0x006003E4 File Offset: 0x005FE5E4
		public static void AddMinInterpolationSpeed(FlatBufferBuilder builder, float minInterpolationSpeed)
		{
			builder.AddFloat(0, minInterpolationSpeed, 0.0);
		}

		// Token: 0x0602B966 RID: 178534 RVA: 0x006003F7 File Offset: 0x005FE5F7
		public static void AddMaxInterpolationSpeed(FlatBufferBuilder builder, float maxInterpolationSpeed)
		{
			builder.AddFloat(1, maxInterpolationSpeed, 0.0);
		}

		// Token: 0x0602B967 RID: 178535 RVA: 0x0060040A File Offset: 0x005FE60A
		public static void AddOffsetDistance1(FlatBufferBuilder builder, float offsetDistance1)
		{
			builder.AddFloat(2, offsetDistance1, 0.0);
		}

		// Token: 0x0602B968 RID: 178536 RVA: 0x0060041D File Offset: 0x005FE61D
		public static void AddOffsetDistance2(FlatBufferBuilder builder, float offsetDistance2)
		{
			builder.AddFloat(3, offsetDistance2, 0.0);
		}

		// Token: 0x0602B969 RID: 178537 RVA: 0x00600430 File Offset: 0x005FE630
		public static void AddOffsetCurve(FlatBufferBuilder builder, Offset<IBaseCurve> offsetCurveOffset)
		{
			builder.AddOffset(4, offsetCurveOffset.Value, 0);
		}

		// Token: 0x0602B96A RID: 178538 RVA: 0x00600440 File Offset: 0x005FE640
		public static void AddCenteringWaitTime(FlatBufferBuilder builder, int centeringWaitTime)
		{
			builder.AddInt(5, centeringWaitTime, 0);
		}

		// Token: 0x0602B96B RID: 178539 RVA: 0x0060044B File Offset: 0x005FE64B
		public static void AddStartupWaitTime(FlatBufferBuilder builder, int startupWaitTime)
		{
			builder.AddInt(6, startupWaitTime, 0);
		}

		// Token: 0x0602B96C RID: 178540 RVA: 0x00600456 File Offset: 0x005FE656
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602B96D RID: 178541 RVA: 0x00600461 File Offset: 0x005FE661
		public static Offset<ICameraOffsetInMovementDirection> EndICameraOffsetInMovementDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICameraOffsetInMovementDirection>(builder.EndTable());
		}

		// Token: 0x0602B96E RID: 178542 RVA: 0x00600470 File Offset: 0x005FE670
		public ICameraOffsetInMovementDirectionT UnPack()
		{
			ICameraOffsetInMovementDirectionT cameraOffsetInMovementDirectionT = new ICameraOffsetInMovementDirectionT();
			this.UnPackTo(cameraOffsetInMovementDirectionT);
			return cameraOffsetInMovementDirectionT;
		}

		// Token: 0x0602B96F RID: 178543 RVA: 0x0060048C File Offset: 0x005FE68C
		public void UnPackTo(ICameraOffsetInMovementDirectionT _o)
		{
			_o.MinInterpolationSpeed = this.MinInterpolationSpeed;
			_o.MaxInterpolationSpeed = this.MaxInterpolationSpeed;
			_o.OffsetDistance1 = this.OffsetDistance1;
			_o.OffsetDistance2 = this.OffsetDistance2;
			_o.OffsetCurve = ((this.OffsetCurve != null) ? this.OffsetCurve.Value.UnPack() : null);
			_o.CenteringWaitTime = this.CenteringWaitTime;
			_o.StartupWaitTime = this.StartupWaitTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B970 RID: 178544 RVA: 0x0060051C File Offset: 0x005FE71C
		public static Offset<ICameraOffsetInMovementDirection> Pack(FlatBufferBuilder builder, ICameraOffsetInMovementDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraOffsetInMovementDirection>);
			}
			Offset<IBaseCurve> offsetCurveOffset = (_o.OffsetCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.OffsetCurve);
			return ICameraOffsetInMovementDirection.CreateICameraOffsetInMovementDirection(builder, _o.MinInterpolationSpeed, _o.MaxInterpolationSpeed, _o.OffsetDistance1, _o.OffsetDistance2, offsetCurveOffset, _o.CenteringWaitTime, _o.StartupWaitTime, _o.NullMask);
		}

		// Token: 0x04010813 RID: 67603
		private Table __p;
	}
}
