using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DBE RID: 15806
	public struct ICrossSceneSyncKillMonster : IFlatbufferObject
	{
		// Token: 0x17006D1A RID: 27930
		// (get) Token: 0x060160D3 RID: 90323 RVA: 0x003306A7 File Offset: 0x0032E8A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060160D4 RID: 90324 RVA: 0x003306B4 File Offset: 0x0032E8B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060160D5 RID: 90325 RVA: 0x003306BC File Offset: 0x0032E8BC
		public static ICrossSceneSyncKillMonster GetRootAsICrossSceneSyncKillMonster(ByteBuffer _bb)
		{
			return ICrossSceneSyncKillMonster.GetRootAsICrossSceneSyncKillMonster(_bb, default(ICrossSceneSyncKillMonster));
		}

		// Token: 0x060160D6 RID: 90326 RVA: 0x003306D8 File Offset: 0x0032E8D8
		public static ICrossSceneSyncKillMonster GetRootAsICrossSceneSyncKillMonster(ByteBuffer _bb, ICrossSceneSyncKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060160D7 RID: 90327 RVA: 0x003306F5 File Offset: 0x0032E8F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060160D8 RID: 90328 RVA: 0x00330704 File Offset: 0x0032E904
		public ICrossSceneSyncKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D1B RID: 27931
		// (get) Token: 0x060160D9 RID: 90329 RVA: 0x00330714 File Offset: 0x0032E914
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

		// Token: 0x17006D1C RID: 27932
		// (get) Token: 0x060160DA RID: 90330 RVA: 0x00330750 File Offset: 0x0032E950
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

		// Token: 0x17006D1D RID: 27933
		// (get) Token: 0x060160DB RID: 90331 RVA: 0x003307B0 File Offset: 0x0032E9B0
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

		// Token: 0x17006D1E RID: 27934
		// (get) Token: 0x060160DC RID: 90332 RVA: 0x003307EC File Offset: 0x0032E9EC
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

		// Token: 0x060160DD RID: 90333 RVA: 0x00330829 File Offset: 0x0032EA29
		public static Offset<ICrossSceneSyncKillMonster> CreateICrossSceneSyncKillMonster(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityBundleId = 0, int PosEntityId = 0)
		{
			builder.StartTable(4);
			ICrossSceneSyncKillMonster.AddPosEntityId(builder, PosEntityId);
			ICrossSceneSyncKillMonster.AddEntityBundleId(builder, EntityBundleId);
			ICrossSceneSyncKillMonster.AddPreConditions(builder, PreConditionsOffset);
			ICrossSceneSyncKillMonster.AddType(builder, Type);
			return ICrossSceneSyncKillMonster.EndICrossSceneSyncKillMonster(builder);
		}

		// Token: 0x060160DE RID: 90334 RVA: 0x00330855 File Offset: 0x0032EA55
		public static void StartICrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060160DF RID: 90335 RVA: 0x0033085E File Offset: 0x0032EA5E
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060160E0 RID: 90336 RVA: 0x00330869 File Offset: 0x0032EA69
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060160E1 RID: 90337 RVA: 0x00330879 File Offset: 0x0032EA79
		public static void AddEntityBundleId(FlatBufferBuilder builder, int entityBundleId)
		{
			builder.AddInt(2, entityBundleId, 0);
		}

		// Token: 0x060160E2 RID: 90338 RVA: 0x00330884 File Offset: 0x0032EA84
		public static void AddPosEntityId(FlatBufferBuilder builder, int posEntityId)
		{
			builder.AddInt(3, posEntityId, 0);
		}

		// Token: 0x060160E3 RID: 90339 RVA: 0x0033088F File Offset: 0x0032EA8F
		public static Offset<ICrossSceneSyncKillMonster> EndICrossSceneSyncKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<ICrossSceneSyncKillMonster>(builder.EndTable());
		}

		// Token: 0x060160E4 RID: 90340 RVA: 0x0033089C File Offset: 0x0032EA9C
		public ICrossSceneSyncKillMonsterT UnPack()
		{
			ICrossSceneSyncKillMonsterT crossSceneSyncKillMonsterT = new ICrossSceneSyncKillMonsterT();
			this.UnPackTo(crossSceneSyncKillMonsterT);
			return crossSceneSyncKillMonsterT;
		}

		// Token: 0x060160E5 RID: 90341 RVA: 0x003308B8 File Offset: 0x0032EAB8
		public void UnPackTo(ICrossSceneSyncKillMonsterT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityBundleId = this.EntityBundleId;
			_o.PosEntityId = this.PosEntityId;
		}

		// Token: 0x060160E6 RID: 90342 RVA: 0x00330918 File Offset: 0x0032EB18
		public static Offset<ICrossSceneSyncKillMonster> Pack(FlatBufferBuilder builder, ICrossSceneSyncKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICrossSceneSyncKillMonster>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ICrossSceneSyncKillMonster.CreateICrossSceneSyncKillMonster(builder, _o.Type, preConditionsOffset, _o.EntityBundleId, _o.PosEntityId);
		}

		// Token: 0x0400B6FE RID: 46846
		private Table __p;
	}
}
