using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154F RID: 5455
public class CyberpunkLoadingView : LoadingViewBase
{
	// Token: 0x0600DA6C RID: 55916 RVA: 0x0040A8FC File Offset: 0x00408AFC
	[NullableContext(1)]
	public CyberpunkLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DA6D RID: 55917 RVA: 0x0040A920 File Offset: 0x00408B20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DA6E RID: 55918 RVA: 0x0040A989 File Offset: 0x00408B89
	protected override void UpdateProgressRate(float rate)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(rate);
	}

	// Token: 0x0600DA6F RID: 55919 RVA: 0x0040A99D File Offset: 0x00408B9D
	protected override void UpdateProgressValue(float value)
	{
	}

	// Token: 0x0600DA70 RID: 55920 RVA: 0x0040A99F File Offset: 0x00408B9F
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.TickIconRotation(delta);
	}

	// Token: 0x0600DA71 RID: 55921 RVA: 0x0040A9B0 File Offset: 0x00408BB0
	private void TickIconRotation(float delta)
	{
		this.IconRotationAngle = (this.IconRotationAngle + 90f * delta / 1000f) % 360f;
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		this.IconRotator.Yaw = this.IconRotationAngle;
		UUIItem uuiitem = sprite;
		FRotator frotator = this.IconRotator.ToUeRotator();
		uuiitem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x040079DF RID: 31199
	private const float ICON_ROTATION_SPEED = 90f;

	// Token: 0x040079E0 RID: 31200
	private float IconRotationAngle;

	// Token: 0x040079E1 RID: 31201
	[Nullable(1)]
	private readonly Rotator IconRotator = Rotator.Create(0f, 0f, 0f);

	// Token: 0x020077EB RID: 30699
	private class ECyberpunkLoadingDefine
	{
		// Token: 0x04026EA9 RID: 159401
		public const int TextureProgress = 0;

		// Token: 0x04026EAA RID: 159402
		public const int SpriteIcon = 1;
	}
}
