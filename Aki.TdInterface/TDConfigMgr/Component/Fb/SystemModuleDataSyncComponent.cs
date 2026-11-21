using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ECF RID: 3791
	public class SystemModuleDataSyncComponent : IComponentBase
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x000D1FAD File Offset: 0x000D01AD
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

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x000D1FCC File Offset: 0x000D01CC
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

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x000D2004 File Offset: 0x000D0204
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x000D201A File Offset: 0x000D021A
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

		// Token: 0x040030DC RID: 12508
		private ISystemModuleDataSyncComponent Instance;

		// Token: 0x040030DD RID: 12509
		[Nullable(2)]
		private ISystemModuleDataSyncMotorRacing _SystemModuleDataCache;

		// Token: 0x040030DE RID: 12510
		private bool _SystemModuleDataInited;
	}
}
