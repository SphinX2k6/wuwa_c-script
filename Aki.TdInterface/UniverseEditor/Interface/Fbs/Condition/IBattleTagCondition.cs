using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200497C RID: 18812
	public struct IBattleTagCondition : IFlatbufferObject
	{
		// Token: 0x170087DA RID: 34778
		// (get) Token: 0x0601D524 RID: 120100 RVA: 0x004229B6 File Offset: 0x00420BB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D525 RID: 120101 RVA: 0x004229C3 File Offset: 0x00420BC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D526 RID: 120102 RVA: 0x004229CC File Offset: 0x00420BCC
		public static IBattleTagCondition GetRootAsIBattleTagCondition(ByteBuffer _bb)
		{
			return IBattleTagCondition.GetRootAsIBattleTagCondition(_bb, default(IBattleTagCondition));
		}

		// Token: 0x0601D527 RID: 120103 RVA: 0x004229E8 File Offset: 0x00420BE8
		public static IBattleTagCondition GetRootAsIBattleTagCondition(ByteBuffer _bb, IBattleTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D528 RID: 120104 RVA: 0x00422A05 File Offset: 0x00420C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D529 RID: 120105 RVA: 0x00422A14 File Offset: 0x00420C14
		public IBattleTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087DB RID: 34779
		// (get) Token: 0x0601D52A RID: 120106 RVA: 0x00422A24 File Offset: 0x00420C24
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

		// Token: 0x170087DC RID: 34780
		// (get) Token: 0x0601D52B RID: 120107 RVA: 0x00422A60 File Offset: 0x00420C60
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

		// Token: 0x170087DD RID: 34781
		// (get) Token: 0x0601D52C RID: 120108 RVA: 0x00422A9C File Offset: 0x00420C9C
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

		// Token: 0x0601D52D RID: 120109 RVA: 0x00422AD8 File Offset: 0x00420CD8
		public static Offset<IBattleTagCondition> CreateIBattleTagCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, int EntityId = 0, int TagConfigId = 0)
		{
			builder.StartTable(3);
			IBattleTagCondition.AddTagConfigId(builder, TagConfigId);
			IBattleTagCondition.AddEntityId(builder, EntityId);
			IBattleTagCondition.AddType(builder, Type);
			return IBattleTagCondition.EndIBattleTagCondition(builder);
		}

		// Token: 0x0601D52E RID: 120110 RVA: 0x00422AFC File Offset: 0x00420CFC
		public static void StartIBattleTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D52F RID: 120111 RVA: 0x00422B05 File Offset: 0x00420D05
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D530 RID: 120112 RVA: 0x00422B10 File Offset: 0x00420D10
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601D531 RID: 120113 RVA: 0x00422B1B File Offset: 0x00420D1B
		public static void AddTagConfigId(FlatBufferBuilder builder, int tagConfigId)
		{
			builder.AddInt(2, tagConfigId, 0);
		}

		// Token: 0x0601D532 RID: 120114 RVA: 0x00422B26 File Offset: 0x00420D26
		public static Offset<IBattleTagCondition> EndIBattleTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBattleTagCondition>(builder.EndTable());
		}

		// Token: 0x0601D533 RID: 120115 RVA: 0x00422B34 File Offset: 0x00420D34
		public IBattleTagConditionT UnPack()
		{
			IBattleTagConditionT battleTagConditionT = new IBattleTagConditionT();
			this.UnPackTo(battleTagConditionT);
			return battleTagConditionT;
		}

		// Token: 0x0601D534 RID: 120116 RVA: 0x00422B4F File Offset: 0x00420D4F
		public void UnPackTo(IBattleTagConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TagConfigId = this.TagConfigId;
		}

		// Token: 0x0601D535 RID: 120117 RVA: 0x00422B78 File Offset: 0x00420D78
		public static Offset<IBattleTagCondition> Pack(FlatBufferBuilder builder, IBattleTagConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBattleTagCondition>);
			}
			return IBattleTagCondition.CreateIBattleTagCondition(builder, _o.Type, _o.EntityId, _o.TagConfigId);
		}

		// Token: 0x0400D185 RID: 53637
		private Table __p;
	}
}
