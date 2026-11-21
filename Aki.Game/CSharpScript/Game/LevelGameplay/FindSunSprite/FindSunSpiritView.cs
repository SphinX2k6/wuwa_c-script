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
	// Token: 0x02005FD2 RID: 24530
	public class FindSunSpiritView : UiViewBase
	{
		// Token: 0x0603AED7 RID: 241367 RVA: 0x010A7564 File Offset: 0x010A5764
		[NullableContext(1)]
		public FindSunSpiritView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AED8 RID: 241368 RVA: 0x010A7570 File Offset: 0x010A5770
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

		// Token: 0x0603AED9 RID: 241369 RVA: 0x010A7704 File Offset: 0x010A5904
		protected override UniTask OnBeforeStartAsync()
		{
			FindSunSpiritView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FindSunSpiritView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEDA RID: 241370 RVA: 0x010A7747 File Offset: 0x010A5947
		protected override void OnBeforeShow()
		{
			this.RefreshTriggerTimes();
		}

		// Token: 0x0603AEDB RID: 241371 RVA: 0x010A774F File Offset: 0x010A594F
		protected override void OnBeforeDestroy()
		{
			if (FindSunSpiritModel.Instance.Config != null)
			{
				FindSunSpiritController.Instance.FinishFindSunSpirit();
			}
		}

		// Token: 0x0603AEDC RID: 241372 RVA: 0x010A7767 File Offset: 0x010A5967
		private void OnTriggerButtonClick()
		{
			this.TriggerModifierAsync();
		}

		// Token: 0x0603AEDD RID: 241373 RVA: 0x010A7770 File Offset: 0x010A5970
		private UniTask TriggerModifierAsync()
		{
			FindSunSpiritView.<TriggerModifierAsync>d__9 <TriggerModifierAsync>d__;
			<TriggerModifierAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerModifierAsync>d__.<>4__this = this;
			<TriggerModifierAsync>d__.<>1__state = -1;
			<TriggerModifierAsync>d__.<>t__builder.Start<FindSunSpiritView.<TriggerModifierAsync>d__9>(ref <TriggerModifierAsync>d__);
			return <TriggerModifierAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEDE RID: 241374 RVA: 0x010A77B3 File Offset: 0x010A59B3
		private void OnResetButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			this.ResetFindSunSpirit();
		}

		// Token: 0x0603AEDF RID: 241375 RVA: 0x010A77C4 File Offset: 0x010A59C4
		private void OnCloseButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.FinishFindSunSpirit();
			base.CloseMe(null);
		}

		// Token: 0x0603AEE0 RID: 241376 RVA: 0x010A77E0 File Offset: 0x010A59E0
		private void OnLeftButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.SelectModifier(false);
		}

		// Token: 0x0603AEE1 RID: 241377 RVA: 0x010A77F6 File Offset: 0x010A59F6
		private void OnRightButtonClick()
		{
			if (this.DisableInput)
			{
				return;
			}
			FindSunSpiritController.Instance.SelectModifier(true);
		}

		// Token: 0x0603AEE2 RID: 241378 RVA: 0x010A780C File Offset: 0x010A5A0C
		private void ResetFindSunSpirit()
		{
			FindSunSpiritController.Instance.ResetFindSunSpirit(delegate
			{
				this.DisableInput = false;
				this.RefreshTriggerTimes();
			});
		}

		// Token: 0x0603AEE3 RID: 241379 RVA: 0x010A7824 File Offset: 0x010A5A24
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

		// Token: 0x0401EFBA RID: 126906
		private bool DisableInput;

		// Token: 0x0401EFBB RID: 126907
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200B8FA RID: 47354
		private class EComponentType
		{
			// Token: 0x0403914D RID: 233805
			public const int CaptionItem = 0;

			// Token: 0x0403914E RID: 233806
			public const int LeftBtn = 1;

			// Token: 0x0403914F RID: 233807
			public const int RightBtn = 2;

			// Token: 0x04039150 RID: 233808
			public const int TriggerBtn = 3;

			// Token: 0x04039151 RID: 233809
			public const int ResetBtn = 4;

			// Token: 0x04039152 RID: 233810
			public const int TimesText = 5;
		}
	}
}
