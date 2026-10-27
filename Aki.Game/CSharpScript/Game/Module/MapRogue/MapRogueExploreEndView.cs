using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055F2 RID: 22002
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueExploreEndView : UiViewBase
	{
		// Token: 0x0603805F RID: 229471 RVA: 0x00D44D2B File Offset: 0x00D42F2B
		public MapRogueExploreEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038060 RID: 229472 RVA: 0x00D44D34 File Offset: 0x00D42F34
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnBtnResultClick)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnBtnSaveFileClick))
			};
		}

		// Token: 0x06038061 RID: 229473 RVA: 0x00D44E0C File Offset: 0x00D4300C
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueExploreEndView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueExploreEndView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038062 RID: 229474 RVA: 0x00D44E50 File Offset: 0x00D43050
		protected override void OnBeforeShow()
		{
			MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
			if (gameInfo == null)
			{
				return;
			}
			MapRogueConfig instance = MapRogueConfig.Instance;
			RogueResInstGrid? rogueResInstGrid = (instance != null) ? instance.GetInsGridConfigByInstId(gameInfo.InstanceId) : null;
			if (rogueResInstGrid == null)
			{
				return;
			}
			UUIText text = base.GetText(5);
			LguiUtil.Instance.SetLocalTextNew(text, rogueResInstGrid.Value.Title, Array.Empty<object>());
			GenericScrollViewNew<RogueExploreListItem, IExploreData> listLayout = this.ListLayout;
			if (listLayout == null)
			{
				return;
			}
			listLayout.RefreshByData(gameInfo.GetAllExplorationData(), null, true);
		}

		// Token: 0x06038063 RID: 229475 RVA: 0x00D44ED6 File Offset: 0x00D430D6
		private RogueExploreListItem CreateItem()
		{
			return new RogueExploreListItem();
		}

		// Token: 0x06038064 RID: 229476 RVA: 0x00D44EDD File Offset: 0x00D430DD
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038065 RID: 229477 RVA: 0x00D44EE6 File Offset: 0x00D430E6
		private void OnBtnResultClick()
		{
			MapRogueController.Instance.RequestInstResultEnd().Forget();
		}

		// Token: 0x06038066 RID: 229478 RVA: 0x00D44EF7 File Offset: 0x00D430F7
		private void OnBtnSaveFileClick()
		{
			if ((this.OpenParam as ExploreEndViewData).ExitToMap)
			{
				MapRogueController.Instance.RequestBackToMap(delegate(bool success)
				{
					if (success)
					{
						base.CloseMe(null);
					}
				});
				return;
			}
			MapRogueController.Instance.RequestInstLeave();
		}

		// Token: 0x0401D705 RID: 120581
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueExploreListItem, IExploreData> ListLayout;

		// Token: 0x0401D706 RID: 120582
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
