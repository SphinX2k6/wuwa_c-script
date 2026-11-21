using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001206 RID: 4614
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseCountDownTips : UiTickViewBase
{
	// Token: 0x0600B754 RID: 46932 RVA: 0x00361D93 File Offset: 0x0035FF93
	public TrapDefenseCountDownTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B755 RID: 46933 RVA: 0x00361DA3 File Offset: 0x0035FFA3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIArtText)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara))
		};
	}

	// Token: 0x0600B756 RID: 46934 RVA: 0x00361DDC File Offset: 0x0035FFDC
	protected override void OnStart()
	{
		this.Sequence = new UiSequencePlayer(base.GetRootItem());
		this.Data = (this.OpenParam as ITrapDefenseCountDownTipsData);
		this.CountDownTime = this.Data.CountDownTime * (float)TimeUtil.Instance.InverseMillisecond;
		this.ShowTextNum = this.Data.CountDownTime;
		this.Niagara = base.GetUiNiagara(1);
		this.SetCountDownText(this.ShowTextNum);
	}

	// Token: 0x0600B757 RID: 46935 RVA: 0x00361E54 File Offset: 0x00360054
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

	// Token: 0x0600B758 RID: 46936 RVA: 0x00361E88 File Offset: 0x00360088
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

	// Token: 0x0600B759 RID: 46937 RVA: 0x00361F08 File Offset: 0x00360108
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

	// Token: 0x040069C9 RID: 27081
	[Nullable(2)]
	protected ITrapDefenseCountDownTipsData Data;

	// Token: 0x040069CA RID: 27082
	private float CountDownTime;

	// Token: 0x040069CB RID: 27083
	private float ShowTextNum;

	// Token: 0x040069CC RID: 27084
	private bool CanTick = true;

	// Token: 0x040069CD RID: 27085
	private UUINiagara Niagara;

	// Token: 0x040069CE RID: 27086
	private UiSequencePlayer Sequence;

	// Token: 0x020074DE RID: 29918
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402603F RID: 155711
		public const int CountDownText = 0;

		// Token: 0x04026040 RID: 155712
		public const int Niagara = 1;
	}
}
