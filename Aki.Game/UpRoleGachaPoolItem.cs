using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200114D RID: 4429
public class UpRoleGachaPoolItem : GachaPoolItem
{
	// Token: 0x0600B0AF RID: 45231 RVA: 0x00342CBE File Offset: 0x00340EBE
	public UpRoleGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600B0B0 RID: 45232 RVA: 0x00342CC8 File Offset: 0x00340EC8
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

	// Token: 0x0600B0B1 RID: 45233 RVA: 0x00342DB8 File Offset: 0x00340FB8
	protected override UniTask OnBeforeStartAsync()
	{
		UpRoleGachaPoolItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<UpRoleGachaPoolItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B0B2 RID: 45234 RVA: 0x00342DFC File Offset: 0x00340FFC
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

	// Token: 0x0600B0B3 RID: 45235 RVA: 0x00342FCF File Offset: 0x003411CF
	public void SetDescUiActive(bool bActive)
	{
		this.DescComponent.SetUiActive(bActive);
	}

	// Token: 0x040065FE RID: 26110
	[Nullable(2)]
	private RoleDescribeComponent DescComponent;

	// Token: 0x020073F0 RID: 29680
	private enum EComponent
	{
		// Token: 0x04025BE8 RID: 154600
		ContentTexture,
		// Token: 0x04025BE9 RID: 154601
		DescItem,
		// Token: 0x04025BEA RID: 154602
		ContentBgTexture,
		// Token: 0x04025BEB RID: 154603
		ThemeTextTexture,
		// Token: 0x04025BEC RID: 154604
		EffectPanel,
		// Token: 0x04025BED RID: 154605
		EffectNiagara
	}
}
