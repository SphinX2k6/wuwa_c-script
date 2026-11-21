using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020017D6 RID: 6102
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineMultipleApplyItem : GridProxyAbstract<OnlineApplyData>
{
	// Token: 0x0600EEC0 RID: 61120 RVA: 0x00460F3C File Offset: 0x0045F13C
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

	// Token: 0x0600EEC1 RID: 61121 RVA: 0x00461089 File Offset: 0x0045F289
	protected override void OnStart()
	{
		this.CountDownBar = base.GetSprite(3);
	}

	// Token: 0x0600EEC2 RID: 61122 RVA: 0x00461098 File Offset: 0x0045F298
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

	// Token: 0x0600EEC3 RID: 61123 RVA: 0x0046110C File Offset: 0x0045F30C
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

	// Token: 0x0600EEC4 RID: 61124 RVA: 0x00461197 File Offset: 0x0045F397
	private void OnClickAgreeBtn()
	{
		OnlineController.Instance.AgreeJoinResultRequest(this.OnlineApplyData.PlayerId, true);
	}

	// Token: 0x0600EEC5 RID: 61125 RVA: 0x004611B0 File Offset: 0x0045F3B0
	private void OnClickRefuseBtn()
	{
		OnlineController.Instance.AgreeJoinResultRequest(this.OnlineApplyData.PlayerId, false);
		if (OnlineModel.Instance.GetCurrentApplyListById(this.OnlineApplyData.PlayerId) != null)
		{
			OnlineModel.Instance.DeleteCurrentApplyListById(this.OnlineApplyData.PlayerId);
			EventSystem.Instance.Emit(EEventName.OnRefreshApply);
		}
	}

	// Token: 0x04008710 RID: 34576
	private OnlineApplyData OnlineApplyData;

	// Token: 0x04008711 RID: 34577
	private UUISprite CountDownBar;

	// Token: 0x020079F6 RID: 31222
	[NullableContext(0)]
	private enum EOnlineMultipleApplyItem
	{
		// Token: 0x0402787C RID: 161916
		PlayerName,
		// Token: 0x0402787D RID: 161917
		RoleHead,
		// Token: 0x0402787E RID: 161918
		Level,
		// Token: 0x0402787F RID: 161919
		CountDownProgressBar,
		// Token: 0x04027880 RID: 161920
		AgreeBtn,
		// Token: 0x04027881 RID: 161921
		RefuseBtn
	}
}
