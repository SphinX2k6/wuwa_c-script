using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x0200687C RID: 26748
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class NormalInteractionMode : IInteractionMode
	{
		// Token: 0x170097AB RID: 38827
		// (get) Token: 0x06042C84 RID: 273540 RVA: 0x010410CD File Offset: 0x0103F2CD
		public EInteractionModeKind Kind
		{
			get
			{
				return EInteractionModeKind.Normal;
			}
		}

		// Token: 0x170097AC RID: 38828
		// (get) Token: 0x06042C85 RID: 273541 RVA: 0x010410D0 File Offset: 0x0103F2D0
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x170097AD RID: 38829
		// (get) Token: 0x06042C86 RID: 273542 RVA: 0x010410D8 File Offset: 0x0103F2D8
		public ICommitStrategy CommitStrategy
		{
			get
			{
				return this.Immediate;
			}
		}

		// Token: 0x06042C87 RID: 273543 RVA: 0x010410E0 File Offset: 0x0103F2E0
		public NormalInteractionMode(ActivityDangoBrawlData data)
		{
			this.Data = data;
			this.Immediate = new ImmediateCommitStrategy(data);
		}

		// Token: 0x06042C88 RID: 273544 RVA: 0x010410FB File Offset: 0x0103F2FB
		public bool AllowInteract(int configId)
		{
			return true;
		}

		// Token: 0x06042C89 RID: 273545 RVA: 0x010410FE File Offset: 0x0103F2FE
		public bool AllowBuyShopSlot()
		{
			return true;
		}

		// Token: 0x06042C8A RID: 273546 RVA: 0x01041101 File Offset: 0x0103F301
		public bool TryEnter()
		{
			this.m_IsActive = true;
			return true;
		}

		// Token: 0x06042C8B RID: 273547 RVA: 0x0104110B File Offset: 0x0103F30B
		[NullableContext(0)]
		public UniTask<bool> TryExit()
		{
			this.m_IsActive = false;
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x06042C8C RID: 273548 RVA: 0x0104111A File Offset: 0x0103F31A
		public void Discard()
		{
		}

		// Token: 0x06042C8D RID: 273549 RVA: 0x0104111C File Offset: 0x0103F31C
		public void EnqueueBagToBench(int uid)
		{
		}

		// Token: 0x04022C1F RID: 142367
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x04022C20 RID: 142368
		private readonly ImmediateCommitStrategy Immediate;

		// Token: 0x04022C21 RID: 142369
		private bool m_IsActive;
	}
}
