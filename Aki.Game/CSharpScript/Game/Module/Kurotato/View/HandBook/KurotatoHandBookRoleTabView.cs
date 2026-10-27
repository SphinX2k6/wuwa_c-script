using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x02005763 RID: 22371
	public class KurotatoHandBookRoleTabView : UiTabViewBase
	{
		// Token: 0x06038D57 RID: 232791 RVA: 0x00D805D4 File Offset: 0x00D7E7D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D58 RID: 232792 RVA: 0x00D8061C File Offset: 0x00D7E81C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookRoleTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookRoleTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D59 RID: 232793 RVA: 0x00D8065F File Offset: 0x00D7E85F
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Change");
			}
			this.KurotatoHandBookRolePanel.RefreshRoleList();
		}

		// Token: 0x06038D5A RID: 232794 RVA: 0x00D80682 File Offset: 0x00D7E882
		protected override void OnShowUiTabViewFromView()
		{
			this.KurotatoHandBookRolePanel.RefreshRoleList();
		}

		// Token: 0x06038D5B RID: 232795 RVA: 0x00D8068F File Offset: 0x00D7E88F
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			KurotatoActivityController.Instance.GetActivityData().ReadRoleRedDot();
		}

		// Token: 0x0401DCFA RID: 122106
		[Nullable(1)]
		private readonly KurotatoHandBookRolePanel KurotatoHandBookRolePanel = new KurotatoHandBookRolePanel();

		// Token: 0x0200B95D RID: 47453
		private enum EHandBookRoleTabViewComponent
		{
			// Token: 0x040380DE RID: 229598
			ItemRoleViewPanel
		}
	}
}
