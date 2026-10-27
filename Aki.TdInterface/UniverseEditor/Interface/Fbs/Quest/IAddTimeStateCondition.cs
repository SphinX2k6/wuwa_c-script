using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF8 RID: 15608
	public struct IAddTimeStateCondition : IFlatbufferObject
	{
		// Token: 0x17006B02 RID: 27394
		// (get) Token: 0x0601580D RID: 88077 RVA: 0x0031B34A File Offset: 0x0031954A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601580E RID: 88078 RVA: 0x0031B357 File Offset: 0x00319557
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601580F RID: 88079 RVA: 0x0031B360 File Offset: 0x00319560
		public static IAddTimeStateCondition GetRootAsIAddTimeStateCondition(ByteBuffer _bb)
		{
			return IAddTimeStateCondition.GetRootAsIAddTimeStateCondition(_bb, default(IAddTimeStateCondition));
		}

		// Token: 0x06015810 RID: 88080 RVA: 0x0031B37C File Offset: 0x0031957C
		public static IAddTimeStateCondition GetRootAsIAddTimeStateCondition(ByteBuffer _bb, IAddTimeStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015811 RID: 88081 RVA: 0x0031B399 File Offset: 0x00319599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015812 RID: 88082 RVA: 0x0031B3A8 File Offset: 0x003195A8
		public IAddTimeStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B03 RID: 27395
		// (get) Token: 0x06015813 RID: 88083 RVA: 0x0031B3B8 File Offset: 0x003195B8
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

		// Token: 0x17006B04 RID: 27396
		// (get) Token: 0x06015814 RID: 88084 RVA: 0x0031B418 File Offset: 0x00319618
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

		// Token: 0x06015815 RID: 88085 RVA: 0x0031B454 File Offset: 0x00319654
		public static Offset<IAddTimeStateCondition> CreateIAddTimeStateCondition(FlatBufferBuilder builder, Offset<IEntityStateCondition> ConditionOffset = default(Offset<IEntityStateCondition>), int AddTime = 0)
		{
			builder.StartTable(2);
			IAddTimeStateCondition.AddAddTime(builder, AddTime);
			IAddTimeStateCondition.AddCondition(builder, ConditionOffset);
			return IAddTimeStateCondition.EndIAddTimeStateCondition(builder);
		}

		// Token: 0x06015816 RID: 88086 RVA: 0x0031B471 File Offset: 0x00319671
		public static void StartIAddTimeStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015817 RID: 88087 RVA: 0x0031B47A File Offset: 0x0031967A
		public static void AddCondition(FlatBufferBuilder builder, Offset<IEntityStateCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06015818 RID: 88088 RVA: 0x0031B48A File Offset: 0x0031968A
		public static void AddAddTime(FlatBufferBuilder builder, int addTime)
		{
			builder.AddInt(1, addTime, 0);
		}

		// Token: 0x06015819 RID: 88089 RVA: 0x0031B495 File Offset: 0x00319695
		public static Offset<IAddTimeStateCondition> EndIAddTimeStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<IAddTimeStateCondition>(builder.EndTable());
		}

		// Token: 0x0601581A RID: 88090 RVA: 0x0031B4A4 File Offset: 0x003196A4
		public IAddTimeStateConditionT UnPack()
		{
			IAddTimeStateConditionT addTimeStateConditionT = new IAddTimeStateConditionT();
			this.UnPackTo(addTimeStateConditionT);
			return addTimeStateConditionT;
		}

		// Token: 0x0601581B RID: 88091 RVA: 0x0031B4C0 File Offset: 0x003196C0
		public void UnPackTo(IAddTimeStateConditionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.AddTime = this.AddTime;
		}

		// Token: 0x0601581C RID: 88092 RVA: 0x0031B508 File Offset: 0x00319708
		public static Offset<IAddTimeStateCondition> Pack(FlatBufferBuilder builder, IAddTimeStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTimeStateCondition>);
			}
			Offset<IEntityStateCondition> conditionOffset = (_o.Condition == null) ? default(Offset<IEntityStateCondition>) : IEntityStateCondition.Pack(builder, _o.Condition);
			return IAddTimeStateCondition.CreateIAddTimeStateCondition(builder, conditionOffset, _o.AddTime);
		}

		// Token: 0x0400B59D RID: 46493
		private Table __p;
	}
}
