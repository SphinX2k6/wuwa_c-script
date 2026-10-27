using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02005293 RID: 21139
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentMonsterProxy : OpponentFunctionAreaProxy
	{
		// Token: 0x17008286 RID: 33414
		// (get) Token: 0x060360E6 RID: 221414 RVA: 0x00CCAFD7 File Offset: 0x00CC91D7
		// (set) Token: 0x060360E7 RID: 221415 RVA: 0x00CCAFE4 File Offset: 0x00CC91E4
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

		// Token: 0x17008287 RID: 33415
		// (get) Token: 0x060360E8 RID: 221416 RVA: 0x00CCAFED File Offset: 0x00CC91ED
		public override bool IsMonster
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17008288 RID: 33416
		// (get) Token: 0x060360E9 RID: 221417 RVA: 0x00CCAFF0 File Offset: 0x00CC91F0
		public override bool IsNeedPreload
		{
			get
			{
				return this.Card != null && this.Card.Data.IsNormal;
			}
		}

		// Token: 0x060360EA RID: 221418 RVA: 0x00CCB00C File Offset: 0x00CC920C
		public OpponentMonsterProxy(int index, OpponentFunctionArea area) : base(index, area)
		{
		}

		// Token: 0x060360EB RID: 221419 RVA: 0x00CCB016 File Offset: 0x00CC9216
		protected override UUIItem GetCardAttachItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x060360EC RID: 221420 RVA: 0x00CCB024 File Offset: 0x00CC9224
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

		// Token: 0x060360ED RID: 221421 RVA: 0x00CCB070 File Offset: 0x00CC9270
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

		// Token: 0x060360EE RID: 221422 RVA: 0x00CCB0BC File Offset: 0x00CC92BC
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
