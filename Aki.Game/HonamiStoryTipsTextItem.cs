using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EB6 RID: 7862
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HonamiStoryTipsTextItem : GridProxyAbstract<IHonamiStoryTipsBuffInfo>
{
	// Token: 0x0600F1C8 RID: 61896 RVA: 0x003A32A0 File Offset: 0x003A14A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600F1C9 RID: 61897 RVA: 0x003A333C File Offset: 0x003A153C
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

	// Token: 0x0600F1CA RID: 61898 RVA: 0x003A3378 File Offset: 0x003A1578
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryTipsTextItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryTipsTextItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1CB RID: 61899 RVA: 0x003A33BC File Offset: 0x003A15BC
	[NullableContext(1)]
	public override void Refresh(IHonamiStoryTipsBuffInfo info, bool isSelected, int gridIndex)
	{
		int buffId = info.BuffId;
		int? roleId = info.RoleId;
		HonamiStoryBuffTemp? honamiStoryBuffTemp = HonamiStoryConfig.Instance.GetHonamiStoryBuffTemp(buffId);
		if (roleId != null)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId.Value);
			string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "HonamiStory_TipsCharacterEffect", new <>z__ReadOnlySingleElementList<object>(roleName));
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			RoleModel instance = RoleModel.Instance;
			MainRoleConfig? mainRoleConfig = (instance != null) ? instance.GetCorrectMainRoleConfig(roleId.Value) : null;
			int id = (mainRoleConfig != null) ? mainRoleConfig.Value.Id : roleId.Value;
			this.RoleItem.Refresh(id);
		}
		else
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIText text3 = base.GetText(0);
			if (text3 != null)
			{
				text3.ShowTextNew(honamiStoryBuffTemp.Value.Name);
			}
			if (info.TagId != null)
			{
				HonamiStoryWeaponTagItem tagItem = this.TagItem;
				if (tagItem != null)
				{
					tagItem.SetUiActive(true);
				}
				this.TagItem.Refresh(info.TagId.Value, false, -1);
			}
			else
			{
				HonamiStoryWeaponTagItem tagItem2 = this.TagItem;
				if (tagItem2 != null)
				{
					tagItem2.SetUiActive(false);
				}
			}
		}
		bool skillDescMode = HonamiStoryModel.Instance.GetSkillDescMode();
		string textStringId = (!skillDescMode) ? honamiStoryBuffTemp.Value.Desc : honamiStoryBuffTemp.Value.DescSimple;
		string[] array = (!skillDescMode) ? honamiStoryBuffTemp.Value.DescArgs() : honamiStoryBuffTemp.Value.DescSimpleArgs();
		if (array != null && array.Length != 0)
		{
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i];
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, array2);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
	}

	// Token: 0x04006FC2 RID: 28610
	private HonamiStoryWeaponTagItem TagItem;

	// Token: 0x04006FC3 RID: 28611
	private HonamiStoryTipsRoleItem RoleItem;

	// Token: 0x02008492 RID: 33938
	[NullableContext(0)]
	private enum ETxt
	{
		// Token: 0x0402B275 RID: 176757
		TitleText,
		// Token: 0x0402B276 RID: 176758
		DescText,
		// Token: 0x0402B277 RID: 176759
		TabItem,
		// Token: 0x0402B278 RID: 176760
		TxtRole,
		// Token: 0x0402B279 RID: 176761
		PanelTitle,
		// Token: 0x0402B27A RID: 176762
		RoleItem
	}
}
