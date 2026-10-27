using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA2 RID: 23202
	public struct ITimeScheduleGenerateDynamicEntity : IFlatbufferObject
	{
		// Token: 0x1700AEC3 RID: 44739
		// (get) Token: 0x06027880 RID: 161920 RVA: 0x00570355 File Offset: 0x0056E555
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027881 RID: 161921 RVA: 0x00570362 File Offset: 0x0056E562
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027882 RID: 161922 RVA: 0x0057036C File Offset: 0x0056E56C
		public static ITimeScheduleGenerateDynamicEntity GetRootAsITimeScheduleGenerateDynamicEntity(ByteBuffer _bb)
		{
			return ITimeScheduleGenerateDynamicEntity.GetRootAsITimeScheduleGenerateDynamicEntity(_bb, default(ITimeScheduleGenerateDynamicEntity));
		}

		// Token: 0x06027883 RID: 161923 RVA: 0x00570388 File Offset: 0x0056E588
		public static ITimeScheduleGenerateDynamicEntity GetRootAsITimeScheduleGenerateDynamicEntity(ByteBuffer _bb, ITimeScheduleGenerateDynamicEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027884 RID: 161924 RVA: 0x005703A5 File Offset: 0x0056E5A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027885 RID: 161925 RVA: 0x005703B4 File Offset: 0x0056E5B4
		public ITimeScheduleGenerateDynamicEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEC4 RID: 44740
		// (get) Token: 0x06027886 RID: 161926 RVA: 0x005703C4 File Offset: 0x0056E5C4
		public ITimeScheduleGenerateParams? GenerateParams
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleGenerateParams?(default(ITimeScheduleGenerateParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AEC5 RID: 44741
		// (get) Token: 0x06027887 RID: 161927 RVA: 0x00570424 File Offset: 0x0056E624
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

		// Token: 0x1700AEC6 RID: 44742
		// (get) Token: 0x06027888 RID: 161928 RVA: 0x00570484 File Offset: 0x0056E684
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

		// Token: 0x06027889 RID: 161929 RVA: 0x005704E1 File Offset: 0x0056E6E1
		public static Offset<ITimeScheduleGenerateDynamicEntity> CreateITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder, Offset<ITimeScheduleGenerateParams> GenerateParamsOffset = default(Offset<ITimeScheduleGenerateParams>), Offset<ITimeScheduleEntityTemplateNpcSource> NpcSourceOffset = default(Offset<ITimeScheduleEntityTemplateNpcSource>), Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ITimeScheduleGenerateDynamicEntity.AddConditions(builder, ConditionsOffset);
			ITimeScheduleGenerateDynamicEntity.AddNpcSource(builder, NpcSourceOffset);
			ITimeScheduleGenerateDynamicEntity.AddGenerateParams(builder, GenerateParamsOffset);
			return ITimeScheduleGenerateDynamicEntity.EndITimeScheduleGenerateDynamicEntity(builder);
		}

		// Token: 0x0602788A RID: 161930 RVA: 0x00570505 File Offset: 0x0056E705
		public static void StartITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602788B RID: 161931 RVA: 0x0057050E File Offset: 0x0056E70E
		public static void AddGenerateParams(FlatBufferBuilder builder, Offset<ITimeScheduleGenerateParams> generateParamsOffset)
		{
			builder.AddOffset(0, generateParamsOffset.Value, 0);
		}

		// Token: 0x0602788C RID: 161932 RVA: 0x0057051E File Offset: 0x0056E71E
		public static void AddNpcSource(FlatBufferBuilder builder, Offset<ITimeScheduleEntityTemplateNpcSource> npcSourceOffset)
		{
			builder.AddOffset(1, npcSourceOffset.Value, 0);
		}

		// Token: 0x0602788D RID: 161933 RVA: 0x0057052E File Offset: 0x0056E72E
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0602788E RID: 161934 RVA: 0x0057053E File Offset: 0x0056E73E
		public static Offset<ITimeScheduleGenerateDynamicEntity> EndITimeScheduleGenerateDynamicEntity(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleGenerateDynamicEntity>(builder.EndTable());
		}

		// Token: 0x0602788F RID: 161935 RVA: 0x0057054C File Offset: 0x0056E74C
		public ITimeScheduleGenerateDynamicEntityT UnPack()
		{
			ITimeScheduleGenerateDynamicEntityT timeScheduleGenerateDynamicEntityT = new ITimeScheduleGenerateDynamicEntityT();
			this.UnPackTo(timeScheduleGenerateDynamicEntityT);
			return timeScheduleGenerateDynamicEntityT;
		}

		// Token: 0x06027890 RID: 161936 RVA: 0x00570568 File Offset: 0x0056E768
		public void UnPackTo(ITimeScheduleGenerateDynamicEntityT _o)
		{
			_o.GenerateParams = ((this.GenerateParams != null) ? this.GenerateParams.Value.UnPack() : null);
			_o.NpcSource = ((this.NpcSource != null) ? this.NpcSource.Value.UnPack() : null);
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
		}

		// Token: 0x06027891 RID: 161937 RVA: 0x00570608 File Offset: 0x0056E808
		public static Offset<ITimeScheduleGenerateDynamicEntity> Pack(FlatBufferBuilder builder, ITimeScheduleGenerateDynamicEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleGenerateDynamicEntity>);
			}
			Offset<ITimeScheduleGenerateParams> generateParamsOffset = (_o.GenerateParams == null) ? default(Offset<ITimeScheduleGenerateParams>) : ITimeScheduleGenerateParams.Pack(builder, _o.GenerateParams);
			Offset<ITimeScheduleEntityTemplateNpcSource> npcSourceOffset = (_o.NpcSource == null) ? default(Offset<ITimeScheduleEntityTemplateNpcSource>) : ITimeScheduleEntityTemplateNpcSource.Pack(builder, _o.NpcSource);
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return ITimeScheduleGenerateDynamicEntity.CreateITimeScheduleGenerateDynamicEntity(builder, generateParamsOffset, npcSourceOffset, conditionsOffset);
		}

		// Token: 0x0400F162 RID: 61794
		private Table __p;
	}
}
