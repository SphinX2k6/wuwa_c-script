using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001553 RID: 5459
public class RacingBetsLoadingView : LoadingViewBase
{
	// Token: 0x0600DA98 RID: 55960 RVA: 0x0040B375 File Offset: 0x00409575
	[NullableContext(1)]
	public RacingBetsLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DA99 RID: 55961 RVA: 0x0040B37E File Offset: 0x0040957E
	protected override void OnStart()
	{
		base.OnStart();
		UUIItem item = base.GetItem(1);
		this.FullSize = ((item != null) ? item.Width : 0f);
	}

	// Token: 0x0600DA9A RID: 55962 RVA: 0x0040B3A3 File Offset: 0x004095A3
	protected override void OnBeforeShow()
	{
		GameAudioController.Instance.UpdateLoadingType(new ELoadingPerform?(ELoadingPerform.Loading));
	}

	// Token: 0x0600DA9B RID: 55963 RVA: 0x0040B3B8 File Offset: 0x004095B8
	protected override void OnBeforeHide()
	{
		GameAudioController.Instance.UpdateLoadingType(null);
	}

	// Token: 0x0600DA9C RID: 55964 RVA: 0x0040B3D8 File Offset: 0x004095D8
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

	// Token: 0x0600DA9D RID: 55965 RVA: 0x0040B464 File Offset: 0x00409664
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

	// Token: 0x0600DA9E RID: 55966 RVA: 0x0040B494 File Offset: 0x00409694
	protected override void UpdateProgressValue(float value)
	{
	}

	// Token: 0x0600DA9F RID: 55967 RVA: 0x0040B496 File Offset: 0x00409696
	protected override void OnLevelSequencePlayerBandStateChange(bool state)
	{
		base.PlaySequence("Start01", null, false);
	}

	// Token: 0x040079E9 RID: 31209
	private float FullSize;

	// Token: 0x020077EF RID: 30703
	private class EChildType
	{
		// Token: 0x04026EBA RID: 159418
		public const int TextureProgress = 0;

		// Token: 0x04026EBB RID: 159419
		public const int ItemNiagaraRoot = 1;

		// Token: 0x04026EBC RID: 159420
		public const int NiagaraProgress = 2;
	}
}
