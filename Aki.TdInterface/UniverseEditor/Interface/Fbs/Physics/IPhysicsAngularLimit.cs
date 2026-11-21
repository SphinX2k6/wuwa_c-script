using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047AD RID: 18349
	public struct IPhysicsAngularLimit : IFlatbufferObject
	{
		// Token: 0x17007FCF RID: 32719
		// (get) Token: 0x0601B031 RID: 110641 RVA: 0x003D3A1E File Offset: 0x003D1C1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B032 RID: 110642 RVA: 0x003D3A2B File Offset: 0x003D1C2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B033 RID: 110643 RVA: 0x003D3A34 File Offset: 0x003D1C34
		public static IPhysicsAngularLimit GetRootAsIPhysicsAngularLimit(ByteBuffer _bb)
		{
			return IPhysicsAngularLimit.GetRootAsIPhysicsAngularLimit(_bb, default(IPhysicsAngularLimit));
		}

		// Token: 0x0601B034 RID: 110644 RVA: 0x003D3A50 File Offset: 0x003D1C50
		public static IPhysicsAngularLimit GetRootAsIPhysicsAngularLimit(ByteBuffer _bb, IPhysicsAngularLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B035 RID: 110645 RVA: 0x003D3A6D File Offset: 0x003D1C6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B036 RID: 110646 RVA: 0x003D3A7C File Offset: 0x003D1C7C
		public IPhysicsAngularLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FD0 RID: 32720
		// (get) Token: 0x0601B037 RID: 110647 RVA: 0x003D3A8C File Offset: 0x003D1C8C
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

		// Token: 0x0601B038 RID: 110648 RVA: 0x003D3AC8 File Offset: 0x003D1CC8
		public TTable? Swing1Motion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B039 RID: 110649 RVA: 0x003D3B0C File Offset: 0x003D1D0C
		public IAcmFree Swing1MotionAsIAcmFree()
		{
			return this.Swing1Motion<IAcmFree>().Value;
		}

		// Token: 0x0601B03A RID: 110650 RVA: 0x003D3B28 File Offset: 0x003D1D28
		public IAcmLimited Swing1MotionAsIAcmLimited()
		{
			return this.Swing1Motion<IAcmLimited>().Value;
		}

		// Token: 0x0601B03B RID: 110651 RVA: 0x003D3B44 File Offset: 0x003D1D44
		public IAcmLocked Swing1MotionAsIAcmLocked()
		{
			return this.Swing1Motion<IAcmLocked>().Value;
		}

		// Token: 0x17007FD1 RID: 32721
		// (get) Token: 0x0601B03C RID: 110652 RVA: 0x003D3B60 File Offset: 0x003D1D60
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

		// Token: 0x0601B03D RID: 110653 RVA: 0x003D3B9C File Offset: 0x003D1D9C
		public TTable? Swing2Motion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B03E RID: 110654 RVA: 0x003D3BE4 File Offset: 0x003D1DE4
		public IAcmFree Swing2MotionAsIAcmFree()
		{
			return this.Swing2Motion<IAcmFree>().Value;
		}

		// Token: 0x0601B03F RID: 110655 RVA: 0x003D3C00 File Offset: 0x003D1E00
		public IAcmLimited Swing2MotionAsIAcmLimited()
		{
			return this.Swing2Motion<IAcmLimited>().Value;
		}

		// Token: 0x0601B040 RID: 110656 RVA: 0x003D3C1C File Offset: 0x003D1E1C
		public IAcmLocked Swing2MotionAsIAcmLocked()
		{
			return this.Swing2Motion<IAcmLocked>().Value;
		}

		// Token: 0x17007FD2 RID: 32722
		// (get) Token: 0x0601B041 RID: 110657 RVA: 0x003D3C38 File Offset: 0x003D1E38
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

		// Token: 0x0601B042 RID: 110658 RVA: 0x003D3C78 File Offset: 0x003D1E78
		public TTable? TwistMotion<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B043 RID: 110659 RVA: 0x003D3CC0 File Offset: 0x003D1EC0
		public IAcmFree TwistMotionAsIAcmFree()
		{
			return this.TwistMotion<IAcmFree>().Value;
		}

		// Token: 0x0601B044 RID: 110660 RVA: 0x003D3CDC File Offset: 0x003D1EDC
		public IAcmLimited TwistMotionAsIAcmLimited()
		{
			return this.TwistMotion<IAcmLimited>().Value;
		}

		// Token: 0x0601B045 RID: 110661 RVA: 0x003D3CF8 File Offset: 0x003D1EF8
		public IAcmLocked TwistMotionAsIAcmLocked()
		{
			return this.TwistMotion<IAcmLocked>().Value;
		}

		// Token: 0x17007FD3 RID: 32723
		// (get) Token: 0x0601B046 RID: 110662 RVA: 0x003D3D14 File Offset: 0x003D1F14
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

		// Token: 0x0601B047 RID: 110663 RVA: 0x003D3D74 File Offset: 0x003D1F74
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

		// Token: 0x0601B048 RID: 110664 RVA: 0x003D3DC3 File Offset: 0x003D1FC3
		public static void StartIPhysicsAngularLimit(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601B049 RID: 110665 RVA: 0x003D3DCC File Offset: 0x003D1FCC
		public static void AddSwing1MotionType(FlatBufferBuilder builder, TAngularConstraintMotion swing1MotionType)
		{
			builder.AddByte(0, (byte)swing1MotionType, 0);
		}

		// Token: 0x0601B04A RID: 110666 RVA: 0x003D3DD7 File Offset: 0x003D1FD7
		public static void AddSwing1Motion(FlatBufferBuilder builder, int swing1MotionOffset)
		{
			builder.AddOffset(1, swing1MotionOffset, 0);
		}

		// Token: 0x0601B04B RID: 110667 RVA: 0x003D3DE2 File Offset: 0x003D1FE2
		public static void AddSwing2MotionType(FlatBufferBuilder builder, TAngularConstraintMotion swing2MotionType)
		{
			builder.AddByte(2, (byte)swing2MotionType, 0);
		}

		// Token: 0x0601B04C RID: 110668 RVA: 0x003D3DED File Offset: 0x003D1FED
		public static void AddSwing2Motion(FlatBufferBuilder builder, int swing2MotionOffset)
		{
			builder.AddOffset(3, swing2MotionOffset, 0);
		}

		// Token: 0x0601B04D RID: 110669 RVA: 0x003D3DF8 File Offset: 0x003D1FF8
		public static void AddTwistMotionType(FlatBufferBuilder builder, TAngularConstraintMotion twistMotionType)
		{
			builder.AddByte(4, (byte)twistMotionType, 0);
		}

		// Token: 0x0601B04E RID: 110670 RVA: 0x003D3E03 File Offset: 0x003D2003
		public static void AddTwistMotion(FlatBufferBuilder builder, int twistMotionOffset)
		{
			builder.AddOffset(5, twistMotionOffset, 0);
		}

		// Token: 0x0601B04F RID: 110671 RVA: 0x003D3E0E File Offset: 0x003D200E
		public static void AddAngularRotationOffset(FlatBufferBuilder builder, Offset<IVectorInfo> angularRotationOffsetOffset)
		{
			builder.AddOffset(6, angularRotationOffsetOffset.Value, 0);
		}

		// Token: 0x0601B050 RID: 110672 RVA: 0x003D3E1E File Offset: 0x003D201E
		public static Offset<IPhysicsAngularLimit> EndIPhysicsAngularLimit(FlatBufferBuilder builder)
		{
			return new Offset<IPhysicsAngularLimit>(builder.EndTable());
		}

		// Token: 0x0601B051 RID: 110673 RVA: 0x003D3E2C File Offset: 0x003D202C
		public IPhysicsAngularLimitT UnPack()
		{
			IPhysicsAngularLimitT physicsAngularLimitT = new IPhysicsAngularLimitT();
			this.UnPackTo(physicsAngularLimitT);
			return physicsAngularLimitT;
		}

		// Token: 0x0601B052 RID: 110674 RVA: 0x003D3E48 File Offset: 0x003D2048
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

		// Token: 0x0601B053 RID: 110675 RVA: 0x003D4128 File Offset: 0x003D2328
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

		// Token: 0x0400CB46 RID: 52038
		private Table __p;
	}
}
