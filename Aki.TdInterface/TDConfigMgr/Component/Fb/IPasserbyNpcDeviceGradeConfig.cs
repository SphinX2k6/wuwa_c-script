using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD0 RID: 3536
	[NullableContext(2)]
	[Nullable(0)]
	public class IPasserbyNpcDeviceGradeConfig
	{
		// Token: 0x06005033 RID: 20531 RVA: 0x000C7276 File Offset: 0x000C5476
		[NullableContext(0)]
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

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x000C7295 File Offset: 0x000C5495
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

		// Token: 0x04002DAF RID: 11695
		private IPasserbyNpcDeviceGradeConfig Instance;

		// Token: 0x04002DB0 RID: 11696
		private IPasserbyNpcSpawnCountOverride _SpawnCountOverrideCache;

		// Token: 0x04002DB1 RID: 11697
		private bool _SpawnCountOverrideInited;
	}
}
