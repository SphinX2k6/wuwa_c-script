using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000042 RID: 66
	public class CollectComponent : IComponentBase
	{
		// Token: 0x06000242 RID: 578 RVA: 0x00019ADC File Offset: 0x00017CDC
		private CollectComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CollectComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CollectComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CollectComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00019B14 File Offset: 0x00017D14
		public static CollectComponent Create([Nullable(2)] CollectComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CollectComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00019B27 File Offset: 0x00017D27
		public static CollectComponent CreateFromSetValue([Nullable(2)] CollectComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CollectComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00019B3A File Offset: 0x00017D3A
		public new CollectComponent_SetValue ToSetValue()
		{
			return new CollectComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				IsDisableOneClickCollection = this.IsDisableOneClickCollection
			};
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00019B68 File Offset: 0x00017D68
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00019BA2 File Offset: 0x00017DA2
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				CollectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00019BB0 File Offset: 0x00017DB0
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00019BDA File Offset: 0x00017DDA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00019BE8 File Offset: 0x00017DE8
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00019C22 File Offset: 0x00017E22
		public virtual bool? IsDisableOneClickCollection
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableOneClickCollection;
				}
				CollectComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableOneClickCollection;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableOneClickCollection = value;
			}
		}

		// Token: 0x04000176 RID: 374
		[Nullable(2)]
		protected new CollectComponent FbInstance;

		// Token: 0x04000177 RID: 375
		[Nullable(2)]
		protected new CollectComponent_SetValue PocoInterface;
	}
}
