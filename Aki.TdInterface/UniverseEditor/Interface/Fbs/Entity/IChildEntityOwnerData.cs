using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE9 RID: 19433
	public struct IChildEntityOwnerData : IFlatbufferObject
	{
		// Token: 0x1700898C RID: 35212
		// (get) Token: 0x0601DACC RID: 121548 RVA: 0x0042A06F File Offset: 0x0042826F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DACD RID: 121549 RVA: 0x0042A07C File Offset: 0x0042827C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DACE RID: 121550 RVA: 0x0042A084 File Offset: 0x00428284
		public static IChildEntityOwnerData GetRootAsIChildEntityOwnerData(ByteBuffer _bb)
		{
			return IChildEntityOwnerData.GetRootAsIChildEntityOwnerData(_bb, default(IChildEntityOwnerData));
		}

		// Token: 0x0601DACF RID: 121551 RVA: 0x0042A0A0 File Offset: 0x004282A0
		public static IChildEntityOwnerData GetRootAsIChildEntityOwnerData(ByteBuffer _bb, IChildEntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DAD0 RID: 121552 RVA: 0x0042A0BD File Offset: 0x004282BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAD1 RID: 121553 RVA: 0x0042A0CC File Offset: 0x004282CC
		public IChildEntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700898D RID: 35213
		// (get) Token: 0x0601DAD2 RID: 121554 RVA: 0x0042A0DC File Offset: 0x004282DC
		public int LevelId
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

		// Token: 0x1700898E RID: 35214
		// (get) Token: 0x0601DAD3 RID: 121555 RVA: 0x0042A118 File Offset: 0x00428318
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

		// Token: 0x1700898F RID: 35215
		// (get) Token: 0x0601DAD4 RID: 121556 RVA: 0x0042A154 File Offset: 0x00428354
		public IEntityOwnerEntity? Owner
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IEntityOwnerEntity?(default(IEntityOwnerEntity).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601DAD5 RID: 121557 RVA: 0x0042A1B1 File Offset: 0x004283B1
		public static Offset<IChildEntityOwnerData> CreateIChildEntityOwnerData(FlatBufferBuilder builder, int LevelId = 0, int EntityId = 0, Offset<IEntityOwnerEntity> OwnerOffset = default(Offset<IEntityOwnerEntity>))
		{
			builder.StartTable(3);
			IChildEntityOwnerData.AddOwner(builder, OwnerOffset);
			IChildEntityOwnerData.AddEntityId(builder, EntityId);
			IChildEntityOwnerData.AddLevelId(builder, LevelId);
			return IChildEntityOwnerData.EndIChildEntityOwnerData(builder);
		}

		// Token: 0x0601DAD6 RID: 121558 RVA: 0x0042A1D5 File Offset: 0x004283D5
		public static void StartIChildEntityOwnerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DAD7 RID: 121559 RVA: 0x0042A1DE File Offset: 0x004283DE
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601DAD8 RID: 121560 RVA: 0x0042A1E9 File Offset: 0x004283E9
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DAD9 RID: 121561 RVA: 0x0042A1F4 File Offset: 0x004283F4
		public static void AddOwner(FlatBufferBuilder builder, Offset<IEntityOwnerEntity> ownerOffset)
		{
			builder.AddOffset(2, ownerOffset.Value, 0);
		}

		// Token: 0x0601DADA RID: 121562 RVA: 0x0042A204 File Offset: 0x00428404
		public static Offset<IChildEntityOwnerData> EndIChildEntityOwnerData(FlatBufferBuilder builder)
		{
			return new Offset<IChildEntityOwnerData>(builder.EndTable());
		}

		// Token: 0x0601DADB RID: 121563 RVA: 0x0042A214 File Offset: 0x00428414
		public IChildEntityOwnerDataT UnPack()
		{
			IChildEntityOwnerDataT childEntityOwnerDataT = new IChildEntityOwnerDataT();
			this.UnPackTo(childEntityOwnerDataT);
			return childEntityOwnerDataT;
		}

		// Token: 0x0601DADC RID: 121564 RVA: 0x0042A230 File Offset: 0x00428430
		public void UnPackTo(IChildEntityOwnerDataT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityId = this.EntityId;
			_o.Owner = ((this.Owner != null) ? this.Owner.Value.UnPack() : null);
		}

		// Token: 0x0601DADD RID: 121565 RVA: 0x0042A284 File Offset: 0x00428484
		public static Offset<IChildEntityOwnerData> Pack(FlatBufferBuilder builder, IChildEntityOwnerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildEntityOwnerData>);
			}
			Offset<IEntityOwnerEntity> ownerOffset = (_o.Owner == null) ? default(Offset<IEntityOwnerEntity>) : IEntityOwnerEntity.Pack(builder, _o.Owner);
			return IChildEntityOwnerData.CreateIChildEntityOwnerData(builder, _o.LevelId, _o.EntityId, ownerOffset);
		}

		// Token: 0x0400D618 RID: 54808
		private Table __p;
	}
}
