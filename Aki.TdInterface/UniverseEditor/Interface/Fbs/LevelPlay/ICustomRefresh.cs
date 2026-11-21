using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B7 RID: 18615
	public struct ICustomRefresh : IFlatbufferObject
	{
		// Token: 0x17008178 RID: 33144
		// (get) Token: 0x0601B82D RID: 112685 RVA: 0x003E438E File Offset: 0x003E258E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B82E RID: 112686 RVA: 0x003E439B File Offset: 0x003E259B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B82F RID: 112687 RVA: 0x003E43A4 File Offset: 0x003E25A4
		public static ICustomRefresh GetRootAsICustomRefresh(ByteBuffer _bb)
		{
			return ICustomRefresh.GetRootAsICustomRefresh(_bb, default(ICustomRefresh));
		}

		// Token: 0x0601B830 RID: 112688 RVA: 0x003E43C0 File Offset: 0x003E25C0
		public static ICustomRefresh GetRootAsICustomRefresh(ByteBuffer _bb, ICustomRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B831 RID: 112689 RVA: 0x003E43DD File Offset: 0x003E25DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B832 RID: 112690 RVA: 0x003E43EC File Offset: 0x003E25EC
		public ICustomRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008179 RID: 33145
		// (get) Token: 0x0601B833 RID: 112691 RVA: 0x003E43FC File Offset: 0x003E25FC
		public ELevelPlayRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRefreshType.None;
				}
				return (ELevelPlayRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700817A RID: 33146
		// (get) Token: 0x0601B834 RID: 112692 RVA: 0x003E4438 File Offset: 0x003E2638
		public IConditionGroup? PreCondition
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

		// Token: 0x1700817B RID: 33147
		// (get) Token: 0x0601B835 RID: 112693 RVA: 0x003E4498 File Offset: 0x003E2698
		public int CompletedRefreshTime
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

		// Token: 0x1700817C RID: 33148
		// (get) Token: 0x0601B836 RID: 112694 RVA: 0x003E44D4 File Offset: 0x003E26D4
		public int ChildDestroyRefreshTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700817D RID: 33149
		// (get) Token: 0x0601B837 RID: 112695 RVA: 0x003E4514 File Offset: 0x003E2714
		public int AwardedRefreshTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700817E RID: 33150
		// (get) Token: 0x0601B838 RID: 112696 RVA: 0x003E4554 File Offset: 0x003E2754
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B839 RID: 112697 RVA: 0x003E4591 File Offset: 0x003E2791
		public static Offset<ICustomRefresh> CreateICustomRefresh(FlatBufferBuilder builder, ELevelPlayRefreshType Type = ELevelPlayRefreshType.None, Offset<IConditionGroup> PreConditionOffset = default(Offset<IConditionGroup>), int CompletedRefreshTime = 0, int ChildDestroyRefreshTime = 0, int AwardedRefreshTime = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			ICustomRefresh.AddAwardedRefreshTime(builder, AwardedRefreshTime);
			ICustomRefresh.AddChildDestroyRefreshTime(builder, ChildDestroyRefreshTime);
			ICustomRefresh.AddCompletedRefreshTime(builder, CompletedRefreshTime);
			ICustomRefresh.AddPreCondition(builder, PreConditionOffset);
			ICustomRefresh.AddNullMask(builder, NullMask);
			ICustomRefresh.AddType(builder, Type);
			return ICustomRefresh.EndICustomRefresh(builder);
		}

		// Token: 0x0601B83A RID: 112698 RVA: 0x003E45CD File Offset: 0x003E27CD
		public static void StartICustomRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B83B RID: 112699 RVA: 0x003E45D6 File Offset: 0x003E27D6
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B83C RID: 112700 RVA: 0x003E45E1 File Offset: 0x003E27E1
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionOffset)
		{
			builder.AddOffset(1, preConditionOffset.Value, 0);
		}

		// Token: 0x0601B83D RID: 112701 RVA: 0x003E45F1 File Offset: 0x003E27F1
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(2, completedRefreshTime, 0);
		}

		// Token: 0x0601B83E RID: 112702 RVA: 0x003E45FC File Offset: 0x003E27FC
		public static void AddChildDestroyRefreshTime(FlatBufferBuilder builder, int childDestroyRefreshTime)
		{
			builder.AddInt(3, childDestroyRefreshTime, 0);
		}

		// Token: 0x0601B83F RID: 112703 RVA: 0x003E4607 File Offset: 0x003E2807
		public static void AddAwardedRefreshTime(FlatBufferBuilder builder, int awardedRefreshTime)
		{
			builder.AddInt(4, awardedRefreshTime, 0);
		}

		// Token: 0x0601B840 RID: 112704 RVA: 0x003E4612 File Offset: 0x003E2812
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601B841 RID: 112705 RVA: 0x003E461D File Offset: 0x003E281D
		public static Offset<ICustomRefresh> EndICustomRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICustomRefresh>(builder.EndTable());
		}

		// Token: 0x0601B842 RID: 112706 RVA: 0x003E462C File Offset: 0x003E282C
		public ICustomRefreshT UnPack()
		{
			ICustomRefreshT customRefreshT = new ICustomRefreshT();
			this.UnPackTo(customRefreshT);
			return customRefreshT;
		}

		// Token: 0x0601B843 RID: 112707 RVA: 0x003E4648 File Offset: 0x003E2848
		public void UnPackTo(ICustomRefreshT _o)
		{
			_o.Type = this.Type;
			_o.PreCondition = ((this.PreCondition != null) ? this.PreCondition.Value.UnPack() : null);
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.ChildDestroyRefreshTime = this.ChildDestroyRefreshTime;
			_o.AwardedRefreshTime = this.AwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B844 RID: 112708 RVA: 0x003E46C0 File Offset: 0x003E28C0
		public static Offset<ICustomRefresh> Pack(FlatBufferBuilder builder, ICustomRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomRefresh>);
			}
			Offset<IConditionGroup> preConditionOffset = (_o.PreCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreCondition);
			return ICustomRefresh.CreateICustomRefresh(builder, _o.Type, preConditionOffset, _o.CompletedRefreshTime, _o.ChildDestroyRefreshTime, _o.AwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400CE4E RID: 52814
		private Table __p;
	}
}
