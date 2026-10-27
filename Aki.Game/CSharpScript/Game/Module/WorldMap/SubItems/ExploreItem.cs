using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubItems
{
	// Token: 0x0200484B RID: 18507
	public class ExploreItem : UiPanelBase
	{
		// Token: 0x060306F5 RID: 198389 RVA: 0x00B3ED08 File Offset: 0x00B3CF08
		[NullableContext(1)]
		public UniTask Init(UUIItem uiItem)
		{
			ExploreItem.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.uiItem = uiItem;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<ExploreItem.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060306F6 RID: 198390 RVA: 0x00B3ED54 File Offset: 0x00B3CF54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060306F7 RID: 198391 RVA: 0x00B3EEA0 File Offset: 0x00B3D0A0
		public void Update(int areaId)
		{
			this.AreaId = areaId;
			ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(areaId);
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), areaInfo.Value.Title, Array.Empty<object>());
			int num = (exploreAreaData != null) ? exploreAreaData.GetProgress() : 0;
			string item = num.ToString() + "%";
			if (exploreAreaData != null && exploreAreaData.IsReachMaxProgress)
			{
				item = StringUtils.Format("<color=#ffd12f>{0}%</color>", new string[]
				{
					num.ToString()
				});
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Text_ExploreRate", new <>z__ReadOnlySingleElementList<object>(item));
			this.ExploreData = exploreAreaData;
			base.GetItem(3).SetUIActive(exploreAreaData == null || !exploreAreaData.IsReachMaxProgress);
			if (exploreAreaData != null && exploreAreaData.IsReachMaxProgress)
			{
				return;
			}
			int value = (exploreAreaData != null) ? exploreAreaData.GetNextStageNeedProgress() : 0;
			float fillAmount = (exploreAreaData != null) ? exploreAreaData.GetStageProgress(false) : 0f;
			UUIText text = base.GetText(4);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			base.GetSprite(5).SetFillAmount(fillAmount);
			if (areaInfo != null && areaInfo.Value.IsDisableInExplore)
			{
				base.GetText(2).SetUIActive(false);
			}
		}

		// Token: 0x060306F8 RID: 198392 RVA: 0x00B3F00C File Offset: 0x00B3D20C
		private void OnClick()
		{
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(this.AreaId);
			if (areaInfo != null && areaInfo.Value.IsDisableInExplore)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ExplorationForbid_Text", Array.Empty<object>());
				return;
			}
			if (this.ExploreData == null)
			{
				return;
			}
			UiManager instance = UiManager.Instance;
			EUiViewName mapExploreDetailView = EUiViewName.MapExploreDetailView;
			MapExploreDetailViewParams mapExploreDetailViewParams = new MapExploreDetailViewParams();
			mapExploreDetailViewParams.AreaId = this.AreaId;
			instance.OpenView(mapExploreDetailView, mapExploreDetailViewParams, delegate(bool success, int viewId)
			{
				if (!success)
				{
					return;
				}
				UiModel.Instance.NormalStack.Peek().AddChildViewById(viewId);
			});
		}

		// Token: 0x060306F9 RID: 198393 RVA: 0x00B3F0A1 File Offset: 0x00B3D2A1
		protected override void OnBeforeShow()
		{
			this.BindRedDot();
		}

		// Token: 0x060306FA RID: 198394 RVA: 0x00B3F0A9 File Offset: 0x00B3D2A9
		protected override void OnBeforeHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060306FB RID: 198395 RVA: 0x00B3F0B1 File Offset: 0x00B3D2B1
		private void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.MapAreaExplore, base.GetItem(6), null, 0);
		}

		// Token: 0x060306FC RID: 198396 RVA: 0x00B3F0C8 File Offset: 0x00B3D2C8
		private void UnBindRedDot()
		{
			RedDotController.Instance.UnBindRedDot(ERedDotName.MapAreaExplore);
		}

		// Token: 0x0401A06D RID: 106605
		[Nullable(2)]
		public ExploreAreaData ExploreData;

		// Token: 0x0401A06E RID: 106606
		public int AreaId;
	}
}
