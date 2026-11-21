using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005544 RID: 21828
	public struct IConditionalNpcPerformOnInteract : IFlatbufferObject
	{
		// Token: 0x17009C0E RID: 39950
		// (get) Token: 0x06022A0D RID: 141837 RVA: 0x004C5017 File Offset: 0x004C3217
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A0E RID: 141838 RVA: 0x004C5024 File Offset: 0x004C3224
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A0F RID: 141839 RVA: 0x004C502C File Offset: 0x004C322C
		public static IConditionalNpcPerformOnInteract GetRootAsIConditionalNpcPerformOnInteract(ByteBuffer _bb)
		{
			return IConditionalNpcPerformOnInteract.GetRootAsIConditionalNpcPerformOnInteract(_bb, default(IConditionalNpcPerformOnInteract));
		}

		// Token: 0x06022A10 RID: 141840 RVA: 0x004C5048 File Offset: 0x004C3248
		public static IConditionalNpcPerformOnInteract GetRootAsIConditionalNpcPerformOnInteract(ByteBuffer _bb, IConditionalNpcPerformOnInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A11 RID: 141841 RVA: 0x004C5065 File Offset: 0x004C3265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x004C5074 File Offset: 0x004C3274
		public IConditionalNpcPerformOnInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C0F RID: 39951
		// (get) Token: 0x06022A13 RID: 141843 RVA: 0x004C5084 File Offset: 0x004C3284
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

		// Token: 0x17009C10 RID: 39952
		// (get) Token: 0x06022A14 RID: 141844 RVA: 0x004C50E4 File Offset: 0x004C32E4
		public INpcPerformOnInteract? Perform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new INpcPerformOnInteract?(default(INpcPerformOnInteract).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022A15 RID: 141845 RVA: 0x004C5141 File Offset: 0x004C3341
		public static Offset<IConditionalNpcPerformOnInteract> CreateIConditionalNpcPerformOnInteract(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<INpcPerformOnInteract> PerformOffset = default(Offset<INpcPerformOnInteract>))
		{
			builder.StartTable(2);
			IConditionalNpcPerformOnInteract.AddPerform(builder, PerformOffset);
			IConditionalNpcPerformOnInteract.AddCondition(builder, ConditionOffset);
			return IConditionalNpcPerformOnInteract.EndIConditionalNpcPerformOnInteract(builder);
		}

		// Token: 0x06022A16 RID: 141846 RVA: 0x004C515E File Offset: 0x004C335E
		public static void StartIConditionalNpcPerformOnInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022A17 RID: 141847 RVA: 0x004C5167 File Offset: 0x004C3367
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022A18 RID: 141848 RVA: 0x004C5177 File Offset: 0x004C3377
		public static void AddPerform(FlatBufferBuilder builder, Offset<INpcPerformOnInteract> performOffset)
		{
			builder.AddOffset(1, performOffset.Value, 0);
		}

		// Token: 0x06022A19 RID: 141849 RVA: 0x004C5187 File Offset: 0x004C3387
		public static Offset<IConditionalNpcPerformOnInteract> EndIConditionalNpcPerformOnInteract(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalNpcPerformOnInteract>(builder.EndTable());
		}

		// Token: 0x06022A1A RID: 141850 RVA: 0x004C5194 File Offset: 0x004C3394
		public IConditionalNpcPerformOnInteractT UnPack()
		{
			IConditionalNpcPerformOnInteractT conditionalNpcPerformOnInteractT = new IConditionalNpcPerformOnInteractT();
			this.UnPackTo(conditionalNpcPerformOnInteractT);
			return conditionalNpcPerformOnInteractT;
		}

		// Token: 0x06022A1B RID: 141851 RVA: 0x004C51B0 File Offset: 0x004C33B0
		public void UnPackTo(IConditionalNpcPerformOnInteractT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Perform = ((this.Perform != null) ? this.Perform.Value.UnPack() : null);
		}

		// Token: 0x06022A1C RID: 141852 RVA: 0x004C521C File Offset: 0x004C341C
		public static Offset<IConditionalNpcPerformOnInteract> Pack(FlatBufferBuilder builder, IConditionalNpcPerformOnInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionalNpcPerformOnInteract>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<INpcPerformOnInteract> performOffset = (_o.Perform == null) ? default(Offset<INpcPerformOnInteract>) : INpcPerformOnInteract.Pack(builder, _o.Perform);
			return IConditionalNpcPerformOnInteract.CreateIConditionalNpcPerformOnInteract(builder, conditionOffset, performOffset);
		}

		// Token: 0x0400EB93 RID: 60307
		private Table __p;
	}
}
