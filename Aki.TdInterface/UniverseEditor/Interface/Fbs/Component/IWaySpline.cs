using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B56 RID: 23382
	public struct IWaySpline : IFlatbufferObject
	{
		// Token: 0x1700B096 RID: 45206
		// (get) Token: 0x06027FDF RID: 163807 RVA: 0x0057F9E5 File Offset: 0x0057DBE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FE0 RID: 163808 RVA: 0x0057F9F2 File Offset: 0x0057DBF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FE1 RID: 163809 RVA: 0x0057F9FC File Offset: 0x0057DBFC
		public static IWaySpline GetRootAsIWaySpline(ByteBuffer _bb)
		{
			return IWaySpline.GetRootAsIWaySpline(_bb, default(IWaySpline));
		}

		// Token: 0x06027FE2 RID: 163810 RVA: 0x0057FA18 File Offset: 0x0057DC18
		public static IWaySpline GetRootAsIWaySpline(ByteBuffer _bb, IWaySpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FE3 RID: 163811 RVA: 0x0057FA35 File Offset: 0x0057DC35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FE4 RID: 163812 RVA: 0x0057FA44 File Offset: 0x0057DC44
		public IWaySpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B097 RID: 45207
		// (get) Token: 0x06027FE5 RID: 163813 RVA: 0x0057FA54 File Offset: 0x0057DC54
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

		// Token: 0x1700B098 RID: 45208
		// (get) Token: 0x06027FE6 RID: 163814 RVA: 0x0057FA90 File Offset: 0x0057DC90
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

		// Token: 0x1700B099 RID: 45209
		// (get) Token: 0x06027FE7 RID: 163815 RVA: 0x0057FACC File Offset: 0x0057DCCC
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

		// Token: 0x06027FE8 RID: 163816 RVA: 0x0057FB03 File Offset: 0x0057DD03
		public Span<byte> GetPcgRoadPathNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027FE9 RID: 163817 RVA: 0x0057FB12 File Offset: 0x0057DD12
		public byte[] GetPcgRoadPathNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B09A RID: 45210
		// (get) Token: 0x06027FEA RID: 163818 RVA: 0x0057FB20 File Offset: 0x0057DD20
		public bool NoEntry
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B09B RID: 45211
		// (get) Token: 0x06027FEB RID: 163819 RVA: 0x0057FB60 File Offset: 0x0057DD60
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

		// Token: 0x06027FEC RID: 163820 RVA: 0x0057FBB4 File Offset: 0x0057DDB4
		public IWaySplinePoint? Points(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IWaySplinePoint?(default(IWaySplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B09C RID: 45212
		// (get) Token: 0x06027FED RID: 163821 RVA: 0x0057FC18 File Offset: 0x0057DE18
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

		// Token: 0x06027FEE RID: 163822 RVA: 0x0057FC44 File Offset: 0x0057DE44
		public int Last(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B09D RID: 45213
		// (get) Token: 0x06027FEF RID: 163823 RVA: 0x0057FC84 File Offset: 0x0057DE84
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

		// Token: 0x06027FF0 RID: 163824 RVA: 0x0057FCB0 File Offset: 0x0057DEB0
		public Span<int> GetLastBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06027FF1 RID: 163825 RVA: 0x0057FCC0 File Offset: 0x0057DEC0
		public int[] GetLastArray()
		{
			return this.__p.__vector_as_array<int>(16);
		}

		// Token: 0x06027FF2 RID: 163826 RVA: 0x0057FCD0 File Offset: 0x0057DED0
		public int Next(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B09E RID: 45214
		// (get) Token: 0x06027FF3 RID: 163827 RVA: 0x0057FD10 File Offset: 0x0057DF10
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

		// Token: 0x06027FF4 RID: 163828 RVA: 0x0057FD3C File Offset: 0x0057DF3C
		public Span<int> GetNextBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06027FF5 RID: 163829 RVA: 0x0057FD4C File Offset: 0x0057DF4C
		public int[] GetNextArray()
		{
			return this.__p.__vector_as_array<int>(18);
		}

		// Token: 0x1700B09F RID: 45215
		// (get) Token: 0x06027FF6 RID: 163830 RVA: 0x0057FD5C File Offset: 0x0057DF5C
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

		// Token: 0x1700B0A0 RID: 45216
		// (get) Token: 0x06027FF7 RID: 163831 RVA: 0x0057FD9C File Offset: 0x0057DF9C
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

		// Token: 0x1700B0A1 RID: 45217
		// (get) Token: 0x06027FF8 RID: 163832 RVA: 0x0057FDE0 File Offset: 0x0057DFE0
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

		// Token: 0x06027FF9 RID: 163833 RVA: 0x0057FE20 File Offset: 0x0057E020
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

		// Token: 0x06027FFA RID: 163834 RVA: 0x0057FE96 File Offset: 0x0057E096
		public static void StartIWaySpline(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06027FFB RID: 163835 RVA: 0x0057FEA0 File Offset: 0x0057E0A0
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027FFC RID: 163836 RVA: 0x0057FEAB File Offset: 0x0057E0AB
		public static void AddRoadZoneId(FlatBufferBuilder builder, int roadZoneId)
		{
			builder.AddInt(1, roadZoneId, 0);
		}

		// Token: 0x06027FFD RID: 163837 RVA: 0x0057FEB6 File Offset: 0x0057E0B6
		public static void AddPcgRoadPathName(FlatBufferBuilder builder, StringOffset pcgRoadPathNameOffset)
		{
			builder.AddOffset(2, pcgRoadPathNameOffset.Value, 0);
		}

		// Token: 0x06027FFE RID: 163838 RVA: 0x0057FEC6 File Offset: 0x0057E0C6
		public static void AddNoEntry(FlatBufferBuilder builder, bool noEntry)
		{
			builder.AddBool(3, noEntry, false);
		}

		// Token: 0x06027FFF RID: 163839 RVA: 0x0057FED1 File Offset: 0x0057E0D1
		public static void AddPavedWayConfig(FlatBufferBuilder builder, Offset<IPavedWayConfig> pavedWayConfigOffset)
		{
			builder.AddStruct(4, pavedWayConfigOffset.Value, 0);
		}

		// Token: 0x06028000 RID: 163840 RVA: 0x0057FEE1 File Offset: 0x0057E0E1
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(5, pointsOffset.Value, 0);
		}

		// Token: 0x06028001 RID: 163841 RVA: 0x0057FEF4 File Offset: 0x0057E0F4
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IWaySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x0057FF34 File Offset: 0x0057E134
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IWaySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IWaySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x0057FF4E File Offset: 0x0057E14E
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IWaySplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IWaySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028004 RID: 163844 RVA: 0x0057FF6C File Offset: 0x0057E16C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IWaySplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028005 RID: 163845 RVA: 0x0057FF85 File Offset: 0x0057E185
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028006 RID: 163846 RVA: 0x0057FF90 File Offset: 0x0057E190
		public static void AddLast(FlatBufferBuilder builder, VectorOffset lastOffset)
		{
			builder.AddOffset(6, lastOffset.Value, 0);
		}

		// Token: 0x06028007 RID: 163847 RVA: 0x0057FFA0 File Offset: 0x0057E1A0
		public static VectorOffset CreateLastVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028008 RID: 163848 RVA: 0x0057FFD7 File Offset: 0x0057E1D7
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028009 RID: 163849 RVA: 0x0057FFF1 File Offset: 0x0057E1F1
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602800A RID: 163850 RVA: 0x0058000F File Offset: 0x0057E20F
		public static VectorOffset CreateLastVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602800B RID: 163851 RVA: 0x00580028 File Offset: 0x0057E228
		public static void StartLastVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602800C RID: 163852 RVA: 0x00580033 File Offset: 0x0057E233
		public static void AddNext(FlatBufferBuilder builder, VectorOffset nextOffset)
		{
			builder.AddOffset(7, nextOffset.Value, 0);
		}

		// Token: 0x0602800D RID: 163853 RVA: 0x00580044 File Offset: 0x0057E244
		public static VectorOffset CreateNextVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602800E RID: 163854 RVA: 0x0058007B File Offset: 0x0057E27B
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602800F RID: 163855 RVA: 0x00580095 File Offset: 0x0057E295
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028010 RID: 163856 RVA: 0x005800B3 File Offset: 0x0057E2B3
		public static VectorOffset CreateNextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028011 RID: 163857 RVA: 0x005800CC File Offset: 0x0057E2CC
		public static void StartNextVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028012 RID: 163858 RVA: 0x005800D7 File Offset: 0x0057E2D7
		public static void AddOpposite(FlatBufferBuilder builder, int opposite)
		{
			builder.AddInt(8, opposite, 0);
		}

		// Token: 0x06028013 RID: 163859 RVA: 0x005800E2 File Offset: 0x0057E2E2
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
			builder.AddFloat(9, width, 0.0);
		}

		// Token: 0x06028014 RID: 163860 RVA: 0x005800F6 File Offset: 0x0057E2F6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06028015 RID: 163861 RVA: 0x00580102 File Offset: 0x0057E302
		public static Offset<IWaySpline> EndIWaySpline(FlatBufferBuilder builder)
		{
			return new Offset<IWaySpline>(builder.EndTable());
		}

		// Token: 0x06028016 RID: 163862 RVA: 0x00580110 File Offset: 0x0057E310
		public IWaySplineT UnPack()
		{
			IWaySplineT waySplineT = new IWaySplineT();
			this.UnPackTo(waySplineT);
			return waySplineT;
		}

		// Token: 0x06028017 RID: 163863 RVA: 0x0058012C File Offset: 0x0057E32C
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

		// Token: 0x06028018 RID: 163864 RVA: 0x00580278 File Offset: 0x0057E478
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

		// Token: 0x0400F295 RID: 62101
		private Table __p;
	}
}
