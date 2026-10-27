using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D7 RID: 727
	[NullableContext(1)]
	[Nullable(0)]
	public class IDurabilityStateConfig
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x000331E4 File Offset: 0x000313E4
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

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0003321C File Offset: 0x0003141C
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

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003322F File Offset: 0x0003142F
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

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00033242 File Offset: 0x00031442
		public IDurabilityStateConfig_SetValue ToSetValue()
		{
			return new IDurabilityStateConfig_SetValue
			{
				NonDestructable = this.NonDestructable,
				DurabilityStates = this.DurabilityStates
			};
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00033264 File Offset: 0x00031464
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x0003329E File Offset: 0x0003149E
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000332AC File Offset: 0x000314AC
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0003333F File Offset: 0x0003153F
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

		// Token: 0x04000C70 RID: 3184
		[Nullable(2)]
		protected IDurabilityStateConfig FbInstance;

		// Token: 0x04000C71 RID: 3185
		[Nullable(2)]
		protected IDurabilityStateConfig_SetValue PocoInterface;

		// Token: 0x04000C72 RID: 3186
		private List<IDurabilityState> _DurabilityStatesCache;

		// Token: 0x04000C73 RID: 3187
		private bool _DurabilityStatesInited;
	}
}
