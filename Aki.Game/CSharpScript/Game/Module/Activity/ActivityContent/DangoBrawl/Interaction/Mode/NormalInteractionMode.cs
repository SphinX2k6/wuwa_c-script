using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x020057CC RID: 22476
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class NormalInteractionMode : IInteractionMode
	{
		// Token: 0x17006AEC RID: 27372
		// (get) Token: 0x060377DB RID: 227291 RVA: 0x00F825AD File Offset: 0x00F807AD
		public EInteractionModeKind Kind
		{
			get
			{
				return EInteractionModeKind.Normal;
			}
		}

		// Token: 0x17006AED RID: 27373
		// (get) Token: 0x060377DC RID: 227292 RVA: 0x00F825B0 File Offset: 0x00F807B0
		public bool IsActive
		{
			get
			{
				return this.m_IsActive;
			}
		}

		// Token: 0x17006AEE RID: 27374
		// (get) Token: 0x060377DD RID: 227293 RVA: 0x00F825B8 File Offset: 0x00F807B8
		public ICommitStrategy CommitStrategy
		{
			get
			{
				return this.Immediate;
			}
		}

		// Token: 0x060377DE RID: 227294 RVA: 0x00F825C0 File Offset: 0x00F807C0
		public NormalInteractionMode(ActivityDangoBrawlData data)
		{
			this.Data = data;
			this.Immediate = new ImmediateCommitStrategy(data);
		}

		// Token: 0x060377DF RID: 227295 RVA: 0x00F825DB File Offset: 0x00F807DB
		public bool AllowInteract(int configId)
		{
			return true;
		}

		// Token: 0x060377E0 RID: 227296 RVA: 0x00F825DE File Offset: 0x00F807DE
		public bool AllowBuyShopSlot()
		{
			return true;
		}

		// Token: 0x060377E1 RID: 227297 RVA: 0x00F825E1 File Offset: 0x00F807E1
		public bool TryEnter()
		{
			this.m_IsActive = true;
			return true;
		}

		// Token: 0x060377E2 RID: 227298 RVA: 0x00F825EB File Offset: 0x00F807EB
		[NullableContext(0)]
		public UniTask<bool> TryExit()
		{
			this.m_IsActive = false;
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x060377E3 RID: 227299 RVA: 0x00F825FA File Offset: 0x00F807FA
		public void Discard()
		{
		}

		// Token: 0x060377E4 RID: 227300 RVA: 0x00F825FC File Offset: 0x00F807FC
		public void EnqueueBagToBench(int uid)
		{
		}

		// Token: 0x0401D47C RID: 119932
		private readonly ActivityDangoBrawlData Data;

		// Token: 0x0401D47D RID: 119933
		private readonly ImmediateCommitStrategy Immediate;

		// Token: 0x0401D47E RID: 119934
		private bool m_IsActive;
	}
}
