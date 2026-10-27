using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002204 RID: 8708
[NullableContext(2)]
[Nullable(0)]
public class MarqueeView : UiTickViewBase
{
	// Token: 0x06010EF3 RID: 69363 RVA: 0x0041EB86 File Offset: 0x0041CD86
	[NullableContext(1)]
	public MarqueeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010EF4 RID: 69364 RVA: 0x0041EB98 File Offset: 0x0041CD98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06010EF5 RID: 69365 RVA: 0x0041EBF2 File Offset: 0x0041CDF2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string, string>(EEventName.TextLanguageChange, new Action<string, string>(this.OnChangeLanguage));
	}

	// Token: 0x06010EF6 RID: 69366 RVA: 0x0041EC10 File Offset: 0x0041CE10
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.TextLanguageChange, new Action<string, string>(this.OnChangeLanguage));
	}

	// Token: 0x06010EF7 RID: 69367 RVA: 0x0041EC2E File Offset: 0x0041CE2E
	[NullableContext(1)]
	private void OnChangeLanguage(string oldLang, string newLang)
	{
		if (MarqueeModel.Instance.CurMarquee != null)
		{
			MarqueeModel.Instance.CurMarquee.RefreshContent();
			this.RefreshText(MarqueeModel.Instance.CurMarquee);
		}
	}

	// Token: 0x06010EF8 RID: 69368 RVA: 0x0041EC5C File Offset: 0x0041CE5C
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

	// Token: 0x06010EF9 RID: 69369 RVA: 0x0041ED0C File Offset: 0x0041CF0C
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

	// Token: 0x06010EFA RID: 69370 RVA: 0x0041EEF8 File Offset: 0x0041D0F8
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

	// Token: 0x040080C4 RID: 32964
	private const int TARGETPOSITIONOFFSET = 10;

	// Token: 0x040080C5 RID: 32965
	private int InitOffsetX;

	// Token: 0x040080C6 RID: 32966
	private UUIText Text;

	// Token: 0x040080C7 RID: 32967
	private UUIItem TextContainer;

	// Token: 0x040080C8 RID: 32968
	private UUISprite Icon;

	// Token: 0x040080C9 RID: 32969
	private int CurOffsetX;

	// Token: 0x040080CA RID: 32970
	private double? PerVisibleTime;

	// Token: 0x040080CB RID: 32971
	private int Speed;

	// Token: 0x040080CC RID: 32972
	private MarqueeData CurrentMarqueeData;

	// Token: 0x040080CD RID: 32973
	private bool CurrentShowState = true;

	// Token: 0x02008734 RID: 34612
	[NullableContext(0)]
	private class EMarqueeChildCom
	{
		// Token: 0x0402BF4C RID: 180044
		public const int Text = 0;

		// Token: 0x0402BF4D RID: 180045
		public const int Container = 1;

		// Token: 0x0402BF4E RID: 180046
		public const int Icon = 2;
	}
}
