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
	// Token: 0x020053A3 RID: 21411
	public class MotorFightFailView : UiViewBase
	{
		// Token: 0x06035429 RID: 218153 RVA: 0x00EE0521 File Offset: 0x00EDE721
		[NullableContext(1)]
		public MotorFightFailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603542A RID: 218154 RVA: 0x00EE052C File Offset: 0x00EDE72C
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

		// Token: 0x0603542B RID: 218155 RVA: 0x00EE05FC File Offset: 0x00EDE7FC
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightFailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightFailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603542C RID: 218156 RVA: 0x00EE0640 File Offset: 0x00EDE840
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

		// Token: 0x0603542D RID: 218157 RVA: 0x00EE06F0 File Offset: 0x00EDE8F0
		private UniTask InitButtonAsync()
		{
			MotorFightFailView.<InitButtonAsync>d__7 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<MotorFightFailView.<InitButtonAsync>d__7>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603542E RID: 218158 RVA: 0x00EE0734 File Offset: 0x00EDE934
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

		// Token: 0x0603542F RID: 218159 RVA: 0x00EE0787 File Offset: 0x00EDE987
		private void OnReChallengeBtnClick()
		{
			MotorFightController.Instance.ReChallengeMotorFightDungeon();
		}

		// Token: 0x06035430 RID: 218160 RVA: 0x00EE0793 File Offset: 0x00EDE993
		private void OnExitBtnClick()
		{
			MotorFightController.Instance.LeaveInstanceDungeon();
		}

		// Token: 0x0401C166 RID: 115046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<int, ActivityCorniceMeetingButton> ButtonMap;

		// Token: 0x0200B03C RID: 45116
		private class EComponents
		{
			// Token: 0x04036758 RID: 223064
			public const int TxtTitle = 1;

			// Token: 0x04036759 RID: 223065
			public const int TextureIcon = 2;

			// Token: 0x0403675A RID: 223066
			public const int ButtonHorizontalItem = 4;

			// Token: 0x0403675B RID: 223067
			public const int ButtonItem = 5;

			// Token: 0x0403675C RID: 223068
			public const int TextFailTip = 14;
		}

		// Token: 0x0200B03D RID: 45117
		private class EButtons
		{
			// Token: 0x0403675D RID: 223069
			public const int LeftButton = 0;

			// Token: 0x0403675E RID: 223070
			public const int RightButton = 1;
		}
	}
}
