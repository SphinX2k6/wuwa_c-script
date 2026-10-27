using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531B RID: 21275
	public struct IGraph3dNodeNormal : IFlatbufferObject
	{
		// Token: 0x17009C36 RID: 39990
		// (get) Token: 0x06022C18 RID: 142360 RVA: 0x004D0AB4 File Offset: 0x004CECB4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C19 RID: 142361 RVA: 0x004D0AC1 File Offset: 0x004CECC1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C1A RID: 142362 RVA: 0x004D0AC8 File Offset: 0x004CECC8
		public static IGraph3dNodeNormal GetRootAsIGraph3dNodeNormal(ByteBuffer _bb)
		{
			return IGraph3dNodeNormal.GetRootAsIGraph3dNodeNormal(_bb, default(IGraph3dNodeNormal));
		}

		// Token: 0x06022C1B RID: 142363 RVA: 0x004D0AE4 File Offset: 0x004CECE4
		public static IGraph3dNodeNormal GetRootAsIGraph3dNodeNormal(ByteBuffer _bb, IGraph3dNodeNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C1C RID: 142364 RVA: 0x004D0B01 File Offset: 0x004CED01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C1D RID: 142365 RVA: 0x004D0B10 File Offset: 0x004CED10
		public IGraph3dNodeNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C37 RID: 39991
		// (get) Token: 0x06022C1E RID: 142366 RVA: 0x004D0B20 File Offset: 0x004CED20
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

		// Token: 0x17009C38 RID: 39992
		// (get) Token: 0x06022C1F RID: 142367 RVA: 0x004D0B5C File Offset: 0x004CED5C
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022C20 RID: 142368 RVA: 0x004D0BB9 File Offset: 0x004CEDB9
		public static Offset<IGraph3dNodeNormal> CreateIGraph3dNodeNormal(FlatBufferBuilder builder, int Id = 0, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGraph3dNodeNormal.AddPosition(builder, PositionOffset);
			IGraph3dNodeNormal.AddId(builder, Id);
			return IGraph3dNodeNormal.EndIGraph3dNodeNormal(builder);
		}

		// Token: 0x06022C21 RID: 142369 RVA: 0x004D0BD6 File Offset: 0x004CEDD6
		public static void StartIGraph3dNodeNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022C22 RID: 142370 RVA: 0x004D0BDF File Offset: 0x004CEDDF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06022C23 RID: 142371 RVA: 0x004D0BEA File Offset: 0x004CEDEA
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06022C24 RID: 142372 RVA: 0x004D0BFA File Offset: 0x004CEDFA
		public static Offset<IGraph3dNodeNormal> EndIGraph3dNodeNormal(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNodeNormal>(builder.EndTable());
		}

		// Token: 0x06022C25 RID: 142373 RVA: 0x004D0C08 File Offset: 0x004CEE08
		public IGraph3dNodeNormalT UnPack()
		{
			IGraph3dNodeNormalT graph3dNodeNormalT = new IGraph3dNodeNormalT();
			this.UnPackTo(graph3dNodeNormalT);
			return graph3dNodeNormalT;
		}

		// Token: 0x06022C26 RID: 142374 RVA: 0x004D0C24 File Offset: 0x004CEE24
		public void UnPackTo(IGraph3dNodeNormalT _o)
		{
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06022C27 RID: 142375 RVA: 0x004D0C6C File Offset: 0x004CEE6C
		public static Offset<IGraph3dNodeNormal> Pack(FlatBufferBuilder builder, IGraph3dNodeNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dNodeNormal>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IGraph3dNodeNormal.CreateIGraph3dNodeNormal(builder, _o.Id, positionOffset);
		}

		// Token: 0x0400E4D4 RID: 58580
		private Table __p;
	}
}
