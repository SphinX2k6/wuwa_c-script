using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DEA RID: 3562
public class MediumItemGridRoleItemAddtionComponent : MediumItemGridComponent
{
	// Token: 0x17000FE5 RID: 4069
	// (get) Token: 0x06009099 RID: 37017 RVA: 0x002B5A06 File Offset: 0x002B3C06
	private static FColor ZeroCostColor
	{
		get
		{
			return FColor.FromHex("E2524C");
		}
	}

	// Token: 0x0600909A RID: 37018 RVA: 0x002B5A12 File Offset: 0x002B3C12
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "PnlRoleItemAddtion";
	}

	// Token: 0x0600909B RID: 37019 RVA: 0x002B5A1C File Offset: 0x002B3C1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600909C RID: 37020 RVA: 0x002B5A88 File Offset: 0x002B3C88
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridRoleItemAddtionComponent.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridRoleItemAddtionComponent.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600909D RID: 37021 RVA: 0x002B5ACC File Offset: 0x002B3CCC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		RoleItemAddtionData roleItemAddtionData = data as RoleItemAddtionData;
		if (roleItemAddtionData == null)
		{
			this.SetActive(false);
			return;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(roleItemAddtionData.IsTrial);
		}
		if (roleItemAddtionData.CostData != null)
		{
			MediumItemGridCostComponent costComponent = this.CostComponent;
			if (costComponent != null)
			{
				costComponent.Refresh(MediumItemGridRoleItemAddtionComponent.BuildCostData(roleItemAddtionData.CostData));
			}
		}
		else
		{
			MediumItemGridCostComponent costComponent2 = this.CostComponent;
			if (costComponent2 != null)
			{
				costComponent2.SetActive(false);
			}
		}
		this.SetActive(true);
	}

	// Token: 0x0600909E RID: 37022 RVA: 0x002B5B44 File Offset: 0x002B3D44
	[NullableContext(1)]
	private static MediumItemGridCostComponentData BuildCostData(MediumItemGridCostComponentData data)
	{
		if (data.Cost != 0)
		{
			return data;
		}
		return new MediumItemGridCostComponentData
		{
			Cost = data.Cost,
			Color = MediumItemGridRoleItemAddtionComponent.ZeroCostColor,
			Text = data.Text,
			BeforeCost = data.BeforeCost,
			BeforeColor = data.BeforeColor
		};
	}

	// Token: 0x040055EE RID: 21998
	[Nullable(2)]
	private MediumItemGridCostComponent CostComponent;

	// Token: 0x0200701D RID: 28701
	private class EChildType
	{
		// Token: 0x0402499F RID: 149919
		public const int Trial = 0;

		// Token: 0x040249A0 RID: 149920
		public const int CostAnchor = 1;
	}
}
