using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F4 RID: 29684
	public struct IToggleAndHighlightItem : IFlatbufferObject
	{
		// Token: 0x1700E16D RID: 57709
		// (get) Token: 0x06035EB5 RID: 220853 RVA: 0x00756788 File Offset: 0x00754988
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035EB6 RID: 220854 RVA: 0x00756795 File Offset: 0x00754995
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035EB7 RID: 220855 RVA: 0x0075679C File Offset: 0x0075499C
		public static IToggleAndHighlightItem GetRootAsIToggleAndHighlightItem(ByteBuffer _bb)
		{
			return IToggleAndHighlightItem.GetRootAsIToggleAndHighlightItem(_bb, default(IToggleAndHighlightItem));
		}

		// Token: 0x06035EB8 RID: 220856 RVA: 0x007567B8 File Offset: 0x007549B8
		public static IToggleAndHighlightItem GetRootAsIToggleAndHighlightItem(ByteBuffer _bb, IToggleAndHighlightItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035EB9 RID: 220857 RVA: 0x007567D5 File Offset: 0x007549D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035EBA RID: 220858 RVA: 0x007567E4 File Offset: 0x007549E4
		public IToggleAndHighlightItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E16E RID: 57710
		// (get) Token: 0x06035EBB RID: 220859 RVA: 0x007567F4 File Offset: 0x007549F4
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

		// Token: 0x1700E16F RID: 57711
		// (get) Token: 0x06035EBC RID: 220860 RVA: 0x00756830 File Offset: 0x00754A30
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

		// Token: 0x1700E170 RID: 57712
		// (get) Token: 0x06035EBD RID: 220861 RVA: 0x0075686C File Offset: 0x00754A6C
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

		// Token: 0x1700E171 RID: 57713
		// (get) Token: 0x06035EBE RID: 220862 RVA: 0x007568A8 File Offset: 0x00754AA8
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

		// Token: 0x1700E172 RID: 57714
		// (get) Token: 0x06035EBF RID: 220863 RVA: 0x007568E8 File Offset: 0x00754AE8
		public bool IsShowTips
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E173 RID: 57715
		// (get) Token: 0x06035EC0 RID: 220864 RVA: 0x00756928 File Offset: 0x00754B28
		public bool IsSwitchBack
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E174 RID: 57716
		// (get) Token: 0x06035EC1 RID: 220865 RVA: 0x00756968 File Offset: 0x00754B68
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

		// Token: 0x06035EC2 RID: 220866 RVA: 0x007569A8 File Offset: 0x00754BA8
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

		// Token: 0x06035EC3 RID: 220867 RVA: 0x007569F7 File Offset: 0x00754BF7
		public static void StartIToggleAndHighlightItem(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06035EC4 RID: 220868 RVA: 0x00756A00 File Offset: 0x00754C00
		public static void AddType(FlatBufferBuilder builder, EHighlightExploreSkillIconType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035EC5 RID: 220869 RVA: 0x00756A0B File Offset: 0x00754C0B
		public static void AddHighlightType(FlatBufferBuilder builder, EHighlightType highlightType)
		{
			builder.AddByte(1, (byte)highlightType, 0);
		}

		// Token: 0x06035EC6 RID: 220870 RVA: 0x00756A16 File Offset: 0x00754C16
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(2, itemId, 0);
		}

		// Token: 0x06035EC7 RID: 220871 RVA: 0x00756A21 File Offset: 0x00754C21
		public static void AddSkillType(FlatBufferBuilder builder, int skillType)
		{
			builder.AddInt(3, skillType, 0);
		}

		// Token: 0x06035EC8 RID: 220872 RVA: 0x00756A2C File Offset: 0x00754C2C
		public static void AddIsShowTips(FlatBufferBuilder builder, bool isShowTips)
		{
			builder.AddBool(4, isShowTips, false);
		}

		// Token: 0x06035EC9 RID: 220873 RVA: 0x00756A37 File Offset: 0x00754C37
		public static void AddIsSwitchBack(FlatBufferBuilder builder, bool isSwitchBack)
		{
			builder.AddBool(5, isSwitchBack, false);
		}

		// Token: 0x06035ECA RID: 220874 RVA: 0x00756A42 File Offset: 0x00754C42
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06035ECB RID: 220875 RVA: 0x00756A4D File Offset: 0x00754C4D
		public static Offset<IToggleAndHighlightItem> EndIToggleAndHighlightItem(FlatBufferBuilder builder)
		{
			return new Offset<IToggleAndHighlightItem>(builder.EndTable());
		}

		// Token: 0x06035ECC RID: 220876 RVA: 0x00756A5C File Offset: 0x00754C5C
		public IToggleAndHighlightItemT UnPack()
		{
			IToggleAndHighlightItemT toggleAndHighlightItemT = new IToggleAndHighlightItemT();
			this.UnPackTo(toggleAndHighlightItemT);
			return toggleAndHighlightItemT;
		}

		// Token: 0x06035ECD RID: 220877 RVA: 0x00756A78 File Offset: 0x00754C78
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

		// Token: 0x06035ECE RID: 220878 RVA: 0x00756ADC File Offset: 0x00754CDC
		public static Offset<IToggleAndHighlightItem> Pack(FlatBufferBuilder builder, IToggleAndHighlightItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToggleAndHighlightItem>);
			}
			return IToggleAndHighlightItem.CreateIToggleAndHighlightItem(builder, _o.Type, _o.HighlightType, _o.ItemId, _o.SkillType, _o.IsShowTips, _o.IsSwitchBack, _o.NullMask);
		}

		// Token: 0x04012251 RID: 74321
		private Table __p;
	}
}
