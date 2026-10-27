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
	// Token: 0x020056B5 RID: 22197
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginServerDynItem : UiPanelBase, IDynamicScrollBaseItem<ILoginServersData>
	{
		// Token: 0x06038765 RID: 231269 RVA: 0x00D67B78 File Offset: 0x00D65D78
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

		// Token: 0x06038766 RID: 231270 RVA: 0x00D67BC4 File Offset: 0x00D65DC4
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

		// Token: 0x06038767 RID: 231271 RVA: 0x00D67C10 File Offset: 0x00D65E10
		public AUIBaseActor GetUsingItem()
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06038768 RID: 231272 RVA: 0x00D67C22 File Offset: 0x00D65E22
		public void ClearItem()
		{
		}

		// Token: 0x0401DA71 RID: 121457
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
