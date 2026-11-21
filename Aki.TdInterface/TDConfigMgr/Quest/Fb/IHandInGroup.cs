using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014C7 RID: 5319
	public class IHandInGroup : IHandInItem
	{
		// Token: 0x060078A8 RID: 30888 RVA: 0x00120F24 File Offset: 0x0011F124
		public static IHandInGroup Create(IHandInGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandInGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x060078A9 RID: 30889 RVA: 0x00120F43 File Offset: 0x0011F143
		public override EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x00120F50 File Offset: 0x0011F150
		public override List<int> ItemIds
		{
			get
			{
				if (this._ItemIdsInited)
				{
					return this._ItemIdsCache;
				}
				this._ItemIdsInited = true;
				int itemIdsLength = this.Instance.ItemIdsLength;
				this._ItemIdsCache = new List<int>(itemIdsLength);
				for (int i = 0; i < itemIdsLength; i++)
				{
					this._ItemIdsCache.Add(this.Instance.ItemIds(i));
				}
				return this._ItemIdsCache;
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x00120FB4 File Offset: 0x0011F1B4
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x00120FC1 File Offset: 0x0011F1C1
		public virtual int Slot
		{
			get
			{
				return this.Instance.Slot;
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x060078AD RID: 30893 RVA: 0x00120FCE File Offset: 0x0011F1CE
		[Nullable(2)]
		public virtual IHandInItemRange ChoiceRange
		{
			[NullableContext(2)]
			get
			{
				if (this._ChoiceRangeInited)
				{
					return this._ChoiceRangeCache;
				}
				this._ChoiceRangeInited = true;
				this._ChoiceRangeCache = IHandInItemRange.Create(this.Instance.ChoiceRange);
				return this._ChoiceRangeCache;
			}
		}

		// Token: 0x04004565 RID: 17765
		private IHandInGroup Instance;

		// Token: 0x04004566 RID: 17766
		private List<int> _ItemIdsCache;

		// Token: 0x04004567 RID: 17767
		private bool _ItemIdsInited;

		// Token: 0x04004568 RID: 17768
		[Nullable(2)]
		private IHandInItemRange _ChoiceRangeCache;

		// Token: 0x04004569 RID: 17769
		private bool _ChoiceRangeInited;
	}
}
