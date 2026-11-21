using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D0 RID: 8912
	public class IVisualNovelPerformanceExit : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C21E RID: 49694 RVA: 0x001BE7F0 File Offset: 0x001BC9F0
		private IVisualNovelPerformanceExit_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceExit 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceExit_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceExit_SetValue());
			}
			return result;
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x001BE828 File Offset: 0x001BCA28
		public static IVisualNovelPerformanceExit Create([Nullable(2)] IVisualNovelPerformanceExit instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceExit
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x001BE83B File Offset: 0x001BCA3B
		public static IVisualNovelPerformanceExit CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceExit_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceExit
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x001BE850 File Offset: 0x001BCA50
		public new IVisualNovelPerformanceExit_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceExit_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				WhoId = this.WhoId,
				AllExit = this.AllExit,
				FadeOutTime = this.FadeOutTime,
				RoleConfig = this.RoleConfig
			};
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600C222 RID: 49698 RVA: 0x001BE8AA File Offset: 0x001BCAAA
		// (set) Token: 0x0600C223 RID: 49699 RVA: 0x001BE8D5 File Offset: 0x001BCAD5
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600C224 RID: 49700 RVA: 0x001BE8E4 File Offset: 0x001BCAE4
		// (set) Token: 0x0600C225 RID: 49701 RVA: 0x001BE91E File Offset: 0x001BCB1E
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceExit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600C226 RID: 49702 RVA: 0x001BE92C File Offset: 0x001BCB2C
		// (set) Token: 0x0600C227 RID: 49703 RVA: 0x001BE957 File Offset: 0x001BCB57
		public virtual int WhoId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WhoId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WhoId;
			}
			set
			{
				this.GetOrCreatePoco().WhoId = value;
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600C228 RID: 49704 RVA: 0x001BE968 File Offset: 0x001BCB68
		// (set) Token: 0x0600C229 RID: 49705 RVA: 0x001BE9A2 File Offset: 0x001BCBA2
		public virtual bool? AllExit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AllExit;
				}
				IVisualNovelPerformanceExit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AllExit;
			}
			set
			{
				this.GetOrCreatePoco().AllExit = value;
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600C22A RID: 49706 RVA: 0x001BE9B0 File Offset: 0x001BCBB0
		// (set) Token: 0x0600C22B RID: 49707 RVA: 0x001BE9EA File Offset: 0x001BCBEA
		public virtual float? FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				IVisualNovelPerformanceExit_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600C22C RID: 49708 RVA: 0x001BE9F8 File Offset: 0x001BCBF8
		// (set) Token: 0x0600C22D RID: 49709 RVA: 0x001BEA59 File Offset: 0x001BCC59
		[Nullable(2)]
		public virtual IVisualNovelRoleConfig RoleConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._RoleConfigInited)
				{
					return this._RoleConfigCache;
				}
				this._RoleConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RoleConfigCache = IVisualNovelRoleConfig.Create(this.FbInstance.RoleConfig);
				}
				else
				{
					IVisualNovelPerformanceExit_SetValue pocoInterface = this.PocoInterface;
					this._RoleConfigCache = ((pocoInterface != null) ? pocoInterface.RoleConfig : null);
				}
				return this._RoleConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().RoleConfig = value;
				this._RoleConfigInited = false;
			}
		}

		// Token: 0x040073E6 RID: 29670
		[Nullable(2)]
		protected new IVisualNovelPerformanceExit FbInstance;

		// Token: 0x040073E7 RID: 29671
		[Nullable(2)]
		protected new IVisualNovelPerformanceExit_SetValue PocoInterface;

		// Token: 0x040073E8 RID: 29672
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x040073E9 RID: 29673
		private bool _RoleConfigInited;
	}
}
