using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E3 RID: 22243
	public struct IPasserbyNpcSplineMove : IFlatbufferObject
	{
		// Token: 0x1700A597 RID: 42391
		// (get) Token: 0x060252AA RID: 152234 RVA: 0x005214EF File Offset: 0x0051F6EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252AB RID: 152235 RVA: 0x005214FC File Offset: 0x0051F6FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252AC RID: 152236 RVA: 0x00521504 File Offset: 0x0051F704
		public static IPasserbyNpcSplineMove GetRootAsIPasserbyNpcSplineMove(ByteBuffer _bb)
		{
			return IPasserbyNpcSplineMove.GetRootAsIPasserbyNpcSplineMove(_bb, default(IPasserbyNpcSplineMove));
		}

		// Token: 0x060252AD RID: 152237 RVA: 0x00521520 File Offset: 0x0051F720
		public static IPasserbyNpcSplineMove GetRootAsIPasserbyNpcSplineMove(ByteBuffer _bb, IPasserbyNpcSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252AE RID: 152238 RVA: 0x0052153D File Offset: 0x0051F73D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252AF RID: 152239 RVA: 0x0052154C File Offset: 0x0051F74C
		public IPasserbyNpcSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A598 RID: 42392
		// (get) Token: 0x060252B0 RID: 152240 RVA: 0x0052155C File Offset: 0x0051F75C
		public EPasserbyNpcMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcMoveType.Spline;
				}
				return (EPasserbyNpcMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060252B1 RID: 152241 RVA: 0x00521598 File Offset: 0x0051F798
		public IPasserbyNpcSpline? Routes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPasserbyNpcSpline?(default(IPasserbyNpcSpline).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A599 RID: 42393
		// (get) Token: 0x060252B2 RID: 152242 RVA: 0x005215F8 File Offset: 0x0051F7F8
		public int RoutesLength
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

		// Token: 0x060252B3 RID: 152243 RVA: 0x00521623 File Offset: 0x0051F823
		public static Offset<IPasserbyNpcSplineMove> CreateIPasserbyNpcSplineMove(FlatBufferBuilder builder, EPasserbyNpcMoveType Type = EPasserbyNpcMoveType.Spline, VectorOffset RoutesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPasserbyNpcSplineMove.AddRoutes(builder, RoutesOffset);
			IPasserbyNpcSplineMove.AddType(builder, Type);
			return IPasserbyNpcSplineMove.EndIPasserbyNpcSplineMove(builder);
		}

		// Token: 0x060252B4 RID: 152244 RVA: 0x00521640 File Offset: 0x0051F840
		public static void StartIPasserbyNpcSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060252B5 RID: 152245 RVA: 0x00521649 File Offset: 0x0051F849
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060252B6 RID: 152246 RVA: 0x00521654 File Offset: 0x0051F854
		public static void AddRoutes(FlatBufferBuilder builder, VectorOffset routesOffset)
		{
			builder.AddOffset(1, routesOffset.Value, 0);
		}

		// Token: 0x060252B7 RID: 152247 RVA: 0x00521664 File Offset: 0x0051F864
		public static VectorOffset CreateRoutesVector(FlatBufferBuilder builder, Offset<IPasserbyNpcSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060252B8 RID: 152248 RVA: 0x005216A4 File Offset: 0x0051F8A4
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, Offset<IPasserbyNpcSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPasserbyNpcSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x060252B9 RID: 152249 RVA: 0x005216BE File Offset: 0x0051F8BE
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPasserbyNpcSpline>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPasserbyNpcSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x060252BA RID: 152250 RVA: 0x005216DC File Offset: 0x0051F8DC
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPasserbyNpcSpline>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060252BB RID: 152251 RVA: 0x005216F5 File Offset: 0x0051F8F5
		public static void StartRoutesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060252BC RID: 152252 RVA: 0x00521700 File Offset: 0x0051F900
		public static Offset<IPasserbyNpcSplineMove> EndIPasserbyNpcSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSplineMove>(builder.EndTable());
		}

		// Token: 0x060252BD RID: 152253 RVA: 0x00521710 File Offset: 0x0051F910
		public IPasserbyNpcSplineMoveT UnPack()
		{
			IPasserbyNpcSplineMoveT passerbyNpcSplineMoveT = new IPasserbyNpcSplineMoveT();
			this.UnPackTo(passerbyNpcSplineMoveT);
			return passerbyNpcSplineMoveT;
		}

		// Token: 0x060252BE RID: 152254 RVA: 0x0052172C File Offset: 0x0051F92C
		public void UnPackTo(IPasserbyNpcSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.Routes = new List<IPasserbyNpcSplineT>();
			for (int i = 0; i < this.RoutesLength; i++)
			{
				_o.Routes.Add((this.Routes(i) != null) ? this.Routes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060252BF RID: 152255 RVA: 0x00521798 File Offset: 0x0051F998
		public static Offset<IPasserbyNpcSplineMove> Pack(FlatBufferBuilder builder, IPasserbyNpcSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcSplineMove>);
			}
			VectorOffset routesOffset = default(VectorOffset);
			if (_o.Routes != null)
			{
				Offset<IPasserbyNpcSpline>[] array = new Offset<IPasserbyNpcSpline>[_o.Routes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPasserbyNpcSpline.Pack(builder, _o.Routes[i]);
				}
				routesOffset = IPasserbyNpcSplineMove.CreateRoutesVector(builder, array);
			}
			return IPasserbyNpcSplineMove.CreateIPasserbyNpcSplineMove(builder, _o.Type, routesOffset);
		}

		// Token: 0x0400EB33 RID: 60211
		private Table __p;
	}
}
