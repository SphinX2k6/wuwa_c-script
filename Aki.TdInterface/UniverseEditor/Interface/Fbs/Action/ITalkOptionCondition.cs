using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AFA RID: 31482
	public struct ITalkOptionCondition : IFlatbufferObject
	{
		// Token: 0x1700EBE8 RID: 60392
		// (get) Token: 0x06038B15 RID: 232213 RVA: 0x007AB8BD File Offset: 0x007A9ABD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038B16 RID: 232214 RVA: 0x007AB8CA File Offset: 0x007A9ACA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038B17 RID: 232215 RVA: 0x007AB8D4 File Offset: 0x007A9AD4
		public static ITalkOptionCondition GetRootAsITalkOptionCondition(ByteBuffer _bb)
		{
			return ITalkOptionCondition.GetRootAsITalkOptionCondition(_bb, default(ITalkOptionCondition));
		}

		// Token: 0x06038B18 RID: 232216 RVA: 0x007AB8F0 File Offset: 0x007A9AF0
		public static ITalkOptionCondition GetRootAsITalkOptionCondition(ByteBuffer _bb, ITalkOptionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038B19 RID: 232217 RVA: 0x007AB90D File Offset: 0x007A9B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038B1A RID: 232218 RVA: 0x007AB91C File Offset: 0x007A9B1C
		public ITalkOptionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EBE9 RID: 60393
		// (get) Token: 0x06038B1B RID: 232219 RVA: 0x007AB92C File Offset: 0x007A9B2C
		public ETalkOptionPreConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return (ETalkOptionPreConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EBEA RID: 60394
		// (get) Token: 0x06038B1C RID: 232220 RVA: 0x007AB968 File Offset: 0x007A9B68
		public IConditionGroup? Conditions
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

		// Token: 0x06038B1D RID: 232221 RVA: 0x007AB9C5 File Offset: 0x007A9BC5
		public static Offset<ITalkOptionCondition> CreateITalkOptionCondition(FlatBufferBuilder builder, ETalkOptionPreConditionType Type = ETalkOptionPreConditionType.PreOption, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ITalkOptionCondition.AddConditions(builder, ConditionsOffset);
			ITalkOptionCondition.AddType(builder, Type);
			return ITalkOptionCondition.EndITalkOptionCondition(builder);
		}

		// Token: 0x06038B1E RID: 232222 RVA: 0x007AB9E2 File Offset: 0x007A9BE2
		public static void StartITalkOptionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06038B1F RID: 232223 RVA: 0x007AB9EB File Offset: 0x007A9BEB
		public static void AddType(FlatBufferBuilder builder, ETalkOptionPreConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038B20 RID: 232224 RVA: 0x007AB9F6 File Offset: 0x007A9BF6
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06038B21 RID: 232225 RVA: 0x007ABA06 File Offset: 0x007A9C06
		public static Offset<ITalkOptionCondition> EndITalkOptionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionCondition>(builder.EndTable());
		}

		// Token: 0x06038B22 RID: 232226 RVA: 0x007ABA14 File Offset: 0x007A9C14
		public ITalkOptionConditionT UnPack()
		{
			ITalkOptionConditionT talkOptionConditionT = new ITalkOptionConditionT();
			this.UnPackTo(talkOptionConditionT);
			return talkOptionConditionT;
		}

		// Token: 0x06038B23 RID: 232227 RVA: 0x007ABA30 File Offset: 0x007A9C30
		public void UnPackTo(ITalkOptionConditionT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
		}

		// Token: 0x06038B24 RID: 232228 RVA: 0x007ABA78 File Offset: 0x007A9C78
		public static Offset<ITalkOptionCondition> Pack(FlatBufferBuilder builder, ITalkOptionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionCondition>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			return ITalkOptionCondition.CreateITalkOptionCondition(builder, _o.Type, conditionsOffset);
		}

		// Token: 0x04013114 RID: 78100
		private Table __p;
	}
}
