using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007157 RID: 29015
	public struct ISlideTrackMove : IFlatbufferObject
	{
		// Token: 0x1700D78E RID: 55182
		// (get) Token: 0x060336FE RID: 210686 RVA: 0x006EE3E6 File Offset: 0x006EC5E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336FF RID: 210687 RVA: 0x006EE3F3 File Offset: 0x006EC5F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033700 RID: 210688 RVA: 0x006EE3FC File Offset: 0x006EC5FC
		public static ISlideTrackMove GetRootAsISlideTrackMove(ByteBuffer _bb)
		{
			return ISlideTrackMove.GetRootAsISlideTrackMove(_bb, default(ISlideTrackMove));
		}

		// Token: 0x06033701 RID: 210689 RVA: 0x006EE418 File Offset: 0x006EC618
		public static ISlideTrackMove GetRootAsISlideTrackMove(ByteBuffer _bb, ISlideTrackMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033702 RID: 210690 RVA: 0x006EE435 File Offset: 0x006EC635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033703 RID: 210691 RVA: 0x006EE444 File Offset: 0x006EC644
		public ISlideTrackMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D78F RID: 55183
		// (get) Token: 0x06033704 RID: 210692 RVA: 0x006EE454 File Offset: 0x006EC654
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

		// Token: 0x1700D790 RID: 55184
		// (get) Token: 0x06033705 RID: 210693 RVA: 0x006EE490 File Offset: 0x006EC690
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

		// Token: 0x1700D791 RID: 55185
		// (get) Token: 0x06033706 RID: 210694 RVA: 0x006EE4D0 File Offset: 0x006EC6D0
		public bool IsOneWay
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D792 RID: 55186
		// (get) Token: 0x06033707 RID: 210695 RVA: 0x006EE510 File Offset: 0x006EC710
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

		// Token: 0x1700D793 RID: 55187
		// (get) Token: 0x06033708 RID: 210696 RVA: 0x006EE554 File Offset: 0x006EC754
		public bool DynamicGravity
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D794 RID: 55188
		// (get) Token: 0x06033709 RID: 210697 RVA: 0x006EE594 File Offset: 0x006EC794
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

		// Token: 0x1700D795 RID: 55189
		// (get) Token: 0x0603370A RID: 210698 RVA: 0x006EE5D8 File Offset: 0x006EC7D8
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

		// Token: 0x1700D796 RID: 55190
		// (get) Token: 0x0603370B RID: 210699 RVA: 0x006EE618 File Offset: 0x006EC818
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

		// Token: 0x1700D797 RID: 55191
		// (get) Token: 0x0603370C RID: 210700 RVA: 0x006EE65C File Offset: 0x006EC85C
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

		// Token: 0x1700D798 RID: 55192
		// (get) Token: 0x0603370D RID: 210701 RVA: 0x006EE6A0 File Offset: 0x006EC8A0
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

		// Token: 0x0603370E RID: 210702 RVA: 0x006EE6E0 File Offset: 0x006EC8E0
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

		// Token: 0x0603370F RID: 210703 RVA: 0x006EE748 File Offset: 0x006EC948
		public static void StartISlideTrackMove(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06033710 RID: 210704 RVA: 0x006EE752 File Offset: 0x006EC952
		public static void AddType(FlatBufferBuilder builder, ESplineMovePattern type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033711 RID: 210705 RVA: 0x006EE75D File Offset: 0x006EC95D
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(1, maxOffsetDistance, 0.0);
		}

		// Token: 0x06033712 RID: 210706 RVA: 0x006EE770 File Offset: 0x006EC970
		public static void AddIsOneWay(FlatBufferBuilder builder, bool isOneWay)
		{
			builder.AddBool(2, isOneWay, false);
		}

		// Token: 0x06033713 RID: 210707 RVA: 0x006EE77B File Offset: 0x006EC97B
		public static void AddLayerVerticalLimit(FlatBufferBuilder builder, float layerVerticalLimit)
		{
			builder.AddFloat(3, layerVerticalLimit, 0.0);
		}

		// Token: 0x06033714 RID: 210708 RVA: 0x006EE78E File Offset: 0x006EC98E
		public static void AddDynamicGravity(FlatBufferBuilder builder, bool dynamicGravity)
		{
			builder.AddBool(4, dynamicGravity, false);
		}

		// Token: 0x06033715 RID: 210709 RVA: 0x006EE799 File Offset: 0x006EC999
		public static void AddGravitySwitchAngularVelocity(FlatBufferBuilder builder, float gravitySwitchAngularVelocity)
		{
			builder.AddFloat(5, gravitySwitchAngularVelocity, 0.0);
		}

		// Token: 0x06033716 RID: 210710 RVA: 0x006EE7AC File Offset: 0x006EC9AC
		public static void AddAutoExitDistance(FlatBufferBuilder builder, int autoExitDistance)
		{
			builder.AddInt(6, autoExitDistance, 0);
		}

		// Token: 0x06033717 RID: 210711 RVA: 0x006EE7B7 File Offset: 0x006EC9B7
		public static void AddDirectionAngleLimit(FlatBufferBuilder builder, float directionAngleLimit)
		{
			builder.AddFloat(7, directionAngleLimit, 0.0);
		}

		// Token: 0x06033718 RID: 210712 RVA: 0x006EE7CA File Offset: 0x006EC9CA
		public static void AddEdgeLimitCurveFactor(FlatBufferBuilder builder, float edgeLimitCurveFactor)
		{
			builder.AddFloat(8, edgeLimitCurveFactor, 0.0);
		}

		// Token: 0x06033719 RID: 210713 RVA: 0x006EE7DD File Offset: 0x006EC9DD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0603371A RID: 210714 RVA: 0x006EE7E9 File Offset: 0x006EC9E9
		public static Offset<ISlideTrackMove> EndISlideTrackMove(FlatBufferBuilder builder)
		{
			return new Offset<ISlideTrackMove>(builder.EndTable());
		}

		// Token: 0x0603371B RID: 210715 RVA: 0x006EE7F8 File Offset: 0x006EC9F8
		public ISlideTrackMoveT UnPack()
		{
			ISlideTrackMoveT slideTrackMoveT = new ISlideTrackMoveT();
			this.UnPackTo(slideTrackMoveT);
			return slideTrackMoveT;
		}

		// Token: 0x0603371C RID: 210716 RVA: 0x006EE814 File Offset: 0x006ECA14
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

		// Token: 0x0603371D RID: 210717 RVA: 0x006EE89C File Offset: 0x006ECA9C
		public static Offset<ISlideTrackMove> Pack(FlatBufferBuilder builder, ISlideTrackMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideTrackMove>);
			}
			return ISlideTrackMove.CreateISlideTrackMove(builder, _o.Type, _o.MaxOffsetDistance, _o.IsOneWay, _o.LayerVerticalLimit, _o.DynamicGravity, _o.GravitySwitchAngularVelocity, _o.AutoExitDistance, _o.DirectionAngleLimit, _o.EdgeLimitCurveFactor, _o.NullMask);
		}

		// Token: 0x04011BF5 RID: 72693
		private Table __p;
	}
}
