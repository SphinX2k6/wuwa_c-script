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
	// Token: 0x02003B9D RID: 15261
	public class RoleSkinRecommendView : UiTabViewBase
	{
		// Token: 0x060271D5 RID: 160213 RVA: 0x00AF1A03 File Offset: 0x00AEFC03
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060271D6 RID: 160214 RVA: 0x00AF1A28 File Offset: 0x00AEFC28
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinRecommendView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinRecommendView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060271D7 RID: 160215 RVA: 0x00AF1A6B File Offset: 0x00AEFC6B
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		}

		// Token: 0x060271D8 RID: 160216 RVA: 0x00AF1A89 File Offset: 0x00AEFC89
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		}

		// Token: 0x060271D9 RID: 160217 RVA: 0x00AF1AA7 File Offset: 0x00AEFCA7
		private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
		{
			if (this.RecommendData.RecommendId != goodsId)
			{
				return;
			}
			this.RefreshView();
		}

		// Token: 0x060271DA RID: 160218 RVA: 0x00AF1AC0 File Offset: 0x00AEFCC0
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			((tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null).PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x060271DB RID: 160219 RVA: 0x00AF1AFA File Offset: 0x00AEFCFA
		private void RefreshView()
		{
			this.RoleSkinItemContent.Refresh(this.RecommendData.Id);
		}

		// Token: 0x04015528 RID: 87336
		[Nullable(2)]
		private RoleSkinItemContent RoleSkinItemContent;

		// Token: 0x04015529 RID: 87337
		[Nullable(2)]
		private PayShopRecommendData RecommendData;

		// Token: 0x02009800 RID: 38912
		private enum EComponent
		{
			// Token: 0x0402F699 RID: 194201
			Content
		}
	}
}
