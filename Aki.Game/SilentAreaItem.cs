using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B73 RID: 2931
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SilentAreaItem : GridProxyAbstract<ISilentAreaDetectionDynamicData>
{
	// Token: 0x060079F2 RID: 31218 RVA: 0x0025C47B File Offset: 0x0025A67B
	public void BindCallback(Action<int, UUIExtendToggle> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x060079F3 RID: 31219 RVA: 0x0025C484 File Offset: 0x0025A684
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060079F4 RID: 31220 RVA: 0x0025C510 File Offset: 0x0025A710
	protected override void OnStart()
	{
		this.ExtendToggle = base.GetExtendToggle(0);
		this.ExtendToggle.OnStateChange.Add(delegate(EToggleState state)
		{
			this.OnCallback();
		});
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ExtendToggle.OnPostAudioEvent.Bind(delegate(string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
		this.ExtendToggle.OnPostAudioStateEvent.Bind(delegate(EToggleAudioTransitionState state, string eventPath)
		{
			if (!string.IsNullOrEmpty(eventPath))
			{
				base.PostClickAudioEvent(eventPath);
			}
		});
	}

	// Token: 0x060079F5 RID: 31221 RVA: 0x0025C58E File Offset: 0x0025A78E
	protected override void OnBeforeDestroy()
	{
		this.ExtendToggle.OnStateChange.Clear();
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x060079F6 RID: 31222 RVA: 0x0025C5C0 File Offset: 0x0025A7C0
	public override void Refresh(ISilentAreaDetectionDynamicData data, bool isSelected, int gridIndex)
	{
		this.Data = data.SilentAreaDetectionData;
		if (this.Data.IsLock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_UnDiscovered_Text", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.Conf.Name, Array.Empty<object>());
		}
		UUISprite sprite = base.GetSprite(2);
		sprite.SetUIActive(true);
		int dangerType = this.Data.Conf.DangerType;
		this.SetSpriteByPath(AdventureGuideConfig.Instance.GetSecondaryGuideDataConf(dangerType).Value.Icon, sprite, false, null, null);
		this.RootItem.SetUIActive(true);
		bool flag = AdventureGuideModel.Instance.CurrentSilentId == this.Data.Conf.Id;
		this.Selected(flag, false);
		if (flag)
		{
			this.OnCallback();
		}
	}

	// Token: 0x060079F7 RID: 31223 RVA: 0x0025C6BE File Offset: 0x0025A8BE
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x060079F8 RID: 31224 RVA: 0x0025C6C8 File Offset: 0x0025A8C8
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x060079F9 RID: 31225 RVA: 0x0025C6D4 File Offset: 0x0025A8D4
	private void OnCallback()
	{
		if (this.OnSelectedCallback != null && this.Data != null)
		{
			this.OnSelectedCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x060079FA RID: 31226 RVA: 0x0025C715 File Offset: 0x0025A915
	private void Selected(bool bSelected, bool fire = true)
	{
		if (bSelected)
		{
			this.ExtendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
			return;
		}
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04004BA4 RID: 19364
	[Nullable(2)]
	private SilentAreaDetectionRecord Data;

	// Token: 0x04004BA5 RID: 19365
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004BA6 RID: 19366
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnSelectedCallback;

	// Token: 0x02006E14 RID: 28180
	[NullableContext(0)]
	private enum EDetectItemNodeDefine
	{
		// Token: 0x04024109 RID: 147721
		MonsterToggle,
		// Token: 0x0402410A RID: 147722
		NameText,
		// Token: 0x0402410B RID: 147723
		NormalIcon
	}
}
