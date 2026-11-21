using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DF5 RID: 19957
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarXinYueHuStar : UiPanelBase
	{
		// Token: 0x06032352 RID: 205650 RVA: 0x00E12970 File Offset: 0x00E10B70
		protected override void OnRegisterComponent()
		{
			this.ItemNum = 6;
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x06032353 RID: 205651 RVA: 0x00E129B0 File Offset: 0x00E10BB0
		protected override void OnStart()
		{
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.TargetAlphaList.Add(1f);
				this.CurAlphaList.Add(1f);
			}
			this.AlphaSpeed = 0.0033333334f;
		}

		// Token: 0x06032354 RID: 205652 RVA: 0x00E129FC File Offset: 0x00E10BFC
		public void SetStarNum(int starNum)
		{
			if (this.CurStarNum == starNum)
			{
				return;
			}
			int num = Math.Max(starNum, 0);
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
				int num2 = Math.Max(this.CurStarNum, 0);
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

		// Token: 0x06032355 RID: 205653 RVA: 0x00E12AAB File Offset: 0x00E10CAB
		private void PlayStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 0f;
			this.IsAnyEffectPlaying = true;
		}

		// Token: 0x06032356 RID: 205654 RVA: 0x00E12AC5 File Offset: 0x00E10CC5
		private void StopStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 1f;
			this.CurAlphaList[index] = 1f;
			base.GetItem(index).SetAlpha(1f);
		}

		// Token: 0x06032357 RID: 205655 RVA: 0x00E12AFC File Offset: 0x00E10CFC
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

		// Token: 0x0401A9AE RID: 108974
		private const int ALPHA_ANIM_TIME = 300;

		// Token: 0x0401A9AF RID: 108975
		public const int StarTotalNum = 6;

		// Token: 0x0401A9B0 RID: 108976
		private int ItemNum;

		// Token: 0x0401A9B1 RID: 108977
		private int CurStarNum = -1;

		// Token: 0x0401A9B2 RID: 108978
		private readonly List<float> TargetAlphaList = new List<float>();

		// Token: 0x0401A9B3 RID: 108979
		private readonly List<float> CurAlphaList = new List<float>();

		// Token: 0x0401A9B4 RID: 108980
		private bool IsAnyEffectPlaying;

		// Token: 0x0401A9B5 RID: 108981
		private float AlphaSpeed = 1f;
	}
}
