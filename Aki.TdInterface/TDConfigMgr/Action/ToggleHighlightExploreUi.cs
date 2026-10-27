using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002246 RID: 8774
	[NullableContext(1)]
	[Nullable(0)]
	public class ToggleHighlightExploreUi : ActionParams
	{
		// Token: 0x0600C08C RID: 49292 RVA: 0x001BA464 File Offset: 0x001B8664
		private ToggleHighlightExploreUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ToggleHighlightExploreUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ToggleHighlightExploreUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ToggleHighlightExploreUi_SetValue());
			}
			return result;
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x001BA49C File Offset: 0x001B869C
		public static ToggleHighlightExploreUi Create([Nullable(2)] ToggleHighlightExploreUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ToggleHighlightExploreUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x001BA4AF File Offset: 0x001B86AF
		public static ToggleHighlightExploreUi CreateFromSetValue([Nullable(2)] ToggleHighlightExploreUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ToggleHighlightExploreUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x001BA4C2 File Offset: 0x001B86C2
		public ToggleHighlightExploreUi_SetValue ToSetValue()
		{
			return new ToggleHighlightExploreUi_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType
			};
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600C090 RID: 49296 RVA: 0x001BA4E1 File Offset: 0x001B86E1
		// (set) Token: 0x0600C091 RID: 49297 RVA: 0x001BA50C File Offset: 0x001B870C
		public virtual EHighlightExploreSkillIconType Type
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

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600C092 RID: 49298 RVA: 0x001BA51C File Offset: 0x001B871C
		// (set) Token: 0x0600C093 RID: 49299 RVA: 0x001BA556 File Offset: 0x001B8756
		public virtual EHighlightType? HighlightType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightType;
				}
				ToggleHighlightExploreUi_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040072CA RID: 29386
		[Nullable(2)]
		protected new ToggleHighlightExploreUi FbInstance;

		// Token: 0x040072CB RID: 29387
		[Nullable(2)]
		protected ToggleHighlightExploreUi_SetValue PocoInterface;
	}
}
