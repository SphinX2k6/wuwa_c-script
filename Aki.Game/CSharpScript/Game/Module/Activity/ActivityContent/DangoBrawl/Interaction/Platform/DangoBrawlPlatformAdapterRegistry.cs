using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Input;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Sticky;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Platform
{
	// Token: 0x0200686E RID: 26734
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlPlatformAdapterRegistry
	{
		// Token: 0x06042C26 RID: 273446 RVA: 0x0103FAEC File Offset: 0x0103DCEC
		public DangoBrawlPlatformAdapterRegistry(InteractionStateMachine fsm, DangoBrawlPlatformState platformState, DangoBrawlDragCtrl dragCtrl, DangoBrawlStickyCtrl sticky)
		{
			this.PlatformState = platformState;
			this.Adapters[EInputPlatform.Mobile] = new DangoBrawlMobileAdapter(dragCtrl);
			this.Adapters[EInputPlatform.Pc] = new DangoBrawlPcAdapter(dragCtrl, sticky, fsm);
			this.Adapters[EInputPlatform.Gamepad] = new DangoBrawlGamepadAdapter(dragCtrl, sticky, fsm);
		}

		// Token: 0x17009795 RID: 38805
		// (get) Token: 0x06042C27 RID: 273447 RVA: 0x0103FB50 File Offset: 0x0103DD50
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

		// Token: 0x06042C28 RID: 273448 RVA: 0x0103FB85 File Offset: 0x0103DD85
		public void Start()
		{
			this.SwitchTo(this.Current);
		}

		// Token: 0x06042C29 RID: 273449 RVA: 0x0103FB93 File Offset: 0x0103DD93
		public void Stop()
		{
			IDangobrawlInputAdapter startedAdapter = this.StartedAdapter;
			if (startedAdapter != null)
			{
				startedAdapter.Stop();
			}
			this.StartedAdapter = null;
		}

		// Token: 0x06042C2A RID: 273450 RVA: 0x0103FBAD File Offset: 0x0103DDAD
		public void UpdatePlatform()
		{
			this.SwitchTo(this.Current);
		}

		// Token: 0x06042C2B RID: 273451 RVA: 0x0103FBBB File Offset: 0x0103DDBB
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

		// Token: 0x04022C0C RID: 142348
		private readonly DangoBrawlPlatformState PlatformState;

		// Token: 0x04022C0D RID: 142349
		private readonly Dictionary<EInputPlatform, IDangobrawlInputAdapter> Adapters = new Dictionary<EInputPlatform, IDangobrawlInputAdapter>();

		// Token: 0x04022C0E RID: 142350
		[Nullable(2)]
		private IDangobrawlInputAdapter StartedAdapter;
	}
}
