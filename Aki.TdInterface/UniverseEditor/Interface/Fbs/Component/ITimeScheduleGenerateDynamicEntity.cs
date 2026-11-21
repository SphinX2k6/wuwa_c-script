using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AC RID: 24748
	public struct ITimeScheduleGenerateDynamicEntity : IFlatbufferObject
	{
		// Token: 0x1700B801 RID: 47105
		// (get) Token: 0x06029E02 RID: 171522 RVA: 0x005B7744 File Offset: 0x005B5944
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E03 RID: 171523 RVA: 0x005B7751 File Offset: 0x005B5951
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E04 RID: 171524 RVA: 0x005B7758 File Offset: 0x005B5958
		public static ITimeScheduleGenerateDynamicEntity GetRootAsITimeScheduleGenerateDynamicEntity(ByteBuffer _bb)
		{
			return ITimeScheduleGenerateDynamicEntity.GetRootAsITimeScheduleGenerateDynamicEntity(_bb, default(ITimeScheduleGenerateDynamicEntity));
		}

		// Token: 0x06029E05 RID: 171525 RVA: 0x005B7774 File Offset: 0x005B5974
		public static ITimeScheduleGenerateDynamicEntity GetRootAsITimeScheduleGenerateDynamicEntity(ByteBuffer _bb, ITimeScheduleGenerateDynamicEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E06 RID: 171526 RVA: 0x005B7791 File Offset: 0x005B5991
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E07 RID: 171527 RVA: 0x005B77A0 File Offset: 0x005B59A0
		public ITimeScheduleGenerateDynamicEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B802 RID: 47106
		// (get) Token: 0x06029E08 RID: 171528 RVA: 0x005B77B0 File Offset: 0x005B59B0
		public ITimeScheduleFixedIntervalRefresh? GenerateParams
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleFixedIntervalRefresh?(default(ITimeScheduleFixedIntervalRefresh).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B803 RID: 47107
		// (get) Token: 0x06029E09 RID: 171529 RVA: 0x005B7810 File Offset: 0x005B5A10
		public ITimeScheduleEntityTemplateNpcSource? NpcSource
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleEntityTemplateNpcSource?(default(ITimeScheduleEntityTemplateNpcSource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B804 RID: 47108
		// (get) Token: 0x06029E0A RID: 171530 RVA: 0x005B7870 File Offset: 0x005B5A70
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029E0B RID: 171531 RVA: 0x005B78CD File Offset: 0x005B5ACD
		public static Offset<ITimeScheduleGenerateDynamicEntity> CreateITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder, Offset<ITimeScheduleFixedIntervalRefresh> GenerateParamsOffset = default(Offset<ITimeScheduleFixedIntervalRefresh>), Offset<ITimeScheduleEntityTemplateNpcSource> NpcSourceOffset = default(Offset<ITimeScheduleEntityTemplateNpcSource>), Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ITimeScheduleGenerateDynamicEntity.AddConditions(builder, ConditionsOffset);
			ITimeScheduleGenerateDynamicEntity.AddNpcSource(builder, NpcSourceOffset);
			ITimeScheduleGenerateDynamicEntity.AddGenerateParams(builder, GenerateParamsOffset);
			return ITimeScheduleGenerateDynamicEntity.EndITimeScheduleGenerateDynamicEntity(builder);
		}

		// Token: 0x06029E0C RID: 171532 RVA: 0x005B78F1 File Offset: 0x005B5AF1
		public static void StartITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029E0D RID: 171533 RVA: 0x005B78FA File Offset: 0x005B5AFA
		public static void AddGenerateParams(FlatBufferBuilder builder, Offset<ITimeScheduleFixedIntervalRefresh> generateParamsOffset)
		{
			builder.AddOffset(0, generateParamsOffset.Value, 0);
		}

		// Token: 0x06029E0E RID: 171534 RVA: 0x005B790A File Offset: 0x005B5B0A
		public static void AddNpcSource(FlatBufferBuilder builder, Offset<ITimeScheduleEntityTemplateNpcSource> npcSourceOffset)
		{
			builder.AddOffset(1, npcSourceOffset.Value, 0);
		}

		// Token: 0x06029E0F RID: 171535 RVA: 0x005B791A File Offset: 0x005B5B1A
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06029E10 RID: 171536 RVA: 0x005B792A File Offset: 0x005B5B2A
		public static Offset<ITimeScheduleGenerateDynamicEntity> EndITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleGenerateDynamicEntity>(builder.EndTable());
		}

		// Token: 0x06029E11 RID: 171537 RVA: 0x005B7938 File Offset: 0x005B5B38
		public ITimeScheduleGenerateDynamicEntityT UnPack()
		{
			ITimeScheduleGenerateDynamicEntityT timeScheduleGenerateDynamicEntityT = new ITimeScheduleGenerateDynamicEntityT();
			this.UnPackTo(timeScheduleGenerateDynamicEntityT);
			return timeScheduleGenerateDynamicEntityT;
		}

		// Token: 0x06029E12 RID: 171538 RVA: 0x005B7954 File Offset: 0x005B5B54
		public void UnPackTo(ITimeScheduleGenerateDynamicEntityT _o)
		{
			_o.GenerateParams = ((this.GenerateParams != null) ? this.GenerateParams.Value.UnPack() : null);
			_o.NpcSource = ((this.NpcSource != null) ? this.NpcSource.Value.UnPack() : null);
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
		}

		// Token: 0x06029E13 RID: 171539 RVA: 0x005B79F4 File Offset: 0x005B5BF4
		public static Offset<ITimeScheduleGenerateDynamicEntity> Pack(FlatBufferBuilder builder, ITimeScheduleGenerateDynamicEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleGenerateDynamicEntity>);
			}
			Offset<ITimeScheduleFixedIntervalRefresh> generateParamsOffset = (_o.GenerateParams == null) ? default(Offset<ITimeScheduleFixedIntervalRefresh>) : ITimeScheduleFixedIntervalRefresh.Pack(builder, _o.GenerateParams);
			Offset<ITimeScheduleEntityTemplateNpcSource> npcSourceOffset = (_o.NpcSource == null) ? default(Offset<ITimeScheduleEntityTemplateNpcSource>) : ITimeScheduleEntityTemplateNpcSource.Pack(builder, _o.NpcSource);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return ITimeScheduleGenerateDynamicEntity.CreateITimeScheduleGenerateDynamicEntity(builder, generateParamsOffset, npcSourceOffset, conditionsOffset);
		}

		// Token: 0x0400FE57 RID: 65111
		private Table __p;
	}
}
