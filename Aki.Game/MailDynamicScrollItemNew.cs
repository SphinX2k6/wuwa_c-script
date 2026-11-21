using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020016BC RID: 5820
[NullableContext(1)]
[Nullable(0)]
public class MailDynamicScrollItemNew : UiPanelBase, IDynamicScrollBaseItem<MailData>
{
	// Token: 0x0600E26C RID: 57964 RVA: 0x00426EF4 File Offset: 0x004250F4
	public UniTask Init(UUIItem actor)
	{
		MailDynamicScrollItemNew.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<MailDynamicScrollItemNew.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600E26D RID: 57965 RVA: 0x00426F40 File Offset: 0x00425140
	public FVector2D GetItemSize(MailData data)
	{
		if (this.ItemSizeVector == null)
		{
			this.ItemSizeVector = Vector2D.Create();
		}
		UUIItem rootItem = base.GetRootItem();
		this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
		return this.ItemSizeVector.ToUeVector2D(false);
	}

	// Token: 0x0600E26E RID: 57966 RVA: 0x00426F8C File Offset: 0x0042518C
	public void ClearItem()
	{
	}

	// Token: 0x04008164 RID: 33124
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
