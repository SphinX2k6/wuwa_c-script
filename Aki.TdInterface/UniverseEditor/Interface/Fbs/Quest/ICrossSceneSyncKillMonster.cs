using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D5 RID: 16853
	public struct ICrossSceneSyncKillMonster : IFlatbufferObject
	{
		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x0601760C RID: 95756 RVA: 0x00357A2F File Offset: 0x00355C2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601760D RID: 95757 RVA: 0x00357A3C File Offset: 0x00355C3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601760E RID: 95758 RVA: 0x00357A44 File Offset: 0x00355C44
		public static ICrossSceneSyncKillMonster GetRootAsICrossSceneSyncKillMonster(ByteBuffer _bb)
		{
			return ICrossSceneSyncKillMonster.GetRootAsICrossSceneSyncKillMonster(_bb, default(ICrossSceneSyncKillMonster));
		}

		// Token: 0x0601760F RID: 95759 RVA: 0x00357A60 File Offset: 0x00355C60
		public static ICrossSceneSyncKillMonster GetRootAsICrossSceneSyncKillMonster(ByteBuffer _bb, ICrossSceneSyncKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017610 RID: 95760 RVA: 0x00357A7D File Offset: 0x00355C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017611 RID: 95761 RVA: 0x00357A8C File Offset: 0x00355C8C
		public ICrossSceneSyncKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x06017612 RID: 95762 RVA: 0x00357A9C File Offset: 0x00355C9C
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x06017613 RID: 95763 RVA: 0x00357AD8 File Offset: 0x00355CD8
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x06017614 RID: 95764 RVA: 0x00357B38 File Offset: 0x00355D38
		public int EntityBundleId
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

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x06017615 RID: 95765 RVA: 0x00357B74 File Offset: 0x00355D74
		public int PosEntityId
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

		// Token: 0x06017616 RID: 95766 RVA: 0x00357BB1 File Offset: 0x00355DB1
		public static Offset<ICrossSceneSyncKillMonster> CreateICrossSceneSyncKillMonster(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityBundleId = 0, int PosEntityId = 0)
		{
			builder.StartTable(4);
			ICrossSceneSyncKillMonster.AddPosEntityId(builder, PosEntityId);
			ICrossSceneSyncKillMonster.AddEntityBundleId(builder, EntityBundleId);
			ICrossSceneSyncKillMonster.AddPreConditions(builder, PreConditionsOffset);
			ICrossSceneSyncKillMonster.AddType(builder, Type);
			return ICrossSceneSyncKillMonster.EndICrossSceneSyncKillMonster(builder);
		}

		// Token: 0x06017617 RID: 95767 RVA: 0x00357BDD File Offset: 0x00355DDD
		public static void StartICrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017618 RID: 95768 RVA: 0x00357BE6 File Offset: 0x00355DE6
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017619 RID: 95769 RVA: 0x00357BF1 File Offset: 0x00355DF1
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601761A RID: 95770 RVA: 0x00357C01 File Offset: 0x00355E01
		public static void AddEntityBundleId(FlatBufferBuilder builder, int entityBundleId)
		{
			builder.AddInt(2, entityBundleId, 0);
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x00357C0C File Offset: 0x00355E0C
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(3, posEntityId, 0);
		}

		// Token: 0x0601761C RID: 95772 RVA: 0x00357C17 File Offset: 0x00355E17
		public static Offset<ICrossSceneSyncKillMonster> EndICrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<ICrossSceneSyncKillMonster>(builder.EndTable());
		}

		// Token: 0x0601761D RID: 95773 RVA: 0x00357C24 File Offset: 0x00355E24
		public ICrossSceneSyncKillMonsterT UnPack()
		{
			ICrossSceneSyncKillMonsterT crossSceneSyncKillMonsterT = new ICrossSceneSyncKillMonsterT();
			this.UnPackTo(crossSceneSyncKillMonsterT);
			return crossSceneSyncKillMonsterT;
		}

		// Token: 0x0601761E RID: 95774 RVA: 0x00357C40 File Offset: 0x00355E40
		public void UnPackTo(ICrossSceneSyncKillMonsterT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityBundleId = this.EntityBundleId;
			_o.PosEntityId = this.PosEntityId;
		}

		// Token: 0x0601761F RID: 95775 RVA: 0x00357CA0 File Offset: 0x00355EA0
		public static Offset<ICrossSceneSyncKillMonster> Pack(FlatBufferBuilder builder, ICrossSceneSyncKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICrossSceneSyncKillMonster>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ICrossSceneSyncKillMonster.CreateICrossSceneSyncKillMonster(builder, _o.Type, preConditionsOffset, _o.EntityBundleId, _o.PosEntityId);
		}

		// Token: 0x0400C0AB RID: 49323
		private Table __p;
	}
}
