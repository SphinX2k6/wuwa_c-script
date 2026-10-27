using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001768 RID: 5992
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineAttributeSelectView : UiViewBase
{
	// Token: 0x0600AD9B RID: 44443 RVA: 0x00271367 File Offset: 0x0026F567
	public VisionRefineAttributeSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AD9C RID: 44444 RVA: 0x00271384 File Offset: 0x0026F584
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirm))
		};
	}

	// Token: 0x0600AD9D RID: 44445 RVA: 0x00271470 File Offset: 0x0026F670
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributeSelectView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributeSelectView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD9E RID: 44446 RVA: 0x002714B4 File Offset: 0x0026F6B4
	protected override void OnStart()
	{
		IRefineAttrSelectViewOpenParam refineAttrSelectViewOpenParam = this.OpenParam as IRefineAttrSelectViewOpenParam;
		this.IncId = refineAttrSelectViewOpenParam.IncId;
		this.CallbackConfirm = refineAttrSelectViewOpenParam.Callback;
		this.GetSelectedPropItemIdList = refineAttrSelectViewOpenParam.GetSelectedPropItemIdList;
		this.Selection = refineAttrSelectViewOpenParam.SelectAttribute;
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(this.IncId);
		AttrListScrollData attrListScrollData = phantomDataBase.GetMainPropShowAttributeList(CommonComponentDefine.EAttributeType.PhantomType, false)[0];
		int[] visionRefineRecommendAttributes = CalabashModel.Instance.GetVisionRefineRecommendAttributes(phantomDataBase.GetCost(), phantomDataBase.GetFetterGroupId());
		int[] phantomMainPropItemRefineAvailableIdList = PhantomBattleModel.Instance.GetPhantomMainPropItemRefineAvailableIdList(phantomDataBase.GetConfigId(false));
		List<IRefineAttrItemData> list = new List<IRefineAttrItemData>();
		int? chosenIndex = null;
		for (int i = 0; i < phantomMainPropItemRefineAvailableIdList.Length; i++)
		{
			int num = phantomMainPropItemRefineAvailableIdList[i];
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(num);
			RefineAttrItemData item = new RefineAttrItemData
			{
				PropItemId = num,
				PropIndexId = phantomMainPropertyItemId.PropId,
				IsRecommend = (refineAttrSelectViewOpenParam.DataConfirmed && visionRefineRecommendAttributes.Contains(phantomMainPropertyItemId.PropId)),
				IsDisable = (refineAttrSelectViewOpenParam.DataConfirmed && attrListScrollData.Id == phantomMainPropertyItemId.PropId)
			};
			list.Add(item);
			if (refineAttrSelectViewOpenParam.SelectAttribute != null && refineAttrSelectViewOpenParam.SelectAttribute.PropItemId == num)
			{
				chosenIndex = new int?(i);
			}
		}
		this.Attributes = list.ToArray();
		this.AttributeLayout.RefreshByData(this.Attributes, chosenIndex);
		this.RefreshTips();
	}

	// Token: 0x0600AD9F RID: 44447 RVA: 0x0027162D File Offset: 0x0026F82D
	protected override void OnBeforeShow()
	{
		this.RefreshConfirm();
	}

	// Token: 0x0600ADA0 RID: 44448 RVA: 0x00271635 File Offset: 0x0026F835
	private void RefreshConfirm()
	{
		if (this.Selection == null)
		{
			base.GetButton(1).SetSelfInteractive(false);
			return;
		}
		base.GetButton(1).SetSelfInteractive(true);
	}

	// Token: 0x0600ADA1 RID: 44449 RVA: 0x0027165C File Offset: 0x0026F85C
	private void RefreshTips()
	{
		if (this.GetSelectedPropItemIdList != null)
		{
			int[] array = this.GetSelectedPropItemIdList();
			IRefineAttrItemData selection = this.Selection;
			int? num = (selection != null) ? new int?(selection.PropItemId) : null;
			if (num != null && array.Length != 0)
			{
				int num2 = 0;
				foreach (int num3 in array)
				{
					int? num4 = num;
					if (num3 == num4.GetValueOrDefault() & num4 != null)
					{
						num2++;
					}
				}
				if (num2 > 0)
				{
					UUIItem item = base.GetItem(5);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Text_VisionRefine_CanRefineWithNumber_Text", new <>z__ReadOnlySingleElementList<object>(num2.ToString()));
					return;
				}
			}
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600ADA2 RID: 44450 RVA: 0x0027172F File Offset: 0x0026F92F
	private void OnClickConfirm()
	{
		if (this.CallbackConfirm != null)
		{
			this.CallbackConfirm(this.Selection);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600ADA3 RID: 44451 RVA: 0x00271751 File Offset: 0x0026F951
	private void OnClickAttribute(IRefineAttrItemData data)
	{
		this.Selection = data;
		this.RefreshConfirm();
		this.RefreshTips();
	}

	// Token: 0x04004EE8 RID: 20200
	private int IncId = -1;

	// Token: 0x04004EE9 RID: 20201
	[Nullable(2)]
	private IRefineAttrItemData Selection;

	// Token: 0x04004EEA RID: 20202
	private IRefineAttrItemData[] Attributes = new IRefineAttrItemData[0];

	// Token: 0x04004EEB RID: 20203
	[Nullable(2)]
	private AttributeSelectPanel AttributeLayout;

	// Token: 0x04004EEC RID: 20204
	[Nullable(2)]
	private Action<IRefineAttrItemData> CallbackConfirm;

	// Token: 0x04004EED RID: 20205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<int[]> GetSelectedPropItemIdList;

	// Token: 0x02007D5B RID: 32091
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290C5 RID: 168133
		ClearButton,
		// Token: 0x040290C6 RID: 168134
		ConfirmButton,
		// Token: 0x040290C7 RID: 168135
		BaseLayout,
		// Token: 0x040290C8 RID: 168136
		AttributeLayout,
		// Token: 0x040290C9 RID: 168137
		TitleText,
		// Token: 0x040290CA RID: 168138
		DownLeftRoot,
		// Token: 0x040290CB RID: 168139
		TipsText,
		// Token: 0x040290CC RID: 168140
		IconItem
	}
}
