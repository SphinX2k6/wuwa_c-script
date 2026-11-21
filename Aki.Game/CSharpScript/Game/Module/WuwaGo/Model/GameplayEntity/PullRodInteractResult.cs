using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity
{
	// Token: 0x02003680 RID: 13952
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class PullRodInteractResult : IPullRodInteractResult
	{
		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x0602431E RID: 148254 RVA: 0x00A3D9B6 File Offset: 0x00A3BBB6
		// (set) Token: 0x0602431F RID: 148255 RVA: 0x00A3D9BE File Offset: 0x00A3BBBE
		[RequiredMember]
		public EGameplayEntityState PreviousState { get; set; }

		// Token: 0x170049FA RID: 18938
		// (get) Token: 0x06024320 RID: 148256 RVA: 0x00A3D9C7 File Offset: 0x00A3BBC7
		// (set) Token: 0x06024321 RID: 148257 RVA: 0x00A3D9CF File Offset: 0x00A3BBCF
		[RequiredMember]
		public EGameplayEntityState CurrentState { get; set; }

		// Token: 0x170049FB RID: 18939
		// (get) Token: 0x06024322 RID: 148258 RVA: 0x00A3D9D8 File Offset: 0x00A3BBD8
		// (set) Token: 0x06024323 RID: 148259 RVA: 0x00A3D9E0 File Offset: 0x00A3BBE0
		public IWuWaGoInteractStateAction StateAction { get; set; }

		// Token: 0x06024324 RID: 148260 RVA: 0x00A3D9E9 File Offset: 0x00A3BBE9
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PullRodInteractResult()
		{
		}
	}
}
