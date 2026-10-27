using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002089 RID: 8329
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B70E RID: 46862 RVA: 0x001A83B0 File Offset: 0x001A65B0
		[NullableContext(1)]
		private IVisualNovelPerformanceModifyRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceModifyRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceModifyRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceModifyRole_SetValue());
			}
			return result;
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x001A83E8 File Offset: 0x001A65E8
		[NullableContext(1)]
		public static IVisualNovelPerformanceModifyRole Create([Nullable(2)] IVisualNovelPerformanceModifyRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceModifyRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x001A83FB File Offset: 0x001A65FB
		[NullableContext(1)]
		public static IVisualNovelPerformanceModifyRole CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceModifyRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceModifyRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x001A8410 File Offset: 0x001A6610
		[NullableContext(1)]
		public new IVisualNovelPerformanceModifyRole_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceModifyRole_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				WhoId = this.WhoId,
				Transform = this.Transform,
				RoleConfig = this.RoleConfig
			};
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600B712 RID: 46866 RVA: 0x001A845E File Offset: 0x001A665E
		// (set) Token: 0x0600B713 RID: 46867 RVA: 0x001A8489 File Offset: 0x001A6689
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

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600B714 RID: 46868 RVA: 0x001A8498 File Offset: 0x001A6698
		// (set) Token: 0x0600B715 RID: 46869 RVA: 0x001A84D2 File Offset: 0x001A66D2
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceModifyRole_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600B716 RID: 46870 RVA: 0x001A84E0 File Offset: 0x001A66E0
		// (set) Token: 0x0600B717 RID: 46871 RVA: 0x001A850B File Offset: 0x001A670B
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

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600B718 RID: 46872 RVA: 0x001A851C File Offset: 0x001A671C
		// (set) Token: 0x0600B719 RID: 46873 RVA: 0x001A857D File Offset: 0x001A677D
		public virtual IVisualNovelPortraitTransform Transform
		{
			get
			{
				if (this._TransformInited)
				{
					return this._TransformCache;
				}
				this._TransformInited = true;
				if (this.FbInstance != null)
				{
					this._TransformCache = IVisualNovelPortraitTransform.Create(this.FbInstance.Transform);
				}
				else
				{
					IVisualNovelPerformanceModifyRole_SetValue pocoInterface = this.PocoInterface;
					this._TransformCache = ((pocoInterface != null) ? pocoInterface.Transform : null);
				}
				return this._TransformCache;
			}
			set
			{
				this.GetOrCreatePoco().Transform = value;
				this._TransformInited = false;
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600B71A RID: 46874 RVA: 0x001A8594 File Offset: 0x001A6794
		// (set) Token: 0x0600B71B RID: 46875 RVA: 0x001A85F5 File Offset: 0x001A67F5
		public virtual IVisualNovelRoleConfig RoleConfig
		{
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
					IVisualNovelPerformanceModifyRole_SetValue pocoInterface = this.PocoInterface;
					this._RoleConfigCache = ((pocoInterface != null) ? pocoInterface.RoleConfig : null);
				}
				return this._RoleConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().RoleConfig = value;
				this._RoleConfigInited = false;
			}
		}

		// Token: 0x04006DE9 RID: 28137
		protected new IVisualNovelPerformanceModifyRole FbInstance;

		// Token: 0x04006DEA RID: 28138
		protected new IVisualNovelPerformanceModifyRole_SetValue PocoInterface;

		// Token: 0x04006DEB RID: 28139
		[Nullable(1)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04006DEC RID: 28140
		private bool _TransformInited;

		// Token: 0x04006DED RID: 28141
		[Nullable(1)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04006DEE RID: 28142
		private bool _RoleConfigInited;
	}
}
