using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BC7 RID: 7111
[NullableContext(1)]
[Nullable(0)]
public class DangoItem_Tmp_E : UiPanelBase
{
	// Token: 0x0600D40E RID: 54286 RVA: 0x0030CB30 File Offset: 0x0030AD30
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnAddButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D40F RID: 54287 RVA: 0x0030CC7C File Offset: 0x0030AE7C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoItem_Tmp_E.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoItem_Tmp_E.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D410 RID: 54288 RVA: 0x0030CCC0 File Offset: 0x0030AEC0
	private void OnAddButtonClick()
	{
		if (this.CurrentData == null || !this.CurrentData.IfSelf)
		{
			return;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		DangoSelectViewData dangoSelectViewData = new DangoSelectViewData();
		dangoSelectViewData.Index = this.CurrentData.Index;
		dangoSelectViewData.RoleConfigId = this.CurrentData.RoleConfigId;
		dangoSelectViewData.GroupIndex = FormationModel.Instance.CurrentFormationId.GetValueOrDefault();
		AbyssDangoRoleData[] allDangoList = DangoAbyssModel.Instance.GetAllDangoList();
		dangoSelectViewData.CurrentSelectDangoId = allDangoList[0].GetId();
		if (this.CurrentData.DangoId != 0)
		{
			dangoSelectViewData.CurrentSelectDangoId = this.CurrentData.DangoId;
		}
		else
		{
			List<BattleRoleSlotData> allSlots = BattleTeamModel.Instance.GetAllSlots();
			int num = allDangoList.Length;
			int count = allSlots.Count;
			for (int i = 0; i < num; i++)
			{
				bool flag = false;
				for (int j = 0; j < count; j++)
				{
					int? roleConfigId = allSlots[j].RoleConfigId;
					if (roleConfigId != null)
					{
						int? num2 = roleConfigId;
						int num3 = 0;
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							AbyssDangoOwnerData roleOwnerData = DangoAbyssModel.Instance.GetRoleOwnerData(id.Value, roleConfigId.Value);
							num2 = ((roleOwnerData != null) ? new int?(roleOwnerData.DangoId) : null);
							num3 = allDangoList[i].GetId();
							if (num2.GetValueOrDefault() == num3 & num2 != null)
							{
								flag = true;
								break;
							}
						}
					}
				}
				if (!flag)
				{
					dangoSelectViewData.CurrentSelectDangoId = allDangoList[i].GetId();
					break;
				}
			}
		}
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssSelectDangoView, dangoSelectViewData, delegate(bool success, int viewId)
		{
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			if (uiViewBase == null)
			{
				return;
			}
			uiViewBase.AddChildViewById(viewId);
		});
	}

	// Token: 0x0600D411 RID: 54289 RVA: 0x0030CE85 File Offset: 0x0030B085
	protected override void OnStart()
	{
	}

	// Token: 0x0600D412 RID: 54290 RVA: 0x0030CE87 File Offset: 0x0030B087
	protected override void OnBeforeDestroy()
	{
		this.ClearRedDot();
	}

	// Token: 0x0600D413 RID: 54291 RVA: 0x0030CE8F File Offset: 0x0030B08F
	private void ClearRedDot()
	{
		if (this.RedDotBindState)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoFormation, base.GetItem(6), 0);
			this.RedDotBindState = false;
		}
	}

	// Token: 0x0600D414 RID: 54292 RVA: 0x0030CEB8 File Offset: 0x0030B0B8
	public void OnDangoInfoUpdate()
	{
		if (this.CurrentData == null)
		{
			return;
		}
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(this.CurrentData.DangoId);
		if (dangoAbyssRoleData == null)
		{
			return;
		}
		int[] equipItemConfigIdList = dangoAbyssRoleData.GetEquipItemConfigIdList();
		this.CurrentData.DangoEquipIds = equipItemConfigIdList;
		this.RefreshQuality(this.CurrentData);
	}

	// Token: 0x0600D415 RID: 54293 RVA: 0x0030CF07 File Offset: 0x0030B107
	public void OnLevelUp(int dangoId, int level)
	{
		if (this.CurrentData == null)
		{
			return;
		}
		if (dangoId == this.CurrentData.DangoId)
		{
			this.CurrentData.Level = level;
			this.RefreshLevel(this.CurrentData);
		}
	}

	// Token: 0x0600D416 RID: 54294 RVA: 0x0030CF38 File Offset: 0x0030B138
	[NullableContext(2)]
	public void Refresh(DangoItemData_Tmp data)
	{
		this.CurrentData = data;
		if (data == null)
		{
			return;
		}
		this.RefreshAddButtonState(data);
		this.RefreshAvatar(data);
		this.RefreshQuality(data);
		this.RefreshAvatarItem(data);
		this.RefreshLevel(data);
		this.ClearRedDot();
		if (data.IfSelf)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotDangoFormation, base.GetItem(6), null, 0);
			this.RedDotBindState = true;
			return;
		}
		base.GetItem(6).SetUIActive(false);
	}

	// Token: 0x0600D417 RID: 54295 RVA: 0x0030CFAE File Offset: 0x0030B1AE
	private void RefreshAvatarItem(DangoItemData_Tmp data)
	{
		if (data.DangoId == 0)
		{
			base.GetItem(1).SetUIActive(false);
			return;
		}
		base.GetItem(1).SetUIActive(true);
	}

	// Token: 0x0600D418 RID: 54296 RVA: 0x0030CFD4 File Offset: 0x0030B1D4
	private void RefreshAvatar(DangoItemData_Tmp data)
	{
		if (data.DangoId == 0)
		{
			base.GetTexture(3);
			return;
		}
		string formationIcon = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetFormationIcon();
		base.SetTextureByPath(formationIcon, base.GetTexture(3), null, null);
	}

	// Token: 0x0600D419 RID: 54297 RVA: 0x0030D020 File Offset: 0x0030B220
	private void RefreshQuality(DangoItemData_Tmp data)
	{
		DangoCircleQualityData dangoCircleQualityData = new DangoCircleQualityData();
		int[] dangoEquipIds = data.DangoEquipIds;
		int num = dangoEquipIds.Length;
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < num; i++)
		{
			dictionary[i] = dangoEquipIds[i];
		}
		dangoCircleQualityData.PluginIdMap = dictionary;
		this.DangoCircleQualityItem.RefreshData(dangoCircleQualityData);
		this.DangoCircleQualityItem.SetActive(true);
	}

	// Token: 0x0600D41A RID: 54298 RVA: 0x0030D080 File Offset: 0x0030B280
	private void RefreshLevel(DangoItemData_Tmp data)
	{
		if (data.DangoId == 0)
		{
			return;
		}
		int level = data.Level;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "AbyssDango_LV", new <>z__ReadOnlySingleElementList<object>(level.ToString()));
	}

	// Token: 0x0600D41B RID: 54299 RVA: 0x0030D0C0 File Offset: 0x0030B2C0
	private void RefreshAddButtonState(DangoItemData_Tmp data)
	{
		bool uiactive = data.DangoId == 0;
		base.GetItem(5).SetUIActive(uiactive);
	}

	// Token: 0x040060F9 RID: 24825
	[Nullable(2)]
	private DangoItemData_Tmp CurrentData;

	// Token: 0x040060FA RID: 24826
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x040060FB RID: 24827
	private bool RedDotBindState;

	// Token: 0x02008182 RID: 33154
	[NullableContext(0)]
	private enum EDangoComponent
	{
		// Token: 0x0402A421 RID: 173089
		QualityItem,
		// Token: 0x0402A422 RID: 173090
		AvatarItem,
		// Token: 0x0402A423 RID: 173091
		AddButton,
		// Token: 0x0402A424 RID: 173092
		AvatarTexture,
		// Token: 0x0402A425 RID: 173093
		LevelText,
		// Token: 0x0402A426 RID: 173094
		AddItem,
		// Token: 0x0402A427 RID: 173095
		RedDot
	}
}
