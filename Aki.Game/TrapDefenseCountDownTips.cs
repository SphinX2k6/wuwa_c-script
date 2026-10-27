using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D44 RID: 7492
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseCountDownTips : UiTickViewBase
{
	// Token: 0x0600E337 RID: 58167 RVA: 0x00356363 File Offset: 0x00354563
	public TrapDefenseCountDownTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E338 RID: 58168 RVA: 0x00356373 File Offset: 0x00354573
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara))
		};
	}

	// Token: 0x0600E339 RID: 58169 RVA: 0x003563AC File Offset: 0x003545AC
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Data = (this.OpenParam as ITrapDefenseCountDownTipsData);
		this.CountDownTime = this.Data.CountDownTime * (float)TimeUtil.Instance.InverseMillisecond;
		this.ShowTextNum = this.Data.CountDownTime;
		this.Niagara = base.GetUiNiagara(1);
		this.SetCountDownText(this.ShowTextNum);
	}

	// Token: 0x0600E33A RID: 58170 RVA: 0x00356424 File Offset: 0x00354624
	protected override void OnBeforeDestroy()
	{
		this.Sequence.Clear();
		ITrapDefenseCountDownTipsData data = this.Data;
		Action action = (data != null) ? data.Callback : null;
		if (action != null)
		{
			action();
		}
	}

	// Token: 0x0600E33B RID: 58171 RVA: 0x00356458 File Offset: 0x00354658
	protected override void OnTick(float deltaTime)
	{
		if (!this.CanTick)
		{
			return;
		}
		this.CountDownTime -= deltaTime;
		if (this.CountDownTime <= 0f)
		{
			this.CanTick = false;
			base.CloseMe(null);
			return;
		}
		if (this.ShowTextNum - (float)((int)(this.CountDownTime / (float)TimeUtil.Instance.InverseMillisecond)) >= 1f)
		{
			this.ShowTextNum -= 1f;
			this.SetCountDownText(this.ShowTextNum);
		}
	}

	// Token: 0x0600E33C RID: 58172 RVA: 0x003564D8 File Offset: 0x003546D8
	private void SetCountDownText(float num)
	{
		this.Niagara.SetNiagaraVarInt("Number_Start Frame", (int)(num - 1f));
		this.Niagara.SetNiagaraVarInt("Number_End Frame", (int)num);
		UUIArtText artText = base.GetArtText(0);
		if (artText != null)
		{
			artText.SetText(num.ToString());
		}
		this.Sequence.PlaySequencePurely("Change", false, false);
	}

	// Token: 0x040068EA RID: 26858
	[Nullable(2)]
	protected ITrapDefenseCountDownTipsData Data;

	// Token: 0x040068EB RID: 26859
	private float CountDownTime;

	// Token: 0x040068EC RID: 26860
	private float ShowTextNum;

	// Token: 0x040068ED RID: 26861
	private bool CanTick = true;

	// Token: 0x040068EE RID: 26862
	private UUINiagara Niagara;

	// Token: 0x040068EF RID: 26863
	private UiSequencePlayer Sequence;

	// Token: 0x02008355 RID: 33621
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AD17 RID: 175383
		public const int CountDownText = 0;

		// Token: 0x0402AD18 RID: 175384
		public const int Niagara = 1;
	}
}
