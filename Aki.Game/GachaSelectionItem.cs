using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C87 RID: 7303
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaSelectionItem : GridProxyAbstract<GachaPoolData>
{
	// Token: 0x0600DC57 RID: 56407 RVA: 0x00335DD8 File Offset: 0x00333FD8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnPreviewBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DC58 RID: 56408 RVA: 0x00335FAB File Offset: 0x003341AB
	private void OnToggleClick(EToggleState toggleState)
	{
		Action<int> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(base.GridIndex);
	}

	// Token: 0x0600DC59 RID: 56409 RVA: 0x00335FC4 File Offset: 0x003341C4
	private void OnPreviewBtnClick()
	{
		int itemId = this.PoolConfig.Value.ShowIdList()[0];
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId);
		if (this.IsRole)
		{
			List<int> roleIdList = new List<int>
			{
				gachaTextureInfo.Value.TrialId
			};
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, roleIdList, null, null);
			return;
		}
		WeaponTrialData weaponTrialData = new WeaponTrialData();
		weaponTrialData.SetTrialId(gachaTextureInfo.Value.TrialId, true);
		WeaponPreviewViewParam weaponPreviewViewParam = new WeaponPreviewViewParam();
		WeaponPreviewViewParam weaponPreviewViewParam2 = weaponPreviewViewParam;
		WeaponDataBase[] weaponDataList = new WeaponTrialData[]
		{
			weaponTrialData
		};
		weaponPreviewViewParam2.WeaponDataList = weaponDataList;
		weaponPreviewViewParam.SelectedIndex = 0;
		WeaponPreviewViewParam param = weaponPreviewViewParam;
		UiManager.Instance.OpenView(EUiViewName.WeaponPreviewView, param, null);
	}

	// Token: 0x0600DC5A RID: 56410 RVA: 0x0033608A File Offset: 0x0033428A
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(4));
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => this.CanToggleChange == null || this.CanToggleChange(base.GridIndex));
	}

	// Token: 0x0600DC5B RID: 56411 RVA: 0x003360C0 File Offset: 0x003342C0
	[NullableContext(1)]
	public override void Refresh(GachaPoolData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		ProtoGachaInfo gachaInfo = data.GachaInfo;
		int id = data.PoolInfo.Id;
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(gachaInfo.UsePoolId == id);
		}
		GachaViewInfo value = GachaConfig.Instance.GetGachaViewInfo(id).Value;
		this.PoolConfig = new GachaViewInfo?(value);
		int type = value.Type;
		this.IsRole = GachaModel.Instance.IsRolePool((GachaDefine.EGachaViewType)type);
		int itemId = value.ShowIdList()[0];
		base.SetTextureByPath(GachaConfig.Instance.GetGachaTextureInfo(itemId).Value.GachaResultViewTexture, base.GetTexture(1), null, null);
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(data.GachaInfo.GetPoolInfo(id).Title, true);
		}
		this.RefreshLeftTime(0f);
		if (this.IsRole)
		{
			this.HandleRole();
		}
		else
		{
			this.HandleWeapon();
		}
		if (isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		else
		{
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			return;
		}
	}

	// Token: 0x0600DC5C RID: 56412 RVA: 0x003361F3 File Offset: 0x003343F3
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600DC5D RID: 56413 RVA: 0x0033620B File Offset: 0x0033440B
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600DC5E RID: 56414 RVA: 0x00336224 File Offset: 0x00334424
	private void HandleRole()
	{
		int itemId = this.PoolConfig.Value.ShowIdList()[0];
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), roleInfoById.Value.Name, Array.Empty<object>());
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		string gachaElementTexturePath = GachaConfig.Instance.GetGachaElementTexturePath(roleInfoById.Value.ElementId);
		base.SetElementIcon(gachaElementTexturePath, base.GetTexture(3), roleInfoById.Value.ElementId, null);
		int qualityId = roleInfoById.Value.QualityId;
		SimpleGenericLayout starLayout = this.StarLayout;
		if (starLayout == null)
		{
			return;
		}
		starLayout.RebuildLayout(qualityId);
	}

	// Token: 0x0600DC5F RID: 56415 RVA: 0x003362F4 File Offset: 0x003344F4
	private void HandleWeapon()
	{
		GachaViewInfo value = this.PoolConfig.Value;
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		int configId = value.ShowIdList()[0];
		WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(configId);
		if (weaponItemConfig == null)
		{
			return;
		}
		GachaWeaponTransform? gachaWeaponTransformConfig = GachaConfig.Instance.GetGachaWeaponTransformConfig(weaponItemConfig.Value.WeaponType);
		FVector uiitemScale = new FVector(0.6f, 0.6f, 0.6f);
		base.GetTexture(3).SetUIItemScale(uiitemScale);
		base.SetTextureByPath(gachaWeaponTransformConfig.Value.WeaponTypeTexture, base.GetTexture(3), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), weaponItemConfig.Value.WeaponName, Array.Empty<object>());
		int qualityId = weaponItemConfig.Value.QualityId;
		SimpleGenericLayout starLayout = this.StarLayout;
		if (starLayout == null)
		{
			return;
		}
		starLayout.RebuildLayout(qualityId);
	}

	// Token: 0x0600DC60 RID: 56416 RVA: 0x003363F4 File Offset: 0x003345F4
	public void RefreshLeftTime(float delta)
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		UUIText text = base.GetText(6);
		ProtoGachaInfo gachaInfo = this.Data.GachaInfo;
		int id = this.Data.PoolInfo.Id;
		double poolEndTimeByPoolId = gachaInfo.GetPoolEndTimeByPoolId(id);
		if (poolEndTimeByPoolId == 0.0)
		{
			text.SetUIActive(false);
			return;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		double num = poolEndTimeByPoolId - serverTime;
		if (num <= 0.0)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(num);
		text.SetText(remainTimeDataFormat.CountDownText, true);
		double remainingTime = remainTimeDataFormat.RemainingTime;
		if (remainingTime > 0.0)
		{
			double num2 = remainingTime;
			this.TimerHandle = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.RefreshLeftTime), (float)(num2 * 1000.0), null, null, false, 1f);
		}
	}

	// Token: 0x0600DC61 RID: 56417 RVA: 0x003364F3 File Offset: 0x003346F3
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x04006514 RID: 25876
	private SimpleGenericLayout StarLayout;

	// Token: 0x04006515 RID: 25877
	private GachaPoolData Data;

	// Token: 0x04006516 RID: 25878
	private TimerHandle TimerHandle;

	// Token: 0x04006517 RID: 25879
	private GachaViewInfo? PoolConfig;

	// Token: 0x04006518 RID: 25880
	private bool IsRole;

	// Token: 0x04006519 RID: 25881
	public Action<int> ToggleCallBack;

	// Token: 0x0400651A RID: 25882
	public Func<int, bool> CanToggleChange;

	// Token: 0x0200825E RID: 33374
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A891 RID: 174225
		Toggle,
		// Token: 0x0402A892 RID: 174226
		MainTexture,
		// Token: 0x0402A893 RID: 174227
		ElementItem,
		// Token: 0x0402A894 RID: 174228
		ElementTexture,
		// Token: 0x0402A895 RID: 174229
		StarLayout,
		// Token: 0x0402A896 RID: 174230
		PoolTitleText,
		// Token: 0x0402A897 RID: 174231
		LeftTimeText,
		// Token: 0x0402A898 RID: 174232
		CardNameText,
		// Token: 0x0402A899 RID: 174233
		PreviewBtn,
		// Token: 0x0402A89A RID: 174234
		CurrentItem
	}
}
