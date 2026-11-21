using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x020052A3 RID: 21155
	public class PinballPlotSpineItem : UiPanelBase, IPlotAvgCharacterMove
	{
		// Token: 0x06034A3C RID: 215612 RVA: 0x00EB8CC0 File Offset: 0x00EB6EC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034A3D RID: 215613 RVA: 0x00EB8D2C File Offset: 0x00EB6F2C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballPlotSpineItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A3E RID: 215614 RVA: 0x00EB8D6F File Offset: 0x00EB6F6F
		[NullableContext(1)]
		public void PlayAnimation(string animationName, bool isLoop)
		{
			base.GetSpine(0).SetAnimation(0, animationName, isLoop);
		}

		// Token: 0x06034A3F RID: 215615 RVA: 0x00EB8D81 File Offset: 0x00EB6F81
		public void SetAnchorOffsetX(float offsetX)
		{
			this.GetOriginalItem().SetAnchorOffsetX(offsetX);
		}

		// Token: 0x06034A40 RID: 215616 RVA: 0x00EB8D8F File Offset: 0x00EB6F8F
		public void SetAnchorOffsetY(float offsetY)
		{
			this.GetOriginalItem().SetAnchorOffsetY(offsetY);
		}

		// Token: 0x06034A41 RID: 215617 RVA: 0x00EB8D9D File Offset: 0x00EB6F9D
		public void UpdateSpeakStatus(bool isSpeaking)
		{
			if (this.IsSpeaking == isSpeaking)
			{
				return;
			}
			this.IsSpeaking = isSpeaking;
			this.RefreshArrowStatus();
		}

		// Token: 0x06034A42 RID: 215618 RVA: 0x00EB8DB6 File Offset: 0x00EB6FB6
		public void RefreshArrowStatus()
		{
			base.GetItem(1).SetUIActive(this.IsSpeaking);
		}

		// Token: 0x06034A43 RID: 215619 RVA: 0x00EB8DCC File Offset: 0x00EB6FCC
		public UniTask OnEnterAsync()
		{
			PinballPlotSpineItem.<OnEnterAsync>d__10 <OnEnterAsync>d__;
			<OnEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnEnterAsync>d__.<>1__state = -1;
			<OnEnterAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnEnterAsync>d__10>(ref <OnEnterAsync>d__);
			return <OnEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A44 RID: 215620 RVA: 0x00EB8E07 File Offset: 0x00EB7007
		public void SetPosition(float position)
		{
			this.SetAnchorOffsetX(position);
		}

		// Token: 0x06034A45 RID: 215621 RVA: 0x00EB8E10 File Offset: 0x00EB7010
		public float GetPosition()
		{
			return this.GetOriginalItem().GetAnchorOffsetX();
		}

		// Token: 0x06034A46 RID: 215622 RVA: 0x00EB8E20 File Offset: 0x00EB7020
		public UniTask OnExitAsync()
		{
			PinballPlotSpineItem.<OnExitAsync>d__13 <OnExitAsync>d__;
			<OnExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExitAsync>d__.<>1__state = -1;
			<OnExitAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnExitAsync>d__13>(ref <OnExitAsync>d__);
			return <OnExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BE2C RID: 114220
		private int? TalkerId;

		// Token: 0x0401BE2D RID: 114221
		private bool IsSpeaking;

		// Token: 0x0200AF03 RID: 44803
		private enum EComponent
		{
			// Token: 0x04036127 RID: 221479
			RoleSpine,
			// Token: 0x04036128 RID: 221480
			ArrowItem
		}
	}
}
