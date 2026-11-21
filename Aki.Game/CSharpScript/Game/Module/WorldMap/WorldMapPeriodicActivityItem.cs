using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036DB RID: 14043
	public class WorldMapPeriodicActivityItem : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x06024792 RID: 149394 RVA: 0x00A4BB23 File Offset: 0x00A49D23
		// (set) Token: 0x06024793 RID: 149395 RVA: 0x00A4BB2B File Offset: 0x00A49D2B
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x06024794 RID: 149396 RVA: 0x00A4BB34 File Offset: 0x00A49D34
		[NullableContext(1)]
		public UniTask Init(UUIItem uiItem)
		{
			WorldMapPeriodicActivityItem.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.uiItem = uiItem;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<WorldMapPeriodicActivityItem.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06024795 RID: 149397 RVA: 0x00A4BB80 File Offset: 0x00A49D80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickTexture));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024796 RID: 149398 RVA: 0x00A4BCAD File Offset: 0x00A49EAD
		private void OnClickBtn()
		{
			Action onClickBtnCb = this.OnClickBtnCb;
			if (onClickBtnCb == null)
			{
				return;
			}
			onClickBtnCb();
		}

		// Token: 0x06024797 RID: 149399 RVA: 0x00A4BCBF File Offset: 0x00A49EBF
		private void OnClickTexture()
		{
			WorldMapModel.Instance.ActivityListData[0].OnClickCb();
			WorldMapModel.Instance.UpdateActivityListItemData(false);
			this.RefreshRedPoint();
		}

		// Token: 0x06024798 RID: 149400 RVA: 0x00A4BCEC File Offset: 0x00A49EEC
		public void SetShowState(bool state)
		{
			this.CurrentShowState = state;
		}

		// Token: 0x06024799 RID: 149401 RVA: 0x00A4BCF5 File Offset: 0x00A49EF5
		public bool GetCurrentShowState()
		{
			return this.CurrentShowState;
		}

		// Token: 0x0602479A RID: 149402 RVA: 0x00A4BCFD File Offset: 0x00A49EFD
		public void Refresh(bool inEightMap)
		{
			this.InEightMap = inEightMap;
			this.RefreshView();
		}

		// Token: 0x0602479B RID: 149403 RVA: 0x00A4BD0C File Offset: 0x00A49F0C
		[NullableContext(1)]
		public void SetOnClickBtnCb(Action onClickBtnCb)
		{
			this.OnClickBtnCb = onClickBtnCb;
		}

		// Token: 0x0602479C RID: 149404 RVA: 0x00A4BD18 File Offset: 0x00A49F18
		public void RefreshView()
		{
			if (this.ShowMode != EWorldMapShowMode.Default)
			{
				base.GetRootItem().SetUIActive(false);
				return;
			}
			List<IActivityListItemData> activityListData = WorldMapModel.Instance.ActivityListData;
			if (activityListData.Count == 0)
			{
				base.GetRootItem().SetUIActive(false);
				return;
			}
			base.GetRootItem().SetUIActive(this.InEightMap);
			IActivityListItemData activityListItemData = activityListData[0];
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(activityListItemData.CurrentNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activityListItemData.TotalNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			this.SetSpriteByPath(MapConfig.Instance.GetMapPeriodicActivityConfig(activityListItemData.Id).Value.IconPath, base.GetSprite(7), false, null, null);
			this.RefreshRedPoint();
		}

		// Token: 0x0602479D RID: 149405 RVA: 0x00A4BDF6 File Offset: 0x00A49FF6
		public void RefreshRedPoint()
		{
			base.GetItem(9).SetUIActive(WorldMapModel.Instance.ActivityListData.Exists((IActivityListItemData item) => item.RedPoint));
		}

		// Token: 0x0602479E RID: 149406 RVA: 0x00A4BE33 File Offset: 0x00A4A033
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			if (showMode == EWorldMapShowMode.Default)
			{
				this.RefreshView();
				return;
			}
			base.SetUiActive(false);
		}

		// Token: 0x0602479F RID: 149407 RVA: 0x00A4BE46 File Offset: 0x00A4A046
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x04014500 RID: 83200
		private bool CurrentShowState;

		// Token: 0x04014502 RID: 83202
		private bool InEightMap;

		// Token: 0x04014503 RID: 83203
		[Nullable(2)]
		private Action OnClickBtnCb;

		// Token: 0x020093ED RID: 37869
		private enum EWorldMapTowerItemComponent
		{
			// Token: 0x0402E43B RID: 189499
			AreaText = 1,
			// Token: 0x0402E43C RID: 189500
			BtnFunction,
			// Token: 0x0402E43D RID: 189501
			Button,
			// Token: 0x0402E43E RID: 189502
			SpriteIcon = 7,
			// Token: 0x0402E43F RID: 189503
			ReadPoint = 9
		}
	}
}
