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
	// Token: 0x0200425D RID: 16989
	[NullableContext(1)]
	[Nullable(0)]
	public class OpponentArea
	{
		// Token: 0x0602AF72 RID: 175986 RVA: 0x00C16BB0 File Offset: 0x00C14DB0
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

		// Token: 0x0602AF73 RID: 175987 RVA: 0x00C16BFC File Offset: 0x00C14DFC
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

		// Token: 0x0602AF74 RID: 175988 RVA: 0x00C16C48 File Offset: 0x00C14E48
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

		// Token: 0x0602AF75 RID: 175989 RVA: 0x00C16C94 File Offset: 0x00C14E94
		private UniTask InitCurveX()
		{
			OpponentArea.<InitCurveX>d__15 <InitCurveX>d__;
			<InitCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveX>d__.<>4__this = this;
			<InitCurveX>d__.<>1__state = -1;
			<InitCurveX>d__.<>t__builder.Start<OpponentArea.<InitCurveX>d__15>(ref <InitCurveX>d__);
			return <InitCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF76 RID: 175990 RVA: 0x00C16CD8 File Offset: 0x00C14ED8
		private UniTask InitDrawCardCurveY()
		{
			OpponentArea.<InitDrawCardCurveY>d__16 <InitDrawCardCurveY>d__;
			<InitDrawCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveY>d__.<>4__this = this;
			<InitDrawCardCurveY>d__.<>1__state = -1;
			<InitDrawCardCurveY>d__.<>t__builder.Start<OpponentArea.<InitDrawCardCurveY>d__16>(ref <InitDrawCardCurveY>d__);
			return <InitDrawCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF77 RID: 175991 RVA: 0x00C16D1C File Offset: 0x00C14F1C
		private UniTask InitDiscardCardCurveX()
		{
			OpponentArea.<InitDiscardCardCurveX>d__17 <InitDiscardCardCurveX>d__;
			<InitDiscardCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveX>d__.<>4__this = this;
			<InitDiscardCardCurveX>d__.<>1__state = -1;
			<InitDiscardCardCurveX>d__.<>t__builder.Start<OpponentArea.<InitDiscardCardCurveX>d__17>(ref <InitDiscardCardCurveX>d__);
			return <InitDiscardCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF78 RID: 175992 RVA: 0x00C16D60 File Offset: 0x00C14F60
		private UniTask InitDiscardCardCurveY()
		{
			OpponentArea.<InitDiscardCardCurveY>d__18 <InitDiscardCardCurveY>d__;
			<InitDiscardCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveY>d__.<>4__this = this;
			<InitDiscardCardCurveY>d__.<>1__state = -1;
			<InitDiscardCardCurveY>d__.<>t__builder.Start<OpponentArea.<InitDiscardCardCurveY>d__18>(ref <InitDiscardCardCurveY>d__);
			return <InitDiscardCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF79 RID: 175993 RVA: 0x00C16DA4 File Offset: 0x00C14FA4
		private UniTask InitMoveLocationCurve()
		{
			OpponentArea.<InitMoveLocationCurve>d__19 <InitMoveLocationCurve>d__;
			<InitMoveLocationCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveLocationCurve>d__.<>4__this = this;
			<InitMoveLocationCurve>d__.<>1__state = -1;
			<InitMoveLocationCurve>d__.<>t__builder.Start<OpponentArea.<InitMoveLocationCurve>d__19>(ref <InitMoveLocationCurve>d__);
			return <InitMoveLocationCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF7A RID: 175994 RVA: 0x00C16DE8 File Offset: 0x00C14FE8
		private UniTask InitRecycleCurve()
		{
			OpponentArea.<InitRecycleCurve>d__20 <InitRecycleCurve>d__;
			<InitRecycleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecycleCurve>d__.<>4__this = this;
			<InitRecycleCurve>d__.<>1__state = -1;
			<InitRecycleCurve>d__.<>t__builder.Start<OpponentArea.<InitRecycleCurve>d__20>(ref <InitRecycleCurve>d__);
			return <InitRecycleCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF7B RID: 175995 RVA: 0x00C16E2C File Offset: 0x00C1502C
		private UniTask InitCardCurve()
		{
			OpponentArea.<InitCardCurve>d__21 <InitCardCurve>d__;
			<InitCardCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardCurve>d__.<>4__this = this;
			<InitCardCurve>d__.<>1__state = -1;
			<InitCardCurve>d__.<>t__builder.Start<OpponentArea.<InitCardCurve>d__21>(ref <InitCardCurve>d__);
			return <InitCardCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF7C RID: 175996 RVA: 0x00C16E70 File Offset: 0x00C15070
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

		// Token: 0x0602AF7D RID: 175997 RVA: 0x00C16ED4 File Offset: 0x00C150D4
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
			this.AiManager = new PhantomArenaAiManager(proxy);
		}

		// Token: 0x0602AF7E RID: 175998 RVA: 0x00C16EEC File Offset: 0x00C150EC
		public UniTask StartAiOperation()
		{
			OpponentArea.<StartAiOperation>d__24 <StartAiOperation>d__;
			<StartAiOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartAiOperation>d__.<>4__this = this;
			<StartAiOperation>d__.<>1__state = -1;
			<StartAiOperation>d__.<>t__builder.Start<OpponentArea.<StartAiOperation>d__24>(ref <StartAiOperation>d__);
			return <StartAiOperation>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF7F RID: 175999 RVA: 0x00C16F2F File Offset: 0x00C1512F
		public void RefreshAll(bool isFromWorldDone)
		{
			this.RolePanel.RefreshAll(isFromWorldDone);
			this.FunctionalArea.RefreshAllBattleCard();
			this.RefreshFiledArea().Forget();
		}

		// Token: 0x0602AF80 RID: 176000 RVA: 0x00C16F53 File Offset: 0x00C15153
		public void RefreshLifeNumWithEffect()
		{
			this.RolePanel.RefreshLifeNumWithEffect();
		}

		// Token: 0x0602AF81 RID: 176001 RVA: 0x00C16F60 File Offset: 0x00C15160
		public void Clear()
		{
			this.AiManager.Clear();
		}

		// Token: 0x0602AF82 RID: 176002 RVA: 0x00C16F70 File Offset: 0x00C15170
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

		// Token: 0x0602AF83 RID: 176003 RVA: 0x00C16FBC File Offset: 0x00C151BC
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

		// Token: 0x0602AF84 RID: 176004 RVA: 0x00C17008 File Offset: 0x00C15208
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

		// Token: 0x0602AF85 RID: 176005 RVA: 0x00C17054 File Offset: 0x00C15254
		public UniTask RefreshFiledArea()
		{
			OpponentArea.<RefreshFiledArea>d__31 <RefreshFiledArea>d__;
			<RefreshFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFiledArea>d__.<>4__this = this;
			<RefreshFiledArea>d__.<>1__state = -1;
			<RefreshFiledArea>d__.<>t__builder.Start<OpponentArea.<RefreshFiledArea>d__31>(ref <RefreshFiledArea>d__);
			return <RefreshFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF86 RID: 176006 RVA: 0x00C17098 File Offset: 0x00C15298
		public UniTask LockFiledArea()
		{
			OpponentArea.<LockFiledArea>d__32 <LockFiledArea>d__;
			<LockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LockFiledArea>d__.<>4__this = this;
			<LockFiledArea>d__.<>1__state = -1;
			<LockFiledArea>d__.<>t__builder.Start<OpponentArea.<LockFiledArea>d__32>(ref <LockFiledArea>d__);
			return <LockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF87 RID: 176007 RVA: 0x00C170DC File Offset: 0x00C152DC
		public UniTask UnlockFiledArea()
		{
			OpponentArea.<UnlockFiledArea>d__33 <UnlockFiledArea>d__;
			<UnlockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UnlockFiledArea>d__.<>4__this = this;
			<UnlockFiledArea>d__.<>1__state = -1;
			<UnlockFiledArea>d__.<>t__builder.Start<OpponentArea.<UnlockFiledArea>d__33>(ref <UnlockFiledArea>d__);
			return <UnlockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF88 RID: 176008 RVA: 0x00C1711F File Offset: 0x00C1531F
		public void SwitchFieldState(bool isGamepad)
		{
			PhantomArenaFieldArea filedArea = this.FiledArea;
			if (filedArea != null)
			{
				filedArea.SwitchFieldState(!isGamepad);
			}
			this.RolePanel.SwitchFieldState(isGamepad);
		}

		// Token: 0x04017407 RID: 95239
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x04017408 RID: 95240
		public OpponentFunctionArea FunctionalArea;

		// Token: 0x04017409 RID: 95241
		public OpponentHandArea HandArea;

		// Token: 0x0401740A RID: 95242
		public PhantomArenaOpponentRolePanel RolePanel;

		// Token: 0x0401740B RID: 95243
		public PhantomArenaFieldArea FiledArea;

		// Token: 0x0401740C RID: 95244
		private PhantomArenaAiManager AiManager;

		// Token: 0x0401740D RID: 95245
		public UCurveFloat DrawCardCurveX;

		// Token: 0x0401740E RID: 95246
		public UCurveFloat DrawCardCurveY;

		// Token: 0x0401740F RID: 95247
		public UCurveFloat DiscardCardCurveX;

		// Token: 0x04017410 RID: 95248
		public UCurveFloat DiscardCardCurveY;

		// Token: 0x04017411 RID: 95249
		public UCurveFloat MoveLocationCurve;

		// Token: 0x04017412 RID: 95250
		public UCurveFloat RecycleCurve;
	}
}
