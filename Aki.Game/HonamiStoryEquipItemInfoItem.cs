using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001EF8 RID: 7928
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryEquipItemInfoItem : GridProxyAbstract<IHonamiStoryTipsBuffInfo>
{
	// Token: 0x0600F409 RID: 62473 RVA: 0x003ADD48 File Offset: 0x003ABF48
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

	// Token: 0x0600F40A RID: 62474 RVA: 0x003ADDFC File Offset: 0x003ABFFC
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

	// Token: 0x020084F5 RID: 34037
	internal enum EHonamiStoryEquipItemInfoItemComponent
	{
		// Token: 0x0402B449 RID: 177225
		TitleText,
		// Token: 0x0402B44A RID: 177226
		DescText,
		// Token: 0x0402B44B RID: 177227
		ActiveSprite,
		// Token: 0x0402B44C RID: 177228
		NonActiveSprite,
		// Token: 0x0402B44D RID: 177229
		TipSprite,
		// Token: 0x0402B44E RID: 177230
		SuitActiveItem,
		// Token: 0x0402B44F RID: 177231
		SuitNumText
	}
}
