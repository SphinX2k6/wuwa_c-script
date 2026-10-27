using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200318F RID: 12687
[NullableContext(2)]
[Nullable(0)]
public class SpecialSkillBuling : SpecialSkillBase
{
	// Token: 0x0601B50A RID: 111882 RVA: 0x007750DF File Offset: 0x007732DF
	[NullableContext(1)]
	public SpecialSkillBuling(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B50B RID: 111883 RVA: 0x00775100 File Offset: 0x00773300
	public override void OnStart()
	{
		this.EntityRef = this.SpecialSkillComponent.Entity;
		this.AttributeComponent = this.EntityRef.GetComponent<BaseAttributeComponent>();
		this.TagComponent = this.EntityRef.GetComponent<RoleTagComponent>();
		this.ActorComponent = this.EntityRef.CheckGetComponent<CharacterActorComponent>();
		this.InitSpecialEnergy();
		CharacterActorComponent actorComponent = this.ActorComponent;
		if (actorComponent != null && actorComponent.IsRoleAndCtrlByMe)
		{
			if (this.AttributeComponent != null)
			{
				this.AttributeComponent.AddListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged), null);
				this.IsAddAttributeListener = true;
			}
			this.InitSlotEnergyTags();
			this.SetSpecialEnergyTag();
		}
	}

	// Token: 0x0601B50C RID: 111884 RVA: 0x007751A0 File Offset: 0x007733A0
	public override void OnEnd()
	{
		if (this.IsAddAttributeListener)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return;
			}
			attributeComponent.RemoveListener(EAttributeType.SpecialEnergy1, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
		}
	}

	// Token: 0x0601B50D RID: 111885 RVA: 0x007751CC File Offset: 0x007733CC
	private void InitSpecialEnergy()
	{
		this.SpecialEnergyTypeList.Clear();
		this.UiTagList.Clear();
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		int num = (int)((attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy1) : 0f);
		for (int i = 0; i < 4; i++)
		{
			int num2 = (4 - i - 1) * 2;
			int num3 = (num & 3 << num2) >> num2;
			this.UiTagList.Add(0);
			if (num3 > 0)
			{
				this.SpecialEnergyTypeList.Add(num3);
				int uiTag = this.GetUiTag(i, num3);
				if (uiTag != 0)
				{
					RoleTagComponent tagComponent = this.TagComponent;
					if (tagComponent != null)
					{
						tagComponent.AddTag(new int?(uiTag));
					}
				}
				this.UiTagList[i] = uiTag;
			}
		}
	}

	// Token: 0x0601B50E RID: 111886 RVA: 0x0077527C File Offset: 0x0077347C
	[NullableContext(1)]
	public void ModifySlotSpecialEnergy(int[] numberParams)
	{
		int? num = (numberParams.Length > 1) ? new int?(numberParams[1]) : null;
		if (num == null || !CharacterAttributeTypes.specialEnergyIds.Contains((EAttributeType)num.Value))
		{
			return;
		}
		int? num2 = (numberParams.Length > 2) ? new int?(numberParams[2]) : null;
		if (num2 == null || num2.Value < 0 || num2.Value >= 3)
		{
			return;
		}
		if (num2.Value == 0)
		{
			int removeNum = (numberParams.Length > 3) ? numberParams[3] : 1;
			this.RemoveSlotSpecialEnergy(num.Value, removeNum);
			return;
		}
		this.AddSlotSpecialEnergy(num.Value, num2.Value);
	}

	// Token: 0x0601B50F RID: 111887 RVA: 0x00775331 File Offset: 0x00773531
	public void AddSlotSpecialEnergy(int attributeId, int energyType)
	{
		if (this.SpecialEnergyTypeList.Count == 4)
		{
			this.SpecialEnergyTypeList.RemoveAt(0);
		}
		this.SpecialEnergyTypeList.Add(energyType);
		this.SetSpecialEnergyTag();
		this.SaveSpecialEnergy();
	}

	// Token: 0x0601B510 RID: 111888 RVA: 0x00775368 File Offset: 0x00773568
	public void RemoveSlotSpecialEnergy(int attributeId, int removeNum = 1)
	{
		for (int i = 0; i < removeNum; i++)
		{
			if (this.SpecialEnergyTypeList.Count > 0)
			{
				this.SpecialEnergyTypeList.RemoveAt(this.SpecialEnergyTypeList.Count - 1);
			}
		}
		this.SetSpecialEnergyTag();
		this.SaveSpecialEnergy();
	}

	// Token: 0x0601B511 RID: 111889 RVA: 0x007753B4 File Offset: 0x007735B4
	private void SaveSpecialEnergy()
	{
		int num = 0;
		foreach (int num2 in this.SpecialEnergyTypeList)
		{
			num <<= 2;
			num += num2;
		}
		BaseAttributeComponent attributeComponent = this.AttributeComponent;
		if (attributeComponent == null)
		{
			return;
		}
		attributeComponent.SetBaseValue(EAttributeType.SpecialEnergy1, (float)num);
	}

	// Token: 0x0601B512 RID: 111890 RVA: 0x00775420 File Offset: 0x00773620
	public int GetSpecialEnergyType(int index)
	{
		if (index < 0 || index >= this.SpecialEnergyTypeList.Count)
		{
			return 0;
		}
		return this.SpecialEnergyTypeList[index];
	}

	// Token: 0x0601B513 RID: 111891 RVA: 0x00775442 File Offset: 0x00773642
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		if (newValue == 0f && this.SpecialEnergyTypeList.Count != 0)
		{
			this.SpecialEnergyTypeList.Clear();
		}
	}

	// Token: 0x0601B514 RID: 111892 RVA: 0x00775464 File Offset: 0x00773664
	private void InitSlotEnergyTags()
	{
		if (this.SpecialEnergyTagMap != null)
		{
			return;
		}
		this.SpecialEnergyTagMap = new Dictionary<int, int>();
		int key = 6;
		this.SpecialEnergyTagMap[key] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.1AB"];
		int key2 = 9;
		this.SpecialEnergyTagMap[key2] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.2BA"];
		int key3 = 5;
		this.SpecialEnergyTagMap[key3] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.3AA"];
		int key4 = 10;
		this.SpecialEnergyTagMap[key4] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.4BB"];
		int key5 = 1;
		this.SpecialEnergyTagMap[key5] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.5A"];
		int key6 = 2;
		this.SpecialEnergyTagMap[key6] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.6B"];
		int key7 = 0;
		this.SpecialEnergyTagMap[key7] = GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.结算准备.空"];
	}

	// Token: 0x0601B515 RID: 111893 RVA: 0x00775558 File Offset: 0x00773758
	private int? GetSpecialEnergyTag()
	{
		if (this.SpecialEnergyTypeList.Count == 0)
		{
			Dictionary<int, int> specialEnergyTagMap = this.SpecialEnergyTagMap;
			if (specialEnergyTagMap == null)
			{
				return null;
			}
			return new int?(specialEnergyTagMap.GetValueOrDefault(0));
		}
		else if (this.SpecialEnergyTypeList.Count == 1)
		{
			Dictionary<int, int> specialEnergyTagMap2 = this.SpecialEnergyTagMap;
			if (specialEnergyTagMap2 == null)
			{
				return null;
			}
			return new int?(specialEnergyTagMap2.GetValueOrDefault(this.SpecialEnergyTypeList[0]));
		}
		else
		{
			int num = this.SpecialEnergyTypeList.Count - 1;
			int index = num - 1;
			int key = (this.SpecialEnergyTypeList[index] << 2) + this.SpecialEnergyTypeList[num];
			Dictionary<int, int> specialEnergyTagMap3 = this.SpecialEnergyTagMap;
			if (specialEnergyTagMap3 == null)
			{
				return null;
			}
			return new int?(specialEnergyTagMap3.GetValueOrDefault(key));
		}
	}

	// Token: 0x0601B516 RID: 111894 RVA: 0x00775618 File Offset: 0x00773818
	private void SetSpecialEnergyTag()
	{
		int? specialEnergyTag = this.GetSpecialEnergyTag();
		if ((specialEnergyTag == null && this.CurrentTag != null) || specialEnergyTag != null)
		{
			RoleTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTag(this.CurrentTag);
			}
			this.CurrentTag = null;
		}
		if (specialEnergyTag != null)
		{
			RoleTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.AddTag(new int?(specialEnergyTag.Value));
			}
			this.CurrentTag = new int?(specialEnergyTag.Value);
		}
		for (int i = 0; i < 4; i++)
		{
			int num = this.UiTagList[i];
			int uiTag = this.GetUiTag(i, (i < this.SpecialEnergyTypeList.Count) ? this.SpecialEnergyTypeList[i] : 0);
			if (num == 0 || num != uiTag)
			{
				if (num != 0)
				{
					RoleTagComponent tagComponent3 = this.TagComponent;
					if (tagComponent3 != null)
					{
						tagComponent3.RemoveTag(new int?(num));
					}
				}
				if (uiTag != 0)
				{
					RoleTagComponent tagComponent4 = this.TagComponent;
					if (tagComponent4 != null)
					{
						tagComponent4.AddTag(new int?(uiTag));
					}
				}
				this.UiTagList[i] = uiTag;
			}
		}
	}

	// Token: 0x0601B517 RID: 111895 RVA: 0x00775734 File Offset: 0x00773934
	private int GetUiTag(int index, int energyType)
	{
		if (energyType == 1)
		{
			switch (index)
			{
			case 0:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A1"];
			case 1:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A2"];
			case 2:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A3"];
			case 3:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.A4"];
			}
		}
		else if (energyType == 2)
		{
			switch (index)
			{
			case 0:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B1"];
			case 1:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B2"];
			case 2:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B3"];
			case 3:
				return GameplayTagDefine.EGameplayTagId["角色.BulingMd10011.卦象.UI标识.B4"];
			}
		}
		return 0;
	}

	// Token: 0x0400D586 RID: 54662
	private const int SLOT_COUNT = 4;

	// Token: 0x0400D587 RID: 54663
	private const int SLOT_BITS = 2;

	// Token: 0x0400D588 RID: 54664
	private const int SLOT_MASK = 3;

	// Token: 0x0400D589 RID: 54665
	private const EAttributeType slotSpecialEnergyType = EAttributeType.SpecialEnergy1;

	// Token: 0x0400D58A RID: 54666
	private Entity EntityRef;

	// Token: 0x0400D58B RID: 54667
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400D58C RID: 54668
	private RoleTagComponent TagComponent;

	// Token: 0x0400D58D RID: 54669
	private CharacterActorComponent ActorComponent;

	// Token: 0x0400D58E RID: 54670
	[Nullable(1)]
	private readonly List<int> SpecialEnergyTypeList = new List<int>();

	// Token: 0x0400D58F RID: 54671
	private Dictionary<int, int> SpecialEnergyTagMap;

	// Token: 0x0400D590 RID: 54672
	private bool IsAddAttributeListener;

	// Token: 0x0400D591 RID: 54673
	private int? CurrentTag;

	// Token: 0x0400D592 RID: 54674
	[Nullable(1)]
	private readonly List<int> UiTagList = new List<int>();

	// Token: 0x020096E5 RID: 38629
	[NullableContext(0)]
	private enum ESlotEnergyType
	{
		// Token: 0x04030566 RID: 197990
		Empty,
		// Token: 0x04030567 RID: 197991
		EnergyA,
		// Token: 0x04030568 RID: 197992
		EnergyB,
		// Token: 0x04030569 RID: 197993
		Max
	}
}
