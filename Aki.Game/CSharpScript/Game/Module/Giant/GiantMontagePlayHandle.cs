using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005958 RID: 22872
	[RequiredMember]
	public class GiantMontagePlayHandle
	{
		// Token: 0x17008B20 RID: 35616
		// (get) Token: 0x0603A074 RID: 237684 RVA: 0x00DCB172 File Offset: 0x00DC9372
		// (set) Token: 0x0603A075 RID: 237685 RVA: 0x00DCB17A File Offset: 0x00DC937A
		[RequiredMember]
		public bool IsHoldAtEnd { get; set; }

		// Token: 0x17008B21 RID: 35617
		// (get) Token: 0x0603A076 RID: 237686 RVA: 0x00DCB183 File Offset: 0x00DC9383
		// (set) Token: 0x0603A077 RID: 237687 RVA: 0x00DCB18B File Offset: 0x00DC938B
		[RequiredMember]
		public UniTask BlendOut { get; set; }

		// Token: 0x0603A078 RID: 237688 RVA: 0x00DCB194 File Offset: 0x00DC9394
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantMontagePlayHandle()
		{
		}
	}
}
