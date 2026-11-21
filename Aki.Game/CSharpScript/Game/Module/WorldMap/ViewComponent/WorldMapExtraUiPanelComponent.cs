using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant;
using CSharpScript.Game.Module.Map.View.SubView;
using CSharpScript.Game.Module.PhantomArena.Prepare.Entrance;
using CSharpScript.Game.Module.Sheriff.View.Map;
using CSharpScript.Game.Module.WorldMap.SubViews;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036DF RID: 14047
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapExtraUiPanelComponent : MapComponent
	{
		// Token: 0x06024849 RID: 149577 RVA: 0x00A50C03 File Offset: 0x00A4EE03
		public WorldMapExtraUiPanelComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x0602484A RID: 149578 RVA: 0x00A50C1E File Offset: 0x00A4EE1E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapExtraUiPanel;
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x0602484B RID: 149579 RVA: 0x00A50C24 File Offset: 0x00A4EE24
		[Nullable(2)]
		public WorldMapUiEntity WorldMapUiComponent
		{
			[NullableContext(2)]
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x0602484C RID: 149580 RVA: 0x00A50C61 File Offset: 0x00A4EE61
		protected override void OnAdd()
		{
			EventSystem.Instance.Add(EEventName.WorldMapAfterChangeMap, new Action(this.OnWorldMapAfterChangeMap));
		}

		// Token: 0x0602484D RID: 149581 RVA: 0x00A50C7F File Offset: 0x00A4EE7F
		protected override void OnRemove()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapAfterChangeMap, new Action(this.OnWorldMapAfterChangeMap));
			this.CloseAllUi();
		}

		// Token: 0x0602484E RID: 149582 RVA: 0x00A50CA3 File Offset: 0x00A4EEA3
		private void OnWorldMapAfterChangeMap()
		{
			this.RefreshDragAndScaleParam();
		}

		// Token: 0x0602484F RID: 149583 RVA: 0x00A50CAC File Offset: 0x00A4EEAC
		public UniTask OpenUi(EWorldMapExtraUiPanelName panelName, UUIItem parent, [Nullable(2)] object param = null)
		{
			WorldMapExtraUiPanelComponent.<OpenUi>d__16 <OpenUi>d__;
			<OpenUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenUi>d__.<>4__this = this;
			<OpenUi>d__.panelName = panelName;
			<OpenUi>d__.parent = parent;
			<OpenUi>d__.param = param;
			<OpenUi>d__.<>1__state = -1;
			<OpenUi>d__.<>t__builder.Start<WorldMapExtraUiPanelComponent.<OpenUi>d__16>(ref <OpenUi>d__);
			return <OpenUi>d__.<>t__builder.Task;
		}

		// Token: 0x06024850 RID: 149584 RVA: 0x00A50D08 File Offset: 0x00A4EF08
		public unsafe void CloseUi(WorldMapExtraUiPanel panel)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.CB;
			string message = "关闭地图外部二级界面";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("panelName", panel.PanelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", panel.ComponentId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel != null)
			{
				if (worldMapExtraUiPanel != panel)
				{
					global::Stack<WorldMapExtraUiPanel> stack = new global::Stack<WorldMapExtraUiPanel>();
					bool flag = false;
					while (this.ExtraUiPanelStack.Size > 0)
					{
						WorldMapExtraUiPanel worldMapExtraUiPanel2 = this.ExtraUiPanelStack.Pop();
						if (worldMapExtraUiPanel2 == panel)
						{
							flag = true;
							IL_F7:
							while (stack.Size > 0)
							{
								this.ExtraUiPanelStack.Push(stack.Pop());
							}
							if (flag)
							{
								this.OnBeforeCloseUiView();
								panel.Destroy(null);
								goto IL_175;
							}
							goto IL_175;
						}
						else
						{
							stack.Push(worldMapExtraUiPanel2);
						}
					}
					goto IL_F7;
				}
				this.ExtraUiPanelStack.Pop();
				this.OnBeforeCloseUiView();
				panel.Destroy(null);
				IL_175:
				this.OnCloseUiView(panel);
				if (this.ExtraUiPanelStack.Size > 0)
				{
					WorldMapExtraUiPanel worldMapExtraUiPanel3 = this.ExtraUiPanelStack.Peek();
					if (worldMapExtraUiPanel3 == null)
					{
						return;
					}
					worldMapExtraUiPanel3.Show(null);
				}
				return;
			}
			ELogAuthor author2 = ELogAuthor.CB;
			string message2 = "关闭地图外部二级界面失败，栈中没有元素";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("panelName", panel.PanelName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ComponentId", panel.ComponentId);
			base.LogError(author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}

		// Token: 0x06024851 RID: 149585 RVA: 0x00A50EB5 File Offset: 0x00A4F0B5
		public void CloseAllUi()
		{
			while (this.ExtraUiPanelStack.Size > 0)
			{
				this.CloseUi(this.ExtraUiPanelStack.Peek());
			}
		}

		// Token: 0x06024852 RID: 149586 RVA: 0x00A50ED8 File Offset: 0x00A4F0D8
		private void OnBeforeOpenUiView()
		{
			this.RefreshExtraMark();
			this.RefreshMultiMapVisible();
			this.RefreshFogParam(true);
			this.RefreshPlayerMark();
			this.RefreshDragAndScaleParam();
			this.RefreshMapRangeVisible();
		}

		// Token: 0x06024853 RID: 149587 RVA: 0x00A50EFF File Offset: 0x00A4F0FF
		private void OnBeforeCloseUiView()
		{
			this.RefreshExtraMark();
		}

		// Token: 0x06024854 RID: 149588 RVA: 0x00A50F08 File Offset: 0x00A4F108
		private void OnOpenUiView(WorldMapExtraUiPanel panel)
		{
			Action<WorldMapExtraUiPanel> onExtraUiViewOpened = this.OnExtraUiViewOpened;
			if (onExtraUiViewOpened != null)
			{
				onExtraUiViewOpened(panel);
			}
			this.RefreshSlider(true);
			this.RefreshCanAutoPilotTrack(true);
			this.PlayBackgroundMusic(panel);
			WorldMapModel.Instance.WorldExtraUiCount++;
			EventSystem.Instance.Emit<EWorldMapExtraUiPanelName>(EEventName.OnWorldMapExtraUiOpen, panel.PanelName);
			this.UpdateMarkItems();
		}

		// Token: 0x06024855 RID: 149589 RVA: 0x00A50F6C File Offset: 0x00A4F16C
		private void OnCloseUiView(WorldMapExtraUiPanel panel)
		{
			Action onExtraUiViewClosed = this.OnExtraUiViewClosed;
			if (onExtraUiViewClosed != null)
			{
				onExtraUiViewClosed();
			}
			this.RefreshSlider(false);
			this.RefreshDragAndScaleParam();
			this.RefreshFogParam(false);
			this.RefreshPlayerMark();
			this.RefreshCanAutoPilotTrack(false);
			this.RefreshMapRangeVisible();
			this.RefreshMultiMapVisible();
			this.StopBackgroundMusic();
			WorldMapModel.Instance.WorldExtraUiCount--;
			EventSystem.Instance.Emit<EWorldMapExtraUiPanelName>(EEventName.OnWorldMapExtraUiClose, panel.PanelName);
			this.UpdateMarkItems();
		}

		// Token: 0x06024856 RID: 149590 RVA: 0x00A50FEC File Offset: 0x00A4F1EC
		private void PlayBackgroundMusic(WorldMapExtraUiPanel panel)
		{
			string backgroundMusicAudioEvent = panel.GetBackgroundMusicAudioEvent();
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			UiViewBase uiViewBase = (worldMapUiComponent != null) ? worldMapUiComponent.OwnerView : null;
			if (!string.IsNullOrEmpty(backgroundMusicAudioEvent) && uiViewBase != null)
			{
				UiAudioSystem.Instance.PlayViewBgm(uiViewBase, backgroundMusicAudioEvent);
			}
		}

		// Token: 0x06024857 RID: 149591 RVA: 0x00A5102C File Offset: 0x00A4F22C
		private void StopBackgroundMusic()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			UiViewBase uiViewBase = (worldMapUiComponent != null) ? worldMapUiComponent.OwnerView : null;
			if (uiViewBase != null)
			{
				UiAudioSystem.Instance.StopViewBgm(uiViewBase);
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x06024858 RID: 149592 RVA: 0x00A5105A File Offset: 0x00A4F25A
		public bool IsExtraUiViewOpened
		{
			get
			{
				return this.ExtraUiPanelStack.Size > 0;
			}
		}

		// Token: 0x06024859 RID: 149593 RVA: 0x00A5106C File Offset: 0x00A4F26C
		private void RefreshSlider(bool isOpen)
		{
			if (this.WorldMapUiComponent == null)
			{
				return;
			}
			if (isOpen && this.ExtraUiPanelStack.Size == 1)
			{
				this.OriginalScaleSlider = this.WorldMapUiComponent.ScaleComponent.ScaleSlider;
			}
			UUISliderComponent targetSlider = this.GetTargetSlider();
			this.WorldMapUiComponent.ScaleComponent.ScaleSlider = targetSlider;
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.ScaleComponent.Initialize();
		}

		// Token: 0x0602485A RID: 149594 RVA: 0x00A510D6 File Offset: 0x00A4F2D6
		[NullableContext(2)]
		private UUISliderComponent GetTargetSlider()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			return ((worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetScaleSlider() : null) ?? this.OriginalScaleSlider;
		}

		// Token: 0x0602485B RID: 149595 RVA: 0x00A5110C File Offset: 0x00A4F30C
		public bool ClickEmpty(Vector2D clickedPosition)
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel == null || !worldMapExtraUiPanel.OnClickEmpty(clickedPosition))
			{
				return false;
			}
			WorldMapController.Instance.ClearFocalMarkItem();
			return true;
		}

		// Token: 0x0602485C RID: 149596 RVA: 0x00A51150 File Offset: 0x00A4F350
		public bool ClickSingleMark(MarkItem clickedItem)
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			ClickMarkItemRet clickMarkItemRet = (worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.OnClickMarkItem(clickedItem) : null;
			if (clickMarkItemRet == null || !clickMarkItemRet.IsExtraUiLogic)
			{
				return false;
			}
			if (clickMarkItemRet.IsNeedSelected)
			{
				this.ClearClickItem();
				this.SetClickItem(clickedItem);
			}
			return true;
		}

		// Token: 0x0602485D RID: 149597 RVA: 0x00A511B0 File Offset: 0x00A4F3B0
		public bool ClickMarks(List<MarkItem> clickedItems, Vector2D clickedPosition)
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel == null || !worldMapExtraUiPanel.OnClickMarks(clickedItems, clickedPosition))
			{
				return false;
			}
			WorldMapController.Instance.ClearFocalMarkItem();
			return true;
		}

		// Token: 0x0602485E RID: 149598 RVA: 0x00A511F4 File Offset: 0x00A4F3F4
		public int? GetCustomClickRange()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel == null)
			{
				return null;
			}
			return worldMapExtraUiPanel.GetCustomClickRange();
		}

		// Token: 0x0602485F RID: 149599 RVA: 0x00A51230 File Offset: 0x00A4F430
		public void SetClickItem(MarkItem clickedItem)
		{
			if (clickedItem.IsOutOfBound)
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				if (worldMapUiComponent != null)
				{
					worldMapUiComponent.MoveComponent.SetMapPosition(clickedItem, true, EClampType.ClampToSafeArea, null, null, true, true);
				}
			}
			this.WorldMapUiComponent.ClickedItem = clickedItem;
			WorldMapUiEntity worldMapUiComponent2 = this.WorldMapUiComponent;
			if (worldMapUiComponent2 != null)
			{
				MarkItem clickedItem2 = worldMapUiComponent2.ClickedItem;
				if (clickedItem2 != null)
				{
					clickedItem2.SetSelected(true);
				}
			}
			WorldMapUiEntity worldMapUiComponent3 = this.WorldMapUiComponent;
			if (worldMapUiComponent3 != null)
			{
				worldMapUiComponent3.UpdateSingleMarkItem(clickedItem, true);
			}
			WorldMapUiEntity worldMapUiComponent4 = this.WorldMapUiComponent;
			bool flag;
			if (worldMapUiComponent4 == null)
			{
				flag = false;
			}
			else
			{
				MarkItem clickedItem3 = worldMapUiComponent4.ClickedItem;
				flag = ((clickedItem3 != null) ? new bool?(clickedItem3.IsMultiMap()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				WorldMapUiEntity worldMapUiComponent5 = this.WorldMapUiComponent;
				int? num;
				if (worldMapUiComponent5 == null)
				{
					num = null;
				}
				else
				{
					MarkItem clickedItem4 = worldMapUiComponent5.ClickedItem;
					num = ((clickedItem4 != null) ? new int?(clickedItem4.GetMultiMapId()) : null);
				}
				int? num2 = num;
				int valueOrDefault = num2.GetValueOrDefault();
				MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(valueOrDefault);
				if (subMapConfigById != null)
				{
					int num3;
					if (subMapConfigById.Value.AreaLength <= 0)
					{
						WorldMapUiEntity worldMapUiComponent6 = this.WorldMapUiComponent;
						num3 = ((worldMapUiComponent6 != null) ? worldMapUiComponent6.Map.GetWorldMapCenterAreaId() : 0);
					}
					else
					{
						num3 = subMapConfigById.Value.Area(0);
					}
					int areaId = num3;
					int groupId = subMapConfigById.Value.GroupId;
					int floor = subMapConfigById.Value.Floor;
					WorldMapUiEntity worldMapUiComponent7 = this.WorldMapUiComponent;
					if (worldMapUiComponent7 == null)
					{
						return;
					}
					worldMapUiComponent7.MultiFloorComponent.SelectMultiMapFloor(areaId, new int?(groupId), new int?(floor), true);
					return;
				}
			}
			else
			{
				WorldMapUiEntity worldMapUiComponent8 = this.WorldMapUiComponent;
				if (worldMapUiComponent8 == null)
				{
					return;
				}
				worldMapUiComponent8.MultiFloorComponent.DeSelectMultiMapFloor(true);
			}
		}

		// Token: 0x06024860 RID: 149600 RVA: 0x00A513E0 File Offset: 0x00A4F5E0
		public void ClearClickItem()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (((worldMapUiComponent != null) ? worldMapUiComponent.ClickedItem : null) != null)
			{
				this.WorldMapUiComponent.ClickedItem.IsIgnoreScaleShow = false;
				this.WorldMapUiComponent.ClickedItem.SetSelected(false);
				this.WorldMapUiComponent.UpdateSingleMarkItem(this.WorldMapUiComponent.ClickedItem, true);
				this.WorldMapUiComponent.ClickedItem = null;
			}
		}

		// Token: 0x06024861 RID: 149601 RVA: 0x00A51446 File Offset: 0x00A4F646
		public bool OnPointerDrag(Vector2D delta)
		{
			WorldMapController.Instance.ClearFocalMarkItem();
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			return worldMapExtraUiPanel != null && worldMapExtraUiPanel.OnPointerDrag(delta);
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x06024862 RID: 149602 RVA: 0x00A51480 File Offset: 0x00A4F680
		public bool IsEnableMapScale
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsEnableMapScale();
			}
		}

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x06024863 RID: 149603 RVA: 0x00A514B8 File Offset: 0x00A4F6B8
		public bool IsEnableMapCursorButton
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsEnableMapCursorButton();
			}
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x06024864 RID: 149604 RVA: 0x00A514ED File Offset: 0x00A4F6ED
		public float MapDefaultScale
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				if (worldMapExtraUiPanel == null)
				{
					return 0f;
				}
				return worldMapExtraUiPanel.GetDefaultMapScale();
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x06024865 RID: 149605 RVA: 0x00A5151A File Offset: 0x00A4F71A
		public float MapMaxScale
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				if (worldMapExtraUiPanel == null)
				{
					return 0f;
				}
				return worldMapExtraUiPanel.GetMaxMapScale();
			}
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x06024866 RID: 149606 RVA: 0x00A51547 File Offset: 0x00A4F747
		public float MapMinScale
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				if (worldMapExtraUiPanel == null)
				{
					return 0f;
				}
				return worldMapExtraUiPanel.GetMinMapScale();
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x06024867 RID: 149607 RVA: 0x00A51574 File Offset: 0x00A4F774
		[Nullable(2)]
		public ITileNum TileNum
		{
			[NullableContext(2)]
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				IEnumerable<string> enumerable = (worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetTileRange() : null;
				if (enumerable == null)
				{
					return null;
				}
				TileNum tileNum = new TileNum
				{
					MaxX = int.MinValue,
					MinX = int.MaxValue,
					MaxY = int.MinValue,
					MinY = int.MaxValue
				};
				foreach (string text in enumerable)
				{
					string[] array = text.Split('_', StringSplitOptions.None);
					int val = int.Parse(array[0]);
					int val2 = int.Parse(array[1]);
					tileNum.MaxX = Math.Max(val, tileNum.MaxX);
					tileNum.MinX = Math.Min(val, tileNum.MinX);
					tileNum.MaxY = Math.Max(val2, tileNum.MaxY);
					tileNum.MinY = Math.Min(val2, tileNum.MinY);
				}
				return tileNum;
			}
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x06024868 RID: 149608 RVA: 0x00A5167C File Offset: 0x00A4F87C
		public bool IsShowPlayerMark
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsShowPlayerMark();
			}
		}

		// Token: 0x06024869 RID: 149609 RVA: 0x00A516A8 File Offset: 0x00A4F8A8
		public void RefreshScaleParam()
		{
			if (this.MapDefaultScale == 0f || this.MapMaxScale == 0f || this.MapMinScale == 0f)
			{
				WorldMapModel.Instance.ResetMapScale(null);
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				if (worldMapUiComponent == null)
				{
					return;
				}
				worldMapUiComponent.ScaleComponent.Initialize();
				return;
			}
			else
			{
				WorldMapModel.Instance.MapScaleMax = this.MapMaxScale / this.MapDefaultScale;
				WorldMapModel.Instance.MapScaleMin = this.MapMinScale / this.MapDefaultScale;
				float mapScale = this.MapDefaultScale / 100f;
				WorldMapModel.Instance.MapScale = mapScale;
				WorldMapUiEntity worldMapUiComponent2 = this.WorldMapUiComponent;
				if (worldMapUiComponent2 == null)
				{
					return;
				}
				worldMapUiComponent2.ScaleComponent.Initialize();
				return;
			}
		}

		// Token: 0x0602486A RID: 149610 RVA: 0x00A51760 File Offset: 0x00A4F960
		private void RefreshDragParam()
		{
			if (this.TileNum == null)
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				if (worldMapUiComponent != null)
				{
					BaseMap map = worldMapUiComponent.Map;
					if (map != null)
					{
						map.ResetDraggableParams();
					}
				}
				MapModel instance = MapModel.Instance;
				if (instance != null)
				{
					instance.ClearExtraUiTileRange(EMapType.WorldMap);
				}
			}
			else
			{
				WorldMapUiEntity worldMapUiComponent2 = this.WorldMapUiComponent;
				if (worldMapUiComponent2 != null)
				{
					BaseMap map2 = worldMapUiComponent2.Map;
					if (map2 != null)
					{
						map2.UpdateDraggableParams(this.TileNum);
					}
				}
				MapModel instance2 = MapModel.Instance;
				if (instance2 != null)
				{
					instance2.SetExtraUiTileRange(EMapType.WorldMap, this.TileNum);
				}
			}
			WorldMapUiEntity worldMapUiComponent3 = this.WorldMapUiComponent;
			if (worldMapUiComponent3 == null)
			{
				return;
			}
			worldMapUiComponent3.RecalculateMapSize();
		}

		// Token: 0x0602486B RID: 149611 RVA: 0x00A517ED File Offset: 0x00A4F9ED
		private void RefreshPlayerMark()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.InitSelfPlayerMark();
		}

		// Token: 0x0602486C RID: 149612 RVA: 0x00A517FF File Offset: 0x00A4F9FF
		public void RefreshDragAndScaleParam()
		{
			this.RefreshDragParam();
			this.RefreshScaleParam();
		}

		// Token: 0x0602486D RID: 149613 RVA: 0x00A51810 File Offset: 0x00A4FA10
		private void RefreshFogParam(bool isOpen)
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			MapTileMgr mapTileMgr;
			if (worldMapUiComponent == null)
			{
				mapTileMgr = null;
			}
			else
			{
				BaseMap map = worldMapUiComponent.Map;
				mapTileMgr = ((map != null) ? map.MapTileMgr : null);
			}
			MapTileMgr mapTileMgr2 = mapTileMgr;
			if (mapTileMgr2 == null)
			{
				return;
			}
			if (isOpen && this.ExtraUiPanelStack.Size == 1)
			{
				this.OriginalOpenFogSet = mapTileMgr2.OpenFogSet;
			}
			int[] array;
			if (this.ExtraUiPanelStack.Size <= 0)
			{
				array = null;
			}
			else
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = this.ExtraUiPanelStack.Peek();
				array = ((worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetUnlockFogs() : null);
			}
			int[] array2 = array;
			if (array2 != null && this.OriginalOpenFogSet != null)
			{
				HashSet<int> hashSet = new HashSet<int>();
				foreach (int num in this.OriginalOpenFogSet)
				{
					if (Array.IndexOf<int>(array2, num) >= 0)
					{
						hashSet.Add(num);
					}
				}
				mapTileMgr2.OpenFogSet = hashSet;
			}
			else
			{
				mapTileMgr2.OpenFogSet = this.OriginalOpenFogSet;
			}
			mapTileMgr2.UpdateOpenArea();
		}

		// Token: 0x0602486E RID: 149614 RVA: 0x00A51908 File Offset: 0x00A4FB08
		public void UpdateMarkItems()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.UpdateMarkItems(new bool?(true));
		}

		// Token: 0x0602486F RID: 149615 RVA: 0x00A51920 File Offset: 0x00A4FB20
		private void HideAllMarkItems()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (((worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetExtraMarkTypes() : null) != null)
			{
				MapModel instance = MapModel.Instance;
				if (instance != null)
				{
					instance.InitExtraUiMarkType(EMapType.WorldMap);
				}
			}
			if (((worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetExtraMarkIds() : null) != null)
			{
				MapModel instance2 = MapModel.Instance;
				if (instance2 != null)
				{
					instance2.InitExtraUiMarkId(EMapType.WorldMap);
				}
			}
			this.UpdateMarkItems();
		}

		// Token: 0x06024870 RID: 149616 RVA: 0x00A51990 File Offset: 0x00A4FB90
		public void RefreshExtraMark()
		{
			MapModel instance = MapModel.Instance;
			if (instance != null)
			{
				instance.ClearExtraUiMarkType(EMapType.WorldMap);
			}
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			EMarkType[] array = (worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetExtraMarkTypes() : null;
			if (array != null)
			{
				foreach (EMarkType markType in array)
				{
					MapModel instance2 = MapModel.Instance;
					if (instance2 != null)
					{
						instance2.AddExtraUiMarkType(EMapType.WorldMap, markType);
					}
					WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
					Dictionary<int, MarkItem> dictionary;
					if (worldMapUiComponent == null)
					{
						dictionary = null;
					}
					else
					{
						BaseMap map = worldMapUiComponent.Map;
						dictionary = ((map != null) ? map.GetMarkItemsByType(markType, true) : null);
					}
					Dictionary<int, MarkItem> dictionary2 = dictionary;
					if (dictionary2 != null)
					{
						foreach (KeyValuePair<int, MarkItem> keyValuePair in dictionary2)
						{
							int num;
							MarkItem markItem;
							keyValuePair.Deconstruct(out num, out markItem);
							markItem.NeedPlayStartSequence = true;
						}
					}
				}
			}
			MapModel instance3 = MapModel.Instance;
			if (instance3 != null)
			{
				instance3.ClearExtraUiMarkId(EMapType.WorldMap);
			}
			int[] array3 = (worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetExtraMarkIds() : null;
			if (array3 != null)
			{
				foreach (int markId in array3)
				{
					MapModel instance4 = MapModel.Instance;
					if (instance4 != null)
					{
						instance4.AddExtraUiMarkId(EMapType.WorldMap, markId);
					}
				}
			}
		}

		// Token: 0x06024871 RID: 149617 RVA: 0x00A51ADC File Offset: 0x00A4FCDC
		private void RefreshCanAutoPilotTrack(bool isOpen)
		{
			if (isOpen && this.ExtraUiPanelStack.Size == 1)
			{
				this.OriginalIsCanAutoPilotTrack = WorldMapModel.Instance.IsCanAutoPilotTrack;
			}
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel == null)
			{
				WorldMapModel.Instance.IsCanAutoPilotTrack = this.OriginalIsCanAutoPilotTrack;
				return;
			}
			WorldMapModel.Instance.IsCanAutoPilotTrack = worldMapExtraUiPanel.GetIsCanAutoPilotTrack();
		}

		// Token: 0x06024872 RID: 149618 RVA: 0x00A51B4C File Offset: 0x00A4FD4C
		private void RefreshMapRangeVisible()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			WorldMapModel.Instance.IsMapRangeVisible = (worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsMapRangeVisible());
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			BaseMap map = worldMapUiComponent.Map;
			if (map == null)
			{
				return;
			}
			MapRangePanel mapRangePanel = map.MapRangePanel;
			if (mapRangePanel == null)
			{
				return;
			}
			mapRangePanel.CheckExploreMarkRangeInfo();
		}

		// Token: 0x06024873 RID: 149619 RVA: 0x00A51BB0 File Offset: 0x00A4FDB0
		private void RefreshMultiMapVisible()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			WorldMapModel.Instance.IsMultiMapVisible = (worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsMultiMapVisible());
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.MultiFloorComponent.UpdateMultiMap();
		}

		// Token: 0x06024874 RID: 149620 RVA: 0x00A51C08 File Offset: 0x00A4FE08
		public bool HideTopPanel()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel != null)
			{
				worldMapExtraUiPanel.Hide(null);
				return true;
			}
			return false;
		}

		// Token: 0x06024875 RID: 149621 RVA: 0x00A51C40 File Offset: 0x00A4FE40
		public bool ShowTopPanel()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel != null)
			{
				worldMapExtraUiPanel.Show(null);
				return true;
			}
			return false;
		}

		// Token: 0x06024876 RID: 149622 RVA: 0x00A51C78 File Offset: 0x00A4FE78
		// Note: this type is marked as 'beforefieldinit'.
		static WorldMapExtraUiPanelComponent()
		{
			Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>> dictionary = new Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>>();
			dictionary[EWorldMapExtraUiPanelName.PhantomArenaMapEntrance] = new ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>((EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent component) => new PhantomArenaMapEntrancePanel(panelName, component), "UiView_SoundRemnantArenaMap");
			dictionary[EWorldMapExtraUiPanelName.SheriffMapPanel] = new ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>((EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent component) => new SheriffMapPanel(panelName, component), "UiView_SkyEyesMap");
			WorldMapExtraUiPanelComponent.ExtraUiPanelInfoMap = dictionary;
		}

		// Token: 0x04014531 RID: 83249
		private readonly global::Stack<WorldMapExtraUiPanel> ExtraUiPanelStack = new global::Stack<WorldMapExtraUiPanel>();

		// Token: 0x04014532 RID: 83250
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<WorldMapExtraUiPanel> OnExtraUiViewOpened;

		// Token: 0x04014533 RID: 83251
		[Nullable(2)]
		public Action OnExtraUiViewClosed;

		// Token: 0x04014534 RID: 83252
		[Nullable(2)]
		private UUISliderComponent OriginalScaleSlider;

		// Token: 0x04014535 RID: 83253
		[Nullable(2)]
		private HashSet<int> OriginalOpenFogSet;

		// Token: 0x04014536 RID: 83254
		private bool OriginalIsCanAutoPilotTrack = true;

		// Token: 0x04014537 RID: 83255
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>> ExtraUiPanelInfoMap;

		// Token: 0x0200941C RID: 37916
		// (Invoke) Token: 0x06043DE5 RID: 277989
		[NullableContext(0)]
		private delegate WorldMapExtraUiPanel ExtraUiPanelCtor(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent);
	}
}
