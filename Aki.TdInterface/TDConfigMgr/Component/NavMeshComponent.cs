using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000841 RID: 2113
	[NullableContext(1)]
	[Nullable(0)]
	public class NavMeshComponent : IComponentBase
	{
		// Token: 0x06002E55 RID: 11861 RVA: 0x00077C9C File Offset: 0x00075E9C
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

		// Token: 0x06002E56 RID: 11862 RVA: 0x00077CD4 File Offset: 0x00075ED4
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

		// Token: 0x06002E57 RID: 11863 RVA: 0x00077CE7 File Offset: 0x00075EE7
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

		// Token: 0x06002E58 RID: 11864 RVA: 0x00077CFA File Offset: 0x00075EFA
		public new NavMeshComponent_SetValue ToSetValue()
		{
			return new NavMeshComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Source = this.Source
			};
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x00077D28 File Offset: 0x00075F28
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x00077D62 File Offset: 0x00075F62
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00077D70 File Offset: 0x00075F70
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x00077D9A File Offset: 0x00075F9A
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x00077DA8 File Offset: 0x00075FA8
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x00077E09 File Offset: 0x00076009
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

		// Token: 0x04001E98 RID: 7832
		[Nullable(2)]
		protected new NavMeshComponent FbInstance;

		// Token: 0x04001E99 RID: 7833
		[Nullable(2)]
		protected new NavMeshComponent_SetValue PocoInterface;

		// Token: 0x04001E9A RID: 7834
		private INavMeshAkiEntitySource _SourceCache;

		// Token: 0x04001E9B RID: 7835
		private bool _SourceInited;
	}
}
