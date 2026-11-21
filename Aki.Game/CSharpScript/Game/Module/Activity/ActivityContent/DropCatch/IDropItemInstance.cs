using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055D5 RID: 21973
	[NullableContext(1)]
	public interface IDropItemInstance
	{
		// Token: 0x06036776 RID: 223094
		UniTask OnInit(IDropCatchDropItemParams @params);

		// Token: 0x06036777 RID: 223095
		void OnTick(float deltaTime);

		// Token: 0x06036778 RID: 223096
		IDropCatchBounds GetItemBounds();

		// Token: 0x06036779 RID: 223097
		void OnCollision(IRoleInstance role);

		// Token: 0x0603677A RID: 223098
		int GetInstanceId();

		// Token: 0x0603677B RID: 223099
		int GetItemId();

		// Token: 0x0603677C RID: 223100
		void OnRecycle();

		// Token: 0x0603677D RID: 223101
		void Destroy();
	}
}
