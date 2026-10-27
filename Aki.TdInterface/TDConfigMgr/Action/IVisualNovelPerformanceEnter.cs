using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002081 RID: 8321
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B6CC RID: 46796 RVA: 0x001A7AB0 File Offset: 0x001A5CB0
		[NullableContext(1)]
		private IVisualNovelPerformanceEnter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceEnter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceEnter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceEnter_SetValue());
			}
			return result;
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x001A7AE8 File Offset: 0x001A5CE8
		[NullableContext(1)]
		public static IVisualNovelPerformanceEnter Create([Nullable(2)] IVisualNovelPerformanceEnter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceEnter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x001A7AFB File Offset: 0x001A5CFB
		[NullableContext(1)]
		public static IVisualNovelPerformanceEnter CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceEnter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceEnter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x001A7B10 File Offset: 0x001A5D10
		[NullableContext(1)]
		public new IVisualNovelPerformanceEnter_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceEnter_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				WhoId = this.WhoId,
				Transform = this.Transform,
				FadeInTime = this.FadeInTime,
				RoleConfig = this.RoleConfig
			};
		}

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600B6D0 RID: 46800 RVA: 0x001A7B6A File Offset: 0x001A5D6A
		// (set) Token: 0x0600B6D1 RID: 46801 RVA: 0x001A7B95 File Offset: 0x001A5D95
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

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x001A7BA4 File Offset: 0x001A5DA4
		// (set) Token: 0x0600B6D3 RID: 46803 RVA: 0x001A7BDE File Offset: 0x001A5DDE
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600B6D4 RID: 46804 RVA: 0x001A7BEC File Offset: 0x001A5DEC
		// (set) Token: 0x0600B6D5 RID: 46805 RVA: 0x001A7C17 File Offset: 0x001A5E17
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

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x001A7C28 File Offset: 0x001A5E28
		// (set) Token: 0x0600B6D7 RID: 46807 RVA: 0x001A7C89 File Offset: 0x001A5E89
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
					IVisualNovelPerformanceEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600B6D8 RID: 46808 RVA: 0x001A7CA0 File Offset: 0x001A5EA0
		// (set) Token: 0x0600B6D9 RID: 46809 RVA: 0x001A7CDA File Offset: 0x001A5EDA
		public virtual float? FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				IVisualNovelPerformanceEnter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600B6DA RID: 46810 RVA: 0x001A7CE8 File Offset: 0x001A5EE8
		// (set) Token: 0x0600B6DB RID: 46811 RVA: 0x001A7D49 File Offset: 0x001A5F49
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
					IVisualNovelPerformanceEnter_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006DC6 RID: 28102
		protected new IVisualNovelPerformanceEnter FbInstance;

		// Token: 0x04006DC7 RID: 28103
		protected new IVisualNovelPerformanceEnter_SetValue PocoInterface;

		// Token: 0x04006DC8 RID: 28104
		[Nullable(1)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x04006DC9 RID: 28105
		private bool _TransformInited;

		// Token: 0x04006DCA RID: 28106
		[Nullable(1)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x04006DCB RID: 28107
		private bool _RoleConfigInited;
	}
}
