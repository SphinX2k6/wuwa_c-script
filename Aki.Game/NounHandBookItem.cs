using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E3A RID: 7738
[NullableContext(1)]
[Nullable(0)]
public class NounHandBookItem : UiPanelBase, IDynamicScrollItem<HandBookNounDynamicData>
{
	// Token: 0x0600EB36 RID: 60214 RVA: 0x0037C210 File Offset: 0x0037A410
	public UniTask Init(UUIItem actor)
	{
		NounHandBookItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<NounHandBookItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB37 RID: 60215 RVA: 0x0037C25C File Offset: 0x0037A45C
	private UniTask InitChildItem()
	{
		NounHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<NounHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB38 RID: 60216 RVA: 0x0037C2A0 File Offset: 0x0037A4A0
	public AUIBaseActor GetUsingItem(HandBookNounDynamicData data)
	{
		if (data.HandBookNounConfigId != null)
		{
			int? handBookNounConfigId = data.HandBookNounConfigId;
			int num = 0;
			if (!(handBookNounConfigId.GetValueOrDefault() == num & handBookNounConfigId != null))
			{
				return base.GetItem(1).GetOwner() as AUIBaseActor;
			}
		}
		return base.GetItem(0).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600EB39 RID: 60217 RVA: 0x0037C2FA File Offset: 0x0037A4FA
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600EB3A RID: 60218 RVA: 0x0037C303 File Offset: 0x0037A503
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EB3B RID: 60219 RVA: 0x0037C33C File Offset: 0x0037A53C
	public void Update(HandBookNounDynamicData data, int gridIndex)
	{
		if (this.HandBookNounDesItem != null)
		{
			this.HandBookNounDesItem.SetUiActive(false);
		}
		if (this.HandBookNounToggleItem != null)
		{
			this.HandBookNounToggleItem.SetUiActive(false);
		}
		if (this.RootItem != null)
		{
			this.RootItem.SetAlpha(1f);
		}
		if (data.HandBookNounConfigId != null)
		{
			int? handBookNounConfigId = data.HandBookNounConfigId;
			int num = 0;
			if (!(handBookNounConfigId.GetValueOrDefault() == num & handBookNounConfigId != null))
			{
				if (this.HandBookNounDesItem != null)
				{
					this.HandBookNounDesItem.SetUiActive(true);
					this.HandBookNounDesItem.Refresh(data.HandBookNounConfigId.Value, data.IsShowContent);
					return;
				}
				return;
			}
		}
		if (data.HandBookCommonItemData != null && this.HandBookNounToggleItem != null)
		{
			this.HandBookNounToggleItem.SetUiActive(true);
			this.HandBookNounToggleItem.Refresh(data.HandBookCommonItemData, data.IsShowContent);
		}
	}

	// Token: 0x0600EB3C RID: 60220 RVA: 0x0037C417 File Offset: 0x0037A617
	public void RefreshNewState()
	{
		if (this.HandBookNounToggleItem != null)
		{
			this.HandBookNounToggleItem.RefreshNewState();
		}
		if (this.HandBookNounDesItem != null)
		{
			this.HandBookNounDesItem.RefreshNewState();
		}
	}

	// Token: 0x0600EB3D RID: 60221 RVA: 0x0037C43F File Offset: 0x0037A63F
	public void BindChildToggleCallback(TChildNounToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
		if (this.HandBookNounDesItem != null)
		{
			this.HandBookNounDesItem.BindChildToggleCallback(toggleFunction);
		}
	}

	// Token: 0x0600EB3E RID: 60222 RVA: 0x0037C45C File Offset: 0x0037A65C
	public void BindToggleCallback(TNounToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
		if (this.HandBookNounToggleItem != null)
		{
			this.HandBookNounToggleItem.BindToggleCallback(toggleFunction);
		}
	}

	// Token: 0x04006D1E RID: 27934
	[Nullable(2)]
	private HandBookNounToggleItem HandBookNounToggleItem;

	// Token: 0x04006D1F RID: 27935
	[Nullable(2)]
	private HandBookNounDesItem HandBookNounDesItem;

	// Token: 0x04006D20 RID: 27936
	[Nullable(2)]
	private TNounToggleFunction OnToggleCallback;

	// Token: 0x04006D21 RID: 27937
	[Nullable(2)]
	private TChildNounToggleFunction OnChildToggleCallback;
}
