using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200227F RID: 8831
public class MotorcycleDiySkinObtainItem : UiPanelBase
{
	// Token: 0x060113EB RID: 70635 RVA: 0x00435838 File Offset: 0x00433A38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickObtain))
		};
	}

	// Token: 0x060113EC RID: 70636 RVA: 0x004358E4 File Offset: 0x00433AE4
	[NullableContext(1)]
	public void Refresh(IList<int> accessIdList)
	{
		if (accessIdList.Count <= 0)
		{
			return;
		}
		int num = accessIdList[0];
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(num);
		if (accessPathConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), accessPathConfig.Value.Description, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), accessPathConfig.Value.Description, Array.Empty<object>());
			ESkipName skipName = (ESkipName)accessPathConfig.Value.SkipName;
			base.GetItem(1).SetUIActive(skipName != ESkipName.NoSkip);
			base.GetItem(2).SetUIActive(skipName == ESkipName.NoSkip);
		}
		this.JumpId = num;
	}

	// Token: 0x060113ED RID: 70637 RVA: 0x0043599C File Offset: 0x00433B9C
	private void OnClickObtain()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		Action onClickObtainBack = this.OnClickObtainBack;
		if (onClickObtainBack != null)
		{
			onClickObtainBack();
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x0400832E RID: 33582
	private int JumpId;

	// Token: 0x0400832F RID: 33583
	[Nullable(2)]
	public Action OnClickObtainBack;

	// Token: 0x020087C4 RID: 34756
	private class EMotorDiySkinObtainItemComponent
	{
		// Token: 0x0402C1F6 RID: 180726
		public const int BtnObtain = 0;

		// Token: 0x0402C1F7 RID: 180727
		public const int HasAccessItem = 1;

		// Token: 0x0402C1F8 RID: 180728
		public const int LockItem = 2;

		// Token: 0x0402C1F9 RID: 180729
		public const int TxtAccess = 3;

		// Token: 0x0402C1FA RID: 180730
		public const int TxtLock = 4;
	}
}
