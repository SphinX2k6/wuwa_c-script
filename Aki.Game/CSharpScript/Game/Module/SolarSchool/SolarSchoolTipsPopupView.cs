using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059DC RID: 23004
	public class SolarSchoolTipsPopupView : UiViewBase
	{
		// Token: 0x06038A9F RID: 232095 RVA: 0x00FDBA03 File Offset: 0x00FD9C03
		[NullableContext(1)]
		public SolarSchoolTipsPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038AA0 RID: 232096 RVA: 0x00FDBA0C File Offset: 0x00FD9C0C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.CloseSelf));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.CloseSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038AA1 RID: 232097 RVA: 0x00FDBBE4 File Offset: 0x00FD9DE4
		protected override void OnStart()
		{
			SolarSchoolTipsPopupParam solarSchoolTipsPopupParam = this.OpenParam as SolarSchoolTipsPopupParam;
			if (solarSchoolTipsPopupParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 道具提示弹窗打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(solarSchoolTipsPopupParam.ShowTitle);
			}
			this.UiViewSequence.StartSequenceName = (solarSchoolTipsPopupParam.ShowTitle ? "Start01" : "Start02");
			SolarSchoolItem? item2 = SolarSchoolConfig.Instance.GetItem(solarSchoolTipsPopupParam.ItemId);
			if (item2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 道具提示弹窗道具不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", solarSchoolTipsPopupParam.ItemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			base.SetTextureByPath(item2.Value.Icon, base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), item2.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), item2.Value.Desc, Array.Empty<object>());
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(solarSchoolTipsPopupParam.Count > 0);
			}
			if (solarSchoolTipsPopupParam.Count > 0)
			{
				UUIText text = base.GetText(4);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("x");
					defaultInterpolatedStringHandler.AppendFormatted<int>(solarSchoolTipsPopupParam.Count);
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			bool flag = !string.IsNullOrEmpty(item2.Value.SourceDesc);
			UUIText text2 = base.GetText(8);
			if (text2 != null)
			{
				UUIItem parentAsUIItem = text2.GetParentAsUIItem();
				if (parentAsUIItem != null)
				{
					parentAsUIItem.SetUIActive(flag);
				}
			}
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(8), item2.Value.SourceDesc, Array.Empty<object>());
			}
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolItemTipsRefreshed, solarSchoolTipsPopupParam.ItemId);
		}

		// Token: 0x06038AA2 RID: 232098 RVA: 0x00FDBDF1 File Offset: 0x00FD9FF1
		protected override void OnBeforeDestroy()
		{
			SolarSchoolTipsPopupParam solarSchoolTipsPopupParam = this.OpenParam as SolarSchoolTipsPopupParam;
			if (solarSchoolTipsPopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolTipsPopupParam.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0200B587 RID: 46471
		private class EComponent
		{
			// Token: 0x04038218 RID: 229912
			public const int Mask = 0;

			// Token: 0x04038219 RID: 229913
			public const int BtnBack = 1;

			// Token: 0x0403821A RID: 229914
			public const int PnlTitle = 2;

			// Token: 0x0403821B RID: 229915
			public const int TexIcon = 3;

			// Token: 0x0403821C RID: 229916
			public const int TxtNum = 4;

			// Token: 0x0403821D RID: 229917
			public const int TxtTitle = 5;

			// Token: 0x0403821E RID: 229918
			public const int TxtDetails = 6;

			// Token: 0x0403821F RID: 229919
			public const int PnlWay = 7;

			// Token: 0x04038220 RID: 229920
			public const int TxtWay = 8;

			// Token: 0x04038221 RID: 229921
			public const int BtnConfirm = 9;
		}
	}
}
