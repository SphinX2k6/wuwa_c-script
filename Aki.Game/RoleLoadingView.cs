using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001554 RID: 5460
public class RoleLoadingView : LoadingViewBase
{
	// Token: 0x0600DAA0 RID: 55968 RVA: 0x0040B4A5 File Offset: 0x004096A5
	[NullableContext(1)]
	public RoleLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DAA1 RID: 55969 RVA: 0x0040B4B0 File Offset: 0x004096B0
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

	// Token: 0x0600DAA2 RID: 55970 RVA: 0x0040B57C File Offset: 0x0040977C
	protected override void OnStart()
	{
		base.OnStart();
		this.InitContent();
	}

	// Token: 0x0600DAA3 RID: 55971 RVA: 0x0040B58C File Offset: 0x0040978C
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

	// Token: 0x0600DAA4 RID: 55972 RVA: 0x0040B68F File Offset: 0x0040988F
	protected override void UpdateProgressRate(float rate)
	{
		base.GetSprite(0).SetFillAmount(rate);
	}

	// Token: 0x0600DAA5 RID: 55973 RVA: 0x0040B69E File Offset: 0x0040989E
	protected override void UpdateProgressValue(float value)
	{
		this.SetTextProgressValue(1, value, "%");
	}

	// Token: 0x020077F0 RID: 30704
	private class EChildType
	{
		// Token: 0x04026EBD RID: 159421
		public const int Progress = 0;

		// Token: 0x04026EBE RID: 159422
		public const int ProgressText = 1;

		// Token: 0x04026EBF RID: 159423
		public const int Tips = 2;

		// Token: 0x04026EC0 RID: 159424
		public const int RoleTexture = 3;

		// Token: 0x04026EC1 RID: 159425
		public const int RoleName = 4;
	}
}
