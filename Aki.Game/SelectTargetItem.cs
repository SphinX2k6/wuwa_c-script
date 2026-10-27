using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001757 RID: 5975
internal class SelectTargetItem : GridProxyAbstract<int>
{
	// Token: 0x0600ACDD RID: 44253 RVA: 0x0026DB18 File Offset: 0x0026BD18
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

	// Token: 0x0600ACDE RID: 44254 RVA: 0x0026DB98 File Offset: 0x0026BD98
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

	// Token: 0x0600ACDF RID: 44255 RVA: 0x0026DC54 File Offset: 0x0026BE54
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

	// Token: 0x04004EA3 RID: 20131
	private int FetterId;

	// Token: 0x04004EA4 RID: 20132
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;

	// Token: 0x02007D3B RID: 32059
	private enum ESelectTargetItem
	{
		// Token: 0x04029018 RID: 167960
		NameText,
		// Token: 0x04029019 RID: 167961
		Toggle,
		// Token: 0x0402901A RID: 167962
		Texture
	}
}
