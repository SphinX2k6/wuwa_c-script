using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DED RID: 3565
public class MediumItemGridRoleTowerElementComponent : MediumItemGridComponent
{
	// Token: 0x060090A8 RID: 37032 RVA: 0x002B5D2E File Offset: 0x002B3F2E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBElementB3";
	}

	// Token: 0x060090A9 RID: 37033 RVA: 0x002B5D38 File Offset: 0x002B3F38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060090AA RID: 37034 RVA: 0x002B5D80 File Offset: 0x002B3F80
	protected override UniTask OnBeforeStartAsync()
	{
		MediumItemGridRoleTowerElementComponent.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemGridRoleTowerElementComponent.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060090AB RID: 37035 RVA: 0x002B5DC4 File Offset: 0x002B3FC4
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (!(data is int))
		{
			this.SetActive(false);
			return;
		}
		int elementId = (int)data;
		ElementInfo? elementInfo = ElementInfoConfig.Instance.GetElementInfo(elementId);
		if (elementInfo == null || string.IsNullOrEmpty(elementInfo.Value.Icon))
		{
			this.SetActive(false);
			return;
		}
		MediumItemGridRoleTowerElementComponent.RoleTowerElementIconItem elementIconItem = this.ElementIconItem;
		if (elementIconItem != null)
		{
			elementIconItem.Update(elementInfo.Value.Icon, elementInfo.Value.ElementColor);
		}
		this.SetActive(true);
	}

	// Token: 0x040055EF RID: 21999
	[Nullable(2)]
	private MediumItemGridRoleTowerElementComponent.RoleTowerElementIconItem ElementIconItem;

	// Token: 0x02007021 RID: 28705
	private class EChildType
	{
		// Token: 0x040249A8 RID: 149928
		public const int ElementItem = 0;
	}

	// Token: 0x02007022 RID: 28706
	private class RoleTowerElementIconItem : UiPanelBase
	{
		// Token: 0x06040003 RID: 262147 RVA: 0x012BDE04 File Offset: 0x012BC004
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040004 RID: 262148 RVA: 0x012BDE70 File Offset: 0x012BC070
		[NullableContext(1)]
		public void Update(string iconPath, string color)
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetColor(FColor.FromHex(color));
			}
			base.SetTextureByPath(iconPath, base.GetTexture(1), null, null);
		}

		// Token: 0x0200BC08 RID: 48136
		private class EChildType
		{
			// Token: 0x04039CCB RID: 236747
			public const int ElementBgSprite = 0;

			// Token: 0x04039CCC RID: 236748
			public const int ElementIconTexture = 1;
		}
	}
}
