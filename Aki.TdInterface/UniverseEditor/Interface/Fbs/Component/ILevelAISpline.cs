using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5C RID: 23132
	public struct ILevelAISpline : IFlatbufferObject
	{
		// Token: 0x1700A83E RID: 43070
		// (get) Token: 0x06025D5E RID: 154974 RVA: 0x0052F8F4 File Offset: 0x0052DAF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D5F RID: 154975 RVA: 0x0052F901 File Offset: 0x0052DB01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D60 RID: 154976 RVA: 0x0052F908 File Offset: 0x0052DB08
		public static ILevelAISpline GetRootAsILevelAISpline(ByteBuffer _bb)
		{
			return ILevelAISpline.GetRootAsILevelAISpline(_bb, default(ILevelAISpline));
		}

		// Token: 0x06025D61 RID: 154977 RVA: 0x0052F924 File Offset: 0x0052DB24
		public static ILevelAISpline GetRootAsILevelAISpline(ByteBuffer _bb, ILevelAISpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D62 RID: 154978 RVA: 0x0052F941 File Offset: 0x0052DB41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D63 RID: 154979 RVA: 0x0052F950 File Offset: 0x0052DB50
		public ILevelAISpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A83F RID: 43071
		// (get) Token: 0x06025D64 RID: 154980 RVA: 0x0052F960 File Offset: 0x0052DB60
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

		// Token: 0x1700A840 RID: 43072
		// (get) Token: 0x06025D65 RID: 154981 RVA: 0x0052F99C File Offset: 0x0052DB9C
		public int EntityId
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

		// Token: 0x1700A841 RID: 43073
		// (get) Token: 0x06025D66 RID: 154982 RVA: 0x0052F9D8 File Offset: 0x0052DBD8
		public ILevelAiCycleLooply? CycleOption
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ILevelAiCycleLooply?(default(ILevelAiCycleLooply).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A842 RID: 43074
		// (get) Token: 0x06025D67 RID: 154983 RVA: 0x0052FA38 File Offset: 0x0052DC38
		public bool UsePathFinding
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A843 RID: 43075
		// (get) Token: 0x06025D68 RID: 154984 RVA: 0x0052FA78 File Offset: 0x0052DC78
		public bool IsPassEveryKeyPoint
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025D69 RID: 154985 RVA: 0x0052FAB8 File Offset: 0x0052DCB8
		public ILevelAISplinePoint? Points(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ILevelAISplinePoint?(default(ILevelAISplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A844 RID: 43076
		// (get) Token: 0x06025D6A RID: 154986 RVA: 0x0052FB1C File Offset: 0x0052DD1C
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

		// Token: 0x1700A845 RID: 43077
		// (get) Token: 0x06025D6B RID: 154987 RVA: 0x0052FB48 File Offset: 0x0052DD48
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025D6C RID: 154988 RVA: 0x0052FB88 File Offset: 0x0052DD88
		public static Offset<ILevelAISpline> CreateILevelAISpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, int EntityId = 0, Offset<ILevelAiCycleLooply> CycleOptionOffset = default(Offset<ILevelAiCycleLooply>), bool UsePathFinding = false, bool IsPassEveryKeyPoint = false, VectorOffset PointsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ILevelAISpline.AddPoints(builder, PointsOffset);
			ILevelAISpline.AddCycleOption(builder, CycleOptionOffset);
			ILevelAISpline.AddEntityId(builder, EntityId);
			ILevelAISpline.AddNullMask(builder, NullMask);
			ILevelAISpline.AddIsPassEveryKeyPoint(builder, IsPassEveryKeyPoint);
			ILevelAISpline.AddUsePathFinding(builder, UsePathFinding);
			ILevelAISpline.AddType(builder, Type);
			return ILevelAISpline.EndILevelAISpline(builder);
		}

		// Token: 0x06025D6D RID: 154989 RVA: 0x0052FBD7 File Offset: 0x0052DDD7
		public static void StartILevelAISpline(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06025D6E RID: 154990 RVA: 0x0052FBE0 File Offset: 0x0052DDE0
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D6F RID: 154991 RVA: 0x0052FBEB File Offset: 0x0052DDEB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06025D70 RID: 154992 RVA: 0x0052FBF6 File Offset: 0x0052DDF6
		public static void AddCycleOption(FlatBufferBuilder builder, Offset<ILevelAiCycleLooply> cycleOptionOffset)
		{
			builder.AddOffset(2, cycleOptionOffset.Value, 0);
		}

		// Token: 0x06025D71 RID: 154993 RVA: 0x0052FC06 File Offset: 0x0052DE06
		public static void AddUsePathFinding(FlatBufferBuilder builder, bool usePathFinding)
		{
			builder.AddBool(3, usePathFinding, false);
		}

		// Token: 0x06025D72 RID: 154994 RVA: 0x0052FC11 File Offset: 0x0052DE11
		public static void AddIsPassEveryKeyPoint(FlatBufferBuilder builder, bool isPassEveryKeyPoint)
		{
			builder.AddBool(4, isPassEveryKeyPoint, false);
		}

		// Token: 0x06025D73 RID: 154995 RVA: 0x0052FC1C File Offset: 0x0052DE1C
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(5, pointsOffset.Value, 0);
		}

		// Token: 0x06025D74 RID: 154996 RVA: 0x0052FC2C File Offset: 0x0052DE2C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ILevelAISplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025D75 RID: 154997 RVA: 0x0052FC6C File Offset: 0x0052DE6C
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ILevelAISplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelAISplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D76 RID: 154998 RVA: 0x0052FC86 File Offset: 0x0052DE86
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelAISplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelAISplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D77 RID: 154999 RVA: 0x0052FCA4 File Offset: 0x0052DEA4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelAISplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025D78 RID: 155000 RVA: 0x0052FCBD File Offset: 0x0052DEBD
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025D79 RID: 155001 RVA: 0x0052FCC8 File Offset: 0x0052DEC8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06025D7A RID: 155002 RVA: 0x0052FCD3 File Offset: 0x0052DED3
		public static Offset<ILevelAISpline> EndILevelAISpline(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAISpline>(builder.EndTable());
		}

		// Token: 0x06025D7B RID: 155003 RVA: 0x0052FCE0 File Offset: 0x0052DEE0
		public ILevelAISplineT UnPack()
		{
			ILevelAISplineT levelAISplineT = new ILevelAISplineT();
			this.UnPackTo(levelAISplineT);
			return levelAISplineT;
		}

		// Token: 0x06025D7C RID: 155004 RVA: 0x0052FCFC File Offset: 0x0052DEFC
		public void UnPackTo(ILevelAISplineT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.CycleOption = ((this.CycleOption != null) ? this.CycleOption.Value.UnPack() : null);
			_o.UsePathFinding = this.UsePathFinding;
			_o.IsPassEveryKeyPoint = this.IsPassEveryKeyPoint;
			_o.Points = new List<ILevelAISplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025D7D RID: 155005 RVA: 0x0052FDC8 File Offset: 0x0052DFC8
		public static Offset<ILevelAISpline> Pack(FlatBufferBuilder builder, ILevelAISplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelAISpline>);
			}
			Offset<ILevelAiCycleLooply> cycleOptionOffset = (_o.CycleOption == null) ? default(Offset<ILevelAiCycleLooply>) : ILevelAiCycleLooply.Pack(builder, _o.CycleOption);
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ILevelAISplinePoint>[] array = new Offset<ILevelAISplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelAISplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = ILevelAISpline.CreatePointsVector(builder, array);
			}
			return ILevelAISpline.CreateILevelAISpline(builder, _o.Type, _o.EntityId, cycleOptionOffset, _o.UsePathFinding, _o.IsPassEveryKeyPoint, pointsOffset, _o.NullMask);
		}

		// Token: 0x0400F3C7 RID: 62407
		private Table __p;
	}
}
