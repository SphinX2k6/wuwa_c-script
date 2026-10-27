using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001554 RID: 5460
[NullableContext(1)]
[Nullable(0)]
public class ActivityTitleTypeA : UiPanelBase
{
	// Token: 0x06009C53 RID: 40019 RVA: 0x0021D0B4 File Offset: 0x0021B2B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009C54 RID: 40020 RVA: 0x0021D2CC File Offset: 0x0021B4CC
	protected override void OnStart()
	{
		this.SetSubTitleVisible(false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(5);
		if (extendToggle == null)
		{
			return;
		}
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(false);
	}

	// Token: 0x06009C55 RID: 40021 RVA: 0x0021D304 File Offset: 0x0021B504
	[NullableContext(2)]
	public void SetActivityBaseData(ActivityBaseData data)
	{
		if (data == null)
		{
			return;
		}
		this.ActivityData = data;
		this.SetPnlActTypeByConfig();
	}

	// Token: 0x06009C56 RID: 40022 RVA: 0x0021D318 File Offset: 0x0021B518
	private void SetPnlActTypeByConfig()
	{
		if (this.ActivityData == null)
		{
			return;
		}
		Activity? localConfig = this.ActivityData.LocalConfig;
		if (localConfig == null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(5);
			if (extendToggle == null)
			{
				return;
			}
			UUIItem uuiitem = extendToggle.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(false);
			return;
		}
		else
		{
			bool flag = localConfig.Value.ShowActTypeIds().Length >= 1;
			bool flag2 = localConfig.Value.ShowActTypeIds().Length >= 2;
			if (flag)
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(5);
				if (extendToggle2 != null)
				{
					UUIItem uuiitem2 = extendToggle2.RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(true);
					}
				}
				UUIItem item = base.GetItem(6);
				if (item != null)
				{
					item.SetUIActive(flag);
				}
				UUIItem item2 = base.GetItem(9);
				if (item2 != null)
				{
					item2.SetUIActive(flag2);
				}
				if (flag && localConfig.Value.ShowActTypeIds()[0] != 0)
				{
					this.TagId_1 = localConfig.Value.ShowActTypeIds()[0];
					this.SetActTypeTogByConfig(this.TagId_1);
				}
				if (flag2 && localConfig.Value.ShowActTypeIds()[1] != 0)
				{
					this.TagId_2 = localConfig.Value.ShowActTypeIds()[1];
					this.SetPlayTypeTogBtnByConfig(this.TagId_2);
				}
				return;
			}
			UUIExtendToggle extendToggle3 = base.GetExtendToggle(5);
			if (extendToggle3 == null)
			{
				return;
			}
			UUIItem uuiitem3 = extendToggle3.RootUIComp.Get();
			if (uuiitem3 == null)
			{
				return;
			}
			uuiitem3.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06009C57 RID: 40023 RVA: 0x0021D488 File Offset: 0x0021B688
	private void SetActTypeTogByConfig(int id)
	{
		ActivityTitleTags? activityTitleTags = ActivityConfig.Instance.GetActivityTitleTags(id);
		if (activityTitleTags == null)
		{
			return;
		}
		string togIcon = activityTitleTags.Value.TogIcon;
		this.SetSpriteByPath(togIcon, base.GetSprite(7), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), activityTitleTags.Value.TagName, Array.Empty<object>());
	}

