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
	// Token: 0x020045C8 RID: 17864
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueExploreEndView : UiViewBase
	{
		// Token: 0x0602CF5D RID: 184157 RVA: 0x00C92A73 File Offset: 0x00C90C73
		public MapRogueExploreEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602CF5E RID: 184158 RVA: 0x00C92A7C File Offset: 0x00C90C7C
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

		// Token: 0x0602CF5F RID: 184159 RVA: 0x00C92B54 File Offset: 0x00C90D54
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueExploreEndView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueExploreEndView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CF60 RID: 184160 RVA: 0x00C92B98 File Offset: 0x00C90D98
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

		// Token: 0x0602CF61 RID: 184161 RVA: 0x00C92C1E File Offset: 0x00C90E1E
		private RogueExploreListItem CreateItem()
		{
			return new RogueExploreListItem();
		}

		// Token: 0x0602CF62 RID: 184162 RVA: 0x00C92C25 File Offset: 0x00C90E25
		private void OnBackBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602CF63 RID: 184163 RVA: 0x00C92C2E File Offset: 0x00C90E2E
		private void OnBtnResultClick()
		{
			MapRogueController.Instance.RequestInstResultEnd().Forget();
		}

		// Token: 0x0602CF64 RID: 184164 RVA: 0x00C92C3F File Offset: 0x00C90E3F
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

		// Token: 0x04018190 RID: 98704
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueExploreListItem, IExploreData> ListLayout;

		// Token: 0x04018191 RID: 98705
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
