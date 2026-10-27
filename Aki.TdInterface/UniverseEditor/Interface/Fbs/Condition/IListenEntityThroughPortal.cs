using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C4F RID: 19535
	public struct IListenEntityThroughPortal : IFlatbufferObject
	{
		// Token: 0x17008DEF RID: 36335
		// (get) Token: 0x0601EF89 RID: 126857 RVA: 0x00455018 File Offset: 0x00453218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF8A RID: 126858 RVA: 0x00455025 File Offset: 0x00453225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF8B RID: 126859 RVA: 0x0045502C File Offset: 0x0045322C
		public static IListenEntityThroughPortal GetRootAsIListenEntityThroughPortal(ByteBuffer _bb)
		{
			return IListenEntityThroughPortal.GetRootAsIListenEntityThroughPortal(_bb, default(IListenEntityThroughPortal));
		}

		// Token: 0x0601EF8C RID: 126860 RVA: 0x00455048 File Offset: 0x00453248
		public static IListenEntityThroughPortal GetRootAsIListenEntityThroughPortal(ByteBuffer _bb, IListenEntityThroughPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF8D RID: 126861 RVA: 0x00455065 File Offset: 0x00453265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF8E RID: 126862 RVA: 0x00455074 File Offset: 0x00453274
		public IListenEntityThroughPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DF0 RID: 36336
		// (get) Token: 0x0601EF8F RID: 126863 RVA: 0x00455084 File Offset: 0x00453284
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DF1 RID: 36337
		// (get) Token: 0x0601EF90 RID: 126864 RVA: 0x004550C0 File Offset: 0x004532C0
		public TTargetEntity CheckTargetType
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

		// Token: 0x0601EF91 RID: 126865 RVA: 0x004550FC File Offset: 0x004532FC
		public TTable? CheckTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601EF92 RID: 126866 RVA: 0x00455140 File Offset: 0x00453340
		public IPlayerEntity CheckTargetAsIPlayerEntity()
		{
			return this.CheckTarget<IPlayerEntity>().Value;
		}

		// Token: 0x0601EF93 RID: 126867 RVA: 0x0045515C File Offset: 0x0045335C
		public ISelfEntity CheckTargetAsISelfEntity()
		{
			return this.CheckTarget<ISelfEntity>().Value;
		}

		// Token: 0x0601EF94 RID: 126868 RVA: 0x00455178 File Offset: 0x00453378
		public ITargetEntity CheckTargetAsITargetEntity()
		{
			return this.CheckTarget<ITargetEntity>().Value;
		}

		// Token: 0x0601EF95 RID: 126869 RVA: 0x00455194 File Offset: 0x00453394
		public ITriggeredEntity CheckTargetAsITriggeredEntity()
		{
			return this.CheckTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x17008DF2 RID: 36338
		// (get) Token: 0x0601EF96 RID: 126870 RVA: 0x004551B0 File Offset: 0x004533B0
		public int PortalEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF97 RID: 126871 RVA: 0x004551ED File Offset: 0x004533ED
		public static Offset<IListenEntityThroughPortal> CreateIListenEntityThroughPortal(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity CheckTarget_type = TTargetEntity.NONE, int CheckTargetOffset = 0, int PortalEntityId = 0)
		{
			builder.StartTable(4);
			IListenEntityThroughPortal.AddPortalEntityId(builder, PortalEntityId);
			IListenEntityThroughPortal.AddCheckTarget(builder, CheckTargetOffset);
			IListenEntityThroughPortal.AddCheckTargetType(builder, CheckTarget_type);
			IListenEntityThroughPortal.AddType(builder, Type);
			return IListenEntityThroughPortal.EndIListenEntityThroughPortal(builder);
		}

		// Token: 0x0601EF98 RID: 126872 RVA: 0x00455219 File Offset: 0x00453419
		public static void StartIListenEntityThroughPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EF99 RID: 126873 RVA: 0x00455222 File Offset: 0x00453422
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF9A RID: 126874 RVA: 0x0045522D File Offset: 0x0045342D
		public static void AddCheckTargetType(FlatBufferBuilder builder, TTargetEntity checkTargetType)
		{
			builder.AddByte(1, (byte)checkTargetType, 0);
		}

		// Token: 0x0601EF9B RID: 126875 RVA: 0x00455238 File Offset: 0x00453438
		public static void AddCheckTarget(FlatBufferBuilder builder, int checkTargetOffset)
		{
			builder.AddOffset(2, checkTargetOffset, 0);
		}

		// Token: 0x0601EF9C RID: 126876 RVA: 0x00455243 File Offset: 0x00453443
		public static void AddPortalEntityId(FlatBufferBuilder builder, int portalEntityId)
		{
			builder.AddInt(3, portalEntityId, 0);
		}

		// Token: 0x0601EF9D RID: 126877 RVA: 0x0045524E File Offset: 0x0045344E
		public static Offset<IListenEntityThroughPortal> EndIListenEntityThroughPortal(FlatBufferBuilder builder)
		{
			return new Offset<IListenEntityThroughPortal>(builder.EndTable());
		}

		// Token: 0x0601EF9E RID: 126878 RVA: 0x0045525C File Offset: 0x0045345C
		public IListenEntityThroughPortalT UnPack()
		{
			IListenEntityThroughPortalT listenEntityThroughPortalT = new IListenEntityThroughPortalT();
			this.UnPackTo(listenEntityThroughPortalT);
			return listenEntityThroughPortalT;
		}

		// Token: 0x0601EF9F RID: 126879 RVA: 0x00455278 File Offset: 0x00453478
		public void UnPackTo(IListenEntityThroughPortalT _o)
		{
			_o.Type = this.Type;
			_o.CheckTarget = new TTargetEntityUnion();
			_o.CheckTarget.Type = this.CheckTargetType;
			switch (this.CheckTargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.CheckTarget.Value = ((this.CheckTarget<IPlayerEntity>() != null) ? this.CheckTarget<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.CheckTarget.Value = ((this.CheckTarget<ISelfEntity>() != null) ? this.CheckTarget<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.CheckTarget.Value = ((this.CheckTarget<ITargetEntity>() != null) ? this.CheckTarget<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.CheckTarget.Value = ((this.CheckTarget<ITriggeredEntity>() != null) ? this.CheckTarget<ITriggeredEntity>().Value.UnPack() : null);
				break;
			}
			_o.PortalEntityId = this.PortalEntityId;
		}

		// Token: 0x0601EFA0 RID: 126880 RVA: 0x004553C0 File Offset: 0x004535C0
		public static Offset<IListenEntityThroughPortal> Pack(FlatBufferBuilder builder, IListenEntityThroughPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IListenEntityThroughPortal>);
			}
			TTargetEntity checkTarget_type = (_o.CheckTarget == null) ? TTargetEntity.NONE : _o.CheckTarget.Type;
			int checkTargetOffset = (_o.CheckTarget == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.CheckTarget);
			return IListenEntityThroughPortal.CreateIListenEntityThroughPortal(builder, _o.Type, checkTarget_type, checkTargetOffset, _o.PortalEntityId);
		}

		// Token: 0x0400D5F8 RID: 54776
		private Table __p;
	}
}
