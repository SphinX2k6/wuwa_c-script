using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051E2 RID: 20962
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardCheckComponent : CardComponentBase<ICardCheckComponentData>
	{
		// Token: 0x06035A28 RID: 219688 RVA: 0x00CB4B44 File Offset: 0x00CB2D44
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnCheckBtnClick))
			};
		}

		// Token: 0x06035A29 RID: 219689 RVA: 0x00CB4BAB File Offset: 0x00CB2DAB
		public override void Refresh(ICardCheckComponentData data)
		{
			this.Data = data;
			this.RefreshLeftCount();
			this.OnCheckBtnClickInternal = data.OnCheckBtnClick;
		}

		// Token: 0x06035A2A RID: 219690 RVA: 0x00CB4BC8 File Offset: 0x00CB2DC8
		public void RefreshLeftCount()
		{
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.LeftCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.MaxCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06035A2B RID: 219691 RVA: 0x00CB4C22 File Offset: 0x00CB2E22
		protected void OnCheckBtnClick()
		{
			Action onCheckBtnClickInternal = this.OnCheckBtnClickInternal;
			if (onCheckBtnClickInternal == null)
			{
				return;
			}
			onCheckBtnClickInternal();
		}

		// Token: 0x06035A2C RID: 219692 RVA: 0x00CB4C34 File Offset: 0x00CB2E34
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIButtonComponent button = base.GetButton(1);
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
			if (tweakObjectPtr == null)
			{
				return null;
			}
			UUIItem[] array = new UUIItem[2];
			int num = 0;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr2 = tweakObjectPtr;
			array[num] = ((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
			int num2 = 1;
			tweakObjectPtr2 = tweakObjectPtr;
			array[num2] = ((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
			return array;
		}

		// Token: 0x0401C766 RID: 116582
		protected ICardCheckComponentData Data;

		// Token: 0x0401C767 RID: 116583
		private Action OnCheckBtnClickInternal;

		// Token: 0x0200B368 RID: 45928
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036600 RID: 222720
			public const int CountText = 0;

			// Token: 0x04036601 RID: 222721
			public const int CheckBtn = 1;
		}
	}
}
