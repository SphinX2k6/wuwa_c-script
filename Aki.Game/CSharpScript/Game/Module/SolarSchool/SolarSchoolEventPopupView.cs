using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A1C RID: 23068
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolEventPopupView : UiViewBase
	{
		// Token: 0x06038D08 RID: 232712 RVA: 0x00FE743E File Offset: 0x00FE563E
		[NullableContext(1)]
		public SolarSchoolEventPopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038D09 RID: 232713 RVA: 0x00FE7448 File Offset: 0x00FE5648
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D0A RID: 232714 RVA: 0x00FE74D4 File Offset: 0x00FE56D4
		protected override void OnStart()
		{
			this.Param = (this.OpenParam as SolarSchoolEventPopupParam);
			SolarSchoolEventPopupParam param = this.Param;
			this.CloseCallback = ((param != null) ? param.OnCloseCallback : null);
			if (this.Param == null)
			{
				return;
			}
			this.Row = SolarSchoolConfig.Instance.GetSolarSchoolPopup((int)this.Param.PopupId);
			if (this.Row == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 弹窗样式缺配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("popupId", (int)this.Param.PopupId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Start");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Row.Value.AnimStyle);
			uiViewSequence.StartSequenceName = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06038D0B RID: 232715 RVA: 0x00FE75B6 File Offset: 0x00FE57B6
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
		}

		// Token: 0x06038D0C RID: 232716 RVA: 0x00FE75BE File Offset: 0x00FE57BE
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038D0D RID: 232717 RVA: 0x00FE75C7 File Offset: 0x00FE57C7
		protected override void OnBeforeDestroy()
		{
			Action closeCallback = this.CloseCallback;
			this.CloseCallback = null;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06038D0E RID: 232718 RVA: 0x00FE75E0 File Offset: 0x00FE57E0
		private void RefreshTitle()
		{
			int component = 1;
			string textKey = (this.Row != null) ? this.Row.GetValueOrDefault().Title : null;
			SolarSchoolEventPopupParam param = this.Param;
			this.SetTitle(component, textKey, (param != null) ? param.MainTitleParams : null);
			int component2 = 0;
			string textKey2 = (this.Row != null) ? this.Row.GetValueOrDefault().SubTitle : null;
			SolarSchoolEventPopupParam param2 = this.Param;
			this.SetTitle(component2, textKey2, (param2 != null) ? param2.SubTitleParams : null);
		}

		// Token: 0x06038D0F RID: 232719 RVA: 0x00FE7660 File Offset: 0x00FE5860
		private void SetTitle(int component, string textKey, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<string> textParams)
		{
			bool flag = !string.IsNullOrEmpty(textKey);
			UUIItem item = base.GetItem(component);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(component), textKey, textParams ?? Array.Empty<string>());
		}

		// Token: 0x0401DE75 RID: 122485
		private SolarSchoolEventPopupParam Param;

		// Token: 0x0401DE76 RID: 122486
		private SolarSchoolPopup? Row;

		// Token: 0x0401DE77 RID: 122487
		private Action CloseCallback;

		// Token: 0x0200B5E1 RID: 46561
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040383F4 RID: 230388
			public const int TxtSubTitle = 0;

			// Token: 0x040383F5 RID: 230389
			public const int TxtMainTitle = 1;

			// Token: 0x040383F6 RID: 230390
			public const int TexBomBg = 2;
		}
	}
}
