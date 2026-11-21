using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;

namespace Aki.Game.Module.Plot
{
	// Token: 0x02002F98 RID: 12184
	public class PlotMouthAnimPlayer
	{
		// Token: 0x0601CE52 RID: 118354 RVA: 0x008D4184 File Offset: 0x008D2384
		[NullableContext(1)]
		public unsafe void Play(Entity entity, PlotAudio plotAudio, string tidTalk)
		{
			PlotMouthAnimPlayer.<>c__DisplayClass2_0 CS$<>8__locals1 = new PlotMouthAnimPlayer.<>c__DisplayClass2_0();
			CS$<>8__locals1.<>4__this = this;
			this.Stop();
			if (!plotAudio.GenLipSync)
			{
				return;
			}
			PlotMouthAnimPlayer.<>c__DisplayClass2_0 CS$<>8__locals2 = CS$<>8__locals1;
			CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
			CS$<>8__locals2.animInstance = ((component != null) ? component.MainAnimInstance : null);
			if (CS$<>8__locals1.animInstance == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "播放口型时无法获取有效AnimInstance";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TidTalk", tidTalk);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", entity.Id);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			PlotMouthAnimPlayer.<>c__DisplayClass2_0 CS$<>8__locals3 = CS$<>8__locals1;
			CommonNpcPerformComponent component2 = entity.GetComponent<CommonNpcPerformComponent>();
			CS$<>8__locals3.faceChangeManager = ((component2 != null) ? component2.ExpressionController : null);
			CS$<>8__locals1.targetEntityId = entity.Id;
			string audioMouthAnimName = PlotAudioModel.Instance.GetAudioMouthAnimName(plotAudio);
			this.LoadingId = PreloadModelNew.Instance.PlotAssetManager.GetAsset<UAnimSequence>(audioMouthAnimName, delegate([Nullable(2)] UAnimSequence asset, string _)
			{
				CS$<>8__locals1.<>4__this.LoadingId = -1;
				UAnimMontage animMontage = CS$<>8__locals1.animInstance.PlaySlotAnimationAsDynamicMontage(asset, SequenceDefine.ABP_Mouth_Slot_Name, 0f, 0f, 1f, 1, -1f, 0f, false);
				CS$<>8__locals1.<>4__this.TargetEntityId = new int?(CS$<>8__locals1.targetEntityId);
				NpcFacialExpressionController faceChangeManager = CS$<>8__locals1.faceChangeManager;
				if (faceChangeManager == null)
				{
					return;
				}
				faceChangeManager.ChangeFaceForMouthMontage(animMontage);
			});
		}

		// Token: 0x0601CE53 RID: 118355 RVA: 0x008D4280 File Offset: 0x008D2480
		public void Stop()
		{
			if (this.LoadingId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadingId);
				this.LoadingId = -1;
			}
			if (this.TargetEntityId == null)
			{
				return;
			}
			Entity entity = EntitySystem.Instance.Get(this.TargetEntityId.Value);
			UAnimInstance uanimInstance;
			if (entity == null)
			{
				uanimInstance = null;
			}
			else
			{
				CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
				uanimInstance = ((component != null) ? component.MainAnimInstance : null);
			}
			UAnimInstance uanimInstance2 = uanimInstance;
			this.TargetEntityId = null;
			if (!ObjectUtils.IsValid(uanimInstance2))
			{
				return;
			}
			uanimInstance2.StopSlotAnimation(0f, SequenceDefine.ABP_Mouth_Slot_Name);
		}

		// Token: 0x0400F39E RID: 62366
		private int LoadingId = -1;

		// Token: 0x0400F39F RID: 62367
		private int? TargetEntityId;
	}
}
