using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616C RID: 24940
	public struct IWaySpline : IFlatbufferObject
	{
		// Token: 0x1700B9DE RID: 47582
		// (get) Token: 0x0602A5A3 RID: 173475 RVA: 0x005C7475 File Offset: 0x005C5675
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5A4 RID: 173476 RVA: 0x005C7482 File Offset: 0x005C5682
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5A5 RID: 173477 RVA: 0x005C748C File Offset: 0x005C568C
		public static IWaySpline GetRootAsIWaySpline(ByteBuffer _bb)
		{
			return IWaySpline.GetRootAsIWaySpline(_bb, default(IWaySpline));
		}

		// Token: 0x0602A5A6 RID: 173478 RVA: 0x005C74A8 File Offset: 0x005C56A8
		public static IWaySpline GetRootAsIWaySpline(ByteBuffer _bb, IWaySpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5A7 RID: 173479 RVA: 0x005C74C5 File Offset: 0x005C56C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5A8 RID: 173480 RVA: 0x005C74D4 File Offset: 0x005C56D4
		public IWaySpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9DF RID: 47583
		// (get) Token: 0x0602A5A9 RID: 173481 RVA: 0x005C74E4 File Offset: 0x005C56E4
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

		// Token: 0x1700B9E0 RID: 47584
		// (get) Token: 0x0602A5AA RID: 173482 RVA: 0x005C7520 File Offset: 0x005C5720
		public int RoadZoneId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9E1 RID: 47585
		// (get) Token: 0x0602A5AB RID: 173483 RVA: 0x005C755C File Offset: 0x005C575C
		public string PcgRoadPathName
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

		// Token: 0x0602A5AC RID: 173484 RVA: 0x005C7593 File Offset: 0x005C5793
		public Span<byte> GetPcgRoadPathNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602A5AD RID: 173485 RVA: 0x005C75A2 File Offset: 0x005C57A2
		public byte[] GetPcgRoadPathNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B9E2 RID: 47586
		// (get) Token: 0x0602A5AE RID: 173486 RVA: 0x005C75B0 File Offset: 0x005C57B0
		public bool NoEntry
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9E3 RID: 47587
		// (get) Token: 0x0602A5AF RID: 173487 RVA: 0x005C75F0 File Offset: 0x005C57F0
		public IPavedWayConfig? PavedWayConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPavedWayConfig?(default(IPavedWayConfig).__assign(num + this.__p.bb_pos, this.__p.bb));
			}
		}

		// Token: 0x0602A5B0 RID: 173488 RVA: 0x005C7644 File Offset: 0x005C5844
		public IWaySplinePoint? Points(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IWaySplinePoint?(default(IWaySplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B9E4 RID: 47588
		// (get) Token: 0x0602A5B1 RID: 173489 RVA: 0x005C76A8 File Offset: 0x005C58A8
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A5B2 RID: 173490 RVA: 0x005C76D4 File Offset: 0x005C58D4
		public int Last(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B9E5 RID: 47589
		// (get) Token: 0x0602A5B3 RID: 173491 RVA: 0x005C7714 File Offset: 0x005C5914
		public int LastLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602A5B4 RID: 173492 RVA: 0x005C7740 File Offset: 0x005C5940
		public Span<int> GetLastBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0602A5B5 RID: 173493 RVA: 0x005C7750 File Offset: 0x005C5950
		public int[] GetLastArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x0602A5B6 RID: 173494 RVA: 0x005C7760 File Offset: 0x005C5960
		public int Next(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B9E6 RID: 47590
		// (get) Token: 0x0602A5B7 RID: 173495 RVA: 0x005C77A0 File Offset: 0x005C59A0
		public int NextLength
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

		// Token: 0x0602A5B8 RID: 173496 RVA: 0x005C77CC File Offset: 0x005C59CC
		public Span<int> GetNextBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0602A5B9 RID: 173497 RVA: 0x005C77DC File Offset: 0x005C59DC
		public int[] GetNextArray()
		{
			return this.__p.__vector_as_array<int>(18);
		}

		// Token: 0x1700B9E7 RID: 47591
		// (get) Token: 0x0602A5BA RID: 173498 RVA: 0x005C77EC File Offset: 0x005C59EC
		public int Opposite
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

		// Token: 0x1700B9E8 RID: 47592
		// (get) Token: 0x0602A5BB RID: 173499 RVA: 0x005C782C File Offset: 0x005C5A2C
		public float Width
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B9E9 RID: 47593
		// (get) Token: 0x0602A5BC RID: 173500 RVA: 0x005C7870 File Offset: 0x005C5A70
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A5BD RID: 173501 RVA: 0x005C78B0 File Offset: 0x005C5AB0
		public static Offset<IWaySpline> CreateIWaySpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, int RoadZoneId = 0, StringOffset PcgRoadPathNameOffset = default(StringOffset), bool NoEntry = false, IPavedWayConfigT PavedWayConfig = null, VectorOffset PointsOffset = default(VectorOffset), VectorOffset LastOffset = default(VectorOffset), VectorOffset NextOffset = default(VectorOffset), int Opposite = 0, float Width = 0f, byte NullMask = 0)
		{
			builder.StartTable(11);
			IWaySpline.AddWidth(builder, Width);
			IWaySpline.AddOpposite(builder, Opposite);
			IWaySpline.AddNext(builder, NextOffset);
			IWaySpline.AddLast(builder, LastOffset);
			IWaySpline.AddPoints(builder, PointsOffset);
			IWaySpline.AddPavedWayConfig(builder, IPavedWayConfig.Pack(builder, PavedWayConfig));
			IWaySpline.AddPcgRoadPathName(builder, PcgRoadPathNameOffset);
			IWaySpline.AddRoadZoneId(builder, RoadZoneId);
			IWaySpline.AddNullMask(builder, NullMask);
			IWaySpline.AddNoEntry(builder, NoEntry);
			IWaySpline.AddType(builder, Type);
			return IWaySpline.EndIWaySpline(builder);
		}

		// Token: 0x0602A5BE RID: 173502 RVA: 0x005C7926 File Offset: 0x005C5B26
		public static void StartIWaySpline(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602A5BF RID: 173503 RVA: 0x005C7930 File Offset: 0x005C5B30
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A5C0 RID: 173504 RVA: 0x005C793B File Offset: 0x005C5B3B
		public static void AddRoadZoneId(FlatBufferBuilder builder, int roadZoneId)
		{
			builder.AddInt(1, roadZoneId, 0);
		}

		// Token: 0x0602A5C1 RID: 173505 RVA: 0x005C7946 File Offset: 0x005C5B46
		public static void AddPcgRoadPathName(FlatBufferBuilder builder, StringOffset pcgRoadPathNameOffset)
		{
			builder.AddOffset(2, pcgRoadPathNameOffset.Value, 0);
		}

		// Token: 0x0602A5C2 RID: 173506 RVA: 0x005C7956 File Offset: 0x005C5B56
		public static void AddNoEntry(FlatBufferBuilder builder, bool noEntry)
		{
			builder.AddBool(3, noEntry, false);
		}

		// Token: 0x0602A5C3 RID: 173507 RVA: 0x005C7961 File Offset: 0x005C5B61
		public static void AddPavedWayConfig(FlatBufferBuilder builder, Offset<IPavedWayConfig> pavedWayConfigOffset)
		{
			builder.AddStruct(4, pavedWayConfigOffset.Value, 0);
		}

		// Token: 0x0602A5C4 RID: 173508 RVA: 0x005C7971 File Offset: 0x005C5B71
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(5, pointsOffset.Value, 0);
		}

		// Token: 0x0602A5C5 RID: 173509 RVA: 0x005C7984 File Offset: 0x005C5B84
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IWaySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A5C6 RID: 173510 RVA: 0x005C79C4 File Offset: 0x005C5BC4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IWaySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWaySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5C7 RID: 173511 RVA: 0x005C79DE File Offset: 0x005C5BDE
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWaySplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWaySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5C8 RID: 173512 RVA: 0x005C79FC File Offset: 0x005C5BFC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWaySplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A5C9 RID: 173513 RVA: 0x005C7A15 File Offset: 0x005C5C15
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A5CA RID: 173514 RVA: 0x005C7A20 File Offset: 0x005C5C20
		public static void AddLast(FlatBufferBuilder builder, VectorOffset lastOffset)
		{
			builder.AddOffset(6, lastOffset.Value, 0);
		}

		// Token: 0x0602A5CB RID: 173515 RVA: 0x005C7A30 File Offset: 0x005C5C30
		public static VectorOffset CreateLastVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A5CC RID: 173516 RVA: 0x005C7A67 File Offset: 0x005C5C67
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5CD RID: 173517 RVA: 0x005C7A81 File Offset: 0x005C5C81
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5CE RID: 173518 RVA: 0x005C7A9F File Offset: 0x005C5C9F
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A5CF RID: 173519 RVA: 0x005C7AB8 File Offset: 0x005C5CB8
		public static void StartLastVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A5D0 RID: 173520 RVA: 0x005C7AC3 File Offset: 0x005C5CC3
		public static void AddNext(FlatBufferBuilder builder, VectorOffset nextOffset)
		{
			builder.AddOffset(7, nextOffset.Value, 0);
		}

		// Token: 0x0602A5D1 RID: 173521 RVA: 0x005C7AD4 File Offset: 0x005C5CD4
		public static VectorOffset CreateNextVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A5D2 RID: 173522 RVA: 0x005C7B0B File Offset: 0x005C5D0B
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5D3 RID: 173523 RVA: 0x005C7B25 File Offset: 0x005C5D25
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A5D4 RID: 173524 RVA: 0x005C7B43 File Offset: 0x005C5D43
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A5D5 RID: 173525 RVA: 0x005C7B5C File Offset: 0x005C5D5C
		public static void StartNextVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A5D6 RID: 173526 RVA: 0x005C7B67 File Offset: 0x005C5D67
		public static void AddOpposite(FlatBufferBuilder builder, int opposite)
		{
			builder.AddInt(8, opposite, 0);
		}

		// Token: 0x0602A5D7 RID: 173527 RVA: 0x005C7B72 File Offset: 0x005C5D72
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
			builder.AddFloat(9, width, 0.0);
		}

		// Token: 0x0602A5D8 RID: 173528 RVA: 0x005C7B86 File Offset: 0x005C5D86
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602A5D9 RID: 173529 RVA: 0x005C7B92 File Offset: 0x005C5D92
		public static Offset<IWaySpline> EndIWaySpline(FlatBufferBuilder builder)
		{
			return new Offset<IWaySpline>(builder.EndTable());
		}

		// Token: 0x0602A5DA RID: 173530 RVA: 0x005C7BA0 File Offset: 0x005C5DA0
		public IWaySplineT UnPack()
		{
			IWaySplineT waySplineT = new IWaySplineT();
			this.UnPackTo(waySplineT);
			return waySplineT;
		}

		// Token: 0x0602A5DB RID: 173531 RVA: 0x005C7BBC File Offset: 0x005C5DBC
		public void UnPackTo(IWaySplineT _o)
		{
			_o.Type = this.Type;
			_o.RoadZoneId = this.RoadZoneId;
			_o.PcgRoadPathName = this.PcgRoadPathName;
			_o.NoEntry = this.NoEntry;
			_o.PavedWayConfig = ((this.PavedWayConfig != null) ? this.PavedWayConfig.Value.UnPack() : null);
			_o.Points = new List<IWaySplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
			_o.Last = new List<int>();
			for (int j = 0; j < this.LastLength; j++)
			{
				_o.Last.Add(this.Last(j));
			}
			_o.Next = new List<int>();
			for (int k = 0; k < this.NextLength; k++)
			{
				_o.Next.Add(this.Next(k));
			}
			_o.Opposite = this.Opposite;
			_o.Width = this.Width;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A5DC RID: 173532 RVA: 0x005C7D08 File Offset: 0x005C5F08
		public static Offset<IWaySpline> Pack(FlatBufferBuilder builder, IWaySplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySpline>);
			}
			StringOffset pcgRoadPathNameOffset = (_o.PcgRoadPathName == null) ? default(StringOffset) : builder.CreateString(_o.PcgRoadPathName);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IWaySplinePoint>[] array = new Offset<IWaySplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IWaySplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IWaySpline.CreatePointsVector(builder, array);
			}
			VectorOffset lastOffset = default(VectorOffset);
			if (_o.Last != null)
			{
				int[] data = _o.Last.ToArray();
				lastOffset = IWaySpline.CreateLastVector(builder, data);
			}
			VectorOffset nextOffset = default(VectorOffset);
			if (_o.Next != null)
			{
				int[] data2 = _o.Next.ToArray();
				nextOffset = IWaySpline.CreateNextVector(builder, data2);
			}
			return IWaySpline.CreateIWaySpline(builder, _o.Type, _o.RoadZoneId, pcgRoadPathNameOffset, _o.NoEntry, _o.PavedWayConfig, pointsOffset, lastOffset, nextOffset, _o.Opposite, _o.Width, _o.NullMask);
		}

		// Token: 0x0400FF9B RID: 65435
		private Table __p;
	}
}
