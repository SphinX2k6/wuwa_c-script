using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006766 RID: 26470
	public struct IActorTurnToEntityData : IFlatbufferObject
	{
		// Token: 0x1700C076 RID: 49270
		// (get) Token: 0x0602CDD0 RID: 183760 RVA: 0x006228BD File Offset: 0x00620ABD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDD1 RID: 183761 RVA: 0x006228CA File Offset: 0x00620ACA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDD2 RID: 183762 RVA: 0x006228D4 File Offset: 0x00620AD4
		public static IActorTurnToEntityData GetRootAsIActorTurnToEntityData(ByteBuffer _bb)
		{
			return IActorTurnToEntityData.GetRootAsIActorTurnToEntityData(_bb, default(IActorTurnToEntityData));
		}

		// Token: 0x0602CDD3 RID: 183763 RVA: 0x006228F0 File Offset: 0x00620AF0
		public static IActorTurnToEntityData GetRootAsIActorTurnToEntityData(ByteBuffer _bb, IActorTurnToEntityData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDD4 RID: 183764 RVA: 0x0062290D File Offset: 0x00620B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDD5 RID: 183765 RVA: 0x0062291C File Offset: 0x00620B1C
		public IActorTurnToEntityData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C077 RID: 49271
		// (get) Token: 0x0602CDD6 RID: 183766 RVA: 0x0062292C File Offset: 0x00620B2C
		public EActorTurnToMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorTurnToMode.Talker;
				}
				return (EActorTurnToMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C078 RID: 49272
		// (get) Token: 0x0602CDD7 RID: 183767 RVA: 0x00622968 File Offset: 0x00620B68
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

		// Token: 0x0602CDD8 RID: 183768 RVA: 0x006229A4 File Offset: 0x00620BA4
		public static Offset<IActorTurnToEntityData> CreateIActorTurnToEntityData(FlatBufferBuilder builder, EActorTurnToMode Type = EActorTurnToMode.Talker, int EntityId = 0)
		{
			builder.StartTable(2);
			IActorTurnToEntityData.AddEntityId(builder, EntityId);
			IActorTurnToEntityData.AddType(builder, Type);
			return IActorTurnToEntityData.EndIActorTurnToEntityData(builder);
		}

		// Token: 0x0602CDD9 RID: 183769 RVA: 0x006229C1 File Offset: 0x00620BC1
		public static void StartIActorTurnToEntityData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CDDA RID: 183770 RVA: 0x006229CA File Offset: 0x00620BCA
		public static void AddType(FlatBufferBuilder builder, EActorTurnToMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDDB RID: 183771 RVA: 0x006229D5 File Offset: 0x00620BD5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602CDDC RID: 183772 RVA: 0x006229E0 File Offset: 0x00620BE0
		public static Offset<IActorTurnToEntityData> EndIActorTurnToEntityData(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnToEntityData>(builder.EndTable());
		}

		// Token: 0x0602CDDD RID: 183773 RVA: 0x006229F0 File Offset: 0x00620BF0
		public IActorTurnToEntityDataT UnPack()
		{
			IActorTurnToEntityDataT actorTurnToEntityDataT = new IActorTurnToEntityDataT();
			this.UnPackTo(actorTurnToEntityDataT);
			return actorTurnToEntityDataT;
		}

		// Token: 0x0602CDDE RID: 183774 RVA: 0x00622A0B File Offset: 0x00620C0B
		public void UnPackTo(IActorTurnToEntityDataT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0602CDDF RID: 183775 RVA: 0x00622A28 File Offset: 0x00620C28
		public static Offset<IActorTurnToEntityData> Pack(FlatBufferBuilder builder, IActorTurnToEntityDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnToEntityData>);
			}
			return IActorTurnToEntityData.CreateIActorTurnToEntityData(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x040112D3 RID: 70355
		private Table __p;
	}
}
