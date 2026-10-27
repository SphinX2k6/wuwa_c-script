using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BC8 RID: 7112
public class DangoLikeItem : UiPanelBase
{
	// Token: 0x0600D41D RID: 54301 RVA: 0x0030D0EC File Offset: 0x0030B2EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D41E RID: 54302 RVA: 0x0030D1B3 File Offset: 0x0030B3B3
	private void OnClick()
	{
	}

	// Token: 0x0600D41F RID: 54303 RVA: 0x0030D1B8 File Offset: 0x0030B3B8
	public void Refresh(int playerId)
	{
		MatchTeamInfo matchTeamInfo = InstanceDungeonModel.Instance.GetMatchTeamInfo();
		int num = 0;
		if (matchTeamInfo != null)
		{
			foreach (MatchPlayerInfo matchPlayerInfo in matchTeamInfo.PlayerInfos)
			{
				if (matchPlayerInfo.PlayerId == playerId)
				{
					num = matchPlayerInfo.AbyssLikeCount;
					break;
				}
			}
		}
		base.GetText(1).SetText(num.ToString(), true);
	}

	// Token: 0x02008185 RID: 33157
	private enum ELikeComponent
	{
		// Token: 0x0402A42F RID: 173103
		LikeButton,
		// Token: 0x0402A430 RID: 173104
		LikeNumText,
		// Token: 0x0402A431 RID: 173105
		LikeIcon
	}
}
