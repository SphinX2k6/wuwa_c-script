using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform
{
	// Token: 0x020057BE RID: 22462
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPlatformAdapterRegistry
	{
		// Token: 0x0603777D RID: 227197 RVA: 0x00F80FCC File Offset: 0x00F7F1CC
		public DangoBrawlPlatformAdapterRegistry(InteractionStateMachine fsm, DangoBrawlPlatformState platformState, DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl sticky)
		{
			this.PlatformState = platformState;
			this.Adapters[EInputPlatform.Mobile] = new DangoBrawlMobileAdapter(dragCtrl);
			this.Adapters[EInputPlatform.Pc] = new DangoBrawlPcAdapter(dragCtrl, sticky, fsm);
			this.Adapters[EInputPlatform.Gamepad] = new DangoBrawlGamepadAdapter(dragCtrl, sticky, fsm);
		}

		// Token: 0x17006AD6 RID: 27350
		// (get) Token: 0x0603777E RID: 227198 RVA: 0x00F81030 File Offset: 0x00F7F230
		public IDangobrawlInputAdapter Current
		{
			get
			{
				IDangobrawlInputAdapter result;
				if (!this.Adapters.TryGetValue(this.PlatformState.Current, out result))
				{
					return this.Adapters[EInputPlatform.Mobile];
				}
				return result;
			}
		}

		// Token: 0x0603777F RID: 227199 RVA: 0x00F81065 File Offset: 0x00F7F265
		public void Start()
		{
			this.SwitchTo(this.Current);
		}

		// Token: 0x06037780 RID: 227200 RVA: 0x00F81073 File Offset: 0x00F7F273
		public void Stop()
		{
			IDangobrawlInputAdapter startedAdapter = this.StartedAdapter;
			if (startedAdapter != null)
			{
				startedAdapter.Stop();
			}
			this.StartedAdapter = null;
		}

		// Token: 0x06037781 RID: 227201 RVA: 0x00F8108D File Offset: 0x00F7F28D
		public void UpdatePlatform()
		{
			this.SwitchTo(this.Current);
		}

		// Token: 0x06037782 RID: 227202 RVA: 0x00F8109B File Offset: 0x00F7F29B
		private void SwitchTo(IDangobrawlInputAdapter target)
		{
			if (this.StartedAdapter == target)
			{
				return;
			}
			IDangobrawlInputAdapter startedAdapter = this.StartedAdapter;
			if (startedAdapter != null)
			{
				startedAdapter.Stop();
			}
			this.StartedAdapter = target;
			target.Start();
		}

		// Token: 0x0401D469 RID: 119913
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x0401D46A RID: 119914
		private readonly Dictionary<EInputPlatform, IDangobrawlInputAdapter> Adapters = new Dictionary<EInputPlatform, IDangobrawlInputAdapter>();

		// Token: 0x0401D46B RID: 119915
		[Nullable(2)]
		private IDangobrawlInputAdapter StartedAdapter;
	}
}
