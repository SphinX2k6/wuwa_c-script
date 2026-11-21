using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006020 RID: 24608
	public struct ISwordRiderRailSpline : IFlatbufferObject
	{
		// Token: 0x1700B682 RID: 46722
		// (get) Token: 0x060297E5 RID: 169957 RVA: 0x005A9BAD File Offset: 0x005A7DAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060297E6 RID: 169958 RVA: 0x005A9BBA File Offset: 0x005A7DBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060297E7 RID: 169959 RVA: 0x005A9BC4 File Offset: 0x005A7DC4
		public static ISwordRiderRailSpline GetRootAsISwordRiderRailSpline(ByteBuffer _bb)
		{
			return ISwordRiderRailSpline.GetRootAsISwordRiderRailSpline(_bb, default(ISwordRiderRailSpline));
		}

		// Token: 0x060297E8 RID: 169960 RVA: 0x005A9BE0 File Offset: 0x005A7DE0
		public static ISwordRiderRailSpline GetRootAsISwordRiderRailSpline(ByteBuffer _bb, ISwordRiderRailSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060297E9 RID: 169961 RVA: 0x005A9BFD File Offset: 0x005A7DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060297EA RID: 169962 RVA: 0x005A9C0C File Offset: 0x005A7E0C
		public ISwordRiderRailSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B683 RID: 46723
		// (get) Token: 0x060297EB RID: 169963 RVA: 0x005A9C1C File Offset: 0x005A7E1C
		public ESplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineType.Common;
				}
				return (ESplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B684 RID: 46724
		// (get) Token: 0x060297EC RID: 169964 RVA: 0x005A9C58 File Offset: 0x005A7E58
		public ESwordRiderRailWall WallType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ESwordRiderRailWall.Inner;
				}
				return (ESwordRiderRailWall)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B685 RID: 46725
		// (get) Token: 0x060297ED RID: 169965 RVA: 0x005A9C94 File Offset: 0x005A7E94
		public string PathEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060297EE RID: 169966 RVA: 0x005A9CCB File Offset: 0x005A7ECB
		public Span<byte> GetPathEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060297EF RID: 169967 RVA: 0x005A9CDA File Offset: 0x005A7EDA
		public byte[] GetPathEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x060297F0 RID: 169968 RVA: 0x005A9CE8 File Offset: 0x005A7EE8
		public ISwordRiderRailSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISwordRiderRailSplinePoint?(default(ISwordRiderRailSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B686 RID: 46726
		// (get) Token: 0x060297F1 RID: 169969 RVA: 0x005A9D4C File Offset: 0x005A7F4C
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060297F2 RID: 169970 RVA: 0x005A9D78 File Offset: 0x005A7F78
		public static Offset<ISwordRiderRailSpline> CreateISwordRiderRailSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, ESwordRiderRailWall WallType = ESwordRiderRailWall.Inner, StringOffset PathEffectOffset = default(StringOffset), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ISwordRiderRailSpline.AddPoints(builder, PointsOffset);
			ISwordRiderRailSpline.AddPathEffect(builder, PathEffectOffset);
			ISwordRiderRailSpline.AddWallType(builder, WallType);
			ISwordRiderRailSpline.AddType(builder, Type);
			return ISwordRiderRailSpline.EndISwordRiderRailSpline(builder);
		}

		// Token: 0x060297F3 RID: 169971 RVA: 0x005A9DA4 File Offset: 0x005A7FA4
		public static void StartISwordRiderRailSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060297F4 RID: 169972 RVA: 0x005A9DAD File Offset: 0x005A7FAD
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060297F5 RID: 169973 RVA: 0x005A9DB8 File Offset: 0x005A7FB8
		public static void AddWallType(FlatBufferBuilder builder, ESwordRiderRailWall wallType)
		{
			builder.AddByte(1, (byte)wallType, 0);
		}

		// Token: 0x060297F6 RID: 169974 RVA: 0x005A9DC3 File Offset: 0x005A7FC3
		public static void AddPathEffect(FlatBufferBuilder builder, StringOffset pathEffectOffset)
		{
			builder.AddOffset(2, pathEffectOffset.Value, 0);
		}

		// Token: 0x060297F7 RID: 169975 RVA: 0x005A9DD3 File Offset: 0x005A7FD3
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(3, pointsOffset.Value, 0);
		}

		// Token: 0x060297F8 RID: 169976 RVA: 0x005A9DE4 File Offset: 0x005A7FE4
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ISwordRiderRailSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060297F9 RID: 169977 RVA: 0x005A9E24 File Offset: 0x005A8024
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ISwordRiderRailSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297FA RID: 169978 RVA: 0x005A9E3E File Offset: 0x005A803E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISwordRiderRailSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060297FB RID: 169979 RVA: 0x005A9E5C File Offset: 0x005A805C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060297FC RID: 169980 RVA: 0x005A9E75 File Offset: 0x005A8075
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060297FD RID: 169981 RVA: 0x005A9E80 File Offset: 0x005A8080
		public static Offset<ISwordRiderRailSpline> EndISwordRiderRailSpline(FlatBufferBuilder builder)
		{
			return new Offset<ISwordRiderRailSpline>(builder.EndTable());
		}

		// Token: 0x060297FE RID: 169982 RVA: 0x005A9E90 File Offset: 0x005A8090
		public ISwordRiderRailSplineT UnPack()
		{
			ISwordRiderRailSplineT swordRiderRailSplineT = new ISwordRiderRailSplineT();
			this.UnPackTo(swordRiderRailSplineT);
			return swordRiderRailSplineT;
		}

		// Token: 0x060297FF RID: 169983 RVA: 0x005A9EAC File Offset: 0x005A80AC
		public void UnPackTo(ISwordRiderRailSplineT _o)
		{
			_o.Type = this.Type;
			_o.WallType = this.WallType;
			_o.PathEffect = this.PathEffect;
			_o.Points = new List<ISwordRiderRailSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029800 RID: 169984 RVA: 0x005A9F30 File Offset: 0x005A8130
		public static Offset<ISwordRiderRailSpline> Pack(FlatBufferBuilder builder, ISwordRiderRailSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwordRiderRailSpline>);
			}
			StringOffset pathEffectOffset = (_o.PathEffect == null) ? default(StringOffset) : builder.CreateString(_o.PathEffect);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ISwordRiderRailSplinePoint>[] array = new Offset<ISwordRiderRailSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISwordRiderRailSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ISwordRiderRailSpline.CreatePointsVector(builder, array);
			}
			return ISwordRiderRailSpline.CreateISwordRiderRailSpline(builder, _o.Type, _o.WallType, pathEffectOffset, pointsOffset);
		}

		// Token: 0x0400FD55 RID: 64853
		private Table __p;
	}
}
