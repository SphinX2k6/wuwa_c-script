using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048E7 RID: 18663
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyCombineComponent
	{
		// Token: 0x06030CDC RID: 199900 RVA: 0x00B55818 File Offset: 0x00B53A18
		public UniTask BeforeStartAsync(AActor rootActor)
		{
			HotKeyCombineComponent.<BeforeStartAsync>d__5 <BeforeStartAsync>d__;
			<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BeforeStartAsync>d__.<>4__this = this;
			<BeforeStartAsync>d__.rootActor = rootActor;
			<BeforeStartAsync>d__.<>1__state = -1;
			<BeforeStartAsync>d__.<>t__builder.Start<HotKeyCombineComponent.<BeforeStartAsync>d__5>(ref <BeforeStartAsync>d__);
			return <BeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030CDD RID: 199901 RVA: 0x00B55863 File Offset: 0x00B53A63
		public void SetConfig(HotKeyMap config)
		{
			this.Config = new HotKeyMap?(config);
		}

		// Token: 0x06030CDE RID: 199902 RVA: 0x00B55871 File Offset: 0x00B53A71
		public void SetIsNeedLongPress(bool value)
		{
			this.IsLongPress = value;
		}

		// Token: 0x06030CDF RID: 199903 RVA: 0x00B5587A File Offset: 0x00B53A7A
		public void SetNeedRefreshKeyName(bool value)
		{
			this.NeedRefreshKeyName = value;
		}

		// Token: 0x06030CE0 RID: 199904 RVA: 0x00B55884 File Offset: 0x00B53A84
		public void RefreshKeyIcon()
		{
			IReadOnlyList<string> keyNameList = this.GetKeyNameList();
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.RefreshKeyIcon((keyNameList.Count > 0) ? keyNameList[0] : null);
			}
			IconKeyComponent curComponent2 = this.CurComponent;
			if (curComponent2 != null)
			{
				curComponent2.SetActive(true);
			}
			this.RefreshDynamicKeyIconAsync(keyNameList).Forget();
		}

		// Token: 0x06030CE1 RID: 199905 RVA: 0x00B558DC File Offset: 0x00B53ADC
		public void RefreshKeyIconWithoutActive()
		{
			IReadOnlyList<string> keyNameList = this.GetKeyNameList();
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.RefreshKeyIcon(keyNameList.GetValueOrDefault(0, string.Empty));
			}
			this.RefreshDynamicKeyIconAsync(keyNameList).Forget();
		}

		// Token: 0x06030CE2 RID: 199906 RVA: 0x00B55919 File Offset: 0x00B53B19
		public void SetVisible(bool value)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.SetActive(value);
			}
			if (this.DynamicKeyComponent != null)
			{
				this.DynamicKeyComponent.SetActive(value);
			}
		}

		// Token: 0x06030CE3 RID: 199907 RVA: 0x00B55944 File Offset: 0x00B53B44
		public void RefreshNameText(string textId)
		{
			DynamicKeyComponent dynamicKeyComponent = this.DynamicKeyComponent;
			if (dynamicKeyComponent != null && dynamicKeyComponent.IsShowOrShowing)
			{
				DynamicKeyComponent dynamicKeyComponent2 = this.DynamicKeyComponent;
				if (dynamicKeyComponent2 != null)
				{
					dynamicKeyComponent2.RefreshNameText(textId);
				}
				IconKeyComponent curComponent = this.CurComponent;
				if (curComponent == null)
				{
					return;
				}
				curComponent.RefreshNameText("");
				return;
			}
			else
			{
				IconKeyComponent curComponent2 = this.CurComponent;
				if (curComponent2 == null)
				{
					return;
				}
				curComponent2.RefreshNameText(textId);
				return;
			}
		}

		// Token: 0x06030CE4 RID: 199908 RVA: 0x00B5599E File Offset: 0x00B53B9E
		public bool GetIsForceSetText()
		{
			IconKeyComponent curComponent = this.CurComponent;
			return curComponent != null && curComponent.GetIsForceSetText();
		}

		// Token: 0x06030CE5 RID: 199909 RVA: 0x00B559B1 File Offset: 0x00B53BB1
		public void RefreshPcAndGamepad()
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.RefreshPcAndGamepad();
			}
			if (this.DynamicKeyComponent != null)
			{
				this.DynamicKeyComponent.RefreshPcAndGamepad();
			}
		}

		// Token: 0x06030CE6 RID: 199910 RVA: 0x00B559D8 File Offset: 0x00B53BD8
		public void SetNameText(string keyText)
		{
			DynamicKeyComponent dynamicKeyComponent = this.DynamicKeyComponent;
			if (dynamicKeyComponent != null && dynamicKeyComponent.IsShowOrShowing)
			{
				DynamicKeyComponent dynamicKeyComponent2 = this.DynamicKeyComponent;
				if (dynamicKeyComponent2 != null)
				{
					dynamicKeyComponent2.SetNameText(keyText);
				}
				IconKeyComponent curComponent = this.CurComponent;
				if (curComponent == null)
				{
					return;
				}
				curComponent.SetNameText("");
				return;
			}
			else
			{
				IconKeyComponent curComponent2 = this.CurComponent;
				if (curComponent2 == null)
				{
					return;
				}
				curComponent2.SetNameText(keyText);
				return;
			}
		}

		// Token: 0x06030CE7 RID: 199911 RVA: 0x00B55A32 File Offset: 0x00B53C32
		public void SetNameTextForce(bool value)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetNameTextForce(value);
		}

		// Token: 0x06030CE8 RID: 199912 RVA: 0x00B55A45 File Offset: 0x00B53C45
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetHotKeyType(hotKeyType);
		}

		// Token: 0x06030CE9 RID: 199913 RVA: 0x00B55A58 File Offset: 0x00B53C58
		[NullableContext(2)]
		public AActor GetRootActor()
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return null;
			}
			return curComponent.GetRootActor();
		}

		// Token: 0x06030CEA RID: 199914 RVA: 0x00B55A6B File Offset: 0x00B53C6B
		public void SetLongPressState(float percent)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.SetLongPressState(percent);
			}
			if (this.DynamicKeyComponent != null)
			{
				this.DynamicKeyComponent.SetLongPressState(percent);
			}
		}

		// Token: 0x06030CEB RID: 199915 RVA: 0x00B55A93 File Offset: 0x00B53C93
		public void SetLongPressItemAlpha(float alpha)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.SetLongPressItemAlpha(alpha);
			}
			if (this.DynamicKeyComponent != null)
			{
				this.DynamicKeyComponent.SetLongPressItemAlpha(alpha);
			}
		}

		// Token: 0x06030CEC RID: 199916 RVA: 0x00B55ABB File Offset: 0x00B53CBB
		private IReadOnlyList<string> GetKeyNameList()
		{
			if (!this.NeedRefreshKeyName)
			{
				return new <>z__ReadOnlySingleElementList<string>("");
			}
			if (this.Config == null)
			{
				return new <>z__ReadOnlySingleElementList<string>("");
			}
			return UiNavigationUtil.GetKeyNameListByConfig(this.Config.Value);
		}

		// Token: 0x06030CED RID: 199917 RVA: 0x00B55AF8 File Offset: 0x00B53CF8
		private UniTask CreateCurComponent(string keyName, AActor rootActor)
		{
			HotKeyCombineComponent.<CreateCurComponent>d__22 <CreateCurComponent>d__;
			<CreateCurComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCurComponent>d__.<>4__this = this;
			<CreateCurComponent>d__.keyName = keyName;
			<CreateCurComponent>d__.rootActor = rootActor;
			<CreateCurComponent>d__.<>1__state = -1;
			<CreateCurComponent>d__.<>t__builder.Start<HotKeyCombineComponent.<CreateCurComponent>d__22>(ref <CreateCurComponent>d__);
			return <CreateCurComponent>d__.<>t__builder.Task;
		}

		// Token: 0x06030CEE RID: 199918 RVA: 0x00B55B4C File Offset: 0x00B53D4C
		private UniTask CreateDynamicComponent(string keyName)
		{
			HotKeyCombineComponent.<CreateDynamicComponent>d__23 <CreateDynamicComponent>d__;
			<CreateDynamicComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDynamicComponent>d__.<>4__this = this;
			<CreateDynamicComponent>d__.keyName = keyName;
			<CreateDynamicComponent>d__.<>1__state = -1;
			<CreateDynamicComponent>d__.<>t__builder.Start<HotKeyCombineComponent.<CreateDynamicComponent>d__23>(ref <CreateDynamicComponent>d__);
			return <CreateDynamicComponent>d__.<>t__builder.Task;
		}

		// Token: 0x06030CEF RID: 199919 RVA: 0x00B55B98 File Offset: 0x00B53D98
		private UniTask RefreshDynamicKeyIconAsync(IReadOnlyList<string> keyNameList)
		{
			HotKeyCombineComponent.<RefreshDynamicKeyIconAsync>d__24 <RefreshDynamicKeyIconAsync>d__;
			<RefreshDynamicKeyIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshDynamicKeyIconAsync>d__.<>4__this = this;
			<RefreshDynamicKeyIconAsync>d__.keyNameList = keyNameList;
			<RefreshDynamicKeyIconAsync>d__.<>1__state = -1;
			<RefreshDynamicKeyIconAsync>d__.<>t__builder.Start<HotKeyCombineComponent.<RefreshDynamicKeyIconAsync>d__24>(ref <RefreshDynamicKeyIconAsync>d__);
			return <RefreshDynamicKeyIconAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401A34D RID: 107341
		[Nullable(2)]
		protected IconKeyComponent CurComponent;

		// Token: 0x0401A34E RID: 107342
		[Nullable(2)]
		protected DynamicKeyComponent DynamicKeyComponent;

		// Token: 0x0401A34F RID: 107343
		protected bool IsLongPress;

		// Token: 0x0401A350 RID: 107344
		protected bool NeedRefreshKeyName = true;

		// Token: 0x0401A351 RID: 107345
		protected HotKeyMap? Config;
	}
}
