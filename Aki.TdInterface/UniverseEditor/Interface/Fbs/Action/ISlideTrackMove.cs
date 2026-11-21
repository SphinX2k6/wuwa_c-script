using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007923 RID: 31011
	public struct ISlideTrackMove : IFlatbufferObject
	{
		// Token: 0x1700E373 RID: 58227
		// (get) Token: 0x060369A8 RID: 223656 RVA: 0x0074EBF2 File Offset: 0x0074CDF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369A9 RID: 223657 RVA: 0x0074EBFF File Offset: 0x0074CDFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369AA RID: 223658 RVA: 0x0074EC08 File Offset: 0x0074CE08
		public static ISlideTrackMove GetRootAsISlideTrackMove(ByteBuffer _bb)
		{
			return ISlideTrackMove.GetRootAsISlideTrackMove(_bb, default(ISlideTrackMove));
		}

		// Token: 0x060369AB RID: 223659 RVA: 0x0074EC24 File Offset: 0x0074CE24
		public static ISlideTrackMove GetRootAsISlideTrackMove(ByteBuffer _bb, ISlideTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369AC RID: 223660 RVA: 0x0074EC41 File Offset: 0x0074CE41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369AD RID: 223661 RVA: 0x0074EC50 File Offset: 0x0074CE50
		public ISlideTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E374 RID: 58228
		// (get) Token: 0x060369AE RID: 223662 RVA: 0x0074EC60 File Offset: 0x0074CE60
		public ESplineMovePattern Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMovePattern.PathLine;
				}
				return (ESplineMovePattern)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E375 RID: 58229
		// (get) Token: 0x060369AF RID: 223663 RVA: 0x0074EC9C File Offset: 0x0074CE9C
		public float MaxOffsetDistance
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

		// Token: 0x1700E376 RID: 58230
		// (get) Token: 0x060369B0 RID: 223664 RVA: 0x0074ECDC File Offset: 0x0074CEDC
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E377 RID: 58231
		// (get) Token: 0x060369B1 RID: 223665 RVA: 0x0074ED1C File Offset: 0x0074CF1C
		public float LayerVerticalLimit
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

		// Token: 0x1700E378 RID: 58232
		// (get) Token: 0x060369B2 RID: 223666 RVA: 0x0074ED60 File Offset: 0x0074CF60
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E379 RID: 58233
		// (get) Token: 0x060369B3 RID: 223667 RVA: 0x0074EDA0 File Offset: 0x0074CFA0
		public float GravitySwitchAngularVelocity
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

		// Token: 0x1700E37A RID: 58234
		// (get) Token: 0x060369B4 RID: 223668 RVA: 0x0074EDE4 File Offset: 0x0074CFE4
		public int AutoExitDistance
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

		// Token: 0x1700E37B RID: 58235
		// (get) Token: 0x060369B5 RID: 223669 RVA: 0x0074EE24 File Offset: 0x0074D024
		public float DirectionAngleLimit
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

		// Token: 0x1700E37C RID: 58236
		// (get) Token: 0x060369B6 RID: 223670 RVA: 0x0074EE68 File Offset: 0x0074D068
		public float EdgeLimitCurveFactor
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

		// Token: 0x1700E37D RID: 58237
		// (get) Token: 0x060369B7 RID: 223671 RVA: 0x0074EEAC File Offset: 0x0074D0AC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060369B8 RID: 223672 RVA: 0x0074EEEC File Offset: 0x0074D0EC
		public static Offset<ISlideTrackMove> CreateISlideTrackMove(FlatBufferBuilder builder, ESplineMovePattern Type = ESplineMovePattern.PathLine, float MaxOffsetDistance = 0f, bool IsOneWay = false, float LayerVerticalLimit = 0f, bool DynamicGravity = false, float GravitySwitchAngularVelocity = 0f, int AutoExitDistance = 0, float DirectionAngleLimit = 0f, float EdgeLimitCurveFactor = 0f, byte NullMask = 0)
		{
			builder.StartTable(10);
			ISlideTrackMove.AddEdgeLimitCurveFactor(builder, EdgeLimitCurveFactor);
			ISlideTrackMove.AddDirectionAngleLimit(builder, DirectionAngleLimit);
			ISlideTrackMove.AddAutoExitDistance(builder, AutoExitDistance);
			ISlideTrackMove.AddGravitySwitchAngularVelocity(builder, GravitySwitchAngularVelocity);
			ISlideTrackMove.AddLayerVerticalLimit(builder, LayerVerticalLimit);
			ISlideTrackMove.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			ISlideTrackMove.AddNullMask(builder, NullMask);
			ISlideTrackMove.AddDynamicGravity(builder, DynamicGravity);
			ISlideTrackMove.AddIsOneWay(builder, IsOneWay);
			ISlideTrackMove.AddType(builder, Type);
			return ISlideTrackMove.EndISlideTrackMove(builder);
		}

		// Token: 0x060369B9 RID: 223673 RVA: 0x0074EF54 File Offset: 0x0074D154
		public static void StartISlideTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060369BA RID: 223674 RVA: 0x0074EF5E File Offset: 0x0074D15E
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060369BB RID: 223675 RVA: 0x0074EF69 File Offset: 0x0074D169
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x060369BC RID: 223676 RVA: 0x0074EF7C File Offset: 0x0074D17C
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x060369BD RID: 223677 RVA: 0x0074EF87 File Offset: 0x0074D187
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x060369BE RID: 223678 RVA: 0x0074EF9A File Offset: 0x0074D19A
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x060369BF RID: 223679 RVA: 0x0074EFA5 File Offset: 0x0074D1A5
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x060369C0 RID: 223680 RVA: 0x0074EFB8 File Offset: 0x0074D1B8
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x060369C1 RID: 223681 RVA: 0x0074EFC3 File Offset: 0x0074D1C3
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(7, directionAngleLimit, 0.0);
		}

		// Token: 0x060369C2 RID: 223682 RVA: 0x0074EFD6 File Offset: 0x0074D1D6
		public static void AddEdgeLimitCurveFactor(FlatBufferBuilder builder, float edgeLimitCurveFactor)
		{
			builder.AddFloat(8, edgeLimitCurveFactor, 0.0);
		}

		// Token: 0x060369C3 RID: 223683 RVA: 0x0074EFE9 File Offset: 0x0074D1E9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060369C4 RID: 223684 RVA: 0x0074EFF5 File Offset: 0x0074D1F5
		public static Offset<ISlideTrackMove> EndISlideTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ISlideTrackMove>(builder.EndTable());
		}

		// Token: 0x060369C5 RID: 223685 RVA: 0x0074F004 File Offset: 0x0074D204
		public ISlideTrackMoveT UnPack()
		{
			ISlideTrackMoveT slideTrackMoveT = new ISlideTrackMoveT();
			this.UnPackTo(slideTrackMoveT);
			return slideTrackMoveT;
		}

		// Token: 0x060369C6 RID: 223686 RVA: 0x0074F020 File Offset: 0x0074D220
		public void UnPackTo(ISlideTrackMoveT _o)
		{
			_o.Type = this.Type;
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.IsOneWay = this.IsOneWay;
			_o.LayerVerticalLimit = this.LayerVerticalLimit;
			_o.DynamicGravity = this.DynamicGravity;
			_o.GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity;
			_o.AutoExitDistance = this.AutoExitDistance;
			_o.DirectionAngleLimit = this.DirectionAngleLimit;
			_o.EdgeLimitCurveFactor = this.EdgeLimitCurveFactor;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060369C7 RID: 223687 RVA: 0x0074F0A8 File Offset: 0x0074D2A8
		public static Offset<ISlideTrackMove> Pack(FlatBufferBuilder builder, ISlideTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideTrackMove>);
			}
			return ISlideTrackMove.CreateISlideTrackMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DirectionAngleLimit, _o.EdgeLimitCurveFactor, _o.NullMask);
		}

		// Token: 0x04012BE4 RID: 76772
		private Table __p;
	}
}
