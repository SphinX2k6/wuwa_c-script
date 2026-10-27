using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005382 RID: 21378
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ExitMovieModeParams : IExitMovieModeParams
	{
		// Token: 0x1700837E RID: 33662
		// (get) Token: 0x060369F0 RID: 223728 RVA: 0x00CEE7AD File Offset: 0x00CEC9AD
		// (set) Token: 0x060369F1 RID: 223729 RVA: 0x00CEE7B5 File Offset: 0x00CEC9B5
		[RequiredMember]
		public float BlendTime { get; set; }

		// Token: 0x1700837F RID: 33663
		// (get) Token: 0x060369F2 RID: 223730 RVA: 0x00CEE7BE File Offset: 0x00CEC9BE
		// (set) Token: 0x060369F3 RID: 223731 RVA: 0x00CEE7C6 File Offset: 0x00CEC9C6
		public float? BlackFadeInTime { get; set; }

		// Token: 0x17008380 RID: 33664
		// (get) Token: 0x060369F4 RID: 223732 RVA: 0x00CEE7CF File Offset: 0x00CEC9CF
		// (set) Token: 0x060369F5 RID: 223733 RVA: 0x00CEE7D7 File Offset: 0x00CEC9D7
		public Func<UniTask> AfterBlackFadeInCallbackAsync { get; set; }

		// Token: 0x060369F6 RID: 223734 RVA: 0x00CEE7E0 File Offset: 0x00CEC9E0
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExitMovieModeParams()
		{
		}
	}
}
