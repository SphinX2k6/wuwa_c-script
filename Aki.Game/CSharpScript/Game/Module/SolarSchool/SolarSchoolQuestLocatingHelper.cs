using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E8 RID: 23016
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolQuestLocatingHelper
	{
		// Token: 0x06038B1C RID: 232220 RVA: 0x00FDE512 File Offset: 0x00FDC712
		public SolarSchoolQuestLocatingHelper(UUIScrollViewWithScrollbarComponent scroll)
		{
			this.Scroll = scroll;
		}

		// Token: 0x06038B1D RID: 232221 RVA: 0x00FDE524 File Offset: 0x00FDC724
		private float GetTargetAnchorOffsetX(UUIItem target)
		{
			UUIItem uiitem = this.Scroll.GetContent().GetUIItem();
			UUIItem uiitem2 = this.Scroll.GetViewport().GetUIItem();
			FVector location = new FVector((0.5f - target.GetPivot().X) * target.GetWidth(), (0.5f - target.GetPivot().Y) * target.GetHeight(), 0f);
			FTransform ftransform = target.K2_GetComponentToWorld();
			FVector location2 = UKismetMathLibrary.TransformLocation(ftransform, location);
			ftransform = uiitem.K2_GetComponentToWorld();
			FVector fvector = UKismetMathLibrary.InverseTransformLocation(ftransform, location2);
			FTransform relativeTransform = uiitem.GetRelativeTransform();
			float width = uiitem2.GetWidth();
			float num = uiitem.GetWidth() * relativeTransform.Scale3D.X;
			float num2 = relativeTransform.Translation.X - uiitem.GetAnchorOffsetX();
			float num3 = -uiitem2.GetPivot().X * width;
			float num4 = num3 + uiitem.GetPivot().X * num - num2;
			float min = num4 - Math.Max(num - width, 0f);
			return Math.Clamp(num3 + width * 0.5f - fvector.X * relativeTransform.Scale3D.X - num2, min, num4);
		}

		// Token: 0x06038B1E RID: 232222 RVA: 0x00FDE64A File Offset: 0x00FDC84A
		public void SnapToQuest(UUIItem target)
		{
			this.CancelMove();
			this.Scroll.StopMovement();
			this.Scroll.GetContent().GetUIItem().SetAnchorOffsetX(this.GetTargetAnchorOffsetX(target));
		}

		// Token: 0x06038B1F RID: 232223 RVA: 0x00FDE67C File Offset: 0x00FDC87C
		[NullableContext(0)]
		public UniTask<bool> MoveToQuestAsync([Nullable(1)] UUIItem target)
		{
			SolarSchoolQuestLocatingHelper.<MoveToQuestAsync>d__7 <MoveToQuestAsync>d__;
			<MoveToQuestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MoveToQuestAsync>d__.<>4__this = this;
			<MoveToQuestAsync>d__.target = target;
			<MoveToQuestAsync>d__.<>1__state = -1;
			<MoveToQuestAsync>d__.<>t__builder.Start<SolarSchoolQuestLocatingHelper.<MoveToQuestAsync>d__7>(ref <MoveToQuestAsync>d__);
			return <MoveToQuestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038B20 RID: 232224 RVA: 0x00FDE6C7 File Offset: 0x00FDC8C7
		private void UpdateMove(float value)
		{
			this.Scroll.GetContent().GetUIItem().SetAnchorOffsetX(value);
		}

		// Token: 0x06038B21 RID: 232225 RVA: 0x00FDE6E0 File Offset: 0x00FDC8E0
		public void CancelMove()
		{
			if (this.MoveTweener != null)
			{
				this.MoveTweener.OnCompleteCallBack.Unbind();
				this.MoveTweener.Kill(false);
				this.MoveTweener = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateMove));
			CustomPromise<bool> moveCompletion = this.MoveCompletion;
			this.MoveCompletion = null;
			if (moveCompletion == null)
			{
				return;
			}
			moveCompletion.SetResult(false);
		}

		// Token: 0x0401DDA2 RID: 122274
		private const float MoveDuration = 0.5f;

		// Token: 0x0401DDA3 RID: 122275
		private readonly UUIScrollViewWithScrollbarComponent Scroll;

		// Token: 0x0401DDA4 RID: 122276
		[Nullable(2)]
		private ULTweener MoveTweener;

		// Token: 0x0401DDA5 RID: 122277
		[Nullable(2)]
		private CustomPromise<bool> MoveCompletion;
	}
}
