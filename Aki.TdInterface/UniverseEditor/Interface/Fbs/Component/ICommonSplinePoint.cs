using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005532 RID: 21810
	public struct ICommonSplinePoint : IFlatbufferObject
	{
		// Token: 0x17009BE5 RID: 39909
		// (get) Token: 0x060227CF RID: 141263 RVA: 0x004C027C File Offset: 0x004BE47C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227D0 RID: 141264 RVA: 0x004C0289 File Offset: 0x004BE489
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227D1 RID: 141265 RVA: 0x004C0290 File Offset: 0x004BE490
		public static ICommonSplinePoint GetRootAsICommonSplinePoint(ByteBuffer _bb)
		{
			return ICommonSplinePoint.GetRootAsICommonSplinePoint(_bb, default(ICommonSplinePoint));
		}

		// Token: 0x060227D2 RID: 141266 RVA: 0x004C02AC File Offset: 0x004BE4AC
		public static ICommonSplinePoint GetRootAsICommonSplinePoint(ByteBuffer _bb, ICommonSplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227D3 RID: 141267 RVA: 0x004C02C9 File Offset: 0x004BE4C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227D4 RID: 141268 RVA: 0x004C02D8 File Offset: 0x004BE4D8
		public ICommonSplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009BE6 RID: 39910
		// (get) Token: 0x060227D5 RID: 141269 RVA: 0x004C02E8 File Offset: 0x004BE4E8
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

		// Token: 0x17009BE7 RID: 39911
		// (get) Token: 0x060227D6 RID: 141270 RVA: 0x004C0348 File Offset: 0x004BE548
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

		// Token: 0x17009BE8 RID: 39912
		// (get) Token: 0x060227D7 RID: 141271 RVA: 0x004C03A8 File Offset: 0x004BE5A8
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

		// Token: 0x17009BE9 RID: 39913
		// (get) Token: 0x060227D8 RID: 141272 RVA: 0x004C0408 File Offset: 0x004BE608
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

		// Token: 0x17009BEA RID: 39914
		// (get) Token: 0x060227D9 RID: 141273 RVA: 0x004C0448 File Offset: 0x004BE648
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

		// Token: 0x060227DA RID: 141274 RVA: 0x004C04A6 File Offset: 0x004BE6A6
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

		// Token: 0x060227DB RID: 141275 RVA: 0x004C04DA File Offset: 0x004BE6DA
		public static void StartICommonSplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060227DC RID: 141276 RVA: 0x004C04E3 File Offset: 0x004BE6E3
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x060227DD RID: 141277 RVA: 0x004C04F3 File Offset: 0x004BE6F3
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x060227DE RID: 141278 RVA: 0x004C0503 File Offset: 0x004BE703
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x060227DF RID: 141279 RVA: 0x004C0513 File Offset: 0x004BE713
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x060227E0 RID: 141280 RVA: 0x004C051E File Offset: 0x004BE71E
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x060227E1 RID: 141281 RVA: 0x004C052E File Offset: 0x004BE72E
		public static Offset<ICommonSplinePoint> EndICommonSplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<ICommonSplinePoint>(builder.EndTable());
		}

		// Token: 0x060227E2 RID: 141282 RVA: 0x004C053C File Offset: 0x004BE73C
		public ICommonSplinePointT UnPack()
		{
			ICommonSplinePointT commonSplinePointT = new ICommonSplinePointT();
			this.UnPackTo(commonSplinePointT);
			return commonSplinePointT;
		}

		// Token: 0x060227E3 RID: 141283 RVA: 0x004C0558 File Offset: 0x004BE758
		public void UnPackTo(ICommonSplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x060227E4 RID: 141284 RVA: 0x004C0630 File Offset: 0x004BE830
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

		// Token: 0x0400EAAF RID: 60079
		private Table __p;
	}
}
