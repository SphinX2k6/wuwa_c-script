using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD3 RID: 20435
	public struct ICommonSplinePoint : IFlatbufferObject
	{
		// Token: 0x17009404 RID: 37892
		// (get) Token: 0x060208B3 RID: 133299 RVA: 0x004868BC File Offset: 0x00484ABC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060208B4 RID: 133300 RVA: 0x004868C9 File Offset: 0x00484AC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060208B5 RID: 133301 RVA: 0x004868D0 File Offset: 0x00484AD0
		public static ICommonSplinePoint GetRootAsICommonSplinePoint(ByteBuffer _bb)
		{
			return ICommonSplinePoint.GetRootAsICommonSplinePoint(_bb, default(ICommonSplinePoint));
		}

		// Token: 0x060208B6 RID: 133302 RVA: 0x004868EC File Offset: 0x00484AEC
		public static ICommonSplinePoint GetRootAsICommonSplinePoint(ByteBuffer _bb, ICommonSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060208B7 RID: 133303 RVA: 0x00486909 File Offset: 0x00484B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060208B8 RID: 133304 RVA: 0x00486918 File Offset: 0x00484B18
		public ICommonSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009405 RID: 37893
		// (get) Token: 0x060208B9 RID: 133305 RVA: 0x00486928 File Offset: 0x00484B28
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

		// Token: 0x17009406 RID: 37894
		// (get) Token: 0x060208BA RID: 133306 RVA: 0x00486988 File Offset: 0x00484B88
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

		// Token: 0x17009407 RID: 37895
		// (get) Token: 0x060208BB RID: 133307 RVA: 0x004869E8 File Offset: 0x00484BE8
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

		// Token: 0x17009408 RID: 37896
		// (get) Token: 0x060208BC RID: 133308 RVA: 0x00486A48 File Offset: 0x00484C48
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

		// Token: 0x17009409 RID: 37897
		// (get) Token: 0x060208BD RID: 133309 RVA: 0x00486A88 File Offset: 0x00484C88
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

		// Token: 0x060208BE RID: 133310 RVA: 0x00486AE6 File Offset: 0x00484CE6
		public static Offset<ICommonSplinePoint> CreateICommonSplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(5);
			ICommonSplinePoint.AddRotation(builder, RotationOffset);
			ICommonSplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			ICommonSplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			ICommonSplinePoint.AddPosition(builder, PositionOffset);
			ICommonSplinePoint.AddLineType(builder, LineType);
			return ICommonSplinePoint.EndICommonSplinePoint(builder);
		}

		// Token: 0x060208BF RID: 133311 RVA: 0x00486B1A File Offset: 0x00484D1A
		public static void StartICommonSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060208C0 RID: 133312 RVA: 0x00486B23 File Offset: 0x00484D23
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060208C1 RID: 133313 RVA: 0x00486B33 File Offset: 0x00484D33
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060208C2 RID: 133314 RVA: 0x00486B43 File Offset: 0x00484D43
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060208C3 RID: 133315 RVA: 0x00486B53 File Offset: 0x00484D53
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060208C4 RID: 133316 RVA: 0x00486B5E File Offset: 0x00484D5E
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060208C5 RID: 133317 RVA: 0x00486B6E File Offset: 0x00484D6E
		public static Offset<ICommonSplinePoint> EndICommonSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ICommonSplinePoint>(builder.EndTable());
		}

		// Token: 0x060208C6 RID: 133318 RVA: 0x00486B7C File Offset: 0x00484D7C
		public ICommonSplinePointT UnPack()
		{
			ICommonSplinePointT commonSplinePointT = new ICommonSplinePointT();
			this.UnPackTo(commonSplinePointT);
			return commonSplinePointT;
		}

		// Token: 0x060208C7 RID: 133319 RVA: 0x00486B98 File Offset: 0x00484D98
		public void UnPackTo(ICommonSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x060208C8 RID: 133320 RVA: 0x00486C70 File Offset: 0x00484E70
		public static Offset<ICommonSplinePoint> Pack(FlatBufferBuilder builder, ICommonSplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonSplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return ICommonSplinePoint.CreateICommonSplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset);
		}

		// Token: 0x0400DEBB RID: 57019
		private Table __p;
	}
}
