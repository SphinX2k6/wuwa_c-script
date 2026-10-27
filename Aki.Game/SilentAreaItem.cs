using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020016BB RID: 5819
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SilentAreaItem : GridProxyAbstract<ISilentAreaDetectionDynamicData>
{
	// Token: 0x0600A612 RID: 42514 RVA: 0x0025206B File Offset: 0x0025026B
	public void BindCallback(Action<int, UUIExtendToggle> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x0600A613 RID: 42515 RVA: 0x00252074 File Offset: 0x00250274
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

	// Token: 0x0600A614 RID: 42516 RVA: 0x00252100 File Offset: 0x00250300
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

	// Token: 0x0600A615 RID: 42517 RVA: 0x0025217E File Offset: 0x0025037E
	protected override void OnBeforeDestroy()
	{
		this.ExtendToggle.OnStateChange.Clear();
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x0600A616 RID: 42518 RVA: 0x002521B0 File Offset: 0x002503B0
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

	// Token: 0x0600A617 RID: 42519 RVA: 0x002522AE File Offset: 0x002504AE
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x0600A618 RID: 42520 RVA: 0x002522B8 File Offset: 0x002504B8
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x0600A619 RID: 42521 RVA: 0x002522C4 File Offset: 0x002504C4
	private void OnCallback()
	{
		if (this.OnSelectedCallback != null && this.Data != null)
		{
			this.OnSelectedCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x0600A61A RID: 42522 RVA: 0x00252305 File Offset: 0x00250505
	private void Selected(bool bSelected, bool fire = true)
	{
		if (bSelected)
		{
			this.ExtendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
			return;
		}
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04004AFD RID: 19197
	[Nullable(2)]
	private SilentAreaDetectionRecord Data;

	// Token: 0x04004AFE RID: 19198
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004AFF RID: 19199
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnSelectedCallback;

	// Token: 0x02007C8F RID: 31887
	[NullableContext(0)]
	private enum EDetectItemNodeDefine
	{
		// Token: 0x04028DE0 RID: 167392
		MonsterToggle,
		// Token: 0x04028DE1 RID: 167393
		NameText,
		// Token: 0x04028DE2 RID: 167394
		NormalIcon
	}
}
