using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003E06 RID: 15878
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleAttrItem : GridProxyAbstract<AffixEntry>
	{
		// Token: 0x17005283 RID: 21123
		// (get) Token: 0x0602889A RID: 166042 RVA: 0x00B5F36C File Offset: 0x00B5D56C
		// (set) Token: 0x0602889B RID: 166043 RVA: 0x00B5F374 File Offset: 0x00B5D574
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x0602889C RID: 166044 RVA: 0x00B5F37D File Offset: 0x00B5D57D
		public override void Refresh(AffixEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x0602889D RID: 166045 RVA: 0x00B5F386 File Offset: 0x00B5D586
		public void Update(AffixEntry affixEntry)
		{
			this.AffixEntry = affixEntry;
			this.RefreshPanel();
		}

		// Token: 0x0602889E RID: 166046 RVA: 0x00B5F398 File Offset: 0x00B5D598
		public void SetSecondColor()
		{
			UUIText text = base.GetText(0);
			UUIItem uuiitem = text;
			bool bUseChangeColor = true;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0602889F RID: 166047 RVA: 0x00B5F3C4 File Offset: 0x00B5D5C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060288A0 RID: 166048 RVA: 0x00B5F40C File Offset: 0x00B5D60C
		public void RefreshPanel()
		{
			RogueCharacterBuff? rogueCharacterBuffConfig = RoguelikeConfig.Instance.GetRogueCharacterBuffConfig(this.AffixEntry.Id.Value);
			if (rogueCharacterBuffConfig == null)
			{
				return;
			}
			RoguelikeModel instance = RoguelikeModel.Instance;
			EDescModel? edescModel = (instance != null) ? new EDescModel?(instance.GetDescModel()) : null;
			EDescModel edescModel2 = EDescModel.SIMPLE;
			if (edescModel.GetValueOrDefault() == edescModel2 & edescModel != null)
			{
				base.GetText(0).ShowTextNew(rogueCharacterBuffConfig.Value.AffixDescSimple);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueCharacterBuffConfig.Value.AffixDesc, rogueCharacterBuffConfig.Value.AffixDescParam());
		}

		// Token: 0x02009A28 RID: 39464
		[NullableContext(0)]
		private class ERoleAttrItemCom
		{
			// Token: 0x040300ED RID: 196845
			public const int DescText = 0;
		}
	}
}
