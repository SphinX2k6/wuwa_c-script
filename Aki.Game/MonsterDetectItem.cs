using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000B4E RID: 2894
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MonsterDetectItem : GridProxyAbstract<MonsterDetectionRecord>
{
	// Token: 0x060078F3 RID: 30963 RVA: 0x00257887 File Offset: 0x00255A87
	public void BindCallback(Action<int, UUIExtendToggle> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x060078F4 RID: 30964 RVA: 0x00257890 File Offset: 0x00255A90
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060078F5 RID: 30965 RVA: 0x0025793C File Offset: 0x00255B3C
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

	// Token: 0x060078F6 RID: 30966 RVA: 0x002579BA File Offset: 0x00255BBA
	protected override void OnBeforeDestroy()
	{
		this.ExtendToggle.OnStateChange.Clear();
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x060078F7 RID: 30967 RVA: 0x002579EC File Offset: 0x00255BEC
	public override void Refresh(MonsterDetectionRecord data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIItem item = base.GetItem(2);
		UUITexture texture = base.GetTexture(3);
		if (data.IsLock)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_UnDiscovered_Text", Array.Empty<object>());
			item.SetUIActive(true);
			texture.SetUIActive(false);
		}
		else
		{
			MonsterInfo value = MonsterInfoConfig.Instance.GetMonsterInfoConfig(data.Conf.MonsterInfoId).Value;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Name, Array.Empty<object>());
			item.SetUIActive(false);
			texture.SetUIActive(true);
			base.SetTextureByPath(value.Icon, texture, null, null);
		}
		this.RootItem.SetUIActive(true);
		int? currentMonsterId = AdventureGuideModel.Instance.CurrentMonsterId;
		int id = data.Conf.Id;
		bool flag = currentMonsterId.GetValueOrDefault() == id & currentMonsterId != null;
		this.Selected(flag, false);
		if (flag)
		{
			this.OnCallback();
		}
	}

	// Token: 0x060078F8 RID: 30968 RVA: 0x00257AF8 File Offset: 0x00255CF8
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x060078F9 RID: 30969 RVA: 0x00257B02 File Offset: 0x00255D02
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x060078FA RID: 30970 RVA: 0x00257B0C File Offset: 0x00255D0C
	private void OnCallback()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x060078FB RID: 30971 RVA: 0x00257B45 File Offset: 0x00255D45
	private void Selected(bool bSelected, bool fire = true)
	{
		if (bSelected)
		{
			this.ExtendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
			return;
		}
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060078FC RID: 30972 RVA: 0x00257B6C File Offset: 0x00255D6C
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).RootUIComp.Get();
	}

	// Token: 0x04004B56 RID: 19286
	[Nullable(2)]
	private MonsterDetectionRecord Data;

	// Token: 0x04004B57 RID: 19287
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004B58 RID: 19288
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnSelectedCallback;

	// Token: 0x02006DF8 RID: 28152
	[NullableContext(0)]
	private enum EDetectItemNodeDefine
	{
		// Token: 0x04024071 RID: 147569
		MonsterToggle,
		// Token: 0x04024072 RID: 147570
		NameText,
		// Token: 0x04024073 RID: 147571
		UnknownItem,
		// Token: 0x04024074 RID: 147572
		MonsterTexture
	}
}
