using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BDE RID: 31710
	public struct IToggleAndHighlightItem : IFlatbufferObject
	{
		// Token: 0x1700ED82 RID: 60802
		// (get) Token: 0x06039268 RID: 234088 RVA: 0x007B8EFC File Offset: 0x007B70FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039269 RID: 234089 RVA: 0x007B8F09 File Offset: 0x007B7109
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603926A RID: 234090 RVA: 0x007B8F10 File Offset: 0x007B7110
		public static IToggleAndHighlightItem GetRootAsIToggleAndHighlightItem(ByteBuffer _bb)
		{
			return IToggleAndHighlightItem.GetRootAsIToggleAndHighlightItem(_bb, default(IToggleAndHighlightItem));
		}

		// Token: 0x0603926B RID: 234091 RVA: 0x007B8F2C File Offset: 0x007B712C
		public static IToggleAndHighlightItem GetRootAsIToggleAndHighlightItem(ByteBuffer _bb, IToggleAndHighlightItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603926C RID: 234092 RVA: 0x007B8F49 File Offset: 0x007B7149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603926D RID: 234093 RVA: 0x007B8F58 File Offset: 0x007B7158
		public IToggleAndHighlightItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED83 RID: 60803
		// (get) Token: 0x0603926E RID: 234094 RVA: 0x007B8F68 File Offset: 0x007B7168
		public EHighlightExploreSkillIconType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHighlightExploreSkillIconType.Show;
				}
				return (EHighlightExploreSkillIconType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ED84 RID: 60804
		// (get) Token: 0x0603926F RID: 234095 RVA: 0x007B8FA4 File Offset: 0x007B71A4
		public EHighlightType HighlightType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EHighlightType.CommonWhite;
				}
				return (EHighlightType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700ED85 RID: 60805
		// (get) Token: 0x06039270 RID: 234096 RVA: 0x007B8FE0 File Offset: 0x007B71E0
		public int ItemId
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

		// Token: 0x1700ED86 RID: 60806
		// (get) Token: 0x06039271 RID: 234097 RVA: 0x007B901C File Offset: 0x007B721C
		public int SkillType
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

		// Token: 0x1700ED87 RID: 60807
		// (get) Token: 0x06039272 RID: 234098 RVA: 0x007B905C File Offset: 0x007B725C
		public bool IsShowTips
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED88 RID: 60808
		// (get) Token: 0x06039273 RID: 234099 RVA: 0x007B909C File Offset: 0x007B729C
		public bool IsSwitchBack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED89 RID: 60809
		// (get) Token: 0x06039274 RID: 234100 RVA: 0x007B90DC File Offset: 0x007B72DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039275 RID: 234101 RVA: 0x007B911C File Offset: 0x007B731C
		public static Offset<IToggleAndHighlightItem> CreateIToggleAndHighlightItem(FlatBufferBuilder builder, EHighlightExploreSkillIconType Type = EHighlightExploreSkillIconType.Show, EHighlightType HighlightType = EHighlightType.CommonWhite, int ItemId = 0, int SkillType = 0, bool IsShowTips = false, bool IsSwitchBack = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IToggleAndHighlightItem.AddSkillType(builder, SkillType);
			IToggleAndHighlightItem.AddItemId(builder, ItemId);
			IToggleAndHighlightItem.AddNullMask(builder, NullMask);
			IToggleAndHighlightItem.AddIsSwitchBack(builder, IsSwitchBack);
			IToggleAndHighlightItem.AddIsShowTips(builder, IsShowTips);
			IToggleAndHighlightItem.AddHighlightType(builder, HighlightType);
			IToggleAndHighlightItem.AddType(builder, Type);
			return IToggleAndHighlightItem.EndIToggleAndHighlightItem(builder);
		}

		// Token: 0x06039276 RID: 234102 RVA: 0x007B916B File Offset: 0x007B736B
		public static void StartIToggleAndHighlightItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06039277 RID: 234103 RVA: 0x007B9174 File Offset: 0x007B7374
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039278 RID: 234104 RVA: 0x007B917F File Offset: 0x007B737F
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06039279 RID: 234105 RVA: 0x007B918A File Offset: 0x007B738A
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(2, itemId, 0);
		}

		// Token: 0x0603927A RID: 234106 RVA: 0x007B9195 File Offset: 0x007B7395
		public static void AddSkillType(FlatBufferBuilder builder, int skillType)
		{
			builder.AddInt(3, skillType, 0);
		}

		// Token: 0x0603927B RID: 234107 RVA: 0x007B91A0 File Offset: 0x007B73A0
		public static void AddIsShowTips(FlatBufferBuilder builder, bool isShowTips)
		{
			builder.AddBool(4, isShowTips, false);
		}

		// Token: 0x0603927C RID: 234108 RVA: 0x007B91AB File Offset: 0x007B73AB
		public static void AddIsSwitchBack(FlatBufferBuilder builder, bool isSwitchBack)
		{
			builder.AddBool(5, isSwitchBack, false);
		}

		// Token: 0x0603927D RID: 234109 RVA: 0x007B91B6 File Offset: 0x007B73B6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603927E RID: 234110 RVA: 0x007B91C1 File Offset: 0x007B73C1
		public static Offset<IToggleAndHighlightItem> EndIToggleAndHighlightItem(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAndHighlightItem>(builder.EndTable());
		}

		// Token: 0x0603927F RID: 234111 RVA: 0x007B91D0 File Offset: 0x007B73D0
		public IToggleAndHighlightItemT UnPack()
		{
			IToggleAndHighlightItemT toggleAndHighlightItemT = new IToggleAndHighlightItemT();
			this.UnPackTo(toggleAndHighlightItemT);
			return toggleAndHighlightItemT;
		}

		// Token: 0x06039280 RID: 234112 RVA: 0x007B91EC File Offset: 0x007B73EC
		public void UnPackTo(IToggleAndHighlightItemT _o)
		{
			_o.Type = this.Type;
			_o.HighlightType = this.HighlightType;
			_o.ItemId = this.ItemId;
			_o.SkillType = this.SkillType;
			_o.IsShowTips = this.IsShowTips;
			_o.IsSwitchBack = this.IsSwitchBack;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039281 RID: 234113 RVA: 0x007B9250 File Offset: 0x007B7450
		public static Offset<IToggleAndHighlightItem> Pack(FlatBufferBuilder builder, IToggleAndHighlightItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleAndHighlightItem>);
			}
			return IToggleAndHighlightItem.CreateIToggleAndHighlightItem(builder, _o.Type, _o.HighlightType, _o.ItemId, _o.SkillType, _o.IsShowTips, _o.IsSwitchBack, _o.NullMask);
		}

		// Token: 0x0401326D RID: 78445
		private Table __p;
	}
}
