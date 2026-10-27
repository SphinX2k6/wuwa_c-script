using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053AC RID: 21420
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffInfoPanel : UiPanelBase
	{
		// Token: 0x06036BBB RID: 224187 RVA: 0x00CF3FC4 File Offset: 0x00CF21C4
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

		// Token: 0x06036BBC RID: 224188 RVA: 0x00CF4010 File Offset: 0x00CF2210
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

		// Token: 0x06036BBD RID: 224189 RVA: 0x00CF414C File Offset: 0x00CF234C
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleBuffInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleBuffInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036BBE RID: 224190 RVA: 0x00CF4190 File Offset: 0x00CF2390
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

		// Token: 0x06036BBF RID: 224191 RVA: 0x00CF41E4 File Offset: 0x00CF23E4
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

		// Token: 0x06036BC0 RID: 224192 RVA: 0x00CF4224 File Offset: 0x00CF2424
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

		// Token: 0x06036BC1 RID: 224193 RVA: 0x00CF4288 File Offset: 0x00CF2488
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

		// Token: 0x06036BC2 RID: 224194 RVA: 0x00CF42E8 File Offset: 0x00CF24E8
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

		// Token: 0x06036BC3 RID: 224195 RVA: 0x00CF4348 File Offset: 0x00CF2548
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

		// Token: 0x06036BC4 RID: 224196 RVA: 0x00CF4380 File Offset: 0x00CF2580
		private void SetActiveStateBg(string resId)
		{
			UUISprite sprite = base.GetSprite(11);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x06036BC5 RID: 224197 RVA: 0x00CF43B8 File Offset: 0x00CF25B8
		private void SetIcon(string path)
		{
			UUITexture texture = base.GetTexture(4);
			base.SetTextureByPath(path, texture, null, null);
		}

		// Token: 0x06036BC6 RID: 224198 RVA: 0x00CF43E0 File Offset: 0x00CF25E0
		private void SetIconChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(4);
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(useChangeColor, fcolor);
		}

		// Token: 0x06036BC7 RID: 224199 RVA: 0x00CF440C File Offset: 0x00CF260C
		private void SetBg(string resId)
		{
			UUITexture texture = base.GetTexture(1);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06036BC8 RID: 224200 RVA: 0x00CF4440 File Offset: 0x00CF2640
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

		// Token: 0x06036BC9 RID: 224201 RVA: 0x00CF4488 File Offset: 0x00CF2688
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

		// Token: 0x0401CE5E RID: 118366
		public MoraleBuffData BuffData;

		// Token: 0x0200B63E RID: 46654
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403734B RID: 226123
			public const int ItemDesc = 0;

			// Token: 0x0403734C RID: 226124
			public const int TextureBg = 1;

			// Token: 0x0403734D RID: 226125
			public const int TextName = 2;

			// Token: 0x0403734E RID: 226126
			public const int TextDesc = 3;

			// Token: 0x0403734F RID: 226127
			public const int TextureIcon = 4;

			// Token: 0x04037350 RID: 226128
			public const int NiagaraLock = 5;

			// Token: 0x04037351 RID: 226129
			public const int ItemLock = 6;

			// Token: 0x04037352 RID: 226130
			public const int NiagaraActive = 7;

			// Token: 0x04037353 RID: 226131
			public const int NiagaraTempActive = 8;

			// Token: 0x04037354 RID: 226132
			public const int ItemTempActive = 9;

			// Token: 0x04037355 RID: 226133
			public const int ItemActiveStateTag = 10;

			// Token: 0x04037356 RID: 226134
			public const int SpriteActiveStateBg = 11;

			// Token: 0x04037357 RID: 226135
			public const int TextActiveState = 12;
		}
	}
}
