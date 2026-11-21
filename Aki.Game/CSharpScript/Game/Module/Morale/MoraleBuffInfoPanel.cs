using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200438F RID: 17295
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffInfoPanel : UiPanelBase
	{
		// Token: 0x0602BB01 RID: 178945 RVA: 0x00C4306C File Offset: 0x00C4126C
		public UniTask Init(UUIItem item)
		{
			MoraleBuffInfoPanel.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleBuffInfoPanel.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB02 RID: 178946 RVA: 0x00C430B8 File Offset: 0x00C412B8
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

		// Token: 0x0602BB03 RID: 178947 RVA: 0x00C431F4 File Offset: 0x00C413F4
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB04 RID: 178948 RVA: 0x00C43238 File Offset: 0x00C41438
		public void UpdateData(MoraleBuffData data)
		{
			this.BuffData = data;
			this.UpdateState();
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(data.Config.BuffName);
			}
			UUIText text2 = base.GetText(3);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(data.Config.BuffDescDetail);
		}

		// Token: 0x0602BB05 RID: 178949 RVA: 0x00C4328C File Offset: 0x00C4148C
		public void UpdateState()
		{
			switch (this.BuffData.GetActiveState())
			{
			case EMoraleBuffState.TempActive:
				this.SetStateTempActive();
				return;
			case EMoraleBuffState.Active:
				this.SetStateActive();
				return;
			case EMoraleBuffState.NotActive:
				this.SetStateNotActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BB06 RID: 178950 RVA: 0x00C432CC File Offset: 0x00C414CC
		public void SetStateActive()
		{
			this.SetActiveStateText("Morale_title_11", false);
			this.SetActiveStateBg("SP_FrameActivated");
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetIconChangeColor(true);
			this.SetBg("T_MoraleBuffBgActivate");
			this.SetStateNiagaraShow(7);
			this.SetStateItemShow(null);
		}

		// Token: 0x0602BB07 RID: 178951 RVA: 0x00C43330 File Offset: 0x00C41530
		public void SetStateTempActive()
		{
			this.SetActiveStateText("Morale_title_10", false);
			this.SetActiveStateBg("SP_FrameActivated");
			this.SetIcon(this.BuffData.Config.IconPathActive);
			this.SetIconChangeColor(true);
			this.SetBg("T_MoraleBuffBgActivateTemp");
			this.SetStateNiagaraShow(8);
			this.SetStateItemShow(new int?(9));
		}

		// Token: 0x0602BB08 RID: 178952 RVA: 0x00C43390 File Offset: 0x00C41590
		public void SetStateNotActive()
		{
			this.SetActiveStateText("Morale_title_12", true);
			this.SetActiveStateBg("SP_FrameUnactivated");
			this.SetIcon(this.BuffData.Config.IconPathNormal);
			this.SetIconChangeColor(false);
			this.SetBg("T_MoraleBuffBgUnactivated");
			this.SetStateNiagaraShow(5);
			this.SetStateItemShow(new int?(6));
		}

		// Token: 0x0602BB09 RID: 178953 RVA: 0x00C433F0 File Offset: 0x00C415F0
		private void SetActiveStateText(string key, bool useChangeColor = false)
		{
			UUIText text = base.GetText(12);
			if (text != null)
			{
				text.ShowTextNew(key);
			}
			if (text != null)
			{
				UUIItem uuiitem = text;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x0602BB0A RID: 178954 RVA: 0x00C43428 File Offset: 0x00C41628
		private void SetActiveStateBg(string resId)
		{
			UUISprite sprite = base.GetSprite(11);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0602BB0B RID: 178955 RVA: 0x00C43460 File Offset: 0x00C41660
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(4);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x0602BB0C RID: 178956 RVA: 0x00C43488 File Offset: 0x00C41688
		private void SetIconChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(4);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x0602BB0D RID: 178957 RVA: 0x00C434B4 File Offset: 0x00C416B4
		private void SetBg(string resId)
		{
			UUITexture texture = base.GetTexture(1);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x0602BB0E RID: 178958 RVA: 0x00C434E8 File Offset: 0x00C416E8
		private void SetStateNiagaraShow(int index)
		{
			foreach (int num in new int[]
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

		// Token: 0x0602BB0F RID: 178959 RVA: 0x00C43530 File Offset: 0x00C41730
		private void SetStateItemShow(int? index = null)
		{
			foreach (int num in new int[]
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

		// Token: 0x040178F6 RID: 96502
		public MoraleBuffData BuffData;

		// Token: 0x0200A076 RID: 41078
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031DA0 RID: 204192
			public const int ItemDesc = 0;

			// Token: 0x04031DA1 RID: 204193
			public const int TextureBg = 1;

			// Token: 0x04031DA2 RID: 204194
			public const int TextName = 2;

			// Token: 0x04031DA3 RID: 204195
			public const int TextDesc = 3;

			// Token: 0x04031DA4 RID: 204196
			public const int TextureIcon = 4;

			// Token: 0x04031DA5 RID: 204197
			public const int NiagaraLock = 5;

			// Token: 0x04031DA6 RID: 204198
			public const int ItemLock = 6;

			// Token: 0x04031DA7 RID: 204199
			public const int NiagaraActive = 7;

			// Token: 0x04031DA8 RID: 204200
			public const int NiagaraTempActive = 8;

			// Token: 0x04031DA9 RID: 204201
			public const int ItemTempActive = 9;

			// Token: 0x04031DAA RID: 204202
			public const int ItemActiveStateTag = 10;

			// Token: 0x04031DAB RID: 204203
			public const int SpriteActiveStateBg = 11;

			// Token: 0x04031DAC RID: 204204
			public const int TextActiveState = 12;
		}
	}
}
