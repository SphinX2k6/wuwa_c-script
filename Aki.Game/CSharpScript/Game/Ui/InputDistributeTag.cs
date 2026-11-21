using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035C1 RID: 13761
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeTag
	{
		// Token: 0x060230F6 RID: 143606 RVA: 0x009F8704 File Offset: 0x009F6904
		public InputDistributeTag(string tag, [Nullable(2)] InputDistributeTag parentTag = null)
		{
			this.TagNameInternal = tag;
			this.ParentTagInternal = parentTag;
			for (InputDistributeTag inputDistributeTag = parentTag; inputDistributeTag != null; inputDistributeTag = inputDistributeTag.ParentTag)
			{
				string tagName = inputDistributeTag.TagName;
				this.ParentTagNameSet.Add(tagName);
			}
		}

		// Token: 0x170048EC RID: 18668
		// (get) Token: 0x060230F7 RID: 143607 RVA: 0x009F8752 File Offset: 0x009F6952
		public string TagName
		{
			get
			{
				return this.TagNameInternal;
			}
		}

		// Token: 0x170048ED RID: 18669
		// (get) Token: 0x060230F8 RID: 143608 RVA: 0x009F875A File Offset: 0x009F695A
		[Nullable(2)]
		public InputDistributeTag ParentTag
		{
			[NullableContext(2)]
			get
			{
				return this.ParentTagInternal;
			}
		}

		// Token: 0x060230F9 RID: 143609 RVA: 0x009F8762 File Offset: 0x009F6962
		public bool MatchTag(string tag, bool bExactMatch = false)
		{
			return this.TagNameInternal == tag || (!bExactMatch && this.ParentTagNameSet.Contains(tag));
		}

		// Token: 0x04013BEA RID: 80874
		[Nullable(2)]
		private readonly InputDistributeTag ParentTagInternal;

		// Token: 0x04013BEB RID: 80875
		private readonly HashSet<string> ParentTagNameSet = new HashSet<string>();

		// Token: 0x04013BEC RID: 80876
		private readonly string TagNameInternal;
	}
}
