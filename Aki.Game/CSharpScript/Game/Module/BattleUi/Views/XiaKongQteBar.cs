using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E2C RID: 24108
	[NullableContext(2)]
	[Nullable(0)]
	public class XiaKongQteBar : UiPanelBase
	{
		// Token: 0x0603D4FD RID: 251133 RVA: 0x00EC753C File Offset: 0x00EC573C
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

		// Token: 0x0603D4FE RID: 251134 RVA: 0x00EC75A5 File Offset: 0x00EC57A5
		[NullableContext(1)]
		public void Init(XiaKongQteSkillItem skillItem)
		{
			this.SkillItem = skillItem;
			this.SkillItem.SetEnable(this.ClickTipVisible);
		}

		// Token: 0x0603D4FF RID: 251135 RVA: 0x00EC75BF File Offset: 0x00EC57BF
		public void Refresh(SpecialSkillXiaKong specialSkill)
		{
			this.SpecialSkill = specialSkill;
		}

		// Token: 0x0603D500 RID: 251136 RVA: 0x00EC75C8 File Offset: 0x00EC57C8
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			base.GetTexture(1).SetFillAmount(1f);
			base.GetTexture(1).SetUIActive(false);
			this.ClickTipVisible = false;
		}

		// Token: 0x0603D501 RID: 251137 RVA: 0x00EC7600 File Offset: 0x00EC5800
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

		// Token: 0x0603D502 RID: 251138 RVA: 0x00EC7624 File Offset: 0x00EC5824
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

		// Token: 0x0603D503 RID: 251139 RVA: 0x00EC76B0 File Offset: 0x00EC58B0
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

		// Token: 0x0603D504 RID: 251140 RVA: 0x00EC76DC File Offset: 0x00EC58DC
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

		// Token: 0x0401FF9F RID: 130975
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401FFA0 RID: 130976
		private XiaKongQteSkillItem SkillItem;

		// Token: 0x0401FFA1 RID: 130977
		private SpecialSkillXiaKong SpecialSkill;

		// Token: 0x0401FFA2 RID: 130978
		private bool IsVisible = true;

		// Token: 0x0401FFA3 RID: 130979
		private bool ClickTipVisible;

		// Token: 0x0200C1AC RID: 49580
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A865 RID: 239717
			BarTexture,
			// Token: 0x0403A866 RID: 239718
			BarLightTexture
		}
	}
}
