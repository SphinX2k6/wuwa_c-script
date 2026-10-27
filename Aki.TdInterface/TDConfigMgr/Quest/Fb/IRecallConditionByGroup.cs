using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200145C RID: 5212
	[NullableContext(1)]
	[Nullable(0)]
	public class IRecallConditionByGroup : IRecallConditionBase
	{
		// Token: 0x06007673 RID: 30323 RVA: 0x0011AE4C File Offset: 0x0011904C
		public static IRecallConditionByGroup Create(IRecallConditionByGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRecallConditionByGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x0011AE6B File Offset: 0x0011906B
		public override ERecallConditionType Type
		{
			get
			{
				return (ERecallConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x0011AE78 File Offset: 0x00119078
		public override ERecallOperation Operation
		{
			get
			{
				return (ERecallOperation)this.Instance.Operation;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x0011AE88 File Offset: 0x00119088
		public virtual List<int> GroupIds
		{
			get
			{
				if (this._GroupIdsInited)
				{
					return this._GroupIdsCache;
				}
				this._GroupIdsInited = true;
				int groupIdsLength = this.Instance.GroupIdsLength;
				this._GroupIdsCache = new List<int>(groupIdsLength);
				for (int i = 0; i < groupIdsLength; i++)
				{
					this._GroupIdsCache.Add(this.Instance.GroupIds(i));
				}
				return this._GroupIdsCache;
			}
		}

		// Token: 0x040044C8 RID: 17608
		private IRecallConditionByGroup Instance;

		// Token: 0x040044C9 RID: 17609
		private List<int> _GroupIdsCache;

		// Token: 0x040044CA RID: 17610
		private bool _GroupIdsInited;
	}
}
