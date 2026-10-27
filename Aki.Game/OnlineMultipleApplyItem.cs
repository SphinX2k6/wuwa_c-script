using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020022F2 RID: 8946
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineMultipleApplyItem : GridProxyAbstract<OnlineApplyData>
{
	// Token: 0x06011A28 RID: 72232 RVA: 0x00454270 File Offset: 0x00452470
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

	// Token: 0x06011A29 RID: 72233 RVA: 0x004543BD File Offset: 0x004525BD
	protected override void OnStart()
	{
		this.CountDownBar = base.GetSprite(3);
	}

	// Token: 0x06011A2A RID: 72234 RVA: 0x004543CC File Offset: 0x004525CC
	[NullableContext(1)]
	public override void Refresh(OnlineApplyData data, bool isSelected, int gridIndex)
	{
		this.OnlineApplyData = data;
		PlayerHeadData playerHeadData = PersonalModel.Instance.GetPlayerHeadData(data.HeadId, false);
		if (playerHeadData != null)
		{
			base.SetTextureByPath(playerHeadData.GetRoleHeadIconCircle(), base.GetTexture(1), null, null);
		}
		base.GetText(0).SetText(data.Name, true);
		base.GetText(2).SetText(data.Level.ToString(), true);
	}

	// Token: 0x06011A2B RID: 72235 RVA: 0x00454440 File Offset: 0x00452640
	public void UpdateCountDownProgressBar()
	{
		if (this.OnlineApplyData == null)
		{
			return;
		}
		this.CountDownBar.SetFillAmount((float)this.OnlineApplyData.ApplyTimeLeftTime / (float)OnlineModel.Instance.ApplyCd);
		if (this.OnlineApplyData.ApplyTimeLeftTime <= 0.0 && OnlineModel.Instance.GetCurrentApplyListById(this.OnlineApplyData.PlayerId) != null)
		{
			OnlineModel.Instance.DeleteCurrentApplyListById(this.OnlineApplyData.PlayerId);
			EventSystem.Instance.Emit(EEventName.OnRefreshApply);
		}
	}

	// Token: 0x06011A2C RID: 72236 RVA: 0x004544CB File Offset: 0x004526CB
	private void OnClickAgreeBtn()
	{
		OnlineController.Instance.AgreeJoinResultRequest(this.OnlineApplyData.PlayerId, true);
	}

	// Token: 0x06011A2D RID: 72237 RVA: 0x004544E4 File Offset: 0x004526E4
	private void OnClickRefuseBtn()
	{
		OnlineController.Instance.AgreeJoinResultRequest(this.OnlineApplyData.PlayerId, false);
		if (OnlineModel.Instance.GetCurrentApplyListById(this.OnlineApplyData.PlayerId) != null)
		{
			OnlineModel.Instance.DeleteCurrentApplyListById(this.OnlineApplyData.PlayerId);
			EventSystem.Instance.Emit(EEventName.OnRefreshApply);
		}
	}

	// Token: 0x040085D2 RID: 34258
	private OnlineApplyData OnlineApplyData;

	// Token: 0x040085D3 RID: 34259
	private UUISprite CountDownBar;

	// Token: 0x02008872 RID: 34930
	[NullableContext(0)]
	private enum EOnlineMultipleApplyItem
	{
		// Token: 0x0402C57A RID: 181626
		PlayerName,
		// Token: 0x0402C57B RID: 181627
		RoleHead,
		// Token: 0x0402C57C RID: 181628
		Level,
		// Token: 0x0402C57D RID: 181629
		CountDownProgressBar,
		// Token: 0x0402C57E RID: 181630
		AgreeBtn,
		// Token: 0x0402C57F RID: 181631
		RefuseBtn
	}
}
