using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E47 RID: 7751
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookItem : UiPanelBase, IDynamicScrollItem<WeaponHandBookDynamicData>
{
	// Token: 0x0600EBB9 RID: 60345 RVA: 0x0037F0B4 File Offset: 0x0037D2B4
	public UniTask Init(UUIItem actor)
	{
		WeaponHandBookItem.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<WeaponHandBookItem.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBBA RID: 60346 RVA: 0x0037F0FF File Offset: 0x0037D2FF
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600EBBB RID: 60347 RVA: 0x0037F138 File Offset: 0x0037D338
	private UniTask InitChildItem()
	{
		WeaponHandBookItem.<InitChildItem>d__6 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<WeaponHandBookItem.<InitChildItem>d__6>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBBC RID: 60348 RVA: 0x0037F17B File Offset: 0x0037D37B
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(WeaponHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600EBBD RID: 60349 RVA: 0x0037F1AD File Offset: 0x0037D3AD
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600EBBE RID: 60350 RVA: 0x0037F1B8 File Offset: 0x0037D3B8
	public void Update(WeaponHandBookDynamicData data, int gridIndex)
	{
		WeaponHandBookTitleItem weaponHandBookTitleItem = this.WeaponHandBookTitleItem;
		if (weaponHandBookTitleItem != null)
		{
			weaponHandBookTitleItem.SetUiActive(false);
		}
		WeaponHandBookLayoutItem weaponHandBookLayoutItem = this.WeaponHandBookLayoutItem;
		if (weaponHandBookLayoutItem != null)
		{
			weaponHandBookLayoutItem.SetUiActive(false);
		}
		if (string.IsNullOrEmpty(data.TitleId))
		{
			if (data.ItemData != null)
			{
				WeaponHandBookLayoutItem weaponHandBookLayoutItem2 = this.WeaponHandBookLayoutItem;
				if (weaponHandBookLayoutItem2 != null)
				{
					weaponHandBookLayoutItem2.SetUiActive(true);
				}
				WeaponHandBookLayoutItem weaponHandBookLayoutItem3 = this.WeaponHandBookLayoutItem;
				if (weaponHandBookLayoutItem3 == null)
				{
					return;
				}
				weaponHandBookLayoutItem3.Update(data.ItemData);
			}
			return;
		}
		WeaponHandBookTitleItem weaponHandBookTitleItem2 = this.WeaponHandBookTitleItem;
		if (weaponHandBookTitleItem2 != null)
		{
			weaponHandBookTitleItem2.SetUiActive(true);
		}
		WeaponHandBookTitleItem weaponHandBookTitleItem3 = this.WeaponHandBookTitleItem;
		if (weaponHandBookTitleItem3 == null)
		{
			return;
		}
		weaponHandBookTitleItem3.Update(data.TitleId);
	}

	// Token: 0x04006D4F RID: 27983
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x04006D50 RID: 27984
	[Nullable(2)]
	private WeaponHandBookTitleItem WeaponHandBookTitleItem;

	// Token: 0x04006D51 RID: 27985
	[Nullable(2)]
	private WeaponHandBookLayoutItem WeaponHandBookLayoutItem;

	// Token: 0x020083F7 RID: 33783
	[NullableContext(0)]
	private class EWeaponDynamicItemDefine
	{
		// Token: 0x0402AF56 RID: 175958
		public const int TitleItem = 0;

		// Token: 0x0402AF57 RID: 175959
		public const int LayoutItem = 1;
	}
}
