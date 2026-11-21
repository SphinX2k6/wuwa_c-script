using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003614 RID: 13844
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTextAdapterProxy
	{
		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x060233FD RID: 144381 RVA: 0x00A033B6 File Offset: 0x00A015B6
		// (set) Token: 0x060233FE RID: 144382 RVA: 0x00A033BE File Offset: 0x00A015BE
		public UUIText BindText { get; private set; }

		// Token: 0x060233FF RID: 144383 RVA: 0x00A033C7 File Offset: 0x00A015C7
		public UiTextAdapterProxy(UUIText bindText)
		{
			this.BindText = bindText;
		}

		// Token: 0x06023400 RID: 144384 RVA: 0x00A033E0 File Offset: 0x00A015E0
		public void Init()
		{
			this.TextItem = (this.BindText.GetOwner() as AUIBaseActor).GetUIItem().GetParentAsUIItem();
			this.TextSizeControlByOther = (this.TextItem.GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther);
			this.DefaultFontSize = this.BindText.GetSize();
			this.DefaultToggleItemHeight = (int)this.TextItem.GetHeight();
			this.CurrentViewportSize = this.GetViewportSize();
			this.StartTick();
		}

		// Token: 0x06023401 RID: 144385 RVA: 0x00A03468 File Offset: 0x00A01668
		private FIntPoint GetViewportSize()
		{
			APlayerController playerController = Global.PlayerController;
			int x = 0;
			int y = 0;
			if (playerController != null)
			{
				playerController.GetViewportSize(ref x, ref y);
			}
			return new FIntPoint
			{
				X = x,
				Y = y
			};
		}

		// Token: 0x06023402 RID: 144386 RVA: 0x00A034A5 File Offset: 0x00A016A5
		public void SetLocalText(string textStringId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(this.BindText, textStringId, args);
			this.CheckAndRefresh();
		}

		// Token: 0x06023403 RID: 144387 RVA: 0x00A034BF File Offset: 0x00A016BF
		public void SetText(string inText)
		{
			this.BindText.SetText(inText, true);
			this.CheckAndRefresh();
		}

		// Token: 0x06023404 RID: 144388 RVA: 0x00A034D4 File Offset: 0x00A016D4
		private void CheckAndRefresh()
		{
			if (this.DelayRefreshTextHeightTimer == null)
			{
				this.DelayRefreshTextHeightTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.RefreshTextHeight();
					this.DelayRefreshTextHeightTimer = null;
				}, 100f, null, null, true, 1f);
			}
		}

		// Token: 0x06023405 RID: 144389 RVA: 0x00A03507 File Offset: 0x00A01707
		public void StartTick()
		{
			this.StopTick();
			this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "UiTextSizeFitter." + this.BindText.GetName(), ETickingGroup.TG_PrePhysics, false, 0, false);
		}

		// Token: 0x06023406 RID: 144390 RVA: 0x00A03544 File Offset: 0x00A01744
		public void StopTick()
		{
			if (this.Ticker != null)
			{
				TickSystem.Instance.Remove(this.Ticker.Id);
				this.Ticker = null;
			}
		}

		// Token: 0x06023407 RID: 144391 RVA: 0x00A0356B File Offset: 0x00A0176B
		public void Clear()
		{
			this.StopTick();
			if (this.DelayRefreshTextHeightTimer != null && TimerSystem.Instance.Has(this.DelayRefreshTextHeightTimer))
			{
				TimerSystem.Instance.Remove(this.DelayRefreshTextHeightTimer);
				this.DelayRefreshTextHeightTimer = null;
			}
		}

		// Token: 0x06023408 RID: 144392 RVA: 0x00A035A8 File Offset: 0x00A017A8
		private void OnTick(float delta)
		{
			FIntPoint viewportSize = this.GetViewportSize();
			if (this.CurrentViewportSize.X != viewportSize.X || this.CurrentViewportSize.Y != viewportSize.Y)
			{
				this.CurrentViewportSize = viewportSize;
				this.RefreshTextHeight();
			}
		}

		// Token: 0x06023409 RID: 144393 RVA: 0x00A035F0 File Offset: 0x00A017F0
		private void RefreshTextHeight()
		{
			if (this.BindText == null || this.TextItem == null)
			{
				return;
			}
			this.BindText.GetRealSize();
			bool flag = this.BindText.GetRenderLineNum() < 2;
			if (this.IsSingleRow == flag)
			{
				return;
			}
			this.IsSingleRow = flag;
			if (this.IsSingleRow)
			{
				UUISizeControlByOther textSizeControlByOther = this.TextSizeControlByOther;
				if (textSizeControlByOther != null)
				{
					textSizeControlByOther.SetControlHeight(false);
				}
				this.BindText.SetFontSize(this.DefaultFontSize);
				this.BindText.GetRealSize();
				if (this.BindText.GetRenderLineNum() >= 2)
				{
					this.BindText.SetFontSize(38f);
				}
				UUIItem textItem = this.TextItem;
				if (textItem == null)
				{
					return;
				}
				textItem.SetHeight((float)this.DefaultToggleItemHeight);
				return;
			}
			else
			{
				this.BindText.SetFontSize(38f);
				UUISizeControlByOther textSizeControlByOther2 = this.TextSizeControlByOther;
				if (textSizeControlByOther2 != null)
				{
					textSizeControlByOther2.SetControlHeight(true);
				}
				this.BindText.SetFontSize(38f);
				this.BindText.GetRealSize();
				if (this.BindText.GetRenderLineNum() < 2)
				{
					UUISizeControlByOther textSizeControlByOther3 = this.TextSizeControlByOther;
					if (textSizeControlByOther3 != null)
					{
						textSizeControlByOther3.SetControlHeight(false);
					}
					this.IsSingleRow = true;
					return;
				}
				UUISizeControlByOther textSizeControlByOther4 = this.TextSizeControlByOther;
				if (textSizeControlByOther4 == null)
				{
					return;
				}
				textSizeControlByOther4.SetControlHeight(true);
				return;
			}
		}

		// Token: 0x04013DF2 RID: 81394
		private const int FONT_SIZE = 38;

		// Token: 0x04013DF3 RID: 81395
		private const int DELAY_REFRESH_TIME = 100;

		// Token: 0x04013DF4 RID: 81396
		private float DefaultFontSize;

		// Token: 0x04013DF5 RID: 81397
		public int DefaultToggleItemHeight;

		// Token: 0x04013DF6 RID: 81398
		[Nullable(2)]
		private UUISizeControlByOther TextSizeControlByOther;

		// Token: 0x04013DF7 RID: 81399
		[Nullable(2)]
		private Ticker Ticker;

		// Token: 0x04013DF8 RID: 81400
		private FIntPoint CurrentViewportSize;

		// Token: 0x04013DF9 RID: 81401
		private bool IsSingleRow = true;

		// Token: 0x04013DFA RID: 81402
		[Nullable(2)]
		private TimerHandle DelayRefreshTextHeightTimer;

		// Token: 0x04013DFB RID: 81403
		[Nullable(2)]
		private UUIItem TextItem;
	}
}
