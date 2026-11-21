using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000C10 RID: 3088
internal class SelectTargetItem : GridProxyAbstract<int>
{
	// Token: 0x060080C4 RID: 32964 RVA: 0x00277F94 File Offset: 0x00276194
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060080C5 RID: 32965 RVA: 0x00278014 File Offset: 0x00276214
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.FetterId = data;
		int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(this.FetterId);
		int monsterFindCountByMonsterIdArrayWithoutCost = PhantomBattleModel.Instance.GetMonsterFindCountByMonsterIdArrayWithoutCost4(fetterGroupMonsterIdArray);
		bool flag = this.FetterId == CalabashModel.Instance.DirectionalFusionTargetFetterGroup;
		if (monsterFindCountByMonsterIdArrayWithoutCost <= 0)
		{
			base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}
		else
		{
			base.GetExtendToggle(1).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, true, false, false);
		}
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(this.FetterId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fetterGroupById.FetterGroupName, Array.Empty<object>());
		base.SetTextureByPath(fetterGroupById.FetterElementPath, base.GetTexture(2), null, null);
	}

	// Token: 0x060080C6 RID: 32966 RVA: 0x002780D0 File Offset: 0x002762D0
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.FetterId, base.GetExtendToggle(1));
			return;
		}
		else
		{
			Action<int, UUIExtendToggle> onClickToggleCallBack2 = this.OnClickToggleCallBack;
			if (onClickToggleCallBack2 == null)
			{
				return;
			}
			onClickToggleCallBack2(0, base.GetExtendToggle(1));
			return;
		}
	}

	// Token: 0x04004F4C RID: 20300
	private int FetterId;

	// Token: 0x04004F4D RID: 20301
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x02006EC1 RID: 28353
	private enum ESelectTargetItem
	{
		// Token: 0x04024343 RID: 148291
		NameText,
		// Token: 0x04024344 RID: 148292
		Toggle,
		// Token: 0x04024345 RID: 148293
		Texture
	}
}
