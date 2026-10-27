using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046CE RID: 18126
	[NullableContext(1)]
	[Nullable(0)]
	public class UiImageSettingModule : UiResourceLoadModule
	{
		// Token: 0x0602EBDA RID: 191450 RVA: 0x00AD1558 File Offset: 0x00ACF758
		private void SetSpriteBySprite([Nullable(2)] ULGUISpriteData_BaseObject sprite, UUISprite uiSprite, bool setSize, string path, [Nullable(2)] Action<bool> callback = null)
		{
			if (!uiSprite.IsValid())
			{
				return;
			}
			if (sprite == null || !sprite.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiImageSetting;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Sprite失败，图片加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("图片路径", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (callback != null)
				{
					callback(false);
				}
				return;
			}
			uiSprite.SetSprite(sprite, setSize);
			if (callback != null)
			{
				callback(true);
			}
		}

		// Token: 0x0602EBDB RID: 191451 RVA: 0x00AD15C5 File Offset: 0x00ACF7C5
		private void SetSpriteTransitionBySprite([Nullable(2)] ULGUISpriteData_BaseObject sprite, UUISpriteTransition uiSpriteTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			if (!uiSpriteTransition.IsValid())
			{
				return;
			}
			if (state == EUISelectableSelectionState.EUISelectableSelectionState_MAX)
			{
				uiSpriteTransition.SetAllTransitionSprite(sprite);
				return;
			}
			uiSpriteTransition.SetStateSprite(state, sprite);
		}

		// Token: 0x0602EBDC RID: 191452 RVA: 0x00AD15E4 File Offset: 0x00ACF7E4
		[NullableContext(2)]
		public void SetSpriteByPathSync([Nullable(1)] string path, UUISprite uiSprite, bool setSize, EUiViewName viewName, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (uiSprite == null || !uiSprite.IsValid())
			{
				return;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null || uiViewInfo.LoadAsync)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiImageSetting;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "该界面不允许同步加载,Sprite改为异步加载";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SetSpriteByPathAsync(path, uiSprite, setSize, callback);
				return;
			}
			ULGUISpriteData_BaseObject ulguispriteData_BaseObject = this.TryGetSpriteFromAtlasManager(path);
			if (ulguispriteData_BaseObject == null)
			{
				ulguispriteData_BaseObject = ResourceSystem.Instance.Load<ULGUISpriteData_BaseObject>(path, "js_undefined");
			}
			if (ulguispriteData_BaseObject == null || !ulguispriteData_BaseObject.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiImageSetting;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "设置Sprite失败，图片加载失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("图片路径", path);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			uiSprite.SetSprite(ulguispriteData_BaseObject, setSize);
		}

		// Token: 0x0602EBDD RID: 191453 RVA: 0x00AD16B4 File Offset: 0x00ACF8B4
		[NullableContext(2)]
		public void SetSpriteByPathAsync([Nullable(1)] string path, UUISprite uiSprite, bool setSize, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (uiSprite == null || !uiSprite.IsValid())
			{
				return;
			}
			base.CancelResource(uiSprite);
			ULGUISpriteData_BaseObject ulguispriteData_BaseObject = this.TryGetSpriteFromAtlasManager(path);
			if (ulguispriteData_BaseObject != null)
			{
				this.SetSpriteBySprite(ulguispriteData_BaseObject, uiSprite, setSize, path, callback);
				return;
			}
			int resourceId = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(path, delegate([Nullable(2)] ULGUISpriteData_BaseObject image, string loadPath)
			{
				this.DeleteResourceHandle(uiSprite);
				this.SetSpriteBySprite(image, uiSprite, setSize, loadPath, callback);
			}, 102, "js_undefined");
			base.SetResourceId(uiSprite, resourceId);
		}

		// Token: 0x0602EBDE RID: 191454 RVA: 0x00AD1760 File Offset: 0x00ACF960
		public UniTask SetSpriteAsync(string path, [Nullable(2)] UUISprite uiSprite, bool setSize)
		{
			UiImageSettingModule.<SetSpriteAsync>d__8 <SetSpriteAsync>d__;
			<SetSpriteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteAsync>d__.<>4__this = this;
			<SetSpriteAsync>d__.path = path;
			<SetSpriteAsync>d__.uiSprite = uiSprite;
			<SetSpriteAsync>d__.setSize = setSize;
			<SetSpriteAsync>d__.<>1__state = -1;
			<SetSpriteAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetSpriteAsync>d__8>(ref <SetSpriteAsync>d__);
			return <SetSpriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBDF RID: 191455 RVA: 0x00AD17BC File Offset: 0x00ACF9BC
		public UniTask SetSpriteTransitionByPath(string path, [Nullable(2)] UUISpriteTransition uiSpriteTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiImageSettingModule.<SetSpriteTransitionByPath>d__9 <SetSpriteTransitionByPath>d__;
			<SetSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteTransitionByPath>d__.<>4__this = this;
			<SetSpriteTransitionByPath>d__.path = path;
			<SetSpriteTransitionByPath>d__.uiSpriteTransition = uiSpriteTransition;
			<SetSpriteTransitionByPath>d__.state = state;
			<SetSpriteTransitionByPath>d__.<>1__state = -1;
			<SetSpriteTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetSpriteTransitionByPath>d__9>(ref <SetSpriteTransitionByPath>d__);
			return <SetSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBE0 RID: 191456 RVA: 0x00AD1818 File Offset: 0x00ACFA18
		public void SetItemQualityIconSync(UUISprite sprite, int itemId, EUiViewName viewName, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			this.SetQualityIconByIdSync(sprite, itemConfigData.QualityId, viewName, type, action);
		}

		// Token: 0x0602EBE1 RID: 191457 RVA: 0x00AD1844 File Offset: 0x00ACFA44
		public void SetItemQualityIconAsync(UUISprite sprite, int itemId, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			if (itemConfigData != null)
			{
				this.SetQualityIconByIdAsync(sprite, itemConfigData.QualityId, type, action);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiImageSetting;
			ELogAuthor author = ELogAuthor.LRX;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
			defaultInterpolatedStringHandler.AppendLiteral("GetItemConfigData with ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemId);
			defaultInterpolatedStringHandler.AppendLiteral(" results in null config data!");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602EBE2 RID: 191458 RVA: 0x00AD18BC File Offset: 0x00ACFABC
		private string GetQualityPath(UUISprite sprite, int qualityId, CommonDefine.EQualityIconType type)
		{
			QualityInfo? itemQualityById = CommonConfig.Instance.GetItemQualityById(qualityId);
			TArray<FName> componentTags = sprite.ComponentTags;
			if (componentTags.Num() == 0)
			{
				return CommonConfig.Instance.GetItemQualityValueByParam(itemQualityById, new CommonDefine.EQualityIconType?(type)) ?? "";
			}
			string text = componentTags.Get(0).ToString();
			string qualityConfigParam = ComponentConfig.Instance.GetQualityConfigParam(text);
			string text2 = null;
			CommonDefine.EQualityIconType value;
			if (qualityConfigParam != null && Enum.TryParse<CommonDefine.EQualityIconType>(qualityConfigParam, true, out value))
			{
				text2 = CommonConfig.Instance.GetItemQualityValueByParam(itemQualityById, new CommonDefine.EQualityIconType?(value));
			}
			if (text2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiImageSetting;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "配置的表格字段查询到的资源路径不是字符串类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", text);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			return text2;
		}

		// Token: 0x0602EBE3 RID: 191459 RVA: 0x00AD1984 File Offset: 0x00ACFB84
		public void SetQualityIconByIdSync(UUISprite sprite, int qualityId, EUiViewName viewName, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			string qualityPath = this.GetQualityPath(sprite, qualityId, type);
			this.SetSpriteByPathSync(qualityPath, sprite, false, viewName, action);
		}

		// Token: 0x0602EBE4 RID: 191460 RVA: 0x00AD19A8 File Offset: 0x00ACFBA8
		public void SetQualityIconByIdAsync(UUISprite sprite, int qualityId, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			string qualityPath = this.GetQualityPath(sprite, qualityId, type);
			this.SetSpriteByPathAsync(qualityPath, sprite, false, action);
		}

		// Token: 0x0602EBE5 RID: 191461 RVA: 0x00AD19CC File Offset: 0x00ACFBCC
		[NullableContext(2)]
		public void SetTextureByPathSync([Nullable(1)] string path, UUITexture uiTexture, EUiViewName viewName, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (uiTexture == null || !uiTexture.IsValid())
			{
				return;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null || !uiViewInfo.LoadAsync)
			{
				UTexture utexture = ResourceSystem.Instance.Load<UTexture>(path, "js_undefined");
				if (utexture != null)
				{
					uiTexture.SetTexture(utexture);
					return;
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiImageSetting;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "该界面不允许同步加载,Texture改为异步加载";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SetTextureByPathAsync(path, uiTexture, callback);
			}
		}

		// Token: 0x0602EBE6 RID: 191462 RVA: 0x00AD1A5C File Offset: 0x00ACFC5C
		[NullableContext(2)]
		public void SetTextureByPathAsync([Nullable(1)] string path, UUITexture uiTexture, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (uiTexture == null || !uiTexture.IsValid())
			{
				return;
			}
			base.CancelResource(uiTexture);
			int resourceId = ResourceSystem.Instance.LoadAsync<UTexture>(path2, delegate([Nullable(2)] UTexture image, string path)
			{
				this.DeleteResourceHandle(uiTexture);
				if (!uiTexture.IsValid())
				{
					return;
				}
				if (image == null || !image.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiImageSetting;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "设置Texture失败，图片加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("图片路径", path);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					uiTexture.SetTexture(image);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 102, "js_undefined");
			base.SetResourceId(uiTexture, resourceId);
		}

		// Token: 0x0602EBE7 RID: 191463 RVA: 0x00AD1ADC File Offset: 0x00ACFCDC
		public UniTask SetTextureAsync(string path, [Nullable(2)] UUITexture uiTexture)
		{
			UiImageSettingModule.<SetTextureAsync>d__17 <SetTextureAsync>d__;
			<SetTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureAsync>d__.<>4__this = this;
			<SetTextureAsync>d__.path = path;
			<SetTextureAsync>d__.uiTexture = uiTexture;
			<SetTextureAsync>d__.<>1__state = -1;
			<SetTextureAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureAsync>d__17>(ref <SetTextureAsync>d__);
			return <SetTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBE8 RID: 191464 RVA: 0x00AD1B30 File Offset: 0x00ACFD30
		public UniTask SetTextureTransitionByPath(string path, [Nullable(2)] UUITextureTransitionComponent uiTextureTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiImageSettingModule.<SetTextureTransitionByPath>d__18 <SetTextureTransitionByPath>d__;
			<SetTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureTransitionByPath>d__.<>4__this = this;
			<SetTextureTransitionByPath>d__.path = path;
			<SetTextureTransitionByPath>d__.uiTextureTransition = uiTextureTransition;
			<SetTextureTransitionByPath>d__.state = state;
			<SetTextureTransitionByPath>d__.<>1__state = -1;
			<SetTextureTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureTransitionByPath>d__18>(ref <SetTextureTransitionByPath>d__);
			return <SetTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBE9 RID: 191465 RVA: 0x00AD1B8C File Offset: 0x00ACFD8C
		public UniTask SetExtendToggleTextureTransitionByPath(string path, [Nullable(2)] UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState state = EToggleTransitionState.ETT_MAX)
		{
			UiImageSettingModule.<SetExtendToggleTextureTransitionByPath>d__19 <SetExtendToggleTextureTransitionByPath>d__;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionByPath>d__.path = path;
			<SetExtendToggleTextureTransitionByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionByPath>d__.state = state;
			<SetExtendToggleTextureTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleTextureTransitionByPath>d__19>(ref <SetExtendToggleTextureTransitionByPath>d__);
			return <SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBEA RID: 191466 RVA: 0x00AD1BE8 File Offset: 0x00ACFDE8
		public UniTask SetExtendToggleTextureTransitionGroupByPath(string path, [Nullable(2)] UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState[] states)
		{
			UiImageSettingModule.<SetExtendToggleTextureTransitionGroupByPath>d__20 <SetExtendToggleTextureTransitionGroupByPath>d__;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionGroupByPath>d__.path = path;
			<SetExtendToggleTextureTransitionGroupByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionGroupByPath>d__.states = states;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleTextureTransitionGroupByPath>d__20>(ref <SetExtendToggleTextureTransitionGroupByPath>d__);
			return <SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBEB RID: 191467 RVA: 0x00AD1C44 File Offset: 0x00ACFE44
		public UniTask SetTextureCustomMaterialAsync(string materialPath, [Nullable(2)] UUITexture uiTexture)
		{
			UiImageSettingModule.<SetTextureCustomMaterialAsync>d__21 <SetTextureCustomMaterialAsync>d__;
			<SetTextureCustomMaterialAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureCustomMaterialAsync>d__.<>4__this = this;
			<SetTextureCustomMaterialAsync>d__.materialPath = materialPath;
			<SetTextureCustomMaterialAsync>d__.uiTexture = uiTexture;
			<SetTextureCustomMaterialAsync>d__.<>1__state = -1;
			<SetTextureCustomMaterialAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureCustomMaterialAsync>d__21>(ref <SetTextureCustomMaterialAsync>d__);
			return <SetTextureCustomMaterialAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBEC RID: 191468 RVA: 0x00AD1C97 File Offset: 0x00ACFE97
		[NullableContext(2)]
		private void SetExtendToggleSpriteTransitionBySprite(ULGUISpriteData_BaseObject sprite, UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState state = EToggleTransitionState.ETT_MAX)
		{
			if (uiExtendToggleSpriteTransition == null || !uiExtendToggleSpriteTransition.IsValid())
			{
				return;
			}
			if (state == EToggleTransitionState.ETT_MAX)
			{
				uiExtendToggleSpriteTransition.SetAllStateSprite(sprite);
				return;
			}
			uiExtendToggleSpriteTransition.SetStateSprite(state, sprite, false);
		}

		// Token: 0x0602EBED RID: 191469 RVA: 0x00AD1CBC File Offset: 0x00ACFEBC
		public UniTask SetExtendToggleSpriteTransitionByPath(string path, [Nullable(2)] UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState[] stateList)
		{
			UiImageSettingModule.<SetExtendToggleSpriteTransitionByPath>d__23 <SetExtendToggleSpriteTransitionByPath>d__;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByPath>d__.path = path;
			<SetExtendToggleSpriteTransitionByPath>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByPath>d__.stateList = stateList;
			<SetExtendToggleSpriteTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleSpriteTransitionByPath>d__23>(ref <SetExtendToggleSpriteTransitionByPath>d__);
			return <SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBEE RID: 191470 RVA: 0x00AD1D18 File Offset: 0x00ACFF18
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<TAsset> LoadUiTransitionAsync<[Nullable(0)] TAsset>(UObject transition, string path, int[] stateKeys, int maxStateKey) where TAsset : UObject
		{
			UiImageSettingModule.<LoadUiTransitionAsync>d__24<TAsset> <LoadUiTransitionAsync>d__;
			<LoadUiTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<TAsset>.Create();
			<LoadUiTransitionAsync>d__.<>4__this = this;
			<LoadUiTransitionAsync>d__.transition = transition;
			<LoadUiTransitionAsync>d__.path = path;
			<LoadUiTransitionAsync>d__.stateKeys = stateKeys;
			<LoadUiTransitionAsync>d__.maxStateKey = maxStateKey;
			<LoadUiTransitionAsync>d__.<>1__state = -1;
			<LoadUiTransitionAsync>d__.<>t__builder.Start<UiImageSettingModule.<LoadUiTransitionAsync>d__24<TAsset>>(ref <LoadUiTransitionAsync>d__);
			return <LoadUiTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBEF RID: 191471 RVA: 0x00AD1D7C File Offset: 0x00ACFF7C
		private int[] ToToggleStateKeys(EToggleTransitionState[] states)
		{
			int[] array = new int[states.Length];
			for (int i = 0; i < states.Length; i++)
			{
				array[i] = (int)states[i];
			}
			return array;
		}

		// Token: 0x0602EBF0 RID: 191472 RVA: 0x00AD1DA8 File Offset: 0x00ACFFA8
		private bool StatesOverlap(int[] existingStateKeys, int existingMaxStateKey, int[] incomingStateKeys, int incomingMaxStateKey)
		{
			foreach (int num in existingStateKeys)
			{
				if (num == existingMaxStateKey)
				{
					return true;
				}
				foreach (int num2 in incomingStateKeys)
				{
					if (num2 == incomingMaxStateKey || num == num2)
					{
						return true;
					}
				}
			}
			for (int i = 0; i < incomingStateKeys.Length; i++)
			{
				if (incomingStateKeys[i] == incomingMaxStateKey)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602EBF1 RID: 191473 RVA: 0x00AD1E10 File Offset: 0x00AD0010
		private void CancelConflictingUiTransitionLoads(UObject transition, int[] newStateKeys, int maxStateKey)
		{
			List<UiImageSettingModule.PendingUiTransitionLoad> list;
			if (!this.PendingUiTransitionLoadMap.TryGetValue(transition, out list))
			{
				return;
			}
			for (int i = list.Count - 1; i >= 0; i--)
			{
				UiImageSettingModule.PendingUiTransitionLoad pendingUiTransitionLoad = list[i];
				if (this.StatesOverlap(pendingUiTransitionLoad.StateKeys, pendingUiTransitionLoad.MaxStateKey, newStateKeys, maxStateKey))
				{
					pendingUiTransitionLoad.Cancelled = true;
					if (pendingUiTransitionLoad.ResourceId != -1)
					{
						ResourceSystem.Instance.CancelAsyncLoad(pendingUiTransitionLoad.ResourceId);
					}
					list.RemoveAt(i);
				}
			}
			if (list.Count == 0)
			{
				this.PendingUiTransitionLoadMap.Remove(transition);
			}
		}

		// Token: 0x0602EBF2 RID: 191474 RVA: 0x00AD1E9C File Offset: 0x00AD009C
		private void AddPendingUiTransitionLoad(UObject transition, UiImageSettingModule.PendingUiTransitionLoad pending)
		{
			List<UiImageSettingModule.PendingUiTransitionLoad> list;
			if (!this.PendingUiTransitionLoadMap.TryGetValue(transition, out list))
			{
				list = new List<UiImageSettingModule.PendingUiTransitionLoad>();
				this.PendingUiTransitionLoadMap[transition] = list;
			}
			list.Add(pending);
		}

		// Token: 0x0602EBF3 RID: 191475 RVA: 0x00AD1ED4 File Offset: 0x00AD00D4
		private void RemovePendingUiTransitionLoad(UObject transition, UiImageSettingModule.PendingUiTransitionLoad pending)
		{
			List<UiImageSettingModule.PendingUiTransitionLoad> list;
			if (!this.PendingUiTransitionLoadMap.TryGetValue(transition, out list))
			{
				return;
			}
			list.Remove(pending);
			if (list.Count == 0)
			{
				this.PendingUiTransitionLoadMap.Remove(transition);
			}
		}

		// Token: 0x0602EBF4 RID: 191476 RVA: 0x00AD1F10 File Offset: 0x00AD0110
		private string GetItemIcon(UUITexture texture, int itemId)
		{
			if (itemId == 0)
			{
				return string.Empty;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0)
			{
				return itemConfigData.Icon;
			}
			string tag = componentTags.Get(0).ToString();
			string itemConfigParam = ComponentConfig.Instance.GetItemConfigParam(tag);
			return InventoryConfig.Instance.GetItemConfigValueByParam(itemId, itemConfigParam, tag) ?? "";
		}

		// Token: 0x0602EBF5 RID: 191477 RVA: 0x00AD1F84 File Offset: 0x00AD0184
		public void SetItemIconSync(UUITexture texture, int itemId, EUiViewName viewName, [Nullable(2)] Action<bool> action = null)
		{
			string itemIcon = this.GetItemIcon(texture, itemId);
			if (!string.IsNullOrEmpty(itemIcon))
			{
				this.SetTextureByPathSync(itemIcon, texture, viewName, action);
			}
		}

		// Token: 0x0602EBF6 RID: 191478 RVA: 0x00AD1FB0 File Offset: 0x00AD01B0
		public void SetItemIconAsync(UUITexture texture, int itemId, [Nullable(2)] Action<bool> action = null)
		{
			string itemIcon = this.GetItemIcon(texture, itemId);
			if (!string.IsNullOrEmpty(itemIcon))
			{
				this.SetTextureByPathAsync(itemIcon, texture, action);
			}
		}

		// Token: 0x0602EBF7 RID: 191479 RVA: 0x00AD1FD8 File Offset: 0x00AD01D8
		public UniTask SetItemIconTextureAsync(UUITexture texture, int itemId)
		{
			UiImageSettingModule.<SetItemIconTextureAsync>d__33 <SetItemIconTextureAsync>d__;
			<SetItemIconTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetItemIconTextureAsync>d__.<>4__this = this;
			<SetItemIconTextureAsync>d__.texture = texture;
			<SetItemIconTextureAsync>d__.itemId = itemId;
			<SetItemIconTextureAsync>d__.<>1__state = -1;
			<SetItemIconTextureAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetItemIconTextureAsync>d__33>(ref <SetItemIconTextureAsync>d__);
			return <SetItemIconTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EBF8 RID: 191480 RVA: 0x00AD202C File Offset: 0x00AD022C
		private string GetRoleIcon(string path, UUITexture texture, int roleId)
		{
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0)
			{
				return path;
			}
			RoleConfig.Instance.GetRoleConfig(roleId);
			string tag = componentTags.Get(0).ToString();
			string roleConfigParam = ComponentConfig.Instance.GetRoleConfigParam(tag);
			return RoleConfig.Instance.GetRoleConfigValueByParam(roleId, roleConfigParam, tag) ?? "";
		}

		// Token: 0x0602EBF9 RID: 191481 RVA: 0x00AD2090 File Offset: 0x00AD0290
		public void SetRoleIconSync(string path, UUITexture texture, int roleId, EUiViewName viewName, [Nullable(2)] Action<bool> callback = null)
		{
			string roleIcon = this.GetRoleIcon(path, texture, roleId);
			this.SetTextureByPathSync(roleIcon, texture, viewName, callback);
		}

		// Token: 0x0602EBFA RID: 191482 RVA: 0x00AD20B4 File Offset: 0x00AD02B4
		private string GetRoleSkinIcon(string path, UUITexture texture, int skinId)
		{
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0)
			{
				return path;
			}
			if (SkinConfig.Instance.GetRoleSkinConfig(skinId) == null)
			{
				return path;
			}
			string tag = componentTags.Get(0).ToString();
			string roleSkinConfigParam = ComponentConfig.Instance.GetRoleSkinConfigParam(tag);
			return SkinConfig.Instance.GetRoleSkinConfigValueByParam(skinId, roleSkinConfigParam, tag) ?? "";
		}

		// Token: 0x0602EBFB RID: 191483 RVA: 0x00AD2124 File Offset: 0x00AD0324
		public void SetRoleSkinIconAsync(string path, UUITexture texture, int skinId, [Nullable(2)] Action<bool> callback = null)
		{
			string roleSkinIcon = this.GetRoleSkinIcon(path, texture, skinId);
			this.SetTextureByPathAsync(roleSkinIcon, texture, callback);
		}

		// Token: 0x0602EBFC RID: 191484 RVA: 0x00AD2148 File Offset: 0x00AD0348
		public void SetRoleSkinIconSync(string path, UUITexture texture, int skinId, EUiViewName viewName, [Nullable(2)] Action<bool> callback = null)
		{
			string roleSkinIcon = this.GetRoleSkinIcon(path, texture, skinId);
			this.SetTextureByPathSync(roleSkinIcon, texture, viewName, callback);
		}

		// Token: 0x0602EBFD RID: 191485 RVA: 0x00AD216C File Offset: 0x00AD036C
		public void SetRoleIconAsync(string path, UUITexture texture, int roleId, [Nullable(2)] Action<bool> callback = null)
		{
			string roleIcon = this.GetRoleIcon(path, texture, roleId);
			this.SetTextureByPathAsync(roleIcon, texture, callback);
		}

		// Token: 0x0602EBFE RID: 191486 RVA: 0x00AD2190 File Offset: 0x00AD0390
		private string GetElementIcon(string path, UUITexture texture, int elementId)
		{
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0)
			{
				return path;
			}
			ElementInfoConfig.Instance.GetElementInfo(elementId);
			string tag = componentTags.Get(0).ToString();
			string elementConfigParam = ComponentConfig.Instance.GetElementConfigParam(tag);
			return ElementInfoConfig.Instance.GetElementInfoValueByParam(elementId, elementConfigParam, tag) ?? "";
		}

		// Token: 0x0602EBFF RID: 191487 RVA: 0x00AD21F4 File Offset: 0x00AD03F4
		public void SetElementIconSync(string path, UUITexture texture, int elementId, EUiViewName viewName)
		{
			string elementIcon = this.GetElementIcon(path, texture, elementId);
			this.SetTextureByPathSync(elementIcon, texture, viewName, null);
		}

		// Token: 0x0602EC00 RID: 191488 RVA: 0x00AD2218 File Offset: 0x00AD0418
		public void SetElementIcon(string path, UUITexture texture, int elementId)
		{
			string elementIcon = this.GetElementIcon(path, texture, elementId);
			this.SetTextureByPathAsync(elementIcon, texture, null);
		}

		// Token: 0x0602EC01 RID: 191489 RVA: 0x00AD2238 File Offset: 0x00AD0438
		private string GetMonsterIcon(string path, UUITexture texture, int monsterInfoId)
		{
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0 || monsterInfoId == 0)
			{
				return path;
			}
			MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterInfoId);
			string tag = componentTags.Get(0).ToString();
			string monsterConfigParam = ComponentConfig.Instance.GetMonsterConfigParam(tag);
			return MonsterInfoConfig.Instance.GetMonsterInfoConfigValueByParam(monsterInfoId, monsterConfigParam, tag) ?? "";
		}

		// Token: 0x0602EC02 RID: 191490 RVA: 0x00AD22A0 File Offset: 0x00AD04A0
		public void SetMonsterIconSync(string path, UUITexture texture, int monsterInfoId, EUiViewName viewName)
		{
			string monsterIcon = this.GetMonsterIcon(path, texture, monsterInfoId);
			this.SetTextureByPathSync(monsterIcon, texture, viewName, null);
		}

		// Token: 0x0602EC03 RID: 191491 RVA: 0x00AD22C4 File Offset: 0x00AD04C4
		public void SetMonsterIconAsync(string path, UUITexture texture, int monsterInfoId)
		{
			string monsterIcon = this.GetMonsterIcon(path, texture, monsterInfoId);
			this.SetTextureByPathAsync(monsterIcon, texture, null);
		}

		// Token: 0x0602EC04 RID: 191492 RVA: 0x00AD22E4 File Offset: 0x00AD04E4
		private string GetDungeonEntranceIcon(string path, UUITexture texture, int entranceId)
		{
			TArray<FName> componentTags = texture.ComponentTags;
			if (componentTags.Num() == 0 || entranceId == 0)
			{
				return path;
			}
			string tag = componentTags.Get(0).ToString();
			string dungeonEntranceConfigParam = ComponentConfig.Instance.GetDungeonEntranceConfigParam(tag);
			return InstanceDungeonEntranceConfig.Instance.GetConfigValueByParam(entranceId, dungeonEntranceConfigParam, tag) ?? "";
		}

		// Token: 0x0602EC05 RID: 191493 RVA: 0x00AD2340 File Offset: 0x00AD0540
		public void SetDungeonEntranceIconSync(string path, UUITexture texture, int entranceId, EUiViewName viewName)
		{
			string dungeonEntranceIcon = this.GetDungeonEntranceIcon(path, texture, entranceId);
			this.SetTextureByPathSync(dungeonEntranceIcon, texture, viewName, null);
		}

		// Token: 0x0602EC06 RID: 191494 RVA: 0x00AD2364 File Offset: 0x00AD0564
		public void SetDungeonEntranceIconAsync(string path, UUITexture texture, int entranceId)
		{
			string dungeonEntranceIcon = this.GetDungeonEntranceIcon(path, texture, entranceId);
			this.SetTextureByPathAsync(dungeonEntranceIcon, texture, null);
		}

		// Token: 0x0602EC07 RID: 191495 RVA: 0x00AD2384 File Offset: 0x00AD0584
		public void SetNiagaraTextureAsync(string iconPath, [Nullable(2)] UUINiagara niagara, string emitterName, string variableName, [Nullable(2)] Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (niagara == null || !niagara.IsValid())
			{
				return;
			}
			base.CancelResource(niagara);
			int resourceId = ResourceSystem.Instance.LoadAsync<UTexture>(iconPath, delegate([Nullable(2)] UTexture image, string path)
			{
				this.DeleteResourceHandle(niagara);
				if (!niagara.IsValid())
				{
					return;
				}
				if (image == null || !image.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiImageSetting;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "设置Texture失败，图片加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("图片路径", path);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					niagara.SetNiagaraEmitterCustomTexture(emitterName, variableName, image);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 102, "js_undefined");
			base.SetResourceId(niagara, resourceId);
		}

		// Token: 0x0602EC08 RID: 191496 RVA: 0x00AD2414 File Offset: 0x00AD0614
		public void SetNiagaraTextureSync(string iconPath, [Nullable(2)] UUINiagara niagara, string emitterName, string variableName, EUiViewName viewName, [Nullable(2)] Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (niagara == null || !niagara.IsValid())
			{
				return;
			}
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null || uiViewInfo.LoadAsync)
			{
				UTexture inTexture = ResourceSystem.Instance.Load<UTexture>(iconPath, "js_undefined");
				niagara.SetNiagaraEmitterCustomTexture(emitterName, variableName, inTexture);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiImageSetting;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "该界面不允许同步加载,Texture改为异步加载";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", viewName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SetNiagaraTextureAsync(iconPath, niagara, emitterName, variableName, callback);
		}

		// Token: 0x0602EC09 RID: 191497 RVA: 0x00AD24A8 File Offset: 0x00AD06A8
		[return: Nullable(2)]
		private ULGUISpriteData_BaseObject TryGetSpriteFromAtlasManager(string path)
		{
			UUIDynamicSpriteAtlasMgr dynamicSpriteAtlasMgr = ALGUIManagerActor.GetDynamicSpriteAtlasMgr(GlobalData.World);
			if (dynamicSpriteAtlasMgr == null)
			{
				return null;
			}
			return dynamicSpriteAtlasMgr.GetSpriteData(path);
		}

		// Token: 0x0602EC0A RID: 191498 RVA: 0x00AD24CC File Offset: 0x00AD06CC
		public override void Clear()
		{
			foreach (List<UiImageSettingModule.PendingUiTransitionLoad> list in this.PendingUiTransitionLoadMap.Values)
			{
				foreach (UiImageSettingModule.PendingUiTransitionLoad pendingUiTransitionLoad in list)
				{
					pendingUiTransitionLoad.Cancelled = true;
					if (pendingUiTransitionLoad.ResourceId != -1)
					{
						ResourceSystem.Instance.CancelAsyncLoad(pendingUiTransitionLoad.ResourceId);
					}
				}
			}
			this.PendingUiTransitionLoadMap.Clear();
			base.Clear();
		}

		// Token: 0x04019719 RID: 104217
		private readonly Dictionary<UObject, List<UiImageSettingModule.PendingUiTransitionLoad>> PendingUiTransitionLoadMap = new Dictionary<UObject, List<UiImageSettingModule.PendingUiTransitionLoad>>();

		// Token: 0x0401971A RID: 104218
		private const int ToggleMaxStateKey = 9;

		// Token: 0x0401971B RID: 104219
		private const int SelectableMaxStateKey = 5;

		// Token: 0x0200A90B RID: 43275
		[NullableContext(0)]
		private sealed class PendingUiTransitionLoad
		{
			// Token: 0x0403374C RID: 210764
			public int ResourceId = -1;

			// Token: 0x0403374D RID: 210765
			[Nullable(1)]
			public int[] StateKeys = Array.Empty<int>();

			// Token: 0x0403374E RID: 210766
			public int MaxStateKey;

			// Token: 0x0403374F RID: 210767
			public bool Cancelled;
		}
	}
}
