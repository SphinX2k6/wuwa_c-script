using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FB RID: 20987
	public struct IExploreSkillPullStatue : IFlatbufferObject
	{
		// Token: 0x170099BB RID: 39355
		// (get) Token: 0x06022184 RID: 139652 RVA: 0x004BB64F File Offset: 0x004B984F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022185 RID: 139653 RVA: 0x004BB65C File Offset: 0x004B985C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022186 RID: 139654 RVA: 0x004BB664 File Offset: 0x004B9864
		public static IExploreSkillPullStatue GetRootAsIExploreSkillPullStatue(ByteBuffer _bb)
		{
			return IExploreSkillPullStatue.GetRootAsIExploreSkillPullStatue(_bb, default(IExploreSkillPullStatue));
		}

		// Token: 0x06022187 RID: 139655 RVA: 0x004BB680 File Offset: 0x004B9880
		public static IExploreSkillPullStatue GetRootAsIExploreSkillPullStatue(ByteBuffer _bb, IExploreSkillPullStatue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022188 RID: 139656 RVA: 0x004BB69D File Offset: 0x004B989D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022189 RID: 139657 RVA: 0x004BB6AC File Offset: 0x004B98AC
		public IExploreSkillPullStatue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099BC RID: 39356
		// (get) Token: 0x0602218A RID: 139658 RVA: 0x004BB6BC File Offset: 0x004B98BC
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

		// Token: 0x170099BD RID: 39357
		// (get) Token: 0x0602218B RID: 139659 RVA: 0x004BB6F8 File Offset: 0x004B98F8
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

		// Token: 0x170099BE RID: 39358
		// (get) Token: 0x0602218C RID: 139660 RVA: 0x004BB758 File Offset: 0x004B9958
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

		// Token: 0x0602218D RID: 139661 RVA: 0x004BB794 File Offset: 0x004B9994
		public static Offset<IExploreSkillPullStatue> CreateIExploreSkillPullStatue(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), int StatueInteractPointId = 0)
		{
			builder.StartTable(3);
			IExploreSkillPullStatue.AddStatueInteractPointId(builder, StatueInteractPointId);
			IExploreSkillPullStatue.AddCondition(builder, ConditionOffset);
			IExploreSkillPullStatue.AddType(builder, Type);
			return IExploreSkillPullStatue.EndIExploreSkillPullStatue(builder);
		}

		// Token: 0x0602218E RID: 139662 RVA: 0x004BB7B8 File Offset: 0x004B99B8
		public static void StartIExploreSkillPullStatue(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602218F RID: 139663 RVA: 0x004BB7C1 File Offset: 0x004B99C1
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022190 RID: 139664 RVA: 0x004BB7CC File Offset: 0x004B99CC
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06022191 RID: 139665 RVA: 0x004BB7DC File Offset: 0x004B99DC
		public static void AddStatueInteractPointId(FlatBufferBuilder builder, int statueInteractPointId)
		{
			builder.AddInt(2, statueInteractPointId, 0);
		}

		// Token: 0x06022192 RID: 139666 RVA: 0x004BB7E7 File Offset: 0x004B99E7
		public static Offset<IExploreSkillPullStatue> EndIExploreSkillPullStatue(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillPullStatue>(builder.EndTable());
		}

		// Token: 0x06022193 RID: 139667 RVA: 0x004BB7F4 File Offset: 0x004B99F4
		public IExploreSkillPullStatueT UnPack()
		{
			IExploreSkillPullStatueT exploreSkillPullStatueT = new IExploreSkillPullStatueT();
			this.UnPackTo(exploreSkillPullStatueT);
			return exploreSkillPullStatueT;
		}

		// Token: 0x06022194 RID: 139668 RVA: 0x004BB810 File Offset: 0x004B9A10
		public void UnPackTo(IExploreSkillPullStatueT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.StatueInteractPointId = this.StatueInteractPointId;
		}

		// Token: 0x06022195 RID: 139669 RVA: 0x004BB864 File Offset: 0x004B9A64
		public static Offset<IExploreSkillPullStatue> Pack(FlatBufferBuilder builder, IExploreSkillPullStatueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillPullStatue>);
			}
			Offset<ICategoryMatchingCondition> conditionOffset = (_o.Condition == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.Condition);
			return IExploreSkillPullStatue.CreateIExploreSkillPullStatue(builder, _o.Type, conditionOffset, _o.StatueInteractPointId);
		}

		// Token: 0x0400E32B RID: 58155
		private Table __p;
	}
}
