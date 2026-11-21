using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001910 RID: 6416
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManagerConfigNewFetterItem : GridProxyAbstract<IPhantomManagerFetterInfo>
{
	// Token: 0x0600FDD7 RID: 64983 RVA: 0x004A12E4 File Offset: 0x0049F4E4
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

	// Token: 0x0600FDD8 RID: 64984 RVA: 0x004A1390 File Offset: 0x0049F590
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomManagerConfigNewFetterItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomManagerConfigNewFetterItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FDD9 RID: 64985 RVA: 0x004A13D4 File Offset: 0x0049F5D4
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

	// Token: 0x0600FDDA RID: 64986 RVA: 0x004A14C0 File Offset: 0x0049F6C0
	public override void OnSelected(bool fireEvent)
	{
		if (this.IsSelectOnCb != null && this.CurrentId > 0)
		{
			this.SetSelected(this.IsSelectOnCb(this.CurrentId), false);
		}
	}

	// Token: 0x0600FDDB RID: 64987 RVA: 0x004A14EB File Offset: 0x0049F6EB
	private void SetSelected(bool selected, bool fireEvent = false)
	{
		base.GetExtendToggle(0).SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0600FDDC RID: 64988 RVA: 0x004A1504 File Offset: 0x0049F704
	private void OnToggleStateChange(EToggleState state)
	{
		Action<int> onToggleStateChangeFunction = this.OnToggleStateChangeFunction;
		if (onToggleStateChangeFunction == null)
		{
			return;
		}
		onToggleStateChangeFunction(this.CurrentId);
	}

	// Token: 0x04008D3D RID: 36157
	private PhantomManagerConfigNewElementItem ElementItem;

	// Token: 0x04008D3E RID: 36158
	private int CurrentId;

	// Token: 0x04008D3F RID: 36159
	public Func<int, bool> IsSelectOnCb;

	// Token: 0x04008D40 RID: 36160
	public Action<int> OnToggleStateChangeFunction;

	// Token: 0x02007B33 RID: 31539
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027ED4 RID: 163540
		Toggle,
		// Token: 0x04027ED5 RID: 163541
		Txt,
		// Token: 0x04027ED6 RID: 163542
		PanelItem,
		// Token: 0x04027ED7 RID: 163543
		SpriteDone
	}
}
