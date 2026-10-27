using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005309 RID: 21257
	public struct IGraph3dEdgeBase : IFlatbufferObject
	{
		// Token: 0x17009C15 RID: 39957
		// (get) Token: 0x06022B92 RID: 142226 RVA: 0x004CFCEF File Offset: 0x004CDEEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022B93 RID: 142227 RVA: 0x004CFCFC File Offset: 0x004CDEFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022B94 RID: 142228 RVA: 0x004CFD04 File Offset: 0x004CDF04
		public static IGraph3dEdgeBase GetRootAsIGraph3dEdgeBase(ByteBuffer _bb)
		{
			return IGraph3dEdgeBase.GetRootAsIGraph3dEdgeBase(_bb, default(IGraph3dEdgeBase));
		}

		// Token: 0x06022B95 RID: 142229 RVA: 0x004CFD20 File Offset: 0x004CDF20
		public static IGraph3dEdgeBase GetRootAsIGraph3dEdgeBase(ByteBuffer _bb, IGraph3dEdgeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022B96 RID: 142230 RVA: 0x004CFD3D File Offset: 0x004CDF3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022B97 RID: 142231 RVA: 0x004CFD4C File Offset: 0x004CDF4C
		public IGraph3dEdgeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C16 RID: 39958
		// (get) Token: 0x06022B98 RID: 142232 RVA: 0x004CFD5C File Offset: 0x004CDF5C
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

		// Token: 0x17009C17 RID: 39959
		// (get) Token: 0x06022B99 RID: 142233 RVA: 0x004CFD98 File Offset: 0x004CDF98
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

		// Token: 0x17009C18 RID: 39960
		// (get) Token: 0x06022B9A RID: 142234 RVA: 0x004CFDD4 File Offset: 0x004CDFD4
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

		// Token: 0x06022B9B RID: 142235 RVA: 0x004CFE10 File Offset: 0x004CE010
		public static Offset<IGraph3dEdgeBase> CreateIGraph3dEdgeBase(FlatBufferBuilder builder, int Id = 0, int From = 0, int To = 0)
		{
			builder.StartTable(3);
			IGraph3dEdgeBase.AddTo(builder, To);
			IGraph3dEdgeBase.AddFrom(builder, From);
			IGraph3dEdgeBase.AddId(builder, Id);
			return IGraph3dEdgeBase.EndIGraph3dEdgeBase(builder);
		}

		// Token: 0x06022B9C RID: 142236 RVA: 0x004CFE34 File Offset: 0x004CE034
		public static void StartIGraph3dEdgeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022B9D RID: 142237 RVA: 0x004CFE3D File Offset: 0x004CE03D
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06022B9E RID: 142238 RVA: 0x004CFE48 File Offset: 0x004CE048
		public static void AddFrom(FlatBufferBuilder builder, int from)
		{
			builder.AddInt(1, from, 0);
		}

		// Token: 0x06022B9F RID: 142239 RVA: 0x004CFE53 File Offset: 0x004CE053
		public static void AddTo(FlatBufferBuilder builder, int to)
		{
			builder.AddInt(2, to, 0);
		}

		// Token: 0x06022BA0 RID: 142240 RVA: 0x004CFE5E File Offset: 0x004CE05E
		public static Offset<IGraph3dEdgeBase> EndIGraph3dEdgeBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEdgeBase>(builder.EndTable());
		}

		// Token: 0x06022BA1 RID: 142241 RVA: 0x004CFE6C File Offset: 0x004CE06C
		public IGraph3dEdgeBaseT UnPack()
		{
			IGraph3dEdgeBaseT graph3dEdgeBaseT = new IGraph3dEdgeBaseT();
			this.UnPackTo(graph3dEdgeBaseT);
			return graph3dEdgeBaseT;
		}

		// Token: 0x06022BA2 RID: 142242 RVA: 0x004CFE87 File Offset: 0x004CE087
		public void UnPackTo(IGraph3dEdgeBaseT _o)
		{
			_o.Id = this.Id;
			_o.From = this.From;
			_o.To = this.To;
		}

		// Token: 0x06022BA3 RID: 142243 RVA: 0x004CFEB0 File Offset: 0x004CE0B0
		public static Offset<IGraph3dEdgeBase> Pack(FlatBufferBuilder builder, IGraph3dEdgeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEdgeBase>);
			}
			return IGraph3dEdgeBase.CreateIGraph3dEdgeBase(builder, _o.Id, _o.From, _o.To);
		}

		// Token: 0x0400E4BC RID: 58556
		private Table __p;
	}
}
