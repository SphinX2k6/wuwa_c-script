using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004705 RID: 18181
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class WuWaGoGridMoveParticipant : IWuWaGoGridMoveParticipant
	{
		// Token: 0x170076A8 RID: 30376
		// (get) Token: 0x0602F85A RID: 194650 RVA: 0x00B036FC File Offset: 0x00B018FC
		// (set) Token: 0x0602F85B RID: 194651 RVA: 0x00B03704 File Offset: 0x00B01904
		[RequiredMember]
		public string ParticipantKey { get; set; }

		// Token: 0x170076A9 RID: 30377
		// (get) Token: 0x0602F85C RID: 194652 RVA: 0x00B0370D File Offset: 0x00B0190D
		// (set) Token: 0x0602F85D RID: 194653 RVA: 0x00B03715 File Offset: 0x00B01915
		public int? MovedRoleId { get; set; }

		// Token: 0x170076AA RID: 30378
		// (get) Token: 0x0602F85E RID: 194654 RVA: 0x00B0371E File Offset: 0x00B0191E
		// (set) Token: 0x0602F85F RID: 194655 RVA: 0x00B03726 File Offset: 0x00B01926
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<IWuWaGoGridRelocationContext, IWuWaGoWorldMoveTarget> CreateWorldMoveTarget { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x170076AB RID: 30379
		// (get) Token: 0x0602F860 RID: 194656 RVA: 0x00B0372F File Offset: 0x00B0192F
		// (set) Token: 0x0602F861 RID: 194657 RVA: 0x00B03737 File Offset: 0x00B01937
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IWuWaGoGridRelocationContext> BeforeGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170076AC RID: 30380
		// (get) Token: 0x0602F862 RID: 194658 RVA: 0x00B03740 File Offset: 0x00B01940
		// (set) Token: 0x0602F863 RID: 194659 RVA: 0x00B03748 File Offset: 0x00B01948
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<IWuWaGoGridRelocationContext> CommitGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170076AD RID: 30381
		// (get) Token: 0x0602F864 RID: 194660 RVA: 0x00B03751 File Offset: 0x00B01951
		// (set) Token: 0x0602F865 RID: 194661 RVA: 0x00B03759 File Offset: 0x00B01959
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<IWuWaGoGridRelocationContext, UniTask> AfterGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0602F866 RID: 194662 RVA: 0x00B03762 File Offset: 0x00B01962
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public WuWaGoGridMoveParticipant()
		{
		}
	}
}
