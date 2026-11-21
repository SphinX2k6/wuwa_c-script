using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Login
{
	// Token: 0x0200468B RID: 18059
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerDynItem : UiPanelBase, IDynamicScrollBaseItem<ILoginServersData>
	{
		// Token: 0x0602D662 RID: 185954 RVA: 0x00CB5D3C File Offset: 0x00CB3F3C
		public UniTask Init(UUIItem actor)
		{
			LoginServerDynItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<LoginServerDynItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602D663 RID: 185955 RVA: 0x00CB5D88 File Offset: 0x00CB3F88
		public FVector2D GetItemSize(ILoginServersData data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(true);
		}

		// Token: 0x0602D664 RID: 185956 RVA: 0x00CB5DD4 File Offset: 0x00CB3FD4
		public AUIBaseActor GetUsingItem()
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602D665 RID: 185957 RVA: 0x00CB5DE6 File Offset: 0x00CB3FE6
		public void ClearItem()
		{
		}

		// Token: 0x040184FC RID: 99580
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
