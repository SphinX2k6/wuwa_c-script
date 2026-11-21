using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DC RID: 8924
	public class IVisualNovelPerformanceRoleIntroduction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C27E RID: 49790 RVA: 0x001BF4E4 File Offset: 0x001BD6E4
		private IVisualNovelPerformanceRoleIntroduction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceRoleIntroduction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceRoleIntroduction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceRoleIntroduction_SetValue());
			}
			return result;
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x001BF51C File Offset: 0x001BD71C
		public static IVisualNovelPerformanceRoleIntroduction Create([Nullable(2)] IVisualNovelPerformanceRoleIntroduction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceRoleIntroduction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x001BF52F File Offset: 0x001BD72F
		public static IVisualNovelPerformanceRoleIntroduction CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceRoleIntroduction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceRoleIntroduction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C281 RID: 49793 RVA: 0x001BF542 File Offset: 0x001BD742
		public new IVisualNovelPerformanceRoleIntroduction_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceRoleIntroduction_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				RoleIntroductionConfig = this.RoleIntroductionConfig
			};
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600C282 RID: 49794 RVA: 0x001BF56D File Offset: 0x001BD76D
		// (set) Token: 0x0600C283 RID: 49795 RVA: 0x001BF598 File Offset: 0x001BD798
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

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600C284 RID: 49796 RVA: 0x001BF5A8 File Offset: 0x001BD7A8
		// (set) Token: 0x0600C285 RID: 49797 RVA: 0x001BF5E2 File Offset: 0x001BD7E2
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceRoleIntroduction_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600C286 RID: 49798 RVA: 0x001BF5F0 File Offset: 0x001BD7F0
		// (set) Token: 0x0600C287 RID: 49799 RVA: 0x001BF651 File Offset: 0x001BD851
		public virtual IVisualNovelRoleIntroductionSolarSchool RoleIntroductionConfig
		{
			get
			{
				if (this._RoleIntroductionConfigInited)
				{
					return this._RoleIntroductionConfigCache;
				}
				this._RoleIntroductionConfigInited = true;
				if (this.FbInstance != null)
				{
					this._RoleIntroductionConfigCache = IVisualNovelRoleIntroductionSolarSchool.Create(this.FbInstance.RoleIntroductionConfig);
				}
				else
				{
					IVisualNovelPerformanceRoleIntroduction_SetValue pocoInterface = this.PocoInterface;
					this._RoleIntroductionConfigCache = ((pocoInterface != null) ? pocoInterface.RoleIntroductionConfig : null);
				}
				return this._RoleIntroductionConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RoleIntroductionConfig = value;
				this._RoleIntroductionConfigInited = false;
			}
		}

		// Token: 0x0400741A RID: 29722
		[Nullable(2)]
		protected new IVisualNovelPerformanceRoleIntroduction FbInstance;

		// Token: 0x0400741B RID: 29723
		[Nullable(2)]
		protected new IVisualNovelPerformanceRoleIntroduction_SetValue PocoInterface;

		// Token: 0x0400741C RID: 29724
		private IVisualNovelRoleIntroductionSolarSchool _RoleIntroductionConfigCache;

		// Token: 0x0400741D RID: 29725
		private bool _RoleIntroductionConfigInited;
	}
}
