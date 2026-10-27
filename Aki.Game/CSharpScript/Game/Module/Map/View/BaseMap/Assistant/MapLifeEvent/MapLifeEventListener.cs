using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x020054A2 RID: 21666
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapLifeEventListener
	{
		// Token: 0x060375D1 RID: 226769 RVA: 0x00D2712E File Offset: 0x00D2532E
		protected MapLifeEventListener(BaseMap map)
		{
			this.TargetExpressionMap = map;
		}

		// Token: 0x060375D2 RID: 226770 RVA: 0x00D2713D File Offset: 0x00D2533D
		public virtual UniTask OnWorldMapBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060375D3 RID: 226771 RVA: 0x00D27144 File Offset: 0x00D25344
		public virtual void OnWorldMapBeforeShow()
		{
		}

		// Token: 0x060375D4 RID: 226772 RVA: 0x00D27146 File Offset: 0x00D25346
		public virtual void OnWorldMapAfterShow()
		{
		}

		// Token: 0x0401D2B1 RID: 119473
		protected readonly BaseMap TargetExpressionMap;
	}
}
