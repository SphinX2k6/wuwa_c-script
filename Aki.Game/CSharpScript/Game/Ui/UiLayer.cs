using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046CF RID: 18127
	[NullableContext(2)]
	[Nullable(0)]
	public class UiLayer : Singleton
	{
		// Token: 0x17007677 RID: 30327
		// (get) Token: 0x0602EC0C RID: 191500 RVA: 0x00AD2597 File Offset: 0x00AD0797
		public AActor UiRoot
		{
			get
			{
				return this.UiRootInternal;
			}
		}

		// Token: 0x17007678 RID: 30328
		// (get) Token: 0x0602EC0D RID: 191501 RVA: 0x00AD259F File Offset: 0x00AD079F
		public UUIItem UiRootItem
		{
			get
			{
				return this.UiRootItemInternal;
			}
		}

		// Token: 0x17007679 RID: 30329
		// (get) Token: 0x0602EC0E RID: 191502 RVA: 0x00AD25A7 File Offset: 0x00AD07A7
		public AActor WorldSpaceUiRoot
		{
			get
			{
				return this.WorldSpaceUiRootInternal;
			}
		}

		// Token: 0x1700767A RID: 30330
		// (get) Token: 0x0602EC0F RID: 191503 RVA: 0x00AD25AF File Offset: 0x00AD07AF
		public UUIItem WorldSpaceUiRootItem
		{
			get
			{
				return this.WorldSpaceUiRootItemInternal;
			}
		}

		// Token: 0x0602EC10 RID: 191504 RVA: 0x00AD25B8 File Offset: 0x00AD07B8
		private UniTask LoadLayerNode(ELayerType layer, int unitCount)
		{
			UiLayer.<LoadLayerNode>d__21 <LoadLayerNode>d__;
			<LoadLayerNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLayerNode>d__.<>4__this = this;
			<LoadLayerNode>d__.layer = layer;
			<LoadLayerNode>d__.unitCount = unitCount;
			<LoadLayerNode>d__.<>1__state = -1;
			<LoadLayerNode>d__.<>t__builder.Start<UiLayer.<LoadLayerNode>d__21>(ref <LoadLayerNode>d__);
			return <LoadLayerNode>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC11 RID: 191505 RVA: 0x00AD260C File Offset: 0x00AD080C
		[NullableContext(1)]
		private UniTask LoadLayerUnit(int index, [Nullable(2)] UUIItem parent, List<UUIItem> unitList, int unitCount)
		{
			UiLayer.<LoadLayerUnit>d__22 <LoadLayerUnit>d__;
			<LoadLayerUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLayerUnit>d__.<>4__this = this;
			<LoadLayerUnit>d__.index = index;
			<LoadLayerUnit>d__.parent = parent;
			<LoadLayerUnit>d__.unitList = unitList;
			<LoadLayerUnit>d__.unitCount = unitCount;
			<LoadLayerUnit>d__.<>1__state = -1;
			<LoadLayerUnit>d__.<>t__builder.Start<UiLayer.<LoadLayerUnit>d__22>(ref <LoadLayerUnit>d__);
			return <LoadLayerUnit>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC12 RID: 191506 RVA: 0x00AD2670 File Offset: 0x00AD0870
		public UUIItem GetFloatUnit(ELayerType layer, int index)
		{
			List<UUIItem> list;
			if (!this.FloatUnitMap.TryGetValue(layer, out list))
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.XXJ, "索引大于生成单元节点列表,返回当前最大值节点", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (index >= list.Count)
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.XXJ, "索引大于生成单元节点列表,返回当前最大值节点", default(ReadOnlySpan<ValueTuple<string, object>>));
				List<UUIItem> list2 = list;
				return list2[list2.Count - 1];
			}
			return list[index];
		}

		// Token: 0x0602EC13 RID: 191507 RVA: 0x00AD26E8 File Offset: 0x00AD08E8
		private UniTask LoadPureModeUnit(ELayerType layerType)
		{
			UiLayer.<LoadPureModeUnit>d__24 <LoadPureModeUnit>d__;
			<LoadPureModeUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadPureModeUnit>d__.<>4__this = this;
			<LoadPureModeUnit>d__.layerType = layerType;
			<LoadPureModeUnit>d__.<>1__state = -1;
			<LoadPureModeUnit>d__.<>t__builder.Start<UiLayer.<LoadPureModeUnit>d__24>(ref <LoadPureModeUnit>d__);
			return <LoadPureModeUnit>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC14 RID: 191508 RVA: 0x00AD2734 File Offset: 0x00AD0934
		public UUIItem GetPureModeFloatUnit(ELayerType layer)
		{
			UUIItem result;
			if (!this.PureModeFloatUnitMap.TryGetValue(layer, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "该层级没有纯净模式的节点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("layer", layer);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x0602EC15 RID: 191509 RVA: 0x00AD2780 File Offset: 0x00AD0980
		public UUIItem GetLayerRootUiItem(ELayerType layerType)
		{
			UUIItem result;
			if (!this.LayerMap.TryGetValue(layerType, out result))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "找不到对应的UiLayer, 此时UiLayer可能还未初始化";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("层级名称", layerType.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return result;
		}

		// Token: 0x0602EC16 RID: 191510 RVA: 0x00AD27D3 File Offset: 0x00AD09D3
		[NullableContext(1)]
		public UUIItem GetBattleViewUnit(int index)
		{
			return this.BattleViewUnitList[index];
		}

		// Token: 0x0602EC17 RID: 191511 RVA: 0x00AD27E4 File Offset: 0x00AD09E4
		public UUIItem GetLayerUnit(ELayerType layer, int index)
		{
			if (layer != ELayerType.HUD)
			{
				return this.GetFloatUnit(layer, index);
			}
			if (this.BattleViewUnitList == null || index < 0 || index >= this.BattleViewUnitList.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[GetLayerUnit] HUD 层单元下标越界或未加载";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", index);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return this.BattleViewUnitList[index];
		}

		// Token: 0x0602EC18 RID: 191512 RVA: 0x00AD2854 File Offset: 0x00AD0A54
		public unsafe void SetLayerActive(ELayerType type, bool show)
		{
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(type);
			if (layerRootUiItem != null)
			{
				layerRootUiItem.SetUIActive(show);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiLayer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "有操作设置层级的显隐状态";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("层级类型", type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("显示状态", show);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiLayer;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "找不到对应的uiLayer：";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EC19 RID: 191513 RVA: 0x00AD2904 File Offset: 0x00AD0B04
		[NullableContext(1)]
		public unsafe void SetLayerRenderable(ELayerType type, bool show, string reason)
		{
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(type);
			if (layerRootUiItem != null)
			{
				ULGUIBPLibrary.SetUIRenderable(layerRootUiItem, show);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiLayer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "有操作设置层级的可渲染状态";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("层级类型", type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("可渲染状态", show);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiLayer;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "找不到对应的uiLayer：";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EC1A RID: 191514 RVA: 0x00AD29D0 File Offset: 0x00AD0BD0
		public UniTask Initialize()
		{
			UiLayer.<Initialize>d__31 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UiLayer.<Initialize>d__31>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC1B RID: 191515 RVA: 0x00AD2A14 File Offset: 0x00AD0C14
		private UniTask LoadUiRoot()
		{
			UiLayer.<LoadUiRoot>d__32 <LoadUiRoot>d__;
			<LoadUiRoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadUiRoot>d__.<>4__this = this;
			<LoadUiRoot>d__.<>1__state = -1;
			<LoadUiRoot>d__.<>t__builder.Start<UiLayer.<LoadUiRoot>d__32>(ref <LoadUiRoot>d__);
			return <LoadUiRoot>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC1C RID: 191516 RVA: 0x00AD2A58 File Offset: 0x00AD0C58
		private UniTask LoadAllLayer()
		{
			UiLayer.<LoadAllLayer>d__33 <LoadAllLayer>d__;
			<LoadAllLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAllLayer>d__.<>4__this = this;
			<LoadAllLayer>d__.<>1__state = -1;
			<LoadAllLayer>d__.<>t__builder.Start<UiLayer.<LoadAllLayer>d__33>(ref <LoadAllLayer>d__);
			return <LoadAllLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC1D RID: 191517 RVA: 0x00AD2A9C File Offset: 0x00AD0C9C
		private UniTask LoadLayer(ELayerType layerType)
		{
			UiLayer.<LoadLayer>d__34 <LoadLayer>d__;
			<LoadLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadLayer>d__.<>4__this = this;
			<LoadLayer>d__.layerType = layerType;
			<LoadLayer>d__.<>1__state = -1;
			<LoadLayer>d__.<>t__builder.Start<UiLayer.<LoadLayer>d__34>(ref <LoadLayer>d__);
			return <LoadLayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC1E RID: 191518 RVA: 0x00AD2AE8 File Offset: 0x00AD0CE8
		private UniTask LoadBattleViewUnit()
		{
			UiLayer.<LoadBattleViewUnit>d__35 <LoadBattleViewUnit>d__;
			<LoadBattleViewUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBattleViewUnit>d__.<>4__this = this;
			<LoadBattleViewUnit>d__.<>1__state = -1;
			<LoadBattleViewUnit>d__.<>t__builder.Start<UiLayer.<LoadBattleViewUnit>d__35>(ref <LoadBattleViewUnit>d__);
			return <LoadBattleViewUnit>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC1F RID: 191519 RVA: 0x00AD2B2C File Offset: 0x00AD0D2C
		private UniTask LoadWorldSpaceUiRoot()
		{
			UiLayer.<LoadWorldSpaceUiRoot>d__36 <LoadWorldSpaceUiRoot>d__;
			<LoadWorldSpaceUiRoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadWorldSpaceUiRoot>d__.<>4__this = this;
			<LoadWorldSpaceUiRoot>d__.<>1__state = -1;
			<LoadWorldSpaceUiRoot>d__.<>t__builder.Start<UiLayer.<LoadWorldSpaceUiRoot>d__36>(ref <LoadWorldSpaceUiRoot>d__);
			return <LoadWorldSpaceUiRoot>d__.<>t__builder.Task;
		}

		// Token: 0x0602EC20 RID: 191520 RVA: 0x00AD2B70 File Offset: 0x00AD0D70
		public void SetUiRootActive(bool show)
		{
			if (this.IsForceHideUi())
			{
				return;
			}
			UUIItem uiRootItemInternal = this.UiRootItemInternal;
			if (uiRootItemInternal == null || !uiRootItemInternal.IsValid())
			{
				return;
			}
			uiRootItemInternal.SetUIActive(show);
			EventSystem.Instance.Emit<bool>(EEventName.OnUiScreenRootVisibleChange, show);
		}

		// Token: 0x0602EC21 RID: 191521 RVA: 0x00AD2BB4 File Offset: 0x00AD0DB4
		public bool IsUiActive()
		{
			UUIItem uiRootItemInternal = this.UiRootItemInternal;
			return uiRootItemInternal != null && uiRootItemInternal.IsValid() && uiRootItemInternal.IsUIActiveInHierarchy();
		}

		// Token: 0x0602EC22 RID: 191522 RVA: 0x00AD2BDB File Offset: 0x00AD0DDB
		public void ForceHideUi()
		{
			if (!SundryModel.Instance.GmBlueprintGmIsOpen)
			{
				return;
			}
			this.SetUiRootActive(false);
			this.SetWorldUiActive(false);
			this.IsForceHideUiRoot = true;
		}

		// Token: 0x0602EC23 RID: 191523 RVA: 0x00AD2BFF File Offset: 0x00AD0DFF
		public void ForceShowUi()
		{
			if (!this.IsForceHideUi())
			{
				return;
			}
			this.IsForceHideUiRoot = false;
			this.SetUiRootActive(true);
			this.SetWorldUiActive(true);
		}

		// Token: 0x0602EC24 RID: 191524 RVA: 0x00AD2C1F File Offset: 0x00AD0E1F
		public bool IsForceHideUi()
		{
			return this.IsForceHideUiRoot;
		}

		// Token: 0x0602EC25 RID: 191525 RVA: 0x00AD2C27 File Offset: 0x00AD0E27
		public void SetForceHideUiState(bool show)
		{
			this.IsForceHideUiRoot = !show;
		}

		// Token: 0x0602EC26 RID: 191526 RVA: 0x00AD2C34 File Offset: 0x00AD0E34
		public void SetWorldUiActive(bool show)
		{
			if (this.IsForceHideUi())
			{
				return;
			}
			UUIItem worldSpaceUiRootItemInternal = this.WorldSpaceUiRootItemInternal;
			if (worldSpaceUiRootItemInternal != null && worldSpaceUiRootItemInternal.IsValid())
			{
				worldSpaceUiRootItemInternal.SetUIActive(show);
			}
		}

		// Token: 0x0602EC27 RID: 191527 RVA: 0x00AD2C64 File Offset: 0x00AD0E64
		[NullableContext(1)]
		public unsafe void SetShowMaskLayer(string tag, bool show)
		{
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(ELayerType.Mask);
			if (layerRootUiItem == null || !layerRootUiItem.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCore;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "Mask Layer Item无效";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", tag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("show", show);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			if (show)
			{
				this.MaskTagSet.Add(tag);
			}
			else
			{
				this.MaskTagSet.Remove(tag);
			}
			int count = this.MaskTagSet.Count;
			if (layerRootUiItem != null)
			{
				layerRootUiItem.SetRaycastTarget(count > 0);
			}
		}

		// Token: 0x0602EC28 RID: 191528 RVA: 0x00AD2D19 File Offset: 0x00AD0F19
		public void GmClearMask()
		{
			this.MaskTagSet.Clear();
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(ELayerType.Mask);
			if (layerRootUiItem == null)
			{
				return;
			}
			layerRootUiItem.SetRaycastTarget(false);
		}

		// Token: 0x0602EC29 RID: 191529 RVA: 0x00AD2D3C File Offset: 0x00AD0F3C
		public bool IsInMask()
		{
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(ELayerType.Mask);
			return layerRootUiItem != null && layerRootUiItem.IsRaycastTarget();
		}

		// Token: 0x0602EC2A RID: 191530 RVA: 0x00AD2D60 File Offset: 0x00AD0F60
		[NullableContext(1)]
		public void SetShowNormalMaskLayer(bool show, string lockId = "")
		{
			if (!string.IsNullOrEmpty(this.NormalMaskLock) && (this.NormalMaskLock != lockId || show))
			{
				return;
			}
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(ELayerType.NormalMask);
			if (layerRootUiItem == null)
			{
				return;
			}
			if (layerRootUiItem != null)
			{
				layerRootUiItem.SetRaycastTarget(show);
			}
			if (show && string.IsNullOrEmpty(this.NormalMaskLock) && !string.IsNullOrEmpty(lockId))
			{
				this.NormalMaskLock = lockId;
				return;
			}
			if (!show && lockId == this.NormalMaskLock)
			{
				this.NormalMaskLock = "";
			}
		}

		// Token: 0x0602EC2B RID: 191531 RVA: 0x00AD2DDE File Offset: 0x00AD0FDE
		[NullableContext(1)]
		public Vector2D GetViewportSize()
		{
			if (!ObjectUtils.IsValid(this.UiRootItem))
			{
				return Vector2D.Create();
			}
			return Vector2D.Create((double)this.UiRootItem.GetWidth(), (double)this.UiRootItem.GetHeight());
		}

		// Token: 0x0602EC2C RID: 191532 RVA: 0x00AD2E10 File Offset: 0x00AD1010
		private void OnViewPortSizeChanged(FIntPoint newViewportSize)
		{
			Log.Instance.Info(ELogModule.UiCore, ELogAuthor.CFT, "UIRootItem OnViewPortSizeChange", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.UIViewPortSizeChanged);
		}

		// Token: 0x1700767B RID: 30331
		// (get) Token: 0x0602EC2D RID: 191533 RVA: 0x00AD2E46 File Offset: 0x00AD1046
		[Nullable(1)]
		public static UiLayer Instance
		{
			[NullableContext(1)]
			get
			{
				if (UiLayer._instance == null)
				{
					UiLayer._instance = new UiLayer();
					UiLayer._instance.OnInit();
				}
				return UiLayer._instance;
			}
		}

		// Token: 0x0602EC2E RID: 191534 RVA: 0x00AD2E69 File Offset: 0x00AD1069
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EC2F RID: 191535 RVA: 0x00AD2E6B File Offset: 0x00AD106B
		public static void ResetStaticDefaultValue()
		{
			UiLayer instance = UiLayer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiLayer._instance = null;
		}

		// Token: 0x0602EC30 RID: 191536 RVA: 0x00AD2E84 File Offset: 0x00AD1084
		static UiLayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiLayer.CreateStaticDefaultValue), new Action(UiLayer.ResetStaticDefaultValue));
		}

		// Token: 0x0401971C RID: 104220
		private bool IsInitializing;

		// Token: 0x0401971D RID: 104221
		[Nullable(1)]
		private string NormalMaskLock = "";

		// Token: 0x0401971E RID: 104222
		private AActor UiRootInternal;

		// Token: 0x0401971F RID: 104223
		private UUIItem UiRootItemInternal;

		// Token: 0x04019720 RID: 104224
		private AActor WorldSpaceUiRootInternal;

		// Token: 0x04019721 RID: 104225
		private UUIItem WorldSpaceUiRootItemInternal;

		// Token: 0x04019722 RID: 104226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUIItem> BattleViewUnitList;

		// Token: 0x04019723 RID: 104227
		[Nullable(1)]
		private readonly Dictionary<ELayerType, UUIItem> LayerMap = new Dictionary<ELayerType, UUIItem>();

		// Token: 0x04019724 RID: 104228
		private bool IsForceHideUiRoot;

		// Token: 0x04019725 RID: 104229
		[Nullable(1)]
		private readonly HashSet<string> MaskTagSet = new HashSet<string>();

		// Token: 0x04019726 RID: 104230
		[Nullable(1)]
		private readonly Dictionary<ELayerType, List<UUIItem>> FloatUnitMap = new Dictionary<ELayerType, List<UUIItem>>();

		// Token: 0x04019727 RID: 104231
		[Nullable(1)]
		private readonly Dictionary<ELayerType, UUIItem> PureModeFloatUnitMap = new Dictionary<ELayerType, UUIItem>();

		// Token: 0x04019728 RID: 104232
		[Nullable(1)]
		private readonly Array LayerTypeArray = Enum.GetValues(typeof(ELayerType));

		// Token: 0x04019729 RID: 104233
		private static UiLayer _instance;
	}
}
