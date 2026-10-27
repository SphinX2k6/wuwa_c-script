using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x02006879 RID: 26745
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlInteractionModeCtrl
	{
		// Token: 0x170097A5 RID: 38821
		// (get) Token: 0x06042C77 RID: 273527 RVA: 0x0104106D File Offset: 0x0103F26D
		public NormalInteractionMode Normal { get; }

		// Token: 0x170097A6 RID: 38822
		// (get) Token: 0x06042C78 RID: 273528 RVA: 0x01041075 File Offset: 0x0103F275
		public LayerInteractionMode Layer { get; }

		// Token: 0x170097A7 RID: 38823
		// (get) Token: 0x06042C79 RID: 273529 RVA: 0x01041080 File Offset: 0x0103F280
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

		// Token: 0x06042C7A RID: 273530 RVA: 0x010410AB File Offset: 0x0103F2AB
		public DangoBrawlInteractionModeCtrl(ActivityDangoBrawlData data, DropResolver resolver, InteractionStateMachine fsm)
		{
			this.Normal = new NormalInteractionMode(data);
			this.Layer = new LayerInteractionMode(data, fsm, resolver);
		}
	}
}
