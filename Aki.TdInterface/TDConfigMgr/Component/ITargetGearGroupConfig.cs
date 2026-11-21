using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007ED RID: 2029
	public class ITargetGearGroupConfig
	{
		// Token: 0x06002B79 RID: 11129 RVA: 0x00072078 File Offset: 0x00070278
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x000720B0 File Offset: 0x000702B0
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

		// Token: 0x06002B7B RID: 11131 RVA: 0x000720C3 File Offset: 0x000702C3
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

		// Token: 0x06002B7C RID: 11132 RVA: 0x000720D8 File Offset: 0x000702D8
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

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x00072126 File Offset: 0x00070326
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x0007214D File Offset: 0x0007034D
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

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x0007215B File Offset: 0x0007035B
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x00072182 File Offset: 0x00070382
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

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x00072190 File Offset: 0x00070390
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x000721B7 File Offset: 0x000703B7
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

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000721C8 File Offset: 0x000703C8
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x0007225B File Offset: 0x0007045B
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ICheckGearHit> CheckGears
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().CheckGears = value;
				this._CheckGearsInited = false;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00072270 File Offset: 0x00070470
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00072297 File Offset: 0x00070497
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

		// Token: 0x04001D2D RID: 7469
		[Nullable(2)]
		protected ITargetGearGroupConfig FbInstance;

		// Token: 0x04001D2E RID: 7470
		[Nullable(2)]
		protected ITargetGearGroupConfig_SetValue PocoInterface;

		// Token: 0x04001D2F RID: 7471
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ICheckGearHit> _CheckGearsCache;

		// Token: 0x04001D30 RID: 7472
		private bool _CheckGearsInited;
	}
}
