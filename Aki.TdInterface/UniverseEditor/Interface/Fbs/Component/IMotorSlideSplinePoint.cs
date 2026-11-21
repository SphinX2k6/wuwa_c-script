using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6D RID: 23405
	public struct IMotorSlideSplinePoint : IFlatbufferObject
	{
		// Token: 0x1700AAF3 RID: 43763
		// (get) Token: 0x06026898 RID: 157848 RVA: 0x00547007 File Offset: 0x00545207
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026899 RID: 157849 RVA: 0x00547014 File Offset: 0x00545214
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602689A RID: 157850 RVA: 0x0054701C File Offset: 0x0054521C
		public static IMotorSlideSplinePoint GetRootAsIMotorSlideSplinePoint(ByteBuffer _bb)
		{
			return IMotorSlideSplinePoint.GetRootAsIMotorSlideSplinePoint(_bb, default(IMotorSlideSplinePoint));
		}

		// Token: 0x0602689B RID: 157851 RVA: 0x00547038 File Offset: 0x00545238
		public static IMotorSlideSplinePoint GetRootAsIMotorSlideSplinePoint(ByteBuffer _bb, IMotorSlideSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602689C RID: 157852 RVA: 0x00547055 File Offset: 0x00545255
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602689D RID: 157853 RVA: 0x00547064 File Offset: 0x00545264
		public IMotorSlideSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAF4 RID: 43764
		// (get) Token: 0x0602689E RID: 157854 RVA: 0x00547074 File Offset: 0x00545274
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AAF5 RID: 43765
		// (get) Token: 0x0602689F RID: 157855 RVA: 0x005470D4 File Offset: 0x005452D4
		public IVectorInfo? ArriveTangent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AAF6 RID: 43766
		// (get) Token: 0x060268A0 RID: 157856 RVA: 0x00547134 File Offset: 0x00545334
		public IVectorInfo? LeaveTangent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AAF7 RID: 43767
		// (get) Token: 0x060268A1 RID: 157857 RVA: 0x00547194 File Offset: 0x00545394
		public ESplineLine LineType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ESplineLine.Linear;
				}
				return (ESplineLine)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAF8 RID: 43768
		// (get) Token: 0x060268A2 RID: 157858 RVA: 0x005471D4 File Offset: 0x005453D4
		public IVectorInfo? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AAF9 RID: 43769
		// (get) Token: 0x060268A3 RID: 157859 RVA: 0x00547234 File Offset: 0x00545434
		public float MaxSpeed
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

		// Token: 0x1700AAFA RID: 43770
		// (get) Token: 0x060268A4 RID: 157860 RVA: 0x00547278 File Offset: 0x00545478
		public float AbsAcceleration
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

		// Token: 0x1700AAFB RID: 43771
		// (get) Token: 0x060268A5 RID: 157861 RVA: 0x005472BC File Offset: 0x005454BC
		public EMotorSlideOffDirection OffDirection
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EMotorSlideOffDirection.Left;
				}
				return (EMotorSlideOffDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAFC RID: 43772
		// (get) Token: 0x060268A6 RID: 157862 RVA: 0x005472FC File Offset: 0x005454FC
		public int LeftTargetId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAFD RID: 43773
		// (get) Token: 0x060268A7 RID: 157863 RVA: 0x0054733C File Offset: 0x0054553C
		public int RightTargetId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAFE RID: 43774
		// (get) Token: 0x060268A8 RID: 157864 RVA: 0x0054737C File Offset: 0x0054557C
		public int SubCameraTag
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAFF RID: 43775
		// (get) Token: 0x060268A9 RID: 157865 RVA: 0x005473BC File Offset: 0x005455BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060268AA RID: 157866 RVA: 0x005473FC File Offset: 0x005455FC
		public static Offset<IMotorSlideSplinePoint> CreateIMotorSlideSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), float MaxSpeed = 0f, float AbsAcceleration = 0f, EMotorSlideOffDirection OffDirection = EMotorSlideOffDirection.Left, int LeftTargetId = 0, int RightTargetId = 0, int SubCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(12);
			IMotorSlideSplinePoint.AddSubCameraTag(builder, SubCameraTag);
			IMotorSlideSplinePoint.AddRightTargetId(builder, RightTargetId);
			IMotorSlideSplinePoint.AddLeftTargetId(builder, LeftTargetId);
			IMotorSlideSplinePoint.AddAbsAcceleration(builder, AbsAcceleration);
			IMotorSlideSplinePoint.AddMaxSpeed(builder, MaxSpeed);
			IMotorSlideSplinePoint.AddRotation(builder, RotationOffset);
			IMotorSlideSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IMotorSlideSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IMotorSlideSplinePoint.AddPosition(builder, PositionOffset);
			IMotorSlideSplinePoint.AddNullMask(builder, NullMask);
			IMotorSlideSplinePoint.AddOffDirection(builder, OffDirection);
			IMotorSlideSplinePoint.AddLineType(builder, LineType);
			return IMotorSlideSplinePoint.EndIMotorSlideSplinePoint(builder);
		}

		// Token: 0x060268AB RID: 157867 RVA: 0x00547474 File Offset: 0x00545674
		public static void StartIMotorSlideSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060268AC RID: 157868 RVA: 0x0054747E File Offset: 0x0054567E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060268AD RID: 157869 RVA: 0x0054748E File Offset: 0x0054568E
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060268AE RID: 157870 RVA: 0x0054749E File Offset: 0x0054569E
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060268AF RID: 157871 RVA: 0x005474AE File Offset: 0x005456AE
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060268B0 RID: 157872 RVA: 0x005474B9 File Offset: 0x005456B9
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060268B1 RID: 157873 RVA: 0x005474C9 File Offset: 0x005456C9
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(5, maxSpeed, 0.0);
		}

		// Token: 0x060268B2 RID: 157874 RVA: 0x005474DC File Offset: 0x005456DC
		public static void AddAbsAcceleration(FlatBufferBuilder builder, float absAcceleration)
		{
			builder.AddFloat(6, absAcceleration, 0.0);
		}

		// Token: 0x060268B3 RID: 157875 RVA: 0x005474EF File Offset: 0x005456EF
		public static void AddOffDirection(FlatBufferBuilder builder, EMotorSlideOffDirection offDirection)
		{
			builder.AddByte(7, (byte)offDirection, 0);
		}

		// Token: 0x060268B4 RID: 157876 RVA: 0x005474FA File Offset: 0x005456FA
		public static void AddLeftTargetId(FlatBufferBuilder builder, int leftTargetId)
		{
			builder.AddInt(8, leftTargetId, 0);
		}

		// Token: 0x060268B5 RID: 157877 RVA: 0x00547505 File Offset: 0x00545705
		public static void AddRightTargetId(FlatBufferBuilder builder, int rightTargetId)
		{
			builder.AddInt(9, rightTargetId, 0);
		}

		// Token: 0x060268B6 RID: 157878 RVA: 0x00547511 File Offset: 0x00545711
		public static void AddSubCameraTag(FlatBufferBuilder builder, int subCameraTag)
		{
			builder.AddInt(10, subCameraTag, 0);
		}

		// Token: 0x060268B7 RID: 157879 RVA: 0x0054751D File Offset: 0x0054571D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(11, nullMask, 0);
		}

		// Token: 0x060268B8 RID: 157880 RVA: 0x00547529 File Offset: 0x00545729
		public static Offset<IMotorSlideSplinePoint> EndIMotorSlideSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSlideSplinePoint>(builder.EndTable());
		}

		// Token: 0x060268B9 RID: 157881 RVA: 0x00547538 File Offset: 0x00545738
		public IMotorSlideSplinePointT UnPack()
		{
			IMotorSlideSplinePointT motorSlideSplinePointT = new IMotorSlideSplinePointT();
			this.UnPackTo(motorSlideSplinePointT);
			return motorSlideSplinePointT;
		}

		// Token: 0x060268BA RID: 157882 RVA: 0x00547554 File Offset: 0x00545754
		public void UnPackTo(IMotorSlideSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.MaxSpeed = this.MaxSpeed;
			_o.AbsAcceleration = this.AbsAcceleration;
			_o.OffDirection = this.OffDirection;
			_o.LeftTargetId = this.LeftTargetId;
			_o.RightTargetId = this.RightTargetId;
			_o.SubCameraTag = this.SubCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060268BB RID: 157883 RVA: 0x00547680 File Offset: 0x00545880
		public static Offset<IMotorSlideSplinePoint> Pack(FlatBufferBuilder builder, IMotorSlideSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSlideSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IMotorSlideSplinePoint.CreateIMotorSlideSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, _o.MaxSpeed, _o.AbsAcceleration, _o.OffDirection, _o.LeftTargetId, _o.RightTargetId, _o.SubCameraTag, _o.NullMask);
		}

		// Token: 0x0400F587 RID: 62855
		private Table __p;
	}
}
