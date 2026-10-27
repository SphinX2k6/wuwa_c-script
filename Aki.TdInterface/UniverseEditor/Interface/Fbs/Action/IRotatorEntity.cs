using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F03 RID: 28419
	public struct IRotatorEntity : IFlatbufferObject
	{
		// Token: 0x1700D356 RID: 54102
		// (get) Token: 0x0603235F RID: 205663 RVA: 0x006C8B9E File Offset: 0x006C6D9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032360 RID: 205664 RVA: 0x006C8BAB File Offset: 0x006C6DAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032361 RID: 205665 RVA: 0x006C8BB4 File Offset: 0x006C6DB4
		public static IRotatorEntity GetRootAsIRotatorEntity(ByteBuffer _bb)
		{
			return IRotatorEntity.GetRootAsIRotatorEntity(_bb, default(IRotatorEntity));
		}

		// Token: 0x06032362 RID: 205666 RVA: 0x006C8BD0 File Offset: 0x006C6DD0
		public static IRotatorEntity GetRootAsIRotatorEntity(ByteBuffer _bb, IRotatorEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032363 RID: 205667 RVA: 0x006C8BED File Offset: 0x006C6DED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032364 RID: 205668 RVA: 0x006C8BFC File Offset: 0x006C6DFC
		public IRotatorEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D357 RID: 54103
		// (get) Token: 0x06032365 RID: 205669 RVA: 0x006C8C0C File Offset: 0x006C6E0C
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

		// Token: 0x06032366 RID: 205670 RVA: 0x006C8C48 File Offset: 0x006C6E48
		public TTable? Entity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032367 RID: 205671 RVA: 0x006C8C8C File Offset: 0x006C6E8C
		public IPlayerEntity EntityAsIPlayerEntity()
		{
			return this.Entity<IPlayerEntity>().Value;
		}

		// Token: 0x06032368 RID: 205672 RVA: 0x006C8CA8 File Offset: 0x006C6EA8
		public ISelfEntity EntityAsISelfEntity()
		{
			return this.Entity<ISelfEntity>().Value;
		}

		// Token: 0x06032369 RID: 205673 RVA: 0x006C8CC4 File Offset: 0x006C6EC4
		public ITargetEntity EntityAsITargetEntity()
		{
			return this.Entity<ITargetEntity>().Value;
		}

		// Token: 0x0603236A RID: 205674 RVA: 0x006C8CE0 File Offset: 0x006C6EE0
		public ITriggeredEntity EntityAsITriggeredEntity()
		{
			return this.Entity<ITriggeredEntity>().Value;
		}

		// Token: 0x0603236B RID: 205675 RVA: 0x006C8CFC File Offset: 0x006C6EFC
		public IVehicleEntity EntityAsIVehicleEntity()
		{
			return this.Entity<IVehicleEntity>().Value;
		}

		// Token: 0x0603236C RID: 205676 RVA: 0x006C8D17 File Offset: 0x006C6F17
		public static Offset<IRotatorEntity> CreateIRotatorEntity(FlatBufferBuilder builder, TTargetEntity Entity_type = TTargetEntity.NONE, int EntityOffset = 0)
		{
			builder.StartTable(2);
			IRotatorEntity.AddEntity(builder, EntityOffset);
			IRotatorEntity.AddEntityType(builder, Entity_type);
			return IRotatorEntity.EndIRotatorEntity(builder);
		}

		// Token: 0x0603236D RID: 205677 RVA: 0x006C8D34 File Offset: 0x006C6F34
		public static void StartIRotatorEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603236E RID: 205678 RVA: 0x006C8D3D File Offset: 0x006C6F3D
		public static void AddEntityType(FlatBufferBuilder builder, TTargetEntity entityType)
		{
			builder.AddByte(0, (byte)entityType, 0);
		}

		// Token: 0x0603236F RID: 205679 RVA: 0x006C8D48 File Offset: 0x006C6F48
		public static void AddEntity(FlatBufferBuilder builder, int entityOffset)
		{
			builder.AddOffset(1, entityOffset, 0);
		}

		// Token: 0x06032370 RID: 205680 RVA: 0x006C8D53 File Offset: 0x006C6F53
		public static Offset<IRotatorEntity> EndIRotatorEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorEntity>(builder.EndTable());
		}

		// Token: 0x06032371 RID: 205681 RVA: 0x006C8D60 File Offset: 0x006C6F60
		public IRotatorEntityT UnPack()
		{
			IRotatorEntityT rotatorEntityT = new IRotatorEntityT();
			this.UnPackTo(rotatorEntityT);
			return rotatorEntityT;
		}

		// Token: 0x06032372 RID: 205682 RVA: 0x006C8D7C File Offset: 0x006C6F7C
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

		// Token: 0x06032373 RID: 205683 RVA: 0x006C8EDC File Offset: 0x006C70DC
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

		// Token: 0x040118F3 RID: 71923
		private Table __p;
	}
}
