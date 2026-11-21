using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005D0 RID: 1488
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerBuffItem : GridProxyAbstract<IBabelTowerBuffItemData>
{
	// Token: 0x06004632 RID: 17970 RVA: 0x00180B54 File Offset: 0x0017ED54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnToggleClickInternal));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x00180CA0 File Offset: 0x0017EEA0
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerBuffItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerBuffItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004634 RID: 17972 RVA: 0x00180CE3 File Offset: 0x0017EEE3
	private void OnToggleClickInternal(EToggleState state)
	{
		Action<int> onToggleClick = this.OnToggleClick;
		if (onToggleClick == null)
		{
			return;
		}
		onToggleClick(base.GridIndex);
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x00180CFC File Offset: 0x0017EEFC
	[NullableContext(1)]
	public override void Refresh(IBabelTowerBuffItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		extendToggle.SetSelfInteractive(data.CanClick);
		extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		string nameText;
		string texture;
		int star;
		if (this.Data.IsDeTerm)
		{
			BabelTowerDeTerm value = ConfigBabelTowerDeTermById.GetConfig(this.Data.Id, true).Value;
			nameText = value.NameText;
			texture = value.Texture;
			star = value.Star;
		}
		else
		{
			BabelTowerBuff value2 = ConfigBabelTowerBuffById.GetConfig(this.Data.Id, true).Value;
			nameText = value2.NameText;
			texture = value2.Texture;
			star = value2.Star;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), nameText, Array.Empty<object>());
		base.SetTextureByPath(texture, base.GetTexture(1), null, null);
		if (data.ShowStar.GetValueOrDefault())
		{
			this.StarItem.SetActive(true);
			this.StarItem.SetText(star.ToString());
		}
		else
		{
			this.StarItem.SetActive(false);
		}
		int qualityId = BabelTowerModel.Instance.CoverStarNumToQualityId(star);
		base.SetQualityIconById(base.GetSprite(0), qualityId, null, null, null);
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x00180E4D File Offset: 0x0017F04D
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x00180E60 File Offset: 0x0017F060
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040035A5 RID: 13733
	private IBabelTowerBuffItemData Data;

	// Token: 0x040035A6 RID: 13734
	private BabelTowerBuffStarItem StarItem;

	// Token: 0x040035A7 RID: 13735
	public Action<int> OnToggleClick;

	// Token: 0x02006876 RID: 26742
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040226F5 RID: 141045
		public const int QualitySprite = 0;

		// Token: 0x040226F6 RID: 141046
		public const int IconTexture = 1;

		// Token: 0x040226F7 RID: 141047
		public const int NameText = 2;

		// Token: 0x040226F8 RID: 141048
		public const int BgSprite = 3;

		// Token: 0x040226F9 RID: 141049
		public const int AdditionItem = 4;

		// Token: 0x040226FA RID: 141050
		public const int BottomAdditionItem = 5;

		// Token: 0x040226FB RID: 141051
		public const int BuffToggle = 6;
	}
}
