using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E11 RID: 19985
	[NullableContext(2)]
	[Nullable(0)]
	public class XiaKongQteBar : UiPanelBase
	{
		// Token: 0x0603248D RID: 205965 RVA: 0x00E18AA8 File Offset: 0x00E16CA8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603248E RID: 205966 RVA: 0x00E18B11 File Offset: 0x00E16D11
		[NullableContext(1)]
		public void Init(XiaKongQteSkillItem skillItem)
		{
			this.SkillItem = skillItem;
			this.SkillItem.SetEnable(this.ClickTipVisible);
		}

		// Token: 0x0603248F RID: 205967 RVA: 0x00E18B2B File Offset: 0x00E16D2B
		public void Refresh(SpecialSkillXiaKong specialSkill)
		{
			this.SpecialSkill = specialSkill;
		}

		// Token: 0x06032490 RID: 205968 RVA: 0x00E18B34 File Offset: 0x00E16D34
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetTexture(1).SetFillAmount(1f);
			base.GetTexture(1).SetUIActive(false);
			this.ClickTipVisible = false;
		}

		// Token: 0x06032491 RID: 205969 RVA: 0x00E18B6C File Offset: 0x00E16D6C
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.Clear();
				}
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x06032492 RID: 205970 RVA: 0x00E18B90 File Offset: 0x00E16D90
		public void Tick(float delta)
		{
			if (this.SpecialSkill == null)
			{
				return;
			}
			if (this.SpecialSkill.GetNextEndCircleIndex() >= this.SpecialSkill.GetNextGenCircleIndex())
			{
				this.SetVisible(false);
				return;
			}
			this.SetVisible(true);
			float num = this.SpecialSkill.GetNextEndCircleAttrValue(0) / this.SpecialSkill.GetMinAttrValue();
			if (num >= 1f)
			{
				this.SetClickTipVisible(true);
				return;
			}
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetFillAmount((num - 0.5f) / 0.5f);
			}
			this.SetClickTipVisible(false);
		}

		// Token: 0x06032493 RID: 205971 RVA: 0x00E18C1C File Offset: 0x00E16E1C
		private void SetVisible(bool visible)
		{
			if (this.IsVisible == visible)
			{
				return;
			}
			this.IsVisible = visible;
			this.SetActive(visible);
			XiaKongQteSkillItem skillItem = this.SkillItem;
			if (skillItem == null)
			{
				return;
			}
			skillItem.SetActive(visible);
		}

		// Token: 0x06032494 RID: 205972 RVA: 0x00E18C48 File Offset: 0x00E16E48
		private void SetClickTipVisible(bool visible)
		{
			if (this.ClickTipVisible == visible)
			{
				return;
			}
			this.ClickTipVisible = visible;
			base.GetTexture(1).SetUIActive(visible);
			XiaKongQteSkillItem skillItem = this.SkillItem;
			if (skillItem != null)
			{
				skillItem.SetEnable(visible);
			}
			if (visible)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayLevelSequenceByName("Full", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("Use", false, null, false);
				return;
			}
		}

		// Token: 0x0401AA66 RID: 109158
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AA67 RID: 109159
		private XiaKongQteSkillItem SkillItem;

		// Token: 0x0401AA68 RID: 109160
		private SpecialSkillXiaKong SpecialSkill;

		// Token: 0x0401AA69 RID: 109161
		private bool IsVisible = true;

		// Token: 0x0401AA6A RID: 109162
		private bool ClickTipVisible;

		// Token: 0x0200ABBB RID: 43963
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035257 RID: 217687
			BarTexture,
			// Token: 0x04035258 RID: 217688
			BarLightTexture
		}
	}
}
