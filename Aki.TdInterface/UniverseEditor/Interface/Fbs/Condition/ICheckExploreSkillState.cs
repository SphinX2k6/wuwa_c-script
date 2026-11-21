using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE1 RID: 20193
	public struct ICheckExploreSkillState : IFlatbufferObject
	{
		// Token: 0x1700902E RID: 36910
		// (get) Token: 0x0601F588 RID: 128392 RVA: 0x0045E1E4 File Offset: 0x0045C3E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F589 RID: 128393 RVA: 0x0045E1F1 File Offset: 0x0045C3F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F58A RID: 128394 RVA: 0x0045E1F8 File Offset: 0x0045C3F8
		public static ICheckExploreSkillState GetRootAsICheckExploreSkillState(ByteBuffer _bb)
		{
			return ICheckExploreSkillState.GetRootAsICheckExploreSkillState(_bb, default(ICheckExploreSkillState));
		}

		// Token: 0x0601F58B RID: 128395 RVA: 0x0045E214 File Offset: 0x0045C414
		public static ICheckExploreSkillState GetRootAsICheckExploreSkillState(ByteBuffer _bb, ICheckExploreSkillState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F58C RID: 128396 RVA: 0x0045E231 File Offset: 0x0045C431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F58D RID: 128397 RVA: 0x0045E240 File Offset: 0x0045C440
		public ICheckExploreSkillState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700902F RID: 36911
		// (get) Token: 0x0601F58E RID: 128398 RVA: 0x0045E250 File Offset: 0x0045C450
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009030 RID: 36912
		// (get) Token: 0x0601F58F RID: 128399 RVA: 0x0045E28C File Offset: 0x0045C48C
		public ICheckPlayerAirBubbleEnabled? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPlayerAirBubbleEnabled?(default(ICheckPlayerAirBubbleEnabled).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F590 RID: 128400 RVA: 0x0045E2E9 File Offset: 0x0045C4E9
		public static Offset<ICheckExploreSkillState> CreateICheckExploreSkillState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<ICheckPlayerAirBubbleEnabled> ConditionOffset = default(Offset<ICheckPlayerAirBubbleEnabled>))
		{
			builder.StartTable(2);
			ICheckExploreSkillState.AddCondition(builder, ConditionOffset);
			ICheckExploreSkillState.AddType(builder, Type);
			return ICheckExploreSkillState.EndICheckExploreSkillState(builder);
		}

		// Token: 0x0601F591 RID: 128401 RVA: 0x0045E306 File Offset: 0x0045C506
		public static void StartICheckExploreSkillState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F592 RID: 128402 RVA: 0x0045E30F File Offset: 0x0045C50F
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F593 RID: 128403 RVA: 0x0045E31A File Offset: 0x0045C51A
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICheckPlayerAirBubbleEnabled> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601F594 RID: 128404 RVA: 0x0045E32A File Offset: 0x0045C52A
		public static Offset<ICheckExploreSkillState> EndICheckExploreSkillState(FlatBufferBuilder builder)
		{
			return new Offset<ICheckExploreSkillState>(builder.EndTable());
		}

		// Token: 0x0601F595 RID: 128405 RVA: 0x0045E338 File Offset: 0x0045C538
		public ICheckExploreSkillStateT UnPack()
		{
			ICheckExploreSkillStateT checkExploreSkillStateT = new ICheckExploreSkillStateT();
			this.UnPackTo(checkExploreSkillStateT);
			return checkExploreSkillStateT;
		}

		// Token: 0x0601F596 RID: 128406 RVA: 0x0045E354 File Offset: 0x0045C554
		public void UnPackTo(ICheckExploreSkillStateT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x0601F597 RID: 128407 RVA: 0x0045E39C File Offset: 0x0045C59C
		public static Offset<ICheckExploreSkillState> Pack(FlatBufferBuilder builder, ICheckExploreSkillStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckExploreSkillState>);
			}
			Offset<ICheckPlayerAirBubbleEnabled> conditionOffset = (_o.Condition == null) ? default(Offset<ICheckPlayerAirBubbleEnabled>) : ICheckPlayerAirBubbleEnabled.Pack(builder, _o.Condition);
			return ICheckExploreSkillState.CreateICheckExploreSkillState(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400DD46 RID: 56646
		private Table __p;
	}
}
