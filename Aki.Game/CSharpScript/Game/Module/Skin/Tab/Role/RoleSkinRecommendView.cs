using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Role
{
	// Token: 0x02004BEC RID: 19436
	public class RoleSkinRecommendView : UiTabViewBase
	{
		// Token: 0x06032431 RID: 205873 RVA: 0x00BAD483 File Offset: 0x00BAB683
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06032432 RID: 205874 RVA: 0x00BAD4A8 File Offset: 0x00BAB6A8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinRecommendView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinRecommendView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032433 RID: 205875 RVA: 0x00BAD4EB File Offset: 0x00BAB6EB
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		}

		// Token: 0x06032434 RID: 205876 RVA: 0x00BAD509 File Offset: 0x00BAB709
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		}

		// Token: 0x06032435 RID: 205877 RVA: 0x00BAD527 File Offset: 0x00BAB727
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			if (this.RecommendData.RecommendId != goodsId)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x06032436 RID: 205878 RVA: 0x00BAD540 File Offset: 0x00BAB740
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06032437 RID: 205879 RVA: 0x00BAD57A File Offset: 0x00BAB77A
		private void RefreshView()
		{
			this.RoleSkinItemContent.Refresh(this.RecommendData.Id);
		}

		// Token: 0x0401ABCD RID: 109517
		[Nullable(2)]
		private RoleSkinItemContent RoleSkinItemContent;

		// Token: 0x0401ABCE RID: 109518
		[Nullable(2)]
		private PayShopRecommendData RecommendData;

		// Token: 0x0200ADE1 RID: 44513
		private enum EComponent
		{
			// Token: 0x04034CF2 RID: 216306
			Content
		}
	}
}
