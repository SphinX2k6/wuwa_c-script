using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245C RID: 9308
	public class SetWeatherLockState : ActionParams
	{
		// Token: 0x0600CA93 RID: 51859 RVA: 0x001CE824 File Offset: 0x001CCA24
		private SetWeatherLockState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWeatherLockState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWeatherLockState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWeatherLockState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x001CE85C File Offset: 0x001CCA5C
		public static SetWeatherLockState Create([Nullable(2)] SetWeatherLockState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeatherLockState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x001CE86F File Offset: 0x001CCA6F
		public static SetWeatherLockState CreateFromSetValue([Nullable(2)] SetWeatherLockState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWeatherLockState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA96 RID: 51862 RVA: 0x001CE882 File Offset: 0x001CCA82
		public SetWeatherLockState_SetValue ToSetValue()
		{
			return new SetWeatherLockState_SetValue
			{
				LockState = this.LockState,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x001CE8A1 File Offset: 0x001CCAA1
		// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x001CE8CC File Offset: 0x001CCACC
		public virtual ELockState LockState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockState;
				}
				if (this.PocoInterface == null)
				{
					return ELockState.Lock;
				}
				return this.PocoInterface.LockState;
			}
			set
			{
				this.GetOrCreatePoco().LockState = value;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x001CE8DA File Offset: 0x001CCADA
		// (set) Token: 0x0600CA9A RID: 51866 RVA: 0x001CE901 File Offset: 0x001CCB01
		[Nullable(2)]
		public virtual List<int> AreaIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				SetWeatherLockState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x0400781C RID: 30748
		[Nullable(2)]
		protected new SetWeatherLockState FbInstance;

		// Token: 0x0400781D RID: 30749
		[Nullable(2)]
		protected SetWeatherLockState_SetValue PocoInterface;
	}
}
