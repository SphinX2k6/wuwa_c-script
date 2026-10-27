using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DFB RID: 19963
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoViewModel
	{
		// Token: 0x0603383A RID: 211002 RVA: 0x00C09B21 File Offset: 0x00C07D21
		public RogueInfoViewModel(RoguelikeInfo rogueInfoInternal)
		{
			this.RogueInfoInternal = rogueInfoInternal;
		}

		// Token: 0x17007EC6 RID: 32454
		// (get) Token: 0x0603383B RID: 211003 RVA: 0x00C09B37 File Offset: 0x00C07D37
		public RoguelikeInfo RogueInfo
		{
			get
			{
				return this.RogueInfoInternal;
			}
		}

		// Token: 0x17007EC7 RID: 32455
		// (get) Token: 0x0603383C RID: 211004 RVA: 0x00C09B3F File Offset: 0x00C07D3F
		public RogueGainEntry RoleEntry
		{
			get
			{
				return this.RogueInfoInternal.RoleEntry;
			}
		}

		// Token: 0x17007EC8 RID: 32456
		// (get) Token: 0x0603383D RID: 211005 RVA: 0x00C09B4C File Offset: 0x00C07D4C
		[Nullable(2)]
		public RogueGainEntry PhantomEntry
		{
			[NullableContext(2)]
			get
			{
				return this.RogueInfoInternal.PhantomEntry;
			}
		}

		// Token: 0x17007EC9 RID: 32457
		// (get) Token: 0x0603383E RID: 211006 RVA: 0x00C09B59 File Offset: 0x00C07D59
		public List<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.RogueInfoInternal.BuffEntryList;
			}
		}

		// Token: 0x17007ECA RID: 32458
		// (get) Token: 0x0603383F RID: 211007 RVA: 0x00C09B66 File Offset: 0x00C07D66
		public List<RogueGainEntry> SpecialEntryList
		{
			get
			{
				return this.RogueInfoInternal.SpecialEntryList;
			}
		}

		// Token: 0x06033840 RID: 211008 RVA: 0x00C09B74 File Offset: 0x00C07D74
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

		// Token: 0x06033841 RID: 211009 RVA: 0x00C09C02 File Offset: 0x00C07E02
		public bool IsBuffEntryEmpty()
		{
			return this.BuffEntryList.Count <= 0;
		}

		// Token: 0x06033842 RID: 211010 RVA: 0x00C09C15 File Offset: 0x00C07E15
		public bool IsSpecialEntryEmpty()
		{
			return this.SpecialEntryList.Count <= 0;
		}

		// Token: 0x06033843 RID: 211011 RVA: 0x00C09C28 File Offset: 0x00C07E28
		public List<AttrListScrollData> GetAttrList()
		{
			return this.RogueInfoInternal.GetShowAttrList();
		}

		// Token: 0x0401B557 RID: 111959
		public bool ShowCurrency = true;

		// Token: 0x0401B558 RID: 111960
		public ERogueInfoViewPage DefaultPage;

		// Token: 0x0401B559 RID: 111961
		private RoguelikeInfo RogueInfoInternal;
	}
}
