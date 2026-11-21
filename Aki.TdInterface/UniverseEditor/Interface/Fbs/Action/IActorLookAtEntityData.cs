using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673F RID: 26431
	public struct IActorLookAtEntityData : IFlatbufferObject
	{
		// Token: 0x1700C024 RID: 49188
		// (get) Token: 0x0602CC83 RID: 183427 RVA: 0x006203F0 File Offset: 0x0061E5F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC84 RID: 183428 RVA: 0x006203FD File Offset: 0x0061E5FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC85 RID: 183429 RVA: 0x00620404 File Offset: 0x0061E604
		public static IActorLookAtEntityData GetRootAsIActorLookAtEntityData(ByteBuffer _bb)
		{
			return IActorLookAtEntityData.GetRootAsIActorLookAtEntityData(_bb, default(IActorLookAtEntityData));
		}

		// Token: 0x0602CC86 RID: 183430 RVA: 0x00620420 File Offset: 0x0061E620
		public static IActorLookAtEntityData GetRootAsIActorLookAtEntityData(ByteBuffer _bb, IActorLookAtEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC87 RID: 183431 RVA: 0x0062043D File Offset: 0x0061E63D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC88 RID: 183432 RVA: 0x0062044C File Offset: 0x0061E64C
		public IActorLookAtEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C025 RID: 49189
		// (get) Token: 0x0602CC89 RID: 183433 RVA: 0x0062045C File Offset: 0x0061E65C
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

		// Token: 0x1700C026 RID: 49190
		// (get) Token: 0x0602CC8A RID: 183434 RVA: 0x00620498 File Offset: 0x0061E698
		public bool Lock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C027 RID: 49191
		// (get) Token: 0x0602CC8B RID: 183435 RVA: 0x006204D8 File Offset: 0x0061E6D8
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

		// Token: 0x1700C028 RID: 49192
		// (get) Token: 0x0602CC8C RID: 183436 RVA: 0x00620514 File Offset: 0x0061E714
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

		// Token: 0x0602CC8D RID: 183437 RVA: 0x00620551 File Offset: 0x0061E751
		public static Offset<IActorLookAtEntityData> CreateIActorLookAtEntityData(FlatBufferBuilder builder, EActorLookAtMode Type = EActorLookAtMode.Talker, bool Lock = false, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IActorLookAtEntityData.AddEntityId(builder, EntityId);
			IActorLookAtEntityData.AddNullMask(builder, NullMask);
			IActorLookAtEntityData.AddLock(builder, Lock);
			IActorLookAtEntityData.AddType(builder, Type);
			return IActorLookAtEntityData.EndIActorLookAtEntityData(builder);
		}

		// Token: 0x0602CC8E RID: 183438 RVA: 0x0062057D File Offset: 0x0061E77D
		public static void StartIActorLookAtEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CC8F RID: 183439 RVA: 0x00620586 File Offset: 0x0061E786
		public static void AddType(FlatBufferBuilder builder, EActorLookAtMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC90 RID: 183440 RVA: 0x00620591 File Offset: 0x0061E791
		public static void AddLock(FlatBufferBuilder builder, bool @lock)
		{
			builder.AddBool(1, @lock, false);
		}

		// Token: 0x0602CC91 RID: 183441 RVA: 0x0062059C File Offset: 0x0061E79C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0602CC92 RID: 183442 RVA: 0x006205A7 File Offset: 0x0061E7A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602CC93 RID: 183443 RVA: 0x006205B2 File Offset: 0x0061E7B2
		public static Offset<IActorLookAtEntityData> EndIActorLookAtEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAtEntityData>(builder.EndTable());
		}

		// Token: 0x0602CC94 RID: 183444 RVA: 0x006205C0 File Offset: 0x0061E7C0
		public IActorLookAtEntityDataT UnPack()
		{
			IActorLookAtEntityDataT actorLookAtEntityDataT = new IActorLookAtEntityDataT();
			this.UnPackTo(actorLookAtEntityDataT);
			return actorLookAtEntityDataT;
		}

		// Token: 0x0602CC95 RID: 183445 RVA: 0x006205DB File Offset: 0x0061E7DB
		public void UnPackTo(IActorLookAtEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.Lock = this.Lock;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CC96 RID: 183446 RVA: 0x00620610 File Offset: 0x0061E810
		public static Offset<IActorLookAtEntityData> Pack(FlatBufferBuilder builder, IActorLookAtEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAtEntityData>);
			}
			return IActorLookAtEntityData.CreateIActorLookAtEntityData(builder, _o.Type, _o.Lock, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0401129B RID: 70299
		private Table __p;
	}
}
