using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005475 RID: 21621
	public struct IButterflySpline : IFlatbufferObject
	{
		// Token: 0x170099BF RID: 39359
		// (get) Token: 0x06021F75 RID: 139125 RVA: 0x004AE809 File Offset: 0x004ACA09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F76 RID: 139126 RVA: 0x004AE816 File Offset: 0x004ACA16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F77 RID: 139127 RVA: 0x004AE820 File Offset: 0x004ACA20
		public static IButterflySpline GetRootAsIButterflySpline(ByteBuffer _bb)
		{
			return IButterflySpline.GetRootAsIButterflySpline(_bb, default(IButterflySpline));
		}

		// Token: 0x06021F78 RID: 139128 RVA: 0x004AE83C File Offset: 0x004ACA3C
		public static IButterflySpline GetRootAsIButterflySpline(ByteBuffer _bb, IButterflySpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F79 RID: 139129 RVA: 0x004AE859 File Offset: 0x004ACA59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F7A RID: 139130 RVA: 0x004AE868 File Offset: 0x004ACA68
		public IButterflySpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099C0 RID: 39360
		// (get) Token: 0x06021F7B RID: 139131 RVA: 0x004AE878 File Offset: 0x004ACA78
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

		// Token: 0x06021F7C RID: 139132 RVA: 0x004AE8B4 File Offset: 0x004ACAB4
		public IButterflySplinePoint? Points(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IButterflySplinePoint?(default(IButterflySplinePoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099C1 RID: 39361
		// (get) Token: 0x06021F7D RID: 139133 RVA: 0x004AE914 File Offset: 0x004ACB14
		public int PointsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021F7E RID: 139134 RVA: 0x004AE93F File Offset: 0x004ACB3F
		public static Offset<IButterflySpline> CreateIButterflySpline(FlatBufferBuilder builder, ESplineType Type = ESplineType.Common, VectorOffset PointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IButterflySpline.AddPoints(builder, PointsOffset);
			IButterflySpline.AddType(builder, Type);
			return IButterflySpline.EndIButterflySpline(builder);
		}

		// Token: 0x06021F7F RID: 139135 RVA: 0x004AE95C File Offset: 0x004ACB5C
		public static void StartIButterflySpline(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021F80 RID: 139136 RVA: 0x004AE965 File Offset: 0x004ACB65
		public static void AddType(FlatBufferBuilder builder, ESplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021F81 RID: 139137 RVA: 0x004AE970 File Offset: 0x004ACB70
		public static void AddPoints(FlatBufferBuilder builder, VectorOffset pointsOffset)
		{
			builder.AddOffset(1, pointsOffset.Value, 0);
		}

		// Token: 0x06021F82 RID: 139138 RVA: 0x004AE980 File Offset: 0x004ACB80
		public static VectorOffset CreatePointsVector(FlatBufferBuilder builder, Offset<IButterflySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F83 RID: 139139 RVA: 0x004AE9C0 File Offset: 0x004ACBC0
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, Offset<IButterflySplinePoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IButterflySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F84 RID: 139140 RVA: 0x004AE9DA File Offset: 0x004ACBDA
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IButterflySplinePoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IButterflySplinePoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F85 RID: 139141 RVA: 0x004AE9F8 File Offset: 0x004ACBF8
		public static VectorOffset CreatePointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IButterflySplinePoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F86 RID: 139142 RVA: 0x004AEA11 File Offset: 0x004ACC11
		public static void StartPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021F87 RID: 139143 RVA: 0x004AEA1C File Offset: 0x004ACC1C
		public static Offset<IButterflySpline> EndIButterflySpline(FlatBufferBuilder builder)
		{
			return new Offset<IButterflySpline>(builder.EndTable());
		}

		// Token: 0x06021F88 RID: 139144 RVA: 0x004AEA2C File Offset: 0x004ACC2C
		public IButterflySplineT UnPack()
		{
			IButterflySplineT butterflySplineT = new IButterflySplineT();
			this.UnPackTo(butterflySplineT);
			return butterflySplineT;
		}

		// Token: 0x06021F89 RID: 139145 RVA: 0x004AEA48 File Offset: 0x004ACC48
		public void UnPackTo(IButterflySplineT _o)
		{
			_o.Type = this.Type;
			_o.Points = new List<IButterflySplinePointT>();
			for (int i = 0; i < this.PointsLength; i++)
			{
				_o.Points.Add((this.Points(i) != null) ? this.Points(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021F8A RID: 139146 RVA: 0x004AEAB4 File Offset: 0x004ACCB4
		public static Offset<IButterflySpline> Pack(FlatBufferBuilder builder, IButterflySplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IButterflySpline>);
			}
			VectorOffset pointsOffset = default(VectorOffset);
			if (_o.Points != null)
			{
				Offset<IButterflySplinePoint>[] array = new Offset<IButterflySplinePoint>[_o.Points.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IButterflySplinePoint.Pack(builder, _o.Points[i]);
				}
				pointsOffset = IButterflySpline.CreatePointsVector(builder, array);
			}
			return IButterflySpline.CreateIButterflySpline(builder, _o.Type, pointsOffset);
		}

		// Token: 0x0400E960 RID: 59744
		private Table __p;
	}
}
