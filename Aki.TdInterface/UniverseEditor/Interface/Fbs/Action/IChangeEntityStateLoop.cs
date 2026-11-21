using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006964 RID: 26980
	public struct IChangeEntityStateLoop : IFlatbufferObject
	{
		// Token: 0x1700C69B RID: 50843
		// (get) Token: 0x0602E410 RID: 189456 RVA: 0x00650FC4 File Offset: 0x0064F1C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E411 RID: 189457 RVA: 0x00650FD1 File Offset: 0x0064F1D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E412 RID: 189458 RVA: 0x00650FD8 File Offset: 0x0064F1D8
		public static IChangeEntityStateLoop GetRootAsIChangeEntityStateLoop(ByteBuffer _bb)
		{
			return IChangeEntityStateLoop.GetRootAsIChangeEntityStateLoop(_bb, default(IChangeEntityStateLoop));
		}

		// Token: 0x0602E413 RID: 189459 RVA: 0x00650FF4 File Offset: 0x0064F1F4
		public static IChangeEntityStateLoop GetRootAsIChangeEntityStateLoop(ByteBuffer _bb, IChangeEntityStateLoop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E414 RID: 189460 RVA: 0x00651011 File Offset: 0x0064F211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E415 RID: 189461 RVA: 0x00651020 File Offset: 0x0064F220
		public IChangeEntityStateLoop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C69C RID: 50844
		// (get) Token: 0x0602E416 RID: 189462 RVA: 0x00651030 File Offset: 0x0064F230
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

		// Token: 0x1700C69D RID: 50845
		// (get) Token: 0x0602E417 RID: 189463 RVA: 0x0065106C File Offset: 0x0064F26C
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

		// Token: 0x1700C69E RID: 50846
		// (get) Token: 0x0602E418 RID: 189464 RVA: 0x006510A8 File Offset: 0x0064F2A8
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

		// Token: 0x0602E419 RID: 189465 RVA: 0x006510E4 File Offset: 0x0064F2E4
		public static Offset<IChangeEntityStateLoop> CreateIChangeEntityStateLoop(FlatBufferBuilder builder, EChangeEntityState Type = EChangeEntityState.Directly, int EntityId = 0, ELoopStateType Circulation = ELoopStateType.Prev)
		{
			builder.StartTable(3);
			IChangeEntityStateLoop.AddEntityId(builder, EntityId);
			IChangeEntityStateLoop.AddCirculation(builder, Circulation);
			IChangeEntityStateLoop.AddType(builder, Type);
			return IChangeEntityStateLoop.EndIChangeEntityStateLoop(builder);
		}

		// Token: 0x0602E41A RID: 189466 RVA: 0x00651108 File Offset: 0x0064F308
		public static void StartIChangeEntityStateLoop(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E41B RID: 189467 RVA: 0x00651111 File Offset: 0x0064F311
		public static void AddType(FlatBufferBuilder builder, EChangeEntityState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E41C RID: 189468 RVA: 0x0065111C File Offset: 0x0064F31C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602E41D RID: 189469 RVA: 0x00651127 File Offset: 0x0064F327
		public static void AddCirculation(FlatBufferBuilder builder, ELoopStateType circulation)
		{
			builder.AddByte(2, (byte)circulation, 0);
		}

		// Token: 0x0602E41E RID: 189470 RVA: 0x00651132 File Offset: 0x0064F332
		public static Offset<IChangeEntityStateLoop> EndIChangeEntityStateLoop(FlatBufferBuilder builder)
		{
			return new Offset<IChangeEntityStateLoop>(builder.EndTable());
		}

		// Token: 0x0602E41F RID: 189471 RVA: 0x00651140 File Offset: 0x0064F340
		public IChangeEntityStateLoopT UnPack()
		{
			IChangeEntityStateLoopT changeEntityStateLoopT = new IChangeEntityStateLoopT();
			this.UnPackTo(changeEntityStateLoopT);
			return changeEntityStateLoopT;
		}

		// Token: 0x0602E420 RID: 189472 RVA: 0x0065115B File Offset: 0x0064F35B
		public void UnPackTo(IChangeEntityStateLoopT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.Circulation = this.Circulation;
		}

		// Token: 0x0602E421 RID: 189473 RVA: 0x00651184 File Offset: 0x0064F384
		public static Offset<IChangeEntityStateLoop> Pack(FlatBufferBuilder builder, IChangeEntityStateLoopT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeEntityStateLoop>);
			}
			return IChangeEntityStateLoop.CreateIChangeEntityStateLoop(builder, _o.Type, _o.EntityId, _o.Circulation);
		}

		// Token: 0x040116BD RID: 71357
		private Table __p;
	}
}
