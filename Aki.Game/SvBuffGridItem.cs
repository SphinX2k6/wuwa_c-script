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

// Token: 0x0200115A RID: 4442
[NullableContext(2)]
[Nullable(0)]
public class SvBuffGridItem : GridProxyAbstract<int>
{
	// Token: 0x060074FB RID: 29947 RVA: 0x00180AA8 File Offset: 0x0017ECA8
	[NullableContext(1)]
	public void SetParentItem(MutexGroupItem parent)
	{
		this.ParentItem = parent;
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x00180AB4 File Offset: 0x0017ECB4
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

	// Token: 0x060074FD RID: 29949 RVA: 0x00180B60 File Offset: 0x0017ED60
	protected override UniTask OnBeforeStartAsync()
	{
		SvBuffGridItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SvBuffGridItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x00180BA4 File Offset: 0x0017EDA4
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

	// Token: 0x060074FF RID: 29951 RVA: 0x00180C20 File Offset: 0x0017EE20
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

	// Token: 0x06007500 RID: 29952 RVA: 0x00180C78 File Offset: 0x0017EE78
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

	// Token: 0x06007501 RID: 29953 RVA: 0x00180D6F File Offset: 0x0017EF6F
	[NullableContext(1)]
	public void SetCanClickCallBack(Func<bool> callback)
	{
		this.CanClickCallBack = callback;
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x00180D78 File Offset: 0x0017EF78
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

	// Token: 0x06007503 RID: 29955 RVA: 0x00180DB8 File Offset: 0x0017EFB8
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

	// Token: 0x06007504 RID: 29956 RVA: 0x00180DFA File Offset: 0x0017EFFA
	public void SuppressToggleCallback(bool suppress)
	{
		this.IsSuppressToggleCallback = suppress;
	}

	// Token: 0x06007505 RID: 29957 RVA: 0x00180E03 File Offset: 0x0017F003
	public void UseChangeColor(bool use)
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		if (comBuffIns == null)
		{
			return;
		}
		comBuffIns.UseChangeColor(use);
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x00180E16 File Offset: 0x0017F016
	public void FlashHighlight()
	{
		ComBuffSubComponent comBuffIns = this.ComBuffIns;
		if (comBuffIns == null)
		{
			return;
		}
		comBuffIns.FlashHighlight();
	}

	// Token: 0x040035CA RID: 13770
	public int BuffId;

	// Token: 0x040035CB RID: 13771
	public Action<int, UUIExtendToggle> OnClickCallBack;

	// Token: 0x040035CC RID: 13772
	private Func<bool> CanClickCallBack;

	// Token: 0x040035CD RID: 13773
	private MutexGroupItem ParentItem;

	// Token: 0x040035CE RID: 13774
	private ComBuffSubComponent ComBuffIns;

	// Token: 0x040035CF RID: 13775
	public bool IsSuppressToggleCallback;

	// Token: 0x0200771E RID: 30494
	[NullableContext(0)]
	private class EItemGroupSubComponent
	{
		// Token: 0x040274AB RID: 160939
		public const int ComBuff = 0;

		// Token: 0x040274AC RID: 160940
		public const int LineSprite = 1;

		// Token: 0x040274AD RID: 160941
		public const int Check = 2;

		// Token: 0x040274AE RID: 160942
		public const int Lock = 3;
	}
}
