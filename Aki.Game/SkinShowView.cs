using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A38 RID: 10808
[NullableContext(2)]
[Nullable(0)]
public class SkinShowView : UiViewBase
{
	// Token: 0x06016819 RID: 92185 RVA: 0x005B4B49 File Offset: 0x005B2D49
	[NullableContext(1)]
	public SkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601681A RID: 92186 RVA: 0x005B4B54 File Offset: 0x005B2D54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBackBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickBackBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601681B RID: 92187 RVA: 0x005B4C80 File Offset: 0x005B2E80
	protected override void OnStart()
	{
		int itemId = (int)this.OpenParam;
		this.CurrentData = RoleSkinModel.Instance.GetRoleSkinData(itemId);
	}

	// Token: 0x0601681C RID: 92188 RVA: 0x005B4CAA File Offset: 0x005B2EAA
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0601681D RID: 92189 RVA: 0x005B4CB2 File Offset: 0x005B2EB2
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0601681E RID: 92190 RVA: 0x005B4CBB File Offset: 0x005B2EBB
	private void RefreshView()
	{
		if (this.CurrentData == null)
		{
			return;
		}
		this.RefreshRoleSpine(this.CurrentData).Forget();
		this.RefreshFrameTextureColor(this.CurrentData);
		this.RefreshFrameTextureColor2(this.CurrentData);
	}

	// Token: 0x0601681F RID: 92191 RVA: 0x005B4CF0 File Offset: 0x005B2EF0
	private UniTask RefreshRoleSpine(RoleSkinData data)
	{
		SkinShowView.<RefreshRoleSpine>d__8 <RefreshRoleSpine>d__;
		<RefreshRoleSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleSpine>d__.<>4__this = this;
		<RefreshRoleSpine>d__.data = data;
		<RefreshRoleSpine>d__.<>1__state = -1;
		<RefreshRoleSpine>d__.<>t__builder.Start<SkinShowView.<RefreshRoleSpine>d__8>(ref <RefreshRoleSpine>d__);
		return <RefreshRoleSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06016820 RID: 92192 RVA: 0x005B4D3C File Offset: 0x005B2F3C
	private void RefreshFrameTextureColor(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(2).SetUIActive(false);
			return;
		}
		base.GetTexture(2).SetUIActive(true);
		FColor color = FColor.FromHex(data.GetObtainFrameColor1());
		base.GetTexture(2).SetColor(color);
	}

	// Token: 0x06016821 RID: 92193 RVA: 0x005B4D80 File Offset: 0x005B2F80
	private void RefreshFrameTextureColor2(RoleSkinData data)
	{
		if (data == null)
		{
			base.GetTexture(3).SetUIActive(false);
			return;
		}
		base.GetTexture(3).SetUIActive(true);
		FColor color = FColor.FromHex(data.GetObtainFrameColor2());
		base.GetTexture(3).SetColor(color);
	}

	// Token: 0x0400A710 RID: 42768
	private RoleSkinData CurrentData;

	// Token: 0x0200907E RID: 36990
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402ED46 RID: 191814
		BackBtn,
		// Token: 0x0402ED47 RID: 191815
		RoleSpine,
		// Token: 0x0402ED48 RID: 191816
		FrameTexture1,
		// Token: 0x0402ED49 RID: 191817
		FrameTexture2,
		// Token: 0x0402ED4A RID: 191818
		CloseButton
	}
}
