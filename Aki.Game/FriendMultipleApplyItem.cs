using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010FB RID: 4347
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FriendMultipleApplyItem : GridProxyAbstract<FriendApplyData>
{
	// Token: 0x0600ADD2 RID: 44498 RVA: 0x00333390 File Offset: 0x00331590
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickAgreeBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRefuseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600ADD3 RID: 44499 RVA: 0x003334DD File Offset: 0x003316DD
	protected override void OnStart()
	{
		this.CountDownBar = base.GetSprite(3);
	}

	// Token: 0x0600ADD4 RID: 44500 RVA: 0x003334EC File Offset: 0x003316EC
	[NullableContext(1)]
	public override void Refresh(FriendApplyData data, bool isSelected, int gridIndex)
	{
		this.ApplyData = data;
		FriendData applyPlayerData = data.ApplyPlayerData;
		RoleInfo? roleInfo;
		string text = (RoleConfig.Instance.GetRoleConfig(applyPlayerData.PlayerHeadPhoto) != null) ? roleInfo.GetValueOrDefault().Card : null;
		if (!string.IsNullOrEmpty(text))
		{
			base.SetTextureByPath(text, base.GetTexture(1), null, null);
		}
		base.GetText(0).SetText(applyPlayerData.PlayerName, true);
		base.GetText(2).SetText(applyPlayerData.PlayerLevel.ToString(), true);
	}

	// Token: 0x0600ADD5 RID: 44501 RVA: 0x00333584 File Offset: 0x00331784
	public void UpdateCountDownProgressBar()
	{
		if (this.ApplyData == null)
		{
			return;
		}
		this.CountDownBar.SetFillAmount((float)(this.ApplyData.ApplyTimeLeftTime / (double)FriendModel.Instance.ApplyCdTime));
		if (this.ApplyData.ApplyTimeLeftTime <= 0.0)
		{
			EventSystem.Instance.Emit<int>(EEventName.FriendOnMultiItemAction, this.ApplyData.ApplyPlayerData.PlayerId);
		}
	}

	// Token: 0x0600ADD6 RID: 44502 RVA: 0x003335F4 File Offset: 0x003317F4
	private void OnClickAgreeBtn()
	{
		FriendController.Instance.RequestFriendApplyHandle(new List<int>
		{
			this.ApplyData.ApplyPlayerData.PlayerId
		}, FriendApplyOperator.Approve);
		if (this.ApplyData == null)
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.FriendOnMultiItemAction, this.ApplyData.ApplyPlayerData.PlayerId);
	}

	// Token: 0x0600ADD7 RID: 44503 RVA: 0x00333650 File Offset: 0x00331850
	private void OnClickRefuseBtn()
	{
		FriendController.Instance.RequestFriendApplyHandle(new List<int>
		{
			this.ApplyData.ApplyPlayerData.PlayerId
		}, FriendApplyOperator.Reject);
		if (this.ApplyData == null)
		{
			return;
		}
		EventSystem.Instance.Emit<int>(EEventName.FriendOnMultiItemAction, this.ApplyData.ApplyPlayerData.PlayerId);
	}

	// Token: 0x04006404 RID: 25604
	private FriendApplyData ApplyData;

	// Token: 0x04006405 RID: 25605
	private UUISprite CountDownBar;

	// Token: 0x02007389 RID: 29577
	[NullableContext(0)]
	private class EFriendMultipleApplyItem
	{
		// Token: 0x040259F2 RID: 154098
		public const int PlayerName = 0;

		// Token: 0x040259F3 RID: 154099
		public const int RoleHead = 1;

		// Token: 0x040259F4 RID: 154100
		public const int Level = 2;

		// Token: 0x040259F5 RID: 154101
		public const int CountDownProgressBar = 3;

		// Token: 0x040259F6 RID: 154102
		public const int AgreeBtn = 4;

		// Token: 0x040259F7 RID: 154103
		public const int RefuseBtn = 5;
	}
}
