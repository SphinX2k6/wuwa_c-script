using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02004263 RID: 16995
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentMonsterProxy : OpponentFunctionAreaProxy
	{
		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x0602AFE1 RID: 176097 RVA: 0x00C186DB File Offset: 0x00C168DB
		// (set) Token: 0x0602AFE2 RID: 176098 RVA: 0x00C186E8 File Offset: 0x00C168E8
		public new PhantomArenaAreaMonsterItem AreaItem
		{
			get
			{
				return base.AreaItem as PhantomArenaAreaMonsterItem;
			}
			set
			{
				base.AreaItem = value;
			}
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x0602AFE3 RID: 176099 RVA: 0x00C186F1 File Offset: 0x00C168F1
		public override bool IsMonster
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x0602AFE4 RID: 176100 RVA: 0x00C186F4 File Offset: 0x00C168F4
		public override bool IsNeedPreload
		{
			get
			{
				return this.Card != null && this.Card.Data.IsNormal;
			}
		}

		// Token: 0x0602AFE5 RID: 176101 RVA: 0x00C18710 File Offset: 0x00C16910
		public OpponentMonsterProxy(int index, OpponentFunctionArea area) : base(index, area)
		{
		}

		// Token: 0x0602AFE6 RID: 176102 RVA: 0x00C1871A File Offset: 0x00C1691A
		protected override UUIItem GetCardAttachItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x0602AFE7 RID: 176103 RVA: 0x00C18728 File Offset: 0x00C16928
		public UniTask EvolveCard(int cardId)
		{
			OpponentMonsterProxy.<EvolveCard>d__9 <EvolveCard>d__;
			<EvolveCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EvolveCard>d__.<>4__this = this;
			<EvolveCard>d__.cardId = cardId;
			<EvolveCard>d__.<>1__state = -1;
			<EvolveCard>d__.<>t__builder.Start<OpponentMonsterProxy.<EvolveCard>d__9>(ref <EvolveCard>d__);
			return <EvolveCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFE8 RID: 176104 RVA: 0x00C18774 File Offset: 0x00C16974
		public UniTask CopyCard(int cardId)
		{
			OpponentMonsterProxy.<CopyCard>d__10 <CopyCard>d__;
			<CopyCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CopyCard>d__.<>4__this = this;
			<CopyCard>d__.cardId = cardId;
			<CopyCard>d__.<>1__state = -1;
			<CopyCard>d__.<>t__builder.Start<OpponentMonsterProxy.<CopyCard>d__10>(ref <CopyCard>d__);
			return <CopyCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFE9 RID: 176105 RVA: 0x00C187C0 File Offset: 0x00C169C0
		private UniTask DestroyLastCard(PhantomArenaCard lastCard)
		{
			OpponentMonsterProxy.<DestroyLastCard>d__11 <DestroyLastCard>d__;
			<DestroyLastCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyLastCard>d__.lastCard = lastCard;
			<DestroyLastCard>d__.<>1__state = -1;
			<DestroyLastCard>d__.<>t__builder.Start<OpponentMonsterProxy.<DestroyLastCard>d__11>(ref <DestroyLastCard>d__);
			return <DestroyLastCard>d__.<>t__builder.Task;
		}
	}
}
