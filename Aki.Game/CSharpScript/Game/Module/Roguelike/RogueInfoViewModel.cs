using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC4 RID: 15812
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoViewModel
	{
		// Token: 0x060286A5 RID: 165541 RVA: 0x00B53031 File Offset: 0x00B51231
		public RogueInfoViewModel(RoguelikeInfo rogueInfoInternal)
		{
			this.RogueInfoInternal = rogueInfoInternal;
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x060286A6 RID: 165542 RVA: 0x00B53047 File Offset: 0x00B51247
		public RoguelikeInfo RogueInfo
		{
			get
			{
				return this.RogueInfoInternal;
			}
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x060286A7 RID: 165543 RVA: 0x00B5304F File Offset: 0x00B5124F
		public RogueGainEntry RoleEntry
		{
			get
			{
				return this.RogueInfoInternal.RoleEntry;
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x060286A8 RID: 165544 RVA: 0x00B5305C File Offset: 0x00B5125C
		[Nullable(2)]
		public RogueGainEntry PhantomEntry
		{
			[NullableContext(2)]
			get
			{
				return this.RogueInfoInternal.PhantomEntry;
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x060286A9 RID: 165545 RVA: 0x00B53069 File Offset: 0x00B51269
		public List<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.RogueInfoInternal.BuffEntryList;
			}
		}

		// Token: 0x1700527A RID: 21114
		// (get) Token: 0x060286AA RID: 165546 RVA: 0x00B53076 File Offset: 0x00B51276
		public List<RogueGainEntry> SpecialEntryList
		{
			get
			{
				return this.RogueInfoInternal.SpecialEntryList;
			}
		}

		// Token: 0x060286AB RID: 165547 RVA: 0x00B53084 File Offset: 0x00B51284
		public List<ElementInfo> GetElementInfoList()
		{
			List<ElementInfo> list = new List<ElementInfo>();
			foreach (int num in RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.ElementList())
			{
				int count = this.RogueInfoInternal.ElementDict.ContainsKey(num) ? this.RogueInfoInternal.ElementDict[num] : 0;
				list.Add(new ElementInfo(num, count, null));
			}
			return list;
		}

		// Token: 0x060286AC RID: 165548 RVA: 0x00B53112 File Offset: 0x00B51312
		public bool IsBuffEntryEmpty()
		{
			return this.BuffEntryList.Count <= 0;
		}

		// Token: 0x060286AD RID: 165549 RVA: 0x00B53125 File Offset: 0x00B51325
		public bool IsSpecialEntryEmpty()
		{
			return this.SpecialEntryList.Count <= 0;
		}

		// Token: 0x060286AE RID: 165550 RVA: 0x00B53138 File Offset: 0x00B51338
		public List<AttrListScrollData> GetAttrList()
		{
			return this.RogueInfoInternal.GetShowAttrList();
		}

		// Token: 0x04015F2A RID: 89898
		public bool ShowCurrency = true;

		// Token: 0x04015F2B RID: 89899
		public ERogueInfoViewPage DefaultPage;

		// Token: 0x04015F2C RID: 89900
		private RoguelikeInfo RogueInfoInternal;
	}
}
