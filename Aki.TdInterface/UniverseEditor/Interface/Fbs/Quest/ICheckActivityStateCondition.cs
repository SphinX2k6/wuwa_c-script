using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D43 RID: 15683
	public struct ICheckActivityStateCondition : IFlatbufferObject
	{
		// Token: 0x17006B94 RID: 27540
		// (get) Token: 0x06015AC5 RID: 88773 RVA: 0x0032091C File Offset: 0x0031EB1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015AC6 RID: 88774 RVA: 0x00320929 File Offset: 0x0031EB29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015AC7 RID: 88775 RVA: 0x00320930 File Offset: 0x0031EB30
		public static ICheckActivityStateCondition GetRootAsICheckActivityStateCondition(ByteBuffer _bb)
		{
			return ICheckActivityStateCondition.GetRootAsICheckActivityStateCondition(_bb, default(ICheckActivityStateCondition));
		}

		// Token: 0x06015AC8 RID: 88776 RVA: 0x0032094C File Offset: 0x0031EB4C
		public static ICheckActivityStateCondition GetRootAsICheckActivityStateCondition(ByteBuffer _bb, ICheckActivityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015AC9 RID: 88777 RVA: 0x00320969 File Offset: 0x0031EB69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015ACA RID: 88778 RVA: 0x00320978 File Offset: 0x0031EB78
		public ICheckActivityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B95 RID: 27541
		// (get) Token: 0x06015ACB RID: 88779 RVA: 0x00320988 File Offset: 0x0031EB88
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B96 RID: 27542
		// (get) Token: 0x06015ACC RID: 88780 RVA: 0x003209C4 File Offset: 0x0031EBC4
		public IConditionGroup? PreConditions
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

		// Token: 0x17006B97 RID: 27543
		// (get) Token: 0x06015ACD RID: 88781 RVA: 0x00320A24 File Offset: 0x0031EC24
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B98 RID: 27544
		// (get) Token: 0x06015ACE RID: 88782 RVA: 0x00320A60 File Offset: 0x0031EC60
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B99 RID: 27545
		// (get) Token: 0x06015ACF RID: 88783 RVA: 0x00320AA0 File Offset: 0x0031ECA0
		public EActivityState ActivityState
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EActivityState.BeforeOpen;
				}
				return (EActivityState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015AD0 RID: 88784 RVA: 0x00320ADD File Offset: 0x0031ECDD
		public static Offset<ICheckActivityStateCondition> CreateICheckActivityStateCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int ActivityId = 0, ECompare Compare = ECompare.Eq, EActivityState ActivityState = EActivityState.BeforeOpen)
		{
			builder.StartTable(5);
			ICheckActivityStateCondition.AddActivityId(builder, ActivityId);
			ICheckActivityStateCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckActivityStateCondition.AddActivityState(builder, ActivityState);
			ICheckActivityStateCondition.AddCompare(builder, Compare);
			ICheckActivityStateCondition.AddType(builder, Type);
			return ICheckActivityStateCondition.EndICheckActivityStateCondition(builder);
		}

		// Token: 0x06015AD1 RID: 88785 RVA: 0x00320B11 File Offset: 0x0031ED11
		public static void StartICheckActivityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06015AD2 RID: 88786 RVA: 0x00320B1A File Offset: 0x0031ED1A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015AD3 RID: 88787 RVA: 0x00320B25 File Offset: 0x0031ED25
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015AD4 RID: 88788 RVA: 0x00320B35 File Offset: 0x0031ED35
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(2, activityId, 0);
		}

		// Token: 0x06015AD5 RID: 88789 RVA: 0x00320B40 File Offset: 0x0031ED40
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x06015AD6 RID: 88790 RVA: 0x00320B4B File Offset: 0x0031ED4B
		public static void AddActivityState(FlatBufferBuilder builder, EActivityState activityState)
		{
			builder.AddByte(4, (byte)activityState, 0);
		}

		// Token: 0x06015AD7 RID: 88791 RVA: 0x00320B56 File Offset: 0x0031ED56
		public static Offset<ICheckActivityStateCondition> EndICheckActivityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckActivityStateCondition>(builder.EndTable());
		}

		// Token: 0x06015AD8 RID: 88792 RVA: 0x00320B64 File Offset: 0x0031ED64
		public ICheckActivityStateConditionT UnPack()
		{
			ICheckActivityStateConditionT checkActivityStateConditionT = new ICheckActivityStateConditionT();
			this.UnPackTo(checkActivityStateConditionT);
			return checkActivityStateConditionT;
		}

		// Token: 0x06015AD9 RID: 88793 RVA: 0x00320B80 File Offset: 0x0031ED80
		public void UnPackTo(ICheckActivityStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ActivityId = this.ActivityId;
			_o.Compare = this.Compare;
			_o.ActivityState = this.ActivityState;
		}

		// Token: 0x06015ADA RID: 88794 RVA: 0x00320BEC File Offset: 0x0031EDEC
		public static Offset<ICheckActivityStateCondition> Pack(FlatBufferBuilder builder, ICheckActivityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckActivityStateCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ICheckActivityStateCondition.CreateICheckActivityStateCondition(builder, _o.Type, preConditionsOffset, _o.ActivityId, _o.Compare, _o.ActivityState);
		}

		// Token: 0x0400B618 RID: 46616
		private Table __p;
	}
}
