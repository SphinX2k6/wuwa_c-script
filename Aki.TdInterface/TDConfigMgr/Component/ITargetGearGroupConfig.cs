using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200074C RID: 1868
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetGearGroupConfig
	{
		// Token: 0x06002855 RID: 10325 RVA: 0x0006AED0 File Offset: 0x000690D0
		private ITargetGearGroupConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetGearGroupConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetGearGroupConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetGearGroupConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x0006AF08 File Offset: 0x00069108
		public static ITargetGearGroupConfig Create([Nullable(2)] ITargetGearGroupConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetGearGroupConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0006AF1B File Offset: 0x0006911B
		public static ITargetGearGroupConfig CreateFromSetValue([Nullable(2)] ITargetGearGroupConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetGearGroupConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0006AF30 File Offset: 0x00069130
		public ITargetGearGroupConfig_SetValue ToSetValue()
		{
			return new ITargetGearGroupConfig_SetValue
			{
				Entitys = this.Entitys,
				SuccessCondition = this.SuccessCondition,
				FailureConditions = this.FailureConditions,
				CheckGears = this.CheckGears,
				FinishConfig = this.FinishConfig
			};
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x0006AF7E File Offset: 0x0006917E
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x0006AFA5 File Offset: 0x000691A5
		public virtual List<int> Entitys
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entitys;
				}
				ITargetGearGroupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entitys;
			}
			set
			{
				this.GetOrCreatePoco().Entitys = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x0006AFB3 File Offset: 0x000691B3
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0006AFDA File Offset: 0x000691DA
		public virtual ITargetGearGroupSuccessContdion SuccessCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SuccessCondition;
				}
				ITargetGearGroupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SuccessCondition;
			}
			set
			{
				this.GetOrCreatePoco().SuccessCondition = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0006AFE8 File Offset: 0x000691E8
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x0006B00F File Offset: 0x0006920F
		public virtual List<ITargetGearGroupFailureCondition> FailureConditions
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FailureConditions;
				}
				ITargetGearGroupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FailureConditions;
			}
			set
			{
				this.GetOrCreatePoco().FailureConditions = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0006B020 File Offset: 0x00069220
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x0006B0B3 File Offset: 0x000692B3
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ICheckGearHit> CheckGears
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this._CheckGearsInited)
				{
					return this._CheckGearsCache;
				}
				this._CheckGearsInited = true;
				if (this.FbInstance != null)
				{
					List<ICheckGearHit> checkGears = this.FbInstance.CheckGears;
					if (checkGears != null)
					{
						this._CheckGearsCache = new List<ICheckGearHit>(checkGears.Count);
						for (int i = 0; i < checkGears.Count; i++)
						{
							this._CheckGearsCache.Add(ICheckGearHit.Create(checkGears[i]));
						}
					}
				}
				else
				{
					ITargetGearGroupConfig_SetValue pocoInterface = this.PocoInterface;
					this._CheckGearsCache = ((pocoInterface != null) ? pocoInterface.CheckGears : null);
				}
				return this._CheckGearsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().CheckGears = value;
				this._CheckGearsInited = false;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0006B0C8 File Offset: 0x000692C8
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x0006B0EF File Offset: 0x000692EF
		[Nullable(2)]
		public virtual IGroupFinishConfig FinishConfig
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FinishConfig;
				}
				ITargetGearGroupConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FinishConfig;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FinishConfig = value;
			}
		}

		// Token: 0x04001B28 RID: 6952
		[Nullable(2)]
		protected ITargetGearGroupConfig FbInstance;

		// Token: 0x04001B29 RID: 6953
		[Nullable(2)]
		protected ITargetGearGroupConfig_SetValue PocoInterface;

		// Token: 0x04001B2A RID: 6954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICheckGearHit> _CheckGearsCache;

		// Token: 0x04001B2B RID: 6955
		private bool _CheckGearsInited;
	}
}
