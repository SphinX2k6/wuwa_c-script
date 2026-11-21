using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B1 RID: 9393
	public class ToggleHighlightExploreUi : ActionParams
	{
		// Token: 0x0600CC4A RID: 52298 RVA: 0x001D1B30 File Offset: 0x001CFD30
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

		// Token: 0x0600CC4B RID: 52299 RVA: 0x001D1B68 File Offset: 0x001CFD68
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

		// Token: 0x0600CC4C RID: 52300 RVA: 0x001D1B7B File Offset: 0x001CFD7B
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

		// Token: 0x0600CC4D RID: 52301 RVA: 0x001D1B8E File Offset: 0x001CFD8E
		public ToggleHighlightExploreUi_SetValue ToSetValue()
		{
			return new ToggleHighlightExploreUi_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType
			};
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600CC4E RID: 52302 RVA: 0x001D1BAD File Offset: 0x001CFDAD
		// (set) Token: 0x0600CC4F RID: 52303 RVA: 0x001D1BD8 File Offset: 0x001CFDD8
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

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x001D1BE8 File Offset: 0x001CFDE8
		// (set) Token: 0x0600CC51 RID: 52305 RVA: 0x001D1C22 File Offset: 0x001CFE22
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

		// Token: 0x04007914 RID: 30996
		[Nullable(2)]
		protected new ToggleHighlightExploreUi FbInstance;

		// Token: 0x04007915 RID: 30997
		[Nullable(2)]
		protected ToggleHighlightExploreUi_SetValue PocoInterface;
	}
}
