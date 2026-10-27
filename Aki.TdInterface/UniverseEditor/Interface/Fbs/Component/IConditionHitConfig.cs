using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF1 RID: 20465
	public struct IConditionHitConfig : IFlatbufferObject
	{
		// Token: 0x17009441 RID: 37953
		// (get) Token: 0x06020B4B RID: 133963 RVA: 0x0048C297 File Offset: 0x0048A497
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B4C RID: 133964 RVA: 0x0048C2A4 File Offset: 0x0048A4A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B4D RID: 133965 RVA: 0x0048C2AC File Offset: 0x0048A4AC
		public static IConditionHitConfig GetRootAsIConditionHitConfig(ByteBuffer _bb)
		{
			return IConditionHitConfig.GetRootAsIConditionHitConfig(_bb, default(IConditionHitConfig));
		}

		// Token: 0x06020B4E RID: 133966 RVA: 0x0048C2C8 File Offset: 0x0048A4C8
		public static IConditionHitConfig GetRootAsIConditionHitConfig(ByteBuffer _bb, IConditionHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B4F RID: 133967 RVA: 0x0048C2E5 File Offset: 0x0048A4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B50 RID: 133968 RVA: 0x0048C2F4 File Offset: 0x0048A4F4
		public IConditionHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009442 RID: 37954
		// (get) Token: 0x06020B51 RID: 133969 RVA: 0x0048C304 File Offset: 0x0048A504
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

		// Token: 0x17009443 RID: 37955
		// (get) Token: 0x06020B52 RID: 133970 RVA: 0x0048C364 File Offset: 0x0048A564
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

		// Token: 0x06020B53 RID: 133971 RVA: 0x0048C39B File Offset: 0x0048A59B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020B54 RID: 133972 RVA: 0x0048C3AA File Offset: 0x0048A5AA
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06020B55 RID: 133973 RVA: 0x0048C3B8 File Offset: 0x0048A5B8
		public static Offset<IConditionHitConfig> CreateIConditionHitConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IConditionHitConfig.AddState(builder, StateOffset);
			IConditionHitConfig.AddConditions(builder, ConditionsOffset);
			return IConditionHitConfig.EndIConditionHitConfig(builder);
		}

		// Token: 0x06020B56 RID: 133974 RVA: 0x0048C3D5 File Offset: 0x0048A5D5
		public static void StartIConditionHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B57 RID: 133975 RVA: 0x0048C3DE File Offset: 0x0048A5DE
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06020B58 RID: 133976 RVA: 0x0048C3EE File Offset: 0x0048A5EE
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06020B59 RID: 133977 RVA: 0x0048C3FE File Offset: 0x0048A5FE
		public static Offset<IConditionHitConfig> EndIConditionHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IConditionHitConfig>(builder.EndTable());
		}

		// Token: 0x06020B5A RID: 133978 RVA: 0x0048C40C File Offset: 0x0048A60C
		public IConditionHitConfigT UnPack()
		{
			IConditionHitConfigT conditionHitConfigT = new IConditionHitConfigT();
			this.UnPackTo(conditionHitConfigT);
			return conditionHitConfigT;
		}

		// Token: 0x06020B5B RID: 133979 RVA: 0x0048C428 File Offset: 0x0048A628
		public void UnPackTo(IConditionHitConfigT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.State = this.State;
		}

		// Token: 0x06020B5C RID: 133980 RVA: 0x0048C470 File Offset: 0x0048A670
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

		// Token: 0x0400DFA9 RID: 57257
		private Table __p;
	}
}
