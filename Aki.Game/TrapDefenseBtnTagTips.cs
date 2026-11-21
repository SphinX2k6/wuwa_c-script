using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200219B RID: 8603
public class TrapDefenseBtnTagTips : UiPanelBase
{
	// Token: 0x060152C3 RID: 86723 RVA: 0x00628C24 File Offset: 0x00626E24
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

	// Token: 0x060152C4 RID: 86724 RVA: 0x00628C6F File Offset: 0x00626E6F
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x060152C5 RID: 86725 RVA: 0x00628C74 File Offset: 0x00626E74
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

	// Token: 0x060152C6 RID: 86726 RVA: 0x00628D20 File Offset: 0x00626F20
	protected override UniTask OnBeforeStartAsync()
	{
		TrapDefenseBtnTagTips.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBtnTagTips.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060152C7 RID: 86727 RVA: 0x00628D63 File Offset: 0x00626F63
	protected override void OnStart()
	{
	}

	// Token: 0x060152C8 RID: 86728 RVA: 0x00628D65 File Offset: 0x00626F65
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x060152C9 RID: 86729 RVA: 0x00628D67 File Offset: 0x00626F67
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060152CA RID: 86730 RVA: 0x00628D6C File Offset: 0x00626F6C
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

	// Token: 0x060152CB RID: 86731 RVA: 0x00628DE4 File Offset: 0x00626FE4
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

	// Token: 0x060152CC RID: 86732 RVA: 0x00628E50 File Offset: 0x00627050
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

	// Token: 0x060152CD RID: 86733 RVA: 0x00628EC0 File Offset: 0x006270C0
	[NullableContext(1)]
	public void SetDesc(string textKey, params string[] args)
	{
		UUIText text = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text, textKey, args);
	}

	// Token: 0x02008456 RID: 33878
	private class EChildType
	{
		// Token: 0x0402AB08 RID: 174856
		public const int ItemBgGold = 0;

		// Token: 0x0402AB09 RID: 174857
		public const int ItemBgPurple = 1;

		// Token: 0x0402AB0A RID: 174858
		public const int SpriteArrow = 2;

		// Token: 0x0402AB0B RID: 174859
		public const int TextDesc = 3;
	}
}
