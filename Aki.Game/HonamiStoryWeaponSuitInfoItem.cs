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

// Token: 0x02001F08 RID: 7944
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryWeaponSuitInfoItem : GridProxyAbstract<IHonamiStoryWeaponSuitData>
{
	// Token: 0x0600F4A4 RID: 62628 RVA: 0x003B059C File Offset: 0x003AE79C
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

	// Token: 0x0600F4A5 RID: 62629 RVA: 0x003B06AC File Offset: 0x003AE8AC
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

	// Token: 0x0600F4A6 RID: 62630 RVA: 0x003B06E8 File Offset: 0x003AE8E8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponSuitInfoItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponSuitInfoItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4A7 RID: 62631 RVA: 0x003B072C File Offset: 0x003AE92C
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

	// Token: 0x04007134 RID: 28980
	private HonamiStoryWeaponSuitActiveItem SuitActiveItem;

	// Token: 0x02008514 RID: 34068
	[NullableContext(0)]
	private enum EHonamiStoryWeaponSuitInfoItemComponent
	{
		// Token: 0x0402B4EE RID: 177390
		TitleText,
		// Token: 0x0402B4EF RID: 177391
		DescText,
		// Token: 0x0402B4F0 RID: 177392
		ActiveSprite,
		// Token: 0x0402B4F1 RID: 177393
		NonActiveSprite,
		// Token: 0x0402B4F2 RID: 177394
		TipSprite,
		// Token: 0x0402B4F3 RID: 177395
		SuitActiveItem,
		// Token: 0x0402B4F4 RID: 177396
		SuitNumText
	}
}
