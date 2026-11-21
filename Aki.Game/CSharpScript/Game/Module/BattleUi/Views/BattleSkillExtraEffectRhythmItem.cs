using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC7 RID: 19655
	public class BattleSkillExtraEffectRhythmItem : BattleSkillExtraEffectItem
	{
		// Token: 0x06031229 RID: 201257 RVA: 0x00DB81D0 File Offset: 0x00DB63D0
		[NullableContext(1)]
		public override void Init(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_FightBtnRhythm", rootUiItem, false).Forget();
		}

		// Token: 0x0603122A RID: 201258 RVA: 0x00DB81E4 File Offset: 0x00DB63E4
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

		// Token: 0x0603122B RID: 201259 RVA: 0x00DB822C File Offset: 0x00DB642C
		protected override void OnStart()
		{
			this.EffectItem = new BattleUiNiagaraItem(base.GetUiNiagara(0));
			if (this.ExtraEffectDuration > 0f)
			{
				this.EffectItem.Duration = this.ExtraEffectDuration * (float)TimeUtil.Instance.InverseMillisecond;
			}
			base.OnStart();
		}

		// Token: 0x0603122C RID: 201260 RVA: 0x00DB827B File Offset: 0x00DB647B
		protected override void OnRefresh()
		{
			BattleUiNiagaraItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.Play();
		}

		// Token: 0x0603122D RID: 201261 RVA: 0x00DB828D File Offset: 0x00DB648D
		public override void Stop()
		{
			BattleUiNiagaraItem effectItem = this.EffectItem;
			if (effectItem == null)
			{
				return;
			}
			effectItem.Stop();
		}

		// Token: 0x0401A0A4 RID: 106660
		[Nullable(2)]
		private BattleUiNiagaraItem EffectItem;

		// Token: 0x0200A946 RID: 43334
		private enum EChildType
		{
			// Token: 0x040344BC RID: 214204
			Effect
		}
	}
}
