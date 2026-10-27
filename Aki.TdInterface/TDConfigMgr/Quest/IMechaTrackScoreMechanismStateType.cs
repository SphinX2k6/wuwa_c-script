using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200100B RID: 4107
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaTrackScoreMechanismStateType
	{
		// Token: 0x06005BA8 RID: 23464 RVA: 0x000DE690 File Offset: 0x000DC890
		private IMechaTrackScoreMechanismStateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaTrackScoreMechanismStateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaTrackScoreMechanismStateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaTrackScoreMechanismStateType_SetValue());
			}
			return result;
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x000DE6C8 File Offset: 0x000DC8C8
		public static IMechaTrackScoreMechanismStateType Create([Nullable(2)] IMechaTrackScoreMechanismStateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismStateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BAA RID: 23466 RVA: 0x000DE6DB File Offset: 0x000DC8DB
		public static IMechaTrackScoreMechanismStateType CreateFromSetValue([Nullable(2)] IMechaTrackScoreMechanismStateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaTrackScoreMechanismStateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BAB RID: 23467 RVA: 0x000DE6EE File Offset: 0x000DC8EE
		public IMechaTrackScoreMechanismStateType_SetValue ToSetValue()
		{
			return new IMechaTrackScoreMechanismStateType_SetValue
			{
				EntitiyMatch = this.EntitiyMatch,
				State = this.State,
				ScoreId = this.ScoreId
			};
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x000DE71C File Offset: 0x000DC91C
		// (set) Token: 0x06005BAD RID: 23469 RVA: 0x000DE77D File Offset: 0x000DC97D
		public virtual IStaticEntitiyMatch EntitiyMatch
		{
			get
			{
				if (this._EntitiyMatchInited)
				{
					return this._EntitiyMatchCache;
				}
				this._EntitiyMatchInited = true;
				if (this.FbInstance != null)
				{
					this._EntitiyMatchCache = IStaticEntitiyMatch.Create(this.FbInstance.EntitiyMatch);
				}
				else
				{
					IMechaTrackScoreMechanismStateType_SetValue pocoInterface = this.PocoInterface;
					this._EntitiyMatchCache = ((pocoInterface != null) ? pocoInterface.EntitiyMatch : null);
				}
				return this._EntitiyMatchCache;
			}
			set
			{
				this.GetOrCreatePoco().EntitiyMatch = value;
				this._EntitiyMatchInited = false;
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x000DE792 File Offset: 0x000DC992
		// (set) Token: 0x06005BAF RID: 23471 RVA: 0x000DE7BD File Offset: 0x000DC9BD
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x000DE7CB File Offset: 0x000DC9CB
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x000DE7F6 File Offset: 0x000DC9F6
		public virtual int ScoreId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScoreId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ScoreId;
			}
			set
			{
				this.GetOrCreatePoco().ScoreId = value;
			}
		}

		// Token: 0x04003736 RID: 14134
		[Nullable(2)]
		protected IMechaTrackScoreMechanismStateType FbInstance;

		// Token: 0x04003737 RID: 14135
		[Nullable(2)]
		protected IMechaTrackScoreMechanismStateType_SetValue PocoInterface;

		// Token: 0x04003738 RID: 14136
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x04003739 RID: 14137
		private bool _EntitiyMatchInited;
	}
}
