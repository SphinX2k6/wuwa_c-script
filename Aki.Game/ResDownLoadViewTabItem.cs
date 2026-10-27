using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x02002762 RID: 10082
public class ResDownLoadViewTabItem : GridProxyAbstract<int>
{
	// Token: 0x06014AEC RID: 84716 RVA: 0x0053BC80 File Offset: 0x00539E80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014AED RID: 84717 RVA: 0x0053BD0C File Offset: 0x00539F0C
	protected override void OnStart()
	{
		UUIExtendToggle toggle = base.GetExtendToggle(0);
		toggle.OnStateChange.Add(delegate(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.OnClickExtendToggleCallBack != null)
			{
				this.OnClickExtendToggleCallBack(this.TabIndex, this.ResType, toggle);
			}
		});
	}

	// Token: 0x06014AEE RID: 84718 RVA: 0x0053BD50 File Offset: 0x00539F50
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TabIndex = data;
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		if (this.TabIndex == 3)
		{
			if (playerGender == EPlayerGender.Male)
			{
				this.ResType = 4;
			}
			else
			{
				this.ResType = 3;
			}
		}
		else if (playerGender == EPlayerGender.Male)
		{
			this.ResType = 3;
		}
		else
		{
			this.ResType = 4;
		}
		DownLoadTab? config = ConfigDownLoadTabById.GetConfig(this.TabIndex, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.Title, Array.Empty<object>());
		long videoResSize = VideoResUpdate.Instance.GetVideoResSize((EVideoResSizeType)this.ResType);
		if (videoResSize == VideoResUpdate.Instance.GetVideoResSavedSize((EVideoResSizeType)this.ResType))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "HaveDownLoadRes", Array.Empty<object>());
			return;
		}
		base.GetText(2).SetText(HotFixManager.ByteConverter(videoResSize), true);
	}

	// Token: 0x06014AEF RID: 84719 RVA: 0x0053BE27 File Offset: 0x0053A027
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06014AF0 RID: 84720 RVA: 0x0053BE3A File Offset: 0x0053A03A
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04009B64 RID: 39780
	private int TabIndex;

	// Token: 0x04009B65 RID: 39781
	private int ResType;

	// Token: 0x04009B66 RID: 39782
	[Nullable(1)]
	public Action<int, int, UUIExtendToggle> OnClickExtendToggleCallBack;

	// Token: 0x02008DCB RID: 36299
	private enum EResDownLoadViewTabItem
	{
		// Token: 0x0402E047 RID: 188487
		Toggle,
		// Token: 0x0402E048 RID: 188488
		NameText,
		// Token: 0x0402E049 RID: 188489
		SpaceText
	}
}
