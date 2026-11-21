using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035FF RID: 13823
	[NullableContext(2)]
	[Nullable(0)]
	public class UiLayer : Singleton
	{
		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x06023348 RID: 144200 RVA: 0x00A008FB File Offset: 0x009FEAFB
		public AActor UiRoot
		{
			get
			{
				return this.UiRootInternal;
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x06023349 RID: 144201 RVA: 0x00A00903 File Offset: 0x009FEB03
		public UUIItem UiRootItem
		{
			get
			{
				return this.UiRootItemInternal;
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x0602334A RID: 144202 RVA: 0x00A0090B File Offset: 0x009FEB0B
		public AActor WorldSpaceUiRoot
		{
			get
			{
				return this.WorldSpaceUiRootInternal;
			}
		}

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x0602334B RID: 144203 RVA: 0x00A00913 File Offset: 0x009FEB13
		public UUIItem WorldSpaceUiRootItem
		{
			get
			{
				return this.WorldSpaceUiRootItemInternal;
			}
		}

		// Token: 0x0602334C RID: 144204 RVA: 0x00A0091C File Offset: 0x009FEB1C
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

		// Token: 0x0602334D RID: 144205 RVA: 0x00A00970 File Offset: 0x009FEB70
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

		// Token: 0x0602334E RID: 144206 RVA: 0x00A009D4 File Offset: 0x009FEBD4
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

		// Token: 0x0602334F RID: 144207 RVA: 0x00A00A4C File Offset: 0x009FEC4C
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

		// Token: 0x06023350 RID: 144208 RVA: 0x00A00A98 File Offset: 0x009FEC98
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

		// Token: 0x06023351 RID: 144209 RVA: 0x00A00AE4 File Offset: 0x009FECE4
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

		// Token: 0x06023352 RID: 144210 RVA: 0x00A00B37 File Offset: 0x009FED37
		[NullableContext(1)]
		public UUIItem GetBattleViewUnit(int index)
		{
			return this.BattleViewUnitList[index];
		}

		// Token: 0x06023353 RID: 144211 RVA: 0x00A00B48 File Offset: 0x009FED48
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

		// Token: 0x06023354 RID: 144212 RVA: 0x00A00BB8 File Offset: 0x009FEDB8
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

		// Token: 0x06023355 RID: 144213 RVA: 0x00A00C68 File Offset: 0x009FEE68
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

		// Token: 0x06023356 RID: 144214 RVA: 0x00A00D34 File Offset: 0x009FEF34
		public UniTask Initialize()
		{
			UiLayer.<Initialize>d__31 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<UiLayer.<Initialize>d__31>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x06023357 RID: 144215 RVA: 0x00A00D78 File Offset: 0x009FEF78
		private UniTask LoadUiRoot()
		{
			UiLayer.<LoadUiRoot>d__32 <LoadUiRoot>d__;
			<LoadUiRoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadUiRoot>d__.<>4__this = this;
			<LoadUiRoot>d__.<>1__state = -1;
			<LoadUiRoot>d__.<>t__builder.Start<UiLayer.<LoadUiRoot>d__32>(ref <LoadUiRoot>d__);
			return <LoadUiRoot>d__.<>t__builder.Task;
		}

		// Token: 0x06023358 RID: 144216 RVA: 0x00A00DBC File Offset: 0x009FEFBC
		private UniTask LoadAllLayer()
		{
			UiLayer.<LoadAllLayer>d__33 <LoadAllLayer>d__;
			<LoadAllLayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadAllLayer>d__.<>4__this = this;
			<LoadAllLayer>d__.<>1__state = -1;
			<LoadAllLayer>d__.<>t__builder.Start<UiLayer.<LoadAllLayer>d__33>(ref <LoadAllLayer>d__);
			return <LoadAllLayer>d__.<>t__builder.Task;
		}

		// Token: 0x06023359 RID: 144217 RVA: 0x00A00E00 File Offset: 0x009FF000
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

		// Token: 0x0602335A RID: 144218 RVA: 0x00A00E4C File Offset: 0x009FF04C
		private UniTask LoadBattleViewUnit()
		{
			UiLayer.<LoadBattleViewUnit>d__35 <LoadBattleViewUnit>d__;
			<LoadBattleViewUnit>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadBattleViewUnit>d__.<>4__this = this;
			<LoadBattleViewUnit>d__.<>1__state = -1;
			<LoadBattleViewUnit>d__.<>t__builder.Start<UiLayer.<LoadBattleViewUnit>d__35>(ref <LoadBattleViewUnit>d__);
			return <LoadBattleViewUnit>d__.<>t__builder.Task;
		}

		// Token: 0x0602335B RID: 144219 RVA: 0x00A00E90 File Offset: 0x009FF090
		private UniTask LoadWorldSpaceUiRoot()
		{
			UiLayer.<LoadWorldSpaceUiRoot>d__36 <LoadWorldSpaceUiRoot>d__;
			<LoadWorldSpaceUiRoot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadWorldSpaceUiRoot>d__.<>4__this = this;
			<LoadWorldSpaceUiRoot>d__.<>1__state = -1;
			<LoadWorldSpaceUiRoot>d__.<>t__builder.Start<UiLayer.<LoadWorldSpaceUiRoot>d__36>(ref <LoadWorldSpaceUiRoot>d__);
			return <LoadWorldSpaceUiRoot>d__.<>t__builder.Task;
		}

		// Token: 0x0602335C RID: 144220 RVA: 0x00A00ED4 File Offset: 0x009FF0D4
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

		// Token: 0x0602335D RID: 144221 RVA: 0x00A00F18 File Offset: 0x009FF118
		public bool IsUiActive()
		{
			UUIItem uiRootItemInternal = this.UiRootItemInternal;
			return uiRootItemInternal != null && uiRootItemInternal.IsValid() && uiRootItemInternal.IsUIActiveInHierarchy();
		}

		// Token: 0x0602335E RID: 144222 RVA: 0x00A00F3F File Offset: 0x009FF13F
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

		// Token: 0x0602335F RID: 144223 RVA: 0x00A00F63 File Offset: 0x009FF163
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

		// Token: 0x06023360 RID: 144224 RVA: 0x00A00F83 File Offset: 0x009FF183
		public bool IsForceHideUi()
		{
			return this.IsForceHideUiRoot;
		}

		// Token: 0x06023361 RID: 144225 RVA: 0x00A00F8B File Offset: 0x009FF18B
		public void SetForceHideUiState(bool show)
		{
			this.IsForceHideUiRoot = !show;
		}

		// Token: 0x06023362 RID: 144226 RVA: 0x00A00F98 File Offset: 0x009FF198
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

		// Token: 0x06023363 RID: 144227 RVA: 0x00A00FC8 File Offset: 0x009FF1C8
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

		// Token: 0x06023364 RID: 144228 RVA: 0x00A0107D File Offset: 0x009FF27D
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

		// Token: 0x06023365 RID: 144229 RVA: 0x00A010A0 File Offset: 0x009FF2A0
		public bool IsInMask()
		{
			UUIItem layerRootUiItem = this.GetLayerRootUiItem(ELayerType.Mask);
			return layerRootUiItem != null && layerRootUiItem.IsRaycastTarget();
		}

		// Token: 0x06023366 RID: 144230 RVA: 0x00A010C4 File Offset: 0x009FF2C4
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

		// Token: 0x06023367 RID: 144231 RVA: 0x00A01142 File Offset: 0x009FF342
		[NullableContext(1)]
		public Vector2D GetViewportSize()
		{
			if (!ObjectUtils.IsValid(this.UiRootItem))
			{
				return Vector2D.Create();
			}
			return Vector2D.Create((double)this.UiRootItem.GetWidth(), (double)this.UiRootItem.GetHeight());
		}

		// Token: 0x06023368 RID: 144232 RVA: 0x00A01174 File Offset: 0x009FF374
		private void OnViewPortSizeChanged(FIntPoint newViewportSize)
		{
			Log.Instance.Info(ELogModule.UiCore, ELogAuthor.CFT, "UIRootItem OnViewPortSizeChange", default(ReadOnlySpan<ValueTuple<string, object>>));
			EventSystem.Instance.Emit(EEventName.UIViewPortSizeChanged);
		}

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06023369 RID: 144233 RVA: 0x00A011AA File Offset: 0x009FF3AA
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

		// Token: 0x0602336A RID: 144234 RVA: 0x00A011CD File Offset: 0x009FF3CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602336B RID: 144235 RVA: 0x00A011CF File Offset: 0x009FF3CF
		public static void ResetStaticDefaultValue()
		{
			UiLayer instance = UiLayer._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UiLayer._instance = null;
		}

		// Token: 0x0602336C RID: 144236 RVA: 0x00A011E8 File Offset: 0x009FF3E8
		static UiLayer()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiLayer.CreateStaticDefaultValue), new Action(UiLayer.ResetStaticDefaultValue));
		}

		// Token: 0x04013DBA RID: 81338
		private bool IsInitializing;

		// Token: 0x04013DBB RID: 81339
		[Nullable(1)]
		private string NormalMaskLock = "";

		// Token: 0x04013DBC RID: 81340
		private AActor UiRootInternal;

		// Token: 0x04013DBD RID: 81341
		private UUIItem UiRootItemInternal;

		// Token: 0x04013DBE RID: 81342
		private AActor WorldSpaceUiRootInternal;

		// Token: 0x04013DBF RID: 81343
		private UUIItem WorldSpaceUiRootItemInternal;

		// Token: 0x04013DC0 RID: 81344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UUIItem> BattleViewUnitList;

		// Token: 0x04013DC1 RID: 81345
		[Nullable(1)]
		private readonly Dictionary<ELayerType, UUIItem> LayerMap = new Dictionary<ELayerType, UUIItem>();

		// Token: 0x04013DC2 RID: 81346
		private bool IsForceHideUiRoot;

		// Token: 0x04013DC3 RID: 81347
		[Nullable(1)]
		private readonly HashSet<string> MaskTagSet = new HashSet<string>();

		// Token: 0x04013DC4 RID: 81348
		[Nullable(1)]
		private readonly Dictionary<ELayerType, List<UUIItem>> FloatUnitMap = new Dictionary<ELayerType, List<UUIItem>>();

		// Token: 0x04013DC5 RID: 81349
		[Nullable(1)]
		private readonly Dictionary<ELayerType, UUIItem> PureModeFloatUnitMap = new Dictionary<ELayerType, UUIItem>();

		// Token: 0x04013DC6 RID: 81350
		[Nullable(1)]
		private readonly Array LayerTypeArray = Enum.GetValues(typeof(ELayerType));

		// Token: 0x04013DC7 RID: 81351
		private static UiLayer _instance;
	}
}
