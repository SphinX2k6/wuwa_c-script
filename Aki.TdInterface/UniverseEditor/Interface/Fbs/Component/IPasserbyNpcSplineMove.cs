using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CCF RID: 23759
	public struct IPasserbyNpcSplineMove : IFlatbufferObject
	{
		// Token: 0x1700AE95 RID: 44693
		// (get) Token: 0x060276FB RID: 161531 RVA: 0x00565CAB File Offset: 0x00563EAB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060276FC RID: 161532 RVA: 0x00565CB8 File Offset: 0x00563EB8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060276FD RID: 161533 RVA: 0x00565CC0 File Offset: 0x00563EC0
		public static IPasserbyNpcSplineMove GetRootAsIPasserbyNpcSplineMove(ByteBuffer _bb)
		{
			return IPasserbyNpcSplineMove.GetRootAsIPasserbyNpcSplineMove(_bb, default(IPasserbyNpcSplineMove));
		}

		// Token: 0x060276FE RID: 161534 RVA: 0x00565CDC File Offset: 0x00563EDC
		public static IPasserbyNpcSplineMove GetRootAsIPasserbyNpcSplineMove(ByteBuffer _bb, IPasserbyNpcSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060276FF RID: 161535 RVA: 0x00565CF9 File Offset: 0x00563EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027700 RID: 161536 RVA: 0x00565D08 File Offset: 0x00563F08
		public IPasserbyNpcSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE96 RID: 44694
		// (get) Token: 0x06027701 RID: 161537 RVA: 0x00565D18 File Offset: 0x00563F18
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

		// Token: 0x06027702 RID: 161538 RVA: 0x00565D54 File Offset: 0x00563F54
		public IPasserbyNpcSpline? Routes(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPasserbyNpcSpline?(default(IPasserbyNpcSpline).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AE97 RID: 44695
		// (get) Token: 0x06027703 RID: 161539 RVA: 0x00565DB4 File Offset: 0x00563FB4
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

		// Token: 0x06027704 RID: 161540 RVA: 0x00565DDF File Offset: 0x00563FDF
		public static Offset<IPasserbyNpcSplineMove> CreateIPasserbyNpcSplineMove(FlatBufferBuilder builder, EPasserbyNpcMoveType Type = EPasserbyNpcMoveType.Spline, VectorOffset RoutesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPasserbyNpcSplineMove.AddRoutes(builder, RoutesOffset);
			IPasserbyNpcSplineMove.AddType(builder, Type);
			return IPasserbyNpcSplineMove.EndIPasserbyNpcSplineMove(builder);
		}

		// Token: 0x06027705 RID: 161541 RVA: 0x00565DFC File Offset: 0x00563FFC
		public static void StartIPasserbyNpcSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027706 RID: 161542 RVA: 0x00565E05 File Offset: 0x00564005
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027707 RID: 161543 RVA: 0x00565E10 File Offset: 0x00564010
		public static void AddRoutes(FlatBufferBuilder builder, VectorOffset routesOffset)
		{
			builder.AddOffset(1, routesOffset.Value, 0);
		}

		// Token: 0x06027708 RID: 161544 RVA: 0x00565E20 File Offset: 0x00564020
		public static VectorOffset CreateRoutesVector(FlatBufferBuilder builder, Offset<IPasserbyNpcSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027709 RID: 161545 RVA: 0x00565E60 File Offset: 0x00564060
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, Offset<IPasserbyNpcSpline>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPasserbyNpcSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602770A RID: 161546 RVA: 0x00565E7A File Offset: 0x0056407A
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPasserbyNpcSpline>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPasserbyNpcSpline>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602770B RID: 161547 RVA: 0x00565E98 File Offset: 0x00564098
		public static VectorOffset CreateRoutesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPasserbyNpcSpline>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602770C RID: 161548 RVA: 0x00565EB1 File Offset: 0x005640B1
		public static void StartRoutesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602770D RID: 161549 RVA: 0x00565EBC File Offset: 0x005640BC
		public static Offset<IPasserbyNpcSplineMove> EndIPasserbyNpcSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcSplineMove>(builder.EndTable());
		}

		// Token: 0x0602770E RID: 161550 RVA: 0x00565ECC File Offset: 0x005640CC
		public IPasserbyNpcSplineMoveT UnPack()
		{
			IPasserbyNpcSplineMoveT passerbyNpcSplineMoveT = new IPasserbyNpcSplineMoveT();
			this.UnPackTo(passerbyNpcSplineMoveT);
			return passerbyNpcSplineMoveT;
		}

		// Token: 0x0602770F RID: 161551 RVA: 0x00565EE8 File Offset: 0x005640E8
		public void UnPackTo(IPasserbyNpcSplineMoveT _o)
		{
			_o.Type = this.Type;
			_o.Routes = new List<IPasserbyNpcSplineT>();
			for (int i = 0; i < this.RoutesLength; i++)
			{
				_o.Routes.Add((this.Routes(i) != null) ? this.Routes(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06027710 RID: 161552 RVA: 0x00565F54 File Offset: 0x00564154
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

		// Token: 0x0400F7FD RID: 63485
		private Table __p;
	}
}
