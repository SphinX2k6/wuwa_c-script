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
	// Token: 0x02004345 RID: 17221
	[NullableContext(1)]
	[Nullable(0)]
	public class NetworkDetectionSelectServerDynItem : UiPanelBase, IDynamicScrollBaseItem<ILoginServersData>
	{
		// Token: 0x0602B7CA RID: 178122 RVA: 0x00C3853C File Offset: 0x00C3673C
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

		// Token: 0x0602B7CB RID: 178123 RVA: 0x00C38588 File Offset: 0x00C36788
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

		// Token: 0x0602B7CC RID: 178124 RVA: 0x00C385D4 File Offset: 0x00C367D4
		public AUIBaseActor GetUsingItem()
		{
			return base.GetRootItem().GetOwner() as AUIBaseActor;
		}

		// Token: 0x0602B7CD RID: 178125 RVA: 0x00C385E6 File Offset: 0x00C367E6
		public void ClearItem()
		{
		}

		// Token: 0x040177F1 RID: 96241
		[Nullable(2)]
		private Vector2D ItemSizeVector;
	}
}
