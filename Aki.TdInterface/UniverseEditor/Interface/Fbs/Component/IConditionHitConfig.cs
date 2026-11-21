using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005550 RID: 21840
	public struct IConditionHitConfig : IFlatbufferObject
	{
		// Token: 0x17009C22 RID: 39970
		// (get) Token: 0x06022A6B RID: 141931 RVA: 0x004C5CE7 File Offset: 0x004C3EE7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A6C RID: 141932 RVA: 0x004C5CF4 File Offset: 0x004C3EF4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A6D RID: 141933 RVA: 0x004C5CFC File Offset: 0x004C3EFC
		public static IConditionHitConfig GetRootAsIConditionHitConfig(ByteBuffer _bb)
		{
			return IConditionHitConfig.GetRootAsIConditionHitConfig(_bb, default(IConditionHitConfig));
		}

		// Token: 0x06022A6E RID: 141934 RVA: 0x004C5D18 File Offset: 0x004C3F18
		public static IConditionHitConfig GetRootAsIConditionHitConfig(ByteBuffer _bb, IConditionHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A6F RID: 141935 RVA: 0x004C5D35 File Offset: 0x004C3F35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A70 RID: 141936 RVA: 0x004C5D44 File Offset: 0x004C3F44
		public IConditionHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C23 RID: 39971
		// (get) Token: 0x06022A71 RID: 141937 RVA: 0x004C5D54 File Offset: 0x004C3F54
		public IConditionGroup? Conditions
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

		// Token: 0x17009C24 RID: 39972
		// (get) Token: 0x06022A72 RID: 141938 RVA: 0x004C5DB4 File Offset: 0x004C3FB4
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

		// Token: 0x06022A73 RID: 141939 RVA: 0x004C5DEB File Offset: 0x004C3FEB
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022A74 RID: 141940 RVA: 0x004C5DFA File Offset: 0x004C3FFA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022A75 RID: 141941 RVA: 0x004C5E08 File Offset: 0x004C4008
		public static Offset<IConditionHitConfig> CreateIConditionHitConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IConditionHitConfig.AddState(builder, StateOffset);
			IConditionHitConfig.AddConditions(builder, ConditionsOffset);
			return IConditionHitConfig.EndIConditionHitConfig(builder);
		}

		// Token: 0x06022A76 RID: 141942 RVA: 0x004C5E25 File Offset: 0x004C4025
		public static void StartIConditionHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022A77 RID: 141943 RVA: 0x004C5E2E File Offset: 0x004C402E
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06022A78 RID: 141944 RVA: 0x004C5E3E File Offset: 0x004C403E
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06022A79 RID: 141945 RVA: 0x004C5E4E File Offset: 0x004C404E
		public static Offset<IConditionHitConfig> EndIConditionHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConditionHitConfig>(builder.EndTable());
		}

		// Token: 0x06022A7A RID: 141946 RVA: 0x004C5E5C File Offset: 0x004C405C
		public IConditionHitConfigT UnPack()
		{
			IConditionHitConfigT conditionHitConfigT = new IConditionHitConfigT();
			this.UnPackTo(conditionHitConfigT);
			return conditionHitConfigT;
		}

		// Token: 0x06022A7B RID: 141947 RVA: 0x004C5E78 File Offset: 0x004C4078
		public void UnPackTo(IConditionHitConfigT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.State = this.State;
		}

		// Token: 0x06022A7C RID: 141948 RVA: 0x004C5EC0 File Offset: 0x004C40C0
		public static Offset<IConditionHitConfig> Pack(FlatBufferBuilder builder, IConditionHitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionHitConfig>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IConditionHitConfig.CreateIConditionHitConfig(builder, conditionsOffset, stateOffset);
		}

		// Token: 0x0400EB9F RID: 60319
		private Table __p;
	}
}
