using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200242B RID: 9259
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManagerConfigNewFetterItem : GridProxyAbstract<IPhantomManagerFetterInfo>
{
	// Token: 0x06012921 RID: 76065 RVA: 0x00493D18 File Offset: 0x00491F18
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06012922 RID: 76066 RVA: 0x00493DC4 File Offset: 0x00491FC4
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigNewFetterItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigNewFetterItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012923 RID: 76067 RVA: 0x00493E08 File Offset: 0x00492008
	[NullableContext(1)]
	public override void Refresh(IPhantomManagerFetterInfo data, bool isSelected, int gridIndex)
	{
		this.CurrentId = data.FetterId;
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.FetterId);
		PhantomManagerConfigNewElementItem elementItem = this.ElementItem;
		if (elementItem != null)
		{
			elementItem.Refresh(fetterGroupById.FetterElementPath);
		}
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(fetterGroupById.FetterGroupName);
		UUIText text = base.GetText(1);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendFormatted(configTextByKey);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		if (this.IsSelectOnCb != null)
		{
			this.SetSelected(this.IsSelectOnCb(data.FetterId), false);
		}
		bool fetterConfigIsOpen = PhantomBattleModel.Instance.GetPhantomConfigData().GetFetterConfigIsOpen(data.FetterId);
		UUISprite sprite = base.GetSprite(3);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(fetterConfigIsOpen);
	}

	// Token: 0x06012924 RID: 76068 RVA: 0x00493EF4 File Offset: 0x004920F4
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null && this.CurrentId > 0)
		{
			this.SetSelected(this.IsSelectOnCb(this.CurrentId), false);
		}
	}

	// Token: 0x06012925 RID: 76069 RVA: 0x00493F1F File Offset: 0x0049211F
	private void SetSelected(bool selected, bool fireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06012926 RID: 76070 RVA: 0x00493F38 File Offset: 0x00492138
	private void OnToggleStateChange(EToggleState state)
	{
		Action<int> onToggleStateChangeFunction = this.OnToggleStateChangeFunction;
		if (onToggleStateChangeFunction == null)
		{
			return;
		}
		onToggleStateChangeFunction(this.CurrentId);
	}

	// Token: 0x04008BF6 RID: 35830
	private PhantomManagerConfigNewElementItem ElementItem;

	// Token: 0x04008BF7 RID: 35831
	private int CurrentId;

	// Token: 0x04008BF8 RID: 35832
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x04008BF9 RID: 35833
	public Action<int> OnToggleStateChangeFunction;

	// Token: 0x020089AC RID: 35244
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402CBBE RID: 183230
		Toggle,
		// Token: 0x0402CBBF RID: 183231
		Txt,
		// Token: 0x0402CBC0 RID: 183232
		PanelItem,
		// Token: 0x0402CBC1 RID: 183233
		SpriteDone
	}
}
