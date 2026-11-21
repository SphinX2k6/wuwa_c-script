using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065F RID: 1631
	public class IPasserbyNpcSpline
	{
		// Token: 0x06002240 RID: 8768 RVA: 0x0005EA58 File Offset: 0x0005CC58
		private IPasserbyNpcSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0005EA90 File Offset: 0x0005CC90
		public static IPasserbyNpcSpline Create([Nullable(2)] IPasserbyNpcSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0005EAA3 File Offset: 0x0005CCA3
		public static IPasserbyNpcSpline CreateFromSetValue([Nullable(2)] IPasserbyNpcSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
		public IPasserbyNpcSpline_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpline_SetValue
			{
				SplineEntityId = this.SplineEntityId,
				SpawnWeight = this.SpawnWeight,
				IsLoop = this.IsLoop,
				MoveState = this.MoveState,
				IsIkEnabled = this.IsIkEnabled
			};
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0005EB06 File Offset: 0x0005CD06
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x0005EB31 File Offset: 0x0005CD31
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0005EB3F File Offset: 0x0005CD3F
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x0005EB6A File Offset: 0x0005CD6A
		public virtual int SpawnWeight
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpawnWeight;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpawnWeight;
			}
			set
			{
				this.GetOrCreatePoco().SpawnWeight = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x0005EB78 File Offset: 0x0005CD78
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x0005EBB2 File Offset: 0x0005CDB2
		public virtual bool? IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				IPasserbyNpcSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x0005EBC0 File Offset: 0x0005CDC0
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x0005EC21 File Offset: 0x0005CE21
		[Nullable(2)]
		public virtual IPasserbyNpcMoveState MoveState
		{
			[NullableContext(2)]
			get
			{
				if (this._MoveStateInited)
				{
					return this._MoveStateCache;
				}
				this._MoveStateInited = true;
				if (this.FbInstance != null)
				{
					this._MoveStateCache = IPasserbyNpcMoveState.Create(this.FbInstance.MoveState);
				}
				else
				{
					IPasserbyNpcSpline_SetValue pocoInterface = this.PocoInterface;
					this._MoveStateCache = ((pocoInterface != null) ? pocoInterface.MoveState : null);
				}
				return this._MoveStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveState = value;
				this._MoveStateInited = false;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0005EC38 File Offset: 0x0005CE38
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x0005EC72 File Offset: 0x0005CE72
		public virtual bool? IsIkEnabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsIkEnabled;
				}
				IPasserbyNpcSpline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsIkEnabled;
			}
			set
			{
				this.GetOrCreatePoco().IsIkEnabled = value;
			}
		}

		// Token: 0x0400180F RID: 6159
		[Nullable(2)]
		protected IPasserbyNpcSpline FbInstance;

		// Token: 0x04001810 RID: 6160
		[Nullable(2)]
		protected IPasserbyNpcSpline_SetValue PocoInterface;

		// Token: 0x04001811 RID: 6161
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x04001812 RID: 6162
		private bool _MoveStateInited;
	}
}
