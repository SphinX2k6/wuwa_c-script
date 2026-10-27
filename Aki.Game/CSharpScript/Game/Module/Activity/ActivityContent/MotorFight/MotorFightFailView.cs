using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006425 RID: 25637
	public class MotorFightFailView : UiViewBase
	{
		// Token: 0x06040768 RID: 264040 RVA: 0x00F99581 File Offset: 0x00F97781
		[NullableContext(1)]
		public MotorFightFailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040769 RID: 264041 RVA: 0x00F9958C File Offset: 0x00F9778C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604076A RID: 264042 RVA: 0x00F9965C File Offset: 0x00F9785C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightFailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightFailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604076B RID: 264043 RVA: 0x00F996A0 File Offset: 0x00F978A0
		protected override void OnBeforeShow()
		{
			UUIText text = base.GetText(1);
			UUIEffectOutline uuieffectOutline = (UUIEffectOutline)text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass());
			LguiUtil.Instance.SetLocalTextNew(text, "GenericPromptTypes_4_GeneralText", Array.Empty<object>());
			text.SetColor(FColor.FromHex("F08086FF"));
			text.outlineColor = FColor.FromHex("B33100FF");
			uuieffectOutline.SetOutlineColor(FColor.FromHex("B33100FF"));
			base.PlaySequence("Fail", null, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "MotorFightGame_FailInfo", Array.Empty<object>());
			UUIText text2 = base.GetText(14);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(true);
		}

		// Token: 0x0604076C RID: 264044 RVA: 0x00F99750 File Offset: 0x00F97950
		private UniTask InitButtonAsync()
		{
			MotorFightFailView.<InitButtonAsync>d__7 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<MotorFightFailView.<InitButtonAsync>d__7>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604076D RID: 264045 RVA: 0x00F99794 File Offset: 0x00F97994
		[NullableContext(1)]
		private UniTask CreateButton(UUIItem uiItem, int buttonIndex, Action clickFunction)
		{
			MotorFightFailView.<CreateButton>d__8 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.buttonIndex = buttonIndex;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<MotorFightFailView.<CreateButton>d__8>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x0604076E RID: 264046 RVA: 0x00F997E7 File Offset: 0x00F979E7
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.ReChallengeMotorFightDungeon();
		}

		// Token: 0x0604076F RID: 264047 RVA: 0x00F997F3 File Offset: 0x00F979F3
		private void OnExitBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x04021837 RID: 137271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x0200C655 RID: 50773
		private class EComponents
		{
			// Token: 0x0403BDFB RID: 245243
			public const int TxtTitle = 1;

			// Token: 0x0403BDFC RID: 245244
			public const int TextureIcon = 2;

			// Token: 0x0403BDFD RID: 245245
			public const int ButtonHorizontalItem = 4;

			// Token: 0x0403BDFE RID: 245246
			public const int ButtonItem = 5;

			// Token: 0x0403BDFF RID: 245247
			public const int TextFailTip = 14;
		}

		// Token: 0x0200C656 RID: 50774
		private class EButtons
		{
			// Token: 0x0403BE00 RID: 245248
			public const int LeftButton = 0;

			// Token: 0x0403BE01 RID: 245249
			public const int RightButton = 1;
		}
	}
}
