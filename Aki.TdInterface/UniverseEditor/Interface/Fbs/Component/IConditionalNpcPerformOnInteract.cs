using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE5 RID: 20453
	public struct IConditionalNpcPerformOnInteract : IFlatbufferObject
	{
		// Token: 0x1700942D RID: 37933
		// (get) Token: 0x06020AED RID: 133869 RVA: 0x0048B5C7 File Offset: 0x004897C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020AEE RID: 133870 RVA: 0x0048B5D4 File Offset: 0x004897D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020AEF RID: 133871 RVA: 0x0048B5DC File Offset: 0x004897DC
		public static IConditionalNpcPerformOnInteract GetRootAsIConditionalNpcPerformOnInteract(ByteBuffer _bb)
		{
			return IConditionalNpcPerformOnInteract.GetRootAsIConditionalNpcPerformOnInteract(_bb, default(IConditionalNpcPerformOnInteract));
		}

		// Token: 0x06020AF0 RID: 133872 RVA: 0x0048B5F8 File Offset: 0x004897F8
		public static IConditionalNpcPerformOnInteract GetRootAsIConditionalNpcPerformOnInteract(ByteBuffer _bb, IConditionalNpcPerformOnInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020AF1 RID: 133873 RVA: 0x0048B615 File Offset: 0x00489815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020AF2 RID: 133874 RVA: 0x0048B624 File Offset: 0x00489824
		public IConditionalNpcPerformOnInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700942E RID: 37934
		// (get) Token: 0x06020AF3 RID: 133875 RVA: 0x0048B634 File Offset: 0x00489834
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

		// Token: 0x1700942F RID: 37935
		// (get) Token: 0x06020AF4 RID: 133876 RVA: 0x0048B694 File Offset: 0x00489894
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

		// Token: 0x06020AF5 RID: 133877 RVA: 0x0048B6F1 File Offset: 0x004898F1
		public static Offset<IConditionalNpcPerformOnInteract> CreateIConditionalNpcPerformOnInteract(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<INpcPerformOnInteract> PerformOffset = default(Offset<INpcPerformOnInteract>))
		{
			builder.StartTable(2);
			IConditionalNpcPerformOnInteract.AddPerform(builder, PerformOffset);
			IConditionalNpcPerformOnInteract.AddCondition(builder, ConditionOffset);
			return IConditionalNpcPerformOnInteract.EndIConditionalNpcPerformOnInteract(builder);
		}

		// Token: 0x06020AF6 RID: 133878 RVA: 0x0048B70E File Offset: 0x0048990E
		public static void StartIConditionalNpcPerformOnInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020AF7 RID: 133879 RVA: 0x0048B717 File Offset: 0x00489917
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020AF8 RID: 133880 RVA: 0x0048B727 File Offset: 0x00489927
		public static void AddPerform(FlatBufferBuilder builder, Offset<INpcPerformOnInteract> performOffset)
		{
			builder.AddOffset(1, performOffset.Value, 0);
		}

		// Token: 0x06020AF9 RID: 133881 RVA: 0x0048B737 File Offset: 0x00489937
		public static Offset<IConditionalNpcPerformOnInteract> EndIConditionalNpcPerformOnInteract(FlatBufferBuilder builder)
		{
			return new Offset<IConditionalNpcPerformOnInteract>(builder.EndTable());
		}

		// Token: 0x06020AFA RID: 133882 RVA: 0x0048B744 File Offset: 0x00489944
		public IConditionalNpcPerformOnInteractT UnPack()
		{
			IConditionalNpcPerformOnInteractT conditionalNpcPerformOnInteractT = new IConditionalNpcPerformOnInteractT();
			this.UnPackTo(conditionalNpcPerformOnInteractT);
			return conditionalNpcPerformOnInteractT;
		}

		// Token: 0x06020AFB RID: 133883 RVA: 0x0048B760 File Offset: 0x00489960
		public void UnPackTo(IConditionalNpcPerformOnInteractT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Perform = ((this.Perform != null) ? this.Perform.Value.UnPack() : null);
		}

		// Token: 0x06020AFC RID: 133884 RVA: 0x0048B7CC File Offset: 0x004899CC
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

		// Token: 0x0400DF9D RID: 57245
		private Table __p;
	}
}
