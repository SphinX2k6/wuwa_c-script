using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200207C RID: 8316
public class CyberpunkLoadingView : LoadingViewBase
{
	// Token: 0x06010604 RID: 67076 RVA: 0x003FE4B4 File Offset: 0x003FC6B4
	[NullableContext(1)]
	public CyberpunkLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010605 RID: 67077 RVA: 0x003FE4D8 File Offset: 0x003FC6D8
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

	// Token: 0x06010606 RID: 67078 RVA: 0x003FE541 File Offset: 0x003FC741
	protected override void UpdateProgressRate(float rate)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(rate);
	}

	// Token: 0x06010607 RID: 67079 RVA: 0x003FE555 File Offset: 0x003FC755
	protected override void UpdateProgressValue(float value)
	{
	}

	// Token: 0x06010608 RID: 67080 RVA: 0x003FE557 File Offset: 0x003FC757
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.TickIconRotation(delta);
	}

	// Token: 0x06010609 RID: 67081 RVA: 0x003FE568 File Offset: 0x003FC768
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

	// Token: 0x040078F6 RID: 30966
	private const float ICON_ROTATION_SPEED = 90f;

	// Token: 0x040078F7 RID: 30967
	private float IconRotationAngle;

	// Token: 0x040078F8 RID: 30968
	[Nullable(1)]
	private readonly Rotator IconRotator = Rotator.Create(0f, 0f, 0f);

	// Token: 0x02008664 RID: 34404
	private class ECyberpunkLoadingDefine
	{
		// Token: 0x0402BB9A RID: 179098
		public const int TextureProgress = 0;

		// Token: 0x0402BB9B RID: 179099
		public const int SpriteIcon = 1;
	}
}
