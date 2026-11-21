using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200385E RID: 14430
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyCombineComponent
	{
		// Token: 0x06025809 RID: 153609 RVA: 0x00A90688 File Offset: 0x00A8E888
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

		// Token: 0x0602580A RID: 153610 RVA: 0x00A906D3 File Offset: 0x00A8E8D3
		public void SetConfig(HotKeyMap config)
		{
			this.Config = new HotKeyMap?(config);
		}

		// Token: 0x0602580B RID: 153611 RVA: 0x00A906E1 File Offset: 0x00A8E8E1
		public void SetIsNeedLongPress(bool value)
		{
			this.IsLongPress = value;
		}

		// Token: 0x0602580C RID: 153612 RVA: 0x00A906EA File Offset: 0x00A8E8EA
		public void SetNeedRefreshKeyName(bool value)
		{
			this.NeedRefreshKeyName = value;
		}

		// Token: 0x0602580D RID: 153613 RVA: 0x00A906F4 File Offset: 0x00A8E8F4
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

		// Token: 0x0602580E RID: 153614 RVA: 0x00A9074C File Offset: 0x00A8E94C
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

		// Token: 0x0602580F RID: 153615 RVA: 0x00A90789 File Offset: 0x00A8E989
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

		// Token: 0x06025810 RID: 153616 RVA: 0x00A907B4 File Offset: 0x00A8E9B4
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

		// Token: 0x06025811 RID: 153617 RVA: 0x00A9080E File Offset: 0x00A8EA0E
		public bool GetIsForceSetText()
		{
			IconKeyComponent curComponent = this.CurComponent;
			return curComponent != null && curComponent.GetIsForceSetText();
		}

		// Token: 0x06025812 RID: 153618 RVA: 0x00A90821 File Offset: 0x00A8EA21
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

		// Token: 0x06025813 RID: 153619 RVA: 0x00A90848 File Offset: 0x00A8EA48
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

		// Token: 0x06025814 RID: 153620 RVA: 0x00A908A2 File Offset: 0x00A8EAA2
		public void SetNameTextForce(bool value)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetNameTextForce(value);
		}

		// Token: 0x06025815 RID: 153621 RVA: 0x00A908B5 File Offset: 0x00A8EAB5
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			IconKeyComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetHotKeyType(hotKeyType);
		}

		// Token: 0x06025816 RID: 153622 RVA: 0x00A908C8 File Offset: 0x00A8EAC8
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

		// Token: 0x06025817 RID: 153623 RVA: 0x00A908DB File Offset: 0x00A8EADB
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

		// Token: 0x06025818 RID: 153624 RVA: 0x00A90903 File Offset: 0x00A8EB03
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

		// Token: 0x06025819 RID: 153625 RVA: 0x00A9092B File Offset: 0x00A8EB2B
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

		// Token: 0x0602581A RID: 153626 RVA: 0x00A90968 File Offset: 0x00A8EB68
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

		// Token: 0x0602581B RID: 153627 RVA: 0x00A909BC File Offset: 0x00A8EBBC
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

		// Token: 0x0602581C RID: 153628 RVA: 0x00A90A08 File Offset: 0x00A8EC08
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

		// Token: 0x04014BC0 RID: 84928
		[Nullable(2)]
		protected IconKeyComponent CurComponent;

		// Token: 0x04014BC1 RID: 84929
		[Nullable(2)]
		protected DynamicKeyComponent DynamicKeyComponent;

		// Token: 0x04014BC2 RID: 84930
		protected bool IsLongPress;

		// Token: 0x04014BC3 RID: 84931
		protected bool NeedRefreshKeyName = true;

		// Token: 0x04014BC4 RID: 84932
		protected HotKeyMap? Config;
	}
}
