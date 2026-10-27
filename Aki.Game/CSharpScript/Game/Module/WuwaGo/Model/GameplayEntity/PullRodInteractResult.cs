using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x0200474F RID: 18255
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class PullRodInteractResult : IPullRodInteractResult
	{
		// Token: 0x1700773D RID: 30525
		// (get) Token: 0x0602FB54 RID: 195412 RVA: 0x00B0D9D6 File Offset: 0x00B0BBD6
		// (set) Token: 0x0602FB55 RID: 195413 RVA: 0x00B0D9DE File Offset: 0x00B0BBDE
		[RequiredMember]
		public EGameplayEntityState PreviousState { get; set; }

		// Token: 0x1700773E RID: 30526
		// (get) Token: 0x0602FB56 RID: 195414 RVA: 0x00B0D9E7 File Offset: 0x00B0BBE7
		// (set) Token: 0x0602FB57 RID: 195415 RVA: 0x00B0D9EF File Offset: 0x00B0BBEF
		[RequiredMember]
		public EGameplayEntityState CurrentState { get; set; }

		// Token: 0x1700773F RID: 30527
		// (get) Token: 0x0602FB58 RID: 195416 RVA: 0x00B0D9F8 File Offset: 0x00B0BBF8
		// (set) Token: 0x0602FB59 RID: 195417 RVA: 0x00B0DA00 File Offset: 0x00B0BC00
		public IWuWaGoInteractStateAction StateAction { get; set; }

		// Token: 0x0602FB5A RID: 195418 RVA: 0x00B0DA09 File Offset: 0x00B0BC09
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PullRodInteractResult()
		{
		}
	}
}
