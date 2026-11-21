using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CEE RID: 7406
public class RoleTowerPropVisionPanel : UiPanelBase
{
	// Token: 0x06012557 RID: 75095 RVA: 0x00568A64 File Offset: 0x00566C64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelp))
		};
	}

	// Token: 0x06012558 RID: 75096 RVA: 0x00568B23 File Offset: 0x00566D23
	protected override void OnStart()
	{
		this.BuffScroll = new GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData>(base.GetScrollViewWithScrollbar(4), () => new RoleTowerPropBuffItem(), null, false, null);
	}

	// Token: 0x06012559 RID: 75097 RVA: 0x00568B5C File Offset: 0x00566D5C
	[NullableContext(1)]
	public void Refresh(int curLevel, int curExp, int needExp, List<RoleTowerPropBuffData> buffList)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(curLevel);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		float fillAmount = (needExp > 0) ? ((float)curExp / (float)needExp) : 0f;
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetFillAmount(fillAmount);
		}
		GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData> buffScroll = this.BuffScroll;
		if (buffScroll == null)
		{
			return;
		}
		buffScroll.RefreshByData(buffList, null, false);
	}

	// Token: 0x0601255A RID: 75098 RVA: 0x00568BD8 File Offset: 0x00566DD8
	private void OnClickHelp()
	{
		Log.Instance.Info(ELogModule.Temp, ELogAuthor.LJQ, "RoleTower.RoleProperty 声骸等级帮助说明弹窗(TODO)", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x04009FE2 RID: 40930
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerPropBuffItem, RoleTowerPropBuffData> BuffScroll;

	// Token: 0x02007FF9 RID: 32761
	private static class EChildType
	{
		// Token: 0x0402966C RID: 169580
		public const int TxtTitle = 0;

		// Token: 0x0402966D RID: 169581
		public const int BtnHelpInfo = 1;

		// Token: 0x0402966E RID: 169582
		public const int TxtLevel = 2;

		// Token: 0x0402966F RID: 169583
		public const int TexBarFill = 3;

		// Token: 0x04029670 RID: 169584
		public const int VisionBuffScroll = 4;

		// Token: 0x04029671 RID: 169585
		public const int PnlDescItem = 5;
	}
}
