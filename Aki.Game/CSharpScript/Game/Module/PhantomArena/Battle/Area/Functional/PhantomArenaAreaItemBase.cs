using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052CF RID: 21199
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaAreaItemBase : UiPanelBase
	{
		// Token: 0x060363E4 RID: 222180 RVA: 0x00CD54A8 File Offset: 0x00CD36A8
		protected override void OnStart()
		{
			Vector worldLocation = this.WorldLocation;
			FVector location = base.GetRootItem().K2_GetComponentToWorld().GetLocation();
			worldLocation.FromUeVector(location);
			this.SetHoverStateActive(false);
			this.SetCanUseStateActive(false);
			this.OnStartImplement();
		}

		// Token: 0x060363E5 RID: 222181 RVA: 0x00CD54EA File Offset: 0x00CD36EA
		public Vector GetWorldLocation()
		{
			return this.WorldLocation;
		}

		// Token: 0x060363E6 RID: 222182 RVA: 0x00CD54F2 File Offset: 0x00CD36F2
		protected override void OnStartImplement()
		{
		}

		// Token: 0x060363E7 RID: 222183
		public abstract void Refresh(PhantomArenaCard card);

		// Token: 0x060363E8 RID: 222184
		public abstract void SetHoverStateActive(bool value);

		// Token: 0x060363E9 RID: 222185
		public abstract void SetCanUseStateActive(bool value);

		// Token: 0x060363EA RID: 222186 RVA: 0x00CD54F4 File Offset: 0x00CD36F4
		public void SetProxy(PhantomArenaAreaProxyBase proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0401CAD9 RID: 117465
		private readonly Vector WorldLocation = Vector.Create();

		// Token: 0x0401CADA RID: 117466
		protected PhantomArenaAreaProxyBase Proxy;
	}
}
