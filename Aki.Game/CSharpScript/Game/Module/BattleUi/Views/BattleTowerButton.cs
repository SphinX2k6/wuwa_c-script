using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CBD RID: 19645
	public class BattleTowerButton : BattleEntranceButton
	{
		// Token: 0x060311C5 RID: 201157 RVA: 0x00DB6B50 File Offset: 0x00DB4D50
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUINiagara)));
		}

		// Token: 0x060311C6 RID: 201158 RVA: 0x00DB6B8E File Offset: 0x00DB4D8E
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnTowerGuideClose, new Action(this.OnTowerGuideClose));
		}

		// Token: 0x060311C7 RID: 201159 RVA: 0x00DB6BAC File Offset: 0x00DB4DAC
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnTowerGuideClose, new Action(this.OnTowerGuideClose));
		}

		// Token: 0x060311C8 RID: 201160 RVA: 0x00DB6BCA File Offset: 0x00DB4DCA
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AddEvents();
		}

		// Token: 0x060311C9 RID: 201161 RVA: 0x00DB6BD9 File Offset: 0x00DB4DD9
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x060311CA RID: 201162 RVA: 0x00DB6BE8 File Offset: 0x00DB4DE8
		private void OnTowerGuideClose()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(2);
			if (uiNiagara != null)
			{
				uiNiagara.SetNiagaraUIActive(false, true);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(3);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetNiagaraUIActive(false, true);
			}
			TimerSystem.Instance.Next(delegate(float _)
			{
				UUINiagara uiNiagara3 = base.GetUiNiagara(2);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetNiagaraUIActive(true, true);
				}
				UUINiagara uiNiagara4 = base.GetUiNiagara(3);
				if (uiNiagara4 == null)
				{
					return;
				}
				uiNiagara4.SetNiagaraUIActive(true, true);
			}, null, null);
		}

		// Token: 0x0200A939 RID: 43321
		private enum EChildType
		{
			// Token: 0x04034487 RID: 214151
			Button,
			// Token: 0x04034488 RID: 214152
			RedDotItem,
			// Token: 0x04034489 RID: 214153
			NiagaraItem1,
			// Token: 0x0403448A RID: 214154
			NiagaraItem2
		}
	}
}
