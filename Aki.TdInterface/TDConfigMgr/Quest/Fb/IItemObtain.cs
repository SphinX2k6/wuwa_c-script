using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A3 RID: 5027
	[NullableContext(2)]
	[Nullable(0)]
	public class IItemObtain : IShowUi
	{
		// Token: 0x060072DE RID: 29406 RVA: 0x00113E32 File Offset: 0x00112032
		[NullableContext(1)]
		public static IItemObtain Create(IItemObtain? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemObtain
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x060072DF RID: 29407 RVA: 0x00113E51 File Offset: 0x00112051
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x00113E60 File Offset: 0x00112060
		public virtual List<int> ItemIds
		{
			get
			{
				if (this._ItemIdsInited)
				{
					return this._ItemIdsCache;
				}
				this._ItemIdsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int itemIdsLength = this.Instance.ItemIdsLength;
				this._ItemIdsCache = new List<int>(itemIdsLength);
				for (int i = 0; i < itemIdsLength; i++)
				{
					this._ItemIdsCache.Add(this.Instance.ItemIds(i));
				}
				return this._ItemIdsCache;
			}
		}

		// Token: 0x04004261 RID: 16993
		private IItemObtain Instance;

		// Token: 0x04004262 RID: 16994
		private List<int> _ItemIdsCache;

		// Token: 0x04004263 RID: 16995
		private bool _ItemIdsInited;
	}
}
