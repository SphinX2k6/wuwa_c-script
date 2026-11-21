using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200168D RID: 5773
public class LordGymLordEntranceItem : GridProxyAbstract<int>
{
	// Token: 0x0600E0C0 RID: 57536 RVA: 0x0041F258 File Offset: 0x0041D458
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle))
		};
		if (this.OnToggleClick != null)
		{
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.<OnRegisterComponent>g__CallBack|5_0))
			};
		}
	}

	// Token: 0x0600E0C1 RID: 57537 RVA: 0x0041F2F4 File Offset: 0x0041D4F4
	protected override void OnStart()
	{
		if (this.CanExecuteChangeCallBack != null)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(delegate()
				{
					Func<int, bool> canExecuteChangeCallBack = this.CanExecuteChangeCallBack;
					return canExecuteChangeCallBack == null || canExecuteChangeCallBack(base.GridIndex);
				});
			}
		}
		this.StarLayout = new GenericLayout<LordGymLordStarItem, bool>(base.GetHorizontalLayout(1), new Func<LordGymLordStarItem>(this.CreateStarItem), null, false, true);
	}

	// Token: 0x0600E0C2 RID: 57538 RVA: 0x0041F350 File Offset: 0x0041D550
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.LordEntranceId = data;
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(this.LordEntranceId);
		if (lordGymEntranceConfig == null)
		{
			return;
		}
		int[] array = lordGymEntranceConfig.Value.LordGymList();
		if (array.Length == 0)
		{
			return;
		}
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(array[0]);
		if (lordGymConfig == null)
		{
			return;
		}
		LordGym value = lordGymConfig.Value;
		if (value.MonsterListLength == 0)
		{
			return;
		}
		MonsterInfo? config = ConfigMonsterInfoById.GetConfig(value.MonsterList(0), true);
		if (config == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Value.Name, Array.Empty<object>());
		base.SetTextureByPath(config.Value.BigIcon, base.GetTexture(2), null, null);
		List<bool> list = new List<bool>(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			list.Add(LordGymModel.Instance.GetLordGymIsFinish(array[i]));
		}
		GenericLayout<LordGymLordStarItem, bool> starLayout = this.StarLayout;
		if (starLayout != null)
		{
			starLayout.RefreshByData(list, null, false);
		}
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E0C3 RID: 57539 RVA: 0x0041F48D File Offset: 0x0041D68D
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600E0C4 RID: 57540 RVA: 0x0041F4A5 File Offset: 0x0041D6A5
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600E0C5 RID: 57541 RVA: 0x0041F4BD File Offset: 0x0041D6BD
	[NullableContext(1)]
	private LordGymLordStarItem CreateStarItem()
	{
		return new LordGymLordStarItem();
	}

	// Token: 0x0600E0C6 RID: 57542 RVA: 0x0041F4C4 File Offset: 0x0041D6C4
	public int GetLordEntranceId()
	{
		return this.LordEntranceId;
	}

	// Token: 0x0600E0C8 RID: 57544 RVA: 0x0041F4D4 File Offset: 0x0041D6D4
	[CompilerGenerated]
	private void <OnRegisterComponent>g__CallBack|5_0(EToggleState state)
	{
		Action<int> onToggleClick = this.OnToggleClick;
		if (onToggleClick == null)
		{
			return;
		}
		onToggleClick(base.GridIndex);
	}

	// Token: 0x040080D0 RID: 32976
	private int LordEntranceId;

	// Token: 0x040080D1 RID: 32977
	[Nullable(2)]
	public Action<int> OnToggleClick;

	// Token: 0x040080D2 RID: 32978
	[Nullable(2)]
	public Func<int, bool> CanExecuteChangeCallBack;

	// Token: 0x040080D3 RID: 32979
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<LordGymLordStarItem, bool> StarLayout;

	// Token: 0x0200786C RID: 30828
	private class EComponent
	{
		// Token: 0x0402714E RID: 160078
		public const int NameText = 0;

		// Token: 0x0402714F RID: 160079
		public const int StarLayout = 1;

		// Token: 0x04027150 RID: 160080
		public const int LordTexture = 2;

		// Token: 0x04027151 RID: 160081
		public const int ItemToggle = 3;
	}
}
