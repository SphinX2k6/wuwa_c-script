using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E10 RID: 24080
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarXinYueHuStar : UiPanelBase
	{
		// Token: 0x0603D3C3 RID: 250819 RVA: 0x00EC1410 File Offset: 0x00EBF610
		protected override void OnRegisterComponent()
		{
			this.ItemNum = 6;
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D3C4 RID: 250820 RVA: 0x00EC1450 File Offset: 0x00EBF650
		protected override void OnStart()
		{
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.TargetAlphaList.Add(1f);
				this.CurAlphaList.Add(1f);
			}
			this.AlphaSpeed = 0.0033333334f;
		}

		// Token: 0x0603D3C5 RID: 250821 RVA: 0x00EC149C File Offset: 0x00EBF69C
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

		// Token: 0x0603D3C6 RID: 250822 RVA: 0x00EC154B File Offset: 0x00EBF74B
		private void PlayStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 0f;
			this.IsAnyEffectPlaying = true;
		}

		// Token: 0x0603D3C7 RID: 250823 RVA: 0x00EC1565 File Offset: 0x00EBF765
		private void StopStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 1f;
			this.CurAlphaList[index] = 1f;
			base.GetItem(index).SetAlpha(1f);
		}

		// Token: 0x0603D3C8 RID: 250824 RVA: 0x00EC159C File Offset: 0x00EBF79C
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

		// Token: 0x0401FEE7 RID: 130791
		private const int ALPHA_ANIM_TIME = 300;

		// Token: 0x0401FEE8 RID: 130792
		public const int StarTotalNum = 6;

		// Token: 0x0401FEE9 RID: 130793
		private int ItemNum;

		// Token: 0x0401FEEA RID: 130794
		private int CurStarNum = -1;

		// Token: 0x0401FEEB RID: 130795
		private readonly List<float> TargetAlphaList = new List<float>();

		// Token: 0x0401FEEC RID: 130796
		private readonly List<float> CurAlphaList = new List<float>();

		// Token: 0x0401FEED RID: 130797
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FEEE RID: 130798
		private float AlphaSpeed = 1f;
	}
}
