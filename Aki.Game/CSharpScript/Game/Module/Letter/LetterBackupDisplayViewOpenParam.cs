using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020046A1 RID: 18081
	[RequiredMember]
	public class LetterBackupDisplayViewOpenParam : ILetterBackupDisplayViewOpenParam
	{
		// Token: 0x17005B6F RID: 23407
		// (get) Token: 0x0602D742 RID: 186178 RVA: 0x00CBABC9 File Offset: 0x00CB8DC9
		// (set) Token: 0x0602D743 RID: 186179 RVA: 0x00CBABD1 File Offset: 0x00CB8DD1
		[RequiredMember]
		public int LetterId { get; set; }

		// Token: 0x17005B70 RID: 23408
		// (get) Token: 0x0602D744 RID: 186180 RVA: 0x00CBABDA File Offset: 0x00CB8DDA
		// (set) Token: 0x0602D745 RID: 186181 RVA: 0x00CBABE2 File Offset: 0x00CB8DE2
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

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x0602D746 RID: 186182 RVA: 0x00CBABEB File Offset: 0x00CB8DEB
		// (set) Token: 0x0602D747 RID: 186183 RVA: 0x00CBABF3 File Offset: 0x00CB8DF3
		public ELetterStyle? LetterStyle { get; set; }

		// Token: 0x0602D748 RID: 186184 RVA: 0x00CBABFC File Offset: 0x00CB8DFC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LetterBackupDisplayViewOpenParam()
		{
		}
	}
}
