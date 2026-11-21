using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x0200429F RID: 17055
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class PhantomArenaAreaItemBase : UiPanelBase
	{
		// Token: 0x0602B2DF RID: 176863 RVA: 0x00C22BD0 File Offset: 0x00C20DD0
		protected override void OnStart()
		{
			Vector worldLocation = this.WorldLocation;
			FVector location = base.GetRootItem().K2_GetComponentToWorld().GetLocation();
			worldLocation.FromUeVector(location);
			this.SetHoverStateActive(false);
			this.SetCanUseStateActive(false);
			this.OnStartImplement();
		}

		// Token: 0x0602B2E0 RID: 176864 RVA: 0x00C22C12 File Offset: 0x00C20E12
		public Vector GetWorldLocation()
		{
			return this.WorldLocation;
		}

		// Token: 0x0602B2E1 RID: 176865 RVA: 0x00C22C1A File Offset: 0x00C20E1A
		protected override void OnStartImplement()
		{
		}

		// Token: 0x0602B2E2 RID: 176866
		public abstract void Refresh(PhantomArenaCard card);

		// Token: 0x0602B2E3 RID: 176867
		public abstract void SetHoverStateActive(bool value);

		// Token: 0x0602B2E4 RID: 176868
		public abstract void SetCanUseStateActive(bool value);

		// Token: 0x0602B2E5 RID: 176869 RVA: 0x00C22C1C File Offset: 0x00C20E1C
		public void SetProxy(PhantomArenaAreaProxyBase proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0401750E RID: 95502
		private readonly Vector WorldLocation = Vector.Create();

		// Token: 0x0401750F RID: 95503
		protected PhantomArenaAreaProxyBase Proxy;
	}
}
