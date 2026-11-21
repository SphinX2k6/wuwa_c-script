using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Avg;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02005299 RID: 21145
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballAvgCharacter : IPlotAvgCharacterMove
	{
		// Token: 0x06034A0F RID: 215567 RVA: 0x00EB870F File Offset: 0x00EB690F
		public PinballAvgCharacter()
		{
			this.MoveComponent = new PlotAvgCharacterMoveComponent();
		}

		// Token: 0x06034A10 RID: 215568 RVA: 0x00EB8722 File Offset: 0x00EB6922
		public void Init(PinballPlotSpineItem item)
		{
			this.Item = item;
		}

		// Token: 0x06034A11 RID: 215569 RVA: 0x00EB872C File Offset: 0x00EB692C
		public void PlayEnterPerform(EPlotAvgCharacterSpineDirection direction, UUIItem postionItem, EAvgRoleAnimationType animationType, bool isLoop)
		{
			if (this.Item == null)
			{
				return;
			}
			this.Item.SetUiActive(true);
			this.Item.SetAnchorOffsetX(postionItem.GetAnchorOffsetX());
			this.Item.SetAnchorOffsetY(postionItem.GetAnchorOffsetY());
			this.PlayAnimation(direction, animationType, isLoop);
		}

		// Token: 0x06034A12 RID: 215570 RVA: 0x00EB877C File Offset: 0x00EB697C
		public UniTask PlayMovePerformAsync(UUIItem targetPositionItem, IEaseData easeData)
		{
			PinballAvgCharacter.<PlayMovePerformAsync>d__6 <PlayMovePerformAsync>d__;
			<PlayMovePerformAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMovePerformAsync>d__.<>4__this = this;
			<PlayMovePerformAsync>d__.targetPositionItem = targetPositionItem;
			<PlayMovePerformAsync>d__.easeData = easeData;
			<PlayMovePerformAsync>d__.<>1__state = -1;
			<PlayMovePerformAsync>d__.<>t__builder.Start<PinballAvgCharacter.<PlayMovePerformAsync>d__6>(ref <PlayMovePerformAsync>d__);
			return <PlayMovePerformAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A13 RID: 215571 RVA: 0x00EB87CF File Offset: 0x00EB69CF
		public void PlayExitPerform()
		{
			if (this.Item == null)
			{
				return;
			}
			this.Item.SetUiActive(false);
		}

		// Token: 0x06034A14 RID: 215572 RVA: 0x00EB87E8 File Offset: 0x00EB69E8
		public void PlayAnimation(EPlotAvgCharacterSpineDirection direction, EAvgRoleAnimationType animationType, bool isLoop)
		{
			if (this.Item == null)
			{
				return;
			}
			string spineAnimation = PinballAvgUtils.GetSpineAnimation(direction, animationType);
			this.Item.PlayAnimation(spineAnimation, isLoop);
			string spineAnimationAkEvent = PinballAvgUtils.GetSpineAnimationAkEvent(spineAnimation);
			if (spineAnimationAkEvent != null && spineAnimationAkEvent != "")
			{
				AudioSystem.Instance.PostEvent(spineAnimationAkEvent);
			}
		}

		// Token: 0x06034A15 RID: 215573 RVA: 0x00EB8836 File Offset: 0x00EB6A36
		public void SetPosition(float position)
		{
			if (this.Item == null)
			{
				return;
			}
			this.Item.SetPosition(position);
		}

		// Token: 0x06034A16 RID: 215574 RVA: 0x00EB884D File Offset: 0x00EB6A4D
		public float GetPosition()
		{
			if (this.Item == null)
			{
				return 0f;
			}
			return this.Item.GetPosition();
		}

		// Token: 0x06034A17 RID: 215575 RVA: 0x00EB8868 File Offset: 0x00EB6A68
		public void UpdateSpeakStatus(bool isSpeaking)
		{
			this.IsSpeaking = isSpeaking;
			PinballPlotSpineItem item = this.Item;
			if (item == null)
			{
				return;
			}
			item.UpdateSpeakStatus(isSpeaking);
		}

		// Token: 0x06034A18 RID: 215576 RVA: 0x00EB8882 File Offset: 0x00EB6A82
		public void Destroy()
		{
			this.MoveComponent.Clear();
		}

		// Token: 0x06034A19 RID: 215577 RVA: 0x00EB888F File Offset: 0x00EB6A8F
		public bool GetIsSpeaking()
		{
			return this.IsSpeaking;
		}

		// Token: 0x0401BE17 RID: 114199
		[Nullable(2)]
		private PinballPlotSpineItem Item;

		// Token: 0x0401BE18 RID: 114200
		private bool IsSpeaking;

		// Token: 0x0401BE19 RID: 114201
		public PlotAvgCharacterMoveComponent MoveComponent;
	}
}
