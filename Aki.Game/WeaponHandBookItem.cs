using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001309 RID: 4873
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookItem : UiPanelBase, IDynamicScrollItem<WeaponHandBookDynamicData>
{
	// Token: 0x0600BFD8 RID: 49112 RVA: 0x0038AD44 File Offset: 0x00388F44
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

	// Token: 0x0600BFD9 RID: 49113 RVA: 0x0038AD8F File Offset: 0x00388F8F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x0038ADC8 File Offset: 0x00388FC8
	private UniTask InitChildItem()
	{
		WeaponHandBookItem.<InitChildItem>d__6 <InitChildItem>d__;
		<InitChildItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitChildItem>d__.<>4__this = this;
		<InitChildItem>d__.<>1__state = -1;
		<InitChildItem>d__.<>t__builder.Start<WeaponHandBookItem.<InitChildItem>d__6>(ref <InitChildItem>d__);
		return <InitChildItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFDB RID: 49115 RVA: 0x0038AE0B File Offset: 0x0038900B
	[return: Nullable(2)]
	public AUIBaseActor GetUsingItem(WeaponHandBookDynamicData data)
	{
		if (!string.IsNullOrEmpty(data.TitleId))
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600BFDC RID: 49116 RVA: 0x0038AE3D File Offset: 0x0038903D
	public void ClearItem()
	{
		base.Destroy(null);
	}

	// Token: 0x0600BFDD RID: 49117 RVA: 0x0038AE48 File Offset: 0x00389048
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

	// Token: 0x04006E30 RID: 28208
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x04006E31 RID: 28209
	[Nullable(2)]
	private WeaponHandBookTitleItem WeaponHandBookTitleItem;

	// Token: 0x04006E32 RID: 28210
	[Nullable(2)]
	private WeaponHandBookLayoutItem WeaponHandBookLayoutItem;

	// Token: 0x0200757C RID: 30076
	[NullableContext(0)]
	private class EWeaponDynamicItemDefine
	{
		// Token: 0x0402627A RID: 156282
		public const int TitleItem = 0;

		// Token: 0x0402627B RID: 156283
		public const int LayoutItem = 1;
	}
}
