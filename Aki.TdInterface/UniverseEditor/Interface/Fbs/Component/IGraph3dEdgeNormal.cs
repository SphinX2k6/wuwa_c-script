using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200530C RID: 21260
	public struct IGraph3dEdgeNormal : IFlatbufferObject
	{
		// Token: 0x17009C1C RID: 39964
		// (get) Token: 0x06022BAC RID: 142252 RVA: 0x004CFF80 File Offset: 0x004CE180
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022BAD RID: 142253 RVA: 0x004CFF8D File Offset: 0x004CE18D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022BAE RID: 142254 RVA: 0x004CFF94 File Offset: 0x004CE194
		public static IGraph3dEdgeNormal GetRootAsIGraph3dEdgeNormal(ByteBuffer _bb)
		{
			return IGraph3dEdgeNormal.GetRootAsIGraph3dEdgeNormal(_bb, default(IGraph3dEdgeNormal));
		}

		// Token: 0x06022BAF RID: 142255 RVA: 0x004CFFB0 File Offset: 0x004CE1B0
		public static IGraph3dEdgeNormal GetRootAsIGraph3dEdgeNormal(ByteBuffer _bb, IGraph3dEdgeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022BB0 RID: 142256 RVA: 0x004CFFCD File Offset: 0x004CE1CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022BB1 RID: 142257 RVA: 0x004CFFDC File Offset: 0x004CE1DC
		public IGraph3dEdgeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C1D RID: 39965
		// (get) Token: 0x06022BB2 RID: 142258 RVA: 0x004CFFEC File Offset: 0x004CE1EC
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

		// Token: 0x17009C1E RID: 39966
		// (get) Token: 0x06022BB3 RID: 142259 RVA: 0x004D0028 File Offset: 0x004CE228
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

		// Token: 0x17009C1F RID: 39967
		// (get) Token: 0x06022BB4 RID: 142260 RVA: 0x004D0064 File Offset: 0x004CE264
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

		// Token: 0x06022BB5 RID: 142261 RVA: 0x004D00A0 File Offset: 0x004CE2A0
		public static Offset<IGraph3dEdgeNormal> CreateIGraph3dEdgeNormal(FlatBufferBuilder builder, int Id = 0, int From = 0, int To = 0)
		{
			builder.StartTable(3);
			IGraph3dEdgeNormal.AddTo(builder, To);
			IGraph3dEdgeNormal.AddFrom(builder, From);
			IGraph3dEdgeNormal.AddId(builder, Id);
			return IGraph3dEdgeNormal.EndIGraph3dEdgeNormal(builder);
		}

		// Token: 0x06022BB6 RID: 142262 RVA: 0x004D00C4 File Offset: 0x004CE2C4
		public static void StartIGraph3dEdgeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022BB7 RID: 142263 RVA: 0x004D00CD File Offset: 0x004CE2CD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06022BB8 RID: 142264 RVA: 0x004D00D8 File Offset: 0x004CE2D8
		public static void AddFrom(FlatBufferBuilder builder, int from)
		{
			builder.AddInt(1, from, 0);
		}

		// Token: 0x06022BB9 RID: 142265 RVA: 0x004D00E3 File Offset: 0x004CE2E3
		public static void AddTo(FlatBufferBuilder builder, int to)
		{
			builder.AddInt(2, to, 0);
		}

		// Token: 0x06022BBA RID: 142266 RVA: 0x004D00EE File Offset: 0x004CE2EE
		public static Offset<IGraph3dEdgeNormal> EndIGraph3dEdgeNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dEdgeNormal>(builder.EndTable());
		}

		// Token: 0x06022BBB RID: 142267 RVA: 0x004D00FC File Offset: 0x004CE2FC
		public IGraph3dEdgeNormalT UnPack()
		{
			IGraph3dEdgeNormalT graph3dEdgeNormalT = new IGraph3dEdgeNormalT();
			this.UnPackTo(graph3dEdgeNormalT);
			return graph3dEdgeNormalT;
		}

		// Token: 0x06022BBC RID: 142268 RVA: 0x004D0117 File Offset: 0x004CE317
		public void UnPackTo(IGraph3dEdgeNormalT _o)
		{
			_o.Id = this.Id;
			_o.From = this.From;
			_o.To = this.To;
		}

		// Token: 0x06022BBD RID: 142269 RVA: 0x004D0140 File Offset: 0x004CE340
		public static Offset<IGraph3dEdgeNormal> Pack(FlatBufferBuilder builder, IGraph3dEdgeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dEdgeNormal>);
			}
			return IGraph3dEdgeNormal.CreateIGraph3dEdgeNormal(builder, _o.Id, _o.From, _o.To);
		}

		// Token: 0x0400E4C0 RID: 58560
		private Table __p;
	}
}
