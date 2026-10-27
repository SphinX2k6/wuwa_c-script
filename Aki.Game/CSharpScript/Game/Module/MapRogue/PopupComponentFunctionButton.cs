using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200562E RID: 22062
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentFunctionButton : UiPanelBase
	{
		// Token: 0x060381D2 RID: 229842 RVA: 0x00D4AFE2 File Offset: 0x00D491E2
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x060381D3 RID: 229843 RVA: 0x00D4B008 File Offset: 0x00D49208
		protected override UniTask OnBeforeStartAsync()
		{
			PopupComponentFunctionButton.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PopupComponentFunctionButton.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060381D4 RID: 229844 RVA: 0x00D4B04C File Offset: 0x00D4924C
		public void SetButtonTextByTextId(string textId, params string[] args)
		{
			this.ButtonItem.SetLocalTextNew(textId, args);
		}

		// Token: 0x060381D5 RID: 229845 RVA: 0x00D4B068 File Offset: 0x00D49268
		public void SetButtonFunction(Action<int> buttonFunction)
		{
			this.ButtonItem.SetFunction(buttonFunction);
		}

		// Token: 0x060381D6 RID: 229846 RVA: 0x00D4B078 File Offset: 0x00D49278
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			ButtonItem buttonItem = this.ButtonItem;
			UUIItem uuiitem;
			if (buttonItem == null)
			{
				uuiitem = null;
			}
			else
			{
				UUIButtonComponent btn = buttonItem.GetBtn();
				uuiitem = ((btn != null) ? btn.RootUIComp.Get() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x0401D855 RID: 120917
		protected ButtonItem ButtonItem;
	}
}
