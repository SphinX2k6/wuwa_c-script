using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5A RID: 7770
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600A647 RID: 42567 RVA: 0x00178510 File Offset: 0x00176710
		private IShowHighlightExploreSkillIcon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowHighlightExploreSkillIcon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowHighlightExploreSkillIcon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowHighlightExploreSkillIcon_SetValue());
			}
			return result;
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x00178548 File Offset: 0x00176748
		public static IShowHighlightExploreSkillIcon Create([Nullable(2)] IShowHighlightExploreSkillIcon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowHighlightExploreSkillIcon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x0017855B File Offset: 0x0017675B
		public static IShowHighlightExploreSkillIcon CreateFromSetValue([Nullable(2)] IShowHighlightExploreSkillIcon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowHighlightExploreSkillIcon
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x00178570 File Offset: 0x00176770
		public new IShowHighlightExploreSkillIcon_SetValue ToSetValue()
		{
			return new IShowHighlightExploreSkillIcon_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType,
				SkillType = this.SkillType,
				Duration = this.Duration,
				IsSwitchBack = this.IsSwitchBack
			};
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600A64B RID: 42571 RVA: 0x001785BE File Offset: 0x001767BE
		// (set) Token: 0x0600A64C RID: 42572 RVA: 0x001785E9 File Offset: 0x001767E9
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

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600A64D RID: 42573 RVA: 0x001785F8 File Offset: 0x001767F8
		// (set) Token: 0x0600A64E RID: 42574 RVA: 0x00178632 File Offset: 0x00176832
		public override EHighlightType? HighlightType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightType;
				}
				IShowHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600A64F RID: 42575 RVA: 0x00178640 File Offset: 0x00176840
		// (set) Token: 0x0600A650 RID: 42576 RVA: 0x0017866B File Offset: 0x0017686B
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

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x00178679 File Offset: 0x00176879
		// (set) Token: 0x0600A652 RID: 42578 RVA: 0x001786A8 File Offset: 0x001768A8
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600A653 RID: 42579 RVA: 0x001786B8 File Offset: 0x001768B8
		// (set) Token: 0x0600A654 RID: 42580 RVA: 0x001786F2 File Offset: 0x001768F2
		public virtual bool? IsSwitchBack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSwitchBack;
				}
				IShowHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006354 RID: 25428
		[Nullable(2)]
		protected new IShowHighlightExploreSkillIcon FbInstance;

		// Token: 0x04006355 RID: 25429
		[Nullable(2)]
		protected new IShowHighlightExploreSkillIcon_SetValue PocoInterface;
	}
}
