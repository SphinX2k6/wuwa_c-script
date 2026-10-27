using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002080 RID: 8320
public class RacingBetsLoadingView : LoadingViewBase
{
	// Token: 0x06010630 RID: 67120 RVA: 0x003FEF2D File Offset: 0x003FD12D
	[NullableContext(1)]
	public RacingBetsLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010631 RID: 67121 RVA: 0x003FEF36 File Offset: 0x003FD136
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(1);
		this.FullSize = ((item != null) ? item.Width : 0f);
	}

	// Token: 0x06010632 RID: 67122 RVA: 0x003FEF5B File Offset: 0x003FD15B
	protected override void OnBeforeShow()
	{
		GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
	}

	// Token: 0x06010633 RID: 67123 RVA: 0x003FEF70 File Offset: 0x003FD170
	protected override void OnBeforeHide()
	{
		GameAudioController.Instance.UpdateLoadingType(null);
	}

	// Token: 0x06010634 RID: 67124 RVA: 0x003FEF90 File Offset: 0x003FD190
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06010635 RID: 67125 RVA: 0x003FF01C File Offset: 0x003FD21C
	protected override void UpdateProgressRate(float rate)
	{
		base.SetTextureProgressRate(0, rate);
		float anchorOffsetX = this.FullSize * rate;
		UUINiagara uiNiagara = base.GetUiNiagara(2);
		if (uiNiagara == null)
		{
			return;
		}
		uiNiagara.SetAnchorOffsetX(anchorOffsetX);
	}

	// Token: 0x06010636 RID: 67126 RVA: 0x003FF04C File Offset: 0x003FD24C
	protected override void UpdateProgressValue(float value)
	{
	}

	// Token: 0x06010637 RID: 67127 RVA: 0x003FF04E File Offset: 0x003FD24E
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start01", null, false);
	}

	// Token: 0x04007900 RID: 30976
	private float FullSize;

	// Token: 0x02008668 RID: 34408
	private class EChildType
	{
		// Token: 0x0402BBAB RID: 179115
		public const int TextureProgress = 0;

		// Token: 0x0402BBAC RID: 179116
		public const int ItemNiagaraRoot = 1;

		// Token: 0x0402BBAD RID: 179117
		public const int NiagaraProgress = 2;
	}
}
