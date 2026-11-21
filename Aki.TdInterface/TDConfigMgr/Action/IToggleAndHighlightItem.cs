using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200220F RID: 8719
	public class IToggleAndHighlightItem : ToggleHighlightExploreUi
	{
		// Token: 0x0600BE0C RID: 48652 RVA: 0x001B7300 File Offset: 0x001B5500
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

		// Token: 0x0600BE0D RID: 48653 RVA: 0x001B7338 File Offset: 0x001B5538
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

		// Token: 0x0600BE0E RID: 48654 RVA: 0x001B734B File Offset: 0x001B554B
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

		// Token: 0x0600BE0F RID: 48655 RVA: 0x001B7360 File Offset: 0x001B5560
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

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600BE10 RID: 48656 RVA: 0x001B73BA File Offset: 0x001B55BA
		// (set) Token: 0x0600BE11 RID: 48657 RVA: 0x001B73E5 File Offset: 0x001B55E5
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

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600BE12 RID: 48658 RVA: 0x001B73F4 File Offset: 0x001B55F4
		// (set) Token: 0x0600BE13 RID: 48659 RVA: 0x001B742E File Offset: 0x001B562E
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

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600BE14 RID: 48660 RVA: 0x001B743C File Offset: 0x001B563C
		// (set) Token: 0x0600BE15 RID: 48661 RVA: 0x001B7467 File Offset: 0x001B5667
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

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600BE16 RID: 48662 RVA: 0x001B7475 File Offset: 0x001B5675
		// (set) Token: 0x0600BE17 RID: 48663 RVA: 0x001B74A0 File Offset: 0x001B56A0
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

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600BE18 RID: 48664 RVA: 0x001B74B0 File Offset: 0x001B56B0
		// (set) Token: 0x0600BE19 RID: 48665 RVA: 0x001B74EA File Offset: 0x001B56EA
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

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600BE1A RID: 48666 RVA: 0x001B74F8 File Offset: 0x001B56F8
		// (set) Token: 0x0600BE1B RID: 48667 RVA: 0x001B7532 File Offset: 0x001B5732
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

		// Token: 0x04007208 RID: 29192
		[Nullable(2)]
		protected new IToggleAndHighlightItem FbInstance;

		// Token: 0x04007209 RID: 29193
		[Nullable(2)]
		protected new IToggleAndHighlightItem_SetValue PocoInterface;
	}
}