	// Token: 0x06009C58 RID: 40024 RVA: 0x0021D4FC File Offset: 0x0021B6FC
	private void SetPlayTypeTogBtnByConfig(int id)
	{
		ActivityTitleTags? activityTitleTags = ActivityConfig.Instance.GetActivityTitleTags(id);
		if (activityTitleTags == null)
		{
			return;
		}
		string togIcon = activityTitleTags.Value.TogIcon;
		this.SetSpriteByPath(togIcon, base.GetSprite(10), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), activityTitleTags.Value.TagName, Array.Empty<object>());
	}

	// Token: 0x06009C59 RID: 40025 RVA: 0x0021D56F File Offset: 0x0021B76F
	private void OnClickToggle(EToggleState _)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityTagInfoHelpView, new int[]
		{
			this.TagId_1,
			this.TagId_2
		}, null);
	}

	// Token: 0x06009C5A RID: 40026 RVA: 0x0021D599 File Offset: 0x0021B799
	public void SetTitleByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06009C5B RID: 40027 RVA: 0x0021D5AE File Offset: 0x0021B7AE
	public void SetTitleByText(string text)
	{
		UUIText text2 = base.GetText(0);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06009C5C RID: 40028 RVA: 0x0021D5C4 File Offset: 0x0021B7C4
	public void SetTimeTextByText(string text)
	{
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "[活动][DEBUG] SetTimeTextByText.Text不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06009C5D RID: 40029 RVA: 0x0021D604 File Offset: 0x0021B804
	public void SetTimeTextVisible(bool bVisible)
	{
		if (base.GetText(1) == null)
		{
			Log.Instance.Error(ELogModule.Activity, ELogAuthor.YYZ, "[活动][DEBUG] SetTimeTextVisible.Text不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UUIItem item = base.GetItem(12);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x06009C5E RID: 40030 RVA: 0x0021D64D File Offset: 0x0021B84D
	public void SetTimeTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x06009C5F RID: 40031 RVA: 0x0021D664 File Offset: 0x0021B864
	public void SetBgTextureByPath(string path, [Nullable(2)] Action<bool> callback = null)
	{
		base.SetTextureByPath(path, base.GetTexture(2), null, callback);
	}

	// Token: 0x06009C60 RID: 40032 RVA: 0x0021D689 File Offset: 0x0021B889
	public void SetBgTextureVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x06009C61 RID: 40033 RVA: 0x0021D69D File Offset: 0x0021B89D
	public void SetSubTitleVisible(bool bVisible)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06009C62 RID: 40034 RVA: 0x0021D6B1 File Offset: 0x0021B8B1
	public void SetSubTitleByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x06009C63 RID: 40035 RVA: 0x0021D6C6 File Offset: 0x0021B8C6
	public void SetSubTitleByText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06009C64 RID: 40036 RVA: 0x0021D6DB File Offset: 0x0021B8DB
	public void SetSubTitleIconVisible(bool bVisible)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bVisible);
	}

	// Token: 0x06009C65 RID: 40037 RVA: 0x0021D6F0 File Offset: 0x0021B8F0
	public void SetSubTitleIconByPath(string path, [Nullable(2)] Action<bool> callback = null)
	{
		this.SetSpriteByPath(path, base.GetSprite(4), true, null, callback);
	}

	// Token: 0x06009C66 RID: 40038 RVA: 0x0021D718 File Offset: 0x0021B918
	public void SetTogActPlayTypeVisible(bool bVisible)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(5);
		if (extendToggle == null)
		{
			return;
		}
		UUIItem uuiitem = extendToggle.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(bVisible);
	}

	// Token: 0x06009C67 RID: 40039 RVA: 0x0021D74C File Offset: 0x0021B94C
	public void SetTogActPlayTypeInteractive(bool bInteractive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(5);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(bInteractive);
		extendToggle.SetToggleState(bInteractive ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x0400447D RID: 17533
	[Nullable(2)]
	private ActivityBaseData ActivityData;

	// Token: 0x0400447E RID: 17534
	private int TagId_1;

	// Token: 0x0400447F RID: 17535
	private int TagId_2;

	// Token: 0x02007B94 RID: 31636
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289E8 RID: 166376
		public const int Title = 0;

		// Token: 0x040289E9 RID: 166377
		public const int TextTime = 1;

		// Token: 0x040289EA RID: 166378
		public const int BgTexture = 2;

		// Token: 0x040289EB RID: 166379
		public const int SubTitle = 3;

		// Token: 0x040289EC RID: 166380
		public const int SubTitleIcon = 4;

		// Token: 0x040289ED RID: 166381
		public const int TogActPlayType = 5;

		// Token: 0x040289EE RID: 166382
		public const int ItemActType = 6;

		// Token: 0x040289EF RID: 166383
		public const int SprActType = 7;

		// Token: 0x040289F0 RID: 166384
		public const int TxtActType = 8;

		// Token: 0x040289F1 RID: 166385
		public const int ItemPlayType = 9;

		// Token: 0x040289F2 RID: 166386
		public const int SprPlayType = 10;

		// Token: 0x040289F3 RID: 166387
		public const int TxtPlayType = 11;

		// Token: 0x040289F4 RID: 166388
		public const int PnlLimitedTime = 12;
	}
}
