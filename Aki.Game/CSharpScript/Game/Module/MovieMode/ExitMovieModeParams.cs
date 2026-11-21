using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004365 RID: 17253
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class ExitMovieModeParams : IExitMovieModeParams
	{
		// Token: 0x1700574A RID: 22346
		// (get) Token: 0x0602B936 RID: 178486 RVA: 0x00C3D6D5 File Offset: 0x00C3B8D5
		// (set) Token: 0x0602B937 RID: 178487 RVA: 0x00C3D6DD File Offset: 0x00C3B8DD
		[RequiredMember]
		public float BlendTime { get; set; }

		// Token: 0x1700574B RID: 22347
		// (get) Token: 0x0602B938 RID: 178488 RVA: 0x00C3D6E6 File Offset: 0x00C3B8E6
		// (set) Token: 0x0602B939 RID: 178489 RVA: 0x00C3D6EE File Offset: 0x00C3B8EE
		public float? BlackFadeInTime { get; set; }

		// Token: 0x1700574C RID: 22348
		// (get) Token: 0x0602B93A RID: 178490 RVA: 0x00C3D6F7 File Offset: 0x00C3B8F7
		// (set) Token: 0x0602B93B RID: 178491 RVA: 0x00C3D6FF File Offset: 0x00C3B8FF
		public Func<UniTask> AfterBlackFadeInCallbackAsync { get; set; }

		// Token: 0x0602B93C RID: 178492 RVA: 0x00C3D708 File Offset: 0x00C3B908
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExitMovieModeParams()
		{
		}
	}
}
