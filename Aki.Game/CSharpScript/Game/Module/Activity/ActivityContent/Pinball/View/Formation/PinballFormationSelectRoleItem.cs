using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052DF RID: 21215
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballFormationSelectRoleItem : PinballItemGridView<IPinballItemDataRole>
	{
		// Token: 0x06034CE2 RID: 216290 RVA: 0x00EC3380 File Offset: 0x00EC1580
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

		// Token: 0x06034CE3 RID: 216291 RVA: 0x00EC33C4 File Offset: 0x00EC15C4
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

		// Token: 0x06034CE4 RID: 216292 RVA: 0x00EC340F File Offset: 0x00EC160F
		public override void Refresh(IPinballItemDataRole data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}
	}
}
