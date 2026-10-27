using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002C20 RID: 11296
public class TrapDefenseBtnTagTips : UiPanelBase
{
	// Token: 0x06017891 RID: 96401 RVA: 0x005FC200 File Offset: 0x005FA400
	[NullableContext(1)]
	public UniTask Init(UUIItem item)
	{
		TrapDefenseBtnTagTips.<Init>d__1 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<TrapDefenseBtnTagTips.<Init>d__1>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06017892 RID: 96402 RVA: 0x005FC24B File Offset: 0x005FA44B
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06017893 RID: 96403 RVA: 0x005FC250 File Offset: 0x005FA450
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06017894 RID: 96404 RVA: 0x005FC2FC File Offset: 0x005FA4FC
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBtnTagTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBtnTagTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017895 RID: 96405 RVA: 0x005FC33F File Offset: 0x005FA53F
	protected override void OnStart()
	{
	}

	// Token: 0x06017896 RID: 96406 RVA: 0x005FC341 File Offset: 0x005FA541
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06017897 RID: 96407 RVA: 0x005FC343 File Offset: 0x005FA543
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06017898 RID: 96408 RVA: 0x005FC348 File Offset: 0x005FA548
	public void UpdateQuality(ETrapDefenseBdBuffQuality quality)
	{
		UUISprite sprite = base.GetSprite(2);
		FColor? fcolor;
		if (quality == ETrapDefenseBdBuffQuality.Purple)
		{
			this.ShowBg(1);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = true;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			return;
		}
		if (quality != ETrapDefenseBdBuffQuality.Gold)
		{
			this.ShowBg(1);
			UUIItem uuiitem2 = sprite;
			bool bUseChangeColor2 = true;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			return;
		}
		this.ShowBg(0);
		UUIItem uuiitem3 = sprite;
		bool bUseChangeColor3 = false;
		fcolor = new FColor?(sprite.changeColor);
		uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
	}

	// Token: 0x06017899 RID: 96409 RVA: 0x005FC3C0 File Offset: 0x005FA5C0
	public void UpdateDescForBuffSelect(ETrapDefenseBdBuffQuality quality)
	{
		if (quality == ETrapDefenseBdBuffQuality.Purple)
		{
			this.SetDesc(ETrapDefenseTextKey.BdBuffSelectPurpleBuffToPool.ToString(), Array.Empty<string>());
			return;
		}
		if (quality != ETrapDefenseBdBuffQuality.Gold)
		{
			this.SetDesc(ETrapDefenseTextKey.BdBuffSelectPurpleBuffToPool.ToString(), Array.Empty<string>());
			return;
		}
		this.SetDesc(ETrapDefenseTextKey.BdBuffSelectGoldBuffToPool.ToString(), Array.Empty<string>());
	}

	// Token: 0x0601789A RID: 96410 RVA: 0x005FC42C File Offset: 0x005FA62C
	private void ShowBg(int key)
	{
		foreach (int num in new List<int>
		{
			1,
			0
		})
		{
			UUIItem item = base.GetItem(num);
			if (item != null)
			{
				item.SetUIActive(num == key);
			}
		}
	}

	// Token: 0x0601789B RID: 96411 RVA: 0x005FC49C File Offset: 0x005FA69C
	[NullableContext(1)]
	public void SetDesc(string textKey, params string[] args)
	{
		UUIText text = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text, textKey, args);
	}

	// Token: 0x02009213 RID: 37395
	private class EChildType
	{
		// Token: 0x0402F407 RID: 193543
		public const int ItemBgGold = 0;

		// Token: 0x0402F408 RID: 193544
		public const int ItemBgPurple = 1;

		// Token: 0x0402F409 RID: 193545
		public const int SpriteArrow = 2;

		// Token: 0x0402F40A RID: 193546
		public const int TextDesc = 3;
	}
}
