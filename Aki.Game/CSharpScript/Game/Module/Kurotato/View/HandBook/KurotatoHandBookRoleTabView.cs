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
	// Token: 0x0200473A RID: 18234
	public class KurotatoHandBookRoleTabView : UiTabViewBase
	{
		// Token: 0x0602DC67 RID: 187495 RVA: 0x00CCF07C File Offset: 0x00CCD27C
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

		// Token: 0x0602DC68 RID: 187496 RVA: 0x00CCF0C4 File Offset: 0x00CCD2C4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookRoleTabView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookRoleTabView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC69 RID: 187497 RVA: 0x00CCF107 File Offset: 0x00CCD307
		protected override void OnShowUiTabViewFromToggle()
		{
			UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
			if (tabBehavior != null)
			{
				tabBehavior.PlaySequence("Change");
			}
			this.KurotatoHandBookRolePanel.RefreshRoleList();
		}

		// Token: 0x0602DC6A RID: 187498 RVA: 0x00CCF12A File Offset: 0x00CCD32A
		protected override void OnShowUiTabViewFromView()
		{
			this.KurotatoHandBookRolePanel.RefreshRoleList();
		}

		// Token: 0x0602DC6B RID: 187499 RVA: 0x00CCF137 File Offset: 0x00CCD337
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			KurotatoActivityController.Instance.GetActivityData().ReadRoleRedDot();
		}

		// Token: 0x04018790 RID: 100240
		[Nullable(1)]
		private readonly KurotatoHandBookRolePanel KurotatoHandBookRolePanel = new KurotatoHandBookRolePanel();

		// Token: 0x0200A379 RID: 41849
		private enum EHandBookRoleTabViewComponent
		{
			// Token: 0x04032AE0 RID: 207584
			ItemRoleViewPanel
		}
	}
}
