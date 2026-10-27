using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E4 RID: 18148
	[NullableContext(1)]
	[Nullable(0)]
	public class UiTextAdapterProxy
	{
		// Token: 0x17007685 RID: 30341
		// (get) Token: 0x0602ECC2 RID: 191682 RVA: 0x00AD58DE File Offset: 0x00AD3ADE
		// (set) Token: 0x0602ECC3 RID: 191683 RVA: 0x00AD58E6 File Offset: 0x00AD3AE6
		public UUIText BindText { get; private set; }

		// Token: 0x0602ECC4 RID: 191684 RVA: 0x00AD58EF File Offset: 0x00AD3AEF
		public UiTextAdapterProxy(UUIText bindText)
		{
			this.BindText = bindText;
		}

		// Token: 0x0602ECC5 RID: 191685 RVA: 0x00AD5908 File Offset: 0x00AD3B08
		public void Init()
		{
			this.TextItem = (this.BindText.GetOwner() as AUIBaseActor).GetUIItem().GetParentAsUIItem();
			this.TextSizeControlByOther = (this.TextItem.GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther);
			this.DefaultFontSize = this.BindText.GetSize();
			this.DefaultToggleItemHeight = (int)this.TextItem.GetHeight();
			this.CurrentViewportSize = this.GetViewportSize();
			this.StartTick();
		}

		// Token: 0x0602ECC6 RID: 191686 RVA: 0x00AD5990 File Offset: 0x00AD3B90
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

		// Token: 0x0602ECC7 RID: 191687 RVA: 0x00AD59CD File Offset: 0x00AD3BCD
		public void SetLocalText(string textStringId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(this.BindText, textStringId, args);
			this.CheckAndRefresh();
		}

		// Token: 0x0602ECC8 RID: 191688 RVA: 0x00AD59E7 File Offset: 0x00AD3BE7
		public void SetText(string inText)
		{
			this.BindText.SetText(inText, true);
			this.CheckAndRefresh();
		}

		// Token: 0x0602ECC9 RID: 191689 RVA: 0x00AD59FC File Offset: 0x00AD3BFC
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

		// Token: 0x0602ECCA RID: 191690 RVA: 0x00AD5A2F File Offset: 0x00AD3C2F
		public void StartTick()
		{
			this.StopTick();
			this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "UiTextSizeFitter." + this.BindText.GetName(), ETickingGroup.TG_PrePhysics, false, 0, false);
		}

		// Token: 0x0602ECCB RID: 191691 RVA: 0x00AD5A6C File Offset: 0x00AD3C6C
		public void StopTick()
		{
			if (this.Ticker != null)
			{
				TickSystem.Instance.Remove(this.Ticker.Id);
				this.Ticker = null;
			}
		}

		// Token: 0x0602ECCC RID: 191692 RVA: 0x00AD5A93 File Offset: 0x00AD3C93
		public void Clear()
		{
			this.StopTick();
			if (this.DelayRefreshTextHeightTimer != null && TimerSystem.Instance.Has(this.DelayRefreshTextHeightTimer))
			{
				TimerSystem.Instance.Remove(this.DelayRefreshTextHeightTimer);
				this.DelayRefreshTextHeightTimer = null;
			}
		}

		// Token: 0x0602ECCD RID: 191693 RVA: 0x00AD5AD0 File Offset: 0x00AD3CD0
		private void OnTick(float delta)
		{
			FIntPoint viewportSize = this.GetViewportSize();
			if (this.CurrentViewportSize.X != viewportSize.X || this.CurrentViewportSize.Y != viewportSize.Y)
			{
				this.CurrentViewportSize = viewportSize;
				this.RefreshTextHeight();
			}
		}

		// Token: 0x0602ECCE RID: 191694 RVA: 0x00AD5B18 File Offset: 0x00AD3D18
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

		// Token: 0x04019754 RID: 104276
		private const int FONT_SIZE = 38;

		// Token: 0x04019755 RID: 104277
		private const int DELAY_REFRESH_TIME = 100;

		// Token: 0x04019756 RID: 104278
		private float DefaultFontSize;

		// Token: 0x04019757 RID: 104279
		public int DefaultToggleItemHeight;

		// Token: 0x04019758 RID: 104280
		[Nullable(2)]
		private UUISizeControlByOther TextSizeControlByOther;

		// Token: 0x04019759 RID: 104281
		[Nullable(2)]
		private Ticker Ticker;

		// Token: 0x0401975A RID: 104282
		private FIntPoint CurrentViewportSize;

		// Token: 0x0401975B RID: 104283
		private bool IsSingleRow = true;

		// Token: 0x0401975C RID: 104284
		[Nullable(2)]
		private TimerHandle DelayRefreshTextHeightTimer;

		// Token: 0x0401975D RID: 104285
		[Nullable(2)]
		private UUIItem TextItem;
	}
}
