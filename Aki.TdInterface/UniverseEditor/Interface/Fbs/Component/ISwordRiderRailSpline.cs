using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A13 RID: 23059
	public struct ISwordRiderRailSpline : IFlatbufferObject
	{
		// Token: 0x1700AD4A RID: 44362
		// (get) Token: 0x0602726D RID: 160365 RVA: 0x00562BE9 File Offset: 0x00560DE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602726E RID: 160366 RVA: 0x00562BF6 File Offset: 0x00560DF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602726F RID: 160367 RVA: 0x00562C00 File Offset: 0x00560E00
		public static ISwordRiderRailSpline GetRootAsISwordRiderRailSpline(ByteBuffer _bb)
		{
			return ISwordRiderRailSpline.GetRootAsISwordRiderRailSpline(_bb, default(ISwordRiderRailSpline));
		}

		// Token: 0x06027270 RID: 160368 RVA: 0x00562C1C File Offset: 0x00560E1C
		public static ISwordRiderRailSpline GetRootAsISwordRiderRailSpline(ByteBuffer _bb, ISwordRiderRailSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027271 RID: 160369 RVA: 0x00562C39 File Offset: 0x00560E39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027272 RID: 160370 RVA: 0x00562C48 File Offset: 0x00560E48
		public ISwordRiderRailSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD4B RID: 44363
		// (get) Token: 0x06027273 RID: 160371 RVA: 0x00562C58 File Offset: 0x00560E58
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

		// Token: 0x1700AD4C RID: 44364
		// (get) Token: 0x06027274 RID: 160372 RVA: 0x00562C94 File Offset: 0x00560E94
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

		// Token: 0x1700AD4D RID: 44365
		// (get) Token: 0x06027275 RID: 160373 RVA: 0x00562CD0 File Offset: 0x00560ED0
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

		// Token: 0x06027276 RID: 160374 RVA: 0x00562D07 File Offset: 0x00560F07
		public Span<byte> GetPathEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027277 RID: 160375 RVA: 0x00562D16 File Offset: 0x00560F16
		public byte[] GetPathEffectArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06027278 RID: 160376 RVA: 0x00562D24 File Offset: 0x00560F24
		public ISwordRiderRailSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new ISwordRiderRailSplinePoint?(default(ISwordRiderRailSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AD4E RID: 44366
		// (get) Token: 0x06027279 RID: 160377 RVA: 0x00562D88 File Offset: 0x00560F88
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

		// Token: 0x0602727A RID: 160378 RVA: 0x00562DB4 File Offset: 0x00560FB4
		public static Offset<ISwordRiderRailSpline> CreateISwordRiderRailSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, ESwordRiderRailWall WallType = ESwordRiderRailWall.Inner, StringOffset PathEffectOffset = default(StringOffset), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			ISwordRiderRailSpline.AddPoints(builder, PointsOffset);
			ISwordRiderRailSpline.AddPathEffect(builder, PathEffectOffset);
			ISwordRiderRailSpline.AddWallType(builder, WallType);
			ISwordRiderRailSpline.AddType(builder, Type);
			return ISwordRiderRailSpline.EndISwordRiderRailSpline(builder);
		}

		// Token: 0x0602727B RID: 160379 RVA: 0x00562DE0 File Offset: 0x00560FE0
		public static void StartISwordRiderRailSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602727C RID: 160380 RVA: 0x00562DE9 File Offset: 0x00560FE9
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602727D RID: 160381 RVA: 0x00562DF4 File Offset: 0x00560FF4
		public static void AddWallType(FlatBufferBuilder builder, ESwordRiderRailWall wallType)
		{
			builder.AddByte(1, (byte)wallType, 0);
		}

		// Token: 0x0602727E RID: 160382 RVA: 0x00562DFF File Offset: 0x00560FFF
		public static void AddPathEffect(FlatBufferBuilder builder, StringOffset pathEffectOffset)
		{
			builder.AddOffset(2, pathEffectOffset.Value, 0);
		}

		// Token: 0x0602727F RID: 160383 RVA: 0x00562E0F File Offset: 0x0056100F
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(3, pointsOffset.Value, 0);
		}

		// Token: 0x06027280 RID: 160384 RVA: 0x00562E20 File Offset: 0x00561020
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ISwordRiderRailSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027281 RID: 160385 RVA: 0x00562E60 File Offset: 0x00561060
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ISwordRiderRailSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027282 RID: 160386 RVA: 0x00562E7A File Offset: 0x0056107A
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISwordRiderRailSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027283 RID: 160387 RVA: 0x00562E98 File Offset: 0x00561098
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISwordRiderRailSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027284 RID: 160388 RVA: 0x00562EB1 File Offset: 0x005610B1
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027285 RID: 160389 RVA: 0x00562EBC File Offset: 0x005610BC
		public static Offset<ISwordRiderRailSpline> EndISwordRiderRailSpline(FlatBufferBuilder builder)
		{
			return new Offset<ISwordRiderRailSpline>(builder.EndTable());
		}

		// Token: 0x06027286 RID: 160390 RVA: 0x00562ECC File Offset: 0x005610CC
		public ISwordRiderRailSplineT UnPack()
		{
			ISwordRiderRailSplineT swordRiderRailSplineT = new ISwordRiderRailSplineT();
			this.UnPackTo(swordRiderRailSplineT);
			return swordRiderRailSplineT;
		}

		// Token: 0x06027287 RID: 160391 RVA: 0x00562EE8 File Offset: 0x005610E8
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

		// Token: 0x06027288 RID: 160392 RVA: 0x00562F6C File Offset: 0x0056116C
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

		// Token: 0x0400F05E RID: 61534
		private Table __p;
	}
}
