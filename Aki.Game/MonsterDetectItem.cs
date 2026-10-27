using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001696 RID: 5782
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MonsterDetectItem : GridProxyAbstract<MonsterDetectionRecord>
{
	// Token: 0x0600A513 RID: 42259 RVA: 0x0024D503 File Offset: 0x0024B703
	public void BindCallback(Action<int, UUIExtendToggle> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x0600A514 RID: 42260 RVA: 0x0024D50C File Offset: 0x0024B70C
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

	// Token: 0x0600A515 RID: 42261 RVA: 0x0024D5B8 File Offset: 0x0024B7B8
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

	// Token: 0x0600A516 RID: 42262 RVA: 0x0024D636 File Offset: 0x0024B836
	protected override void OnBeforeDestroy()
	{
		this.ExtendToggle.OnStateChange.Clear();
		this.ExtendToggle.OnPostAudioEvent.Unbind();
		this.ExtendToggle.OnPostAudioStateEvent.Unbind();
	}

	// Token: 0x0600A517 RID: 42263 RVA: 0x0024D668 File Offset: 0x0024B868
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

	// Token: 0x0600A518 RID: 42264 RVA: 0x0024D774 File Offset: 0x0024B974
	public override void OnSelected(bool fireEvent)
	{
		this.Selected(true, true);
	}

	// Token: 0x0600A519 RID: 42265 RVA: 0x0024D77E File Offset: 0x0024B97E
	public override void OnDeselected(bool fireEvent)
	{
		this.Selected(false, true);
	}

	// Token: 0x0600A51A RID: 42266 RVA: 0x0024D788 File Offset: 0x0024B988
	private void OnCallback()
	{
		if (this.OnSelectedCallback != null)
		{
			this.OnSelectedCallback(this.Data.Conf.Id, this.ExtendToggle);
		}
	}

	// Token: 0x0600A51B RID: 42267 RVA: 0x0024D7C1 File Offset: 0x0024B9C1
	private void Selected(bool bSelected, bool fire = true)
	{
		if (bSelected)
		{
			this.ExtendToggle.SetToggleState(EToggleState.ETT_Checked, fire, false, false);
			return;
		}
		this.ExtendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600A51C RID: 42268 RVA: 0x0024D7E8 File Offset: 0x0024B9E8
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).RootUIComp.Get();
	}

	// Token: 0x04004AAF RID: 19119
	[Nullable(2)]
	private MonsterDetectionRecord Data;

	// Token: 0x04004AB0 RID: 19120
	[Nullable(2)]
	private UUIExtendToggle ExtendToggle;

	// Token: 0x04004AB1 RID: 19121
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, UUIExtendToggle> OnSelectedCallback;

	// Token: 0x02007C73 RID: 31859
	[NullableContext(0)]
	private enum EDetectItemNodeDefine
	{
		// Token: 0x04028D48 RID: 167240
		MonsterToggle,
		// Token: 0x04028D49 RID: 167241
		NameText,
		// Token: 0x04028D4A RID: 167242
		UnknownItem,
		// Token: 0x04028D4B RID: 167243
		MonsterTexture
	}
}
