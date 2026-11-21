using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054D4 RID: 21716
	[NullableContext(1)]
	[Nullable(0)]
	public static class LinkageRewardDayTextUtil
	{
		// Token: 0x06035CE8 RID: 220392 RVA: 0x00F0825E File Offset: 0x00F0645E
		[NullableContext(2)]
		private static UUITextTransition TryGetUiTextTransition(UUIText text)
		{
			if (text == null)
			{
				return null;
			}
			AUIBaseActor auibaseActor = text.GetOwner() as AUIBaseActor;
			return ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUITextTransition.StaticClass()) : null) as UUITextTransition;
		}

		// Token: 0x06035CE9 RID: 220393 RVA: 0x00F0828B File Offset: 0x00F0648B
		private static void SetStateFontColor(FTextTransitionInfoOfState state, FColor color)
		{
			state.FontColor = color;
			state.bSetFontColor = true;
		}

		// Token: 0x06035CEA RID: 220394 RVA: 0x00F0829B File Offset: 0x00F0649B
		private static void SetDayTextTransitionUniform(UUITextTransition transition, FColor color)
		{
			FTextTransitionInfo transitionInfo = transition.TransitionInfo;
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.NormalTransition, color);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.HighlightedTransition, color);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.PressedTransition, color);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.DisabledTransition, color);
		}

		// Token: 0x06035CEB RID: 220395 RVA: 0x00F082D2 File Offset: 0x00F064D2
		private static void SetDayTextTransitionPending(UUITextTransition transition, FColor normal, FColor hover, FColor pressed)
		{
			FTextTransitionInfo transitionInfo = transition.TransitionInfo;
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.NormalTransition, normal);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.HighlightedTransition, hover);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.PressedTransition, pressed);
			LinkageRewardDayTextUtil.SetStateFontColor(transitionInfo.DisabledTransition, normal);
		}

		// Token: 0x06035CEC RID: 220396 RVA: 0x00F0830C File Offset: 0x00F0650C
		[NullableContext(2)]
		public static void ApplyLinkageRewardKeepMilestoneDayTextStyle(UUIText text, ETimePointRewardState state)
		{
			if (text == null)
			{
				return;
			}
			FColor fcolor = FColor.FromHex("fefe22");
			FColor hover = FColor.FromHex("fdffa3");
			FColor fcolor2 = FColor.FromHex("4dfdff");
			UUITextTransition uuitextTransition = LinkageRewardDayTextUtil.TryGetUiTextTransition(text);
			switch (state)
			{
			case ETimePointRewardState.Lock:
			case ETimePointRewardState.UnlockAndClaimed:
			{
				text.useChangeColor = false;
				if (uuitextTransition != null)
				{
					LinkageRewardDayTextUtil.SetDayTextTransitionUniform(uuitextTransition, fcolor2);
				}
				bool bUseChangeColor = false;
				FColor? fcolor3 = new FColor?(fcolor2);
				text.SetChangeColor(bUseChangeColor, fcolor3);
				text.SetColor(fcolor2);
				return;
			}
			case ETimePointRewardState.UnlockAndUnClaimed:
			{
				text.useChangeColor = true;
				if (uuitextTransition != null)
				{
					LinkageRewardDayTextUtil.SetDayTextTransitionPending(uuitextTransition, fcolor, hover, fcolor);
				}
				bool bUseChangeColor2 = true;
				FColor? fcolor3 = new FColor?(fcolor);
				text.SetChangeColor(bUseChangeColor2, fcolor3);
				text.SetColor(fcolor);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06035CED RID: 220397 RVA: 0x00F083B0 File Offset: 0x00F065B0
		[NullableContext(2)]
		public static void ApplyLinkageRewardDayTextStyle(UUIText text, ETimePointRewardState state)
		{
			if (text == null)
			{
				return;
			}
			FColor fcolor = FColor.FromHex("fefe22");
			FColor hover = FColor.FromHex("fdffa3");
			FColor fcolor2 = FColor.FromHex("8694a0");
			FColor fcolor3 = FColor.FromHex("4dfdff");
			UUITextTransition uuitextTransition = LinkageRewardDayTextUtil.TryGetUiTextTransition(text);
			switch (state)
			{
			case ETimePointRewardState.Lock:
			{
				text.useChangeColor = false;
				if (uuitextTransition != null)
				{
					LinkageRewardDayTextUtil.SetDayTextTransitionUniform(uuitextTransition, fcolor3);
				}
				bool bUseChangeColor = false;
				FColor? fcolor4 = new FColor?(fcolor3);
				text.SetChangeColor(bUseChangeColor, fcolor4);
				text.SetColor(fcolor3);
				return;
			}
			case ETimePointRewardState.UnlockAndUnClaimed:
			{
				text.useChangeColor = true;
				if (uuitextTransition != null)
				{
					LinkageRewardDayTextUtil.SetDayTextTransitionPending(uuitextTransition, fcolor, hover, fcolor);
				}
				bool bUseChangeColor2 = true;
				FColor? fcolor4 = new FColor?(fcolor);
				text.SetChangeColor(bUseChangeColor2, fcolor4);
				text.SetColor(fcolor);
				return;
			}
			case ETimePointRewardState.UnlockAndClaimed:
			{
				text.useChangeColor = false;
				if (uuitextTransition != null)
				{
					LinkageRewardDayTextUtil.SetDayTextTransitionUniform(uuitextTransition, fcolor2);
				}
				bool bUseChangeColor3 = false;
				FColor? fcolor4 = new FColor?(fcolor2);
				text.SetChangeColor(bUseChangeColor3, fcolor4);
				text.SetColor(fcolor2);
				return;
			}
			default:
				return;
			}
		}
	}
}
