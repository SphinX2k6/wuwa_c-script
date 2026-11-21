using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003760 RID: 14176
	public class MapTipsActivateTipPanel : UiPanelBase
	{
		// Token: 0x06024DB9 RID: 150969 RVA: 0x00A6AC58 File Offset: 0x00A68E58
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

		// Token: 0x06024DBA RID: 150970 RVA: 0x00A6AD1F File Offset: 0x00A68F1F
		protected override void OnStart()
		{
			this.SetDistanceTips();
		}

		// Token: 0x06024DBB RID: 150971 RVA: 0x00A6AD27 File Offset: 0x00A68F27
		private void OnClickHelpButton()
		{
			HelpController.Instance.OpenHelpById(119);
		}

		// Token: 0x06024DBC RID: 150972 RVA: 0x00A6AD38 File Offset: 0x00A68F38
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

		// Token: 0x06024DBD RID: 150973 RVA: 0x00A6AD94 File Offset: 0x00A68F94
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

		// Token: 0x06024DBE RID: 150974 RVA: 0x00A6ADD4 File Offset: 0x00A68FD4
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

		// Token: 0x040146E7 RID: 83687
		private const int HELP_ID = 119;

		// Token: 0x020094B8 RID: 38072
		public static class EComponents
		{
			// Token: 0x0402E741 RID: 190273
			public const int SprLock = 0;

			// Token: 0x0402E742 RID: 190274
			public const int TxtActivated = 1;

			// Token: 0x0402E743 RID: 190275
			public const int BtnFunctionA = 2;
		}
	}
}
