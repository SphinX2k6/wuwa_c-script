using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.DreamLink;
using CSharpScript.Game.Module.SkipInterface;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200114C RID: 4428
[NullableContext(2)]
[Nullable(0)]
public class SpineRoleGachaPoolItem : GachaPoolItem
{
	// Token: 0x0600B0A6 RID: 45222 RVA: 0x00342947 File Offset: 0x00340B47
	public SpineRoleGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600B0A7 RID: 45223 RVA: 0x00342950 File Offset: 0x00340B50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B0A8 RID: 45224 RVA: 0x003429DC File Offset: 0x00340BDC
	protected override UniTask OnBeforeStartAsync()
	{
		SpineRoleGachaPoolItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpineRoleGachaPoolItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0A9 RID: 45225 RVA: 0x00342A20 File Offset: 0x00340C20
	private UniTask AddDesc()
	{
		SpineRoleGachaPoolItem.<AddDesc>d__5 <AddDesc>d__;
		<AddDesc>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddDesc>d__.<>4__this = this;
		<AddDesc>d__.<>1__state = -1;
		<AddDesc>d__.<>t__builder.Start<SpineRoleGachaPoolItem.<AddDesc>d__5>(ref <AddDesc>d__);
		return <AddDesc>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0AA RID: 45226 RVA: 0x00342A64 File Offset: 0x00340C64
	private UniTask AddButton()
	{
		SpineRoleGachaPoolItem.<AddButton>d__6 <AddButton>d__;
		<AddButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AddButton>d__.<>4__this = this;
		<AddButton>d__.<>1__state = -1;
		<AddButton>d__.<>t__builder.Start<SpineRoleGachaPoolItem.<AddButton>d__6>(ref <AddButton>d__);
		return <AddButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0AB RID: 45227 RVA: 0x00342AA8 File Offset: 0x00340CA8
	public override void Refresh()
	{
		if (this.GachaViewInfo == null)
		{
			return;
		}
		int gachaTextureInfoId = this.GachaViewInfo.Value.GetShowIdListArray()[0];
		this.DescComponent.Update(gachaTextureInfoId, this.GachaType.GetValueOrDefault() != GachaDefine.EGachaViewType.NewPlayerCustom);
		if (!StringUtils.IsBlank(this.GachaViewInfo.Value.TextTexture))
		{
			base.SetTextureByPath(this.GachaViewInfo.Value.TextTexture, base.GetTexture(1), null, null);
		}
		this.RefreshAnimation();
		bool flag = ActivityModel.Instance.IsActivityOpen(this.GachaViewInfo.Value.TrialActivityId);
		ButtonFunctionComponent buttonFunctionComponent = this.ButtonFunctionComponent;
		if (buttonFunctionComponent == null)
		{
			return;
		}
		buttonFunctionComponent.SetUiActive(this.GachaViewInfo.Value.JumpId > 0 || (this.GachaViewInfo.Value.TrialActivityId > 0 && flag));
	}

	// Token: 0x0600B0AC RID: 45228 RVA: 0x00342B9F File Offset: 0x00340D9F
	public void SetDescUiActive(bool bActive)
	{
		this.DescComponent.SetUiActive(bActive);
	}

	// Token: 0x0600B0AD RID: 45229 RVA: 0x00342BAD File Offset: 0x00340DAD
	public void RefreshAnimation()
	{
		base.GetSpine(2).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
	}

	// Token: 0x0600B0AE RID: 45230 RVA: 0x00342BD0 File Offset: 0x00340DD0
	private void OnSkipButtonClick()
	{
		if (this.GachaViewInfo.Value.JumpId > 0)
		{
			SkipTaskManager.RunByConfigId(this.GachaViewInfo.Value.JumpId, null);
			return;
		}
		if (!ActivityModel.Instance.IsActivityOpen(this.GachaViewInfo.Value.TrialActivityId))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_1100253_Text", Array.Empty<object>());
			return;
		}
		ActivityController.Instance.OpenActivityById(this.GachaViewInfo.Value.TrialActivityId, EActivityViewOpenType.Other, this.GachaViewInfo.Value.TrialRoleId, null);
		OnClickGachaTryRoleLogEvent onClickGachaTryRoleLogEvent = new OnClickGachaTryRoleLogEvent();
		onClickGachaTryRoleLogEvent.i_gacha_id = this.GachaViewInfo.Value.Id;
		onClickGachaTryRoleLogEvent.i_role_id = this.GachaViewInfo.Value.GetShowIdListArray()[0];
		LogReportController.Instance.LogReport(onClickGachaTryRoleLogEvent);
	}

	// Token: 0x040065FC RID: 26108
	private RoleDescribeComponent DescComponent;

	// Token: 0x040065FD RID: 26109
	private ButtonFunctionComponent ButtonFunctionComponent;
}
