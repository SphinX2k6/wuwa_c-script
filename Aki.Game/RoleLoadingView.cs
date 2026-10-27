using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002081 RID: 8321
public class RoleLoadingView : LoadingViewBase
{
	// Token: 0x06010638 RID: 67128 RVA: 0x003FF05D File Offset: 0x003FD25D
	[NullableContext(1)]
	public RoleLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010639 RID: 67129 RVA: 0x003FF068 File Offset: 0x003FD268
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601063A RID: 67130 RVA: 0x003FF134 File Offset: 0x003FD334
	protected override void OnStart()
	{
		base.OnStart();
		this.InitContent();
	}

	// Token: 0x0601063B RID: 67131 RVA: 0x003FF144 File Offset: 0x003FD344
	private void InitContent()
	{
		CharacterDisplayStyle? roleLoading = LoadingModel.Instance.RoleLoading;
		if (roleLoading == null)
		{
			return;
		}
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CharacterDisplayStyle_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleLoading.Value.Id);
		defaultInterpolatedStringHandler.AppendLiteral("_Desc");
		instance.SetLocalTextNew(text, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
		LguiUtil instance2 = LguiUtil.Instance;
		UUIText text2 = base.GetText(4);
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("CharacterDisplayStyle_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleLoading.Value.Id);
		defaultInterpolatedStringHandler.AppendLiteral("_Name");
		instance2.SetLocalTextNew(text2, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
		base.SetTextureByPath(roleLoading.Value.IllustrationAsset, base.GetTexture(3), new EUiViewName?(this.ViewInfo.Name), null);
		LoadingModel.Instance.ClearRoleLoadingInfo();
	}

	// Token: 0x0601063C RID: 67132 RVA: 0x003FF247 File Offset: 0x003FD447
	protected override void UpdateProgressRate(float rate)
	{
		base.GetSprite(0).SetFillAmount(rate);
	}

	// Token: 0x0601063D RID: 67133 RVA: 0x003FF256 File Offset: 0x003FD456
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(1, value, "%");
	}

	// Token: 0x02008669 RID: 34409
	private class EChildType
	{
		// Token: 0x0402BBAE RID: 179118
		public const int Progress = 0;

		// Token: 0x0402BBAF RID: 179119
		public const int ProgressText = 1;

		// Token: 0x0402BBB0 RID: 179120
		public const int Tips = 2;

		// Token: 0x0402BBB1 RID: 179121
		public const int RoleTexture = 3;

		// Token: 0x0402BBB2 RID: 179122
		public const int RoleName = 4;
	}
}
