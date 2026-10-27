using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDA RID: 3290
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcDeviceGradeConfig
	{
		// Token: 0x06004B30 RID: 19248 RVA: 0x000BBF0A File Offset: 0x000BA10A
		[NullableContext(1)]
		public static IPasserbyNpcDeviceGradeConfig Create(IPasserbyNpcDeviceGradeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcDeviceGradeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x000BBF29 File Offset: 0x000BA129
		public virtual IPasserbyNpcSpawnCountOverride SpawnCountOverride
		{
			get
			{
				if (this._SpawnCountOverrideInited)
				{
					return this._SpawnCountOverrideCache;
				}
				this._SpawnCountOverrideInited = true;
				this._SpawnCountOverrideCache = IPasserbyNpcSpawnCountOverride.Create(this.Instance.SpawnCountOverride);
				return this._SpawnCountOverrideCache;
			}
		}

		// Token: 0x04002AFF RID: 11007
		private IPasserbyNpcDeviceGradeConfig Instance;

		// Token: 0x04002B00 RID: 11008
		private IPasserbyNpcSpawnCountOverride _SpawnCountOverrideCache;

		// Token: 0x04002B01 RID: 11009
		private bool _SpawnCountOverrideInited;
	}
}
