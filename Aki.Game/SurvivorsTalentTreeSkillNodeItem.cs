using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020CE RID: 8398
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsTalentTreeSkillNodeItem : UiPanelBase
{
	// Token: 0x17001F04 RID: 7940
	// (get) Token: 0x06014A3A RID: 84538 RVA: 0x00603DB3 File Offset: 0x00601FB3
	public SurvivorsTalentNode Node
	{
		get
		{
			return this.NodeData;
		}
	}

	// Token: 0x06014A3B RID: 84539 RVA: 0x00603DBC File Offset: 0x00601FBC
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

	// Token: 0x06014A3C RID: 84540 RVA: 0x00603E94 File Offset: 0x00602094
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

	// Token: 0x06014A3D RID: 84541 RVA: 0x00603EE0 File Offset: 0x006020E0
	public UniTask RefreshNodeAsync()
	{
		SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsync>d__6 <RefreshNodeAsync>d__;
		<RefreshNodeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshNodeAsync>d__.<>4__this = this;
		<RefreshNodeAsync>d__.<>1__state = -1;
		<RefreshNodeAsync>d__.<>t__builder.Start<SurvivorsTalentTreeSkillNodeItem.<RefreshNodeAsync>d__6>(ref <RefreshNodeAsync>d__);
		return <RefreshNodeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A3E RID: 84542 RVA: 0x00603F23 File Offset: 0x00602123
	public void SelectNode()
	{
		this.OnClickToggle(EToggleState.ETT_Checked);
	}

	// Token: 0x06014A3F RID: 84543 RVA: 0x00603F2C File Offset: 0x0060212C
	private void OnClickToggle(EToggleState state)
	{
		Action<SurvivorsTalentNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.NodeData, base.GetExtendToggle(6));
	}

	// Token: 0x0400AFC4 RID: 44996
	private SurvivorsTalentNode NodeData;

	// Token: 0x0400AFC5 RID: 44997
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsTalentNode, UUIExtendToggle> OnClickToggleBack;
}
