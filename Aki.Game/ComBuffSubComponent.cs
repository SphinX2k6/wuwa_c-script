using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200060F RID: 1551
public class ComBuffSubComponent : UiPanelBase
{
	// Token: 0x060048A1 RID: 18593 RVA: 0x001899D4 File Offset: 0x00187BD4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060048A2 RID: 18594 RVA: 0x00189AC4 File Offset: 0x00187CC4
	protected override UniTask OnBeforeStartAsync()
	{
		ComBuffSubComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ComBuffSubComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060048A3 RID: 18595 RVA: 0x00189B07 File Offset: 0x00187D07
	protected override void OnStart()
	{
		base.SetUiActive(true);
	}

	// Token: 0x060048A4 RID: 18596 RVA: 0x00189B10 File Offset: 0x00187D10
	[NullableContext(2)]
	public UUIExtendToggle GetBuffToggle()
	{
		return base.GetExtendToggle(2);
	}

	// Token: 0x060048A5 RID: 18597 RVA: 0x00189B1C File Offset: 0x00187D1C
	public override void SetActive(bool active)
	{
		base.SetUiActive(active);
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(active);
	}

	// Token: 0x060048A6 RID: 18598 RVA: 0x00189B50 File Offset: 0x00187D50
	public void SetToggleVisible(bool visible)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x060048A7 RID: 18599 RVA: 0x00189B7C File Offset: 0x00187D7C
	[NullableContext(1)]
	public void SetTextureByPath(string path)
	{
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		UiImageSettingModule imageSettingModule = this.ImageSettingModule;
		if (imageSettingModule == null)
		{
			return;
		}
		imageSettingModule.SetTextureByPathAsync(path, texture, null);
	}

	// Token: 0x060048A8 RID: 18600 RVA: 0x00189BA8 File Offset: 0x00187DA8
	public void UseChangeColor(bool use)
	{
		UUISprite sprite = base.GetSprite(1);
		FColor? fcolor;
		if (sprite != null)
		{
			fcolor = new FColor?(base.GetSprite(1).changeColor);
			sprite.SetChangeColor(use, fcolor);
		}
		UUITexture texture = base.GetTexture(0);
		if (texture == null)
		{
			return;
		}
		fcolor = new FColor?(base.GetTexture(0).changeColor);
		texture.SetChangeColor(use, fcolor);
	}

	// Token: 0x060048A9 RID: 18601 RVA: 0x00189C02 File Offset: 0x00187E02
	public void SetLockActive(bool active)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(active);
	}

	// Token: 0x060048AA RID: 18602 RVA: 0x00189C18 File Offset: 0x00187E18
	public void FlashHighlight()
	{
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}, 0.15f * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
	}

	// Token: 0x04003669 RID: 13929
	[Nullable(2)]
	private UiImageSettingModule ImageSettingModule;

	// Token: 0x020068AE RID: 26798
	private class EComBuffSubComponent
	{
		// Token: 0x040227F2 RID: 141298
		public const int Texture = 0;

		// Token: 0x040227F3 RID: 141299
		public const int BgSprite = 1;

		// Token: 0x040227F4 RID: 141300
		public const int Toggle = 2;

		// Token: 0x040227F5 RID: 141301
		public const int NiaItem = 3;

		// Token: 0x040227F6 RID: 141302
		public const int DailyItem = 4;

		// Token: 0x040227F7 RID: 141303
		public const int LockBtn = 5;
	}
}
