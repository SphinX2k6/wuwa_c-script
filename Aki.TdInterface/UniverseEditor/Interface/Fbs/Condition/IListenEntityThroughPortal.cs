using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005142 RID: 20802
	public struct IListenEntityThroughPortal : IFlatbufferObject
	{
		// Token: 0x17009518 RID: 38168
		// (get) Token: 0x06020B8D RID: 134029 RVA: 0x004888F4 File Offset: 0x00486AF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B8E RID: 134030 RVA: 0x00488901 File Offset: 0x00486B01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B8F RID: 134031 RVA: 0x00488908 File Offset: 0x00486B08
		public static IListenEntityThroughPortal GetRootAsIListenEntityThroughPortal(ByteBuffer _bb)
		{
			return IListenEntityThroughPortal.GetRootAsIListenEntityThroughPortal(_bb, default(IListenEntityThroughPortal));
		}

		// Token: 0x06020B90 RID: 134032 RVA: 0x00488924 File Offset: 0x00486B24
		public static IListenEntityThroughPortal GetRootAsIListenEntityThroughPortal(ByteBuffer _bb, IListenEntityThroughPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B91 RID: 134033 RVA: 0x00488941 File Offset: 0x00486B41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B92 RID: 134034 RVA: 0x00488950 File Offset: 0x00486B50
		public IListenEntityThroughPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009519 RID: 38169
		// (get) Token: 0x06020B93 RID: 134035 RVA: 0x00488960 File Offset: 0x00486B60
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

		// Token: 0x1700951A RID: 38170
		// (get) Token: 0x06020B94 RID: 134036 RVA: 0x0048899C File Offset: 0x00486B9C
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

		// Token: 0x06020B95 RID: 134037 RVA: 0x004889D8 File Offset: 0x00486BD8
		public TTable? CheckTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020B96 RID: 134038 RVA: 0x00488A1C File Offset: 0x00486C1C
		public IPlayerEntity CheckTargetAsIPlayerEntity()
		{
			return this.CheckTarget<IPlayerEntity>().Value;
		}

		// Token: 0x06020B97 RID: 134039 RVA: 0x00488A38 File Offset: 0x00486C38
		public ISelfEntity CheckTargetAsISelfEntity()
		{
			return this.CheckTarget<ISelfEntity>().Value;
		}

		// Token: 0x06020B98 RID: 134040 RVA: 0x00488A54 File Offset: 0x00486C54
		public ITargetEntity CheckTargetAsITargetEntity()
		{
			return this.CheckTarget<ITargetEntity>().Value;
		}

		// Token: 0x06020B99 RID: 134041 RVA: 0x00488A70 File Offset: 0x00486C70
		public ITriggeredEntity CheckTargetAsITriggeredEntity()
		{
			return this.CheckTarget<ITriggeredEntity>().Value;
		}

		// Token: 0x1700951B RID: 38171
		// (get) Token: 0x06020B9A RID: 134042 RVA: 0x00488A8C File Offset: 0x00486C8C
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

		// Token: 0x06020B9B RID: 134043 RVA: 0x00488AC9 File Offset: 0x00486CC9
		public static Offset<IListenEntityThroughPortal> CreateIListenEntityThroughPortal(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, TTargetEntity CheckTarget_type = TTargetEntity.NONE, int CheckTargetOffset = 0, int PortalEntityId = 0)
		{
			builder.StartTable(4);
			IListenEntityThroughPortal.AddPortalEntityId(builder, PortalEntityId);
			IListenEntityThroughPortal.AddCheckTarget(builder, CheckTargetOffset);
			IListenEntityThroughPortal.AddCheckTargetType(builder, CheckTarget_type);
			IListenEntityThroughPortal.AddType(builder, Type);
			return IListenEntityThroughPortal.EndIListenEntityThroughPortal(builder);
		}

		// Token: 0x06020B9C RID: 134044 RVA: 0x00488AF5 File Offset: 0x00486CF5
		public static void StartIListenEntityThroughPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020B9D RID: 134045 RVA: 0x00488AFE File Offset: 0x00486CFE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020B9E RID: 134046 RVA: 0x00488B09 File Offset: 0x00486D09
		public static void AddCheckTargetType(FlatBufferBuilder builder, TTargetEntity checkTargetType)
		{
			builder.AddByte(1, (byte)checkTargetType, 0);
		}

		// Token: 0x06020B9F RID: 134047 RVA: 0x00488B14 File Offset: 0x00486D14
		public static void AddCheckTarget(FlatBufferBuilder builder, int checkTargetOffset)
		{
			builder.AddOffset(2, checkTargetOffset, 0);
		}

		// Token: 0x06020BA0 RID: 134048 RVA: 0x00488B1F File Offset: 0x00486D1F
		public static void AddPortalEntityId(FlatBufferBuilder builder, int portalEntityId)
		{
			builder.AddInt(3, portalEntityId, 0);
		}

		// Token: 0x06020BA1 RID: 134049 RVA: 0x00488B2A File Offset: 0x00486D2A
		public static Offset<IListenEntityThroughPortal> EndIListenEntityThroughPortal(FlatBufferBuilder builder)
		{
			return new Offset<IListenEntityThroughPortal>(builder.EndTable());
		}

		// Token: 0x06020BA2 RID: 134050 RVA: 0x00488B38 File Offset: 0x00486D38
		public IListenEntityThroughPortalT UnPack()
		{
			IListenEntityThroughPortalT listenEntityThroughPortalT = new IListenEntityThroughPortalT();
			this.UnPackTo(listenEntityThroughPortalT);
			return listenEntityThroughPortalT;
		}

		// Token: 0x06020BA3 RID: 134051 RVA: 0x00488B54 File Offset: 0x00486D54
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

		// Token: 0x06020BA4 RID: 134052 RVA: 0x00488C9C File Offset: 0x00486E9C
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

		// Token: 0x0400E117 RID: 57623
		private Table __p;
	}
}
