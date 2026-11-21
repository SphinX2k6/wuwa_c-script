using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A5 RID: 21669
	public struct IChangeTemplateInstanceStateConfig : IFlatbufferObject
	{
		// Token: 0x17009A7B RID: 39547
		// (get) Token: 0x060221EB RID: 139755 RVA: 0x004B4182 File Offset: 0x004B2382
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060221EC RID: 139756 RVA: 0x004B418F File Offset: 0x004B238F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060221ED RID: 139757 RVA: 0x004B4198 File Offset: 0x004B2398
		public static IChangeTemplateInstanceStateConfig GetRootAsIChangeTemplateInstanceStateConfig(ByteBuffer _bb)
		{
			return IChangeTemplateInstanceStateConfig.GetRootAsIChangeTemplateInstanceStateConfig(_bb, default(IChangeTemplateInstanceStateConfig));
		}

		// Token: 0x060221EE RID: 139758 RVA: 0x004B41B4 File Offset: 0x004B23B4
		public static IChangeTemplateInstanceStateConfig GetRootAsIChangeTemplateInstanceStateConfig(ByteBuffer _bb, IChangeTemplateInstanceStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060221EF RID: 139759 RVA: 0x004B41D1 File Offset: 0x004B23D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060221F0 RID: 139760 RVA: 0x004B41E0 File Offset: 0x004B23E0
		public IChangeTemplateInstanceStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A7C RID: 39548
		// (get) Token: 0x060221F1 RID: 139761 RVA: 0x004B41F0 File Offset: 0x004B23F0
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

		// Token: 0x17009A7D RID: 39549
		// (get) Token: 0x060221F2 RID: 139762 RVA: 0x004B4250 File Offset: 0x004B2450
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

		// Token: 0x060221F3 RID: 139763 RVA: 0x004B4287 File Offset: 0x004B2487
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060221F4 RID: 139764 RVA: 0x004B4296 File Offset: 0x004B2496
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060221F5 RID: 139765 RVA: 0x004B42A4 File Offset: 0x004B24A4
		public static Offset<IChangeTemplateInstanceStateConfig> CreateIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeTemplateInstanceStateConfig.AddState(builder, StateOffset);
			IChangeTemplateInstanceStateConfig.AddCondition(builder, ConditionOffset);
			return IChangeTemplateInstanceStateConfig.EndIChangeTemplateInstanceStateConfig(builder);
		}

		// Token: 0x060221F6 RID: 139766 RVA: 0x004B42C1 File Offset: 0x004B24C1
		public static void StartIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060221F7 RID: 139767 RVA: 0x004B42CA File Offset: 0x004B24CA
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060221F8 RID: 139768 RVA: 0x004B42DA File Offset: 0x004B24DA
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x060221F9 RID: 139769 RVA: 0x004B42EA File Offset: 0x004B24EA
		public static Offset<IChangeTemplateInstanceStateConfig> EndIChangeTemplateInstanceStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTemplateInstanceStateConfig>(builder.EndTable());
		}

		// Token: 0x060221FA RID: 139770 RVA: 0x004B42F8 File Offset: 0x004B24F8
		public IChangeTemplateInstanceStateConfigT UnPack()
		{
			IChangeTemplateInstanceStateConfigT changeTemplateInstanceStateConfigT = new IChangeTemplateInstanceStateConfigT();
			this.UnPackTo(changeTemplateInstanceStateConfigT);
			return changeTemplateInstanceStateConfigT;
		}

		// Token: 0x060221FB RID: 139771 RVA: 0x004B4314 File Offset: 0x004B2514
		public void UnPackTo(IChangeTemplateInstanceStateConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.State = this.State;
		}

		// Token: 0x060221FC RID: 139772 RVA: 0x004B435C File Offset: 0x004B255C
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

		// Token: 0x0400E9C6 RID: 59846
		private Table __p;
	}
}
