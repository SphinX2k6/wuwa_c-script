using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x0200720E RID: 29198
	public class EffectAreaComponent : EntityComponent
	{
		// Token: 0x0604779A RID: 292762 RVA: 0x01234BEC File Offset: 0x01232DEC
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			return true;
		}

		// Token: 0x0604779B RID: 292763 RVA: 0x01234BEF File Offset: 0x01232DEF
		protected override bool OnStart()
		{
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerOverlapCallback));
			return true;
		}

		// Token: 0x0604779C RID: 292764 RVA: 0x01234C14 File Offset: 0x01232E14
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerOverlapCallback));
			if (this.IsPlayerInRange)
			{
				this.OnPlayerOverlapCallback(false);
			}
			return true;
		}

		// Token: 0x0604779D RID: 292765 RVA: 0x01234C48 File Offset: 0x01232E48
		private void OnPlayerOverlapCallback(bool isEnter)
		{
			this.IsPlayerInRange = isEnter;
		}

		// Token: 0x0604779E RID: 292766 RVA: 0x01234C54 File Offset: 0x01232E54
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			EffectAreaComponent effectAreaComponent = (EffectAreaComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsPlayerInRange"))
			{
				this.IsPlayerInRange = effectAreaComponent.IsPlayerInRange;
			}
			return true;
		}

		// Token: 0x0402599A RID: 154010
		private bool IsPlayerInRange;
	}
}
