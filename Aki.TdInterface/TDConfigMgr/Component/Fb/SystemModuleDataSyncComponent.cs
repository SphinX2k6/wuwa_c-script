using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD3 RID: 3539
	[NullableContext(1)]
	[Nullable(0)]
	public class SystemModuleDataSyncComponent : IComponentBase
	{
		// Token: 0x0600504E RID: 20558 RVA: 0x000C675D File Offset: 0x000C495D
		public static SystemModuleDataSyncComponent Create(ISystemModuleDataSyncComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SystemModuleDataSyncComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x0600504F RID: 20559 RVA: 0x000C677C File Offset: 0x000C497C
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x000C67B4 File Offset: 0x000C49B4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06005051 RID: 20561 RVA: 0x000C67CA File Offset: 0x000C49CA
		public virtual ISystemModuleDataSyncMotorRacing SystemModuleData
		{
			get
			{
				if (this._SystemModuleDataInited)
				{
					return this._SystemModuleDataCache;
				}
				this._SystemModuleDataInited = true;
				this._SystemModuleDataCache = ISystemModuleDataSyncMotorRacing.Create(this.Instance.SystemModuleData);
				return this._SystemModuleDataCache;
			}
		}

		// Token: 0x04002E16 RID: 11798
		private ISystemModuleDataSyncComponent Instance;

		// Token: 0x04002E17 RID: 11799
		[Nullable(2)]
		private ISystemModuleDataSyncMotorRacing _SystemModuleDataCache;

		// Token: 0x04002E18 RID: 11800
		private bool _SystemModuleDataInited;
	}
}
