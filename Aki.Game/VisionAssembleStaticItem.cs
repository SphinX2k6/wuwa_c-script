using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200197A RID: 6522
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleStaticItem : UiPanelBase
{
	// Token: 0x0601019A RID: 65946 RVA: 0x004B1C98 File Offset: 0x004AFE98
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

	// Token: 0x0601019B RID: 65947 RVA: 0x004B1D57 File Offset: 0x004AFF57
	public void BindClickCallBack(Action callBack)
	{
		this.OnClickCallBack = callBack;
	}

	// Token: 0x0601019C RID: 65948 RVA: 0x004B1D60 File Offset: 0x004AFF60
	private void OnClickToggle(EToggleState toggleState)
	{
		Action onClickCallBack = this.OnClickCallBack;
		if (onClickCallBack == null)
		{
			return;
		}
		onClickCallBack();
	}

	// Token: 0x0601019D RID: 65949 RVA: 0x004B1D74 File Offset: 0x004AFF74
	protected override UniTask OnBeforeStartAsync()
	{
		VisionAssembleStaticItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionAssembleStaticItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601019E RID: 65950 RVA: 0x004B1DB8 File Offset: 0x004AFFB8
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

	// Token: 0x0601019F RID: 65951 RVA: 0x004B1E0C File Offset: 0x004B000C
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

	// Token: 0x04008ED9 RID: 36569
	private readonly List<VisionAssembleItem> AssembleItemList = new List<VisionAssembleItem>();

	// Token: 0x04008EDA RID: 36570
	[Nullable(2)]
	private Action OnClickCallBack;
}
