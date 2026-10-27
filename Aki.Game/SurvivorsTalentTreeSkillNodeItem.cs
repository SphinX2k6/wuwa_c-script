using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B52 RID: 11090
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTalentTreeSkillNodeItem : UiPanelBase
{
	// Token: 0x17001EAC RID: 7852
	// (get) Token: 0x06017009 RID: 94217 RVA: 0x005D7247 File Offset: 0x005D5447
	public SurvivorsTalentNode Node
	{
		get
		{
			return this.NodeData;
		}
	}

	// Token: 0x0601700A RID: 94218 RVA: 0x005D7250 File Offset: 0x005D5450
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0601700B RID: 94219 RVA: 0x005D7328 File Offset: 0x005D5528
	public UniTask RefreshNodeAsyncByData(SurvivorsTalentNode talentNode)
	{
		SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsyncByData>d__5 <RefreshNodeAsyncByData>d__;
		<RefreshNodeAsyncByData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsyncByData>d__.<>4__this = this;
		<RefreshNodeAsyncByData>d__.talentNode = talentNode;
		<RefreshNodeAsyncByData>d__.<>1__state = -1;
		<RefreshNodeAsyncByData>d__.<>t__builder.Start<SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsyncByData>d__5>(ref <RefreshNodeAsyncByData>d__);
		return <RefreshNodeAsyncByData>d__.<>t__builder.Task;
	}

	// Token: 0x0601700C RID: 94220 RVA: 0x005D7374 File Offset: 0x005D5574
	public UniTask RefreshNodeAsync()
	{
		SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsync>d__6 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsync>d__6>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601700D RID: 94221 RVA: 0x005D73B7 File Offset: 0x005D55B7
	public void SelectNode()
	{
		this.OnClickToggle(EToggleState.ETT_Checked);
	}

	// Token: 0x0601700E RID: 94222 RVA: 0x005D73C0 File Offset: 0x005D55C0
	private void OnClickToggle(EToggleState state)
	{
		Action<SurvivorsTalentNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.NodeData, base.GetExtendToggle(6));
	}

	// Token: 0x0400ABBE RID: 43966
	private SurvivorsTalentNode NodeData;

	// Token: 0x0400ABBF RID: 43967
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsTalentNode, UUIExtendToggle> OnClickToggleBack;
}
