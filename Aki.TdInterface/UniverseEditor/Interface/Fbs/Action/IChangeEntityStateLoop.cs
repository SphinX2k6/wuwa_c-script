using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062F3 RID: 25331
	public struct IChangeEntityStateLoop : IFlatbufferObject
	{
		// Token: 0x1700BD11 RID: 48401
		// (get) Token: 0x0602BCA7 RID: 179367 RVA: 0x00605FB8 File Offset: 0x006041B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCA8 RID: 179368 RVA: 0x00605FC5 File Offset: 0x006041C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCA9 RID: 179369 RVA: 0x00605FCC File Offset: 0x006041CC
		public static IChangeEntityStateLoop GetRootAsIChangeEntityStateLoop(ByteBuffer _bb)
		{
			return IChangeEntityStateLoop.GetRootAsIChangeEntityStateLoop(_bb, default(IChangeEntityStateLoop));
		}

		// Token: 0x0602BCAA RID: 179370 RVA: 0x00605FE8 File Offset: 0x006041E8
		public static IChangeEntityStateLoop GetRootAsIChangeEntityStateLoop(ByteBuffer _bb, IChangeEntityStateLoop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCAB RID: 179371 RVA: 0x00606005 File Offset: 0x00604205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCAC RID: 179372 RVA: 0x00606014 File Offset: 0x00604214
		public IChangeEntityStateLoop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD12 RID: 48402
		// (get) Token: 0x0602BCAD RID: 179373 RVA: 0x00606024 File Offset: 0x00604224
		public EChangeEntityState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeEntityState.Directly;
				}
				return (EChangeEntityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD13 RID: 48403
		// (get) Token: 0x0602BCAE RID: 179374 RVA: 0x00606060 File Offset: 0x00604260
		public int EntityId
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

		// Token: 0x1700BD14 RID: 48404
		// (get) Token: 0x0602BCAF RID: 179375 RVA: 0x0060609C File Offset: 0x0060429C
		public ELoopStateType Circulation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ELoopStateType.Prev;
				}
				return (ELoopStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BCB0 RID: 179376 RVA: 0x006060D8 File Offset: 0x006042D8
		public static Offset<IChangeEntityStateLoop> CreateIChangeEntityStateLoop(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0, ELoopStateType Circulation = ELoopStateType.Prev)
		{
			builder.StartTable(3);
			IChangeEntityStateLoop.AddEntityId(builder, EntityId);
			IChangeEntityStateLoop.AddCirculation(builder, Circulation);
			IChangeEntityStateLoop.AddType(builder, Type);
			return IChangeEntityStateLoop.EndIChangeEntityStateLoop(builder);
		}

		// Token: 0x0602BCB1 RID: 179377 RVA: 0x006060FC File Offset: 0x006042FC
		public static void StartIChangeEntityStateLoop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BCB2 RID: 179378 RVA: 0x00606105 File Offset: 0x00604305
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BCB3 RID: 179379 RVA: 0x00606110 File Offset: 0x00604310
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602BCB4 RID: 179380 RVA: 0x0060611B File Offset: 0x0060431B
		public static void AddCirculation(FlatBufferBuilder builder, ELoopStateType circulation)
		{
			builder.AddByte(2, (byte)circulation, 0);
		}

		// Token: 0x0602BCB5 RID: 179381 RVA: 0x00606126 File Offset: 0x00604326
		public static Offset<IChangeEntityStateLoop> EndIChangeEntityStateLoop(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateLoop>(builder.EndTable());
		}

		// Token: 0x0602BCB6 RID: 179382 RVA: 0x00606134 File Offset: 0x00604334
		public IChangeEntityStateLoopT UnPack()
		{
			IChangeEntityStateLoopT changeEntityStateLoopT = new IChangeEntityStateLoopT();
			this.UnPackTo(changeEntityStateLoopT);
			return changeEntityStateLoopT;
		}

		// Token: 0x0602BCB7 RID: 179383 RVA: 0x0060614F File Offset: 0x0060434F
		public void UnPackTo(IChangeEntityStateLoopT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Circulation = this.Circulation;
		}

		// Token: 0x0602BCB8 RID: 179384 RVA: 0x00606178 File Offset: 0x00604378
		public static Offset<IChangeEntityStateLoop> Pack(FlatBufferBuilder builder, IChangeEntityStateLoopT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityStateLoop>);
			}
			return IChangeEntityStateLoop.CreateIChangeEntityStateLoop(builder, _o.Type, _o.EntityId, _o.Circulation);
		}

		// Token: 0x040108A7 RID: 67751
		private Table __p;
	}
}
