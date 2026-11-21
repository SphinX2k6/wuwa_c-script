using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554A RID: 21834
	public struct IConditionalStreamingSourceConfig : IFlatbufferObject
	{
		// Token: 0x17009C18 RID: 39960
		// (get) Token: 0x06022A3F RID: 141887 RVA: 0x004C56D0 File Offset: 0x004C38D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A40 RID: 141888 RVA: 0x004C56DD File Offset: 0x004C38DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A41 RID: 141889 RVA: 0x004C56E4 File Offset: 0x004C38E4
		public static IConditionalStreamingSourceConfig GetRootAsIConditionalStreamingSourceConfig(ByteBuffer _bb)
		{
			return IConditionalStreamingSourceConfig.GetRootAsIConditionalStreamingSourceConfig(_bb, default(IConditionalStreamingSourceConfig));
		}

		// Token: 0x06022A42 RID: 141890 RVA: 0x004C5700 File Offset: 0x004C3900
		public static IConditionalStreamingSourceConfig GetRootAsIConditionalStreamingSourceConfig(ByteBuffer _bb, IConditionalStreamingSourceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A43 RID: 141891 RVA: 0x004C571D File Offset: 0x004C391D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A44 RID: 141892 RVA: 0x004C572C File Offset: 0x004C392C
		public IConditionalStreamingSourceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C19 RID: 39961
		// (get) Token: 0x06022A45 RID: 141893 RVA: 0x004C573C File Offset: 0x004C393C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009C1A RID: 39962
		// (get) Token: 0x06022A46 RID: 141894 RVA: 0x004C579C File Offset: 0x004C399C
		public IStreamingSourceConfig? StreamingSourceConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IStreamingSourceConfig?(default(IStreamingSourceConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022A47 RID: 141895 RVA: 0x004C57F9 File Offset: 0x004C39F9
		public static Offset<IConditionalStreamingSourceConfig> CreateIConditionalStreamingSourceConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IStreamingSourceConfig> StreamingSourceConfigOffset = default(Offset<IStreamingSourceConfig>))
		{
			builder.StartTable(2);
			IConditionalStreamingSourceConfig.AddStreamingSourceConfig(builder, StreamingSourceConfigOffset);
			IConditionalStreamingSourceConfig.AddCondition(builder, ConditionOffset);
			return IConditionalStreamingSourceConfig.EndIConditionalStreamingSourceConfig(builder);
		}

		// Token: 0x06022A48 RID: 141896 RVA: 0x004C5816 File Offset: 0x004C3A16
		public static void StartIConditionalStreamingSourceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022A49 RID: 141897 RVA: 0x004C581F File Offset: 0x004C3A1F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022A4A RID: 141898 RVA: 0x004C582F File Offset: 0x004C3A2F
		public static void AddStreamingSourceConfig(FlatBufferBuilder builder, Offset<IStreamingSourceConfig> streamingSourceConfigOffset)
		{
			builder.AddOffset(1, streamingSourceConfigOffset.Value, 0);
		}

		// Token: 0x06022A4B RID: 141899 RVA: 0x004C583F File Offset: 0x004C3A3F
		public static Offset<IConditionalStreamingSourceConfig> EndIConditionalStreamingSourceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalStreamingSourceConfig>(builder.EndTable());
		}

		// Token: 0x06022A4C RID: 141900 RVA: 0x004C584C File Offset: 0x004C3A4C
		public IConditionalStreamingSourceConfigT UnPack()
		{
			IConditionalStreamingSourceConfigT conditionalStreamingSourceConfigT = new IConditionalStreamingSourceConfigT();
			this.UnPackTo(conditionalStreamingSourceConfigT);
			return conditionalStreamingSourceConfigT;
		}

		// Token: 0x06022A4D RID: 141901 RVA: 0x004C5868 File Offset: 0x004C3A68
		public void UnPackTo(IConditionalStreamingSourceConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.StreamingSourceConfig = ((this.StreamingSourceConfig != null) ? this.StreamingSourceConfig.Value.UnPack() : null);
		}

		// Token: 0x06022A4E RID: 141902 RVA: 0x004C58D4 File Offset: 0x004C3AD4
		public static Offset<IConditionalStreamingSourceConfig> Pack(FlatBufferBuilder builder, IConditionalStreamingSourceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionalStreamingSourceConfig>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IStreamingSourceConfig> streamingSourceConfigOffset = (_o.StreamingSourceConfig == null) ? default(Offset<IStreamingSourceConfig>) : IStreamingSourceConfig.Pack(builder, _o.StreamingSourceConfig);
			return IConditionalStreamingSourceConfig.CreateIConditionalStreamingSourceConfig(builder, conditionOffset, streamingSourceConfigOffset);
		}

		// Token: 0x0400EB99 RID: 60313
		private Table __p;
	}
}
