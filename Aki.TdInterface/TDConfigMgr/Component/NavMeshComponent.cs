using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E4 RID: 2276
	public class NavMeshComponent : IComponentBase
	{
		// Token: 0x0600318B RID: 12683 RVA: 0x0007F0C0 File Offset: 0x0007D2C0
		private NavMeshComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("NavMeshComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			NavMeshComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new NavMeshComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x0007F0F8 File Offset: 0x0007D2F8
		public static NavMeshComponent Create([Nullable(2)] NavMeshComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NavMeshComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0007F10B File Offset: 0x0007D30B
		public static NavMeshComponent CreateFromSetValue([Nullable(2)] NavMeshComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new NavMeshComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0007F11E File Offset: 0x0007D31E
		public new NavMeshComponent_SetValue ToSetValue()
		{
			return new NavMeshComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Source = this.Source
			};
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x0007F14C File Offset: 0x0007D34C
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x0007F186 File Offset: 0x0007D386
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				NavMeshComponent_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x0007F194 File Offset: 0x0007D394
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x0007F1BE File Offset: 0x0007D3BE
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x0007F1CC File Offset: 0x0007D3CC
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x0007F22D File Offset: 0x0007D42D
		public virtual INavMeshAkiEntitySource Source
		{
			get
			{
				if (this._SourceInited)
				{
					return this._SourceCache;
				}
				this._SourceInited = true;
				if (this.FbInstance != null)
				{
					this._SourceCache = INavMeshAkiEntitySource.Create(this.FbInstance.Source);
				}
				else
				{
					NavMeshComponent_SetValue pocoInterface = this.PocoInterface;
					this._SourceCache = ((pocoInterface != null) ? pocoInterface.Source : null);
				}
				return this._SourceCache;
			}
			set
			{
				this.GetOrCreatePoco().Source = value;
				this._SourceInited = false;
			}
		}

		// Token: 0x040020A7 RID: 8359
		[Nullable(2)]
		protected new NavMeshComponent FbInstance;

		// Token: 0x040020A8 RID: 8360
		[Nullable(2)]
		protected new NavMeshComponent_SetValue PocoInterface;

		// Token: 0x040020A9 RID: 8361
		private INavMeshAkiEntitySource _SourceCache;

		// Token: 0x040020AA RID: 8362
		private bool _SourceInited;
	}
}
