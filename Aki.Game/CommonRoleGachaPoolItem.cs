using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C7C RID: 7292
public class CommonRoleGachaPoolItem : GachaPoolItem
{
	// Token: 0x0600DBEC RID: 56300 RVA: 0x00332D60 File Offset: 0x00330F60
	public CommonRoleGachaPoolItem(GachaDefine.EGachaViewType gachaType) : base(gachaType)
	{
	}

	// Token: 0x0600DBED RID: 56301 RVA: 0x00332D6C File Offset: 0x00330F6C
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

	// Token: 0x0600DBEE RID: 56302 RVA: 0x00332E38 File Offset: 0x00331038
	protected override UniTask OnBeforeStartAsync()
	{
		CommonRoleGachaPoolItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonRoleGachaPoolItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DBEF RID: 56303 RVA: 0x00332E7C File Offset: 0x0033107C
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

	// Token: 0x040064E9 RID: 25833
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<RoleDescribeComponent> DescComponentList;

	// Token: 0x0200823B RID: 33339
	private enum EComponent
	{
		// Token: 0x0402A7D4 RID: 174036
		ContentTexture,
		// Token: 0x0402A7D5 RID: 174037
		DescItem1,
		// Token: 0x0402A7D6 RID: 174038
		DescItem2,
		// Token: 0x0402A7D7 RID: 174039
		DescItem3,
		// Token: 0x0402A7D8 RID: 174040
		ThemeTextTexture
	}
}
