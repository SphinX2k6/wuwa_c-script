using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F57 RID: 3927
	public class ICircuitConnectLinkageGroup
	{
		// Token: 0x06005805 RID: 22533 RVA: 0x000D7390 File Offset: 0x000D5590
		public static ICircuitConnectLinkageGroup Create(ICircuitConnectLinkageGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICircuitConnectLinkageGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x000D73AF File Offset: 0x000D55AF
		public virtual ETurntableConnectorDisk MainDisk
		{
			get
			{
				return (ETurntableConnectorDisk)this.Instance.MainDisk;
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06005807 RID: 22535 RVA: 0x000D73BC File Offset: 0x000D55BC
		public virtual List<ETurntableConnectorDisk> LinkedDisks
		{
			get
			{
				if (this._LinkedDisksInited)
				{
					return this._LinkedDisksCache;
				}
				this._LinkedDisksInited = true;
				int linkedDisksLength = this.Instance.LinkedDisksLength;
				this._LinkedDisksCache = new List<ETurntableConnectorDisk>(linkedDisksLength);
				for (int i = 0; i < linkedDisksLength; i++)
				{
					this._LinkedDisksCache.Add((ETurntableConnectorDisk)this.Instance.LinkedDisks(i));
				}
				return this._LinkedDisksCache;
			}
		}

		// Token: 0x04003282 RID: 12930
		private ICircuitConnectLinkageGroup Instance;

		// Token: 0x04003283 RID: 12931
		private List<ETurntableConnectorDisk> _LinkedDisksCache;

		// Token: 0x04003284 RID: 12932
		private bool _LinkedDisksInited;
	}
}
