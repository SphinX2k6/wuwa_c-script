using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024C6 RID: 9414
[NullableContext(2)]
[Nullable(0)]
public class VisionFetterSuitItem : GridProxyAbstract<PhantomFetterGroup>
{
	// Token: 0x06012E71 RID: 77425 RVA: 0x004AC69A File Offset: 0x004AA89A
	public VisionFetterSuitItem(UUIItem uiItem = null)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06012E72 RID: 77426 RVA: 0x004AC6AC File Offset: 0x004AA8AC
	public UniTask Init()
	{
		VisionFetterSuitItem.<Init>d__5 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionFetterSuitItem.<Init>d__5>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012E73 RID: 77427 RVA: 0x004AC6F0 File Offset: 0x004AA8F0
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
		if (this.OnItemClick != null)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)));
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.<OnRegisterComponent>g__CallBack|6_0));
			this.BtnBindInfo = list2;
		}
	}

	// Token: 0x06012E74 RID: 77428 RVA: 0x004AC7BC File Offset: 0x004AA9BC
	public void Update(PhantomFetterGroup? fetterGroupData)
	{
		this.Data = fetterGroupData;
		string hexStr;
		string path;
		if (fetterGroupData == null)
		{
			hexStr = PhantomBattleConfig.Instance.GetVisionFetterDefaultColor();
			path = PhantomBattleConfig.Instance.GetVisionFetterDefaultTexture();
		}
		else
		{
			hexStr = fetterGroupData.Value.FetterElementColor;
			path = fetterGroupData.Value.FetterElementPath;
		}
		FColor color = FColor.FromHex(hexStr);
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetColor(color);
		}
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
	}

	// Token: 0x06012E75 RID: 77429 RVA: 0x004AC850 File Offset: 0x004AAA50
	public override void Refresh(PhantomFetterGroup data, bool isSelected, int gridIndex)
	{
		this.Update(new PhantomFetterGroup?(data));
	}

	// Token: 0x06012E76 RID: 77430 RVA: 0x004AC860 File Offset: 0x004AAA60
	[CompilerGenerated]
	private void <OnRegisterComponent>g__CallBack|6_0()
	{
		Action<int> onItemClick = this.OnItemClick;
		if (onItemClick == null)
		{
			return;
		}
		onItemClick(this.Data.Value.Id);
	}

	// Token: 0x04008E78 RID: 36472
	private readonly UUIItem SourceItem;

	// Token: 0x04008E79 RID: 36473
	private PhantomFetterGroup? Data;

	// Token: 0x04008E7A RID: 36474
	public Action<int> OnItemClick;

	// Token: 0x02008A47 RID: 35399
	[NullableContext(0)]
	private enum ECommonElementCom
	{
		// Token: 0x0402CE5F RID: 183903
		ElementBgSprite,
		// Token: 0x0402CE60 RID: 183904
		ElementIconTexture,
		// Token: 0x0402CE61 RID: 183905
		ItemButton
	}
}
