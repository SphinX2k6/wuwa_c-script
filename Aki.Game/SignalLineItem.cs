using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A13 RID: 10771
public class SignalLineItem : SignalItemBase
{
	// Token: 0x060165BA RID: 91578 RVA: 0x005A8A8A File Offset: 0x005A6C8A
	public SignalLineItem(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize) : base(type, rootHalfWidth, startDecisionSize, endDecisionSize)
	{
	}

	// Token: 0x060165BB RID: 91579 RVA: 0x005A8A97 File Offset: 0x005A6C97
	[NullableContext(1)]
	public void Init(UUIItem uiItem, float offsetX)
	{
		base.SetRootActor(uiItem.GetOwner(), true);
		this.Width = this.RootItem.GetWidth();
		this.RootItem.SetAnchorOffsetX(offsetX);
	}

	// Token: 0x060165BC RID: 91580 RVA: 0x005A8AC3 File Offset: 0x005A6CC3
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x060165BD RID: 91581 RVA: 0x005A8AFC File Offset: 0x005A6CFC
	protected override void OnStart()
	{
		this.GrayLine = base.GetSprite(0);
		this.HighlightLine = base.GetSprite(1);
	}

	// Token: 0x060165BE RID: 91582 RVA: 0x005A8B18 File Offset: 0x005A6D18
	public void AddWidth(float width)
	{
		this.Width += width;
		this.RootItem.SetWidth(this.Width);
	}

	// Token: 0x060165BF RID: 91583 RVA: 0x005A8B39 File Offset: 0x005A6D39
	protected override void OnReset()
	{
		this.GrayLine.SetUIActive(true);
		this.HighlightLine.SetFillAmount(0f);
		this.HighlightLine.SetUIActive(true);
	}

	// Token: 0x060165C0 RID: 91584 RVA: 0x005A8B64 File Offset: 0x005A6D64
	public override void InitByGameplayType(ESignalGameplayType type)
	{
		base.InitByGameplayType(type);
		string resourceId = (type == ESignalGameplayType.Send) ? "SP_SignalNoteSolidLineGreen" : "SP_SignalNoteSolidLineYellow";
		if (type == ESignalGameplayType.DrawSword)
		{
			resourceId = "SP_SignalNoteSolidLineOrange";
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, this.HighlightLine, false, null, null);
		base.Reset();
	}

	// Token: 0x060165C1 RID: 91585 RVA: 0x005A8BC0 File Offset: 0x005A6DC0
	protected override bool OnUpdate()
	{
		if (!base.OnUpdate())
		{
			return false;
		}
		float num = (float)(-(float)this.DecisionShowSize) / 2f;
		float fillAmount = this.HighlightLine.GetFillAmount();
		if (this.CurrentRelativeX < num)
		{
			if (fillAmount != 0f)
			{
				this.HighlightLine.SetFillAmount(0f);
			}
			return true;
		}
		float progress = this.GetProgress();
		if (fillAmount != progress)
		{
			this.HighlightLine.SetFillAmount(progress);
		}
		return true;
	}

	// Token: 0x060165C2 RID: 91586 RVA: 0x005A8C30 File Offset: 0x005A6E30
	public override float GetProgress()
	{
		float num = (float)(-(float)this.DecisionShowSize) / 2f;
		return MathCommon.Clamp((this.CurrentRelativeX - num) / this.RootItem.GetWidth(), 0f, 1f);
	}

	// Token: 0x0400A66D RID: 42605
	[Nullable(2)]
	private UUISprite GrayLine;

	// Token: 0x0400A66E RID: 42606
	[Nullable(2)]
	private UUISprite HighlightLine;

	// Token: 0x02009052 RID: 36946
	private static class EChildComponent
	{
		// Token: 0x0402EBB7 RID: 191415
		public const int GrayLine = 0;

		// Token: 0x0402EBB8 RID: 191416
		public const int HighlightLine = 1;
	}
}
