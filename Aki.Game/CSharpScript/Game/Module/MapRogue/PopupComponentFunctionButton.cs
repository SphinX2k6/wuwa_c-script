using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004604 RID: 17924
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupComponentFunctionButton : UiPanelBase
	{
		// Token: 0x0602D0D0 RID: 184528 RVA: 0x00C98D2A File Offset: 0x00C96F2A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x0602D0D1 RID: 184529 RVA: 0x00C98D50 File Offset: 0x00C96F50
		protected override UniTask OnBeforeStartAsync()
		{
			PopupComponentFunctionButton.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PopupComponentFunctionButton.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D0D2 RID: 184530 RVA: 0x00C98D94 File Offset: 0x00C96F94
		public void SetButtonTextByTextId(string textId, params string[] args)
		{
			this.ButtonItem.SetLocalTextNew(textId, args);
		}

		// Token: 0x0602D0D3 RID: 184531 RVA: 0x00C98DB0 File Offset: 0x00C96FB0
		public void SetButtonFunction(Action<int> buttonFunction)
		{
			this.ButtonItem.SetFunction(buttonFunction);
		}

		// Token: 0x0602D0D4 RID: 184532 RVA: 0x00C98DC0 File Offset: 0x00C96FC0
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

		// Token: 0x040182E0 RID: 99040
		protected ButtonItem ButtonItem;
	}
}
