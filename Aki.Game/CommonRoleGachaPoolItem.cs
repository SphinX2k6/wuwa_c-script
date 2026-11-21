using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200113B RID: 4411
public class CommonRoleGachaPoolItem : GachaPoolItem
{
	// Token: 0x0600B002 RID: 45058 RVA: 0x0033E1C0 File Offset: 0x0033C3C0
	public CommonRoleGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600B003 RID: 45059 RVA: 0x0033E1CC File Offset: 0x0033C3CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B004 RID: 45060 RVA: 0x0033E298 File Offset: 0x0033C498
	protected override UniTask OnBeforeStartAsync()
	{
		CommonRoleGachaPoolItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonRoleGachaPoolItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B005 RID: 45061 RVA: 0x0033E2DC File Offset: 0x0033C4DC
	public override void Refresh()
	{
		if (this.GachaViewInfo == null)
		{
			return;
		}
		int[] showIdListArray = this.GachaViewInfo.Value.GetShowIdListArray();
		int num = 0;
		while (num < showIdListArray.Length && num < this.DescComponentList.Count)
		{
			this.DescComponentList[num].Update(showIdListArray[num], false);
			num++;
		}
		base.SetTextureByPath(this.GachaViewInfo.Value.TextTexture, base.GetTexture(4), null, null);
	}

	// Token: 0x040065BB RID: 26043
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<RoleDescribeComponent> DescComponentList;

	// Token: 0x020073C4 RID: 29636
	private enum EComponent
	{
		// Token: 0x04025AFA RID: 154362
		ContentTexture,
		// Token: 0x04025AFB RID: 154363
		DescItem1,
		// Token: 0x04025AFC RID: 154364
		DescItem2,
		// Token: 0x04025AFD RID: 154365
		DescItem3,
		// Token: 0x04025AFE RID: 154366
		ThemeTextTexture
	}
}
