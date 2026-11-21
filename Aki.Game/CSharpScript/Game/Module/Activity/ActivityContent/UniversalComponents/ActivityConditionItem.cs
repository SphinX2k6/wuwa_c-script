using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F5D RID: 20317
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ActivityConditionItem : GridProxyAbstract<IActivityConditionData>
	{
		// Token: 0x0603301A RID: 208922 RVA: 0x00E4BD18 File Offset: 0x00E49F18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.ButtonJumpClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.ButtonJumpClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603301B RID: 208923 RVA: 0x00E4BECC File Offset: 0x00E4A0CC
		[NullableContext(1)]
		public override void Refresh(IActivityConditionData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			bool isFinished = data.IsFinished;
			bool flag = data.OnJump != null || data.AccessId != 0;
			bool flag2 = data.AccessType == 7 || data.OnJump != null;
			bool flag3 = data.AccessType == 16;
			UUIText text = base.GetText(4);
			if (StringUtils.IsEmpty(data.ConditionTextId))
			{
				text.SetText(string.Empty, true);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.ConditionTextId, data.TextParam ?? Array.Empty<object>());
			}
			UUIItem uuiitem = text;
			bool bUseChangeColor = isFinished;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			base.GetItem(0).SetUIActive(isFinished);
			base.GetItem(1).SetUIActive(!isFinished && flag2);
			base.GetItem(2).SetUIActive(!isFinished && !flag2);
			base.GetItem(3).SetUIActive(!isFinished);
			base.GetItem(6).SetUIActive(isFinished);
			base.GetItem(7).SetUIActive(!isFinished && !flag);
			base.GetButton(5).RootUIComp.Get().SetUIActive(!isFinished && flag && !flag3);
			base.GetButton(8).RootUIComp.Get().SetUIActive(!isFinished && flag && flag3);
		}

		// Token: 0x0603301C RID: 208924 RVA: 0x00E4C030 File Offset: 0x00E4A230
		private void ButtonJumpClick()
		{
			IActivityConditionData data = this.Data;
			if (((data != null) ? data.OnJump : null) != null)
			{
				this.Data.OnJump();
				return;
			}
			IActivityConditionData data2 = this.Data;
			int? num = (data2 != null) ? new int?(data2.AccessId) : null;
			if (num != null && num.GetValueOrDefault() != 0)
			{
				SkipTaskManager.RunByConfigId(this.Data.AccessId, null);
			}
		}

		// Token: 0x0401B11C RID: 110876
		[Nullable(2)]
		private IActivityConditionData Data;

		// Token: 0x0200AC7C RID: 44156
		internal class EItemComponents
		{
			// Token: 0x040355AE RID: 218542
			public const int PanelDone = 0;

			// Token: 0x040355AF RID: 218543
			public const int PanelType1 = 1;

			// Token: 0x040355B0 RID: 218544
			public const int PanelType2 = 2;

			// Token: 0x040355B1 RID: 218545
			public const int SpriteGoing = 3;

			// Token: 0x040355B2 RID: 218546
			public const int Txt = 4;

			// Token: 0x040355B3 RID: 218547
			public const int ButtonType1 = 5;

			// Token: 0x040355B4 RID: 218548
			public const int SpriteDone = 6;

			// Token: 0x040355B5 RID: 218549
			public const int TxtGoing = 7;

			// Token: 0x040355B6 RID: 218550
			public const int ButtonType2 = 8;
		}
	}
}
