using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200434B RID: 17227
	public struct IPhysicsAngularLimit : IFlatbufferObject
	{
		// Token: 0x1700799A RID: 31130
		// (get) Token: 0x060198A3 RID: 104611 RVA: 0x003A7FF6 File Offset: 0x003A61F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198A4 RID: 104612 RVA: 0x003A8003 File Offset: 0x003A6203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198A5 RID: 104613 RVA: 0x003A800C File Offset: 0x003A620C
		public static IPhysicsAngularLimit GetRootAsIPhysicsAngularLimit(ByteBuffer _bb)
		{
			return IPhysicsAngularLimit.GetRootAsIPhysicsAngularLimit(_bb, default(IPhysicsAngularLimit));
		}

		// Token: 0x060198A6 RID: 104614 RVA: 0x003A8028 File Offset: 0x003A6228
		public static IPhysicsAngularLimit GetRootAsIPhysicsAngularLimit(ByteBuffer _bb, IPhysicsAngularLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198A7 RID: 104615 RVA: 0x003A8045 File Offset: 0x003A6245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198A8 RID: 104616 RVA: 0x003A8054 File Offset: 0x003A6254
		public IPhysicsAngularLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700799B RID: 31131
		// (get) Token: 0x060198A9 RID: 104617 RVA: 0x003A8064 File Offset: 0x003A6264
		public TAngularConstraintMotion Swing1MotionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TAngularConstraintMotion.NONE;
				}
				return (TAngularConstraintMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060198AA RID: 104618 RVA: 0x003A80A0 File Offset: 0x003A62A0
		public TTable? Swing1Motion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060198AB RID: 104619 RVA: 0x003A80E4 File Offset: 0x003A62E4
		public IAcmFree Swing1MotionAsIAcmFree()
		{
			return this.Swing1Motion<IAcmFree>().Value;
		}

		// Token: 0x060198AC RID: 104620 RVA: 0x003A8100 File Offset: 0x003A6300
		public IAcmLimited Swing1MotionAsIAcmLimited()
		{
			return this.Swing1Motion<IAcmLimited>().Value;
		}

		// Token: 0x060198AD RID: 104621 RVA: 0x003A811C File Offset: 0x003A631C
		public IAcmLocked Swing1MotionAsIAcmLocked()
		{
			return this.Swing1Motion<IAcmLocked>().Value;
		}

		// Token: 0x1700799C RID: 31132
		// (get) Token: 0x060198AE RID: 104622 RVA: 0x003A8138 File Offset: 0x003A6338
		public TAngularConstraintMotion Swing2MotionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TAngularConstraintMotion.NONE;
				}
				return (TAngularConstraintMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060198AF RID: 104623 RVA: 0x003A8174 File Offset: 0x003A6374
		public TTable? Swing2Motion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060198B0 RID: 104624 RVA: 0x003A81BC File Offset: 0x003A63BC
		public IAcmFree Swing2MotionAsIAcmFree()
		{
			return this.Swing2Motion<IAcmFree>().Value;
		}

		// Token: 0x060198B1 RID: 104625 RVA: 0x003A81D8 File Offset: 0x003A63D8
		public IAcmLimited Swing2MotionAsIAcmLimited()
		{
			return this.Swing2Motion<IAcmLimited>().Value;
		}

		// Token: 0x060198B2 RID: 104626 RVA: 0x003A81F4 File Offset: 0x003A63F4
		public IAcmLocked Swing2MotionAsIAcmLocked()
		{
			return this.Swing2Motion<IAcmLocked>().Value;
		}

		// Token: 0x1700799D RID: 31133
		// (get) Token: 0x060198B3 RID: 104627 RVA: 0x003A8210 File Offset: 0x003A6410
		public TAngularConstraintMotion TwistMotionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TAngularConstraintMotion.NONE;
				}
				return (TAngularConstraintMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060198B4 RID: 104628 RVA: 0x003A8250 File Offset: 0x003A6450
		public TTable? TwistMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060198B5 RID: 104629 RVA: 0x003A8298 File Offset: 0x003A6498
		public IAcmFree TwistMotionAsIAcmFree()
		{
			return this.TwistMotion<IAcmFree>().Value;
		}

		// Token: 0x060198B6 RID: 104630 RVA: 0x003A82B4 File Offset: 0x003A64B4
		public IAcmLimited TwistMotionAsIAcmLimited()
		{
			return this.TwistMotion<IAcmLimited>().Value;
		}

		// Token: 0x060198B7 RID: 104631 RVA: 0x003A82D0 File Offset: 0x003A64D0
		public IAcmLocked TwistMotionAsIAcmLocked()
		{
			return this.TwistMotion<IAcmLocked>().Value;
		}

		// Token: 0x1700799E RID: 31134
		// (get) Token: 0x060198B8 RID: 104632 RVA: 0x003A82EC File Offset: 0x003A64EC
		public IVectorInfo? AngularRotationOffset
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060198B9 RID: 104633 RVA: 0x003A834C File Offset: 0x003A654C
		public static Offset<IPhysicsAngularLimit> CreateIPhysicsAngularLimit(FlatBufferBuilder builder, TAngularConstraintMotion Swing1Motion_type = TAngularConstraintMotion.NONE, int Swing1MotionOffset = 0, TAngularConstraintMotion Swing2Motion_type = TAngularConstraintMotion.NONE, int Swing2MotionOffset = 0, TAngularConstraintMotion TwistMotion_type = TAngularConstraintMotion.NONE, int TwistMotionOffset = 0, Offset<IVectorInfo> AngularRotationOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(7);
			IPhysicsAngularLimit.AddAngularRotationOffset(builder, AngularRotationOffsetOffset);
			IPhysicsAngularLimit.AddTwistMotion(builder, TwistMotionOffset);
			IPhysicsAngularLimit.AddSwing2Motion(builder, Swing2MotionOffset);
			IPhysicsAngularLimit.AddSwing1Motion(builder, Swing1MotionOffset);
			IPhysicsAngularLimit.AddTwistMotionType(builder, TwistMotion_type);
			IPhysicsAngularLimit.AddSwing2MotionType(builder, Swing2Motion_type);
			IPhysicsAngularLimit.AddSwing1MotionType(builder, Swing1Motion_type);
			return IPhysicsAngularLimit.EndIPhysicsAngularLimit(builder);
		}

		// Token: 0x060198BA RID: 104634 RVA: 0x003A839B File Offset: 0x003A659B
		public static void StartIPhysicsAngularLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060198BB RID: 104635 RVA: 0x003A83A4 File Offset: 0x003A65A4
		public static void AddSwing1MotionType(FlatBufferBuilder builder, TAngularConstraintMotion swing1MotionType)
		{
			builder.AddByte(0, (byte)swing1MotionType, 0);
		}

		// Token: 0x060198BC RID: 104636 RVA: 0x003A83AF File Offset: 0x003A65AF
		public static void AddSwing1Motion(FlatBufferBuilder builder, int swing1MotionOffset)
		{
			builder.AddOffset(1, swing1MotionOffset, 0);
		}

		// Token: 0x060198BD RID: 104637 RVA: 0x003A83BA File Offset: 0x003A65BA
		public static void AddSwing2MotionType(FlatBufferBuilder builder, TAngularConstraintMotion swing2MotionType)
		{
			builder.AddByte(2, (byte)swing2MotionType, 0);
		}

		// Token: 0x060198BE RID: 104638 RVA: 0x003A83C5 File Offset: 0x003A65C5
		public static void AddSwing2Motion(FlatBufferBuilder builder, int swing2MotionOffset)
		{
			builder.AddOffset(3, swing2MotionOffset, 0);
		}

		// Token: 0x060198BF RID: 104639 RVA: 0x003A83D0 File Offset: 0x003A65D0
		public static void AddTwistMotionType(FlatBufferBuilder builder, TAngularConstraintMotion twistMotionType)
		{
			builder.AddByte(4, (byte)twistMotionType, 0);
		}

		// Token: 0x060198C0 RID: 104640 RVA: 0x003A83DB File Offset: 0x003A65DB
		public static void AddTwistMotion(FlatBufferBuilder builder, int twistMotionOffset)
		{
			builder.AddOffset(5, twistMotionOffset, 0);
		}

		// Token: 0x060198C1 RID: 104641 RVA: 0x003A83E6 File Offset: 0x003A65E6
		public static void AddAngularRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> angularRotationOffsetOffset)
		{
			builder.AddOffset(6, angularRotationOffsetOffset.Value, 0);
		}

		// Token: 0x060198C2 RID: 104642 RVA: 0x003A83F6 File Offset: 0x003A65F6
		public static Offset<IPhysicsAngularLimit> EndIPhysicsAngularLimit(FlatBufferBuilder builder)
		{
			return new Offset<IPhysicsAngularLimit>(builder.EndTable());
		}

		// Token: 0x060198C3 RID: 104643 RVA: 0x003A8404 File Offset: 0x003A6604
		public IPhysicsAngularLimitT UnPack()
		{
			IPhysicsAngularLimitT physicsAngularLimitT = new IPhysicsAngularLimitT();
			this.UnPackTo(physicsAngularLimitT);
			return physicsAngularLimitT;
		}

		// Token: 0x060198C4 RID: 104644 RVA: 0x003A8420 File Offset: 0x003A6620
		public void UnPackTo(IPhysicsAngularLimitT _o)
		{
			_o.Swing1Motion = new TAngularConstraintMotionUnion();
			_o.Swing1Motion.Type = this.Swing1MotionType;
			switch (this.Swing1MotionType)
			{
			case TAngularConstraintMotion.IAcmFree:
				_o.Swing1Motion.Value = ((this.Swing1Motion<IAcmFree>() != null) ? this.Swing1Motion<IAcmFree>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLimited:
				_o.Swing1Motion.Value = ((this.Swing1Motion<IAcmLimited>() != null) ? this.Swing1Motion<IAcmLimited>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLocked:
				_o.Swing1Motion.Value = ((this.Swing1Motion<IAcmLocked>() != null) ? this.Swing1Motion<IAcmLocked>().Value.UnPack() : null);
				break;
			}
			_o.Swing2Motion = new TAngularConstraintMotionUnion();
			_o.Swing2Motion.Type = this.Swing2MotionType;
			switch (this.Swing2MotionType)
			{
			case TAngularConstraintMotion.IAcmFree:
				_o.Swing2Motion.Value = ((this.Swing2Motion<IAcmFree>() != null) ? this.Swing2Motion<IAcmFree>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLimited:
				_o.Swing2Motion.Value = ((this.Swing2Motion<IAcmLimited>() != null) ? this.Swing2Motion<IAcmLimited>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLocked:
				_o.Swing2Motion.Value = ((this.Swing2Motion<IAcmLocked>() != null) ? this.Swing2Motion<IAcmLocked>().Value.UnPack() : null);
				break;
			}
			_o.TwistMotion = new TAngularConstraintMotionUnion();
			_o.TwistMotion.Type = this.TwistMotionType;
			switch (this.TwistMotionType)
			{
			case TAngularConstraintMotion.IAcmFree:
				_o.TwistMotion.Value = ((this.TwistMotion<IAcmFree>() != null) ? this.TwistMotion<IAcmFree>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLimited:
				_o.TwistMotion.Value = ((this.TwistMotion<IAcmLimited>() != null) ? this.TwistMotion<IAcmLimited>().Value.UnPack() : null);
				break;
			case TAngularConstraintMotion.IAcmLocked:
				_o.TwistMotion.Value = ((this.TwistMotion<IAcmLocked>() != null) ? this.TwistMotion<IAcmLocked>().Value.UnPack() : null);
				break;
			}
			_o.AngularRotationOffset = ((this.AngularRotationOffset != null) ? this.AngularRotationOffset.Value.UnPack() : null);
		}

		// Token: 0x060198C5 RID: 104645 RVA: 0x003A8700 File Offset: 0x003A6900
		public static Offset<IPhysicsAngularLimit> Pack(FlatBufferBuilder builder, IPhysicsAngularLimitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhysicsAngularLimit>);
			}
			TAngularConstraintMotion swing1Motion_type = (_o.Swing1Motion == null) ? TAngularConstraintMotion.NONE : _o.Swing1Motion.Type;
			int swing1MotionOffset = (_o.Swing1Motion == null) ? 0 : TAngularConstraintMotionUnion.Pack(builder, _o.Swing1Motion);
			TAngularConstraintMotion swing2Motion_type = (_o.Swing2Motion == null) ? TAngularConstraintMotion.NONE : _o.Swing2Motion.Type;
			int swing2MotionOffset = (_o.Swing2Motion == null) ? 0 : TAngularConstraintMotionUnion.Pack(builder, _o.Swing2Motion);
			TAngularConstraintMotion twistMotion_type = (_o.TwistMotion == null) ? TAngularConstraintMotion.NONE : _o.TwistMotion.Type;
			int twistMotionOffset = (_o.TwistMotion == null) ? 0 : TAngularConstraintMotionUnion.Pack(builder, _o.TwistMotion);
			Offset<IVectorInfo> angularRotationOffsetOffset = (_o.AngularRotationOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.AngularRotationOffset);
			return IPhysicsAngularLimit.CreateIPhysicsAngularLimit(builder, swing1Motion_type, swing1MotionOffset, swing2Motion_type, swing2MotionOffset, twistMotion_type, twistMotionOffset, angularRotationOffsetOffset);
		}

		// Token: 0x0400C128 RID: 49448
		private Table __p;
	}
}
