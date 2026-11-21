using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x020057C9 RID: 22473
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlInteractionModeCtrl
	{
		// Token: 0x17006AE6 RID: 27366
		// (get) Token: 0x060377CE RID: 227278 RVA: 0x00F8254D File Offset: 0x00F8074D
		public NormalInteractionMode Normal { get; }

		// Token: 0x17006AE7 RID: 27367
		// (get) Token: 0x060377CF RID: 227279 RVA: 0x00F82555 File Offset: 0x00F80755
		public LayerInteractionMode Layer { get; }

		// Token: 0x17006AE8 RID: 27368
		// (get) Token: 0x060377D0 RID: 227280 RVA: 0x00F82560 File Offset: 0x00F80760
		public IInteractionMode Current
		{
			get
			{
				if (!this.Layer.IsActive)
				{
					return this.Normal;
				}
				return this.Layer;
			}
		}

		// Token: 0x060377D1 RID: 227281 RVA: 0x00F8258B File Offset: 0x00F8078B
		public DangoBrawlInteractionModeCtrl(ActivityDangoBrawlData data, DropResolver resolver, InteractionStateMachine fsm)
		{
			this.Normal = new NormalInteractionMode(data);
			this.Layer = new LayerInteractionMode(data, fsm, resolver);
		}
	}
}
