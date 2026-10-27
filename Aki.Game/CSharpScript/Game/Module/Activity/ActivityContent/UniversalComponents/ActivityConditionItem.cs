using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02005F76 RID: 24438
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class ActivityConditionItem : GridProxyAbstract<IActivityConditionData>
	{
		// Token: 0x0603E080 RID: 254080 RVA: 0x00EFA030 File Offset: 0x00EF8230
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

		// Token: 0x0603E081 RID: 254081 RVA: 0x00EFA1E4 File Offset: 0x00EF83E4
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

		// Token: 0x0603E082 RID: 254082 RVA: 0x00EFA348 File Offset: 0x00EF8548
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

		// Token: 0x0402064A RID: 132682
		[Nullable(2)]
		private IActivityConditionData Data;

		// Token: 0x0200C271 RID: 49777
		internal class EItemComponents
		{
			// Token: 0x0403ABD2 RID: 240594
			public const int PanelDone = 0;

			// Token: 0x0403ABD3 RID: 240595
			public const int PanelType1 = 1;

			// Token: 0x0403ABD4 RID: 240596
			public const int PanelType2 = 2;

			// Token: 0x0403ABD5 RID: 240597
			public const int SpriteGoing = 3;

			// Token: 0x0403ABD6 RID: 240598
			public const int Txt = 4;

			// Token: 0x0403ABD7 RID: 240599
			public const int ButtonType1 = 5;

			// Token: 0x0403ABD8 RID: 240600
			public const int SpriteDone = 6;

			// Token: 0x0403ABD9 RID: 240601
			public const int TxtGoing = 7;

			// Token: 0x0403ABDA RID: 240602
			public const int ButtonType2 = 8;
		}
	}
}
