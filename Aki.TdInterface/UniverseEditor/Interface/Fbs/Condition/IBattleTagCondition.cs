using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E33 RID: 20019
	public struct IBattleTagCondition : IFlatbufferObject
	{
		// Token: 0x17008E95 RID: 36501
		// (get) Token: 0x0601EF49 RID: 126793 RVA: 0x00452E6A File Offset: 0x0045106A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF4A RID: 126794 RVA: 0x00452E77 File Offset: 0x00451077
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF4B RID: 126795 RVA: 0x00452E80 File Offset: 0x00451080
		public static IBattleTagCondition GetRootAsIBattleTagCondition(ByteBuffer _bb)
		{
			return IBattleTagCondition.GetRootAsIBattleTagCondition(_bb, default(IBattleTagCondition));
		}

		// Token: 0x0601EF4C RID: 126796 RVA: 0x00452E9C File Offset: 0x0045109C
		public static IBattleTagCondition GetRootAsIBattleTagCondition(ByteBuffer _bb, IBattleTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF4D RID: 126797 RVA: 0x00452EB9 File Offset: 0x004510B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF4E RID: 126798 RVA: 0x00452EC8 File Offset: 0x004510C8
		public IBattleTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E96 RID: 36502
		// (get) Token: 0x0601EF4F RID: 126799 RVA: 0x00452ED8 File Offset: 0x004510D8
		public EBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleConditionType.BattleTag;
				}
				return (EBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E97 RID: 36503
		// (get) Token: 0x0601EF50 RID: 126800 RVA: 0x00452F14 File Offset: 0x00451114
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

		// Token: 0x17008E98 RID: 36504
		// (get) Token: 0x0601EF51 RID: 126801 RVA: 0x00452F50 File Offset: 0x00451150
		public int TagConfigId
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

		// Token: 0x0601EF52 RID: 126802 RVA: 0x00452F8C File Offset: 0x0045118C
		public static Offset<IBattleTagCondition> CreateIBattleTagCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, int EntityId = 0, int TagConfigId = 0)
		{
			builder.StartTable(3);
			IBattleTagCondition.AddTagConfigId(builder, TagConfigId);
			IBattleTagCondition.AddEntityId(builder, EntityId);
			IBattleTagCondition.AddType(builder, Type);
			return IBattleTagCondition.EndIBattleTagCondition(builder);
		}

		// Token: 0x0601EF53 RID: 126803 RVA: 0x00452FB0 File Offset: 0x004511B0
		public static void StartIBattleTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EF54 RID: 126804 RVA: 0x00452FB9 File Offset: 0x004511B9
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF55 RID: 126805 RVA: 0x00452FC4 File Offset: 0x004511C4
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601EF56 RID: 126806 RVA: 0x00452FCF File Offset: 0x004511CF
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(2, tagConfigId, 0);
		}

		// Token: 0x0601EF57 RID: 126807 RVA: 0x00452FDA File Offset: 0x004511DA
		public static Offset<IBattleTagCondition> EndIBattleTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBattleTagCondition>(builder.EndTable());
		}

		// Token: 0x0601EF58 RID: 126808 RVA: 0x00452FE8 File Offset: 0x004511E8
		public IBattleTagConditionT UnPack()
		{
			IBattleTagConditionT battleTagConditionT = new IBattleTagConditionT();
			this.UnPackTo(battleTagConditionT);
			return battleTagConditionT;
		}

		// Token: 0x0601EF59 RID: 126809 RVA: 0x00453003 File Offset: 0x00451203
		public void UnPackTo(IBattleTagConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TagConfigId = this.TagConfigId;
		}

		// Token: 0x0601EF5A RID: 126810 RVA: 0x0045302C File Offset: 0x0045122C
		public static Offset<IBattleTagCondition> Pack(FlatBufferBuilder builder, IBattleTagConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleTagCondition>);
			}
			return IBattleTagCondition.CreateIBattleTagCondition(builder, _o.Type, _o.EntityId, _o.TagConfigId);
		}

		// Token: 0x0400DC4D RID: 56397
		private Table __p;
	}
}
