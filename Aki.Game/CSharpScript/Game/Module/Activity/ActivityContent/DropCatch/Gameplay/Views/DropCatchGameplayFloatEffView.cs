using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views
{
	// Token: 0x020066F8 RID: 26360
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayFloatEffView : DropCatchGameplayPoolPanelBase
	{
		// Token: 0x06041DC3 RID: 269763 RVA: 0x00FF8C10 File Offset: 0x00FF6E10
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIArtText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIArtText))
			};
		}

		// Token: 0x06041DC4 RID: 269764 RVA: 0x00FF8CAC File Offset: 0x00FF6EAC
		protected override void OnStart()
		{
			this.PosDelegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnPosTweenUpdate));
		}

		// Token: 0x06041DC5 RID: 269765 RVA: 0x00FF8CC8 File Offset: 0x00FF6EC8
		protected override void OnBeforeShow()
		{
			IDropCatchGameplayFloatEffViewParams dropCatchGameplayFloatEffViewParams = this.OpenParam as IDropCatchGameplayFloatEffViewParams;
			this.InitPos(dropCatchGameplayFloatEffViewParams.Pos);
			if (!StringUtils.IsEmpty(dropCatchGameplayFloatEffViewParams.Icon))
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				base.TrySetSpriteByPath(dropCatchGameplayFloatEffViewParams.Icon, base.GetSprite(0), true, null, null);
			}
			else
			{
				UUIItem item2 = base.GetItem(2);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
			}
			if (dropCatchGameplayFloatEffViewParams.Score != null)
			{
				if (dropCatchGameplayFloatEffViewParams.IsOrangeScore)
				{
					UUIItem item3 = base.GetItem(3);
					if (item3 != null)
					{
						item3.SetUIActive(false);
					}
					UUIItem item4 = base.GetItem(4);
					if (item4 != null)
					{
						item4.SetUIActive(true);
					}
					UUIArtText artText = base.GetArtText(5);
					if (artText != null)
					{
						artText.SetText(dropCatchGameplayFloatEffViewParams.Score.Value.ToString());
					}
				}
				else
				{
					UUIItem item5 = base.GetItem(3);
					if (item5 != null)
					{
						item5.SetUIActive(true);
					}
					UUIItem item6 = base.GetItem(4);
					if (item6 != null)
					{
						item6.SetUIActive(false);
					}
					UUIArtText artText2 = base.GetArtText(1);
					if (artText2 != null)
					{
						artText2.SetText(dropCatchGameplayFloatEffViewParams.Score.Value.ToString());
					}
				}
				AudioSystem.Instance.PostEvent("play_ui_goldcatch_efx_buff_time");
				return;
			}
			UUIItem item7 = base.GetItem(3);
			if (item7 != null)
			{
				item7.SetUIActive(false);
			}
			UUIItem item8 = base.GetItem(4);
			if (item8 == null)
			{
				return;
			}
			item8.SetUIActive(false);
		}

		// Token: 0x06041DC6 RID: 269766 RVA: 0x00FF8E26 File Offset: 0x00FF7026
		private void OnPosTweenUpdate(FVector2D targetPos)
		{
			base.GetRootItem().SetAnchorOffset(targetPos);
		}

		// Token: 0x06041DC7 RID: 269767 RVA: 0x00FF8E34 File Offset: 0x00FF7034
		protected void InitPos(Vector2D pos)
		{
			this.StartPos.Set(pos.X, pos.Y);
			this.EndPos.Set(pos.X, pos.Y + 100.0);
			base.GetRootItem().SetAnchorOffset(pos.ToUeVector2D(false));
		}

		// Token: 0x06041DC8 RID: 269768 RVA: 0x00FF8E8B File Offset: 0x00FF708B
		protected override void OnAfterShow()
		{
			this.PlayPosTween(this.StartPos, this.EndPos, DropCatchGameplayFloatEffView.TWEENTIME, LTweenEase.OutCubic);
			this.PlayAlphaTween();
		}

		// Token: 0x06041DC9 RID: 269769 RVA: 0x00FF8EAC File Offset: 0x00FF70AC
		private void PlayPosTween(Vector2D startPos, Vector2D endPos, float tweenTime, LTweenEase tweenEase)
		{
			this.KillPosTweener();
			this.PosTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.PosDelegate, startPos.ToUeVector2D(false), endPos.ToUeVector2D(false), tweenTime, 0f, tweenEase);
			this.PosTweener.OnCompleteCallBack.Bind(delegate()
			{
				Action<DropCatchGameplayPoolPanelBase> onRecycle = this.OnRecycle;
				if (onRecycle == null)
				{
					return;
				}
				onRecycle(this);
			});
		}

		// Token: 0x06041DCA RID: 269770 RVA: 0x00FF8F07 File Offset: 0x00FF7107
		private void PlayAlphaTween()
		{
			base.GetRootItem().PlayUIItemAlphaTween(1f, 0f, DropCatchGameplayFloatEffView.TWEENTIME);
		}

		// Token: 0x06041DCB RID: 269771 RVA: 0x00FF8F23 File Offset: 0x00FF7123
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
			}
		}

		// Token: 0x06041DCC RID: 269772 RVA: 0x00FF8F40 File Offset: 0x00FF7140
		protected override void OnBeforeDestroy()
		{
			this.KillPosTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnPosTweenUpdate));
		}

		// Token: 0x040224E8 RID: 140520
		private static readonly float TWEENTIME = 1.2f;

		// Token: 0x040224E9 RID: 140521
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x040224EA RID: 140522
		[Nullable(2)]
		private FLTweenVector2SetterDynamic PosDelegate;

		// Token: 0x040224EB RID: 140523
		private readonly Vector2D StartPos = Vector2D.Create();

		// Token: 0x040224EC RID: 140524
		private readonly Vector2D EndPos = Vector2D.Create();
	}
}
