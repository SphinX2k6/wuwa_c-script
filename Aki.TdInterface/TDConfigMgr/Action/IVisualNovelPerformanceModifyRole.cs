using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D4 RID: 8916
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceModifyRole : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C23E RID: 49726 RVA: 0x001BEC28 File Offset: 0x001BCE28
		[NullableContext(0)]
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

		// Token: 0x0600C23F RID: 49727 RVA: 0x001BEC60 File Offset: 0x001BCE60
		[NullableContext(0)]
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

		// Token: 0x0600C240 RID: 49728 RVA: 0x001BEC73 File Offset: 0x001BCE73
		[NullableContext(0)]
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

		// Token: 0x0600C241 RID: 49729 RVA: 0x001BEC88 File Offset: 0x001BCE88
		[NullableContext(0)]
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

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600C242 RID: 49730 RVA: 0x001BECD6 File Offset: 0x001BCED6
		// (set) Token: 0x0600C243 RID: 49731 RVA: 0x001BED01 File Offset: 0x001BCF01
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

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600C244 RID: 49732 RVA: 0x001BED10 File Offset: 0x001BCF10
		// (set) Token: 0x0600C245 RID: 49733 RVA: 0x001BED4A File Offset: 0x001BCF4A
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

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600C246 RID: 49734 RVA: 0x001BED58 File Offset: 0x001BCF58
		// (set) Token: 0x0600C247 RID: 49735 RVA: 0x001BED83 File Offset: 0x001BCF83
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

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600C248 RID: 49736 RVA: 0x001BED94 File Offset: 0x001BCF94
		// (set) Token: 0x0600C249 RID: 49737 RVA: 0x001BEDF5 File Offset: 0x001BCFF5
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

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600C24A RID: 49738 RVA: 0x001BEE0C File Offset: 0x001BD00C
		// (set) Token: 0x0600C24B RID: 49739 RVA: 0x001BEE6D File Offset: 0x001BD06D
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

		// Token: 0x040073F6 RID: 29686
		protected new IVisualNovelPerformanceModifyRole FbInstance;

		// Token: 0x040073F7 RID: 29687
		protected new IVisualNovelPerformanceModifyRole_SetValue PocoInterface;

		// Token: 0x040073F8 RID: 29688
		[Nullable(0)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x040073F9 RID: 29689
		private bool _TransformInited;

		// Token: 0x040073FA RID: 29690
		[Nullable(0)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x040073FB RID: 29691
		private bool _RoleConfigInited;
	}
}
