using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002493 RID: 9363
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleStaticItem : UiPanelBase
{
	// Token: 0x06012CD9 RID: 77017 RVA: 0x004A41A8 File Offset: 0x004A23A8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06012CDA RID: 77018 RVA: 0x004A4267 File Offset: 0x004A2467
	public void BindClickCallBack(Action callBack)
	{
		this.OnClickCallBack = callBack;
	}

	// Token: 0x06012CDB RID: 77019 RVA: 0x004A4270 File Offset: 0x004A2470
	private void OnClickToggle(EToggleState toggleState)
	{
		Action onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack();
	}

	// Token: 0x06012CDC RID: 77020 RVA: 0x004A4284 File Offset: 0x004A2484
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleStaticItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleStaticItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012CDD RID: 77021 RVA: 0x004A42C8 File Offset: 0x004A24C8
	public void RefreshSelectState(bool state, bool compareMode)
	{
		if (compareMode)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
			base.GetExtendToggle(0).SetSelfInteractive(false);
			return;
		}
		base.GetExtendToggle(0).SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		base.GetExtendToggle(0).SetSelfInteractive(true);
	}

	// Token: 0x06012CDE RID: 77022 RVA: 0x004A431C File Offset: 0x004A251C
	public void Refresh(int roleId)
	{
		foreach (VisionAssembleItem visionAssembleItem in this.AssembleItemList)
		{
			visionAssembleItem.Reset();
		}
		foreach (KeyValuePair<int, PhantomDataBase> keyValuePair in RoleModel.Instance.GetRoleDataById(roleId, true).GetPhantomData().GetDataMap())
		{
			PhantomDataBase value = keyValuePair.Value;
			if (value != null)
			{
				int key = keyValuePair.Key;
				if (key < this.AssembleItemList.Count)
				{
					this.AssembleItemList[key].Update(value.GetIncrId());
				}
			}
		}
	}

	// Token: 0x04008D90 RID: 36240
	private readonly List<VisionAssembleItem> AssembleItemList = new List<VisionAssembleItem>();

	// Token: 0x04008D91 RID: 36241
	[Nullable(2)]
	private Action OnClickCallBack;
}
