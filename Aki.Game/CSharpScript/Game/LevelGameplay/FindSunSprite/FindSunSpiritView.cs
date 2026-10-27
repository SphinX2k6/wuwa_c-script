using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02006E51 RID: 28241
	public class FindSunSpiritView : UiViewBase
	{
		// Token: 0x06044D4A RID: 281930 RVA: 0x010FD004 File Offset: 0x010FB204
		[NullableContext(1)]
		public FindSunSpiritView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06044D4B RID: 281931 RVA: 0x010FD010 File Offset: 0x010FB210
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnTriggerButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnResetButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnLeftButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnRightButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06044D4C RID: 281932 RVA: 0x010FD1A4 File Offset: 0x010FB3A4
		protected override UniTask OnBeforeStartAsync()
		{
			FindSunSpiritView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FindSunSpiritView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044D4D RID: 281933 RVA: 0x010FD1E7 File Offset: 0x010FB3E7
		protected override void OnBeforeShow()
		{
			this.RefreshTriggerTimes();
		}

		// Token: 0x06044D4E RID: 281934 RVA: 0x010FD1EF File Offset: 0x010FB3EF
		protected override void OnBeforeDestroy()
		{
			if (FindSunSpiritModel.Instance.Config != null)
			{
				FindSunSpiritController.Instance.FinishFindSunSpirit();
			}
		}

		// Token: 0x06044D4F RID: 281935 RVA: 0x010FD207 File Offset: 0x010FB407
		private void OnTriggerButtonClick()
		{
			this.TriggerModifierAsync();
		}

		// Token: 0x06044D50 RID: 281936 RVA: 0x010FD210 File Offset: 0x010FB410
		private UniTask TriggerModifierAsync()
		{
			FindSunSpiritView.<TriggerModifierAsync>d__9 <TriggerModifierAsync>d__;
			<TriggerModifierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerModifierAsync>d__.<>4__this = this;
			<TriggerModifierAsync>d__.<>1__state = -1;
			<TriggerModifierAsync>d__.<>t__builder.Start<FindSunSpiritView.<TriggerModifierAsync>d__9>(ref <TriggerModifierAsync>d__);
			return <TriggerModifierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044D51 RID: 281937 RVA: 0x010FD253 File Offset: 0x010FB453
		private void OnResetButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			this.ResetFindSunSpirit();
		}

		// Token: 0x06044D52 RID: 281938 RVA: 0x010FD264 File Offset: 0x010FB464
		private void OnCloseButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.FinishFindSunSpirit();
			base.CloseMe(null);
		}

		// Token: 0x06044D53 RID: 281939 RVA: 0x010FD280 File Offset: 0x010FB480
		private void OnLeftButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.SelectModifier(false);
		}

		// Token: 0x06044D54 RID: 281940 RVA: 0x010FD296 File Offset: 0x010FB496
		private void OnRightButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.SelectModifier(true);
		}

		// Token: 0x06044D55 RID: 281941 RVA: 0x010FD2AC File Offset: 0x010FB4AC
		private void ResetFindSunSpirit()
		{
			FindSunSpiritController.Instance.ResetFindSunSpirit(delegate
			{
				this.DisableInput = false;
				this.RefreshTriggerTimes();
			});
		}

		// Token: 0x06044D56 RID: 281942 RVA: 0x010FD2C4 File Offset: 0x010FB4C4
		private void RefreshTriggerTimes()
		{
			FindSunSpiritModel instance = FindSunSpiritModel.Instance;
			FindSunSpiritLevelConfig levelConfig = instance.LevelConfig;
			FindSunSpiritLevelPlay levelPlay = instance.LevelPlay;
			int num = levelConfig.MaxStep - levelPlay.CurrentStep;
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x04023D05 RID: 146693
		private bool DisableInput;

		// Token: 0x04023D06 RID: 146694
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200CD0A RID: 52490
		private class EComponentType
		{
			// Token: 0x0403DD2B RID: 253227
			public const int CaptionItem = 0;

			// Token: 0x0403DD2C RID: 253228
			public const int LeftBtn = 1;

			// Token: 0x0403DD2D RID: 253229
			public const int RightBtn = 2;

			// Token: 0x0403DD2E RID: 253230
			public const int TriggerBtn = 3;

			// Token: 0x0403DD2F RID: 253231
			public const int ResetBtn = 4;

			// Token: 0x0403DD30 RID: 253232
			public const int TimesText = 5;
		}
	}
}
