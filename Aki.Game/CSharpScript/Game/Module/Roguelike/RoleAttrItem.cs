using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E3D RID: 20029
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleAttrItem : GridProxyAbstract<AffixEntry>
	{
		// Token: 0x17007ED3 RID: 32467
		// (get) Token: 0x06033A2F RID: 211503 RVA: 0x00C15E44 File Offset: 0x00C14044
		// (set) Token: 0x06033A30 RID: 211504 RVA: 0x00C15E4C File Offset: 0x00C1404C
		public AffixEntry AffixEntry { get; set; }

		// Token: 0x06033A31 RID: 211505 RVA: 0x00C15E55 File Offset: 0x00C14055
		public override void Refresh(AffixEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06033A32 RID: 211506 RVA: 0x00C15E5E File Offset: 0x00C1405E
		public void Update(AffixEntry affixEntry)
		{
			this.AffixEntry = affixEntry;
			this.RefreshPanel();
		}

		// Token: 0x06033A33 RID: 211507 RVA: 0x00C15E70 File Offset: 0x00C14070
		public void SetSecondColor()
		{
			UUIText text = base.GetText(0);
			UUIItem uuiitem = text;
			bool bUseChangeColor = true;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x06033A34 RID: 211508 RVA: 0x00C15E9C File Offset: 0x00C1409C
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

		// Token: 0x06033A35 RID: 211509 RVA: 0x00C15EE4 File Offset: 0x00C140E4
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

		// Token: 0x0200AFF6 RID: 45046
		[NullableContext(0)]
		private class ERoleAttrItemCom
		{
			// Token: 0x040356BD RID: 218813
			public const int DescText = 0;
		}
	}
}
