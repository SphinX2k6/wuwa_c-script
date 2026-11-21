using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A0C RID: 2572
[NullableContext(1)]
[Nullable(0)]
public class ActivityTitleTypeA : UiPanelBase
{
	// Token: 0x06007031 RID: 28721 RVA: 0x00226E64 File Offset: 0x00225064
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

	// Token: 0x06007032 RID: 28722 RVA: 0x0022707C File Offset: 0x0022527C
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

	// Token: 0x06007033 RID: 28723 RVA: 0x002270B4 File Offset: 0x002252B4
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

	// Token: 0x06007034 RID: 28724 RVA: 0x002270C8 File Offset: 0x002252C8
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

	// Token: 0x06007035 RID: 28725 RVA: 0x00227238 File Offset: 0x00225438
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

	// Token: 0x06007036 RID: 28726 RVA: 0x002272AC File Offset: 0x002254AC
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

	// Token: 0x06007037 RID: 28727 RVA: 0x0022731F File Offset: 0x0022551F
	private void OnClickToggle(EToggleState _)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityTagInfoHelpView, new int[]
		{
			this.TagId_1,
			this.TagId_2
		}, null);
	}

	// Token: 0x06007038 RID: 28728 RVA: 0x00227349 File Offset: 0x00225549
	public void SetTitleByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), textId, args);
	}

	// Token: 0x06007039 RID: 28729 RVA: 0x0022735E File Offset: 0x0022555E
	public void SetTitleByText(string text)
	{
		UUIText text2 = base.GetText(0);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600703A RID: 28730 RVA: 0x00227374 File Offset: 0x00225574
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

	// Token: 0x0600703B RID: 28731 RVA: 0x002273B4 File Offset: 0x002255B4
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

	// Token: 0x0600703C RID: 28732 RVA: 0x002273FD File Offset: 0x002255FD
	public void SetTimeTextByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
	}

	// Token: 0x0600703D RID: 28733 RVA: 0x00227414 File Offset: 0x00225614
	public void SetBgTextureByPath(string path, [Nullable(2)] Action<bool> callback = null)
	{
		base.SetTextureByPath(path, base.GetTexture(2), null, callback);
	}

	// Token: 0x0600703E RID: 28734 RVA: 0x00227439 File Offset: 0x00225639
	public void SetBgTextureVisible(bool bVisible)
	{
		UUITexture texture = base.GetTexture(2);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(bVisible);
	}

	// Token: 0x0600703F RID: 28735 RVA: 0x0022744D File Offset: 0x0022564D
	public void SetSubTitleVisible(bool bVisible)
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06007040 RID: 28736 RVA: 0x00227461 File Offset: 0x00225661
	public void SetSubTitleByTextId(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, args);
	}

	// Token: 0x06007041 RID: 28737 RVA: 0x00227476 File Offset: 0x00225676
	public void SetSubTitleByText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x06007042 RID: 28738 RVA: 0x0022748B File Offset: 0x0022568B
	public void SetSubTitleIconVisible(bool bVisible)
	{
		UUISprite sprite = base.GetSprite(4);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(bVisible);
	}

	// Token: 0x06007043 RID: 28739 RVA: 0x002274A0 File Offset: 0x002256A0
	public void SetSubTitleIconByPath(string path, [Nullable(2)] Action<bool> callback = null)
	{
		this.SetSpriteByPath(path, base.GetSprite(4), true, null, callback);
	}

	// Token: 0x06007044 RID: 28740 RVA: 0x002274C8 File Offset: 0x002256C8
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

	// Token: 0x06007045 RID: 28741 RVA: 0x002274FC File Offset: 0x002256FC
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

	// Token: 0x04004523 RID: 17699
	[Nullable(2)]
	private ActivityBaseData ActivityData;

	// Token: 0x04004524 RID: 17700
	private int TagId_1;

	// Token: 0x04004525 RID: 17701
	private int TagId_2;

	// Token: 0x02006D1F RID: 27935
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023D23 RID: 146723
		public const int Title = 0;

		// Token: 0x04023D24 RID: 146724
		public const int TextTime = 1;

		// Token: 0x04023D25 RID: 146725
		public const int BgTexture = 2;

		// Token: 0x04023D26 RID: 146726
		public const int SubTitle = 3;

		// Token: 0x04023D27 RID: 146727
		public const int SubTitleIcon = 4;

		// Token: 0x04023D28 RID: 146728
		public const int TogActPlayType = 5;

		// Token: 0x04023D29 RID: 146729
		public const int ItemActType = 6;

		// Token: 0x04023D2A RID: 146730
		public const int SprActType = 7;

		// Token: 0x04023D2B RID: 146731
		public const int TxtActType = 8;

		// Token: 0x04023D2C RID: 146732
		public const int ItemPlayType = 9;

		// Token: 0x04023D2D RID: 146733
		public const int SprPlayType = 10;

		// Token: 0x04023D2E RID: 146734
		public const int TxtPlayType = 11;

		// Token: 0x04023D2F RID: 146735
		public const int PnlLimitedTime = 12;
	}
}
