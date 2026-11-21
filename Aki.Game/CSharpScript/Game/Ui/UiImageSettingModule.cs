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
	// Token: 0x020035FE RID: 13822
	[NullableContext(1)]
	[Nullable(0)]
	public class UiImageSettingModule : UiResourceLoadModule
	{
		// Token: 0x06023314 RID: 144148 RVA: 0x009FF830 File Offset: 0x009FDA30
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

		// Token: 0x06023315 RID: 144149 RVA: 0x009FF89D File Offset: 0x009FDA9D
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

		// Token: 0x06023316 RID: 144150 RVA: 0x009FF8BC File Offset: 0x009FDABC
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

		// Token: 0x06023317 RID: 144151 RVA: 0x009FF98C File Offset: 0x009FDB8C
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

		// Token: 0x06023318 RID: 144152 RVA: 0x009FFA38 File Offset: 0x009FDC38
		public bool CancelSpriteLoad(UUISprite uiSprite)
		{
			return base.CancelAndDeleteResource(uiSprite);
		}

		// Token: 0x06023319 RID: 144153 RVA: 0x009FFA44 File Offset: 0x009FDC44
		public UniTask SetSpriteAsync(string path, [Nullable(2)] UUISprite uiSprite, bool setSize)
		{
			UiImageSettingModule.<SetSpriteAsync>d__9 <SetSpriteAsync>d__;
			<SetSpriteAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteAsync>d__.<>4__this = this;
			<SetSpriteAsync>d__.path = path;
			<SetSpriteAsync>d__.uiSprite = uiSprite;
			<SetSpriteAsync>d__.setSize = setSize;
			<SetSpriteAsync>d__.<>1__state = -1;
			<SetSpriteAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetSpriteAsync>d__9>(ref <SetSpriteAsync>d__);
			return <SetSpriteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602331A RID: 144154 RVA: 0x009FFAA0 File Offset: 0x009FDCA0
		public UniTask SetSpriteTransitionByPath(string path, [Nullable(2)] UUISpriteTransition uiSpriteTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiImageSettingModule.<SetSpriteTransitionByPath>d__10 <SetSpriteTransitionByPath>d__;
			<SetSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSpriteTransitionByPath>d__.<>4__this = this;
			<SetSpriteTransitionByPath>d__.path = path;
			<SetSpriteTransitionByPath>d__.uiSpriteTransition = uiSpriteTransition;
			<SetSpriteTransitionByPath>d__.state = state;
			<SetSpriteTransitionByPath>d__.<>1__state = -1;
			<SetSpriteTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetSpriteTransitionByPath>d__10>(ref <SetSpriteTransitionByPath>d__);
			return <SetSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602331B RID: 144155 RVA: 0x009FFAFC File Offset: 0x009FDCFC
		public void SetItemQualityIconSync(UUISprite sprite, int itemId, EUiViewName viewName, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			this.SetQualityIconByIdSync(sprite, itemConfigData.QualityId, viewName, type, action);
		}

		// Token: 0x0602331C RID: 144156 RVA: 0x009FFB28 File Offset: 0x009FDD28
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

		// Token: 0x0602331D RID: 144157 RVA: 0x009FFBA0 File Offset: 0x009FDDA0
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

		// Token: 0x0602331E RID: 144158 RVA: 0x009FFC68 File Offset: 0x009FDE68
		public void SetQualityIconByIdSync(UUISprite sprite, int qualityId, EUiViewName viewName, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			string qualityPath = this.GetQualityPath(sprite, qualityId, type);
			this.SetSpriteByPathSync(qualityPath, sprite, false, viewName, action);
		}

		// Token: 0x0602331F RID: 144159 RVA: 0x009FFC8C File Offset: 0x009FDE8C
		public void SetQualityIconByIdAsync(UUISprite sprite, int qualityId, CommonDefine.EQualityIconType type = CommonDefine.EQualityIconType.BackgroundSprite, [Nullable(2)] Action<bool> action = null)
		{
			string qualityPath = this.GetQualityPath(sprite, qualityId, type);
			this.SetSpriteByPathAsync(qualityPath, sprite, false, action);
		}

		// Token: 0x06023320 RID: 144160 RVA: 0x009FFCB0 File Offset: 0x009FDEB0
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

		// Token: 0x06023321 RID: 144161 RVA: 0x009FFD40 File Offset: 0x009FDF40
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

		// Token: 0x06023322 RID: 144162 RVA: 0x009FFDC0 File Offset: 0x009FDFC0
		[NullableContext(2)]
		public void SetRenderableMaskTextureByPathAsync([Nullable(1)] string path, UUIRenderableMask renderableMask, Action<bool> callback = null)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			if (renderableMask == null || !renderableMask.IsValid())
			{
				return;
			}
			base.CancelResource(renderableMask);
			int resourceId = ResourceSystem.Instance.LoadAsync<UTexture>(path2, delegate([Nullable(2)] UTexture image, string path)
			{
				this.DeleteResourceHandle(renderableMask);
				if (!renderableMask.IsValid())
				{
					return;
				}
				if (image == null || !image.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiImageSetting;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "设置RenderableMask Texture失败，图片加载失败";
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
					renderableMask.SetClipTexture(image);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 102, "js_undefined");
			base.SetResourceId(renderableMask, resourceId);
		}

		// Token: 0x06023323 RID: 144163 RVA: 0x009FFE40 File Offset: 0x009FE040
		public UniTask SetTextureAsync(string path, [Nullable(2)] UUITexture uiTexture)
		{
			UiImageSettingModule.<SetTextureAsync>d__19 <SetTextureAsync>d__;
			<SetTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureAsync>d__.<>4__this = this;
			<SetTextureAsync>d__.path = path;
			<SetTextureAsync>d__.uiTexture = uiTexture;
			<SetTextureAsync>d__.<>1__state = -1;
			<SetTextureAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureAsync>d__19>(ref <SetTextureAsync>d__);
			return <SetTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023324 RID: 144164 RVA: 0x009FFE94 File Offset: 0x009FE094
		public UniTask SetTextureTransitionByPath(string path, [Nullable(2)] UUITextureTransitionComponent uiTextureTransition, EUISelectableSelectionState state = EUISelectableSelectionState.EUISelectableSelectionState_MAX)
		{
			UiImageSettingModule.<SetTextureTransitionByPath>d__20 <SetTextureTransitionByPath>d__;
			<SetTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureTransitionByPath>d__.<>4__this = this;
			<SetTextureTransitionByPath>d__.path = path;
			<SetTextureTransitionByPath>d__.uiTextureTransition = uiTextureTransition;
			<SetTextureTransitionByPath>d__.state = state;
			<SetTextureTransitionByPath>d__.<>1__state = -1;
			<SetTextureTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureTransitionByPath>d__20>(ref <SetTextureTransitionByPath>d__);
			return <SetTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06023325 RID: 144165 RVA: 0x009FFEF0 File Offset: 0x009FE0F0
		public UniTask SetExtendToggleTextureTransitionByPath(string path, [Nullable(2)] UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState state = EToggleTransitionState.ETT_MAX)
		{
			UiImageSettingModule.<SetExtendToggleTextureTransitionByPath>d__21 <SetExtendToggleTextureTransitionByPath>d__;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionByPath>d__.path = path;
			<SetExtendToggleTextureTransitionByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionByPath>d__.state = state;
			<SetExtendToggleTextureTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleTextureTransitionByPath>d__21>(ref <SetExtendToggleTextureTransitionByPath>d__);
			return <SetExtendToggleTextureTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06023326 RID: 144166 RVA: 0x009FFF4C File Offset: 0x009FE14C
		public UniTask SetExtendToggleTextureTransitionGroupByPath(string path, [Nullable(2)] UUIExtendToggleTextureTransition uiExtendToggleTextureTransition, EToggleTransitionState[] states)
		{
			UiImageSettingModule.<SetExtendToggleTextureTransitionGroupByPath>d__22 <SetExtendToggleTextureTransitionGroupByPath>d__;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>4__this = this;
			<SetExtendToggleTextureTransitionGroupByPath>d__.path = path;
			<SetExtendToggleTextureTransitionGroupByPath>d__.uiExtendToggleTextureTransition = uiExtendToggleTextureTransition;
			<SetExtendToggleTextureTransitionGroupByPath>d__.states = states;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>1__state = -1;
			<SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleTextureTransitionGroupByPath>d__22>(ref <SetExtendToggleTextureTransitionGroupByPath>d__);
			return <SetExtendToggleTextureTransitionGroupByPath>d__.<>t__builder.Task;
		}

		// Token: 0x06023327 RID: 144167 RVA: 0x009FFFA8 File Offset: 0x009FE1A8
		public UniTask SetTextureCustomMaterialAsync(string materialPath, [Nullable(2)] UUITexture uiTexture)
		{
			UiImageSettingModule.<SetTextureCustomMaterialAsync>d__23 <SetTextureCustomMaterialAsync>d__;
			<SetTextureCustomMaterialAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTextureCustomMaterialAsync>d__.<>4__this = this;
			<SetTextureCustomMaterialAsync>d__.materialPath = materialPath;
			<SetTextureCustomMaterialAsync>d__.uiTexture = uiTexture;
			<SetTextureCustomMaterialAsync>d__.<>1__state = -1;
			<SetTextureCustomMaterialAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetTextureCustomMaterialAsync>d__23>(ref <SetTextureCustomMaterialAsync>d__);
			return <SetTextureCustomMaterialAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023328 RID: 144168 RVA: 0x009FFFFB File Offset: 0x009FE1FB
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

		// Token: 0x06023329 RID: 144169 RVA: 0x00A00020 File Offset: 0x009FE220
		public UniTask SetExtendToggleSpriteTransitionByPath(string path, [Nullable(2)] UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition, EToggleTransitionState[] stateList)
		{
			UiImageSettingModule.<SetExtendToggleSpriteTransitionByPath>d__25 <SetExtendToggleSpriteTransitionByPath>d__;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetExtendToggleSpriteTransitionByPath>d__.<>4__this = this;
			<SetExtendToggleSpriteTransitionByPath>d__.path = path;
			<SetExtendToggleSpriteTransitionByPath>d__.uiExtendToggleSpriteTransition = uiExtendToggleSpriteTransition;
			<SetExtendToggleSpriteTransitionByPath>d__.stateList = stateList;
			<SetExtendToggleSpriteTransitionByPath>d__.<>1__state = -1;
			<SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Start<UiImageSettingModule.<SetExtendToggleSpriteTransitionByPath>d__25>(ref <SetExtendToggleSpriteTransitionByPath>d__);
			return <SetExtendToggleSpriteTransitionByPath>d__.<>t__builder.Task;
		}

		// Token: 0x0602332A RID: 144170 RVA: 0x00A0007C File Offset: 0x009FE27C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<TAsset> LoadUiTransitionAsync<[Nullable(0)] TAsset>(UObject transition, string path, int[] stateKeys, int maxStateKey) where TAsset : UObject
		{
			UiImageSettingModule.<LoadUiTransitionAsync>d__26<TAsset> <LoadUiTransitionAsync>d__;
			<LoadUiTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<TAsset>.Create();
			<LoadUiTransitionAsync>d__.<>4__this = this;
			<LoadUiTransitionAsync>d__.transition = transition;
			<LoadUiTransitionAsync>d__.path = path;
			<LoadUiTransitionAsync>d__.stateKeys = stateKeys;
			<LoadUiTransitionAsync>d__.maxStateKey = maxStateKey;
			<LoadUiTransitionAsync>d__.<>1__state = -1;
			<LoadUiTransitionAsync>d__.<>t__builder.Start<UiImageSettingModule.<LoadUiTransitionAsync>d__26<TAsset>>(ref <LoadUiTransitionAsync>d__);
			return <LoadUiTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602332B RID: 144171 RVA: 0x00A000E0 File Offset: 0x009FE2E0
		private int[] ToToggleStateKeys(EToggleTransitionState[] states)
		{
			int[] array = new int[states.Length];
			for (int i = 0; i < states.Length; i++)
			{
				array[i] = (int)states[i];
			}
			return array;
		}

		// Token: 0x0602332C RID: 144172 RVA: 0x00A0010C File Offset: 0x009FE30C
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

		// Token: 0x0602332D RID: 144173 RVA: 0x00A00174 File Offset: 0x009FE374
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

		// Token: 0x0602332E RID: 144174 RVA: 0x00A00200 File Offset: 0x009FE400
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

		// Token: 0x0602332F RID: 144175 RVA: 0x00A00238 File Offset: 0x009FE438
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

		// Token: 0x06023330 RID: 144176 RVA: 0x00A00274 File Offset: 0x009FE474
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

		// Token: 0x06023331 RID: 144177 RVA: 0x00A002E8 File Offset: 0x009FE4E8
		public void SetItemIconSync(UUITexture texture, int itemId, EUiViewName viewName, [Nullable(2)] Action<bool> action = null)
		{
			string itemIcon = this.GetItemIcon(texture, itemId);
			if (!string.IsNullOrEmpty(itemIcon))
			{
				this.SetTextureByPathSync(itemIcon, texture, viewName, action);
			}
		}

		// Token: 0x06023332 RID: 144178 RVA: 0x00A00314 File Offset: 0x009FE514
		public void SetItemIconAsync(UUITexture texture, int itemId, [Nullable(2)] Action<bool> action = null)
		{
			string itemIcon = this.GetItemIcon(texture, itemId);
			if (!string.IsNullOrEmpty(itemIcon))
			{
				this.SetTextureByPathAsync(itemIcon, texture, action);
			}
		}

		// Token: 0x06023333 RID: 144179 RVA: 0x00A0033C File Offset: 0x009FE53C
		public UniTask SetItemIconTextureAsync(UUITexture texture, int itemId)
		{
			UiImageSettingModule.<SetItemIconTextureAsync>d__35 <SetItemIconTextureAsync>d__;
			<SetItemIconTextureAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetItemIconTextureAsync>d__.<>4__this = this;
			<SetItemIconTextureAsync>d__.texture = texture;
			<SetItemIconTextureAsync>d__.itemId = itemId;
			<SetItemIconTextureAsync>d__.<>1__state = -1;
			<SetItemIconTextureAsync>d__.<>t__builder.Start<UiImageSettingModule.<SetItemIconTextureAsync>d__35>(ref <SetItemIconTextureAsync>d__);
			return <SetItemIconTextureAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06023334 RID: 144180 RVA: 0x00A00390 File Offset: 0x009FE590
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

		// Token: 0x06023335 RID: 144181 RVA: 0x00A003F4 File Offset: 0x009FE5F4
		public void SetRoleIconSync(string path, UUITexture texture, int roleId, EUiViewName viewName, [Nullable(2)] Action<bool> callback = null)
		{
			string roleIcon = this.GetRoleIcon(path, texture, roleId);
			this.SetTextureByPathSync(roleIcon, texture, viewName, callback);
		}

		// Token: 0x06023336 RID: 144182 RVA: 0x00A00418 File Offset: 0x009FE618
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

		// Token: 0x06023337 RID: 144183 RVA: 0x00A00488 File Offset: 0x009FE688
		public void SetRoleSkinIconAsync(string path, UUITexture texture, int skinId, [Nullable(2)] Action<bool> callback = null)
		{
			string roleSkinIcon = this.GetRoleSkinIcon(path, texture, skinId);
			this.SetTextureByPathAsync(roleSkinIcon, texture, callback);
		}

		// Token: 0x06023338 RID: 144184 RVA: 0x00A004AC File Offset: 0x009FE6AC
		public void SetRoleSkinIconSync(string path, UUITexture texture, int skinId, EUiViewName viewName, [Nullable(2)] Action<bool> callback = null)
		{
			string roleSkinIcon = this.GetRoleSkinIcon(path, texture, skinId);
			this.SetTextureByPathSync(roleSkinIcon, texture, viewName, callback);
		}

		// Token: 0x06023339 RID: 144185 RVA: 0x00A004D0 File Offset: 0x009FE6D0
		public void SetRoleIconAsync(string path, UUITexture texture, int roleId, [Nullable(2)] Action<bool> callback = null)
		{
			string roleIcon = this.GetRoleIcon(path, texture, roleId);
			this.SetTextureByPathAsync(roleIcon, texture, callback);
		}

		// Token: 0x0602333A RID: 144186 RVA: 0x00A004F4 File Offset: 0x009FE6F4
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

		// Token: 0x0602333B RID: 144187 RVA: 0x00A00558 File Offset: 0x009FE758
		public void SetElementIconSync(string path, UUITexture texture, int elementId, EUiViewName viewName)
		{
			string elementIcon = this.GetElementIcon(path, texture, elementId);
			this.SetTextureByPathSync(elementIcon, texture, viewName, null);
		}

		// Token: 0x0602333C RID: 144188 RVA: 0x00A0057C File Offset: 0x009FE77C
		public void SetElementIcon(string path, UUITexture texture, int elementId)
		{
			string elementIcon = this.GetElementIcon(path, texture, elementId);
			this.SetTextureByPathAsync(elementIcon, texture, null);
		}

		// Token: 0x0602333D RID: 144189 RVA: 0x00A0059C File Offset: 0x009FE79C
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

		// Token: 0x0602333E RID: 144190 RVA: 0x00A00604 File Offset: 0x009FE804
		public void SetMonsterIconSync(string path, UUITexture texture, int monsterInfoId, EUiViewName viewName)
		{
			string monsterIcon = this.GetMonsterIcon(path, texture, monsterInfoId);
			this.SetTextureByPathSync(monsterIcon, texture, viewName, null);
		}

		// Token: 0x0602333F RID: 144191 RVA: 0x00A00628 File Offset: 0x009FE828
		public void SetMonsterIconAsync(string path, UUITexture texture, int monsterInfoId)
		{
			string monsterIcon = this.GetMonsterIcon(path, texture, monsterInfoId);
			this.SetTextureByPathAsync(monsterIcon, texture, null);
		}

		// Token: 0x06023340 RID: 144192 RVA: 0x00A00648 File Offset: 0x009FE848
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

		// Token: 0x06023341 RID: 144193 RVA: 0x00A006A4 File Offset: 0x009FE8A4
		public void SetDungeonEntranceIconSync(string path, UUITexture texture, int entranceId, EUiViewName viewName)
		{
			string dungeonEntranceIcon = this.GetDungeonEntranceIcon(path, texture, entranceId);
			this.SetTextureByPathSync(dungeonEntranceIcon, texture, viewName, null);
		}

		// Token: 0x06023342 RID: 144194 RVA: 0x00A006C8 File Offset: 0x009FE8C8
		public void SetDungeonEntranceIconAsync(string path, UUITexture texture, int entranceId)
		{
			string dungeonEntranceIcon = this.GetDungeonEntranceIcon(path, texture, entranceId);
			this.SetTextureByPathAsync(dungeonEntranceIcon, texture, null);
		}

		// Token: 0x06023343 RID: 144195 RVA: 0x00A006E8 File Offset: 0x009FE8E8
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

		// Token: 0x06023344 RID: 144196 RVA: 0x00A00778 File Offset: 0x009FE978
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

		// Token: 0x06023345 RID: 144197 RVA: 0x00A0080C File Offset: 0x009FEA0C
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

		// Token: 0x06023346 RID: 144198 RVA: 0x00A00830 File Offset: 0x009FEA30
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

		// Token: 0x04013DB7 RID: 81335
		private readonly Dictionary<UObject, List<UiImageSettingModule.PendingUiTransitionLoad>> PendingUiTransitionLoadMap = new Dictionary<UObject, List<UiImageSettingModule.PendingUiTransitionLoad>>();

		// Token: 0x04013DB8 RID: 81336
		private const int ToggleMaxStateKey = 9;

		// Token: 0x04013DB9 RID: 81337
		private const int SelectableMaxStateKey = 5;

		// Token: 0x020092C6 RID: 37574
		[NullableContext(0)]
		private sealed class PendingUiTransitionLoad
		{
			// Token: 0x0402DEE2 RID: 188130
			public int ResourceId = -1;

			// Token: 0x0402DEE3 RID: 188131
			[Nullable(1)]
			public int[] StateKeys = Array.Empty<int>();

			// Token: 0x0402DEE4 RID: 188132
			public int MaxStateKey;

			// Token: 0x0402DEE5 RID: 188133
			public bool Cancelled;
		}
	}
}
