using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768A RID: 30346
	public struct IRotatorEntity : IFlatbufferObject
	{
		// Token: 0x1700DEB2 RID: 57010
		// (get) Token: 0x060353B7 RID: 218039 RVA: 0x00724B06 File Offset: 0x00722D06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060353B8 RID: 218040 RVA: 0x00724B13 File Offset: 0x00722D13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060353B9 RID: 218041 RVA: 0x00724B1C File Offset: 0x00722D1C
		public static IRotatorEntity GetRootAsIRotatorEntity(ByteBuffer _bb)
		{
			return IRotatorEntity.GetRootAsIRotatorEntity(_bb, default(IRotatorEntity));
		}

		// Token: 0x060353BA RID: 218042 RVA: 0x00724B38 File Offset: 0x00722D38
		public static IRotatorEntity GetRootAsIRotatorEntity(ByteBuffer _bb, IRotatorEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060353BB RID: 218043 RVA: 0x00724B55 File Offset: 0x00722D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060353BC RID: 218044 RVA: 0x00724B64 File Offset: 0x00722D64
		public IRotatorEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEB3 RID: 57011
		// (get) Token: 0x060353BD RID: 218045 RVA: 0x00724B74 File Offset: 0x00722D74
		public TTargetEntity EntityType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060353BE RID: 218046 RVA: 0x00724BB0 File Offset: 0x00722DB0
		public TTable? Entity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060353BF RID: 218047 RVA: 0x00724BF4 File Offset: 0x00722DF4
		public IPlayerEntity EntityAsIPlayerEntity()
		{
			return this.Entity<IPlayerEntity>().Value;
		}

		// Token: 0x060353C0 RID: 218048 RVA: 0x00724C10 File Offset: 0x00722E10
		public ISelfEntity EntityAsISelfEntity()
		{
			return this.Entity<ISelfEntity>().Value;
		}

		// Token: 0x060353C1 RID: 218049 RVA: 0x00724C2C File Offset: 0x00722E2C
		public ITargetEntity EntityAsITargetEntity()
		{
			return this.Entity<ITargetEntity>().Value;
		}

		// Token: 0x060353C2 RID: 218050 RVA: 0x00724C48 File Offset: 0x00722E48
		public ITriggeredEntity EntityAsITriggeredEntity()
		{
			return this.Entity<ITriggeredEntity>().Value;
		}

		// Token: 0x060353C3 RID: 218051 RVA: 0x00724C64 File Offset: 0x00722E64
		public IVehicleEntity EntityAsIVehicleEntity()
		{
			return this.Entity<IVehicleEntity>().Value;
		}

		// Token: 0x060353C4 RID: 218052 RVA: 0x00724C7F File Offset: 0x00722E7F
		public static Offset<IRotatorEntity> CreateIRotatorEntity(FlatBufferBuilder builder, TTargetEntity Entity_type = TTargetEntity.NONE, int EntityOffset = 0)
		{
			builder.StartTable(2);
			IRotatorEntity.AddEntity(builder, EntityOffset);
			IRotatorEntity.AddEntityType(builder, Entity_type);
			return IRotatorEntity.EndIRotatorEntity(builder);
		}

		// Token: 0x060353C5 RID: 218053 RVA: 0x00724C9C File Offset: 0x00722E9C
		public static void StartIRotatorEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060353C6 RID: 218054 RVA: 0x00724CA5 File Offset: 0x00722EA5
		public static void AddEntityType(FlatBufferBuilder builder, TTargetEntity entityType)
		{
			builder.AddByte(0, (byte)entityType, 0);
		}

		// Token: 0x060353C7 RID: 218055 RVA: 0x00724CB0 File Offset: 0x00722EB0
		public static void AddEntity(FlatBufferBuilder builder, int entityOffset)
		{
			builder.AddOffset(1, entityOffset, 0);
		}

		// Token: 0x060353C8 RID: 218056 RVA: 0x00724CBB File Offset: 0x00722EBB
		public static Offset<IRotatorEntity> EndIRotatorEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorEntity>(builder.EndTable());
		}

		// Token: 0x060353C9 RID: 218057 RVA: 0x00724CC8 File Offset: 0x00722EC8
		public IRotatorEntityT UnPack()
		{
			IRotatorEntityT rotatorEntityT = new IRotatorEntityT();
			this.UnPackTo(rotatorEntityT);
			return rotatorEntityT;
		}

		// Token: 0x060353CA RID: 218058 RVA: 0x00724CE4 File Offset: 0x00722EE4
		public void UnPackTo(IRotatorEntityT _o)
		{
			_o.Entity = new TTargetEntityUnion();
			_o.Entity.Type = this.EntityType;
			switch (this.EntityType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Entity.Value = ((this.Entity<IPlayerEntity>() != null) ? this.Entity<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Entity.Value = ((this.Entity<ISelfEntity>() != null) ? this.Entity<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Entity.Value = ((this.Entity<ITargetEntity>() != null) ? this.Entity<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Entity.Value = ((this.Entity<ITriggeredEntity>() != null) ? this.Entity<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.Entity.Value = ((this.Entity<IVehicleEntity>() != null) ? this.Entity<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060353CB RID: 218059 RVA: 0x00724E44 File Offset: 0x00723044
		public static Offset<IRotatorEntity> Pack(FlatBufferBuilder builder, IRotatorEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRotatorEntity>);
			}
			TTargetEntity entity_type = (_o.Entity == null) ? TTargetEntity.NONE : _o.Entity.Type;
			int entityOffset = (_o.Entity == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Entity);
			return IRotatorEntity.CreateIRotatorEntity(builder, entity_type, entityOffset);
		}

		// Token: 0x0401287B RID: 75899
		private Table __p;
	}
}
