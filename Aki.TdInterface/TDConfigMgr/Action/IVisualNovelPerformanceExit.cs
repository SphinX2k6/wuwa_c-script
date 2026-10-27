using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002085 RID: 8325
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceExit : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B6EE RID: 46830 RVA: 0x001A7F78 File Offset: 0x001A6178
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

		// Token: 0x0600B6EF RID: 46831 RVA: 0x001A7FB0 File Offset: 0x001A61B0
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

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x001A7FC3 File Offset: 0x001A61C3
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

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x001A7FD8 File Offset: 0x001A61D8
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

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600B6F2 RID: 46834 RVA: 0x001A8032 File Offset: 0x001A6232
		// (set) Token: 0x0600B6F3 RID: 46835 RVA: 0x001A805D File Offset: 0x001A625D
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

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600B6F4 RID: 46836 RVA: 0x001A806C File Offset: 0x001A626C
		// (set) Token: 0x0600B6F5 RID: 46837 RVA: 0x001A80A6 File Offset: 0x001A62A6
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

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600B6F6 RID: 46838 RVA: 0x001A80B4 File Offset: 0x001A62B4
		// (set) Token: 0x0600B6F7 RID: 46839 RVA: 0x001A80DF File Offset: 0x001A62DF
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

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600B6F8 RID: 46840 RVA: 0x001A80F0 File Offset: 0x001A62F0
		// (set) Token: 0x0600B6F9 RID: 46841 RVA: 0x001A812A File Offset: 0x001A632A
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

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600B6FA RID: 46842 RVA: 0x001A8138 File Offset: 0x001A6338
		// (set) Token: 0x0600B6FB RID: 46843 RVA: 0x001A8172 File Offset: 0x001A6372
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

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600B6FC RID: 46844 RVA: 0x001A8180 File Offset: 0x001A6380
		// (set) Token: 0x0600B6FD RID: 46845 RVA: 0x001A81E1 File Offset: 0x001A63E1
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

		// Token: 0x04006DD9 RID: 28121
		[Nullable(2)]
		protected new IVisualNovelPerformanceExit FbInstance;

		// Token: 0x04006DDA RID: 28122
		[Nullable(2)]
		protected new IVisualNovelPerformanceExit_SetValue PocoInterface;

		// Token: 0x04006DDB RID: 28123
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04006DDC RID: 28124
		private bool _RoleConfigInited;
	}
}
