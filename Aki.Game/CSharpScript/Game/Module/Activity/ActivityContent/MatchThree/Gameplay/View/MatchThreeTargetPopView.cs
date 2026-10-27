using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E7 RID: 25831
	public class MatchThreeTargetPopView : UiViewBase
	{
		// Token: 0x06040D75 RID: 265589 RVA: 0x00FB4F54 File Offset: 0x00FB3154
		[NullableContext(1)]
		public MatchThreeTargetPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040D76 RID: 265590 RVA: 0x00FB4F60 File Offset: 0x00FB3160
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040D77 RID: 265591 RVA: 0x00FB4FA8 File Offset: 0x00FB31A8
		protected override void OnStart()
		{
			this.Parameter = (this.OpenParam as MatchThreeTargetPopParam);
			MatchThreeTargetPopParam parameter = this.Parameter;
			IReadOnlyList<LevelGoal> readOnlyList = (parameter != null) ? parameter.Goals : null;
			LevelGoal levelGoal = (readOnlyList != null && readOnlyList.Count > 0) ? readOnlyList[0] : null;
			UUIText text = base.GetText(0);
			if (levelGoal == null)
			{
				if (text != null)
				{
					text.ShowTextNew(EMatchThreeTextId.TargetNone.ToEnumString());
				}
				return;
			}
			if (levelGoal is ReachScoreGoal)
			{
				LguiUtil.Instance.TrySetLocalTextNew(text, EMatchThreeTextId.TargetScore.ToEnumString(), new <>z__ReadOnlySingleElementList<object>(levelGoal.Target));
				return;
			}
			if (levelGoal is ClearTypeCountGoal)
			{
				EPieceType targetType = ((ClearTypeCountGoal)levelGoal).TargetType;
				EMatchThreeTextId value;
				if (targetType != EPieceType.Hourglass)
				{
					if (targetType != EPieceType.Charger)
					{
						if (text != null)
						{
							text.SetUIActive(false);
						}
						return;
					}
					value = EMatchThreeTextId.TargetCharger;
				}
				else
				{
					value = EMatchThreeTextId.TargetHourglass;
				}
				LguiUtil.Instance.TrySetLocalTextNew(text, value.ToEnumString(), new <>z__ReadOnlySingleElementList<object>(levelGoal.Target));
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}

		// Token: 0x06040D78 RID: 265592 RVA: 0x00FB5093 File Offset: 0x00FB3293
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06040D79 RID: 265593 RVA: 0x00FB509C File Offset: 0x00FB329C
		protected override void OnAfterDestroy()
		{
			MatchThreeTargetPopParam parameter = this.Parameter;
			if (parameter != null)
			{
				parameter.OnClosed();
			}
			this.Parameter = null;
		}

		// Token: 0x04021C7E RID: 138366
		[Nullable(2)]
		private MatchThreeTargetPopParam Parameter;

		// Token: 0x0200C727 RID: 50983
		private enum EComponent
		{
			// Token: 0x0403C2AD RID: 246445
			TxtTargetNum
		}
	}
}
