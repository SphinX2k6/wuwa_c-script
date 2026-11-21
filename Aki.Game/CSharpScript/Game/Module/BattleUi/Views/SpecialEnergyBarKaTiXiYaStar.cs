using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCA RID: 19914
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarKaTiXiYaStar : UiPanelBase
	{
		// Token: 0x06032128 RID: 205096 RVA: 0x00E06608 File Offset: 0x00E04808
		protected override void OnRegisterComponent()
		{
			this.ItemNum = 11;
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x06032129 RID: 205097 RVA: 0x00E0664C File Offset: 0x00E0484C
		protected override void OnStart()
		{
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.TargetAlphaList.Add(1f);
				this.CurAlphaList.Add(1f);
			}
			this.AlphaSpeed = 0.0033333334f;
		}

		// Token: 0x0603212A RID: 205098 RVA: 0x00E06698 File Offset: 0x00E04898
		public void SetStarNum(int starNum)
		{
			if (this.CurStarNum == starNum)
			{
				return;
			}
			int num = Math.Max(starNum * 2 - 1, 0);
			if (this.CurStarNum == -1)
			{
				for (int i = 0; i < this.ItemNum; i++)
				{
					base.GetItem(i).SetUIActive(i < num);
					base.GetItem(i).SetAlpha(1f);
				}
			}
			else
			{
				int num2 = Math.Max(this.CurStarNum * 2 - 1, 0);
				if (num2 > num)
				{
					for (int j = num; j < num2; j++)
					{
						this.PlayStarHideAnim(j);
					}
				}
				else
				{
					for (int k = num2; k < num; k++)
					{
						base.GetItem(k).SetUIActive(true);
						this.StopStarHideAnim(k);
					}
				}
			}
			this.CurStarNum = starNum;
		}

		// Token: 0x0603212B RID: 205099 RVA: 0x00E0674F File Offset: 0x00E0494F
		private void PlayStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 0f;
			this.IsAnyEffectPlaying = true;
		}

		// Token: 0x0603212C RID: 205100 RVA: 0x00E06769 File Offset: 0x00E04969
		private void StopStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 1f;
			this.CurAlphaList[index] = 1f;
			base.GetItem(index).SetAlpha(1f);
		}

		// Token: 0x0603212D RID: 205101 RVA: 0x00E067A0 File Offset: 0x00E049A0
		public void Tick(float delta)
		{
			if (!this.IsAnyEffectPlaying)
			{
				return;
			}
			this.IsAnyEffectPlaying = false;
			float num = delta * this.AlphaSpeed;
			for (int i = 0; i < this.ItemNum; i++)
			{
				if (this.CurAlphaList[i] != this.TargetAlphaList[i])
				{
					if (this.CurAlphaList[i] < this.TargetAlphaList[i])
					{
						this.CurAlphaList[i] = this.TargetAlphaList[i];
					}
					else
					{
						List<float> curAlphaList = this.CurAlphaList;
						int index = i;
						curAlphaList[index] -= num;
						if (this.CurAlphaList[i] <= this.TargetAlphaList[i])
						{
							this.CurAlphaList[i] = this.TargetAlphaList[i];
						}
						else
						{
							this.IsAnyEffectPlaying = true;
						}
					}
					base.GetItem(i).SetAlpha(this.CurAlphaList[i]);
					if (this.CurAlphaList[i] == 0f)
					{
						base.GetItem(i).SetUIActive(false);
					}
				}
			}
		}

		// Token: 0x0401A84C RID: 108620
		private const int ALPHA_ANIM_TIME = 300;

		// Token: 0x0401A84D RID: 108621
		public const int StarTotalNum = 6;

		// Token: 0x0401A84E RID: 108622
		private int ItemNum;

		// Token: 0x0401A84F RID: 108623
		private int CurStarNum = -1;

		// Token: 0x0401A850 RID: 108624
		private readonly List<float> TargetAlphaList = new List<float>();

		// Token: 0x0401A851 RID: 108625
		private readonly List<float> CurAlphaList = new List<float>();

		// Token: 0x0401A852 RID: 108626
		private bool IsAnyEffectPlaying;

		// Token: 0x0401A853 RID: 108627
		private float AlphaSpeed = 1f;
	}
}
