using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A59 RID: 23129
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffInfoPanel : UiPanelBase
	{
		// Token: 0x0603AA18 RID: 240152 RVA: 0x00DF51A8 File Offset: 0x00DF33A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUINiagara)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUINiagara)),
				new ValueTuple<int, Type>(8, typeof(UUINiagara)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUISprite)),
				new ValueTuple<int, Type>(12, typeof(UUIText))
			};
		}

		// Token: 0x0603AA19 RID: 240153 RVA: 0x00DF52E2 File Offset: 0x00DF34E2
		protected override void OnStart()
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x0603AA1A RID: 240154 RVA: 0x00DF52F4 File Offset: 0x00DF34F4
		public void RefreshView(FlagChallengeBuffData data)
		{
			this.BuffData = data;
			this.UpdateState();
			base.GetText(2).ShowTextNew(data.Config.BuffName);
			base.GetText(3).ShowTextNew(data.Config.BuffDescDetail);
		}

		// Token: 0x0603AA1B RID: 240155 RVA: 0x00DF5344 File Offset: 0x00DF3544
		private void UpdateState()
		{
			switch (this.BuffData.GetBuffStatus())
			{
			case EFlagChallengeBuffStatus.NotActive:
				this.SetStateNotActive();
				return;
			case EFlagChallengeBuffStatus.Active:
				this.SetStateActive();
				return;
			case EFlagChallengeBuffStatus.TempActive:
				this.SetStateTempActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0603AA1C RID: 240156 RVA: 0x00DF5384 File Offset: 0x00DF3584
		public void SetStateActive()
		{
			this.SetActiveStateText("Morale_32_Buff_Activated", false);
			this.SetActiveStateBg("SP_FrameActivated");
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetIconChangeColor(true);
			this.SetBg("T_FlagChallengeBuffBgActivate");
			this.SetStateNiagaraShow(7);
			this.SetStateItemShow(null);
		}

		// Token: 0x0603AA1D RID: 240157 RVA: 0x00DF53EC File Offset: 0x00DF35EC
		public void SetStateTempActive()
		{
			this.SetActiveStateText("Morale_32_Buff_TempActivated", false);
			this.SetActiveStateBg("SP_FrameActivated");
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetIconChangeColor(true);
			this.SetBg("T_FlagChallengeBuffBgActivateTemp");
			this.SetStateNiagaraShow(8);
			this.SetStateItemShow(new int?(9));
		}

		// Token: 0x0603AA1E RID: 240158 RVA: 0x00DF5450 File Offset: 0x00DF3650
		public void SetStateNotActive()
		{
			this.SetActiveStateText("Morale_32_Buff_NotActivated", true);
			this.SetActiveStateBg("SP_FrameUnactivated");
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.SetIconChangeColor(false);
			this.SetBg("T_FlagChallengeBuffBgUnactivated");
			this.SetStateNiagaraShow(5);
			this.SetStateItemShow(new int?(6));
		}

		// Token: 0x0603AA1F RID: 240159 RVA: 0x00DF54B4 File Offset: 0x00DF36B4
		private void SetActiveStateText(string key, bool useChangeColor = false)
		{
			UUIText text = base.GetText(12);
			text.ShowTextNew(key);
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x0603AA20 RID: 240160 RVA: 0x00DF54E8 File Offset: 0x00DF36E8
		private void SetActiveStateBg(string resId)
		{
			UUISprite sprite = base.GetSprite(11);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0603AA21 RID: 240161 RVA: 0x00DF5520 File Offset: 0x00DF3720
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(4);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0603AA22 RID: 240162 RVA: 0x00DF5548 File Offset: 0x00DF3748
		private void SetIconChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(4);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x0603AA23 RID: 240163 RVA: 0x00DF5574 File Offset: 0x00DF3774
		private void SetBg(string resId)
		{
			UUITexture texture = base.GetTexture(1);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0603AA24 RID: 240164 RVA: 0x00DF55A8 File Offset: 0x00DF37A8
		private void SetStateNiagaraShow(int index)
		{
			foreach (int num in new List<int>
			{
				7,
				8,
				5
			})
			{
				UUINiagara uiNiagara = base.GetUiNiagara(num);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(index == num);
				}
			}
		}

		// Token: 0x0603AA25 RID: 240165 RVA: 0x00DF5620 File Offset: 0x00DF3820
		private void SetStateItemShow(int? index = null)
		{
			foreach (int num in new List<int>
			{
				9,
				6
			})
			{
				UUIItem item = base.GetItem(num);
				if (item != null)
				{
					int? num2 = index;
					int num3 = num;
					item.SetUIActive(num2.GetValueOrDefault() == num3 & num2 != null);
				}
			}
		}

		// Token: 0x0401E90F RID: 125199
		[Nullable(2)]
		private FlagChallengeBuffData BuffData;
	}
}
