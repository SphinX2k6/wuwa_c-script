using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020047AE RID: 18350
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapExtraUiPanelComponent : MapComponent
	{
		// Token: 0x0603007A RID: 196730 RVA: 0x00B20CB7 File Offset: 0x00B1EEB7
		public WorldMapExtraUiPanelComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007838 RID: 30776
		// (get) Token: 0x0603007B RID: 196731 RVA: 0x00B20CD2 File Offset: 0x00B1EED2
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapExtraUiPanel;
			}
		}

		// Token: 0x17007839 RID: 30777
		// (get) Token: 0x0603007C RID: 196732 RVA: 0x00B20CD8 File Offset: 0x00B1EED8
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

		// Token: 0x0603007D RID: 196733 RVA: 0x00B20D15 File Offset: 0x00B1EF15
		protected override void OnAdd()
		{
			EventSystem.Instance.Add(EEventName.WorldMapAfterChangeMap, new Action(this.OnWorldMapAfterChangeMap));
		}

		// Token: 0x0603007E RID: 196734 RVA: 0x00B20D33 File Offset: 0x00B1EF33
		protected override void OnRemove()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapAfterChangeMap, new Action(this.OnWorldMapAfterChangeMap));
			this.CloseAllUi();
		}

		// Token: 0x0603007F RID: 196735 RVA: 0x00B20D57 File Offset: 0x00B1EF57
		private void OnWorldMapAfterChangeMap()
		{
			this.RefreshDragAndScaleParam();
		}

		// Token: 0x06030080 RID: 196736 RVA: 0x00B20D60 File Offset: 0x00B1EF60
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

		// Token: 0x06030081 RID: 196737 RVA: 0x00B20DBC File Offset: 0x00B1EFBC
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

		// Token: 0x06030082 RID: 196738 RVA: 0x00B20F69 File Offset: 0x00B1F169
		public void CloseAllUi()
		{
			while (this.ExtraUiPanelStack.Size > 0)
			{
				this.CloseUi(this.ExtraUiPanelStack.Peek());
			}
		}

		// Token: 0x06030083 RID: 196739 RVA: 0x00B20F8C File Offset: 0x00B1F18C
		private void OnBeforeOpenUiView()
		{
			this.RefreshExtraMark();
			this.RefreshMultiMapVisible();
			this.RefreshFogParam(true);
			this.RefreshPlayerMark();
			this.RefreshDragAndScaleParam();
			this.RefreshMapRangeVisible();
		}

		// Token: 0x06030084 RID: 196740 RVA: 0x00B20FB3 File Offset: 0x00B1F1B3
		private void OnBeforeCloseUiView()
		{
			this.RefreshExtraMark();
		}

		// Token: 0x06030085 RID: 196741 RVA: 0x00B20FBC File Offset: 0x00B1F1BC
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

		// Token: 0x06030086 RID: 196742 RVA: 0x00B21020 File Offset: 0x00B1F220
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
			this.StopBackgroundMusic(panel);
			WorldMapModel.Instance.WorldExtraUiCount--;
			EventSystem.Instance.Emit<EWorldMapExtraUiPanelName>(EEventName.OnWorldMapExtraUiClose, panel.PanelName);
			this.UpdateMarkItems();
		}

		// Token: 0x06030087 RID: 196743 RVA: 0x00B210A0 File Offset: 0x00B1F2A0
		private void PlayBackgroundMusic(WorldMapExtraUiPanel panel)
		{
			string backgroundMusicAudioEvent = panel.GetBackgroundMusicAudioEvent();
			AActor rootActor = panel.GetRootActor();
			if (!string.IsNullOrEmpty(backgroundMusicAudioEvent) && rootActor != null)
			{
				UiAudioModel.Instance.SetLoopAudioEventShow(panel.ComponentId, rootActor, backgroundMusicAudioEvent);
			}
		}

		// Token: 0x06030088 RID: 196744 RVA: 0x00B210D8 File Offset: 0x00B1F2D8
		private void StopBackgroundMusic(WorldMapExtraUiPanel panel)
		{
			string backgroundMusicAudioEvent = panel.GetBackgroundMusicAudioEvent();
			AActor rootActor = panel.GetRootActor();
			if (!string.IsNullOrEmpty(backgroundMusicAudioEvent) && rootActor != null)
			{
				UiAudioModel.Instance.SetLoopAudioEventDestroy(panel.ComponentId, rootActor, backgroundMusicAudioEvent);
			}
		}

		// Token: 0x1700783A RID: 30778
		// (get) Token: 0x06030089 RID: 196745 RVA: 0x00B21110 File Offset: 0x00B1F310
		public bool IsExtraUiViewOpened
		{
			get
			{
				return this.ExtraUiPanelStack.Size > 0;
			}
		}

		// Token: 0x0603008A RID: 196746 RVA: 0x00B21120 File Offset: 0x00B1F320
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

		// Token: 0x0603008B RID: 196747 RVA: 0x00B2118A File Offset: 0x00B1F38A
		[NullableContext(2)]
		private UUISliderComponent GetTargetSlider()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			return ((worldMapExtraUiPanel != null) ? worldMapExtraUiPanel.GetScaleSlider() : null) ?? this.OriginalScaleSlider;
		}

		// Token: 0x0603008C RID: 196748 RVA: 0x00B211C0 File Offset: 0x00B1F3C0
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

		// Token: 0x0603008D RID: 196749 RVA: 0x00B21204 File Offset: 0x00B1F404
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

		// Token: 0x0603008E RID: 196750 RVA: 0x00B21264 File Offset: 0x00B1F464
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

		// Token: 0x0603008F RID: 196751 RVA: 0x00B212A8 File Offset: 0x00B1F4A8
		public int? GetCustomClickRange()
		{
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			if (worldMapExtraUiPanel == null)
			{
				return null;
			}
			return worldMapExtraUiPanel.GetCustomClickRange();
		}

		// Token: 0x06030090 RID: 196752 RVA: 0x00B212E4 File Offset: 0x00B1F4E4
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

		// Token: 0x06030091 RID: 196753 RVA: 0x00B21494 File Offset: 0x00B1F694
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

		// Token: 0x06030092 RID: 196754 RVA: 0x00B214FA File Offset: 0x00B1F6FA
		public bool OnPointerDrag(Vector2D delta)
		{
			WorldMapController.Instance.ClearFocalMarkItem();
			WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
			return worldMapExtraUiPanel != null && worldMapExtraUiPanel.OnPointerDrag(delta);
		}

		// Token: 0x1700783B RID: 30779
		// (get) Token: 0x06030093 RID: 196755 RVA: 0x00B21534 File Offset: 0x00B1F734
		public bool IsEnableMapScale
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsEnableMapScale();
			}
		}

		// Token: 0x1700783C RID: 30780
		// (get) Token: 0x06030094 RID: 196756 RVA: 0x00B2156C File Offset: 0x00B1F76C
		public bool IsEnableMapCursorButton
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsEnableMapCursorButton();
			}
		}

		// Token: 0x1700783D RID: 30781
		// (get) Token: 0x06030095 RID: 196757 RVA: 0x00B215A1 File Offset: 0x00B1F7A1
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

		// Token: 0x1700783E RID: 30782
		// (get) Token: 0x06030096 RID: 196758 RVA: 0x00B215CE File Offset: 0x00B1F7CE
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

		// Token: 0x1700783F RID: 30783
		// (get) Token: 0x06030097 RID: 196759 RVA: 0x00B215FB File Offset: 0x00B1F7FB
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

		// Token: 0x17007840 RID: 30784
		// (get) Token: 0x06030098 RID: 196760 RVA: 0x00B21628 File Offset: 0x00B1F828
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

		// Token: 0x17007841 RID: 30785
		// (get) Token: 0x06030099 RID: 196761 RVA: 0x00B21730 File Offset: 0x00B1F930
		public bool IsShowPlayerMark
		{
			get
			{
				WorldMapExtraUiPanel worldMapExtraUiPanel = (this.ExtraUiPanelStack.Size > 0) ? this.ExtraUiPanelStack.Peek() : null;
				return worldMapExtraUiPanel == null || worldMapExtraUiPanel.GetIsShowPlayerMark();
			}
		}

		// Token: 0x0603009A RID: 196762 RVA: 0x00B2175C File Offset: 0x00B1F95C
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

		// Token: 0x0603009B RID: 196763 RVA: 0x00B21814 File Offset: 0x00B1FA14
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

		// Token: 0x0603009C RID: 196764 RVA: 0x00B218A1 File Offset: 0x00B1FAA1
		private void RefreshPlayerMark()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.InitSelfPlayerMark();
		}

		// Token: 0x0603009D RID: 196765 RVA: 0x00B218B3 File Offset: 0x00B1FAB3
		public void RefreshDragAndScaleParam()
		{
			this.RefreshDragParam();
			this.RefreshScaleParam();
		}

		// Token: 0x0603009E RID: 196766 RVA: 0x00B218C4 File Offset: 0x00B1FAC4
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
					if (array2.Contains(num))
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

		// Token: 0x0603009F RID: 196767 RVA: 0x00B219BC File Offset: 0x00B1FBBC
		public void UpdateMarkItems()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			if (worldMapUiComponent == null)
			{
				return;
			}
			worldMapUiComponent.UpdateMarkItems(new bool?(true));
		}

		// Token: 0x060300A0 RID: 196768 RVA: 0x00B219D4 File Offset: 0x00B1FBD4
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

		// Token: 0x060300A1 RID: 196769 RVA: 0x00B21A44 File Offset: 0x00B1FC44
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

		// Token: 0x060300A2 RID: 196770 RVA: 0x00B21B90 File Offset: 0x00B1FD90
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

		// Token: 0x060300A3 RID: 196771 RVA: 0x00B21C00 File Offset: 0x00B1FE00
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

		// Token: 0x060300A4 RID: 196772 RVA: 0x00B21C64 File Offset: 0x00B1FE64
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

		// Token: 0x060300A5 RID: 196773 RVA: 0x00B21CBC File Offset: 0x00B1FEBC
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

		// Token: 0x060300A6 RID: 196774 RVA: 0x00B21CF4 File Offset: 0x00B1FEF4
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

		// Token: 0x060300A7 RID: 196775 RVA: 0x00B21D2C File Offset: 0x00B1FF2C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldMapExtraUiPanelComponent()
		{
			Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>> dictionary = new Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>>();
			dictionary[EWorldMapExtraUiPanelName.PhantomArenaMapEntrance] = new ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>((EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent component) => new PhantomArenaMapEntrancePanel(panelName, component), "UiView_SoundRemnantArenaMap");
			dictionary[EWorldMapExtraUiPanelName.SheriffMapPanel] = new ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>((EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent component) => new SheriffMapPanel(panelName, component), "UiView_SkyEyesMap");
			WorldMapExtraUiPanelComponent.ExtraUiPanelInfoMap = dictionary;
		}

		// Token: 0x04019E81 RID: 106113
		private readonly global::Stack<WorldMapExtraUiPanel> ExtraUiPanelStack = new global::Stack<WorldMapExtraUiPanel>();

		// Token: 0x04019E82 RID: 106114
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<WorldMapExtraUiPanel> OnExtraUiViewOpened;

		// Token: 0x04019E83 RID: 106115
		[Nullable(2)]
		public Action OnExtraUiViewClosed;

		// Token: 0x04019E84 RID: 106116
		[Nullable(2)]
		private UUISliderComponent OriginalScaleSlider;

		// Token: 0x04019E85 RID: 106117
		[Nullable(2)]
		private HashSet<int> OriginalOpenFogSet;

		// Token: 0x04019E86 RID: 106118
		private bool OriginalIsCanAutoPilotTrack = true;

		// Token: 0x04019E87 RID: 106119
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EWorldMapExtraUiPanelName, ValueTuple<WorldMapExtraUiPanelComponent.ExtraUiPanelCtor, string>> ExtraUiPanelInfoMap;

		// Token: 0x0200AA68 RID: 43624
		// (Invoke) Token: 0x0604D8D5 RID: 317653
		[NullableContext(0)]
		private delegate WorldMapExtraUiPanel ExtraUiPanelCtor(EWorldMapExtraUiPanelName panelName, WorldMapExtraUiPanelComponent extraUiPanelComponent);
	}
}
