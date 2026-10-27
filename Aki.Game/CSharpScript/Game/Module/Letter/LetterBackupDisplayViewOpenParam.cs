using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020056CA RID: 22218
	[RequiredMember]
	public class LetterBackupDisplayViewOpenParam : ILetterBackupDisplayViewOpenParam
	{
		// Token: 0x170087A7 RID: 34727
		// (get) Token: 0x06038832 RID: 231474 RVA: 0x00D6C611 File Offset: 0x00D6A811
		// (set) Token: 0x06038833 RID: 231475 RVA: 0x00D6C619 File Offset: 0x00D6A819
		[RequiredMember]
		public int LetterId { get; set; }

		// Token: 0x170087A8 RID: 34728
		// (get) Token: 0x06038834 RID: 231476 RVA: 0x00D6C622 File Offset: 0x00D6A822
		// (set) Token: 0x06038835 RID: 231477 RVA: 0x00D6C62A File Offset: 0x00D6A82A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IReadOnlyList<ITalkItem> Items { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170087A9 RID: 34729
		// (get) Token: 0x06038836 RID: 231478 RVA: 0x00D6C633 File Offset: 0x00D6A833
		// (set) Token: 0x06038837 RID: 231479 RVA: 0x00D6C63B File Offset: 0x00D6A83B
		public ELetterStyle? LetterStyle { get; set; }

		// Token: 0x06038838 RID: 231480 RVA: 0x00D6C644 File Offset: 0x00D6A844
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LetterBackupDisplayViewOpenParam()
		{
		}
	}
}
