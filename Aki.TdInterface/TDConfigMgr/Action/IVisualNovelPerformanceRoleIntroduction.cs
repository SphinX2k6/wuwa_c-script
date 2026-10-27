using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002091 RID: 8337
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceRoleIntroduction : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B750 RID: 46928 RVA: 0x001A8CC4 File Offset: 0x001A6EC4
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

		// Token: 0x0600B751 RID: 46929 RVA: 0x001A8CFC File Offset: 0x001A6EFC
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

		// Token: 0x0600B752 RID: 46930 RVA: 0x001A8D0F File Offset: 0x001A6F0F
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

		// Token: 0x0600B753 RID: 46931 RVA: 0x001A8D22 File Offset: 0x001A6F22
		public new IVisualNovelPerformanceRoleIntroduction_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceRoleIntroduction_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				RoleIntroductionConfig = this.RoleIntroductionConfig
			};
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x001A8D4D File Offset: 0x001A6F4D
		// (set) Token: 0x0600B755 RID: 46933 RVA: 0x001A8D78 File Offset: 0x001A6F78
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

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x001A8D88 File Offset: 0x001A6F88
		// (set) Token: 0x0600B757 RID: 46935 RVA: 0x001A8DC2 File Offset: 0x001A6FC2
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

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600B758 RID: 46936 RVA: 0x001A8DD0 File Offset: 0x001A6FD0
		// (set) Token: 0x0600B759 RID: 46937 RVA: 0x001A8E31 File Offset: 0x001A7031
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

		// Token: 0x04006E0E RID: 28174
		[Nullable(2)]
		protected new IVisualNovelPerformanceRoleIntroduction FbInstance;

		// Token: 0x04006E0F RID: 28175
		[Nullable(2)]
		protected new IVisualNovelPerformanceRoleIntroduction_SetValue PocoInterface;

		// Token: 0x04006E10 RID: 28176
		private IVisualNovelRoleIntroductionSolarSchool _RoleIntroductionConfigCache;

		// Token: 0x04006E11 RID: 28177
		private bool _RoleIntroductionConfigInited;
	}
}
