using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200495D RID: 18781
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicKeyComponent : UiPanelBase
	{
		// Token: 0x06031011 RID: 200721 RVA: 0x00B60FDE File Offset: 0x00B5F1DE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06031012 RID: 200722 RVA: 0x00B61018 File Offset: 0x00B5F218
		protected override UniTask OnBeforeStartAsync()
		{
			DynamicKeyComponent.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DynamicKeyComponent.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031013 RID: 200723 RVA: 0x00B6105B File Offset: 0x00B5F25B
		public void SetKeyName(string keyName)
		{
			this.KeyName = keyName;
		}

		// Token: 0x06031014 RID: 200724 RVA: 0x00B61064 File Offset: 0x00B5F264
		public void SetIsNeedLongPress(bool isLongPress)
		{
			this.IsLongPress = isLongPress;
		}

		// Token: 0x06031015 RID: 200725 RVA: 0x00B6106D File Offset: 0x00B5F26D
		public void RefreshKeyIcon(string keyName)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshKeyIcon(keyName);
		}

		// Token: 0x06031016 RID: 200726 RVA: 0x00B61080 File Offset: 0x00B5F280
		public void RefreshNameText(string textId)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshNameText(textId);
		}

		// Token: 0x06031017 RID: 200727 RVA: 0x00B61093 File Offset: 0x00B5F293
		public void RefreshPcAndGamepad()
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshPcAndGamepad();
		}

		// Token: 0x06031018 RID: 200728 RVA: 0x00B610A5 File Offset: 0x00B5F2A5
		public void SetNameText(string keyText)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetNameText(keyText);
		}

		// Token: 0x06031019 RID: 200729 RVA: 0x00B610B8 File Offset: 0x00B5F2B8
		public void SetLongPressState(float percent)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetLongPressState(percent);
		}

		// Token: 0x0603101A RID: 200730 RVA: 0x00B610CB File Offset: 0x00B5F2CB
		public void SetLongPressItemAlpha(float alpha)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetLongPressItemAlpha(alpha);
		}

		// Token: 0x0401A486 RID: 107654
		private string KeyName = "";

		// Token: 0x0401A487 RID: 107655
		private bool IsLongPress;

		// Token: 0x0401A488 RID: 107656
		[Nullable(2)]
		protected KeyBaseComponent CurComponent;

		// Token: 0x0200ABAE RID: 43950
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034301 RID: 213761
			public const int Text = 0;

			// Token: 0x04034302 RID: 213762
			public const int KeyItem = 1;
		}
	}
}
