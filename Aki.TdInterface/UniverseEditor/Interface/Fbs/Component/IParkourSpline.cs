using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C57 RID: 23639
	public struct IParkourSpline : IFlatbufferObject
	{
		// Token: 0x1700ADA4 RID: 44452
		// (get) Token: 0x0602731B RID: 160539 RVA: 0x0055E69A File Offset: 0x0055C89A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602731C RID: 160540 RVA: 0x0055E6A7 File Offset: 0x0055C8A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602731D RID: 160541 RVA: 0x0055E6B0 File Offset: 0x0055C8B0
		public static IParkourSpline GetRootAsIParkourSpline(ByteBuffer _bb)
		{
			return IParkourSpline.GetRootAsIParkourSpline(_bb, default(IParkourSpline));
		}

		// Token: 0x0602731E RID: 160542 RVA: 0x0055E6CC File Offset: 0x0055C8CC
		public static IParkourSpline GetRootAsIParkourSpline(ByteBuffer _bb, IParkourSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602731F RID: 160543 RVA: 0x0055E6E9 File Offset: 0x0055C8E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027320 RID: 160544 RVA: 0x0055E6F8 File Offset: 0x0055C8F8
		public IParkourSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADA5 RID: 44453
		// (get) Token: 0x06027321 RID: 160545 RVA: 0x0055E708 File Offset: 0x0055C908
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

		// Token: 0x1700ADA6 RID: 44454
		// (get) Token: 0x06027322 RID: 160546 RVA: 0x0055E744 File Offset: 0x0055C944
		public bool IsRequireToEnd
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADA7 RID: 44455
		// (get) Token: 0x06027323 RID: 160547 RVA: 0x0055E784 File Offset: 0x0055C984
		public int CheckPointsRequire
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ADA8 RID: 44456
		// (get) Token: 0x06027324 RID: 160548 RVA: 0x0055E7C0 File Offset: 0x0055C9C0
		public string CheckPointResource
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027325 RID: 160549 RVA: 0x0055E7F8 File Offset: 0x0055C9F8
		public Span<byte> GetCheckPointResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06027326 RID: 160550 RVA: 0x0055E808 File Offset: 0x0055CA08
		public byte[] GetCheckPointResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ADA9 RID: 44457
		// (get) Token: 0x06027327 RID: 160551 RVA: 0x0055E818 File Offset: 0x0055CA18
		public string CheckPointsDestroyRes
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027328 RID: 160552 RVA: 0x0055E850 File Offset: 0x0055CA50
		public Span<byte> GetCheckPointsDestroyResBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06027329 RID: 160553 RVA: 0x0055E860 File Offset: 0x0055CA60
		public byte[] GetCheckPointsDestroyResArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700ADAA RID: 44458
		// (get) Token: 0x0602732A RID: 160554 RVA: 0x0055E870 File Offset: 0x0055CA70
		public string StartResource
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602732B RID: 160555 RVA: 0x0055E8A8 File Offset: 0x0055CAA8
		public Span<byte> GetStartResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602732C RID: 160556 RVA: 0x0055E8B8 File Offset: 0x0055CAB8
		public byte[] GetStartResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700ADAB RID: 44459
		// (get) Token: 0x0602732D RID: 160557 RVA: 0x0055E8C8 File Offset: 0x0055CAC8
		public string EndResource
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602732E RID: 160558 RVA: 0x0055E900 File Offset: 0x0055CB00
		public Span<byte> GetEndResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602732F RID: 160559 RVA: 0x0055E910 File Offset: 0x0055CB10
		public byte[] GetEndResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x06027330 RID: 160560 RVA: 0x0055E920 File Offset: 0x0055CB20
		public IParkourSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IParkourSplinePoint?(default(IParkourSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ADAC RID: 44460
		// (get) Token: 0x06027331 RID: 160561 RVA: 0x0055E984 File Offset: 0x0055CB84
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027332 RID: 160562 RVA: 0x0055E9B0 File Offset: 0x0055CBB0
		public static Offset<IParkourSpline> CreateIParkourSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, bool IsRequireToEnd = false, int CheckPointsRequire = 0, StringOffset CheckPointResourceOffset = default(StringOffset), StringOffset CheckPointsDestroyResOffset = default(StringOffset), StringOffset StartResourceOffset = default(StringOffset), StringOffset EndResourceOffset = default(StringOffset), VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(8);
			IParkourSpline.AddPoints(builder, PointsOffset);
			IParkourSpline.AddEndResource(builder, EndResourceOffset);
			IParkourSpline.AddStartResource(builder, StartResourceOffset);
			IParkourSpline.AddCheckPointsDestroyRes(builder, CheckPointsDestroyResOffset);
			IParkourSpline.AddCheckPointResource(builder, CheckPointResourceOffset);
			IParkourSpline.AddCheckPointsRequire(builder, CheckPointsRequire);
			IParkourSpline.AddIsRequireToEnd(builder, IsRequireToEnd);
			IParkourSpline.AddType(builder, Type);
			return IParkourSpline.EndIParkourSpline(builder);
		}

		// Token: 0x06027333 RID: 160563 RVA: 0x0055EA07 File Offset: 0x0055CC07
		public static void StartIParkourSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06027334 RID: 160564 RVA: 0x0055EA10 File Offset: 0x0055CC10
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027335 RID: 160565 RVA: 0x0055EA1B File Offset: 0x0055CC1B
		public static void AddIsRequireToEnd(FlatBufferBuilder builder, bool isRequireToEnd)
		{
			builder.AddBool(1, isRequireToEnd, false);
		}

		// Token: 0x06027336 RID: 160566 RVA: 0x0055EA26 File Offset: 0x0055CC26
		public static void AddCheckPointsRequire(FlatBufferBuilder builder, int checkPointsRequire)
		{
			builder.AddInt(2, checkPointsRequire, 0);
		}

		// Token: 0x06027337 RID: 160567 RVA: 0x0055EA31 File Offset: 0x0055CC31
		public static void AddCheckPointResource(FlatBufferBuilder builder, StringOffset checkPointResourceOffset)
		{
			builder.AddOffset(3, checkPointResourceOffset.Value, 0);
		}

		// Token: 0x06027338 RID: 160568 RVA: 0x0055EA41 File Offset: 0x0055CC41
		public static void AddCheckPointsDestroyRes(FlatBufferBuilder builder, StringOffset checkPointsDestroyResOffset)
		{
			builder.AddOffset(4, checkPointsDestroyResOffset.Value, 0);
		}

		// Token: 0x06027339 RID: 160569 RVA: 0x0055EA51 File Offset: 0x0055CC51
		public static void AddStartResource(FlatBufferBuilder builder, StringOffset startResourceOffset)
		{
			builder.AddOffset(5, startResourceOffset.Value, 0);
		}

		// Token: 0x0602733A RID: 160570 RVA: 0x0055EA61 File Offset: 0x0055CC61
		public static void AddEndResource(FlatBufferBuilder builder, StringOffset endResourceOffset)
		{
			builder.AddOffset(6, endResourceOffset.Value, 0);
		}

		// Token: 0x0602733B RID: 160571 RVA: 0x0055EA71 File Offset: 0x0055CC71
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(7, pointsOffset.Value, 0);
		}

		// Token: 0x0602733C RID: 160572 RVA: 0x0055EA84 File Offset: 0x0055CC84
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IParkourSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602733D RID: 160573 RVA: 0x0055EAC4 File Offset: 0x0055CCC4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IParkourSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IParkourSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602733E RID: 160574 RVA: 0x0055EADE File Offset: 0x0055CCDE
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IParkourSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IParkourSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602733F RID: 160575 RVA: 0x0055EAFC File Offset: 0x0055CCFC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IParkourSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027340 RID: 160576 RVA: 0x0055EB15 File Offset: 0x0055CD15
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027341 RID: 160577 RVA: 0x0055EB20 File Offset: 0x0055CD20
		public static Offset<IParkourSpline> EndIParkourSpline(FlatBufferBuilder builder)
		{
			return new Offset<IParkourSpline>(builder.EndTable());
		}

		// Token: 0x06027342 RID: 160578 RVA: 0x0055EB30 File Offset: 0x0055CD30
		public IParkourSplineT UnPack()
		{
			IParkourSplineT parkourSplineT = new IParkourSplineT();
			this.UnPackTo(parkourSplineT);
			return parkourSplineT;
		}

		// Token: 0x06027343 RID: 160579 RVA: 0x0055EB4C File Offset: 0x0055CD4C
		public void UnPackTo(IParkourSplineT _o)
		{
			_o.Type = this.Type;
			_o.IsRequireToEnd = this.IsRequireToEnd;
			_o.CheckPointsRequire = this.CheckPointsRequire;
			_o.CheckPointResource = this.CheckPointResource;
			_o.CheckPointsDestroyRes = this.CheckPointsDestroyRes;
			_o.StartResource = this.StartResource;
			_o.EndResource = this.EndResource;
			_o.Points = new List<IParkourSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027344 RID: 160580 RVA: 0x0055EC00 File Offset: 0x0055CE00
		public static Offset<IParkourSpline> Pack(FlatBufferBuilder builder, IParkourSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParkourSpline>);
			}
			StringOffset checkPointResourceOffset = (_o.CheckPointResource == null) ? default(StringOffset) : builder.CreateString(_o.CheckPointResource);
			StringOffset checkPointsDestroyResOffset = (_o.CheckPointsDestroyRes == null) ? default(StringOffset) : builder.CreateString(_o.CheckPointsDestroyRes);
			StringOffset startResourceOffset = (_o.StartResource == null) ? default(StringOffset) : builder.CreateString(_o.StartResource);
			StringOffset endResourceOffset = (_o.EndResource == null) ? default(StringOffset) : builder.CreateString(_o.EndResource);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IParkourSplinePoint>[] array = new Offset<IParkourSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IParkourSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IParkourSpline.CreatePointsVector(builder, array);
			}
			return IParkourSpline.CreateIParkourSpline(builder, _o.Type, _o.IsRequireToEnd, _o.CheckPointsRequire, checkPointResourceOffset, checkPointsDestroyResOffset, startResourceOffset, endResourceOffset, pointsOffset);
		}

		// Token: 0x0400F746 RID: 63302
		private Table __p;
	}
}
