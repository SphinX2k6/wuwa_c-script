using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200115B RID: 4443
public class ComBuffSubComponent : UiPanelBase
{
	// Token: 0x0600750A RID: 29962 RVA: 0x00180EA4 File Offset: 0x0017F0A4
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

	// Token: 0x0600750B RID: 29963 RVA: 0x00180F94 File Offset: 0x0017F194
	protected override UniTask OnBeforeStartAsync()
	{
		ComBuffSubComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ComBuffSubComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600750C RID: 29964 RVA: 0x00180FD7 File Offset: 0x0017F1D7
	protected override void OnStart()
	{
		base.SetUiActive(true);
	}

	// Token: 0x0600750D RID: 29965 RVA: 0x00180FE0 File Offset: 0x0017F1E0
	[NullableContext(2)]
	public UUIExtendToggle GetBuffToggle()
	{
		return base.GetExtendToggle(2);
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x00180FEC File Offset: 0x0017F1EC
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

	// Token: 0x0600750F RID: 29967 RVA: 0x00181020 File Offset: 0x0017F220
	public void SetToggleVisible(bool visible)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x0018104C File Offset: 0x0017F24C
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

	// Token: 0x06007511 RID: 29969 RVA: 0x00181078 File Offset: 0x0017F278
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

	// Token: 0x06007512 RID: 29970 RVA: 0x001810D2 File Offset: 0x0017F2D2
	public void SetLockActive(bool active)
	{
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(active);
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x001810E8 File Offset: 0x0017F2E8
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

	// Token: 0x040035D0 RID: 13776
	[Nullable(2)]
	private UiImageSettingModule ImageSettingModule;

	// Token: 0x02007720 RID: 30496
	private class EComBuffSubComponent
	{
		// Token: 0x040274B3 RID: 160947
		public const int Texture = 0;

		// Token: 0x040274B4 RID: 160948
		public const int BgSprite = 1;

		// Token: 0x040274B5 RID: 160949
		public const int Toggle = 2;

		// Token: 0x040274B6 RID: 160950
		public const int NiaItem = 3;

		// Token: 0x040274B7 RID: 160951
		public const int DailyItem = 4;

		// Token: 0x040274B8 RID: 160952
		public const int LockBtn = 5;
	}
}
