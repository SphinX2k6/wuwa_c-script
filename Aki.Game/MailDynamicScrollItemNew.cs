using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021D8 RID: 8664
[NullableContext(1)]
[Nullable(0)]
public class MailDynamicScrollItemNew : UiPanelBase, IDynamicScrollBaseItem<MailData>
{
	// Token: 0x06010DDB RID: 69083 RVA: 0x0041A614 File Offset: 0x00418814
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

	// Token: 0x06010DDC RID: 69084 RVA: 0x0041A660 File Offset: 0x00418860
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

	// Token: 0x06010DDD RID: 69085 RVA: 0x0041A6AC File Offset: 0x004188AC
	public void ClearItem()
	{
	}

	// Token: 0x0400801D RID: 32797
	[Nullable(2)]
	private Vector2D ItemSizeVector;
}
