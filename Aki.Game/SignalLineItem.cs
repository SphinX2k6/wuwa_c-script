using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001F8E RID: 8078
public class SignalLineItem : SignalItemBase
{
	// Token: 0x06013FC1 RID: 81857 RVA: 0x005D3A62 File Offset: 0x005D1C62
	public SignalLineItem(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize) : base(type, rootHalfWidth, startDecisionSize, endDecisionSize)
	{
	}

	// Token: 0x06013FC2 RID: 81858 RVA: 0x005D3A6F File Offset: 0x005D1C6F
	[NullableContext(1)]
	public void Init(UUIItem uiItem, float offsetX)
	{
		base.SetRootActor(uiItem.GetOwner(), true);
		this.Width = this.RootItem.GetWidth();
		this.RootItem.SetAnchorOffsetX(offsetX);
	}

	// Token: 0x06013FC3 RID: 81859 RVA: 0x005D3A9B File Offset: 0x005D1C9B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
	}

	// Token: 0x06013FC4 RID: 81860 RVA: 0x005D3AD4 File Offset: 0x005D1CD4
	protected override void OnStart()
	{
		this.GrayLine = base.GetSprite(0);
		this.HighlightLine = base.GetSprite(1);
	}

	// Token: 0x06013FC5 RID: 81861 RVA: 0x005D3AF0 File Offset: 0x005D1CF0
	public void AddWidth(float width)
	{
		this.Width += width;
		this.RootItem.SetWidth(this.Width);
	}

	// Token: 0x06013FC6 RID: 81862 RVA: 0x005D3B11 File Offset: 0x005D1D11
	protected override void OnReset()
	{
		this.GrayLine.SetUIActive(true);
		this.HighlightLine.SetFillAmount(0f);
		this.HighlightLine.SetUIActive(true);
	}

	// Token: 0x06013FC7 RID: 81863 RVA: 0x005D3B3C File Offset: 0x005D1D3C
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

	// Token: 0x06013FC8 RID: 81864 RVA: 0x005D3B98 File Offset: 0x005D1D98
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

	// Token: 0x06013FC9 RID: 81865 RVA: 0x005D3C08 File Offset: 0x005D1E08
	public override float GetProgress()
	{
		float num = (float)(-(float)this.DecisionShowSize) / 2f;
		return MathCommon.Clamp((this.CurrentRelativeX - num) / this.RootItem.GetWidth(), 0f, 1f);
	}

	// Token: 0x0400AA57 RID: 43607
	[Nullable(2)]
	private UUISprite GrayLine;

	// Token: 0x0400AA58 RID: 43608
	[Nullable(2)]
	private UUISprite HighlightLine;

	// Token: 0x02008299 RID: 33433
	private static class EChildComponent
	{
		// Token: 0x0402A2AF RID: 172719
		public const int GrayLine = 0;

		// Token: 0x0402A2B0 RID: 172720
		public const int HighlightLine = 1;
	}
}
