using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C8E RID: 7310
public class UpRoleGachaPoolItem : GachaPoolItem
{
	// Token: 0x0600DC99 RID: 56473 RVA: 0x0033779A File Offset: 0x0033599A
	public UpRoleGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600DC9A RID: 56474 RVA: 0x003377A4 File Offset: 0x003359A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DC9B RID: 56475 RVA: 0x00337894 File Offset: 0x00335A94
	protected override UniTask OnBeforeStartAsync()
	{
		UpRoleGachaPoolItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<UpRoleGachaPoolItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DC9C RID: 56476 RVA: 0x003378D8 File Offset: 0x00335AD8
	public override void Refresh()
	{
		if (this.GachaViewInfo == null)
		{
			return;
		}
		int gachaTextureInfoId = this.GachaViewInfo.Value.GetShowIdListArray()[0];
		this.DescComponent.Update(gachaTextureInfoId, this.GachaType.GetValueOrDefault() != GachaDefine.EGachaViewType.NewPlayerCustom);
		UUITexture contentTexture = base.GetTexture(0);
		base.SetTextureByPath(this.GachaViewInfo.Value.ContentTexturePath, contentTexture, null, delegate(bool _)
		{
			contentTexture.SetSizeFromTexture();
		});
		base.SetTextureByPath(this.GachaViewInfo.Value.TextTexture, base.GetTexture(3), null, null);
		UUITexture contentBgTexture = base.GetTexture(2);
		base.SetTextureByPath(this.GachaViewInfo.Value.ContentTextureBgPath, contentBgTexture, null, delegate(bool _)
		{
			contentBgTexture.SetSizeFromTexture();
		});
		bool flag = !StringUtils.IsBlank(this.GachaViewInfo.Value.EffectPath);
		base.GetItem(4).SetUIActive(flag);
		if (flag)
		{
			base.SetNiagaraSystemByPath(this.GachaViewInfo.Value.EffectPath, base.GetUiNiagara(5), null);
			if (this.GachaViewInfo.Value.EffectLocation != null)
			{
				base.GetItem(4).SetAnchorOffsetX(this.GachaViewInfo.Value.EffectLocation.Value.X);
				base.GetItem(4).SetAnchorOffsetY(this.GachaViewInfo.Value.EffectLocation.Value.Y);
			}
		}
	}

	// Token: 0x0600DC9D RID: 56477 RVA: 0x00337AAB File Offset: 0x00335CAB
	public void SetDescUiActive(bool bActive)
	{
		this.DescComponent.SetUiActive(bActive);
	}

	// Token: 0x0400652C RID: 25900
	[Nullable(2)]
	private RoleDescribeComponent DescComponent;

	// Token: 0x02008268 RID: 33384
	private enum EComponent
	{
		// Token: 0x0402A8C7 RID: 174279
		ContentTexture,
		// Token: 0x0402A8C8 RID: 174280
		DescItem,
		// Token: 0x0402A8C9 RID: 174281
		ContentBgTexture,
		// Token: 0x0402A8CA RID: 174282
		ThemeTextTexture,
		// Token: 0x0402A8CB RID: 174283
		EffectPanel,
		// Token: 0x0402A8CC RID: 174284
		EffectNiagara
	}
}
