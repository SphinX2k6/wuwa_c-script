using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001763 RID: 5987
public class MotorcycleDiySkinObtainItem : UiPanelBase
{
	// Token: 0x0600E881 RID: 59521 RVA: 0x00442444 File Offset: 0x00440644
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

	// Token: 0x0600E882 RID: 59522 RVA: 0x004424F0 File Offset: 0x004406F0
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

	// Token: 0x0600E883 RID: 59523 RVA: 0x004425A8 File Offset: 0x004407A8
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

	// Token: 0x0400846C RID: 33900
	private int JumpId;

	// Token: 0x0400846D RID: 33901
	[Nullable(2)]
	public Action OnClickObtainBack;

	// Token: 0x0200794D RID: 31053
	private class EMotorDiySkinObtainItemComponent
	{
		// Token: 0x0402750E RID: 161038
		public const int BtnObtain = 0;

		// Token: 0x0402750F RID: 161039
		public const int HasAccessItem = 1;

		// Token: 0x04027510 RID: 161040
		public const int LockItem = 2;

		// Token: 0x04027511 RID: 161041
		public const int TxtAccess = 3;

		// Token: 0x04027512 RID: 161042
		public const int TxtLock = 4;
	}
}
