using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.View.PunishReport
{
	// Token: 0x020059BD RID: 22973
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportSettlementView : UiViewBase
	{
		// Token: 0x0603A3CD RID: 238541 RVA: 0x00DD73D1 File Offset: 0x00DD55D1
		public PunishReportSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A3CE RID: 238542 RVA: 0x00DD73F0 File Offset: 0x00DD55F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A3CF RID: 238543 RVA: 0x00DD745C File Offset: 0x00DD565C
		protected override UniTask OnBeforeStartAsync()
		{
			PunishReportSettlementView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PunishReportSettlementView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D0 RID: 238544 RVA: 0x00DD74A0 File Offset: 0x00DD56A0
		private UniTask InitSuccessItem()
		{
			PunishReportSettlementView.<InitSuccessItem>d__8 <InitSuccessItem>d__;
			<InitSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSuccessItem>d__.<>4__this = this;
			<InitSuccessItem>d__.<>1__state = -1;
			<InitSuccessItem>d__.<>t__builder.Start<PunishReportSettlementView.<InitSuccessItem>d__8>(ref <InitSuccessItem>d__);
			return <InitSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3D1 RID: 238545 RVA: 0x00DD74E3 File Offset: 0x00DD56E3
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnRootSequenceClose), false);
		}

		// Token: 0x0603A3D2 RID: 238546 RVA: 0x00DD750E File Offset: 0x00DD570E
		protected override void OnAfterShow()
		{
			this.GameSuccessItem.ShowTip().Forget();
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
			}, 1000f, null, null, true, 1f);
		}

		// Token: 0x0603A3D3 RID: 238547 RVA: 0x00DD7544 File Offset: 0x00DD5744
		private void PlayConditionAnim()
		{
			foreach (PunishReportSettlementConditionItem punishReportSettlementConditionItem in this.ConditionItems)
			{
				punishReportSettlementConditionItem.PlaySequence().Finally(new Action(this.OnSequenceClose)).Forget();
			}
		}

		// Token: 0x0603A3D4 RID: 238548 RVA: 0x00DD75AC File Offset: 0x00DD57AC
		private void OnSequenceClose()
		{
			this.AnimFinishCount++;
			if (this.AnimFinishCount >= this.ConditionItems.Count)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					UiManager.Instance.CloseView(this.ViewInfo.Name, null);
				}, 2000f, null, null, true, 1f);
			}
		}

		// Token: 0x0603A3D5 RID: 238549 RVA: 0x00DD75FE File Offset: 0x00DD57FE
		private void OnRootSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start01")
			{
				this.PlayConditionAnim();
			}
		}

		// Token: 0x0401E606 RID: 124422
		private readonly PunishReportSettlementSuccessItem GameSuccessItem = new PunishReportSettlementSuccessItem();

		// Token: 0x0401E607 RID: 124423
		private readonly List<PunishReportSettlementConditionItem> ConditionItems = new List<PunishReportSettlementConditionItem>();

		// Token: 0x0401E608 RID: 124424
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E609 RID: 124425
		private int AnimFinishCount;

		// Token: 0x0200BC23 RID: 48163
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04038C75 RID: 232565
			ConditionItemRoot,
			// Token: 0x04038C76 RID: 232566
			ConditionItem
		}
	}
}
