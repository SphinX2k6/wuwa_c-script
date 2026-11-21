using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Motor
{
	// Token: 0x02003BA1 RID: 15265
	public class MotorSkinRecommendView : UiTabViewBase
	{
		// Token: 0x060271F4 RID: 160244 RVA: 0x00AF24DF File Offset: 0x00AF06DF
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060271F5 RID: 160245 RVA: 0x00AF2504 File Offset: 0x00AF0704
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinRecommendView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinRecommendView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060271F6 RID: 160246 RVA: 0x00AF2547 File Offset: 0x00AF0747
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnRefreshGoods));
		}

		// Token: 0x060271F7 RID: 160247 RVA: 0x00AF2565 File Offset: 0x00AF0765
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnRefreshGoods));
		}

		// Token: 0x060271F8 RID: 160248 RVA: 0x00AF2583 File Offset: 0x00AF0783
		[NullableContext(1)]
		private void OnRefreshGoods(PayItemSuccess _)
		{
			this.RefreshView();
		}

		// Token: 0x060271F9 RID: 160249 RVA: 0x00AF258C File Offset: 0x00AF078C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x060271FA RID: 160250 RVA: 0x00AF25C6 File Offset: 0x00AF07C6
		private void RefreshView()
		{
			this.MotorSkinItemContent.Refresh(this.RecommendData.Id);
		}

		// Token: 0x04015532 RID: 87346
		[Nullable(2)]
		private MotorSkinItemContent MotorSkinItemContent;

		// Token: 0x04015533 RID: 87347
		[Nullable(2)]
		private PayShopRecommendData RecommendData;

		// Token: 0x02009807 RID: 38919
		private enum EComponent
		{
			// Token: 0x0402F6BD RID: 194237
			Content
		}
	}
}
