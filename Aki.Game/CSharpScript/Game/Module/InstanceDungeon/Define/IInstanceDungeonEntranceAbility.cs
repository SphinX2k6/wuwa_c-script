using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x02004897 RID: 18583
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class IInstanceDungeonEntranceAbility : UiPanelBase
	{
		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x0602EB53 RID: 191315
		public abstract string ResourceId { get; }

		// Token: 0x0602EB54 RID: 191316
		public abstract UniTask RefreshExternalAsync();

		// Token: 0x0602EB55 RID: 191317 RVA: 0x00D09103 File Offset: 0x00D07303
		public virtual void RefreshOnTick()
		{
		}
	}
}
