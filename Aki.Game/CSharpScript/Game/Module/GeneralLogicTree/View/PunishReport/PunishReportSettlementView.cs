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
	// Token: 0x02004996 RID: 18838
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportSettlementView : UiViewBase
	{
		// Token: 0x0602F2F4 RID: 193268 RVA: 0x00D268A9 File Offset: 0x00D24AA9
		public PunishReportSettlementView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2F5 RID: 193269 RVA: 0x00D268C8 File Offset: 0x00D24AC8
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

		// Token: 0x0602F2F6 RID: 193270 RVA: 0x00D26934 File Offset: 0x00D24B34
		protected override UniTask OnBeforeStartAsync()
		{
			PunishReportSettlementView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PunishReportSettlementView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F2F7 RID: 193271 RVA: 0x00D26978 File Offset: 0x00D24B78
		private UniTask InitSuccessItem()
		{
			PunishReportSettlementView.<InitSuccessItem>d__8 <InitSuccessItem>d__;
			<InitSuccessItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSuccessItem>d__.<>4__this = this;
			<InitSuccessItem>d__.<>1__state = -1;
			<InitSuccessItem>d__.<>t__builder.Start<PunishReportSettlementView.<InitSuccessItem>d__8>(ref <InitSuccessItem>d__);
			return <InitSuccessItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602F2F8 RID: 193272 RVA: 0x00D269BB File Offset: 0x00D24BBB
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnRootSequenceClose), false);
		}

		// Token: 0x0602F2F9 RID: 193273 RVA: 0x00D269E6 File Offset: 0x00D24BE6
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

		// Token: 0x0602F2FA RID: 193274 RVA: 0x00D26A1C File Offset: 0x00D24C1C
		private void PlayConditionAnim()
		{
			foreach (PunishReportSettlementConditionItem punishReportSettlementConditionItem in this.ConditionItems)
			{
				punishReportSettlementConditionItem.PlaySequence().Finally(new Action(this.OnSequenceClose)).Forget();
			}
		}

		// Token: 0x0602F2FB RID: 193275 RVA: 0x00D26A84 File Offset: 0x00D24C84
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

		// Token: 0x0602F2FC RID: 193276 RVA: 0x00D26AD6 File Offset: 0x00D24CD6
		private void OnRootSequenceClose(string sequenceName)
		{
			if (sequenceName == "Start01")
			{
				this.PlayConditionAnim();
			}
		}

		// Token: 0x040190A5 RID: 102565
		private readonly PunishReportSettlementSuccessItem GameSuccessItem = new PunishReportSettlementSuccessItem();

		// Token: 0x040190A6 RID: 102566
		private readonly List<PunishReportSettlementConditionItem> ConditionItems = new List<PunishReportSettlementConditionItem>();

		// Token: 0x040190A7 RID: 102567
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040190A8 RID: 102568
		private int AnimFinishCount;

		// Token: 0x0200A62E RID: 42542
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04033644 RID: 210500
			ConditionItemRoot,
			// Token: 0x04033645 RID: 210501
			ConditionItem
		}
	}
}
