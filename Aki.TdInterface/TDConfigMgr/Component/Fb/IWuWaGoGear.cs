using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0B RID: 3595
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoGear : IWuWaGoEntityBase
	{
		// Token: 0x06005160 RID: 20832 RVA: 0x000C8C91 File Offset: 0x000C6E91
		public static IWuWaGoGear Create(IWuWaGoGear? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoGear
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x000C8CB0 File Offset: 0x000C6EB0
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x000C8CC0 File Offset: 0x000C6EC0
		public virtual List<int> GridEntityIds
		{
			get
			{
				if (this._GridEntityIdsInited)
				{
					return this._GridEntityIdsCache;
				}
				this._GridEntityIdsInited = true;
				int gridEntityIdsLength = this.Instance.GridEntityIdsLength;
				this._GridEntityIdsCache = new List<int>(gridEntityIdsLength);
				for (int i = 0; i < gridEntityIdsLength; i++)
				{
					this._GridEntityIdsCache.Add(this.Instance.GridEntityIds(i));
				}
				return this._GridEntityIdsCache;
			}
		}

		// Token: 0x04002EDC RID: 11996
		private IWuWaGoGear Instance;

		// Token: 0x04002EDD RID: 11997
		private List<int> _GridEntityIdsCache;

		// Token: 0x04002EDE RID: 11998
		private bool _GridEntityIdsInited;
	}
}
