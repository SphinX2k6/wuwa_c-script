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
	// Token: 0x020055F4 RID: 22004
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueExploreView : UiViewBase
	{
		// Token: 0x06038068 RID: 229480 RVA: 0x00D44F38 File Offset: 0x00D43138
		public MapRogueExploreView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038069 RID: 229481 RVA: 0x00D44F44 File Offset: 0x00D43144
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

		// Token: 0x0603806A RID: 229482 RVA: 0x00D44FB4 File Offset: 0x00D431B4
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueExploreView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueExploreView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603806B RID: 229483 RVA: 0x00D44FF8 File Offset: 0x00D431F8
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

		// Token: 0x0603806C RID: 229484 RVA: 0x00D4507E File Offset: 0x00D4327E
		private RogueExploreListItem CreateItem()
		{
			return new RogueExploreListItem();
		}

		// Token: 0x0603806D RID: 229485 RVA: 0x00D45085 File Offset: 0x00D43285
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401D70C RID: 120588
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueExploreListItem, IExploreData> ListLayout;

		// Token: 0x0401D70D RID: 120589
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
