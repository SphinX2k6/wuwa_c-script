using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016E8 RID: 5864
[NullableContext(2)]
[Nullable(0)]
public class MarqueeView : UiTickViewBase
{
	// Token: 0x0600E386 RID: 58246 RVA: 0x0042B52A File Offset: 0x0042972A
	[NullableContext(1)]
	public MarqueeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E387 RID: 58247 RVA: 0x0042B53C File Offset: 0x0042973C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600E388 RID: 58248 RVA: 0x0042B596 File Offset: 0x00429796
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnChangeLanguage));
	}

	// Token: 0x0600E389 RID: 58249 RVA: 0x0042B5B4 File Offset: 0x004297B4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnChangeLanguage));
	}

	// Token: 0x0600E38A RID: 58250 RVA: 0x0042B5D2 File Offset: 0x004297D2
	[NullableContext(1)]
	private void OnChangeLanguage(string oldLang, string newLang)
	{
		if (MarqueeModel.Instance.CurMarquee != null)
		{
			MarqueeModel.Instance.CurMarquee.RefreshContent();
			this.RefreshText(MarqueeModel.Instance.CurMarquee);
		}
	}

	// Token: 0x0600E38B RID: 58251 RVA: 0x0042B600 File Offset: 0x00429800
	protected override void OnStart()
	{
		MarqueeData marqueeData = MarqueeModel.Instance.PeekMarqueeData();
		if (marqueeData == null)
		{
			return;
		}
		MarqueeModel.Instance.CurMarquee = marqueeData;
		this.TextContainer = base.GetItem(1);
		this.Text = base.GetText(0);
		this.RefreshText(marqueeData);
		this.Icon = base.GetSprite(2);
		this.InitOffsetX = (int)(this.TextContainer.GetWidth() / 2f + this.Icon.GetWidth());
		this.CurOffsetX = this.InitOffsetX;
		this.Text.SetAnchorOffsetX((float)this.CurOffsetX);
		this.Speed = ConfigCommonParamById.GetIntConfig("marquee_speed").Value;
	}

	// Token: 0x0600E38C RID: 58252 RVA: 0x0042B6B0 File Offset: 0x004298B0
	protected override void OnTick(float deltaTime)
	{
		MarqueeData curMarquee = MarqueeModel.Instance.CurMarquee;
		if (curMarquee == null || !MarqueeController.Instance.CheckCurMarqueeValid(curMarquee))
		{
			MarqueeController.Instance.CloseMarqueeView(true);
			return;
		}
		if (!curMarquee.UseLocalTextKey)
		{
			string content = curMarquee.Content;
			MarqueeData currentMarqueeData = this.CurrentMarqueeData;
			if (content != ((currentMarqueeData != null) ? currentMarqueeData.Content : null))
			{
				this.RefreshText(curMarquee);
			}
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		MarqueeData nextMarquee = MarqueeModel.Instance.GetNextMarquee();
		if (nextMarquee != null && nextMarquee.BeginTime <= serverTime)
		{
			Log.Instance.Info(ELogModule.Marquee, ELogAuthor.ZJC, "下一条跑马灯到播放时间", default(ReadOnlySpan<ValueTuple<string, object>>));
			MarqueeController.Instance.CloseMarqueeView(true);
			return;
		}
		if ((float)this.CurOffsetX < (float)this.InitOffsetX - this.TextContainer.GetWidth() - (this.Text.GetWidth() + this.Icon.GetWidth()) - 10f)
		{
			if (this.PerVisibleTime == null)
			{
				this.PerVisibleTime = new double?(serverTime);
			}
			double num = serverTime;
			double? num2 = this.PerVisibleTime + (double)curMarquee.ScrollInterval;
			if (!(num > num2.GetValueOrDefault() & num2 != null))
			{
				if (this.CurrentShowState)
				{
					UUIItem rootItem = this.RootItem;
					if (rootItem != null)
					{
						rootItem.SetUIActive(false);
					}
					this.CurrentShowState = false;
				}
				return;
			}
			this.CurOffsetX = this.InitOffsetX;
			this.Text.SetAnchorOffsetX((float)this.CurOffsetX);
			MarqueeModel.Instance.UpdateMarqueeStorageDataByDate(curMarquee);
			this.PerVisibleTime = null;
			if (!this.CurrentShowState)
			{
				UUIItem rootItem2 = this.RootItem;
				if (rootItem2 != null)
				{
					rootItem2.SetUIActive(true);
				}
				this.CurrentShowState = true;
			}
		}
		this.CurOffsetX -= this.Speed;
		this.Text.SetAnchorOffsetX((float)this.CurOffsetX);
	}

	// Token: 0x0600E38D RID: 58253 RVA: 0x0042B89C File Offset: 0x00429A9C
	[NullableContext(1)]
	private void RefreshText(MarqueeData data)
	{
		this.CurrentMarqueeData = data;
		if (data.UseLocalTextKey)
		{
			LguiUtil.Instance.SetLocalTextNew(this.Text, data.LocalTextKey, Array.Empty<object>());
			return;
		}
		string text = data.Content.Replace("\r\n", " ");
		if (text.Contains("{EndTime}"))
		{
			int num = (int)Math.Ceiling(MarqueeModel.Instance.GetMarqueeDataLeftTime(data) / 60.0);
			string text2 = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("ShopMinuteText"), null);
			text2 = text2.Replace("{0}", num.ToString());
			text = text.Replace("{EndTime}", text2);
		}
		this.Text.SetText(text, true);
	}

	// Token: 0x04008202 RID: 33282
	private const int TARGETPOSITIONOFFSET = 10;

	// Token: 0x04008203 RID: 33283
	private int InitOffsetX;

	// Token: 0x04008204 RID: 33284
	private UUIText Text;

	// Token: 0x04008205 RID: 33285
	private UUIItem TextContainer;

	// Token: 0x04008206 RID: 33286
	private UUISprite Icon;

	// Token: 0x04008207 RID: 33287
	private int CurOffsetX;

	// Token: 0x04008208 RID: 33288
	private double? PerVisibleTime;

	// Token: 0x04008209 RID: 33289
	private int Speed;

	// Token: 0x0400820A RID: 33290
	private MarqueeData CurrentMarqueeData;

	// Token: 0x0400820B RID: 33291
	private bool CurrentShowState = true;

	// Token: 0x020078BD RID: 30909
	[NullableContext(0)]
	private class EMarqueeChildCom
	{
		// Token: 0x04027265 RID: 160357
		public const int Text = 0;

		// Token: 0x04027266 RID: 160358
		public const int Container = 1;

		// Token: 0x04027267 RID: 160359
		public const int Icon = 2;
	}
}
