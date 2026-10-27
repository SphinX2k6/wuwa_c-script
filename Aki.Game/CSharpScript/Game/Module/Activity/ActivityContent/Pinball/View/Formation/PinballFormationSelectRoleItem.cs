using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x02006361 RID: 25441
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballFormationSelectRoleItem : PinballItemGridView<IPinballItemDataRole>
	{
		// Token: 0x06040021 RID: 262177 RVA: 0x00F7C420 File Offset: 0x00F7A620
		[NullableContext(2)]
		public UUIItem GetRoleItemToggleRootUiItem()
		{
			UUIExtendToggle itemToggle = base.GetItemToggle();
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (itemToggle != null) ? new TWeakObjectPtr<UUIItem>?(itemToggle.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			return tweakObjectPtr.GetValueOrDefault();
		}

		// Token: 0x06040022 RID: 262178 RVA: 0x00F7C464 File Offset: 0x00F7A664
		public override UniTask RefreshAsync(IPinballItemDataRole data, bool isSelected, int gridIndex)
		{
			PinballFormationSelectRoleItem.<RefreshAsync>d__1 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<PinballFormationSelectRoleItem.<RefreshAsync>d__1>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040023 RID: 262179 RVA: 0x00F7C4AF File Offset: 0x00F7A6AF
		public override void Refresh(IPinballItemDataRole data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}
	}
}
