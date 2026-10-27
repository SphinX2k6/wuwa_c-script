using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006685 RID: 26245
	[NullableContext(1)]
	public interface IDropItemInstance
	{
		// Token: 0x06041C2A RID: 269354
		UniTask OnInit(IDropCatchDropItemParams @params);

		// Token: 0x06041C2B RID: 269355
		void OnTick(float deltaTime);

		// Token: 0x06041C2C RID: 269356
		IDropCatchBounds GetItemBounds();

		// Token: 0x06041C2D RID: 269357
		void OnCollision(IRoleInstance role);

		// Token: 0x06041C2E RID: 269358
		int GetInstanceId();

		// Token: 0x06041C2F RID: 269359
		int GetItemId();

		// Token: 0x06041C30 RID: 269360
		void OnRecycle();

		// Token: 0x06041C31 RID: 269361
		void Destroy();
	}
}
