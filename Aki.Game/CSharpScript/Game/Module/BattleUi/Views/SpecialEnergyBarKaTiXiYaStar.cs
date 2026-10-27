using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE6 RID: 24038
	[NullableContext(1)]
	[Nullable(0)]
	internal class SpecialEnergyBarKaTiXiYaStar : UiPanelBase
	{
		// Token: 0x0603D1B1 RID: 250289 RVA: 0x00EB5708 File Offset: 0x00EB3908
		protected override void OnRegisterComponent()
		{
			this.ItemNum = 11;
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D1B2 RID: 250290 RVA: 0x00EB574C File Offset: 0x00EB394C
		protected override void OnStart()
		{
			for (int i = 0; i < this.ItemNum; i++)
			{
				this.TargetAlphaList.Add(1f);
				this.CurAlphaList.Add(1f);
			}
			this.AlphaSpeed = 0.0033333334f;
		}

		// Token: 0x0603D1B3 RID: 250291 RVA: 0x00EB5798 File Offset: 0x00EB3998
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

		// Token: 0x0603D1B4 RID: 250292 RVA: 0x00EB584F File Offset: 0x00EB3A4F
		private void PlayStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 0f;
			this.IsAnyEffectPlaying = true;
		}

		// Token: 0x0603D1B5 RID: 250293 RVA: 0x00EB5869 File Offset: 0x00EB3A69
		private void StopStarHideAnim(int index)
		{
			this.TargetAlphaList[index] = 1f;
			this.CurAlphaList[index] = 1f;
			base.GetItem(index).SetAlpha(1f);
		}

		// Token: 0x0603D1B6 RID: 250294 RVA: 0x00EB58A0 File Offset: 0x00EB3AA0
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

		// Token: 0x0401FD8F RID: 130447
		private const int ALPHA_ANIM_TIME = 300;

		// Token: 0x0401FD90 RID: 130448
		public const int StarTotalNum = 6;

		// Token: 0x0401FD91 RID: 130449
		private int ItemNum;

		// Token: 0x0401FD92 RID: 130450
		private int CurStarNum = -1;

		// Token: 0x0401FD93 RID: 130451
		private readonly List<float> TargetAlphaList = new List<float>();

		// Token: 0x0401FD94 RID: 130452
		private readonly List<float> CurAlphaList = new List<float>();

		// Token: 0x0401FD95 RID: 130453
		private bool IsAnyEffectPlaying;

		// Token: 0x0401FD96 RID: 130454
		private float AlphaSpeed = 1f;
	}
}
