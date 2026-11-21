using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410F RID: 16655
	public struct IAddTimeStateCondition : IFlatbufferObject
	{
		// Token: 0x170070BC RID: 28860
		// (get) Token: 0x06016D45 RID: 93509 RVA: 0x003425C2 File Offset: 0x003407C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x003425CF File Offset: 0x003407CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x003425D8 File Offset: 0x003407D8
		public static IAddTimeStateCondition GetRootAsIAddTimeStateCondition(ByteBuffer _bb)
		{
			return IAddTimeStateCondition.GetRootAsIAddTimeStateCondition(_bb, default(IAddTimeStateCondition));
		}

		// Token: 0x06016D48 RID: 93512 RVA: 0x003425F4 File Offset: 0x003407F4
		public static IAddTimeStateCondition GetRootAsIAddTimeStateCondition(ByteBuffer _bb, IAddTimeStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D49 RID: 93513 RVA: 0x00342611 File Offset: 0x00340811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D4A RID: 93514 RVA: 0x00342620 File Offset: 0x00340820
		public IAddTimeStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070BD RID: 28861
		// (get) Token: 0x06016D4B RID: 93515 RVA: 0x00342630 File Offset: 0x00340830
		public IEntityStateCondition? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityStateCondition?(default(IEntityStateCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170070BE RID: 28862
		// (get) Token: 0x06016D4C RID: 93516 RVA: 0x00342690 File Offset: 0x00340890
		public int AddTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D4D RID: 93517 RVA: 0x003426CC File Offset: 0x003408CC
		public static Offset<IAddTimeStateCondition> CreateIAddTimeStateCondition(FlatBufferBuilder builder, Offset<IEntityStateCondition> ConditionOffset = default(Offset<IEntityStateCondition>), int AddTime = 0)
		{
			builder.StartTable(2);
			IAddTimeStateCondition.AddAddTime(builder, AddTime);
			IAddTimeStateCondition.AddCondition(builder, ConditionOffset);
			return IAddTimeStateCondition.EndIAddTimeStateCondition(builder);
		}

		// Token: 0x06016D4E RID: 93518 RVA: 0x003426E9 File Offset: 0x003408E9
		public static void StartIAddTimeStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016D4F RID: 93519 RVA: 0x003426F2 File Offset: 0x003408F2
		public static void AddCondition(FlatBufferBuilder builder, Offset<IEntityStateCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06016D50 RID: 93520 RVA: 0x00342702 File Offset: 0x00340902
		public static void AddAddTime(FlatBufferBuilder builder, int addTime)
		{
			builder.AddInt(1, addTime, 0);
		}

		// Token: 0x06016D51 RID: 93521 RVA: 0x0034270D File Offset: 0x0034090D
		public static Offset<IAddTimeStateCondition> EndIAddTimeStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAddTimeStateCondition>(builder.EndTable());
		}

		// Token: 0x06016D52 RID: 93522 RVA: 0x0034271C File Offset: 0x0034091C
		public IAddTimeStateConditionT UnPack()
		{
			IAddTimeStateConditionT addTimeStateConditionT = new IAddTimeStateConditionT();
			this.UnPackTo(addTimeStateConditionT);
			return addTimeStateConditionT;
		}

		// Token: 0x06016D53 RID: 93523 RVA: 0x00342738 File Offset: 0x00340938
		public void UnPackTo(IAddTimeStateConditionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.AddTime = this.AddTime;
		}

		// Token: 0x06016D54 RID: 93524 RVA: 0x00342780 File Offset: 0x00340980
		public static Offset<IAddTimeStateCondition> Pack(FlatBufferBuilder builder, IAddTimeStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTimeStateCondition>);
			}
			Offset<IEntityStateCondition> conditionOffset = (_o.Condition == null) ? default(Offset<IEntityStateCondition>) : IEntityStateCondition.Pack(builder, _o.Condition);
			return IAddTimeStateCondition.CreateIAddTimeStateCondition(builder, conditionOffset, _o.AddTime);
		}

		// Token: 0x0400BF4A RID: 48970
		private Table __p;
	}
}
