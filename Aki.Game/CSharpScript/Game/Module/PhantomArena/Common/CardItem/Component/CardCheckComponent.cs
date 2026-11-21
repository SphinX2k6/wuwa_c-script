using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B2 RID: 16818
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardCheckComponent : CardComponentBase<ICardCheckComponentData>
	{
		// Token: 0x0602A923 RID: 174371 RVA: 0x00C02180 File Offset: 0x00C00380
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

		// Token: 0x0602A924 RID: 174372 RVA: 0x00C021E7 File Offset: 0x00C003E7
		public override void Refresh(ICardCheckComponentData data)
		{
			this.Data = data;
			this.RefreshLeftCount();
			this.OnCheckBtnClickInternal = data.OnCheckBtnClick;
		}

		// Token: 0x0602A925 RID: 174373 RVA: 0x00C02204 File Offset: 0x00C00404
		public void RefreshLeftCount()
		{
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.LeftCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.MaxCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602A926 RID: 174374 RVA: 0x00C0225E File Offset: 0x00C0045E
		protected void OnCheckBtnClick()
		{
			Action onCheckBtnClickInternal = this.OnCheckBtnClickInternal;
			if (onCheckBtnClickInternal == null)
			{
				return;
			}
			onCheckBtnClickInternal();
		}

		// Token: 0x0602A927 RID: 174375 RVA: 0x00C02270 File Offset: 0x00C00470
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

		// Token: 0x0401719B RID: 94619
		protected ICardCheckComponentData Data;

		// Token: 0x0401719C RID: 94620
		private Action OnCheckBtnClickInternal;

		// Token: 0x02009DA0 RID: 40352
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04031053 RID: 200787
			public const int CountText = 0;

			// Token: 0x04031054 RID: 200788
			public const int CheckBtn = 1;
		}
	}
}
