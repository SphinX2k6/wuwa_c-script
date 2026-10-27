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
	// Token: 0x020047AA RID: 18346
	public class WorldMapPeriodicActivityItem : UiPanelBase, IWorldMapItemVisibleControlInterface
	{
		// Token: 0x17007832 RID: 30770
		// (get) Token: 0x0602FFC5 RID: 196549 RVA: 0x00B1BB87 File Offset: 0x00B19D87
		// (set) Token: 0x0602FFC6 RID: 196550 RVA: 0x00B1BB8F File Offset: 0x00B19D8F
		public EWorldMapShowMode ShowMode { get; set; }

		// Token: 0x0602FFC7 RID: 196551 RVA: 0x00B1BB98 File Offset: 0x00B19D98
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

		// Token: 0x0602FFC8 RID: 196552 RVA: 0x00B1BBE4 File Offset: 0x00B19DE4
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

		// Token: 0x0602FFC9 RID: 196553 RVA: 0x00B1BD11 File Offset: 0x00B19F11
		private void OnClickBtn()
		{
			Action onClickBtnCb = this.OnClickBtnCb;
			if (onClickBtnCb == null)
			{
				return;
			}
			onClickBtnCb();
		}

		// Token: 0x0602FFCA RID: 196554 RVA: 0x00B1BD23 File Offset: 0x00B19F23
		private void OnClickTexture()
		{
			WorldMapModel.Instance.ActivityListData[0].OnClickCb();
			WorldMapModel.Instance.UpdateActivityListItemData(false);
			this.RefreshRedPoint();
		}

		// Token: 0x0602FFCB RID: 196555 RVA: 0x00B1BD50 File Offset: 0x00B19F50
		public void SetShowState(bool state)
		{
			this.CurrentShowState = state;
		}

		// Token: 0x0602FFCC RID: 196556 RVA: 0x00B1BD59 File Offset: 0x00B19F59
		public bool GetCurrentShowState()
		{
			return this.CurrentShowState;
		}

		// Token: 0x0602FFCD RID: 196557 RVA: 0x00B1BD61 File Offset: 0x00B19F61
		public void Refresh(bool inEightMap)
		{
			this.InEightMap = inEightMap;
			this.RefreshView();
		}

		// Token: 0x0602FFCE RID: 196558 RVA: 0x00B1BD70 File Offset: 0x00B19F70
		[NullableContext(1)]
		public void SetOnClickBtnCb(Action onClickBtnCb)
		{
			this.OnClickBtnCb = onClickBtnCb;
		}

		// Token: 0x0602FFCF RID: 196559 RVA: 0x00B1BD7C File Offset: 0x00B19F7C
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

		// Token: 0x0602FFD0 RID: 196560 RVA: 0x00B1BE5A File Offset: 0x00B1A05A
		public void RefreshRedPoint()
		{
			base.GetItem(9).SetUIActive(WorldMapModel.Instance.ActivityListData.Exists((IActivityListItemData item) => item.RedPoint));
		}

		// Token: 0x0602FFD1 RID: 196561 RVA: 0x00B1BE97 File Offset: 0x00B1A097
		public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			if (showMode == EWorldMapShowMode.Default)
			{
				this.RefreshView();
				return;
			}
			base.SetUiActive(false);
		}

		// Token: 0x0602FFD2 RID: 196562 RVA: 0x00B1BEAA File Offset: 0x00B1A0AA
		public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
		{
			this.ShowMode = showMode;
		}

		// Token: 0x04019E50 RID: 106064
		private bool CurrentShowState;

		// Token: 0x04019E52 RID: 106066
		private bool InEightMap;

		// Token: 0x04019E53 RID: 106067
		[Nullable(2)]
		private Action OnClickBtnCb;

		// Token: 0x0200AA3A RID: 43578
		private enum EWorldMapTowerItemComponent
		{
			// Token: 0x04033CAF RID: 212143
			AreaText = 1,
			// Token: 0x04033CB0 RID: 212144
			BtnFunction,
			// Token: 0x04033CB1 RID: 212145
			Button,
			// Token: 0x04033CB2 RID: 212146
			SpriteIcon = 7,
			// Token: 0x04033CB3 RID: 212147
			ReadPoint = 9
		}
	}
}
