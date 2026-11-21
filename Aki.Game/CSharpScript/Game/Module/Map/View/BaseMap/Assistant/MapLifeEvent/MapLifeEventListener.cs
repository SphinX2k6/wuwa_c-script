using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent
{
	// Token: 0x02004485 RID: 17541
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapLifeEventListener
	{
		// Token: 0x0602C525 RID: 181541 RVA: 0x00C76D82 File Offset: 0x00C74F82
		protected MapLifeEventListener(BaseMap map)
		{
			this.TargetExpressionMap = map;
		}

		// Token: 0x0602C526 RID: 181542 RVA: 0x00C76D91 File Offset: 0x00C74F91
		public virtual UniTask OnWorldMapBeforeStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0602C527 RID: 181543 RVA: 0x00C76D98 File Offset: 0x00C74F98
		public virtual void OnWorldMapBeforeShow()
		{
		}

		// Token: 0x0602C528 RID: 181544 RVA: 0x00C76D9A File Offset: 0x00C74F9A
		public virtual void OnWorldMapAfterShow()
		{
		}

		// Token: 0x04017D4D RID: 97613
		protected readonly BaseMap TargetExpressionMap;
	}
}
