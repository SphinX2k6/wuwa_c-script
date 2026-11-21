using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F5B RID: 3931
	public class ICircuitConnect : ITurntableConnectorGameplayBase
	{
		// Token: 0x06005818 RID: 22552 RVA: 0x000D7661 File Offset: 0x000D5861
		public static ICircuitConnect Create(ICircuitConnect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06005819 RID: 22553 RVA: 0x000D7680 File Offset: 0x000D5880
		public override ETurntableConnectorGameplayType Type
		{
			get
			{
				return (ETurntableConnectorGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x000D768D File Offset: 0x000D588D
		public virtual int AssetConfigId
		{
			get
			{
				return this.Instance.AssetConfigId;
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600581B RID: 22555 RVA: 0x000D769A File Offset: 0x000D589A
		public virtual ICircuitConnectLevelData LevelData
		{
			get
			{
				if (this._LevelDataInited)
				{
					return this._LevelDataCache;
				}
				this._LevelDataInited = true;
				this._LevelDataCache = ICircuitConnectLevelData.Create(this.Instance.LevelData);
				return this._LevelDataCache;
			}
		}

		// Token: 0x04003294 RID: 12948
		private ICircuitConnect Instance;

		// Token: 0x04003295 RID: 12949
		[Nullable(2)]
		private ICircuitConnectLevelData _LevelDataCache;

		// Token: 0x04003296 RID: 12950
		private bool _LevelDataInited;
	}
}
