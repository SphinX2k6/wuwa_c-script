using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CA RID: 22986
	public class SolarSchoolBuildPopupView : UiViewBase
	{
		// Token: 0x06038A72 RID: 232050 RVA: 0x00FDAA5C File Offset: 0x00FD8C5C
		[NullableContext(1)]
		public SolarSchoolBuildPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038A73 RID: 232051 RVA: 0x00FDAA68 File Offset: 0x00FD8C68
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.CloseSelf));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A74 RID: 232052 RVA: 0x00FDAB98 File Offset: 0x00FD8D98
		protected override void OnStart()
		{
			SolarSchoolBuildPopupParam solarSchoolBuildPopupParam = this.OpenParam as SolarSchoolBuildPopupParam;
			if (solarSchoolBuildPopupParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 建筑弹窗打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Param = solarSchoolBuildPopupParam;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), solarSchoolBuildPopupParam.TipsKey, solarSchoolBuildPopupParam.TipsArgs);
			if (!string.IsNullOrEmpty(solarSchoolBuildPopupParam.IconPath))
			{
				base.SetTextureByPath(solarSchoolBuildPopupParam.IconPath, base.GetTexture(3), null, null);
			}
		}

		// Token: 0x06038A75 RID: 232053 RVA: 0x00FDAC22 File Offset: 0x00FD8E22
		protected override void OnBeforeDestroy()
		{
			this.Param = null;
			SolarSchoolBuildPopupParam solarSchoolBuildPopupParam = this.OpenParam as SolarSchoolBuildPopupParam;
			if (solarSchoolBuildPopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolBuildPopupParam.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06038A76 RID: 232054 RVA: 0x00FDAC4A File Offset: 0x00FD8E4A
		private void OnConfirmClick()
		{
			SolarSchoolBuildPopupParam param = this.Param;
			if (param != null)
			{
				Action onConfirm = param.OnConfirm;
				if (onConfirm != null)
				{
					onConfirm();
				}
			}
			this.CloseSelf();
		}

		// Token: 0x0401DD44 RID: 122180
		[Nullable(2)]
		private SolarSchoolBuildPopupParam Param;

		// Token: 0x0200B57D RID: 46461
		private class EComponent
		{
			// Token: 0x040381EE RID: 229870
			public const int Mask = 0;

			// Token: 0x040381EF RID: 229871
			public const int BtnBack = 1;

			// Token: 0x040381F0 RID: 229872
			public const int TxtTitle = 2;

			// Token: 0x040381F1 RID: 229873
			public const int TexIcon = 3;

			// Token: 0x040381F2 RID: 229874
			public const int BtnConfirm = 4;
		}
	}
}
