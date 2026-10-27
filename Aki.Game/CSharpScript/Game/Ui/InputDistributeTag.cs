using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004690 RID: 18064
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeTag
	{
		// Token: 0x0602E9AC RID: 190892 RVA: 0x00ACA9D0 File Offset: 0x00AC8BD0
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

		// Token: 0x17007630 RID: 30256
		// (get) Token: 0x0602E9AD RID: 190893 RVA: 0x00ACAA1E File Offset: 0x00AC8C1E
		public string TagName
		{
			get
			{
				return this.TagNameInternal;
			}
		}

		// Token: 0x17007631 RID: 30257
		// (get) Token: 0x0602E9AE RID: 190894 RVA: 0x00ACAA26 File Offset: 0x00AC8C26
		[Nullable(2)]
		public InputDistributeTag ParentTag
		{
			[NullableContext(2)]
			get
			{
				return this.ParentTagInternal;
			}
		}

		// Token: 0x0602E9AF RID: 190895 RVA: 0x00ACAA2E File Offset: 0x00AC8C2E
		public bool MatchTag(string tag, bool bExactMatch = false)
		{
			return this.TagNameInternal == tag || (!bExactMatch && this.ParentTagNameSet.Contains(tag));
		}

		// Token: 0x04019543 RID: 103747
		[Nullable(2)]
		private readonly InputDistributeTag ParentTagInternal;

		// Token: 0x04019544 RID: 103748
		private readonly HashSet<string> ParentTagNameSet = new HashSet<string>();

		// Token: 0x04019545 RID: 103749
		private readonly string TagNameInternal;
	}
}
