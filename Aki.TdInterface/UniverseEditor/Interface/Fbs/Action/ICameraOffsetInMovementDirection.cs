using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006901 RID: 26881
	public struct ICameraOffsetInMovementDirection : IFlatbufferObject
	{
		// Token: 0x1700C5CD RID: 50637
		// (get) Token: 0x0602E0B6 RID: 188598 RVA: 0x0064AEFC File Offset: 0x006490FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0B7 RID: 188599 RVA: 0x0064AF09 File Offset: 0x00649109
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0B8 RID: 188600 RVA: 0x0064AF10 File Offset: 0x00649110
		public static ICameraOffsetInMovementDirection GetRootAsICameraOffsetInMovementDirection(ByteBuffer _bb)
		{
			return ICameraOffsetInMovementDirection.GetRootAsICameraOffsetInMovementDirection(_bb, default(ICameraOffsetInMovementDirection));
		}

		// Token: 0x0602E0B9 RID: 188601 RVA: 0x0064AF2C File Offset: 0x0064912C
		public static ICameraOffsetInMovementDirection GetRootAsICameraOffsetInMovementDirection(ByteBuffer _bb, ICameraOffsetInMovementDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0BA RID: 188602 RVA: 0x0064AF49 File Offset: 0x00649149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0BB RID: 188603 RVA: 0x0064AF58 File Offset: 0x00649158
		public ICameraOffsetInMovementDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5CE RID: 50638
		// (get) Token: 0x0602E0BC RID: 188604 RVA: 0x0064AF68 File Offset: 0x00649168
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

		// Token: 0x1700C5CF RID: 50639
		// (get) Token: 0x0602E0BD RID: 188605 RVA: 0x0064AFA8 File Offset: 0x006491A8
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

		// Token: 0x1700C5D0 RID: 50640
		// (get) Token: 0x0602E0BE RID: 188606 RVA: 0x0064AFE8 File Offset: 0x006491E8
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

		// Token: 0x1700C5D1 RID: 50641
		// (get) Token: 0x0602E0BF RID: 188607 RVA: 0x0064B028 File Offset: 0x00649228
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

		// Token: 0x1700C5D2 RID: 50642
		// (get) Token: 0x0602E0C0 RID: 188608 RVA: 0x0064B06C File Offset: 0x0064926C
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

		// Token: 0x1700C5D3 RID: 50643
		// (get) Token: 0x0602E0C1 RID: 188609 RVA: 0x0064B0CC File Offset: 0x006492CC
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

		// Token: 0x1700C5D4 RID: 50644
		// (get) Token: 0x0602E0C2 RID: 188610 RVA: 0x0064B10C File Offset: 0x0064930C
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

		// Token: 0x1700C5D5 RID: 50645
		// (get) Token: 0x0602E0C3 RID: 188611 RVA: 0x0064B14C File Offset: 0x0064934C
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

		// Token: 0x0602E0C4 RID: 188612 RVA: 0x0064B18C File Offset: 0x0064938C
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

		// Token: 0x0602E0C5 RID: 188613 RVA: 0x0064B1E3 File Offset: 0x006493E3
		public static void StartICameraOffsetInMovementDirection(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602E0C6 RID: 188614 RVA: 0x0064B1EC File Offset: 0x006493EC
		public static void AddMinInterpolationSpeed(FlatBufferBuilder builder, float minInterpolationSpeed)
		{
			builder.AddFloat(0, minInterpolationSpeed, 0.0);
		}

		// Token: 0x0602E0C7 RID: 188615 RVA: 0x0064B1FF File Offset: 0x006493FF
		public static void AddMaxInterpolationSpeed(FlatBufferBuilder builder, float maxInterpolationSpeed)
		{
			builder.AddFloat(1, maxInterpolationSpeed, 0.0);
		}

		// Token: 0x0602E0C8 RID: 188616 RVA: 0x0064B212 File Offset: 0x00649412
		public static void AddOffsetDistance1(FlatBufferBuilder builder, float offsetDistance1)
		{
			builder.AddFloat(2, offsetDistance1, 0.0);
		}

		// Token: 0x0602E0C9 RID: 188617 RVA: 0x0064B225 File Offset: 0x00649425
		public static void AddOffsetDistance2(FlatBufferBuilder builder, float offsetDistance2)
		{
			builder.AddFloat(3, offsetDistance2, 0.0);
		}

		// Token: 0x0602E0CA RID: 188618 RVA: 0x0064B238 File Offset: 0x00649438
		public static void AddOffsetCurve(FlatBufferBuilder builder, Offset<IBaseCurve> offsetCurveOffset)
		{
			builder.AddOffset(4, offsetCurveOffset.Value, 0);
		}

		// Token: 0x0602E0CB RID: 188619 RVA: 0x0064B248 File Offset: 0x00649448
		public static void AddCenteringWaitTime(FlatBufferBuilder builder, int centeringWaitTime)
		{
			builder.AddInt(5, centeringWaitTime, 0);
		}

		// Token: 0x0602E0CC RID: 188620 RVA: 0x0064B253 File Offset: 0x00649453
		public static void AddStartupWaitTime(FlatBufferBuilder builder, int startupWaitTime)
		{
			builder.AddInt(6, startupWaitTime, 0);
		}

		// Token: 0x0602E0CD RID: 188621 RVA: 0x0064B25E File Offset: 0x0064945E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602E0CE RID: 188622 RVA: 0x0064B269 File Offset: 0x00649469
		public static Offset<ICameraOffsetInMovementDirection> EndICameraOffsetInMovementDirection(FlatBufferBuilder builder)
		{
			return new Offset<ICameraOffsetInMovementDirection>(builder.EndTable());
		}

		// Token: 0x0602E0CF RID: 188623 RVA: 0x0064B278 File Offset: 0x00649478
		public ICameraOffsetInMovementDirectionT UnPack()
		{
			ICameraOffsetInMovementDirectionT cameraOffsetInMovementDirectionT = new ICameraOffsetInMovementDirectionT();
			this.UnPackTo(cameraOffsetInMovementDirectionT);
			return cameraOffsetInMovementDirectionT;
		}

		// Token: 0x0602E0D0 RID: 188624 RVA: 0x0064B294 File Offset: 0x00649494
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

		// Token: 0x0602E0D1 RID: 188625 RVA: 0x0064B324 File Offset: 0x00649524
		public static Offset<ICameraOffsetInMovementDirection> Pack(FlatBufferBuilder builder, ICameraOffsetInMovementDirectionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraOffsetInMovementDirection>);
			}
			Offset<IBaseCurve> offsetCurveOffset = (_o.OffsetCurve == null) ? default(Offset<IBaseCurve>) : IBaseCurve.Pack(builder, _o.OffsetCurve);
			return ICameraOffsetInMovementDirection.CreateICameraOffsetInMovementDirection(builder, _o.MinInterpolationSpeed, _o.MaxInterpolationSpeed, _o.OffsetDistance1, _o.OffsetDistance2, offsetCurveOffset, _o.CenteringWaitTime, _o.StartupWaitTime, _o.NullMask);
		}

		// Token: 0x04011628 RID: 71208
		private Table __p;
	}
}
