using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200031E RID: 798
	public class IDurabilityStateConfig
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00036118 File Offset: 0x00034318
		private IDurabilityStateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDurabilityStateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDurabilityStateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDurabilityStateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00036150 File Offset: 0x00034350
		public static IDurabilityStateConfig Create([Nullable(2)] IDurabilityStateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDurabilityStateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00036163 File Offset: 0x00034363
		public static IDurabilityStateConfig CreateFromSetValue([Nullable(2)] IDurabilityStateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDurabilityStateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00036176 File Offset: 0x00034376
		public IDurabilityStateConfig_SetValue ToSetValue()
		{
			return new IDurabilityStateConfig_SetValue
			{
				NonDestructable = this.NonDestructable,
				DurabilityStates = this.DurabilityStates
			};
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00036198 File Offset: 0x00034398
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x000361D2 File Offset: 0x000343D2
		public virtual bool? NonDestructable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NonDestructable;
				}
				IDurabilityStateConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.NonDestructable;
			}
			set
			{
				this.GetOrCreatePoco().NonDestructable = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x000361E0 File Offset: 0x000343E0
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00036273 File Offset: 0x00034473
		public virtual List<IDurabilityState> DurabilityStates
		{
			get
			{
				if (this._DurabilityStatesInited)
				{
					return this._DurabilityStatesCache;
				}
				this._DurabilityStatesInited = true;
				if (this.FbInstance != null)
				{
					List<IDurabilityState> durabilityStates = this.FbInstance.DurabilityStates;
					if (durabilityStates != null)
					{
						this._DurabilityStatesCache = new List<IDurabilityState>(durabilityStates.Count);
						for (int i = 0; i < durabilityStates.Count; i++)
						{
							this._DurabilityStatesCache.Add(IDurabilityState.Create(durabilityStates[i]));
						}
					}
				}
				else
				{
					IDurabilityStateConfig_SetValue pocoInterface = this.PocoInterface;
					this._DurabilityStatesCache = ((pocoInterface != null) ? pocoInterface.DurabilityStates : null);
				}
				return this._DurabilityStatesCache;
			}
			set
			{
				this.GetOrCreatePoco().DurabilityStates = value;
				this._DurabilityStatesInited = false;
			}
		}

		// Token: 0x04000D5A RID: 3418
		[Nullable(2)]
		protected IDurabilityStateConfig FbInstance;

		// Token: 0x04000D5B RID: 3419
		[Nullable(2)]
		protected IDurabilityStateConfig_SetValue PocoInterface;

		// Token: 0x04000D5C RID: 3420
		private List<IDurabilityState> _DurabilityStatesCache;

		// Token: 0x04000D5D RID: 3421
		private bool _DurabilityStatesInited;
	}
}
