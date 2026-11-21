using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E0F RID: 24079
	public struct IRangeSpline : IFlatbufferObject
	{
		// Token: 0x1700B17C RID: 45436
		// (get) Token: 0x06028347 RID: 164679 RVA: 0x0057F99A File Offset: 0x0057DB9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028348 RID: 164680 RVA: 0x0057F9A7 File Offset: 0x0057DBA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028349 RID: 164681 RVA: 0x0057F9B0 File Offset: 0x0057DBB0
		public static IRangeSpline GetRootAsIRangeSpline(ByteBuffer _bb)
		{
			return IRangeSpline.GetRootAsIRangeSpline(_bb, default(IRangeSpline));
		}

		// Token: 0x0602834A RID: 164682 RVA: 0x0057F9CC File Offset: 0x0057DBCC
		public static IRangeSpline GetRootAsIRangeSpline(ByteBuffer _bb, IRangeSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602834B RID: 164683 RVA: 0x0057F9E9 File Offset: 0x0057DBE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602834C RID: 164684 RVA: 0x0057F9F8 File Offset: 0x0057DBF8
		public IRangeSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B17D RID: 45437
		// (get) Token: 0x0602834D RID: 164685 RVA: 0x0057FA08 File Offset: 0x0057DC08
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

		// Token: 0x1700B17E RID: 45438
		// (get) Token: 0x0602834E RID: 164686 RVA: 0x0057FA44 File Offset: 0x0057DC44
		public float Height
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602834F RID: 164687 RVA: 0x0057FA84 File Offset: 0x0057DC84
		public ICommonSplinePoint? Points(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ICommonSplinePoint?(default(ICommonSplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B17F RID: 45439
		// (get) Token: 0x06028350 RID: 164688 RVA: 0x0057FAE4 File Offset: 0x0057DCE4
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06028351 RID: 164689 RVA: 0x0057FB0F File Offset: 0x0057DD0F
		public static Offset<IRangeSpline> CreateIRangeSpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, float Height = 0f, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRangeSpline.AddPoints(builder, PointsOffset);
			IRangeSpline.AddHeight(builder, Height);
			IRangeSpline.AddType(builder, Type);
			return IRangeSpline.EndIRangeSpline(builder);
		}

		// Token: 0x06028352 RID: 164690 RVA: 0x0057FB33 File Offset: 0x0057DD33
		public static void StartIRangeSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028353 RID: 164691 RVA: 0x0057FB3C File Offset: 0x0057DD3C
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028354 RID: 164692 RVA: 0x0057FB47 File Offset: 0x0057DD47
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(1, height, 0.0);
		}

		// Token: 0x06028355 RID: 164693 RVA: 0x0057FB5A File Offset: 0x0057DD5A
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(2, pointsOffset.Value, 0);
		}

		// Token: 0x06028356 RID: 164694 RVA: 0x0057FB6C File Offset: 0x0057DD6C
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028357 RID: 164695 RVA: 0x0057FBAC File Offset: 0x0057DDAC
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<ICommonSplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028358 RID: 164696 RVA: 0x0057FBC6 File Offset: 0x0057DDC6
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonSplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonSplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028359 RID: 164697 RVA: 0x0057FBE4 File Offset: 0x0057DDE4
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonSplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602835A RID: 164698 RVA: 0x0057FBFD File Offset: 0x0057DDFD
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602835B RID: 164699 RVA: 0x0057FC08 File Offset: 0x0057DE08
		public static Offset<IRangeSpline> EndIRangeSpline(FlatBufferBuilder builder)
		{
			return new Offset<IRangeSpline>(builder.EndTable());
		}

		// Token: 0x0602835C RID: 164700 RVA: 0x0057FC18 File Offset: 0x0057DE18
		public IRangeSplineT UnPack()
		{
			IRangeSplineT rangeSplineT = new IRangeSplineT();
			this.UnPackTo(rangeSplineT);
			return rangeSplineT;
		}

		// Token: 0x0602835D RID: 164701 RVA: 0x0057FC34 File Offset: 0x0057DE34
		public void UnPackTo(IRangeSplineT _o)
		{
			_o.Type = this.Type;
			_o.Height = this.Height;
			_o.Points = new List<ICommonSplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602835E RID: 164702 RVA: 0x0057FCAC File Offset: 0x0057DEAC
		public static Offset<IRangeSpline> Pack(FlatBufferBuilder builder, IRangeSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeSpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<ICommonSplinePoint>[] array = new Offset<ICommonSplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonSplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IRangeSpline.CreatePointsVector(builder, array);
			}
			return IRangeSpline.CreateIRangeSpline(builder, _o.Type, _o.Height, pointsOffset);
		}

		// Token: 0x0400F9F0 RID: 63984
		private Table __p;
	}
}
