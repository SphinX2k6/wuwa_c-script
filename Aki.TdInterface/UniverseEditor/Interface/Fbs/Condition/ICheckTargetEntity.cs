using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005034 RID: 20532
	public struct ICheckTargetEntity : IFlatbufferObject
	{
		// Token: 0x170092E7 RID: 37607
		// (get) Token: 0x06020135 RID: 131381 RVA: 0x0047337F File Offset: 0x0047157F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020136 RID: 131382 RVA: 0x0047338C File Offset: 0x0047158C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020137 RID: 131383 RVA: 0x00473394 File Offset: 0x00471594
		public static ICheckTargetEntity GetRootAsICheckTargetEntity(ByteBuffer _bb)
		{
			return ICheckTargetEntity.GetRootAsICheckTargetEntity(_bb, default(ICheckTargetEntity));
		}

		// Token: 0x06020138 RID: 131384 RVA: 0x004733B0 File Offset: 0x004715B0
		public static ICheckTargetEntity GetRootAsICheckTargetEntity(ByteBuffer _bb, ICheckTargetEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020139 RID: 131385 RVA: 0x004733CD File Offset: 0x004715CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602013A RID: 131386 RVA: 0x004733DC File Offset: 0x004715DC
		public ICheckTargetEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092E8 RID: 37608
		// (get) Token: 0x0602013B RID: 131387 RVA: 0x004733EC File Offset: 0x004715EC
		public ECheckEntity Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEntity.OnlinePlayer;
				}
				return (ECheckEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170092E9 RID: 37609
		// (get) Token: 0x0602013C RID: 131388 RVA: 0x00473428 File Offset: 0x00471628
		public TTargetEntity TargetEntityType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602013D RID: 131389 RVA: 0x00473464 File Offset: 0x00471664
		public TTable? TargetEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602013E RID: 131390 RVA: 0x004734A8 File Offset: 0x004716A8
		public IPlayerEntity TargetEntityAsIPlayerEntity()
		{
			return this.TargetEntity<IPlayerEntity>().Value;
		}

		// Token: 0x0602013F RID: 131391 RVA: 0x004734C4 File Offset: 0x004716C4
		public ISelfEntity TargetEntityAsISelfEntity()
		{
			return this.TargetEntity<ISelfEntity>().Value;
		}

		// Token: 0x06020140 RID: 131392 RVA: 0x004734E0 File Offset: 0x004716E0
		public ITargetEntity TargetEntityAsITargetEntity()
		{
			return this.TargetEntity<ITargetEntity>().Value;
		}

		// Token: 0x06020141 RID: 131393 RVA: 0x004734FC File Offset: 0x004716FC
		public ITriggeredEntity TargetEntityAsITriggeredEntity()
		{
			return this.TargetEntity<ITriggeredEntity>().Value;
		}

		// Token: 0x06020142 RID: 131394 RVA: 0x00473517 File Offset: 0x00471717
		public static Offset<ICheckTargetEntity> CreateICheckTargetEntity(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer, TTargetEntity TargetEntity_type = TTargetEntity.NONE, int TargetEntityOffset = 0)
		{
			builder.StartTable(3);
			ICheckTargetEntity.AddTargetEntity(builder, TargetEntityOffset);
			ICheckTargetEntity.AddTargetEntityType(builder, TargetEntity_type);
			ICheckTargetEntity.AddType(builder, Type);
			return ICheckTargetEntity.EndICheckTargetEntity(builder);
		}

		// Token: 0x06020143 RID: 131395 RVA: 0x0047353B File Offset: 0x0047173B
		public static void StartICheckTargetEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020144 RID: 131396 RVA: 0x00473544 File Offset: 0x00471744
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020145 RID: 131397 RVA: 0x0047354F File Offset: 0x0047174F
		public static void AddTargetEntityType(FlatBufferBuilder builder, TTargetEntity targetEntityType)
		{
			builder.AddByte(1, (byte)targetEntityType, 0);
		}

		// Token: 0x06020146 RID: 131398 RVA: 0x0047355A File Offset: 0x0047175A
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntityOffset)
		{
			builder.AddOffset(2, targetEntityOffset, 0);
		}

		// Token: 0x06020147 RID: 131399 RVA: 0x00473565 File Offset: 0x00471765
		public static Offset<ICheckTargetEntity> EndICheckTargetEntity(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTargetEntity>(builder.EndTable());
		}

		// Token: 0x06020148 RID: 131400 RVA: 0x00473574 File Offset: 0x00471774
		public ICheckTargetEntityT UnPack()
		{
			ICheckTargetEntityT checkTargetEntityT = new ICheckTargetEntityT();
			this.UnPackTo(checkTargetEntityT);
			return checkTargetEntityT;
		}

		// Token: 0x06020149 RID: 131401 RVA: 0x00473590 File Offset: 0x00471790
		public void UnPackTo(ICheckTargetEntityT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntity = new TTargetEntityUnion();
			_o.TargetEntity.Type = this.TargetEntityType;
			switch (this.TargetEntityType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<IPlayerEntity>() != null) ? this.TargetEntity<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ISelfEntity>() != null) ? this.TargetEntity<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ITargetEntity>() != null) ? this.TargetEntity<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.TargetEntity.Value = ((this.TargetEntity<ITriggeredEntity>() != null) ? this.TargetEntity<ITriggeredEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602014A RID: 131402 RVA: 0x004736C0 File Offset: 0x004718C0
		public static Offset<ICheckTargetEntity> Pack(FlatBufferBuilder builder, ICheckTargetEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTargetEntity>);
			}
			TTargetEntity targetEntity_type = (_o.TargetEntity == null) ? TTargetEntity.NONE : _o.TargetEntity.Type;
			int targetEntityOffset = (_o.TargetEntity == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.TargetEntity);
			return ICheckTargetEntity.CreateICheckTargetEntity(builder, _o.Type, targetEntity_type, targetEntityOffset);
		}

		// Token: 0x0400DF09 RID: 57097
		private Table __p;
	}
}
