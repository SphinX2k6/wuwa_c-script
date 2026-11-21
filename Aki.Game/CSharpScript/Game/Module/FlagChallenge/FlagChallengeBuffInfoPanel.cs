using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A35 RID: 18997
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffInfoPanel : UiPanelBase
	{
		// Token: 0x0602F961 RID: 194913 RVA: 0x00D4572C File Offset: 0x00D4392C
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

		// Token: 0x0602F962 RID: 194914 RVA: 0x00D45866 File Offset: 0x00D43A66
		protected override void OnStart()
		{
			base.GetItem(0).SetUIActive(false);
		}

		// Token: 0x0602F963 RID: 194915 RVA: 0x00D45878 File Offset: 0x00D43A78
		public void RefreshView(FlagChallengeBuffData data)
		{
			this.BuffData = data;
			this.UpdateState();
			base.GetText(2).ShowTextNew(data.Config.BuffName);
			base.GetText(3).ShowTextNew(data.Config.BuffDescDetail);
		}

		// Token: 0x0602F964 RID: 194916 RVA: 0x00D458C8 File Offset: 0x00D43AC8
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

		// Token: 0x0602F965 RID: 194917 RVA: 0x00D45908 File Offset: 0x00D43B08
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

		// Token: 0x0602F966 RID: 194918 RVA: 0x00D45970 File Offset: 0x00D43B70
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

		// Token: 0x0602F967 RID: 194919 RVA: 0x00D459D4 File Offset: 0x00D43BD4
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

		// Token: 0x0602F968 RID: 194920 RVA: 0x00D45A38 File Offset: 0x00D43C38
		private void SetActiveStateText(string key, bool useChangeColor = false)
		{
			UUIText text = base.GetText(12);
			text.ShowTextNew(key);
			UUIItem uuiitem = text;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x0602F969 RID: 194921 RVA: 0x00D45A6C File Offset: 0x00D43C6C
		private void SetActiveStateBg(string resId)
		{
			UUISprite sprite = base.GetSprite(11);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0602F96A RID: 194922 RVA: 0x00D45AA4 File Offset: 0x00D43CA4
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(4);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0602F96B RID: 194923 RVA: 0x00D45ACC File Offset: 0x00D43CCC
		private void SetIconChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(4);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x0602F96C RID: 194924 RVA: 0x00D45AF8 File Offset: 0x00D43CF8
		private void SetBg(string resId)
		{
			UUITexture texture = base.GetTexture(1);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0602F96D RID: 194925 RVA: 0x00D45B2C File Offset: 0x00D43D2C
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

		// Token: 0x0602F96E RID: 194926 RVA: 0x00D45BA4 File Offset: 0x00D43DA4
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

		// Token: 0x040193B6 RID: 103350
		[Nullable(2)]
		private FlagChallengeBuffData BuffData;
	}
}
