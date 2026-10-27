using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200444F RID: 17487
	public struct ICustomRefresh : IFlatbufferObject
	{
		// Token: 0x17007B39 RID: 31545
		// (get) Token: 0x0601A05C RID: 106588 RVA: 0x003B8182 File Offset: 0x003B6382
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A05D RID: 106589 RVA: 0x003B818F File Offset: 0x003B638F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A05E RID: 106590 RVA: 0x003B8198 File Offset: 0x003B6398
		public static ICustomRefresh GetRootAsICustomRefresh(ByteBuffer _bb)
		{
			return ICustomRefresh.GetRootAsICustomRefresh(_bb, default(ICustomRefresh));
		}

		// Token: 0x0601A05F RID: 106591 RVA: 0x003B81B4 File Offset: 0x003B63B4
		public static ICustomRefresh GetRootAsICustomRefresh(ByteBuffer _bb, ICustomRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A060 RID: 106592 RVA: 0x003B81D1 File Offset: 0x003B63D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A061 RID: 106593 RVA: 0x003B81E0 File Offset: 0x003B63E0
		public ICustomRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B3A RID: 31546
		// (get) Token: 0x0601A062 RID: 106594 RVA: 0x003B81F0 File Offset: 0x003B63F0
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

		// Token: 0x17007B3B RID: 31547
		// (get) Token: 0x0601A063 RID: 106595 RVA: 0x003B822C File Offset: 0x003B642C
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

		// Token: 0x17007B3C RID: 31548
		// (get) Token: 0x0601A064 RID: 106596 RVA: 0x003B828C File Offset: 0x003B648C
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

		// Token: 0x17007B3D RID: 31549
		// (get) Token: 0x0601A065 RID: 106597 RVA: 0x003B82C8 File Offset: 0x003B64C8
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

		// Token: 0x17007B3E RID: 31550
		// (get) Token: 0x0601A066 RID: 106598 RVA: 0x003B8308 File Offset: 0x003B6508
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

		// Token: 0x17007B3F RID: 31551
		// (get) Token: 0x0601A067 RID: 106599 RVA: 0x003B8348 File Offset: 0x003B6548
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

		// Token: 0x0601A068 RID: 106600 RVA: 0x003B8385 File Offset: 0x003B6585
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

		// Token: 0x0601A069 RID: 106601 RVA: 0x003B83C1 File Offset: 0x003B65C1
		public static void StartICustomRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601A06A RID: 106602 RVA: 0x003B83CA File Offset: 0x003B65CA
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A06B RID: 106603 RVA: 0x003B83D5 File Offset: 0x003B65D5
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionOffset)
		{
			builder.AddOffset(1, preConditionOffset.Value, 0);
		}

		// Token: 0x0601A06C RID: 106604 RVA: 0x003B83E5 File Offset: 0x003B65E5
		public static void AddCompletedRefreshTime(FlatBufferBuilder builder, int completedRefreshTime)
		{
			builder.AddInt(2, completedRefreshTime, 0);
		}

		// Token: 0x0601A06D RID: 106605 RVA: 0x003B83F0 File Offset: 0x003B65F0
		public static void AddChildDestroyRefreshTime(FlatBufferBuilder builder, int childDestroyRefreshTime)
		{
			builder.AddInt(3, childDestroyRefreshTime, 0);
		}

		// Token: 0x0601A06E RID: 106606 RVA: 0x003B83FB File Offset: 0x003B65FB
		public static void AddAwardedRefreshTime(FlatBufferBuilder builder, int awardedRefreshTime)
		{
			builder.AddInt(4, awardedRefreshTime, 0);
		}

		// Token: 0x0601A06F RID: 106607 RVA: 0x003B8406 File Offset: 0x003B6606
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601A070 RID: 106608 RVA: 0x003B8411 File Offset: 0x003B6611
		public static Offset<ICustomRefresh> EndICustomRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ICustomRefresh>(builder.EndTable());
		}

		// Token: 0x0601A071 RID: 106609 RVA: 0x003B8420 File Offset: 0x003B6620
		public ICustomRefreshT UnPack()
		{
			ICustomRefreshT customRefreshT = new ICustomRefreshT();
			this.UnPackTo(customRefreshT);
			return customRefreshT;
		}

		// Token: 0x0601A072 RID: 106610 RVA: 0x003B843C File Offset: 0x003B663C
		public void UnPackTo(ICustomRefreshT _o)
		{
			_o.Type = this.Type;
			_o.PreCondition = ((this.PreCondition != null) ? this.PreCondition.Value.UnPack() : null);
			_o.CompletedRefreshTime = this.CompletedRefreshTime;
			_o.ChildDestroyRefreshTime = this.ChildDestroyRefreshTime;
			_o.AwardedRefreshTime = this.AwardedRefreshTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x003B84B4 File Offset: 0x003B66B4
		public static Offset<ICustomRefresh> Pack(FlatBufferBuilder builder, ICustomRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomRefresh>);
			}
			Offset<IConditionGroup> preConditionOffset = (_o.PreCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreCondition);
			return ICustomRefresh.CreateICustomRefresh(builder, _o.Type, preConditionOffset, _o.CompletedRefreshTime, _o.ChildDestroyRefreshTime, _o.AwardedRefreshTime, _o.NullMask);
		}

		// Token: 0x0400C420 RID: 50208
		private Table __p;
	}
}
