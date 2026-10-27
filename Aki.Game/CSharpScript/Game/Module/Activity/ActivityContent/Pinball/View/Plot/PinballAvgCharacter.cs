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
	// Token: 0x0200631B RID: 25371
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballAvgCharacter : IPlotAvgCharacterMove
	{
		// Token: 0x0603FD4E RID: 261454 RVA: 0x00F717B3 File Offset: 0x00F6F9B3
		public PinballAvgCharacter()
		{
			this.MoveComponent = new PlotAvgCharacterMoveComponent();
		}

		// Token: 0x0603FD4F RID: 261455 RVA: 0x00F717C6 File Offset: 0x00F6F9C6
		public void Init(PinballPlotSpineItem item)
		{
			this.Item = item;
		}

		// Token: 0x0603FD50 RID: 261456 RVA: 0x00F717D0 File Offset: 0x00F6F9D0
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

		// Token: 0x0603FD51 RID: 261457 RVA: 0x00F71820 File Offset: 0x00F6FA20
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

		// Token: 0x0603FD52 RID: 261458 RVA: 0x00F71873 File Offset: 0x00F6FA73
		public void PlayExitPerform()
		{
			if (this.Item == null)
			{
				return;
			}
			this.Item.SetUiActive(false);
		}

		// Token: 0x0603FD53 RID: 261459 RVA: 0x00F7188C File Offset: 0x00F6FA8C
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

		// Token: 0x0603FD54 RID: 261460 RVA: 0x00F718DA File Offset: 0x00F6FADA
		public void SetPosition(float position)
		{
			if (this.Item == null)
			{
				return;
			}
			this.Item.SetPosition(position);
		}

		// Token: 0x0603FD55 RID: 261461 RVA: 0x00F718F1 File Offset: 0x00F6FAF1
		public float GetPosition()
		{
			if (this.Item == null)
			{
				return 0f;
			}
			return this.Item.GetPosition();
		}

		// Token: 0x0603FD56 RID: 261462 RVA: 0x00F7190C File Offset: 0x00F6FB0C
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

		// Token: 0x0603FD57 RID: 261463 RVA: 0x00F71926 File Offset: 0x00F6FB26
		public void Destroy()
		{
			this.MoveComponent.Clear();
		}

		// Token: 0x0603FD58 RID: 261464 RVA: 0x00F71933 File Offset: 0x00F6FB33
		public bool GetIsSpeaking()
		{
			return this.IsSpeaking;
		}

		// Token: 0x040214E8 RID: 136424
		[Nullable(2)]
		private PinballPlotSpineItem Item;

		// Token: 0x040214E9 RID: 136425
		private bool IsSpeaking;

		// Token: 0x040214EA RID: 136426
		public PlotAvgCharacterMoveComponent MoveComponent;
	}
}
