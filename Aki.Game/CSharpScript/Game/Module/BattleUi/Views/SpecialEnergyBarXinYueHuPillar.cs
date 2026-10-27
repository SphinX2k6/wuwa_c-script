using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E0E RID: 24078
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarXinYueHuPillar
	{
		// Token: 0x0603D3B9 RID: 250809 RVA: 0x00EC0FFC File Offset: 0x00EBF1FC
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

		// Token: 0x0603D3BA RID: 250810 RVA: 0x00EC1058 File Offset: 0x00EBF258
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

		// Token: 0x0603D3BB RID: 250811 RVA: 0x00EC10CC File Offset: 0x00EBF2CC
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

		// Token: 0x0603D3BC RID: 250812 RVA: 0x00EC11DC File Offset: 0x00EBF3DC
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

		// Token: 0x0603D3BD RID: 250813 RVA: 0x00EC122F File Offset: 0x00EBF42F
		private void StopTimer()
		{
			if (TimerSystem.Instance.Has(this.Timer))
			{
				TimerSystem.Instance.Remove(this.Timer);
			}
			this.Timer = null;
		}

		// Token: 0x0603D3BE RID: 250814 RVA: 0x00EC125C File Offset: 0x00EBF45C
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

		// Token: 0x0401FEDF RID: 130783
		private List<UUIItem> PillarUiItemList = new List<UUIItem>();

		// Token: 0x0401FEE0 RID: 130784
		private List<SpecialEnergyBarXinYueHuPillarItem> PillarItemList = new List<SpecialEnergyBarXinYueHuPillarItem>();

		// Token: 0x0401FEE1 RID: 130785
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401FEE2 RID: 130786
		private int NextAnimIndex;

		// Token: 0x0401FEE3 RID: 130787
		private int CurFullCount;

		// Token: 0x0401FEE4 RID: 130788
		[Nullable(2)]
		private UUINiagara FullEffect;
	}
}
