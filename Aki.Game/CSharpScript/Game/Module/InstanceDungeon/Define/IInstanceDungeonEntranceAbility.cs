using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058BF RID: 22719
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class IInstanceDungeonEntranceAbility : UiPanelBase
	{
		// Token: 0x17008AA5 RID: 35493
		// (get) Token: 0x06039C30 RID: 236592
		public abstract string ResourceId { get; }

		// Token: 0x06039C31 RID: 236593
		public abstract UniTask RefreshExternalAsync();

		// Token: 0x06039C32 RID: 236594 RVA: 0x00DBA1EB File Offset: 0x00DB83EB
		public virtual void RefreshOnTick()
		{
		}
	}
}
