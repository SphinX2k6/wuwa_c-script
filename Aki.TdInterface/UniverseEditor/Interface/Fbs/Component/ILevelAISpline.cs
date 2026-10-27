using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D6 RID: 21718
	public struct ILevelAISpline : IFlatbufferObject
	{
		// Token: 0x1700A004 RID: 40964
		// (get) Token: 0x06023CA6 RID: 146598 RVA: 0x004F2880 File Offset: 0x004F0A80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023CA7 RID: 146599 RVA: 0x004F288D File Offset: 0x004F0A8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023CA8 RID: 146600 RVA: 0x004F2894 File Offset: 0x004F0A94
		public static ILevelAISpline GetRootAsILevelAISpline(ByteBuffer _bb)
		{
			return ILevelAISpline.GetRootAsILevelAISpline(_bb, default(ILevelAISpline));
		}

		// Token: 0x06023CA9 RID: 146601 RVA: 0x004F28B0 File Offset: 0x004F0AB0
		public static ILevelAISpline GetRootAsILevelAISpline(ByteBuffer _bb, ILevelAISpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023CAA RID: 146602 RVA: 0x004F28CD File Offset: 0x004F0ACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023CAB RID: 146603 RVA: 0x004F28DC File Offset: 0x004F0ADC
		public ILevelAISpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A005 RID: 40965
		// (get) Token: 0x06023CAC RID: 146604 RVA: 0x004F28EC File Offset: 0x004F0AEC
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

		// Token: 0x1700A006 RID: 40966
		// (get) Token: 0x06023CAD RID: 146605 RVA: 0x004F2928 File Offset: 0x004F0B28
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

		// Token: 0x1700A007 RID: 40967
		// (get) Token: 0x06023CAE RID: 146606 RVA: 0x004F2964 File Offset: 0x004F0B64
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

		// Token: 0x1700A008 RID: 40968
		// (get) Token: 0x06023CAF RID: 146607 RVA: 0x004F29C4 File Offset: 0x004F0BC4
		public bool UsePathFinding
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A009 RID: 40969
		// (get) Token: 0x06023CB0 RID: 146608 RVA: 0x004F2A04 File Offset: 0x004F0C04
		public bool IsPassEveryKeyPoint
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023CB1 RID: 146609 RVA: 0x004F2A44 File Offset: 0x004F0C44
		public ILevelAISplinePoint? Points(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ILevelAISplinePoint?(default(ILevelAISplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A00A RID: 40970
		// (get) Token: 0x06023CB2 RID: 146610 RVA: 0x004F2AA8 File Offset: 0x004F0CA8
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

		// Token: 0x1700A00B RID: 40971
		// (get) Token: 0x06023CB3 RID: 146611 RVA: 0x004F2AD4 File Offset: 0x004F0CD4
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

		// Token: 0x06023CB4 RID: 146612 RVA: 0x004F2B14 File Offset: 0x004F0D14
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

		// Token: 0x06023CB5 RID: 146613 RVA: 0x004F2B63 File Offset: 0x004F0D63
		public static void StartILevelAISpline(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023CB6 RID: 146614 RVA: 0x004F2B6C File Offset: 0x004F0D6C
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023CB7 RID: 146615 RVA: 0x004F2B77 File Offset: 0x004F0D77
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06023CB8 RID: 146616 RVA: 0x004F2B82 File Offset: 0x004F0D82
		public static void AddCycleOption(FlatBufferBuilder builder, Offset<ILevelAiCycleLooply> cycleOptionOffset)
		{
			builder.AddOffset(2, cycleOptionOffset.Value, 0);
		}

		// Token: 0x06023CB9 RID: 146617 RVA: 0x004F2B92 File Offset: 0x004F0D92
		public static void AddUsePathFinding(FlatBufferBuilder builder, bool usePathFinding)
		{
			builder.AddBool(3, usePathFinding, false);
		}

		// Token: 0x06023CBA RID: 146618 RVA: 0x004F2B9D File Offset: 0x004F0D9D
		public static void AddIsPassEveryKeyPoint(FlatBufferBuilder builder, bool isPassEveryKeyPoint)
		{
			builder.AddBool(4, isPassEveryKeyPoint, false);
		}

		// Token: 0x06023CBB RID: 146619 RVA: 0x004F2BA8 File Offset: 0x004F0DA8
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(5, pointsOffset.Value, 0);
		}

		// Token: 0x06023CBC RID: 146620 RVA: 0x004F2BB8 File Offset: 0x004F0DB8
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ILevelAISplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023CBD RID: 146621 RVA: 0x004F2BF8 File Offset: 0x004F0DF8
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ILevelAISplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelAISplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CBE RID: 146622 RVA: 0x004F2C12 File Offset: 0x004F0E12
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelAISplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelAISplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CBF RID: 146623 RVA: 0x004F2C30 File Offset: 0x004F0E30
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelAISplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023CC0 RID: 146624 RVA: 0x004F2C49 File Offset: 0x004F0E49
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023CC1 RID: 146625 RVA: 0x004F2C54 File Offset: 0x004F0E54
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023CC2 RID: 146626 RVA: 0x004F2C5F File Offset: 0x004F0E5F
		public static Offset<ILevelAISpline> EndILevelAISpline(FlatBufferBuilder builder)
		{
			return new Offset<ILevelAISpline>(builder.EndTable());
		}

		// Token: 0x06023CC3 RID: 146627 RVA: 0x004F2C6C File Offset: 0x004F0E6C
		public ILevelAISplineT UnPack()
		{
			ILevelAISplineT levelAISplineT = new ILevelAISplineT();
			this.UnPackTo(levelAISplineT);
			return levelAISplineT;
		}

		// Token: 0x06023CC4 RID: 146628 RVA: 0x004F2C88 File Offset: 0x004F0E88
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

		// Token: 0x06023CC5 RID: 146629 RVA: 0x004F2D54 File Offset: 0x004F0F54
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

		// Token: 0x0400E796 RID: 59286
		private Table __p;
	}
}
