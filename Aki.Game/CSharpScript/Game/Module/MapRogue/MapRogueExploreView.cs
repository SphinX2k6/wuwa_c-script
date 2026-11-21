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
	// Token: 0x020045CA RID: 17866
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueExploreView : UiViewBase
	{
		// Token: 0x0602CF66 RID: 184166 RVA: 0x00C92C80 File Offset: 0x00C90E80
		public MapRogueExploreView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602CF67 RID: 184167 RVA: 0x00C92C8C File Offset: 0x00C90E8C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0602CF68 RID: 184168 RVA: 0x00C92CFC File Offset: 0x00C90EFC
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueExploreView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueExploreView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF69 RID: 184169 RVA: 0x00C92D40 File Offset: 0x00C90F40
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
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, rogueResInstGrid.Value.Title, Array.Empty<object>());
			GenericScrollViewNew<RogueExploreListItem, IExploreData> listLayout = this.ListLayout;
			if (listLayout == null)
			{
				return;
			}
			listLayout.RefreshByData(gameInfo.GetAllExplorationData(), null, true);
		}

		// Token: 0x0602CF6A RID: 184170 RVA: 0x00C92DC6 File Offset: 0x00C90FC6
		private RogueExploreListItem CreateItem()
		{
			return new RogueExploreListItem();
		}

		// Token: 0x0602CF6B RID: 184171 RVA: 0x00C92DCD File Offset: 0x00C90FCD
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x04018197 RID: 98711
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueExploreListItem, IExploreData> ListLayout;

		// Token: 0x04018198 RID: 98712
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
