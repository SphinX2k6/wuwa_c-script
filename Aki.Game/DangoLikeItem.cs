using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001087 RID: 4231
public class DangoLikeItem : UiPanelBase
{
	// Token: 0x0600A82F RID: 43055 RVA: 0x00318260 File Offset: 0x00316460
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

	// Token: 0x0600A830 RID: 43056 RVA: 0x00318327 File Offset: 0x00316527
	private void OnClick()
	{
	}

	// Token: 0x0600A831 RID: 43057 RVA: 0x0031832C File Offset: 0x0031652C
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

	// Token: 0x02007313 RID: 29459
	private enum ELikeComponent
	{
		// Token: 0x04025763 RID: 153443
		LikeButton,
		// Token: 0x04025764 RID: 153444
		LikeNumText,
		// Token: 0x04025765 RID: 153445
		LikeIcon
	}
}
