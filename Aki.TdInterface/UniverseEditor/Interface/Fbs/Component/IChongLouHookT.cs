using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D0 RID: 21712
	public class IChongLouHookT
	{
		// Token: 0x17009B10 RID: 39696
		// (get) Token: 0x06022437 RID: 140343 RVA: 0x004B94B6 File Offset: 0x004B76B6
		// (set) Token: 0x06022438 RID: 140344 RVA: 0x004B94BE File Offset: 0x004B76BE
		public EHookInteractType Type { get; set; }

		// Token: 0x17009B11 RID: 39697
		// (get) Token: 0x06022439 RID: 140345 RVA: 0x004B94C7 File Offset: 0x004B76C7
		// (set) Token: 0x0602243A RID: 140346 RVA: 0x004B94CF File Offset: 0x004B76CF
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009B12 RID: 39698
		// (get) Token: 0x0602243B RID: 140347 RVA: 0x004B94D8 File Offset: 0x004B76D8
		// (set) Token: 0x0602243C RID: 140348 RVA: 0x004B94E0 File Offset: 0x004B76E0
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009B13 RID: 39699
		// (get) Token: 0x0602243D RID: 140349 RVA: 0x004B94E9 File Offset: 0x004B76E9
		// (set) Token: 0x0602243E RID: 140350 RVA: 0x004B94F1 File Offset: 0x004B76F1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009B14 RID: 39700
		// (get) Token: 0x0602243F RID: 140351 RVA: 0x004B94FA File Offset: 0x004B76FA
		// (set) Token: 0x06022440 RID: 140352 RVA: 0x004B9502 File Offset: 0x004B7702
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009B15 RID: 39701
		// (get) Token: 0x06022441 RID: 140353 RVA: 0x004B950B File Offset: 0x004B770B
		// (set) Token: 0x06022442 RID: 140354 RVA: 0x004B9513 File Offset: 0x004B7713
		public float HookMoveSpeed { get; set; }

		// Token: 0x17009B16 RID: 39702
		// (get) Token: 0x06022443 RID: 140355 RVA: 0x004B951C File Offset: 0x004B771C
		// (set) Token: 0x06022444 RID: 140356 RVA: 0x004B9524 File Offset: 0x004B7724
		public float Acceleration { get; set; }

		// Token: 0x17009B17 RID: 39703
		// (get) Token: 0x06022445 RID: 140357 RVA: 0x004B952D File Offset: 0x004B772D
		// (set) Token: 0x06022446 RID: 140358 RVA: 0x004B9535 File Offset: 0x004B7735
		public float LateralMoveSpeed { get; set; }

		// Token: 0x17009B18 RID: 39704
		// (get) Token: 0x06022447 RID: 140359 RVA: 0x004B953E File Offset: 0x004B773E
		// (set) Token: 0x06022448 RID: 140360 RVA: 0x004B9546 File Offset: 0x004B7746
		public float LateralAccelerateTime { get; set; }

		// Token: 0x17009B19 RID: 39705
		// (get) Token: 0x06022449 RID: 140361 RVA: 0x004B954F File Offset: 0x004B774F
		// (set) Token: 0x0602244A RID: 140362 RVA: 0x004B9557 File Offset: 0x004B7757
		public float LateralDecelerateTime { get; set; }

		// Token: 0x17009B1A RID: 39706
		// (get) Token: 0x0602244B RID: 140363 RVA: 0x004B9560 File Offset: 0x004B7760
		// (set) Token: 0x0602244C RID: 140364 RVA: 0x004B9568 File Offset: 0x004B7768
		public float MaxLateralOffset { get; set; }

		// Token: 0x17009B1B RID: 39707
		// (get) Token: 0x0602244D RID: 140365 RVA: 0x004B9571 File Offset: 0x004B7771
		// (set) Token: 0x0602244E RID: 140366 RVA: 0x004B9579 File Offset: 0x004B7779
		public float VerticalMoveSpeed { get; set; }

		// Token: 0x17009B1C RID: 39708
		// (get) Token: 0x0602244F RID: 140367 RVA: 0x004B9582 File Offset: 0x004B7782
		// (set) Token: 0x06022450 RID: 140368 RVA: 0x004B958A File Offset: 0x004B778A
		public float VerticalAccelerateTime { get; set; }

		// Token: 0x17009B1D RID: 39709
		// (get) Token: 0x06022451 RID: 140369 RVA: 0x004B9593 File Offset: 0x004B7793
		// (set) Token: 0x06022452 RID: 140370 RVA: 0x004B959B File Offset: 0x004B779B
		public float VerticalDecelerateTime { get; set; }

		// Token: 0x17009B1E RID: 39710
		// (get) Token: 0x06022453 RID: 140371 RVA: 0x004B95A4 File Offset: 0x004B77A4
		// (set) Token: 0x06022454 RID: 140372 RVA: 0x004B95AC File Offset: 0x004B77AC
		public ushort NullMask { get; set; }

		// Token: 0x06022455 RID: 140373 RVA: 0x004B95B8 File Offset: 0x004B77B8
		public IChongLouHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookMoveSpeed = 0f;
			this.Acceleration = 0f;
			this.LateralMoveSpeed = 0f;
			this.LateralAccelerateTime = 0f;
			this.LateralDecelerateTime = 0f;
			this.MaxLateralOffset = 0f;
			this.VerticalMoveSpeed = 0f;
			this.VerticalAccelerateTime = 0f;
			this.VerticalDecelerateTime = 0f;
			this.NullMask = 0;
		}
	}
}
