using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200270A RID: 9994
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableHostility : ActionParams
	{
		// Token: 0x0600DF03 RID: 57091 RVA: 0x00210F47 File Offset: 0x0020F147
		public static EnableHostility Create(IEnableHostility? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableHostility
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x00210F66 File Offset: 0x0020F166
		public virtual bool IsEnable
		{
			get
			{
				return this.Instance.IsEnable;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x0600DF05 RID: 57093 RVA: 0x00210F74 File Offset: 0x0020F174
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x04007BC4 RID: 31684
		private IEnableHostility Instance;

		// Token: 0x04007BC5 RID: 31685
		private List<int> _EntityIdsCache;

		// Token: 0x04007BC6 RID: 31686
		private bool _EntityIdsInited;
	}
}
