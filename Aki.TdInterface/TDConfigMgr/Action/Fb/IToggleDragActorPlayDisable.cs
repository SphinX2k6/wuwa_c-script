using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A7C RID: 10876
	public class IToggleDragActorPlayDisable : IToggleDragActorPlayType
	{
		// Token: 0x0600F00D RID: 61453 RVA: 0x00232D1F File Offset: 0x00230F1F
		public static IToggleDragActorPlayDisable Create(IToggleDragActorPlayDisable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleDragActorPlayDisable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x0600F00E RID: 61454 RVA: 0x00232D3E File Offset: 0x00230F3E
		public override EToggleDragActorPlayType Type
		{
			get
			{
				return (EToggleDragActorPlayType)this.Instance.Type;
			}
		}

		// Token: 0x040083FE RID: 33790
		private IToggleDragActorPlayDisable Instance;
	}
}
