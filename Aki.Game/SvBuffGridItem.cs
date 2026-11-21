using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200060E RID: 1550
[NullableContext(2)]
[Nullable(0)]
public class SvBuffGridItem : GridProxyAbstract<int>
{
	// Token: 0x06004892 RID: 18578 RVA: 0x001895D8 File Offset: 0x001877D8
	[NullableContext(1)]
	public void SetParentItem(MutexGroupItem parent)
	{
		this.ParentItem = parent;
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x001895E4 File Offset: 0x001877E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x00189690 File Offset: 0x00187890
	protected override UniTask OnBeforeStartAsync()
	{
		SvBuffGridItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SvBuffGridItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x001896D4 File Offset: 0x001878D4
	protected override void OnStart()
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		if (comBuffIns != null)
		{
			comBuffIns.SetActive(true);
		}
		ComBuffSubComponent comBuffIns2 = this.ComBuffIns;
		UUIExtendToggle uuiextendToggle = (comBuffIns2 != null) ? comBuffIns2.GetBuffToggle() : null;
		if (uuiextendToggle != null)
		{
			uuiextendToggle.CanExecuteChange.Bind(delegate()
			{
				MutexGroupItem parentItem = this.ParentItem;
				if (parentItem != null && parentItem.IsQuickSelectMode())
				{
					BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
					{
						IsDeTerm = true,
						ConfigId = this.BuffId,
						ShowWays = false
					};
					UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
					return false;
				}
				return this.CanClickCallBack == null || this.CanClickCallBack();
			});
			uuiextendToggle.OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
			uuiextendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x00189750 File Offset: 0x00187950
	private void OnToggleStateChange(EToggleState state)
	{
		if (this.IsSuppressToggleCallback)
		{
			return;
		}
		if (state == EToggleState.ETT_Checked)
		{
			Action<int, UUIExtendToggle> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			int buffId = this.BuffId;
			ComBuffSubComponent comBuffIns = this.ComBuffIns;
			onClickCallBack(buffId, (comBuffIns != null) ? comBuffIns.GetBuffToggle() : null);
			return;
		}
		else
		{
			Action<int, UUIExtendToggle> onClickCallBack2 = this.OnClickCallBack;
			if (onClickCallBack2 == null)
			{
				return;
			}
			onClickCallBack2(0, null);
			return;
		}
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x001897A8 File Offset: 0x001879A8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.BuffId = data;
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(true);
		}
		if (gridIndex % 3 == 2)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
		}
		MutexGroupItem parentItem = this.ParentItem;
		bool flag = parentItem != null && parentItem.GetIsNecessary();
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (data <= 0)
		{
			ComBuffSubComponent comBuffIns = this.ComBuffIns;
			if (comBuffIns != null)
			{
				comBuffIns.SetLockActive(true);
			}
			ComBuffSubComponent comBuffIns2 = this.ComBuffIns;
			if (comBuffIns2 == null)
			{
				return;
			}
			comBuffIns2.SetToggleVisible(false);
			return;
		}
		else
		{
			BabelTowerDeTerm babelTowerDeTerm = BabelTowerConfig.Instance.GetBabelTowerDeTerm(data);
			ComBuffSubComponent comBuffIns3 = this.ComBuffIns;
			if (comBuffIns3 != null)
			{
				comBuffIns3.SetTextureByPath(babelTowerDeTerm.Texture);
			}
			IBabelTowerSelectInfo valueOrDefault = BabelTowerModel.Instance.DeTermSelectInfo.GetValueOrDefault(data);
			ComBuffSubComponent comBuffIns4 = this.ComBuffIns;
			if (comBuffIns4 == null)
			{
				return;
			}
			comBuffIns4.SetLockActive(valueOrDefault != null && valueOrDefault.State == EBabelTowerDeTermState.Lock);
			return;
		}
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x0018989F File Offset: 0x00187A9F
	[NullableContext(1)]
	public void SetCanClickCallBack(Func<bool> callback)
	{
		this.CanClickCallBack = callback;
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x001898A8 File Offset: 0x00187AA8
	private void OnUndeterminedClicked()
	{
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = true,
			ConfigId = this.BuffId,
			ShowWays = true
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x001898E8 File Offset: 0x00187AE8
	public void SetToggleState(EToggleState state)
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		UUIExtendToggle uuiextendToggle = (comBuffIns != null) ? comBuffIns.GetBuffToggle() : null;
		if (uuiextendToggle != null)
		{
			bool isSuppressToggleCallback = this.IsSuppressToggleCallback;
			this.IsSuppressToggleCallback = true;
			uuiextendToggle.SetToggleStateForce(state, false, false, false);
			this.IsSuppressToggleCallback = isSuppressToggleCallback;
		}
	}

	// Token: 0x0600489B RID: 18587 RVA: 0x0018992A File Offset: 0x00187B2A
	public void SuppressToggleCallback(bool suppress)
	{
		this.IsSuppressToggleCallback = suppress;
	}

	// Token: 0x0600489C RID: 18588 RVA: 0x00189933 File Offset: 0x00187B33
	public void UseChangeColor(bool use)
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		if (comBuffIns == null)
		{
			return;
		}
		comBuffIns.UseChangeColor(use);
	}

	// Token: 0x0600489D RID: 18589 RVA: 0x00189946 File Offset: 0x00187B46
	public void FlashHighlight()
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		if (comBuffIns == null)
		{
			return;
		}
		comBuffIns.FlashHighlight();
	}

	// Token: 0x04003663 RID: 13923
	public int BuffId;

	// Token: 0x04003664 RID: 13924
	public Action<int, UUIExtendToggle> OnClickCallBack;

	// Token: 0x04003665 RID: 13925
	private Func<bool> CanClickCallBack;

	// Token: 0x04003666 RID: 13926
	private MutexGroupItem ParentItem;

	// Token: 0x04003667 RID: 13927
	private ComBuffSubComponent ComBuffIns;

	// Token: 0x04003668 RID: 13928
	public bool IsSuppressToggleCallback;

	// Token: 0x020068AC RID: 26796
	[NullableContext(0)]
	private class EItemGroupSubComponent
	{
		// Token: 0x040227EA RID: 141290
		public const int ComBuff = 0;

		// Token: 0x040227EB RID: 141291
		public const int LineSprite = 1;

		// Token: 0x040227EC RID: 141292
		public const int Check = 2;

		// Token: 0x040227ED RID: 141293
		public const int Lock = 3;
	}
}
