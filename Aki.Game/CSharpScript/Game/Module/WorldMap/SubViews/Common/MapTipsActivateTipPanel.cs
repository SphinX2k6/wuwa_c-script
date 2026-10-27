using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x0200482F RID: 18479
	public class MapTipsActivateTipPanel : UiPanelBase
	{
		// Token: 0x060305E9 RID: 198121 RVA: 0x00B3AB8C File Offset: 0x00B38D8C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060305EA RID: 198122 RVA: 0x00B3AC53 File Offset: 0x00B38E53
		protected override void OnStart()
		{
			this.SetDistanceTips();
		}

		// Token: 0x060305EB RID: 198123 RVA: 0x00B3AC5B File Offset: 0x00B38E5B
		private void OnClickHelpButton()
		{
			HelpController.Instance.OpenHelpById(119);
		}

		// Token: 0x060305EC RID: 198124 RVA: 0x00B3AC6C File Offset: 0x00B38E6C
		[NullableContext(2)]
		public void SetHideTip(string hideReason)
		{
			if (hideReason != null)
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetText(hideReason, true);
				}
			}
			else
			{
				this.SetActivatedTip("PlayPointClearDesc_Text", null);
			}
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x060305ED RID: 198125 RVA: 0x00B3ACC8 File Offset: 0x00B38EC8
		public void SetDistanceTips()
		{
			this.SetActivatedTip("QuickTravelOverDistance_Text", null);
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x060305EE RID: 198126 RVA: 0x00B3AD08 File Offset: 0x00B38F08
		[NullableContext(1)]
		public void SetActivatedTip(string textId, bool? showBtn = null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
			if (showBtn != null)
			{
				UUIButtonComponent button = base.GetButton(2);
				if (button == null)
				{
					return;
				}
				button.RootUIComp.Get().SetUIActive(showBtn.Value);
			}
		}

		// Token: 0x0401A033 RID: 106547
		private const int HELP_ID = 119;

		// Token: 0x0200AB09 RID: 43785
		public static class EComponents
		{
			// Token: 0x04033FC1 RID: 212929
			public const int SprLock = 0;

			// Token: 0x04033FC2 RID: 212930
			public const int TxtActivated = 1;

			// Token: 0x04033FC3 RID: 212931
			public const int BtnFunctionA = 2;
		}
	}
}
