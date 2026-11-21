using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062C3 RID: 25283
	public class EffectAreaComponent : EntityComponent
	{
		// Token: 0x0603D0AF RID: 250031 RVA: 0x0118E666 File Offset: 0x0118C866
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			return true;
		}

		// Token: 0x0603D0B0 RID: 250032 RVA: 0x0118E669 File Offset: 0x0118C869
		protected override bool OnStart()
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerOverlapCallback));
			return true;
		}

		// Token: 0x0603D0B1 RID: 250033 RVA: 0x0118E68E File Offset: 0x0118C88E
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerOverlapCallback));
			if (this.IsPlayerInRange)
			{
				this.OnPlayerOverlapCallback(false);
			}
			return true;
		}

		// Token: 0x0603D0B2 RID: 250034 RVA: 0x0118E6C2 File Offset: 0x0118C8C2
		private void OnPlayerOverlapCallback(bool isEnter)
		{
			this.IsPlayerInRange = isEnter;
		}

		// Token: 0x0603D0B3 RID: 250035 RVA: 0x0118E6CC File Offset: 0x0118C8CC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			EffectAreaComponent effectAreaComponent = (EffectAreaComponent)componentTemplate;
			this.IsPlayerInRange = effectAreaComponent.IsPlayerInRange;
			return true;
		}

		// Token: 0x17007387 RID: 29575
		// (get) Token: 0x0603D0B4 RID: 250036 RVA: 0x0118E6F8 File Offset: 0x0118C8F8
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007388 RID: 29576
		// (get) Token: 0x0603D0B5 RID: 250037 RVA: 0x0118E6FB File Offset: 0x0118C8FB
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020609 RID: 132617
		private bool IsPlayerInRange;
	}
}
