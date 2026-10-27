using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005318 RID: 21272
	public struct IGraph3dNodeBase : IFlatbufferObject
	{
		// Token: 0x17009C31 RID: 39985
		// (get) Token: 0x06022C02 RID: 142338 RVA: 0x004D0827 File Offset: 0x004CEA27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C03 RID: 142339 RVA: 0x004D0834 File Offset: 0x004CEA34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C04 RID: 142340 RVA: 0x004D083C File Offset: 0x004CEA3C
		public static IGraph3dNodeBase GetRootAsIGraph3dNodeBase(ByteBuffer _bb)
		{
			return IGraph3dNodeBase.GetRootAsIGraph3dNodeBase(_bb, default(IGraph3dNodeBase));
		}

		// Token: 0x06022C05 RID: 142341 RVA: 0x004D0858 File Offset: 0x004CEA58
		public static IGraph3dNodeBase GetRootAsIGraph3dNodeBase(ByteBuffer _bb, IGraph3dNodeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C06 RID: 142342 RVA: 0x004D0875 File Offset: 0x004CEA75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C07 RID: 142343 RVA: 0x004D0884 File Offset: 0x004CEA84
		public IGraph3dNodeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C32 RID: 39986
		// (get) Token: 0x06022C08 RID: 142344 RVA: 0x004D0894 File Offset: 0x004CEA94
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

		// Token: 0x17009C33 RID: 39987
		// (get) Token: 0x06022C09 RID: 142345 RVA: 0x004D08D0 File Offset: 0x004CEAD0
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

		// Token: 0x06022C0A RID: 142346 RVA: 0x004D092D File Offset: 0x004CEB2D
		public static Offset<IGraph3dNodeBase> CreateIGraph3dNodeBase(FlatBufferBuilder builder, int Id = 0, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IGraph3dNodeBase.AddPosition(builder, PositionOffset);
			IGraph3dNodeBase.AddId(builder, Id);
			return IGraph3dNodeBase.EndIGraph3dNodeBase(builder);
		}

		// Token: 0x06022C0B RID: 142347 RVA: 0x004D094A File Offset: 0x004CEB4A
		public static void StartIGraph3dNodeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022C0C RID: 142348 RVA: 0x004D0953 File Offset: 0x004CEB53
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06022C0D RID: 142349 RVA: 0x004D095E File Offset: 0x004CEB5E
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06022C0E RID: 142350 RVA: 0x004D096E File Offset: 0x004CEB6E
		public static Offset<IGraph3dNodeBase> EndIGraph3dNodeBase(FlatBufferBuilder builder)
		{
			return new Offset<IGraph3dNodeBase>(builder.EndTable());
		}

		// Token: 0x06022C0F RID: 142351 RVA: 0x004D097C File Offset: 0x004CEB7C
		public IGraph3dNodeBaseT UnPack()
		{
			IGraph3dNodeBaseT graph3dNodeBaseT = new IGraph3dNodeBaseT();
			this.UnPackTo(graph3dNodeBaseT);
			return graph3dNodeBaseT;
		}

		// Token: 0x06022C10 RID: 142352 RVA: 0x004D0998 File Offset: 0x004CEB98
		public void UnPackTo(IGraph3dNodeBaseT _o)
		{
			_o.Id = this.Id;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
		}

		// Token: 0x06022C11 RID: 142353 RVA: 0x004D09E0 File Offset: 0x004CEBE0
		public static Offset<IGraph3dNodeBase> Pack(FlatBufferBuilder builder, IGraph3dNodeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGraph3dNodeBase>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			return IGraph3dNodeBase.CreateIGraph3dNodeBase(builder, _o.Id, positionOffset);
		}

		// Token: 0x0400E4D1 RID: 58577
		private Table __p;
	}
}
