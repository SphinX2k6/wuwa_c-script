using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5C RID: 23388
	public struct IWaySplinePoint : IFlatbufferObject
	{
		// Token: 0x1700B0B0 RID: 45232
		// (get) Token: 0x06028043 RID: 163907 RVA: 0x00580715 File Offset: 0x0057E915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028044 RID: 163908 RVA: 0x00580722 File Offset: 0x0057E922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028045 RID: 163909 RVA: 0x0058072C File Offset: 0x0057E92C
		public static IWaySplinePoint GetRootAsIWaySplinePoint(ByteBuffer _bb)
		{
			return IWaySplinePoint.GetRootAsIWaySplinePoint(_bb, default(IWaySplinePoint));
		}

		// Token: 0x06028046 RID: 163910 RVA: 0x00580748 File Offset: 0x0057E948
		public static IWaySplinePoint GetRootAsIWaySplinePoint(ByteBuffer _bb, IWaySplinePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028047 RID: 163911 RVA: 0x00580765 File Offset: 0x0057E965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x00580774 File Offset: 0x0057E974
		public IWaySplinePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0B1 RID: 45233
		// (get) Token: 0x06028049 RID: 163913 RVA: 0x00580784 File Offset: 0x0057E984
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

		// Token: 0x1700B0B2 RID: 45234
		// (get) Token: 0x0602804A RID: 163914 RVA: 0x005807E4 File Offset: 0x0057E9E4
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

		// Token: 0x1700B0B3 RID: 45235
		// (get) Token: 0x0602804B RID: 163915 RVA: 0x00580844 File Offset: 0x0057EA44
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

		// Token: 0x1700B0B4 RID: 45236
		// (get) Token: 0x0602804C RID: 163916 RVA: 0x005808A4 File Offset: 0x0057EAA4
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

		// Token: 0x1700B0B5 RID: 45237
		// (get) Token: 0x0602804D RID: 163917 RVA: 0x005808E4 File Offset: 0x0057EAE4
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

		// Token: 0x1700B0B6 RID: 45238
		// (get) Token: 0x0602804E RID: 163918 RVA: 0x00580944 File Offset: 0x0057EB44
		public TWaySplinePointType PointTypeType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TWaySplinePointType.NONE;
				}
				return (TWaySplinePointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602804F RID: 163919 RVA: 0x00580984 File Offset: 0x0057EB84
		public TTable? PointType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028050 RID: 163920 RVA: 0x005809CC File Offset: 0x0057EBCC
		public IWaySplineCommonPoint PointTypeAsIWaySplineCommonPoint()
		{
			return this.PointType<IWaySplineCommonPoint>().Value;
		}

		// Token: 0x06028051 RID: 163921 RVA: 0x005809E8 File Offset: 0x0057EBE8
		public IWaySplineStartPoint PointTypeAsIWaySplineStartPoint()
		{
			return this.PointType<IWaySplineStartPoint>().Value;
		}

		// Token: 0x06028052 RID: 163922 RVA: 0x00580A04 File Offset: 0x0057EC04
		public static Offset<IWaySplinePoint> CreateIWaySplinePoint(FlatBufferBuilder builder, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ArriveTangentOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> LeaveTangentOffset = default(Offset<IVectorInfo>), ESplineLine LineType = ESplineLine.Linear, Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>), TWaySplinePointType PointType_type = TWaySplinePointType.NONE, int PointTypeOffset = 0)
		{
			builder.StartTable(7);
			IWaySplinePoint.AddPointType(builder, PointTypeOffset);
			IWaySplinePoint.AddRotation(builder, RotationOffset);
			IWaySplinePoint.AddLeaveTangent(builder, LeaveTangentOffset);
			IWaySplinePoint.AddArriveTangent(builder, ArriveTangentOffset);
			IWaySplinePoint.AddPosition(builder, PositionOffset);
			IWaySplinePoint.AddPointTypeType(builder, PointType_type);
			IWaySplinePoint.AddLineType(builder, LineType);
			return IWaySplinePoint.EndIWaySplinePoint(builder);
		}

		// Token: 0x06028053 RID: 163923 RVA: 0x00580A53 File Offset: 0x0057EC53
		public static void StartIWaySplinePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028054 RID: 163924 RVA: 0x00580A5C File Offset: 0x0057EC5C
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x06028055 RID: 163925 RVA: 0x00580A6C File Offset: 0x0057EC6C
		public static void AddArriveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> arriveTangentOffset)
		{
			builder.AddOffset(1, arriveTangentOffset.Value, 0);
		}

		// Token: 0x06028056 RID: 163926 RVA: 0x00580A7C File Offset: 0x0057EC7C
		public static void AddLeaveTangent(FlatBufferBuilder builder, Offset<IVectorInfo> leaveTangentOffset)
		{
			builder.AddOffset(2, leaveTangentOffset.Value, 0);
		}

		// Token: 0x06028057 RID: 163927 RVA: 0x00580A8C File Offset: 0x0057EC8C
		public static void AddLineType(FlatBufferBuilder builder, ESplineLine lineType)
		{
			builder.AddByte(3, (byte)lineType, 0);
		}

		// Token: 0x06028058 RID: 163928 RVA: 0x00580A97 File Offset: 0x0057EC97
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(4, rotationOffset.Value, 0);
		}

		// Token: 0x06028059 RID: 163929 RVA: 0x00580AA7 File Offset: 0x0057ECA7
		public static void AddPointTypeType(FlatBufferBuilder builder, TWaySplinePointType pointTypeType)
		{
			builder.AddByte(5, (byte)pointTypeType, 0);
		}

		// Token: 0x0602805A RID: 163930 RVA: 0x00580AB2 File Offset: 0x0057ECB2
		public static void AddPointType(FlatBufferBuilder builder, int pointTypeOffset)
		{
			builder.AddOffset(6, pointTypeOffset, 0);
		}

		// Token: 0x0602805B RID: 163931 RVA: 0x00580ABD File Offset: 0x0057ECBD
		public static Offset<IWaySplinePoint> EndIWaySplinePoint(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplinePoint>(builder.EndTable());
		}

		// Token: 0x0602805C RID: 163932 RVA: 0x00580ACC File Offset: 0x0057ECCC
		public IWaySplinePointT UnPack()
		{
			IWaySplinePointT waySplinePointT = new IWaySplinePointT();
			this.UnPackTo(waySplinePointT);
			return waySplinePointT;
		}

		// Token: 0x0602805D RID: 163933 RVA: 0x00580AE8 File Offset: 0x0057ECE8
		public void UnPackTo(IWaySplinePointT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.ArriveTangent = ((this.ArriveTangent != null) ? this.ArriveTangent.Value.UnPack() : null);
			_o.LeaveTangent = ((this.LeaveTangent != null) ? this.LeaveTangent.Value.UnPack() : null);
			_o.LineType = this.LineType;
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
			_o.PointType = new TWaySplinePointTypeUnion();
			_o.PointType.Type = this.PointTypeType;
			TWaySplinePointType pointTypeType = this.PointTypeType;
			if (pointTypeType == TWaySplinePointType.IWaySplineCommonPoint)
			{
				_o.PointType.Value = ((this.PointType<IWaySplineCommonPoint>() != null) ? this.PointType<IWaySplineCommonPoint>().Value.UnPack() : null);
				return;
			}
			if (pointTypeType != TWaySplinePointType.IWaySplineStartPoint)
			{
				return;
			}
			_o.PointType.Value = ((this.PointType<IWaySplineStartPoint>() != null) ? this.PointType<IWaySplineStartPoint>().Value.UnPack() : null);
		}

		// Token: 0x0602805E RID: 163934 RVA: 0x00580C58 File Offset: 0x0057EE58
		public static Offset<IWaySplinePoint> Pack(FlatBufferBuilder builder, IWaySplinePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplinePoint>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> arriveTangentOffset = (_o.ArriveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.ArriveTangent);
			Offset<IVectorInfo> leaveTangentOffset = (_o.LeaveTangent == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.LeaveTangent);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			TWaySplinePointType pointType_type = (_o.PointType == null) ? TWaySplinePointType.NONE : _o.PointType.Type;
			int pointTypeOffset = (_o.PointType == null) ? 0 : TWaySplinePointTypeUnion.Pack(builder, _o.PointType);
			return IWaySplinePoint.CreateIWaySplinePoint(builder, positionOffset, arriveTangentOffset, leaveTangentOffset, _o.LineType, rotationOffset, pointType_type, pointTypeOffset);
		}

		// Token: 0x0400F2A3 RID: 62115
		private Table __p;
	}
}
