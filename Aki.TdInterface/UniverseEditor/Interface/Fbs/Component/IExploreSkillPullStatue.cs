using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005763 RID: 22371
	public struct IExploreSkillPullStatue : IFlatbufferObject
	{
		// Token: 0x1700A1B7 RID: 41399
		// (get) Token: 0x0602411A RID: 147738 RVA: 0x004F6113 File Offset: 0x004F4313
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602411B RID: 147739 RVA: 0x004F6120 File Offset: 0x004F4320
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602411C RID: 147740 RVA: 0x004F6128 File Offset: 0x004F4328
		public static IExploreSkillPullStatue GetRootAsIExploreSkillPullStatue(ByteBuffer _bb)
		{
			return IExploreSkillPullStatue.GetRootAsIExploreSkillPullStatue(_bb, default(IExploreSkillPullStatue));
		}

		// Token: 0x0602411D RID: 147741 RVA: 0x004F6144 File Offset: 0x004F4344
		public static IExploreSkillPullStatue GetRootAsIExploreSkillPullStatue(ByteBuffer _bb, IExploreSkillPullStatue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602411E RID: 147742 RVA: 0x004F6161 File Offset: 0x004F4361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602411F RID: 147743 RVA: 0x004F6170 File Offset: 0x004F4370
		public IExploreSkillPullStatue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1B8 RID: 41400
		// (get) Token: 0x06024120 RID: 147744 RVA: 0x004F6180 File Offset: 0x004F4380
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A1B9 RID: 41401
		// (get) Token: 0x06024121 RID: 147745 RVA: 0x004F61BC File Offset: 0x004F43BC
		public ICategoryMatchingCondition? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingCondition?(default(ICategoryMatchingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A1BA RID: 41402
		// (get) Token: 0x06024122 RID: 147746 RVA: 0x004F621C File Offset: 0x004F441C
		public int StatueInteractPointId
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

		// Token: 0x06024123 RID: 147747 RVA: 0x004F6258 File Offset: 0x004F4458
		public static Offset<IExploreSkillPullStatue> CreateIExploreSkillPullStatue(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), int StatueInteractPointId = 0)
		{
			builder.StartTable(3);
			IExploreSkillPullStatue.AddStatueInteractPointId(builder, StatueInteractPointId);
			IExploreSkillPullStatue.AddCondition(builder, ConditionOffset);
			IExploreSkillPullStatue.AddType(builder, Type);
			return IExploreSkillPullStatue.EndIExploreSkillPullStatue(builder);
		}

		// Token: 0x06024124 RID: 147748 RVA: 0x004F627C File Offset: 0x004F447C
		public static void StartIExploreSkillPullStatue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024125 RID: 147749 RVA: 0x004F6285 File Offset: 0x004F4485
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024126 RID: 147750 RVA: 0x004F6290 File Offset: 0x004F4490
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06024127 RID: 147751 RVA: 0x004F62A0 File Offset: 0x004F44A0
		public static void AddStatueInteractPointId(FlatBufferBuilder builder, int statueInteractPointId)
		{
			builder.AddInt(2, statueInteractPointId, 0);
		}

		// Token: 0x06024128 RID: 147752 RVA: 0x004F62AB File Offset: 0x004F44AB
		public static Offset<IExploreSkillPullStatue> EndIExploreSkillPullStatue(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillPullStatue>(builder.EndTable());
		}

		// Token: 0x06024129 RID: 147753 RVA: 0x004F62B8 File Offset: 0x004F44B8
		public IExploreSkillPullStatueT UnPack()
		{
			IExploreSkillPullStatueT exploreSkillPullStatueT = new IExploreSkillPullStatueT();
			this.UnPackTo(exploreSkillPullStatueT);
			return exploreSkillPullStatueT;
		}

		// Token: 0x0602412A RID: 147754 RVA: 0x004F62D4 File Offset: 0x004F44D4
		public void UnPackTo(IExploreSkillPullStatueT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.StatueInteractPointId = this.StatueInteractPointId;
		}

		// Token: 0x0602412B RID: 147755 RVA: 0x004F6328 File Offset: 0x004F4528
		public static Offset<IExploreSkillPullStatue> Pack(FlatBufferBuilder builder, IExploreSkillPullStatueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillPullStatue>);
			}
			Offset<ICategoryMatchingCondition> conditionOffset = (_o.Condition == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.Condition);
			return IExploreSkillPullStatue.CreateIExploreSkillPullStatue(builder, _o.Type, conditionOffset, _o.StatueInteractPointId);
		}

		// Token: 0x0400EF31 RID: 61233
		private Table __p;
	}
}
