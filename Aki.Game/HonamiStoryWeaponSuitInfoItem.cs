using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.HonamiStory.Data;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013CA RID: 5066
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryWeaponSuitInfoItem : GridProxyAbstract<IHonamiStoryWeaponSuitData>
{
	// Token: 0x0600C8C3 RID: 51395 RVA: 0x003BC090 File Offset: 0x003BA290
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C8C4 RID: 51396 RVA: 0x003BC1A0 File Offset: 0x003BA3A0
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(1),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.HonamiStory
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600C8C5 RID: 51397 RVA: 0x003BC1DC File Offset: 0x003BA3DC
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponSuitInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponSuitInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8C6 RID: 51398 RVA: 0x003BC220 File Offset: 0x003BA420
	public override void Refresh(IHonamiStoryWeaponSuitData data, bool isSelected, int gridIndex)
	{
		int suitId = data.SuitId;
		HonamiStoryRoleEquipData equipData = data.EquipData;
		HonamiStoryWeaponSuitActiveData honamiStoryWeaponSuitActiveData = (equipData != null) ? equipData.IsSuitActivate(suitId, null) : null;
		CSharpScript.Game.Module.HonamiStory.Data.HonamiStoryWeaponSuitData weaponSuitData = HonamiStoryModel.Instance.GetWeaponSuitData(suitId);
		bool flag = honamiStoryWeaponSuitActiveData != null && honamiStoryWeaponSuitActiveData.IsActive;
		UUIText text = base.GetText(6);
		UUIText uuitext = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendLiteral("(");
		defaultInterpolatedStringHandler.AppendFormatted<int?>((honamiStoryWeaponSuitActiveData != null) ? new int?(honamiStoryWeaponSuitActiveData.CurCount) : null);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int?>((honamiStoryWeaponSuitActiveData != null) ? new int?(honamiStoryWeaponSuitActiveData.NeedCount) : null);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUIText text2 = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text2, weaponSuitData.Name, Array.Empty<object>());
		UUIItem uuiitem2 = text2;
		bool bUseChangeColor2 = flag;
		fcolor = new FColor?(text2.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		bool skillDescMode = HonamiStoryModel.Instance.GetSkillDescMode();
		string textStringId = skillDescMode ? weaponSuitData.DescSimple : weaponSuitData.Desc;
		string[] args = skillDescMode ? weaponSuitData.ArgsSimple : weaponSuitData.Args;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, args);
		UUIText text3 = base.GetText(1);
		UUIItem uuiitem3 = text3;
		bool bUseChangeColor3 = flag;
		fcolor = new FColor?(text3.changeColor);
		uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
		base.GetSprite(2).SetUIActive(flag);
		base.GetSprite(3).SetUIActive(!flag);
		base.GetSprite(4).SetUIActive(false);
		this.SuitActiveItem.Refresh(data);
	}

	// Token: 0x04007215 RID: 29205
	private HonamiStoryWeaponSuitActiveItem SuitActiveItem;

	// Token: 0x02007699 RID: 30361
	[NullableContext(0)]
	private enum EHonamiStoryWeaponSuitInfoItemComponent
	{
		// Token: 0x04026812 RID: 157714
		TitleText,
		// Token: 0x04026813 RID: 157715
		DescText,
		// Token: 0x04026814 RID: 157716
		ActiveSprite,
		// Token: 0x04026815 RID: 157717
		NonActiveSprite,
		// Token: 0x04026816 RID: 157718
		TipSprite,
		// Token: 0x04026817 RID: 157719
		SuitActiveItem,
		// Token: 0x04026818 RID: 157720
		SuitNumText
	}
}
