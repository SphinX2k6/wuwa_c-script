using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005892 RID: 22674
	public struct IGraph3dEdgeNormal : IFlatbufferObject
	{
		// Token: 0x1700A454 RID: 42068
		// (get) Token: 0x06024C60 RID: 150624 RVA: 0x0050CE54 File Offset: 0x0050B054
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C61 RID: 150625 RVA: 0x0050CE61 File Offset: 0x0050B061
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C62 RID: 150626 RVA: 0x0050CE68 File Offset: 0x0050B068
		public static IGraph3dEdgeNormal GetRootAsIGraph3dEdgeNormal(ByteBuffer _bb)
		{
			return IGraph3dEdgeNormal.GetRootAsIGraph3dEdgeNormal(_bb, default(IGraph3dEdgeNormal));
		}

		// Token: 0x06024C63 RID: 150627 RVA: 0x0050CE84 File Offset: 0x0050B084
		public static IGraph3dEdgeNormal GetRootAsIGraph3dEdgeNormal(ByteBuffer _bb, IGraph3dEdgeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C64 RID: 150628 RVA: 0x0050CEA1 File Offset: 0x0050B0A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C65 RID: 150629 RVA: 0x0050CEB0 File Offset: 0x0050B0B0
		public IGraph3dEdgeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A455 RID: 42069
		// (get) Token: 0x06024C66 RID: 150630 RVA: 0x0050CEC0 File Offset: 0x0050B0C0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A456 RID: 42070
		// (get) Token: 0x06024C67 RID: 150631 RVA: 0x0050CEFC File Offset: 0x0050B0FC
		public int From
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

		// Token: 0x1700A457 RID: 42071
		// (get) Token: 0x06024C68 RID: 150632 RVA: 0x0050CF38 File Offset: 0x0050B138
		public int To
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

		// Token: 0x06024C69 RID: 150633 RVA: 0x0050CF74 File Offset: 0x0050B174
		public static Offset<IGraph3dEdgeNormal> CreateIGraph3dEdgeNormal(FlatBufferBuilder builder, int Id = 0, int From = 0, int To = 0)
		{
			builder.StartTable(3);
			IGraph3dEdgeNormal.AddTo(builder, To);
			IGraph3dEdgeNormal.AddFrom(builder, From);
			IGraph3dEdgeNormal.AddId(builder, Id);
			return IGraph3dEdgeNormal.EndIGraph3dEdgeNormal(builder);
		}

		// Token: 0x06024C6A RID: 150634 RVA: 0x0050CF98 File Offset: 0x0050B198
		public static void StartIGraph3dEdgeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024C6B RID: 150635 RVA: 0x0050CFA1 File Offset: 0x0050B1A1
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06024C6C RID: 150636 RVA: 0x0050CFAC File Offset: 0x0050B1AC
		public static void AddFrom(FlatBufferBuilder builder, int from)
		{
			builder.AddInt(1, from, 0);
		}

		// Token: 0x06024C6D RID: 150637 RVA: 0x0050CFB7 File Offset: 0x0050B1B7
		public static void AddTo(FlatBufferBuilder builder, int to)
		{
			builder.AddInt(2, to, 0);
		}

		// Token: 0x06024C6E RID: 150638 RVA: 0x0050CFC2 File Offset: 0x0050B1C2
		public static Offset<IGraph3dEdgeNormal> EndIGraph3dEdgeNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEdgeNormal>(builder.EndTable());
		}

		// Token: 0x06024C6F RID: 150639 RVA: 0x0050CFD0 File Offset: 0x0050B1D0
		public IGraph3dEdgeNormalT UnPack()
		{
			IGraph3dEdgeNormalT graph3dEdgeNormalT = new IGraph3dEdgeNormalT();
			this.UnPackTo(graph3dEdgeNormalT);
			return graph3dEdgeNormalT;
		}

		// Token: 0x06024C70 RID: 150640 RVA: 0x0050CFEB File Offset: 0x0050B1EB
		public void UnPackTo(IGraph3dEdgeNormalT _o)
		{
			_o.Id = this.Id;
			_o.From = this.From;
			_o.To = this.To;
		}

		// Token: 0x06024C71 RID: 150641 RVA: 0x0050D014 File Offset: 0x0050B214
		public static Offset<IGraph3dEdgeNormal> Pack(FlatBufferBuilder builder, IGraph3dEdgeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEdgeNormal>);
			}
			return IGraph3dEdgeNormal.CreateIGraph3dEdgeNormal(builder, _o.Id, _o.From, _o.To);
		}

		// Token: 0x0400F0F0 RID: 61680
		private Table __p;
	}
}
