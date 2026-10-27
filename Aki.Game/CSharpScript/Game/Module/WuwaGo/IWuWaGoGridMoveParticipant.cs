using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004704 RID: 18180
	[NullableContext(1)]
	public interface IWuWaGoGridMoveParticipant
	{
		// Token: 0x170076A2 RID: 30370
		// (get) Token: 0x0602F850 RID: 194640
		string ParticipantKey { get; }

		// Token: 0x170076A3 RID: 30371
		// (get) Token: 0x0602F851 RID: 194641
		int? MovedRoleId { get; }

		// Token: 0x170076A4 RID: 30372
		// (get) Token: 0x0602F852 RID: 194642
		// (set) Token: 0x0602F853 RID: 194643
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

		// Token: 0x170076A5 RID: 30373
		// (get) Token: 0x0602F854 RID: 194644
		// (set) Token: 0x0602F855 RID: 194645
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

		// Token: 0x170076A6 RID: 30374
		// (get) Token: 0x0602F856 RID: 194646
		// (set) Token: 0x0602F857 RID: 194647
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

		// Token: 0x170076A7 RID: 30375
		// (get) Token: 0x0602F858 RID: 194648
		// (set) Token: 0x0602F859 RID: 194649
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
