using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FCA RID: 8138
	[NullableContext(1)]
	[Nullable(0)]
	public class IToggleAndHighlightItem : ToggleHighlightExploreUi
	{
		// Token: 0x0600B2FE RID: 45822 RVA: 0x001A0E50 File Offset: 0x0019F050
		private IToggleAndHighlightItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleAndHighlightItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleAndHighlightItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleAndHighlightItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x001A0E88 File Offset: 0x0019F088
		public static IToggleAndHighlightItem Create([Nullable(2)] IToggleAndHighlightItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleAndHighlightItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B300 RID: 45824 RVA: 0x001A0E9B File Offset: 0x0019F09B
		public static IToggleAndHighlightItem CreateFromSetValue([Nullable(2)] IToggleAndHighlightItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleAndHighlightItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B301 RID: 45825 RVA: 0x001A0EB0 File Offset: 0x0019F0B0
		public new IToggleAndHighlightItem_SetValue ToSetValue()
		{
			return new IToggleAndHighlightItem_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType,
				ItemId = this.ItemId,
				SkillType = this.SkillType,
				IsShowTips = this.IsShowTips,
				IsSwitchBack = this.IsSwitchBack
			};
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x001A0F0A File Offset: 0x0019F10A
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x001A0F35 File Offset: 0x0019F135
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHighlightExploreSkillIconType.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x001A0F44 File Offset: 0x0019F144
		// (set) Token: 0x0600B305 RID: 45829 RVA: 0x001A0F7E File Offset: 0x0019F17E
		public override EHighlightType? HighlightType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightType;
				}
				IToggleAndHighlightItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HighlightType;
			}
			set
			{
				this.GetOrCreatePoco().HighlightType = value;
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x001A0F8C File Offset: 0x0019F18C
		// (set) Token: 0x0600B307 RID: 45831 RVA: 0x001A0FB7 File Offset: 0x0019F1B7
		public virtual int ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x001A0FC5 File Offset: 0x0019F1C5
		// (set) Token: 0x0600B309 RID: 45833 RVA: 0x001A0FF0 File Offset: 0x0019F1F0
		public virtual int SkillType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillType;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillType;
			}
			set
			{
				this.GetOrCreatePoco().SkillType = value;
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600B30A RID: 45834 RVA: 0x001A1000 File Offset: 0x0019F200
		// (set) Token: 0x0600B30B RID: 45835 RVA: 0x001A103A File Offset: 0x0019F23A
		public virtual bool? IsShowTips
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsShowTips;
				}
				IToggleAndHighlightItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsShowTips;
			}
			set
			{
				this.GetOrCreatePoco().IsShowTips = value;
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x001A1048 File Offset: 0x0019F248
		// (set) Token: 0x0600B30D RID: 45837 RVA: 0x001A1082 File Offset: 0x0019F282
		public virtual bool? IsSwitchBack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSwitchBack;
				}
				IToggleAndHighlightItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSwitchBack;
			}
			set
			{
				this.GetOrCreatePoco().IsSwitchBack = value;
			}
		}

		// Token: 0x04006C09 RID: 27657
		[Nullable(2)]
		protected new IToggleAndHighlightItem FbInstance;

		// Token: 0x04006C0A RID: 27658
		[Nullable(2)]
		protected new IToggleAndHighlightItem_SetValue PocoInterface;
	}
}
