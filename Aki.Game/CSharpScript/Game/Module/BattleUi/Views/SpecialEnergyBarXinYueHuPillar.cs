using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF3 RID: 19955
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXinYueHuPillar
	{
		// Token: 0x06032348 RID: 205640 RVA: 0x00E1255C File Offset: 0x00E1075C
		public UniTask InitAsync(int pillarNum, UUIItem pillarItem, UUINiagara fullEffect)
		{
			SpecialEnergyBarXinYueHuPillar.<InitAsync>d__6 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.pillarNum = pillarNum;
			<InitAsync>d__.pillarItem = pillarItem;
			<InitAsync>d__.fullEffect = fullEffect;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<SpecialEnergyBarXinYueHuPillar.<InitAsync>d__6>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032349 RID: 205641 RVA: 0x00E125B8 File Offset: 0x00E107B8
		public void Destroy()
		{
			this.StopTimer();
			foreach (SpecialEnergyBarXinYueHuPillarItem specialEnergyBarXinYueHuPillarItem in this.PillarItemList)
			{
				specialEnergyBarXinYueHuPillarItem.Destroy(null);
			}
			this.PillarItemList.Clear();
			this.PillarUiItemList.Clear();
			this.FullEffect = null;
		}

		// Token: 0x0603234A RID: 205642 RVA: 0x00E1262C File Offset: 0x00E1082C
		public void InitByBarPercent(float percent)
		{
			this.StopTimer();
			UUINiagara fullEffect = this.FullEffect;
			if (fullEffect != null)
			{
				fullEffect.SetUIActive(percent <= 0f);
			}
			int num = (int)Math.Floor((double)((1f - percent) * 8f));
			this.CurFullCount = num;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					this.PillarItemList[i].InitByState(true);
				}
				for (int j = num; j < this.PillarItemList.Count; j++)
				{
					this.PillarItemList[j].InitByState(false);
				}
				return;
			}
			for (int k = 0; k < this.PillarItemList.Count; k++)
			{
				this.PillarItemList[k].Reset();
			}
			this.PillarItemList[0].PlayStart();
			this.NextAnimIndex = 1;
			this.Timer = TimerSystem.Instance.Loop(new TTimerAction(this.OnTimer), 20f, this.PillarItemList.Count - num - 1, 1f, null, null, true);
		}

		// Token: 0x0603234B RID: 205643 RVA: 0x00E1273C File Offset: 0x00E1093C
		private void OnTimer(float delta)
		{
			if (this.NextAnimIndex >= this.PillarItemList.Count)
			{
				return;
			}
			if (this.NextAnimIndex >= this.CurFullCount)
			{
				this.PillarItemList[this.NextAnimIndex].PlayStart();
			}
			this.NextAnimIndex++;
		}

		// Token: 0x0603234C RID: 205644 RVA: 0x00E1278F File Offset: 0x00E1098F
		private void StopTimer()
		{
			if (TimerSystem.Instance.Has(this.Timer))
			{
				TimerSystem.Instance.Remove(this.Timer);
			}
			this.Timer = null;
		}

		// Token: 0x0603234D RID: 205645 RVA: 0x00E127BC File Offset: 0x00E109BC
		public void OnBarPercentChanged(float percent)
		{
			int num = (int)Math.Floor((double)((1f - percent) * 8f));
			if (num == this.CurFullCount)
			{
				return;
			}
			if (num > this.CurFullCount)
			{
				for (int i = this.CurFullCount; i < num; i++)
				{
					this.PillarItemList[i].PlayFull();
				}
			}
			else
			{
				for (int j = num; j < this.CurFullCount; j++)
				{
					this.PillarItemList[j].PlayStart();
				}
			}
			this.CurFullCount = num;
			UUINiagara fullEffect = this.FullEffect;
			if (fullEffect == null)
			{
				return;
			}
			fullEffect.SetUIActive(percent <= 0f);
		}

		// Token: 0x0401A9A6 RID: 108966
		private List<UUIItem> PillarUiItemList = new List<UUIItem>();

		// Token: 0x0401A9A7 RID: 108967
		private List<SpecialEnergyBarXinYueHuPillarItem> PillarItemList = new List<SpecialEnergyBarXinYueHuPillarItem>();

		// Token: 0x0401A9A8 RID: 108968
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401A9A9 RID: 108969
		private int NextAnimIndex;

		// Token: 0x0401A9AA RID: 108970
		private int CurFullCount;

		// Token: 0x0401A9AB RID: 108971
		[Nullable(2)]
		private UUINiagara FullEffect;
	}
}
