using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D0 RID: 1488
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcSpline
	{
		// Token: 0x06001F7E RID: 8062 RVA: 0x0005850C File Offset: 0x0005670C
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

		// Token: 0x06001F7F RID: 8063 RVA: 0x00058544 File Offset: 0x00056744
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

		// Token: 0x06001F80 RID: 8064 RVA: 0x00058557 File Offset: 0x00056757
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

		// Token: 0x06001F81 RID: 8065 RVA: 0x0005856C File Offset: 0x0005676C
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000585BA File Offset: 0x000567BA
		// (set) Token: 0x06001F83 RID: 8067 RVA: 0x000585E5 File Offset: 0x000567E5
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000585F3 File Offset: 0x000567F3
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0005861E File Offset: 0x0005681E
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0005862C File Offset: 0x0005682C
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00058666 File Offset: 0x00056866
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00058674 File Offset: 0x00056874
		// (set) Token: 0x06001F89 RID: 8073 RVA: 0x000586D5 File Offset: 0x000568D5
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

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001F8A RID: 8074 RVA: 0x000586EC File Offset: 0x000568EC
		// (set) Token: 0x06001F8B RID: 8075 RVA: 0x00058726 File Offset: 0x00056926
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

		// Token: 0x0400163E RID: 5694
		[Nullable(2)]
		protected IPasserbyNpcSpline FbInstance;

		// Token: 0x0400163F RID: 5695
		[Nullable(2)]
		protected IPasserbyNpcSpline_SetValue PocoInterface;

		// Token: 0x04001640 RID: 5696
		private IPasserbyNpcMoveState _MoveStateCache;

		// Token: 0x04001641 RID: 5697
		private bool _MoveStateInited;
	}
}
