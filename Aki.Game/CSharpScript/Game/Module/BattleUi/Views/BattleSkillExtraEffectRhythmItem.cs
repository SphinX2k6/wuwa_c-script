using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE5 RID: 23781
	public class BattleSkillExtraEffectRhythmItem : BattleSkillExtraEffectItem
	{
		// Token: 0x0603C2D3 RID: 246483 RVA: 0x00E67C1C File Offset: 0x00E65E1C
		[NullableContext(1)]
		public override void Init(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_FightBtnRhythm", rootUiItem, false).Forget();
		}

		// Token: 0x0603C2D4 RID: 246484 RVA: 0x00E67C30 File Offset: 0x00E65E30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C2D5 RID: 246485 RVA: 0x00E67C78 File Offset: 0x00E65E78
		protected override void OnStart()
		{
			this.EffectItem = new BattleUiNiagaraItem(base.GetUiNiagara(0));
			if (this.ExtraEffectDuration > 0f)
			{
				this.EffectItem.Duration = this.ExtraEffectDuration * (float)TimeUtil.Instance.InverseMillisecond;
			}
			base.OnStart();
		}

		// Token: 0x0603C2D6 RID: 246486 RVA: 0x00E67CC7 File Offset: 0x00E65EC7
		protected override void OnRefresh()
		{
			BattleUiNiagaraItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.Play();
		}

		// Token: 0x0603C2D7 RID: 246487 RVA: 0x00E67CD9 File Offset: 0x00E65ED9
		public override void Stop()
		{
			BattleUiNiagaraItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.Stop();
		}

		// Token: 0x0401F5EB RID: 128491
		[Nullable(2)]
		private BattleUiNiagaraItem EffectItem;

		// Token: 0x0200BF40 RID: 48960
		private enum EChildType
		{
			// Token: 0x04039AFA RID: 236282
			Effect
		}
	}
}
