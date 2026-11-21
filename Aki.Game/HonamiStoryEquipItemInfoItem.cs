using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013BA RID: 5050
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryEquipItemInfoItem : GridProxyAbstract<IHonamiStoryTipsBuffInfo>
{
	// Token: 0x0600C828 RID: 51240 RVA: 0x003B983C File Offset: 0x003B7A3C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x0600C829 RID: 51241 RVA: 0x003B98F0 File Offset: 0x003B7AF0
	[NullableContext(1)]
	public override void Refresh(IHonamiStoryTipsBuffInfo buffInfo, bool isSelected, int gridIndex)
	{
		bool flag = true;
		HonamiStoryBuffTemp? honamiStoryBuffTemp = HonamiStoryConfig.Instance.GetHonamiStoryBuffTemp(buffInfo.BuffId);
		if (honamiStoryBuffTemp == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "HonamiStory_EquipEffect", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(honamiStoryBuffTemp.Value.Name, Array.Empty<object>())));
		UUIText text = base.GetText(0);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		bool flag2;
		if (buffInfo.FromTeamView)
		{
			flag2 = RoleModel.Instance.IsShowSkillResume;
		}
		else
		{
			flag2 = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.HonamiStorySkillDescMode, false);
		}
		string textStringId = (!flag2) ? honamiStoryBuffTemp.Value.Desc : honamiStoryBuffTemp.Value.DescSimple;
		string[] array = (!flag2) ? honamiStoryBuffTemp.Value.DescArgs() : honamiStoryBuffTemp.Value.DescSimpleArgs();
		if (array != null && array.Length != 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, array);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			UUIItem uuiitem2 = text2;
			bool bUseChangeColor2 = flag;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		}
		base.GetSprite(2).SetUIActive(flag);
		base.GetSprite(3).SetUIActive(!flag);
		base.GetItem(5).SetUIActive(false);
		base.GetText(6).SetUIActive(false);
	}

	// Token: 0x0200767A RID: 30330
	internal enum EHonamiStoryEquipItemInfoItemComponent
	{
		// Token: 0x0402676D RID: 157549
		TitleText,
		// Token: 0x0402676E RID: 157550
		DescText,
		// Token: 0x0402676F RID: 157551
		ActiveSprite,
		// Token: 0x04026770 RID: 157552
		NonActiveSprite,
		// Token: 0x04026771 RID: 157553
		TipSprite,
		// Token: 0x04026772 RID: 157554
		SuitActiveItem,
		// Token: 0x04026773 RID: 157555
		SuitNumText
	}
}
