using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001137 RID: 4407
	public class IMechaTrackScoreMechanismStateType
	{
		// Token: 0x06006188 RID: 24968 RVA: 0x000EB2D0 File Offset: 0x000E94D0
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

		// Token: 0x06006189 RID: 24969 RVA: 0x000EB308 File Offset: 0x000E9508
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

		// Token: 0x0600618A RID: 24970 RVA: 0x000EB31B File Offset: 0x000E951B
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

		// Token: 0x0600618B RID: 24971 RVA: 0x000EB32E File Offset: 0x000E952E
		public IMechaTrackScoreMechanismStateType_SetValue ToSetValue()
		{
			return new IMechaTrackScoreMechanismStateType_SetValue
			{
				EntitiyMatch = this.EntitiyMatch,
				State = this.State,
				ScoreId = this.ScoreId
			};
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600618C RID: 24972 RVA: 0x000EB35C File Offset: 0x000E955C
		// (set) Token: 0x0600618D RID: 24973 RVA: 0x000EB3BD File Offset: 0x000E95BD
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

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600618E RID: 24974 RVA: 0x000EB3D2 File Offset: 0x000E95D2
		// (set) Token: 0x0600618F RID: 24975 RVA: 0x000EB3FD File Offset: 0x000E95FD
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

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06006190 RID: 24976 RVA: 0x000EB40B File Offset: 0x000E960B
		// (set) Token: 0x06006191 RID: 24977 RVA: 0x000EB436 File Offset: 0x000E9636
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

		// Token: 0x04003A6E RID: 14958
		[Nullable(2)]
		protected IMechaTrackScoreMechanismStateType FbInstance;

		// Token: 0x04003A6F RID: 14959
		[Nullable(2)]
		protected IMechaTrackScoreMechanismStateType_SetValue PocoInterface;

		// Token: 0x04003A70 RID: 14960
		private IStaticEntitiyMatch _EntitiyMatchCache;

		// Token: 0x04003A71 RID: 14961
		private bool _EntitiyMatchInited;
	}
}
