using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CC RID: 8908
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelPerformanceEnter : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C1FC RID: 49660 RVA: 0x001BE328 File Offset: 0x001BC528
		[NullableContext(0)]
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

		// Token: 0x0600C1FD RID: 49661 RVA: 0x001BE360 File Offset: 0x001BC560
		[NullableContext(0)]
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

		// Token: 0x0600C1FE RID: 49662 RVA: 0x001BE373 File Offset: 0x001BC573
		[NullableContext(0)]
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

		// Token: 0x0600C1FF RID: 49663 RVA: 0x001BE388 File Offset: 0x001BC588
		[NullableContext(0)]
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

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600C200 RID: 49664 RVA: 0x001BE3E2 File Offset: 0x001BC5E2
		// (set) Token: 0x0600C201 RID: 49665 RVA: 0x001BE40D File Offset: 0x001BC60D
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

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600C202 RID: 49666 RVA: 0x001BE41C File Offset: 0x001BC61C
		// (set) Token: 0x0600C203 RID: 49667 RVA: 0x001BE456 File Offset: 0x001BC656
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

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600C204 RID: 49668 RVA: 0x001BE464 File Offset: 0x001BC664
		// (set) Token: 0x0600C205 RID: 49669 RVA: 0x001BE48F File Offset: 0x001BC68F
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

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600C206 RID: 49670 RVA: 0x001BE4A0 File Offset: 0x001BC6A0
		// (set) Token: 0x0600C207 RID: 49671 RVA: 0x001BE501 File Offset: 0x001BC701
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

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x001BE518 File Offset: 0x001BC718
		// (set) Token: 0x0600C209 RID: 49673 RVA: 0x001BE552 File Offset: 0x001BC752
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

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600C20A RID: 49674 RVA: 0x001BE560 File Offset: 0x001BC760
		// (set) Token: 0x0600C20B RID: 49675 RVA: 0x001BE5C1 File Offset: 0x001BC7C1
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

		// Token: 0x040073D3 RID: 29651
		protected new IVisualNovelPerformanceEnter FbInstance;

		// Token: 0x040073D4 RID: 29652
		protected new IVisualNovelPerformanceEnter_SetValue PocoInterface;

		// Token: 0x040073D5 RID: 29653
		[Nullable(0)]
		private IVisualNovelPortraitTransform _TransformCache;

		// Token: 0x040073D6 RID: 29654
		private bool _TransformInited;

		// Token: 0x040073D7 RID: 29655
		[Nullable(0)]
		private IVisualNovelRoleConfig _RoleConfigCache;

		// Token: 0x040073D8 RID: 29656
		private bool _RoleConfigInited;
	}
}
