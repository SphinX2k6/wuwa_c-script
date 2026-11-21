using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000637 RID: 1591
	public class IPasserbyNpcFloorSpline
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x0005D1C8 File Offset: 0x0005B3C8
		private IPasserbyNpcFloorSpline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcFloorSpline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcFloorSpline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcFloorSpline_SetValue());
			}
			return result;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0005D200 File Offset: 0x0005B400
		public static IPasserbyNpcFloorSpline Create([Nullable(2)] IPasserbyNpcFloorSpline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcFloorSpline
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0005D213 File Offset: 0x0005B413
		public static IPasserbyNpcFloorSpline CreateFromSetValue([Nullable(2)] IPasserbyNpcFloorSpline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcFloorSpline
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0005D226 File Offset: 0x0005B426
		public IPasserbyNpcFloorSpline_SetValue ToSetValue()
		{
			return new IPasserbyNpcFloorSpline_SetValue
			{
				SplineEntityId = this.SplineEntityId,
				Floor = this.Floor,
				MoveState = this.MoveState
			};
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0005D251 File Offset: 0x0005B451
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x0005D27C File Offset: 0x0005B47C
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

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0005D28A File Offset: 0x0005B48A
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x0005D2B5 File Offset: 0x0005B4B5
		public virtual int Floor
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Floor;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Floor;
			}
			set
			{
				this.GetOrCreatePoco().Floor = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x0005D325 File Offset: 0x0005B525
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
					IPasserbyNpcFloorSpline_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040017A6 RID: 6054
		[Nullable(2)]
		protected IPasserbyNpcFloorSpline FbInstance;

		// Token: 0x040017A7 RID: 6055
		[Nullable(2)]
		protected IPasserbyNpcFloorSpline_SetValue PocoInterface;

		// Token: 0x040017A8 RID: 6056
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x040017A9 RID: 6057
		private bool _MoveStateInited;
	}
}
