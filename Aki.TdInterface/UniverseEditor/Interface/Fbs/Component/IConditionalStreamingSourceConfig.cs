using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FEB RID: 20459
	public struct IConditionalStreamingSourceConfig : IFlatbufferObject
	{
		// Token: 0x17009437 RID: 37943
		// (get) Token: 0x06020B1F RID: 133919 RVA: 0x0048BC80 File Offset: 0x00489E80
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B20 RID: 133920 RVA: 0x0048BC8D File Offset: 0x00489E8D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B21 RID: 133921 RVA: 0x0048BC94 File Offset: 0x00489E94
		public static IConditionalStreamingSourceConfig GetRootAsIConditionalStreamingSourceConfig(ByteBuffer _bb)
		{
			return IConditionalStreamingSourceConfig.GetRootAsIConditionalStreamingSourceConfig(_bb, default(IConditionalStreamingSourceConfig));
		}

		// Token: 0x06020B22 RID: 133922 RVA: 0x0048BCB0 File Offset: 0x00489EB0
		public static IConditionalStreamingSourceConfig GetRootAsIConditionalStreamingSourceConfig(ByteBuffer _bb, IConditionalStreamingSourceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B23 RID: 133923 RVA: 0x0048BCCD File Offset: 0x00489ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B24 RID: 133924 RVA: 0x0048BCDC File Offset: 0x00489EDC
		public IConditionalStreamingSourceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009438 RID: 37944
		// (get) Token: 0x06020B25 RID: 133925 RVA: 0x0048BCEC File Offset: 0x00489EEC
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

		// Token: 0x17009439 RID: 37945
		// (get) Token: 0x06020B26 RID: 133926 RVA: 0x0048BD4C File Offset: 0x00489F4C
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

		// Token: 0x06020B27 RID: 133927 RVA: 0x0048BDA9 File Offset: 0x00489FA9
		public static Offset<IConditionalStreamingSourceConfig> CreateIConditionalStreamingSourceConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IStreamingSourceConfig> StreamingSourceConfigOffset = default(Offset<IStreamingSourceConfig>))
		{
			builder.StartTable(2);
			IConditionalStreamingSourceConfig.AddStreamingSourceConfig(builder, StreamingSourceConfigOffset);
			IConditionalStreamingSourceConfig.AddCondition(builder, ConditionOffset);
			return IConditionalStreamingSourceConfig.EndIConditionalStreamingSourceConfig(builder);
		}

		// Token: 0x06020B28 RID: 133928 RVA: 0x0048BDC6 File Offset: 0x00489FC6
		public static void StartIConditionalStreamingSourceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B29 RID: 133929 RVA: 0x0048BDCF File Offset: 0x00489FCF
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020B2A RID: 133930 RVA: 0x0048BDDF File Offset: 0x00489FDF
		public static void AddStreamingSourceConfig(FlatBufferBuilder builder, Offset<IStreamingSourceConfig> streamingSourceConfigOffset)
		{
			builder.AddOffset(1, streamingSourceConfigOffset.Value, 0);
		}

		// Token: 0x06020B2B RID: 133931 RVA: 0x0048BDEF File Offset: 0x00489FEF
		public static Offset<IConditionalStreamingSourceConfig> EndIConditionalStreamingSourceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalStreamingSourceConfig>(builder.EndTable());
		}

		// Token: 0x06020B2C RID: 133932 RVA: 0x0048BDFC File Offset: 0x00489FFC
		public IConditionalStreamingSourceConfigT UnPack()
		{
			IConditionalStreamingSourceConfigT conditionalStreamingSourceConfigT = new IConditionalStreamingSourceConfigT();
			this.UnPackTo(conditionalStreamingSourceConfigT);
			return conditionalStreamingSourceConfigT;
		}

		// Token: 0x06020B2D RID: 133933 RVA: 0x0048BE18 File Offset: 0x0048A018
		public void UnPackTo(IConditionalStreamingSourceConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.StreamingSourceConfig = ((this.StreamingSourceConfig != null) ? this.StreamingSourceConfig.Value.UnPack() : null);
		}

		// Token: 0x06020B2E RID: 133934 RVA: 0x0048BE84 File Offset: 0x0048A084
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

		// Token: 0x0400DFA3 RID: 57251
		private Table __p;
	}
}
