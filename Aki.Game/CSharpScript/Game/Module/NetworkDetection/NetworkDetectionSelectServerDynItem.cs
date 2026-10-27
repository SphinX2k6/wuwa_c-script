using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02005362 RID: 21346
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerDynItem : UiPanelBase, IDynamicScrollBaseItem<ILoginServersData>
	{
		// Token: 0x06036884 RID: 223364 RVA: 0x00CE96B4 File Offset: 0x00CE78B4
		public UniTask Init(UUIItem actor)
		{
			NetworkDetectionSelectServerDynItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<NetworkDetectionSelectServerDynItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06036885 RID: 223365 RVA: 0x00CE9700 File Offset: 0x00CE7900
		public FVector2D GetItemSize(ILoginServersData data)
		{
			if (this.ItemSizeVector == null)
			{
				this.ItemSizeVector = Vector2D.Create();
			}
			UUIItem rootItem = base.GetRootItem();
			this.ItemSizeVector.Set((double)rootItem.GetWidth(), (double)rootItem.GetHeight());
			return this.ItemSizeVector.ToUeVector2D(false);
		}

		// Token: 0x06036886 RID: 223366 RVA: 0x00CE974C File Offset: 0x00CE794C
		public AUIBaseActor GetUsingItem()
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x06036887 RID: 223367 RVA: 0x00CE975E File Offset: 0x00CE795E
		public void ClearItem()
		{
		}

		// Token: 0x0401CD5D RID: 118109
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
