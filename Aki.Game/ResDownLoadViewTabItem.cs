using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

// Token: 0x02001C4D RID: 7245
public class ResDownLoadViewTabItem : GridProxyAbstract<int>
{
	// Token: 0x06011FCF RID: 73679 RVA: 0x0054AA90 File Offset: 0x00548C90
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

	// Token: 0x06011FD0 RID: 73680 RVA: 0x0054AB1C File Offset: 0x00548D1C
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

	// Token: 0x06011FD1 RID: 73681 RVA: 0x0054AB60 File Offset: 0x00548D60
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

	// Token: 0x06011FD2 RID: 73682 RVA: 0x0054AC37 File Offset: 0x00548E37
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06011FD3 RID: 73683 RVA: 0x0054AC4A File Offset: 0x00548E4A
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return data;
	}

	// Token: 0x04009CBC RID: 40124
	private int TabIndex;

	// Token: 0x04009CBD RID: 40125
	private int ResType;

	// Token: 0x04009CBE RID: 40126
	[Nullable(1)]
	public Action<int, int, UUIExtendToggle> OnClickExtendToggleCallBack;

	// Token: 0x02007F53 RID: 32595
	private enum EResDownLoadViewTabItem
	{
		// Token: 0x0402935C RID: 168796
		Toggle,
		// Token: 0x0402935D RID: 168797
		NameText,
		// Token: 0x0402935E RID: 168798
		SpaceText
	}
}
