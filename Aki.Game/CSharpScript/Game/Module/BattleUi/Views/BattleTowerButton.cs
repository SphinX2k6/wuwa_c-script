using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CDB RID: 23771
	public class BattleTowerButton : BattleEntranceButton
	{
		// Token: 0x0603C26F RID: 246383 RVA: 0x00E6659C File Offset: 0x00E6479C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUINiagara)));
		}

		// Token: 0x0603C270 RID: 246384 RVA: 0x00E665DA File Offset: 0x00E647DA
		protected void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnTowerGuideClose, new Action(this.OnTowerGuideClose));
		}

		// Token: 0x0603C271 RID: 246385 RVA: 0x00E665F8 File Offset: 0x00E647F8
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnTowerGuideClose, new Action(this.OnTowerGuideClose));
		}

		// Token: 0x0603C272 RID: 246386 RVA: 0x00E66616 File Offset: 0x00E64816
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.AddEvents();
		}

		// Token: 0x0603C273 RID: 246387 RVA: 0x00E66625 File Offset: 0x00E64825
		public override void Reset()
		{
			this.RemoveEvents();
			base.Reset();
		}

		// Token: 0x0603C274 RID: 246388 RVA: 0x00E66634 File Offset: 0x00E64834
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

		// Token: 0x0200BF33 RID: 48947
		private enum EChildType
		{
			// Token: 0x04039AC5 RID: 236229
			Button,
			// Token: 0x04039AC6 RID: 236230
			RedDotItem,
			// Token: 0x04039AC7 RID: 236231
			NiagaraItem1,
			// Token: 0x04039AC8 RID: 236232
			NiagaraItem2
		}
	}
}
