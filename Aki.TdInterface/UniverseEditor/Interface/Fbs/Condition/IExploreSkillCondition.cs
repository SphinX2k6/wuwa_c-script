using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200510F RID: 20751
	public struct IExploreSkillCondition : IFlatbufferObject
	{
		// Token: 0x170094B7 RID: 38071
		// (get) Token: 0x060209EB RID: 133611 RVA: 0x00485C2E File Offset: 0x00483E2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060209EC RID: 133612 RVA: 0x00485C3B File Offset: 0x00483E3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060209ED RID: 133613 RVA: 0x00485C44 File Offset: 0x00483E44
		public static IExploreSkillCondition GetRootAsIExploreSkillCondition(ByteBuffer _bb)
		{
			return IExploreSkillCondition.GetRootAsIExploreSkillCondition(_bb, default(IExploreSkillCondition));
		}

		// Token: 0x060209EE RID: 133614 RVA: 0x00485C60 File Offset: 0x00483E60
		public static IExploreSkillCondition GetRootAsIExploreSkillCondition(ByteBuffer _bb, IExploreSkillCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060209EF RID: 133615 RVA: 0x00485C7D File Offset: 0x00483E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060209F0 RID: 133616 RVA: 0x00485C8C File Offset: 0x00483E8C
		public IExploreSkillCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094B8 RID: 38072
		// (get) Token: 0x060209F1 RID: 133617 RVA: 0x00485C9C File Offset: 0x00483E9C
		public EExploreSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillConditionType.PlayerAirBubbleEnabled;
				}
				return (EExploreSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060209F2 RID: 133618 RVA: 0x00485CD8 File Offset: 0x00483ED8
		public static Offset<IExploreSkillCondition> CreateIExploreSkillCondition(FlatBufferBuilder builder, EExploreSkillConditionType Type = EExploreSkillConditionType.PlayerAirBubbleEnabled)
		{
			builder.StartTable(1);
			IExploreSkillCondition.AddType(builder, Type);
			return IExploreSkillCondition.EndIExploreSkillCondition(builder);
		}

		// Token: 0x060209F3 RID: 133619 RVA: 0x00485CEE File Offset: 0x00483EEE
		public static void StartIExploreSkillCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060209F4 RID: 133620 RVA: 0x00485CF7 File Offset: 0x00483EF7
		public static void AddType(FlatBufferBuilder builder, EExploreSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060209F5 RID: 133621 RVA: 0x00485D02 File Offset: 0x00483F02
		public static Offset<IExploreSkillCondition> EndIExploreSkillCondition(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillCondition>(builder.EndTable());
		}

		// Token: 0x060209F6 RID: 133622 RVA: 0x00485D10 File Offset: 0x00483F10
		public IExploreSkillConditionT UnPack()
		{
			IExploreSkillConditionT exploreSkillConditionT = new IExploreSkillConditionT();
			this.UnPackTo(exploreSkillConditionT);
			return exploreSkillConditionT;
		}

		// Token: 0x060209F7 RID: 133623 RVA: 0x00485D2B File Offset: 0x00483F2B
		public void UnPackTo(IExploreSkillConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060209F8 RID: 133624 RVA: 0x00485D3C File Offset: 0x00483F3C
		public static Offset<IExploreSkillCondition> Pack(FlatBufferBuilder builder, IExploreSkillConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillCondition>);
			}
			return IExploreSkillCondition.CreateIExploreSkillCondition(builder, _o.Type);
		}

		// Token: 0x0400E0D1 RID: 57553
		private Table __p;
	}
}
