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

// Token: 0x02001C3C RID: 7228
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FriendMultipleApplyItem : GridProxyAbstract<FriendApplyData>
{
	// Token: 0x0600D9BC RID: 55740 RVA: 0x00327F90 File Offset: 0x00326190
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

	// Token: 0x0600D9BD RID: 55741 RVA: 0x003280DD File Offset: 0x003262DD
	protected override void OnStart()
	{
		this.CountDownBar = base.GetSprite(3);
	}

	// Token: 0x0600D9BE RID: 55742 RVA: 0x003280EC File Offset: 0x003262EC
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

	// Token: 0x0600D9BF RID: 55743 RVA: 0x00328184 File Offset: 0x00326384
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

	// Token: 0x0600D9C0 RID: 55744 RVA: 0x003281F4 File Offset: 0x003263F4
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

	// Token: 0x0600D9C1 RID: 55745 RVA: 0x00328250 File Offset: 0x00326450
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

	// Token: 0x04006332 RID: 25394
	private FriendApplyData ApplyData;

	// Token: 0x04006333 RID: 25395
	private UUISprite CountDownBar;

	// Token: 0x02008200 RID: 33280
	[NullableContext(0)]
	private class EFriendMultipleApplyItem
	{
		// Token: 0x0402A6CB RID: 173771
		public const int PlayerName = 0;

		// Token: 0x0402A6CC RID: 173772
		public const int RoleHead = 1;

		// Token: 0x0402A6CD RID: 173773
		public const int Level = 2;

		// Token: 0x0402A6CE RID: 173774
		public const int CountDownProgressBar = 3;

		// Token: 0x0402A6CF RID: 173775
		public const int AgreeBtn = 4;

		// Token: 0x0402A6D0 RID: 173776
		public const int RefuseBtn = 5;
	}
}
