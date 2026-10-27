using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Ai;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x0200528D RID: 21133
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentArea
	{
		// Token: 0x06036077 RID: 221303 RVA: 0x00CC94AC File Offset: 0x00CC76AC
		private UniTask InitFunctionalArea(UUIItem functionalAreaItem)
		{
			OpponentArea.<InitFunctionalArea>d__12 <InitFunctionalArea>d__;
			<InitFunctionalArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFunctionalArea>d__.<>4__this = this;
			<InitFunctionalArea>d__.functionalAreaItem = functionalAreaItem;
			<InitFunctionalArea>d__.<>1__state = -1;
			<InitFunctionalArea>d__.<>t__builder.Start<OpponentArea.<InitFunctionalArea>d__12>(ref <InitFunctionalArea>d__);
			return <InitFunctionalArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036078 RID: 221304 RVA: 0x00CC94F8 File Offset: 0x00CC76F8
		private UniTask InitRoleItem(UUIItem roleItem)
		{
			OpponentArea.<InitRoleItem>d__13 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.roleItem = roleItem;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<OpponentArea.<InitRoleItem>d__13>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036079 RID: 221305 RVA: 0x00CC9544 File Offset: 0x00CC7744
		private UniTask InitHandArea(UUILayoutBase handAreaItem)
		{
			OpponentArea.<InitHandArea>d__14 <InitHandArea>d__;
			<InitHandArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHandArea>d__.<>4__this = this;
			<InitHandArea>d__.handAreaItem = handAreaItem;
			<InitHandArea>d__.<>1__state = -1;
			<InitHandArea>d__.<>t__builder.Start<OpponentArea.<InitHandArea>d__14>(ref <InitHandArea>d__);
			return <InitHandArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603607A RID: 221306 RVA: 0x00CC9590 File Offset: 0x00CC7790
		private UniTask InitCurveX()
		{
			OpponentArea.<InitCurveX>d__15 <InitCurveX>d__;
			<InitCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveX>d__.<>4__this = this;
			<InitCurveX>d__.<>1__state = -1;
			<InitCurveX>d__.<>t__builder.Start<OpponentArea.<InitCurveX>d__15>(ref <InitCurveX>d__);
			return <InitCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0603607B RID: 221307 RVA: 0x00CC95D4 File Offset: 0x00CC77D4
		private UniTask InitDrawCardCurveY()
		{
			OpponentArea.<InitDrawCardCurveY>d__16 <InitDrawCardCurveY>d__;
			<InitDrawCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveY>d__.<>4__this = this;
			<InitDrawCardCurveY>d__.<>1__state = -1;
			<InitDrawCardCurveY>d__.<>t__builder.Start<OpponentArea.<InitDrawCardCurveY>d__16>(ref <InitDrawCardCurveY>d__);
			return <InitDrawCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0603607C RID: 221308 RVA: 0x00CC9618 File Offset: 0x00CC7818
		private UniTask InitDiscardCardCurveX()
		{
			OpponentArea.<InitDiscardCardCurveX>d__17 <InitDiscardCardCurveX>d__;
			<InitDiscardCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveX>d__.<>4__this = this;
			<InitDiscardCardCurveX>d__.<>1__state = -1;
			<InitDiscardCardCurveX>d__.<>t__builder.Start<OpponentArea.<InitDiscardCardCurveX>d__17>(ref <InitDiscardCardCurveX>d__);
			return <InitDiscardCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0603607D RID: 221309 RVA: 0x00CC965C File Offset: 0x00CC785C
		private UniTask InitDiscardCardCurveY()
		{
			OpponentArea.<InitDiscardCardCurveY>d__18 <InitDiscardCardCurveY>d__;
			<InitDiscardCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveY>d__.<>4__this = this;
			<InitDiscardCardCurveY>d__.<>1__state = -1;
			<InitDiscardCardCurveY>d__.<>t__builder.Start<OpponentArea.<InitDiscardCardCurveY>d__18>(ref <InitDiscardCardCurveY>d__);
			return <InitDiscardCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0603607E RID: 221310 RVA: 0x00CC96A0 File Offset: 0x00CC78A0
		private UniTask InitMoveLocationCurve()
		{
			OpponentArea.<InitMoveLocationCurve>d__19 <InitMoveLocationCurve>d__;
			<InitMoveLocationCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveLocationCurve>d__.<>4__this = this;
			<InitMoveLocationCurve>d__.<>1__state = -1;
			<InitMoveLocationCurve>d__.<>t__builder.Start<OpponentArea.<InitMoveLocationCurve>d__19>(ref <InitMoveLocationCurve>d__);
			return <InitMoveLocationCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0603607F RID: 221311 RVA: 0x00CC96E4 File Offset: 0x00CC78E4
		private UniTask InitRecycleCurve()
		{
			OpponentArea.<InitRecycleCurve>d__20 <InitRecycleCurve>d__;
			<InitRecycleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecycleCurve>d__.<>4__this = this;
			<InitRecycleCurve>d__.<>1__state = -1;
			<InitRecycleCurve>d__.<>t__builder.Start<OpponentArea.<InitRecycleCurve>d__20>(ref <InitRecycleCurve>d__);
			return <InitRecycleCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06036080 RID: 221312 RVA: 0x00CC9728 File Offset: 0x00CC7928
		private UniTask InitCardCurve()
		{
			OpponentArea.<InitCardCurve>d__21 <InitCardCurve>d__;
			<InitCardCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardCurve>d__.<>4__this = this;
			<InitCardCurve>d__.<>1__state = -1;
			<InitCardCurve>d__.<>t__builder.Start<OpponentArea.<InitCardCurve>d__21>(ref <InitCardCurve>d__);
			return <InitCardCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06036081 RID: 221313 RVA: 0x00CC976C File Offset: 0x00CC796C
		public UniTask InitArea(UUILayoutBase handAreaItem, UUIItem functionalAreaItem, UUIItem roleItem, UUIItem filedAreaItem)
		{
			OpponentArea.<InitArea>d__22 <InitArea>d__;
			<InitArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitArea>d__.<>4__this = this;
			<InitArea>d__.handAreaItem = handAreaItem;
			<InitArea>d__.functionalAreaItem = functionalAreaItem;
			<InitArea>d__.roleItem = roleItem;
			<InitArea>d__.filedAreaItem = filedAreaItem;
			<InitArea>d__.<>1__state = -1;
			<InitArea>d__.<>t__builder.Start<OpponentArea.<InitArea>d__22>(ref <InitArea>d__);
			return <InitArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036082 RID: 221314 RVA: 0x00CC97D0 File Offset: 0x00CC79D0
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
			this.AiManager = new PhantomArenaAiManager(proxy);
		}

		// Token: 0x06036083 RID: 221315 RVA: 0x00CC97E8 File Offset: 0x00CC79E8
		public UniTask StartAiOperation()
		{
			OpponentArea.<StartAiOperation>d__24 <StartAiOperation>d__;
			<StartAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAiOperation>d__.<>4__this = this;
			<StartAiOperation>d__.<>1__state = -1;
			<StartAiOperation>d__.<>t__builder.Start<OpponentArea.<StartAiOperation>d__24>(ref <StartAiOperation>d__);
			return <StartAiOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06036084 RID: 221316 RVA: 0x00CC982B File Offset: 0x00CC7A2B
		public void RefreshAll(bool isFromWorldDone)
		{
			this.RolePanel.RefreshAll(isFromWorldDone);
			this.FunctionalArea.RefreshAllBattleCard();
			this.RefreshFiledArea().Forget();
		}

		// Token: 0x06036085 RID: 221317 RVA: 0x00CC984F File Offset: 0x00CC7A4F
		public void RefreshLifeNumWithEffect()
		{
			this.RolePanel.RefreshLifeNumWithEffect();
		}

		// Token: 0x06036086 RID: 221318 RVA: 0x00CC985C File Offset: 0x00CC7A5C
		public void Clear()
		{
			this.AiManager.Clear();
		}

		// Token: 0x06036087 RID: 221319 RVA: 0x00CC986C File Offset: 0x00CC7A6C
		public UniTask CallHandCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			OpponentArea.<CallHandCardListToFight>d__28 <CallHandCardListToFight>d__;
			<CallHandCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallHandCardListToFight>d__.<>4__this = this;
			<CallHandCardListToFight>d__.cardInfoList = cardInfoList;
			<CallHandCardListToFight>d__.<>1__state = -1;
			<CallHandCardListToFight>d__.<>t__builder.Start<OpponentArea.<CallHandCardListToFight>d__28>(ref <CallHandCardListToFight>d__);
			return <CallHandCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x06036088 RID: 221320 RVA: 0x00CC98B8 File Offset: 0x00CC7AB8
		public UniTask CallLibraryCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			OpponentArea.<CallLibraryCardListToFight>d__29 <CallLibraryCardListToFight>d__;
			<CallLibraryCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallLibraryCardListToFight>d__.<>4__this = this;
			<CallLibraryCardListToFight>d__.cardInfoList = cardInfoList;
			<CallLibraryCardListToFight>d__.<>1__state = -1;
			<CallLibraryCardListToFight>d__.<>t__builder.Start<OpponentArea.<CallLibraryCardListToFight>d__29>(ref <CallLibraryCardListToFight>d__);
			return <CallLibraryCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x06036089 RID: 221321 RVA: 0x00CC9904 File Offset: 0x00CC7B04
		private UniTask InitFiledArea(UUIItem filedAreaItem)
		{
			OpponentArea.<InitFiledArea>d__30 <InitFiledArea>d__;
			<InitFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFiledArea>d__.<>4__this = this;
			<InitFiledArea>d__.filedAreaItem = filedAreaItem;
			<InitFiledArea>d__.<>1__state = -1;
			<InitFiledArea>d__.<>t__builder.Start<OpponentArea.<InitFiledArea>d__30>(ref <InitFiledArea>d__);
			return <InitFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603608A RID: 221322 RVA: 0x00CC9950 File Offset: 0x00CC7B50
		public UniTask RefreshFiledArea()
		{
			OpponentArea.<RefreshFiledArea>d__31 <RefreshFiledArea>d__;
			<RefreshFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFiledArea>d__.<>4__this = this;
			<RefreshFiledArea>d__.<>1__state = -1;
			<RefreshFiledArea>d__.<>t__builder.Start<OpponentArea.<RefreshFiledArea>d__31>(ref <RefreshFiledArea>d__);
			return <RefreshFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603608B RID: 221323 RVA: 0x00CC9994 File Offset: 0x00CC7B94
		public UniTask LockFiledArea()
		{
			OpponentArea.<LockFiledArea>d__32 <LockFiledArea>d__;
			<LockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LockFiledArea>d__.<>4__this = this;
			<LockFiledArea>d__.<>1__state = -1;
			<LockFiledArea>d__.<>t__builder.Start<OpponentArea.<LockFiledArea>d__32>(ref <LockFiledArea>d__);
			return <LockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603608C RID: 221324 RVA: 0x00CC99D8 File Offset: 0x00CC7BD8
		public UniTask UnlockFiledArea()
		{
			OpponentArea.<UnlockFiledArea>d__33 <UnlockFiledArea>d__;
			<UnlockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UnlockFiledArea>d__.<>4__this = this;
			<UnlockFiledArea>d__.<>1__state = -1;
			<UnlockFiledArea>d__.<>t__builder.Start<OpponentArea.<UnlockFiledArea>d__33>(ref <UnlockFiledArea>d__);
			return <UnlockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603608D RID: 221325 RVA: 0x00CC9A1B File Offset: 0x00CC7C1B
		public void SwitchFieldState(bool isGamepad)
		{
			PhantomArenaFieldArea filedArea = this.FiledArea;
			if (filedArea != null)
			{
				filedArea.SwitchFieldState(!isGamepad);
			}
			this.RolePanel.SwitchFieldState(isGamepad);
		}

		// Token: 0x0401C9D2 RID: 117202
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401C9D3 RID: 117203
		public OpponentFunctionArea FunctionalArea;

		// Token: 0x0401C9D4 RID: 117204
		public OpponentHandArea HandArea;

		// Token: 0x0401C9D5 RID: 117205
		public PhantomArenaOpponentRolePanel RolePanel;

		// Token: 0x0401C9D6 RID: 117206
		public PhantomArenaFieldArea FiledArea;

		// Token: 0x0401C9D7 RID: 117207
		private PhantomArenaAiManager AiManager;

		// Token: 0x0401C9D8 RID: 117208
		public UCurveFloat DrawCardCurveX;

		// Token: 0x0401C9D9 RID: 117209
		public UCurveFloat DrawCardCurveY;

		// Token: 0x0401C9DA RID: 117210
		public UCurveFloat DiscardCardCurveX;

		// Token: 0x0401C9DB RID: 117211
		public UCurveFloat DiscardCardCurveY;

		// Token: 0x0401C9DC RID: 117212
		public UCurveFloat MoveLocationCurve;

		// Token: 0x0401C9DD RID: 117213
		public UCurveFloat RecycleCurve;
	}
}
