using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001376 RID: 4982
	[NullableContext(1)]
	[Nullable(0)]
	public class IHandInGroup : IHandInItem
	{
		// Token: 0x06007202 RID: 29186 RVA: 0x001128A0 File Offset: 0x00110AA0
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

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x001128BF File Offset: 0x00110ABF
		public override EHandInItemType HandInType
		{
			get
			{
				return (EHandInItemType)this.Instance.HandInType;
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x06007204 RID: 29188 RVA: 0x001128CC File Offset: 0x00110ACC
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

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x00112930 File Offset: 0x00110B30
		public override int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06007206 RID: 29190 RVA: 0x0011293D File Offset: 0x00110B3D
		public virtual int Slot
		{
			get
			{
				return this.Instance.Slot;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x0011294A File Offset: 0x00110B4A
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

		// Token: 0x040041E4 RID: 16868
		private IHandInGroup Instance;

		// Token: 0x040041E5 RID: 16869
		private List<int> _ItemIdsCache;

		// Token: 0x040041E6 RID: 16870
		private bool _ItemIdsInited;

		// Token: 0x040041E7 RID: 16871
		[Nullable(2)]
		private IHandInItemRange _ChoiceRangeCache;

		// Token: 0x040041E8 RID: 16872
		private bool _ChoiceRangeInited;
	}
}
