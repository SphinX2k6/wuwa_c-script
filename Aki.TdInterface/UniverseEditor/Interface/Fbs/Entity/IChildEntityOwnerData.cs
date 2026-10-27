using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004781 RID: 18305
	public struct IChildEntityOwnerData : IFlatbufferObject
	{
		// Token: 0x1700834B RID: 33611
		// (get) Token: 0x0601C2F7 RID: 115447 RVA: 0x003FDDD3 File Offset: 0x003FBFD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C2F8 RID: 115448 RVA: 0x003FDDE0 File Offset: 0x003FBFE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C2F9 RID: 115449 RVA: 0x003FDDE8 File Offset: 0x003FBFE8
		public static IChildEntityOwnerData GetRootAsIChildEntityOwnerData(ByteBuffer _bb)
		{
			return IChildEntityOwnerData.GetRootAsIChildEntityOwnerData(_bb, default(IChildEntityOwnerData));
		}

		// Token: 0x0601C2FA RID: 115450 RVA: 0x003FDE04 File Offset: 0x003FC004
		public static IChildEntityOwnerData GetRootAsIChildEntityOwnerData(ByteBuffer _bb, IChildEntityOwnerData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C2FB RID: 115451 RVA: 0x003FDE21 File Offset: 0x003FC021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x003FDE30 File Offset: 0x003FC030
		public IChildEntityOwnerData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700834C RID: 33612
		// (get) Token: 0x0601C2FD RID: 115453 RVA: 0x003FDE40 File Offset: 0x003FC040
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

		// Token: 0x1700834D RID: 33613
		// (get) Token: 0x0601C2FE RID: 115454 RVA: 0x003FDE7C File Offset: 0x003FC07C
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

		// Token: 0x1700834E RID: 33614
		// (get) Token: 0x0601C2FF RID: 115455 RVA: 0x003FDEB8 File Offset: 0x003FC0B8
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

		// Token: 0x0601C300 RID: 115456 RVA: 0x003FDF15 File Offset: 0x003FC115
		public static Offset<IChildEntityOwnerData> CreateIChildEntityOwnerData(FlatBufferBuilder builder, int LevelId = 0, int EntityId = 0, Offset<IEntityOwnerEntity> OwnerOffset = default(Offset<IEntityOwnerEntity>))
		{
			builder.StartTable(3);
			IChildEntityOwnerData.AddOwner(builder, OwnerOffset);
			IChildEntityOwnerData.AddEntityId(builder, EntityId);
			IChildEntityOwnerData.AddLevelId(builder, LevelId);
			return IChildEntityOwnerData.EndIChildEntityOwnerData(builder);
		}

		// Token: 0x0601C301 RID: 115457 RVA: 0x003FDF39 File Offset: 0x003FC139
		public static void StartIChildEntityOwnerData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C302 RID: 115458 RVA: 0x003FDF42 File Offset: 0x003FC142
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601C303 RID: 115459 RVA: 0x003FDF4D File Offset: 0x003FC14D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601C304 RID: 115460 RVA: 0x003FDF58 File Offset: 0x003FC158
		public static void AddOwner(FlatBufferBuilder builder, Offset<IEntityOwnerEntity> ownerOffset)
		{
			builder.AddOffset(2, ownerOffset.Value, 0);
		}

		// Token: 0x0601C305 RID: 115461 RVA: 0x003FDF68 File Offset: 0x003FC168
		public static Offset<IChildEntityOwnerData> EndIChildEntityOwnerData(FlatBufferBuilder builder)
		{
			return new Offset<IChildEntityOwnerData>(builder.EndTable());
		}

		// Token: 0x0601C306 RID: 115462 RVA: 0x003FDF78 File Offset: 0x003FC178
		public IChildEntityOwnerDataT UnPack()
		{
			IChildEntityOwnerDataT childEntityOwnerDataT = new IChildEntityOwnerDataT();
			this.UnPackTo(childEntityOwnerDataT);
			return childEntityOwnerDataT;
		}

		// Token: 0x0601C307 RID: 115463 RVA: 0x003FDF94 File Offset: 0x003FC194
		public void UnPackTo(IChildEntityOwnerDataT _o)
		{
			_o.LevelId = this.LevelId;
			_o.EntityId = this.EntityId;
			_o.Owner = ((this.Owner != null) ? this.Owner.Value.UnPack() : null);
		}

		// Token: 0x0601C308 RID: 115464 RVA: 0x003FDFE8 File Offset: 0x003FC1E8
		public static Offset<IChildEntityOwnerData> Pack(FlatBufferBuilder builder, IChildEntityOwnerDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildEntityOwnerData>);
			}
			Offset<IEntityOwnerEntity> ownerOffset = (_o.Owner == null) ? default(Offset<IEntityOwnerEntity>) : IEntityOwnerEntity.Pack(builder, _o.Owner);
			return IChildEntityOwnerData.CreateIChildEntityOwnerData(builder, _o.LevelId, _o.EntityId, ownerOffset);
		}

		// Token: 0x0400CBE2 RID: 52194
		private Table __p;
	}
}
