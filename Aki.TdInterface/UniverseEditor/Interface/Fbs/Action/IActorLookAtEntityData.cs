using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060DD RID: 24797
	public struct IActorLookAtEntityData : IFlatbufferObject
	{
		// Token: 0x1700B6B9 RID: 46777
		// (get) Token: 0x0602A5A2 RID: 173474 RVA: 0x005D6448 File Offset: 0x005D4648
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A5A3 RID: 173475 RVA: 0x005D6455 File Offset: 0x005D4655
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A5A4 RID: 173476 RVA: 0x005D645C File Offset: 0x005D465C
		public static IActorLookAtEntityData GetRootAsIActorLookAtEntityData(ByteBuffer _bb)
		{
			return IActorLookAtEntityData.GetRootAsIActorLookAtEntityData(_bb, default(IActorLookAtEntityData));
		}

		// Token: 0x0602A5A5 RID: 173477 RVA: 0x005D6478 File Offset: 0x005D4678
		public static IActorLookAtEntityData GetRootAsIActorLookAtEntityData(ByteBuffer _bb, IActorLookAtEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A5A6 RID: 173478 RVA: 0x005D6495 File Offset: 0x005D4695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A5A7 RID: 173479 RVA: 0x005D64A4 File Offset: 0x005D46A4
		public IActorLookAtEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6BA RID: 46778
		// (get) Token: 0x0602A5A8 RID: 173480 RVA: 0x005D64B4 File Offset: 0x005D46B4
		public EActorLookAtMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorLookAtMode.Talker;
				}
				return (EActorLookAtMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B6BB RID: 46779
		// (get) Token: 0x0602A5A9 RID: 173481 RVA: 0x005D64F0 File Offset: 0x005D46F0
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6BC RID: 46780
		// (get) Token: 0x0602A5AA RID: 173482 RVA: 0x005D6530 File Offset: 0x005D4730
		public int EntityId
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

		// Token: 0x1700B6BD RID: 46781
		// (get) Token: 0x0602A5AB RID: 173483 RVA: 0x005D656C File Offset: 0x005D476C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A5AC RID: 173484 RVA: 0x005D65A9 File Offset: 0x005D47A9
		public static Offset<IActorLookAtEntityData> CreateIActorLookAtEntityData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtEntityData.AddEntityId(builder, EntityId);
			IActorLookAtEntityData.AddNullMask(builder, NullMask);
			IActorLookAtEntityData.AddLock(builder, Lock);
			IActorLookAtEntityData.AddType(builder, Type);
			return IActorLookAtEntityData.EndIActorLookAtEntityData(builder);
		}

		// Token: 0x0602A5AD RID: 173485 RVA: 0x005D65D5 File Offset: 0x005D47D5
		public static void StartIActorLookAtEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602A5AE RID: 173486 RVA: 0x005D65DE File Offset: 0x005D47DE
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A5AF RID: 173487 RVA: 0x005D65E9 File Offset: 0x005D47E9
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602A5B0 RID: 173488 RVA: 0x005D65F4 File Offset: 0x005D47F4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0602A5B1 RID: 173489 RVA: 0x005D65FF File Offset: 0x005D47FF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602A5B2 RID: 173490 RVA: 0x005D660A File Offset: 0x005D480A
		public static Offset<IActorLookAtEntityData> EndIActorLookAtEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtEntityData>(builder.EndTable());
		}

		// Token: 0x0602A5B3 RID: 173491 RVA: 0x005D6618 File Offset: 0x005D4818
		public IActorLookAtEntityDataT UnPack()
		{
			IActorLookAtEntityDataT actorLookAtEntityDataT = new IActorLookAtEntityDataT();
			this.UnPackTo(actorLookAtEntityDataT);
			return actorLookAtEntityDataT;
		}

		// Token: 0x0602A5B4 RID: 173492 RVA: 0x005D6633 File Offset: 0x005D4833
		public void UnPackTo(IActorLookAtEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A5B5 RID: 173493 RVA: 0x005D6668 File Offset: 0x005D4868
		public static Offset<IActorLookAtEntityData> Pack(FlatBufferBuilder builder, IActorLookAtEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtEntityData>);
			}
			return IActorLookAtEntityData.CreateIActorLookAtEntityData(builder, _o.Type, _o.Lock, _o.EntityId, _o.NullMask);
		}

		// Token: 0x04010497 RID: 66711
		private Table __p;
	}
}
