using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CC RID: 22988
	public class SolarSchoolFavorLevelUpPopupView : UiViewBase
	{
		// Token: 0x06038A88 RID: 232072 RVA: 0x00FDB1E3 File Offset: 0x00FD93E3
		[NullableContext(1)]
		public SolarSchoolFavorLevelUpPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038A89 RID: 232073 RVA: 0x00FDB1EC File Offset: 0x00FD93EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.CloseSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038A8A RID: 232074 RVA: 0x00FDB2F8 File Offset: 0x00FD94F8
		protected unsafe override void OnStart()
		{
			SolarSchoolFavorLevelUpPopupParam solarSchoolFavorLevelUpPopupParam = this.OpenParam as SolarSchoolFavorLevelUpPopupParam;
			if (solarSchoolFavorLevelUpPopupParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.SWC, "[SolarSchool] 好感等级提升弹窗打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(solarSchoolFavorLevelUpPopupParam.RoleId);
			SolarSchoolRoleFavorLevel? roleFavorLevel = SolarSchoolConfig.Instance.GetRoleFavorLevel(solarSchoolFavorLevelUpPopupParam.RoleId, solarSchoolFavorLevelUpPopupParam.FinalLevel);
			if (role == null || roleFavorLevel == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 好感等级提升弹窗配置缺失";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", solarSchoolFavorLevelUpPopupParam.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("previousLevel", solarSchoolFavorLevelUpPopupParam.PreviousLevel);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("finalLevel", solarSchoolFavorLevelUpPopupParam.FinalLevel);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			base.SetTextureByPath(role.Value.PopupIcon, base.GetTexture(0), null, null);
			base.SetTextureByPath(SolarSchoolPopupData.GetFavorLevelIcon(solarSchoolFavorLevelUpPopupParam.FinalLevel, ESolarSchoolFavorIconSize.Large), base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), roleFavorLevel.Value.SkillDesc, Array.Empty<object>());
			if (solarSchoolFavorLevelUpPopupParam.PreviousLevel == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SolarSchool_FondnessGet", new <>z__ReadOnlyArray<object>(new object[]
				{
					new TableTextArgNew(role.Value.Name, Array.Empty<object>()),
					new TableTextArgNew(SolarSchoolPopupData.GetFavorLevelTextKey(solarSchoolFavorLevelUpPopupParam.FinalLevel), Array.Empty<object>())
				}));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SolarSchool_FondnessChange", new <>z__ReadOnlyArray<object>(new object[]
			{
				new TableTextArgNew(role.Value.Name, Array.Empty<object>()),
				new TableTextArgNew(SolarSchoolPopupData.GetFavorLevelTextKey(solarSchoolFavorLevelUpPopupParam.PreviousLevel), Array.Empty<object>()),
				new TableTextArgNew(SolarSchoolPopupData.GetFavorLevelTextKey(solarSchoolFavorLevelUpPopupParam.FinalLevel), Array.Empty<object>())
			}));
		}

		// Token: 0x06038A8B RID: 232075 RVA: 0x00FDB540 File Offset: 0x00FD9740
		protected override void OnBeforeDestroy()
		{
			SolarSchoolFavorLevelUpPopupParam solarSchoolFavorLevelUpPopupParam = this.OpenParam as SolarSchoolFavorLevelUpPopupParam;
			if (solarSchoolFavorLevelUpPopupParam == null)
			{
				return;
			}
			Action closeCallback = solarSchoolFavorLevelUpPopupParam.CloseCallback;
			solarSchoolFavorLevelUpPopupParam.CloseCallback = null;
			try
			{
				if (closeCallback != null)
				{
					closeCallback();
				}
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 好感等级提升弹窗关闭回调异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("exception", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0200B585 RID: 46469
		private class EComponent
		{
			// Token: 0x0403820F RID: 229903
			public const int TexRole = 0;

			// Token: 0x04038210 RID: 229904
			public const int TexIcon = 1;

			// Token: 0x04038211 RID: 229905
			public const int TxtTitle = 2;

			// Token: 0x04038212 RID: 229906
			public const int TxtDetails = 3;

			// Token: 0x04038213 RID: 229907
			public const int BtnConfirmBase = 4;
		}
	}
}
