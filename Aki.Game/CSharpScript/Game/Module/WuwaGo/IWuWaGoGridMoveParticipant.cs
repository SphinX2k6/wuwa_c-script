using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003634 RID: 13876
	[NullableContext(1)]
	public interface IWuWaGoGridMoveParticipant
	{
		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06024016 RID: 147478
		string ParticipantKey { get; }

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x06024017 RID: 147479
		int? MovedRoleId { get; }

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x06024018 RID: 147480
		// (set) Token: 0x06024019 RID: 147481
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		Func<IWuWaGoGridRelocationContext, IWuWaGoWorldMoveTarget> CreateWorldMoveTarget { [return: Nullable(new byte[]
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

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x0602401A RID: 147482
		// (set) Token: 0x0602401B RID: 147483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<IWuWaGoGridRelocationContext> BeforeGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x0602401C RID: 147484
		// (set) Token: 0x0602401D RID: 147485
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Action<IWuWaGoGridRelocationContext> CommitGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x0602401E RID: 147486
		// (set) Token: 0x0602401F RID: 147487
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Func<IWuWaGoGridRelocationContext, UniTask> AfterGridMove { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
