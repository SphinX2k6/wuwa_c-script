using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x020034A1 RID: 13473
	[NullableContext(1)]
	[Nullable(0)]
	internal class GameCommandWithValidators<[Nullable(0)] T> : IGameCommand<T>, IGameCommandBase where T : ICommandType
	{
		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06022549 RID: 140617 RVA: 0x009B91A5 File Offset: 0x009B73A5
		// (set) Token: 0x0602254A RID: 140618 RVA: 0x009B91AD File Offset: 0x009B73AD
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<TCommandHandleParams<T>> Execute { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x0602254B RID: 140619 RVA: 0x009B91B6 File Offset: 0x009B73B6
		// (set) Token: 0x0602254C RID: 140620 RVA: 0x009B91BE File Offset: 0x009B73BE
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<TCommandHandleParams<T>> Undo { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x0602254D RID: 140621 RVA: 0x009B91C7 File Offset: 0x009B73C7
		// (set) Token: 0x0602254E RID: 140622 RVA: 0x009B91CF File Offset: 0x009B73CF
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TCommandHandleParams<T> Params { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0602254F RID: 140623 RVA: 0x009B91D8 File Offset: 0x009B73D8
		public void AddValidator(IValidator validator)
		{
			this.Validators.Add(validator);
		}

		// Token: 0x06022550 RID: 140624 RVA: 0x009B91E7 File Offset: 0x009B73E7
		public void RemoveValidator(IValidator validator)
		{
			this.Validators.Remove(validator);
		}

		// Token: 0x04012E75 RID: 77429
		public HashSet<IValidator> Validators = new HashSet<IValidator>();
	}
}
