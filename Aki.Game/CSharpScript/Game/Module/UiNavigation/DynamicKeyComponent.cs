using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D5 RID: 14549
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicKeyComponent : UiPanelBase
	{
		// Token: 0x06025B41 RID: 154433 RVA: 0x00A9BEBE File Offset: 0x00A9A0BE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06025B42 RID: 154434 RVA: 0x00A9BEF8 File Offset: 0x00A9A0F8
		protected override UniTask OnBeforeStartAsync()
		{
			DynamicKeyComponent.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DynamicKeyComponent.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025B43 RID: 154435 RVA: 0x00A9BF3B File Offset: 0x00A9A13B
		public void SetKeyName(string keyName)
		{
			this.KeyName = keyName;
		}

		// Token: 0x06025B44 RID: 154436 RVA: 0x00A9BF44 File Offset: 0x00A9A144
		public void SetIsNeedLongPress(bool isLongPress)
		{
			this.IsLongPress = isLongPress;
		}

		// Token: 0x06025B45 RID: 154437 RVA: 0x00A9BF4D File Offset: 0x00A9A14D
		public void RefreshKeyIcon(string keyName)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshKeyIcon(keyName);
		}

		// Token: 0x06025B46 RID: 154438 RVA: 0x00A9BF60 File Offset: 0x00A9A160
		public void RefreshNameText(string textId)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshNameText(textId);
		}

		// Token: 0x06025B47 RID: 154439 RVA: 0x00A9BF73 File Offset: 0x00A9A173
		public void RefreshPcAndGamepad()
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.RefreshPcAndGamepad();
		}

		// Token: 0x06025B48 RID: 154440 RVA: 0x00A9BF85 File Offset: 0x00A9A185
		public void SetNameText(string keyText)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetNameText(keyText);
		}

		// Token: 0x06025B49 RID: 154441 RVA: 0x00A9BF98 File Offset: 0x00A9A198
		public void SetLongPressState(float percent)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetLongPressState(percent);
		}

		// Token: 0x06025B4A RID: 154442 RVA: 0x00A9BFAB File Offset: 0x00A9A1AB
		public void SetLongPressItemAlpha(float alpha)
		{
			KeyBaseComponent curComponent = this.CurComponent;
			if (curComponent == null)
			{
				return;
			}
			curComponent.SetLongPressItemAlpha(alpha);
		}

		// Token: 0x04014CF9 RID: 85241
		private string KeyName = "";

		// Token: 0x04014CFA RID: 85242
		private bool IsLongPress;

		// Token: 0x04014CFB RID: 85243
		[Nullable(2)]
		protected KeyBaseComponent CurComponent;

		// Token: 0x020095BD RID: 38333
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EC84 RID: 191620
			public const int Text = 0;

			// Token: 0x0402EC85 RID: 191621
			public const int KeyItem = 1;
		}
	}
}
