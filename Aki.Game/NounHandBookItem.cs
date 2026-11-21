using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012FC RID: 4860
[NullableContext(1)]
[Nullable(0)]
public class NounHandBookItem : UiPanelBase, IDynamicScrollItem<HandBookNounDynamicData>
{
	// Token: 0x0600BF55 RID: 48981 RVA: 0x00387EB0 File Offset: 0x003860B0
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

	// Token: 0x0600BF56 RID: 48982 RVA: 0x00387EFC File Offset: 0x003860FC
	private UniTask InitChildItem()
	{
		NounHandBookItem.<InitChildItem>d__5 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<NounHandBookItem.<InitChildItem>d__5>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF57 RID: 48983 RVA: 0x00387F40 File Offset: 0x00386140
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

	// Token: 0x0600BF58 RID: 48984 RVA: 0x00387F9A File Offset: 0x0038619A
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BF59 RID: 48985 RVA: 0x00387FA3 File Offset: 0x003861A3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BF5A RID: 48986 RVA: 0x00387FDC File Offset: 0x003861DC
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

	// Token: 0x0600BF5B RID: 48987 RVA: 0x003880B7 File Offset: 0x003862B7
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

	// Token: 0x0600BF5C RID: 48988 RVA: 0x003880DF File Offset: 0x003862DF
	public void BindChildToggleCallback(TChildNounToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
		if (this.HandBookNounDesItem != null)
		{
			this.HandBookNounDesItem.BindChildToggleCallback(toggleFunction);
		}
	}

	// Token: 0x0600BF5D RID: 48989 RVA: 0x003880FC File Offset: 0x003862FC
	public void BindToggleCallback(TNounToggleFunction toggleFunction)
	{
		this.OnToggleCallback = toggleFunction;
		if (this.HandBookNounToggleItem != null)
		{
			this.HandBookNounToggleItem.BindToggleCallback(toggleFunction);
		}
	}

	// Token: 0x04006DFF RID: 28159
	[Nullable(2)]
	private HandBookNounToggleItem HandBookNounToggleItem;

	// Token: 0x04006E00 RID: 28160
	[Nullable(2)]
	private HandBookNounDesItem HandBookNounDesItem;

	// Token: 0x04006E01 RID: 28161
	[Nullable(2)]
	private TNounToggleFunction OnToggleCallback;

	// Token: 0x04006E02 RID: 28162
	[Nullable(2)]
	private TChildNounToggleFunction OnChildToggleCallback;
}
