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
	// Token: 0x02006325 RID: 25381
	public class PinballPlotSpineItem : UiPanelBase, IPlotAvgCharacterMove
	{
		// Token: 0x0603FD7B RID: 261499 RVA: 0x00F71D64 File Offset: 0x00F6FF64
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

		// Token: 0x0603FD7C RID: 261500 RVA: 0x00F71DD0 File Offset: 0x00F6FFD0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballPlotSpineItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD7D RID: 261501 RVA: 0x00F71E13 File Offset: 0x00F70013
		[NullableContext(1)]
		public void PlayAnimation(string animationName, bool isLoop)
		{
			base.GetSpine(0).SetAnimation(0, animationName, isLoop);
		}

		// Token: 0x0603FD7E RID: 261502 RVA: 0x00F71E25 File Offset: 0x00F70025
		public void SetAnchorOffsetX(float offsetX)
		{
			this.GetOriginalItem().SetAnchorOffsetX(offsetX);
		}

		// Token: 0x0603FD7F RID: 261503 RVA: 0x00F71E33 File Offset: 0x00F70033
		public void SetAnchorOffsetY(float offsetY)
		{
			this.GetOriginalItem().SetAnchorOffsetY(offsetY);
		}

		// Token: 0x0603FD80 RID: 261504 RVA: 0x00F71E41 File Offset: 0x00F70041
		public void UpdateSpeakStatus(bool isSpeaking)
		{
			if (this.IsSpeaking == isSpeaking)
			{
				return;
			}
			this.IsSpeaking = isSpeaking;
			this.RefreshArrowStatus();
		}

		// Token: 0x0603FD81 RID: 261505 RVA: 0x00F71E5A File Offset: 0x00F7005A
		public void RefreshArrowStatus()
		{
			base.GetItem(1).SetUIActive(this.IsSpeaking);
		}

		// Token: 0x0603FD82 RID: 261506 RVA: 0x00F71E70 File Offset: 0x00F70070
		public UniTask OnEnterAsync()
		{
			PinballPlotSpineItem.<OnEnterAsync>d__10 <OnEnterAsync>d__;
			<OnEnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnEnterAsync>d__.<>1__state = -1;
			<OnEnterAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnEnterAsync>d__10>(ref <OnEnterAsync>d__);
			return <OnEnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD83 RID: 261507 RVA: 0x00F71EAB File Offset: 0x00F700AB
		public void SetPosition(float position)
		{
			this.SetAnchorOffsetX(position);
		}

		// Token: 0x0603FD84 RID: 261508 RVA: 0x00F71EB4 File Offset: 0x00F700B4
		public float GetPosition()
		{
			return this.GetOriginalItem().GetAnchorOffsetX();
		}

		// Token: 0x0603FD85 RID: 261509 RVA: 0x00F71EC4 File Offset: 0x00F700C4
		public UniTask OnExitAsync()
		{
			PinballPlotSpineItem.<OnExitAsync>d__13 <OnExitAsync>d__;
			<OnExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnExitAsync>d__.<>1__state = -1;
			<OnExitAsync>d__.<>t__builder.Start<PinballPlotSpineItem.<OnExitAsync>d__13>(ref <OnExitAsync>d__);
			return <OnExitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040214FD RID: 136445
		private int? TalkerId;

		// Token: 0x040214FE RID: 136446
		private bool IsSpeaking;

		// Token: 0x0200C51C RID: 50460
		private enum EComponent
		{
			// Token: 0x0403B7C5 RID: 243653
			RoleSpine,
			// Token: 0x0403B7C6 RID: 243654
			ArrowItem
		}
	}
}
