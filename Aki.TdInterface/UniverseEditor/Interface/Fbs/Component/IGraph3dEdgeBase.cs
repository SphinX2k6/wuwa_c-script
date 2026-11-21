using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588F RID: 22671
	public struct IGraph3dEdgeBase : IFlatbufferObject
	{
		// Token: 0x1700A44D RID: 42061
		// (get) Token: 0x06024C46 RID: 150598 RVA: 0x0050CBC3 File Offset: 0x0050ADC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C47 RID: 150599 RVA: 0x0050CBD0 File Offset: 0x0050ADD0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C48 RID: 150600 RVA: 0x0050CBD8 File Offset: 0x0050ADD8
		public static IGraph3dEdgeBase GetRootAsIGraph3dEdgeBase(ByteBuffer _bb)
		{
			return IGraph3dEdgeBase.GetRootAsIGraph3dEdgeBase(_bb, default(IGraph3dEdgeBase));
		}

		// Token: 0x06024C49 RID: 150601 RVA: 0x0050CBF4 File Offset: 0x0050ADF4
		public static IGraph3dEdgeBase GetRootAsIGraph3dEdgeBase(ByteBuffer _bb, IGraph3dEdgeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C4A RID: 150602 RVA: 0x0050CC11 File Offset: 0x0050AE11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C4B RID: 150603 RVA: 0x0050CC20 File Offset: 0x0050AE20
		public IGraph3dEdgeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A44E RID: 42062
		// (get) Token: 0x06024C4C RID: 150604 RVA: 0x0050CC30 File Offset: 0x0050AE30
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

		// Token: 0x1700A44F RID: 42063
		// (get) Token: 0x06024C4D RID: 150605 RVA: 0x0050CC6C File Offset: 0x0050AE6C
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

		// Token: 0x1700A450 RID: 42064
		// (get) Token: 0x06024C4E RID: 150606 RVA: 0x0050CCA8 File Offset: 0x0050AEA8
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

		// Token: 0x06024C4F RID: 150607 RVA: 0x0050CCE4 File Offset: 0x0050AEE4
		public static Offset<IGraph3dEdgeBase> CreateIGraph3dEdgeBase(FlatBufferBuilder builder, int Id = 0, int From = 0, int To = 0)
		{
			builder.StartTable(3);
			IGraph3dEdgeBase.AddTo(builder, To);
			IGraph3dEdgeBase.AddFrom(builder, From);
			IGraph3dEdgeBase.AddId(builder, Id);
			return IGraph3dEdgeBase.EndIGraph3dEdgeBase(builder);
		}

		// Token: 0x06024C50 RID: 150608 RVA: 0x0050CD08 File Offset: 0x0050AF08
		public static void StartIGraph3dEdgeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024C51 RID: 150609 RVA: 0x0050CD11 File Offset: 0x0050AF11
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06024C52 RID: 150610 RVA: 0x0050CD1C File Offset: 0x0050AF1C
		public static void AddFrom(FlatBufferBuilder builder, int from)
		{
			builder.AddInt(1, from, 0);
		}

		// Token: 0x06024C53 RID: 150611 RVA: 0x0050CD27 File Offset: 0x0050AF27
		public static void AddTo(FlatBufferBuilder builder, int to)
		{
			builder.AddInt(2, to, 0);
		}

		// Token: 0x06024C54 RID: 150612 RVA: 0x0050CD32 File Offset: 0x0050AF32
		public static Offset<IGraph3dEdgeBase> EndIGraph3dEdgeBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEdgeBase>(builder.EndTable());
		}

		// Token: 0x06024C55 RID: 150613 RVA: 0x0050CD40 File Offset: 0x0050AF40
		public IGraph3dEdgeBaseT UnPack()
		{
			IGraph3dEdgeBaseT graph3dEdgeBaseT = new IGraph3dEdgeBaseT();
			this.UnPackTo(graph3dEdgeBaseT);
			return graph3dEdgeBaseT;
		}

		// Token: 0x06024C56 RID: 150614 RVA: 0x0050CD5B File Offset: 0x0050AF5B
		public void UnPackTo(IGraph3dEdgeBaseT _o)
		{
			_o.Id = this.Id;
			_o.From = this.From;
			_o.To = this.To;
		}

		// Token: 0x06024C57 RID: 150615 RVA: 0x0050CD84 File Offset: 0x0050AF84
		public static Offset<IGraph3dEdgeBase> Pack(FlatBufferBuilder builder, IGraph3dEdgeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEdgeBase>);
			}
			return IGraph3dEdgeBase.CreateIGraph3dEdgeBase(builder, _o.Id, _o.From, _o.To);
		}

		// Token: 0x0400F0EC RID: 61676
		private Table __p;
	}
}
