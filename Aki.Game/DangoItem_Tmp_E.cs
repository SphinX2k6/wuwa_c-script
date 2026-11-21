using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001086 RID: 4230
[NullableContext(1)]
[Nullable(0)]
public class DangoItem_Tmp_E : UiPanelBase
{
	// Token: 0x0600A820 RID: 43040 RVA: 0x00317CA4 File Offset: 0x00315EA4
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

	// Token: 0x0600A821 RID: 43041 RVA: 0x00317DF0 File Offset: 0x00315FF0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoItem_Tmp_E.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoItem_Tmp_E.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A822 RID: 43042 RVA: 0x00317E34 File Offset: 0x00316034
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

	// Token: 0x0600A823 RID: 43043 RVA: 0x00317FF9 File Offset: 0x003161F9
	protected override void OnStart()
	{
	}

	// Token: 0x0600A824 RID: 43044 RVA: 0x00317FFB File Offset: 0x003161FB
	protected override void OnBeforeDestroy()
	{
		this.ClearRedDot();
	}

	// Token: 0x0600A825 RID: 43045 RVA: 0x00318003 File Offset: 0x00316203
	private void ClearRedDot()
	{
		if (this.RedDotBindState)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoFormation, base.GetItem(6), 0);
			this.RedDotBindState = false;
		}
	}

	// Token: 0x0600A826 RID: 43046 RVA: 0x0031802C File Offset: 0x0031622C
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

	// Token: 0x0600A827 RID: 43047 RVA: 0x0031807B File Offset: 0x0031627B
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

	// Token: 0x0600A828 RID: 43048 RVA: 0x003180AC File Offset: 0x003162AC
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

	// Token: 0x0600A829 RID: 43049 RVA: 0x00318122 File Offset: 0x00316322
	private void RefreshAvatarItem(DangoItemData_Tmp data)
	{
		if (data.DangoId == 0)
		{
			base.GetItem(1).SetUIActive(false);
			return;
		}
		base.GetItem(1).SetUIActive(true);
	}

	// Token: 0x0600A82A RID: 43050 RVA: 0x00318148 File Offset: 0x00316348
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

	// Token: 0x0600A82B RID: 43051 RVA: 0x00318194 File Offset: 0x00316394
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

	// Token: 0x0600A82C RID: 43052 RVA: 0x003181F4 File Offset: 0x003163F4
	private void RefreshLevel(DangoItemData_Tmp data)
	{
		if (data.DangoId == 0)
		{
			return;
		}
		int level = data.Level;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "AbyssDango_LV", new <>z__ReadOnlySingleElementList<object>(level.ToString()));
	}

	// Token: 0x0600A82D RID: 43053 RVA: 0x00318234 File Offset: 0x00316434
	private void RefreshAddButtonState(DangoItemData_Tmp data)
	{
		bool uiactive = data.DangoId == 0;
		base.GetItem(5).SetUIActive(uiactive);
	}

	// Token: 0x040061C8 RID: 25032
	[Nullable(2)]
	private DangoItemData_Tmp CurrentData;

	// Token: 0x040061C9 RID: 25033
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x040061CA RID: 25034
	private bool RedDotBindState;

	// Token: 0x02007310 RID: 29456
	[NullableContext(0)]
	private enum EDangoComponent
	{
		// Token: 0x04025755 RID: 153429
		QualityItem,
		// Token: 0x04025756 RID: 153430
		AvatarItem,
		// Token: 0x04025757 RID: 153431
		AddButton,
		// Token: 0x04025758 RID: 153432
		AvatarTexture,
		// Token: 0x04025759 RID: 153433
		LevelText,
		// Token: 0x0402575A RID: 153434
		AddItem,
		// Token: 0x0402575B RID: 153435
		RedDot
	}
}
