using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Goals;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x02005465 RID: 21605
	public class MatchThreeTargetPopView : UiViewBase
	{
		// Token: 0x06035A39 RID: 219705 RVA: 0x00EFBF84 File Offset: 0x00EFA184
		[NullableContext(1)]
		public MatchThreeTargetPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035A3A RID: 219706 RVA: 0x00EFBF90 File Offset: 0x00EFA190
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

		// Token: 0x06035A3B RID: 219707 RVA: 0x00EFBFD8 File Offset: 0x00EFA1D8
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

		// Token: 0x06035A3C RID: 219708 RVA: 0x00EFC0C3 File Offset: 0x00EFA2C3
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035A3D RID: 219709 RVA: 0x00EFC0CC File Offset: 0x00EFA2CC
		protected override void OnAfterDestroy()
		{
			MatchThreeTargetPopParam parameter = this.Parameter;
			if (parameter != null)
			{
				parameter.OnClosed();
			}
			this.Parameter = null;
		}

		// Token: 0x0401C5AF RID: 116143
		[Nullable(2)]
		private MatchThreeTargetPopParam Parameter;

		// Token: 0x0200B10D RID: 45325
		private enum EComponent
		{
			// Token: 0x04036C08 RID: 224264
			TxtTargetNum
		}
	}
}
