using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415A RID: 16730
	public struct ICheckActivityStateCondition : IFlatbufferObject
	{
		// Token: 0x1700714E RID: 29006
		// (get) Token: 0x06016FFD RID: 94205 RVA: 0x00347B94 File Offset: 0x00345D94
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016FFE RID: 94206 RVA: 0x00347BA1 File Offset: 0x00345DA1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016FFF RID: 94207 RVA: 0x00347BA8 File Offset: 0x00345DA8
		public static ICheckActivityStateCondition GetRootAsICheckActivityStateCondition(ByteBuffer _bb)
		{
			return ICheckActivityStateCondition.GetRootAsICheckActivityStateCondition(_bb, default(ICheckActivityStateCondition));
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x00347BC4 File Offset: 0x00345DC4
		public static ICheckActivityStateCondition GetRootAsICheckActivityStateCondition(ByteBuffer _bb, ICheckActivityStateCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017001 RID: 94209 RVA: 0x00347BE1 File Offset: 0x00345DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017002 RID: 94210 RVA: 0x00347BF0 File Offset: 0x00345DF0
		public ICheckActivityStateCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700714F RID: 29007
		// (get) Token: 0x06017003 RID: 94211 RVA: 0x00347C00 File Offset: 0x00345E00
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

		// Token: 0x17007150 RID: 29008
		// (get) Token: 0x06017004 RID: 94212 RVA: 0x00347C3C File Offset: 0x00345E3C
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

		// Token: 0x17007151 RID: 29009
		// (get) Token: 0x06017005 RID: 94213 RVA: 0x00347C9C File Offset: 0x00345E9C
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

		// Token: 0x17007152 RID: 29010
		// (get) Token: 0x06017006 RID: 94214 RVA: 0x00347CD8 File Offset: 0x00345ED8
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

		// Token: 0x17007153 RID: 29011
		// (get) Token: 0x06017007 RID: 94215 RVA: 0x00347D18 File Offset: 0x00345F18
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

		// Token: 0x06017008 RID: 94216 RVA: 0x00347D55 File Offset: 0x00345F55
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

		// Token: 0x06017009 RID: 94217 RVA: 0x00347D89 File Offset: 0x00345F89
		public static void StartICheckActivityStateCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601700A RID: 94218 RVA: 0x00347D92 File Offset: 0x00345F92
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601700B RID: 94219 RVA: 0x00347D9D File Offset: 0x00345F9D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601700C RID: 94220 RVA: 0x00347DAD File Offset: 0x00345FAD
		public static void AddActivityId(FlatBufferBuilder builder, int activityId)
		{
			builder.AddInt(2, activityId, 0);
		}

		// Token: 0x0601700D RID: 94221 RVA: 0x00347DB8 File Offset: 0x00345FB8
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601700E RID: 94222 RVA: 0x00347DC3 File Offset: 0x00345FC3
		public static void AddActivityState(FlatBufferBuilder builder, EActivityState activityState)
		{
			builder.AddByte(4, (byte)activityState, 0);
		}

		// Token: 0x0601700F RID: 94223 RVA: 0x00347DCE File Offset: 0x00345FCE
		public static Offset<ICheckActivityStateCondition> EndICheckActivityStateCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckActivityStateCondition>(builder.EndTable());
		}

		// Token: 0x06017010 RID: 94224 RVA: 0x00347DDC File Offset: 0x00345FDC
		public ICheckActivityStateConditionT UnPack()
		{
			ICheckActivityStateConditionT checkActivityStateConditionT = new ICheckActivityStateConditionT();
			this.UnPackTo(checkActivityStateConditionT);
			return checkActivityStateConditionT;
		}

		// Token: 0x06017011 RID: 94225 RVA: 0x00347DF8 File Offset: 0x00345FF8
		public void UnPackTo(ICheckActivityStateConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ActivityId = this.ActivityId;
			_o.Compare = this.Compare;
			_o.ActivityState = this.ActivityState;
		}

		// Token: 0x06017012 RID: 94226 RVA: 0x00347E64 File Offset: 0x00346064
		public static Offset<ICheckActivityStateCondition> Pack(FlatBufferBuilder builder, ICheckActivityStateConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckActivityStateCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ICheckActivityStateCondition.CreateICheckActivityStateCondition(builder, _o.Type, preConditionsOffset, _o.ActivityId, _o.Compare, _o.ActivityState);
		}

		// Token: 0x0400BFC5 RID: 49093
		private Table __p;
	}
}
