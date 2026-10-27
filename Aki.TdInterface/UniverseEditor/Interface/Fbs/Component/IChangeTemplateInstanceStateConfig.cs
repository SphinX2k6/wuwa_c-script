using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F76 RID: 20342
	public struct IChangeTemplateInstanceStateConfig : IFlatbufferObject
	{
		// Token: 0x17009302 RID: 37634
		// (get) Token: 0x06020499 RID: 132249 RVA: 0x0047E192 File Offset: 0x0047C392
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602049A RID: 132250 RVA: 0x0047E19F File Offset: 0x0047C39F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602049B RID: 132251 RVA: 0x0047E1A8 File Offset: 0x0047C3A8
		public static IChangeTemplateInstanceStateConfig GetRootAsIChangeTemplateInstanceStateConfig(ByteBuffer _bb)
		{
			return IChangeTemplateInstanceStateConfig.GetRootAsIChangeTemplateInstanceStateConfig(_bb, default(IChangeTemplateInstanceStateConfig));
		}

		// Token: 0x0602049C RID: 132252 RVA: 0x0047E1C4 File Offset: 0x0047C3C4
		public static IChangeTemplateInstanceStateConfig GetRootAsIChangeTemplateInstanceStateConfig(ByteBuffer _bb, IChangeTemplateInstanceStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602049D RID: 132253 RVA: 0x0047E1E1 File Offset: 0x0047C3E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602049E RID: 132254 RVA: 0x0047E1F0 File Offset: 0x0047C3F0
		public IChangeTemplateInstanceStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009303 RID: 37635
		// (get) Token: 0x0602049F RID: 132255 RVA: 0x0047E200 File Offset: 0x0047C400
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

		// Token: 0x17009304 RID: 37636
		// (get) Token: 0x060204A0 RID: 132256 RVA: 0x0047E260 File Offset: 0x0047C460
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060204A1 RID: 132257 RVA: 0x0047E297 File Offset: 0x0047C497
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060204A2 RID: 132258 RVA: 0x0047E2A6 File Offset: 0x0047C4A6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060204A3 RID: 132259 RVA: 0x0047E2B4 File Offset: 0x0047C4B4
		public static Offset<IChangeTemplateInstanceStateConfig> CreateIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeTemplateInstanceStateConfig.AddState(builder, StateOffset);
			IChangeTemplateInstanceStateConfig.AddCondition(builder, ConditionOffset);
			return IChangeTemplateInstanceStateConfig.EndIChangeTemplateInstanceStateConfig(builder);
		}

		// Token: 0x060204A4 RID: 132260 RVA: 0x0047E2D1 File Offset: 0x0047C4D1
		public static void StartIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060204A5 RID: 132261 RVA: 0x0047E2DA File Offset: 0x0047C4DA
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060204A6 RID: 132262 RVA: 0x0047E2EA File Offset: 0x0047C4EA
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060204A7 RID: 132263 RVA: 0x0047E2FA File Offset: 0x0047C4FA
		public static Offset<IChangeTemplateInstanceStateConfig> EndIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTemplateInstanceStateConfig>(builder.EndTable());
		}

		// Token: 0x060204A8 RID: 132264 RVA: 0x0047E308 File Offset: 0x0047C508
		public IChangeTemplateInstanceStateConfigT UnPack()
		{
			IChangeTemplateInstanceStateConfigT changeTemplateInstanceStateConfigT = new IChangeTemplateInstanceStateConfigT();
			this.UnPackTo(changeTemplateInstanceStateConfigT);
			return changeTemplateInstanceStateConfigT;
		}

		// Token: 0x060204A9 RID: 132265 RVA: 0x0047E324 File Offset: 0x0047C524
		public void UnPackTo(IChangeTemplateInstanceStateConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.State = this.State;
		}

		// Token: 0x060204AA RID: 132266 RVA: 0x0047E36C File Offset: 0x0047C56C
		public static Offset<IChangeTemplateInstanceStateConfig> Pack(FlatBufferBuilder builder, IChangeTemplateInstanceStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTemplateInstanceStateConfig>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IChangeTemplateInstanceStateConfig.CreateIChangeTemplateInstanceStateConfig(builder, conditionOffset, stateOffset);
		}

		// Token: 0x0400DE1C RID: 56860
		private Table __p;
	}
}
