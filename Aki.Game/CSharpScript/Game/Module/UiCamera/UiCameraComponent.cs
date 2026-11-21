using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398C RID: 14732
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiCameraComponent
	{
		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x06025EA8 RID: 155304 RVA: 0x00AA56FE File Offset: 0x00AA38FE
		// (set) Token: 0x06025EA9 RID: 155305 RVA: 0x00AA5706 File Offset: 0x00AA3906
		private protected UiCamera Owner { protected get; private set; }

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x06025EAA RID: 155306 RVA: 0x00AA570F File Offset: 0x00AA390F
		// (set) Token: 0x06025EAB RID: 155307 RVA: 0x00AA5717 File Offset: 0x00AA3917
		private protected UiCameraModeBase Mode { protected get; private set; }

		// Token: 0x06025EAC RID: 155308 RVA: 0x00AA5720 File Offset: 0x00AA3920
		internal void Initialize(UiCamera owner, UiCameraModeBase mode)
		{
			this.Owner = owner;
			this.Mode = mode;
			this.OnInitialize();
		}

		// Token: 0x06025EAD RID: 155309 RVA: 0x00AA5736 File Offset: 0x00AA3936
		internal void EnterMode()
		{
			this.OnEnterMode();
		}

		// Token: 0x06025EAE RID: 155310 RVA: 0x00AA573E File Offset: 0x00AA393E
		internal void ExitMode()
		{
			this.OnExitMode();
		}

		// Token: 0x06025EAF RID: 155311 RVA: 0x00AA5746 File Offset: 0x00AA3946
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06025EB0 RID: 155312 RVA: 0x00AA5748 File Offset: 0x00AA3948
		protected virtual void OnEnterMode()
		{
		}

		// Token: 0x06025EB1 RID: 155313 RVA: 0x00AA574A File Offset: 0x00AA394A
		protected virtual void OnExitMode()
		{
		}

		// Token: 0x06025EB2 RID: 155314 RVA: 0x00AA574C File Offset: 0x00AA394C
		public virtual void Apply(UiCameraHandleData data)
		{
		}

		// Token: 0x06025EB3 RID: 155315 RVA: 0x00AA574E File Offset: 0x00AA394E
		public virtual void Tick(float deltaTime)
		{
		}

		// Token: 0x06025EB4 RID: 155316 RVA: 0x00AA5750 File Offset: 0x00AA3950
		public virtual void Clear()
		{
		}
	}
}
