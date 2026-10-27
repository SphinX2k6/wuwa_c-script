using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B3 RID: 22195
	public struct IParkourSpline : IFlatbufferObject
	{
		// Token: 0x1700A510 RID: 42256
		// (get) Token: 0x060250C6 RID: 151750 RVA: 0x0051D752 File Offset: 0x0051B952
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060250C7 RID: 151751 RVA: 0x0051D75F File Offset: 0x0051B95F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060250C8 RID: 151752 RVA: 0x0051D768 File Offset: 0x0051B968
		public static IParkourSpline GetRootAsIParkourSpline(ByteBuffer _bb)
		{
			return IParkourSpline.GetRootAsIParkourSpline(_bb, default(IParkourSpline));
		}

		// Token: 0x060250C9 RID: 151753 RVA: 0x0051D784 File Offset: 0x0051B984
		public static IParkourSpline GetRootAsIParkourSpline(ByteBuffer _bb, IParkourSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060250CA RID: 151754 RVA: 0x0051D7A1 File Offset: 0x0051B9A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060250CB RID: 151755 RVA: 0x0051D7B0 File Offset: 0x0051B9B0
		public IParkourSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A511 RID: 42257
		// (get) Token: 0x060250CC RID: 151756 RVA: 0x0051D7C0 File Offset: 0x0051B9C0
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

		// Token: 0x1700A512 RID: 42258
		// (get) Token: 0x060250CD RID: 151757 RVA: 0x0051D7FC File Offset: 0x0051B9FC
		public bool IsRequireToEnd
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A513 RID: 42259
		// (get) Token: 0x060250CE RID: 151758 RVA: 0x0051D83C File Offset: 0x0051BA3C
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

		// Token: 0x1700A514 RID: 42260
		// (get) Token: 0x060250CF RID: 151759 RVA: 0x0051D878 File Offset: 0x0051BA78
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

		// Token: 0x060250D0 RID: 151760 RVA: 0x0051D8B0 File Offset: 0x0051BAB0
		public Span<byte> GetCheckPointResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060250D1 RID: 151761 RVA: 0x0051D8C0 File Offset: 0x0051BAC0
		public byte[] GetCheckPointResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A515 RID: 42261
		// (get) Token: 0x060250D2 RID: 151762 RVA: 0x0051D8D0 File Offset: 0x0051BAD0
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

		// Token: 0x060250D3 RID: 151763 RVA: 0x0051D908 File Offset: 0x0051BB08
		public Span<byte> GetCheckPointsDestroyResBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060250D4 RID: 151764 RVA: 0x0051D918 File Offset: 0x0051BB18
		public byte[] GetCheckPointsDestroyResArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A516 RID: 42262
		// (get) Token: 0x060250D5 RID: 151765 RVA: 0x0051D928 File Offset: 0x0051BB28
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

		// Token: 0x060250D6 RID: 151766 RVA: 0x0051D960 File Offset: 0x0051BB60
		public Span<byte> GetStartResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060250D7 RID: 151767 RVA: 0x0051D970 File Offset: 0x0051BB70
		public byte[] GetStartResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700A517 RID: 42263
		// (get) Token: 0x060250D8 RID: 151768 RVA: 0x0051D980 File Offset: 0x0051BB80
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

		// Token: 0x060250D9 RID: 151769 RVA: 0x0051D9B8 File Offset: 0x0051BBB8
		public Span<byte> GetEndResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060250DA RID: 151770 RVA: 0x0051D9C8 File Offset: 0x0051BBC8
		public byte[] GetEndResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x060250DB RID: 151771 RVA: 0x0051D9D8 File Offset: 0x0051BBD8
		public IParkourSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IParkourSplinePoint?(default(IParkourSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A518 RID: 42264
		// (get) Token: 0x060250DC RID: 151772 RVA: 0x0051DA3C File Offset: 0x0051BC3C
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

		// Token: 0x060250DD RID: 151773 RVA: 0x0051DA68 File Offset: 0x0051BC68
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

		// Token: 0x060250DE RID: 151774 RVA: 0x0051DABF File Offset: 0x0051BCBF
		public static void StartIParkourSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060250DF RID: 151775 RVA: 0x0051DAC8 File Offset: 0x0051BCC8
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060250E0 RID: 151776 RVA: 0x0051DAD3 File Offset: 0x0051BCD3
		public static void AddIsRequireToEnd(FlatBufferBuilder builder, bool isRequireToEnd)
		{
			builder.AddBool(1, isRequireToEnd, false);
		}

		// Token: 0x060250E1 RID: 151777 RVA: 0x0051DADE File Offset: 0x0051BCDE
		public static void AddCheckPointsRequire(FlatBufferBuilder builder, int checkPointsRequire)
		{
			builder.AddInt(2, checkPointsRequire, 0);
		}

		// Token: 0x060250E2 RID: 151778 RVA: 0x0051DAE9 File Offset: 0x0051BCE9
		public static void AddCheckPointResource(FlatBufferBuilder builder, StringOffset checkPointResourceOffset)
		{
			builder.AddOffset(3, checkPointResourceOffset.Value, 0);
		}

		// Token: 0x060250E3 RID: 151779 RVA: 0x0051DAF9 File Offset: 0x0051BCF9
		public static void AddCheckPointsDestroyRes(FlatBufferBuilder builder, StringOffset checkPointsDestroyResOffset)
		{
			builder.AddOffset(4, checkPointsDestroyResOffset.Value, 0);
		}

		// Token: 0x060250E4 RID: 151780 RVA: 0x0051DB09 File Offset: 0x0051BD09
		public static void AddStartResource(FlatBufferBuilder builder, StringOffset startResourceOffset)
		{
			builder.AddOffset(5, startResourceOffset.Value, 0);
		}

		// Token: 0x060250E5 RID: 151781 RVA: 0x0051DB19 File Offset: 0x0051BD19
		public static void AddEndResource(FlatBufferBuilder builder, StringOffset endResourceOffset)
		{
			builder.AddOffset(6, endResourceOffset.Value, 0);
		}

		// Token: 0x060250E6 RID: 151782 RVA: 0x0051DB29 File Offset: 0x0051BD29
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(7, pointsOffset.Value, 0);
		}

		// Token: 0x060250E7 RID: 151783 RVA: 0x0051DB3C File Offset: 0x0051BD3C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IParkourSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060250E8 RID: 151784 RVA: 0x0051DB7C File Offset: 0x0051BD7C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IParkourSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IParkourSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250E9 RID: 151785 RVA: 0x0051DB96 File Offset: 0x0051BD96
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IParkourSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IParkourSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060250EA RID: 151786 RVA: 0x0051DBB4 File Offset: 0x0051BDB4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IParkourSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060250EB RID: 151787 RVA: 0x0051DBCD File Offset: 0x0051BDCD
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060250EC RID: 151788 RVA: 0x0051DBD8 File Offset: 0x0051BDD8
		public static Offset<IParkourSpline> EndIParkourSpline(FlatBufferBuilder builder)
		{
			return new Offset<IParkourSpline>(builder.EndTable());
		}

		// Token: 0x060250ED RID: 151789 RVA: 0x0051DBE8 File Offset: 0x0051BDE8
		public IParkourSplineT UnPack()
		{
			IParkourSplineT parkourSplineT = new IParkourSplineT();
			this.UnPackTo(parkourSplineT);
			return parkourSplineT;
		}

		// Token: 0x060250EE RID: 151790 RVA: 0x0051DC04 File Offset: 0x0051BE04
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

		// Token: 0x060250EF RID: 151791 RVA: 0x0051DCB8 File Offset: 0x0051BEB8
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

		// Token: 0x0400EADA RID: 60122
		private Table __p;
	}
}
