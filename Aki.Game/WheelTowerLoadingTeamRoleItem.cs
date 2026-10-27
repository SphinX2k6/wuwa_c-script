using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001595 RID: 5525
public class WheelTowerLoadingTeamRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06009D77 RID: 40311 RVA: 0x00222454 File Offset: 0x00220654
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009D78 RID: 40312 RVA: 0x00222544 File Offset: 0x00220744
	public override void Refresh(int roleId, bool isSelected, int gridIndex)
	{
		int id = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
		if (roleDataById == null)
		{
			return;
		}
		bool flag = WheelTowerModel.Instance.IsTemplateRole(roleId);
		this.RoleDataBase = roleDataById;
		this.IsTemplateRole = flag;
		int num;
		if (flag)
		{
			TrialRoleInfo? trialRoleInfo;
			num = ((TrialRoleConfig.Instance.GetTrialRoleConfig(roleId) != null) ? trialRoleInfo.GetValueOrDefault().Level : 90);
		}
		else
		{
			num = roleDataById.GetLevelData().GetLevel();
		}
		RoleInfo roleConfig = roleDataById.GetRoleConfig();
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(roleConfig.ElementId);
		if (elementConfig != null)
		{
			base.SetTextureShowUntilLoaded(elementConfig.Value.Icon5, base.GetTexture(2), null);
		}
		int value = gridIndex + 1;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("T_WheelTowerLoadingTeamNum");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		string resourceId = defaultInterpolatedStringHandler.ToStringAndClear();
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Text_LevelShow_Text", new <>z__ReadOnlySingleElementList<object>(num));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleConfig.Name, Array.Empty<object>());
		int roleSkillBranchIndexInGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInGamePlay(roleId, ESkillBranchCacheType.WheeTowerLoading);
		FVector fvector = new FVector(0f, (float)((roleSkillBranchIndexInGamePlay == 0) ? 0 : 180), 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIRelativeRotation(frotator);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(roleSkillBranchIndexInGamePlay > -1);
	}

	// Token: 0x06009D79 RID: 40313 RVA: 0x002226F0 File Offset: 0x002208F0
	public UniTask RefreshRoleSkinAsync()
	{
		WheelTowerLoadingTeamRoleItem.<RefreshRoleSkinAsync>d__4 <RefreshRoleSkinAsync>d__;
		<RefreshRoleSkinAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleSkinAsync>d__.<>4__this = this;
		<RefreshRoleSkinAsync>d__.<>1__state = -1;
		<RefreshRoleSkinAsync>d__.<>t__builder.Start<WheelTowerLoadingTeamRoleItem.<RefreshRoleSkinAsync>d__4>(ref <RefreshRoleSkinAsync>d__);
		return <RefreshRoleSkinAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400454A RID: 17738
	[Nullable(2)]
	private RoleDataBase RoleDataBase;

	// Token: 0x0400454B RID: 17739
	private bool IsTemplateRole;
}
